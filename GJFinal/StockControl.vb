Public Class StockControl

    Dim stockAutocompleteSource As AutoCompleteStringCollection
    Dim currentStockID As String
    Public fromAdminForm As Boolean = False

    Dim isFormLoaded = False

    Private Sub StockControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create autocomplete for stock:
        stockAutocompleteSource = New AutoCompleteStringCollection()

        Dim stockNames(stockTable.Length - 1) As String

        ' Iterate over each stockitem and add its name to the autocomplete strings
        For i = 0 To stockTable.Length - 1
            stockNames(i) = stockTable(i).StockName
        Next

        stockAutocompleteSource.AddRange(stockNames)

        ' Setting up the autocomplete on the textbox to use my custom source
        StockNameTxt.AutoCompleteCustomSource = stockAutocompleteSource
        StockNameTxt.AutoCompleteMode = AutoCompleteMode.Suggest
        StockNameTxt.AutoCompleteSource = AutoCompleteSource.CustomSource

        isFormLoaded = True
    End Sub

    ' when the user closes this form, we want to go back to where we came from
    Private Sub StockFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        ' Simulate a back press when closing to save repeating code
        If e.CloseReason = CloseReason.UserClosing Then
            BackButton.PerformClick()
        End If
    End Sub

    ' Called by the admin form when the user asks to add an item
    ' returns the new stock ID of the added item
    Public Function AddItem(ByVal newName As String) As String
        Dim newStockID As String
        Dim highestID As Integer = 0
        ' Go through each stock and see if the ID is higher, if so, set highestID to that stock's ID
        SearchTable(stockTable, Function(r As StockItem)
                                    If CInt(r.StockID) > highestID Then
                                        highestID = CInt(r.StockID)
                                    End If
                                    Return True
                                End Function)

        ' add one to the highest ID and use it as the new one
        newStockID = CStr(highestID + 1)
        currentStockID = newStockID

        ' Set up the form text boxes
        StockNameTxt.Text = newName
        StockLevelTxt.Text = 0
        MinStockLevelTxt.Text = 0

        ' Create a new stock record with the appropriate data
        Dim newStock = New StockItem With {.StockID = currentStockID, .StockName = StockNameTxt.Text, _
                                               .StockLevel = CInt(StockLevelTxt.Text), _
                                               .MinStockLevel = CInt(MinStockLevelTxt.Text)}

        ' Ensure that the form is loaded before doing this, as it could cause a crash otherwise
        ' (stockAutocompletesource is initialised in the form constructor)
        If isFormLoaded Then
            stockAutocompleteSource.Add(StockNameTxt.Text)
        End If



        ' add this new stock member to the stock table
        AddToTable(stockTable, newStock)

        ' Return the new stock id in case other forms need to use it
        Return newStockID
    End Function

    ' Called by till form when user wants to view an item's stock record.
    Public Sub ViewItem(ByVal stockID As String)
        currentStockID = stockID

        ' find the requested stock record
        Dim stockQuery = SearchTable(stockTable, Function(r As StockItem)
                                                     Return r.StockID = currentStockID
                                                 End Function)

        ' fill in the text boxes with the data from this record (if it exists)
        If stockQuery.Length > 0 Then
            Dim stock = stockQuery(0)
            StockNameTxt.Text = stock.StockName
            StockLevelTxt.Text = stock.StockLevel
            MinStockLevelTxt.Text = stock.MinStockLevel
        End If
        
    End Sub

    Private Sub SaveStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStock.Click

        ' Ensure text boxes are not blank
        For Each txtbox In {StockNameTxt, StockLevelTxt, MinStockLevelTxt}
            If txtbox.Text = "" Then
                MsgBox("Please fill out all fields")
                Return
            End If
        Next

        ' Ensure integer inputs are valid integers
        For Each txtbox In {StockLevelTxt, MinStockLevelTxt}
            Dim a = 0
            If Not Integer.TryParse(txtbox.Text, a) Then
                MsgBox("Please ensure stock level/minimum stock level entry is an integer")
                Return
            ElseIf a < 0 Then
                ' Ensures integer inputs are nonnegative
                MsgBox("Please ensure fields are not negative.")
                Return
            End If
        Next

        ' Find the stock record of the currently viewed item
        Dim stockQuery = SearchTable(stockTable, Function(r As StockItem)
                                                     Return r.StockID = currentStockID
                                                 End Function)

        If stockQuery.Length > 0 Then
            Dim stock = stockQuery(0)

            ' Set the data for the record to the data that has been inputted
            ' by the user (effectively saving it)
            EditTableMember(stockTable, stock, Function(r As StockItem)
                                                   r.StockName = StockNameTxt.Text
                                                   r.StockLevel = CInt(StockLevelTxt.Text)
                                                   r.MinStockLevel = CInt(MinStockLevelTxt.Text)
                                                   Return True
                                               End Function)

            MsgBox("Stock item saved.")
        Else
            MsgBox("Stock does not exist.")
        End If



    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click

        ' reset form text boxes
        StockNameTxt.Text = ""
        StockLevelTxt.Text = ""
        MinStockLevelTxt.Text = ""

        ' hide self and return to the admin form if necessary
        Me.Hide()
        If fromAdminForm Then
            AdminForm.Show()
        End If
    End Sub

    Public Sub SubtractFromStock(ByVal stockID As String, ByVal amount As Integer)

        ' Find the requested stock item
        Dim query = SearchTable(stockTable, Function(r As StockItem)
                                                Return r.StockID = stockID
                                            End Function)

        ' if it exists:
        If query.Length > 0 Then
            Dim record = query(0)

            ' pass anonymous function to subtract from the stock
            EditTableMember(stockTable, record, Function(r As StockItem)
                                                    r.StockLevel -= amount

                                                    ' warn user if stock is reaching a low level as defined by the
                                                    ' minstocklevel
                                                    If r.StockLevel <= r.MinStockLevel Then
                                                        MsgBox("Stock levels low, please order more of " + r.StockName)
                                                    End If

                                                    Return True
                                                End Function)
        End If

        
    End Sub

    ' Automatically display the record when the user finishes typing/autocompletes a search
    Private Sub StockNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockNameTxt.TextChanged
        ' Ensure form has loaded first
        If Not isFormLoaded Then
            Return
        End If

        If stockAutocompleteSource.Contains(StockNameTxt.Text) Then

            ' Get the record of the current customer being edited

            Dim stockQuery = SearchTable(stockTable, Function(r As StockItem)
                                                         Return r.StockName = StockNameTxt.Text
                                                     End Function)

            ' set the form text boxes to the data from the newly loaded record
            Dim stock = stockQuery(0)
            StockNameTxt.Text = stock.StockName
            StockLevelTxt.Text = stock.StockLevel
            MinStockLevelTxt.Text = stock.MinStockLevel

            ' Keep track of the currently viewed StockID
            currentStockID = stock.StockID

        End If
    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItem.Click

        ' Ensure the item exists first
        If Not stockAutocompleteSource.Contains(StockNameTxt.Text) Then
            MsgBox("Stock item does not exist.")
            Return
        End If

        ' Delete item from the table (given that it exists).
        DeleteFromTable(stockTable, SearchTable(stockTable, Function(r As StockItem)
                                                                Return r.StockID = currentStockID
                                                            End Function)(0))

        ' Reset the form inputs to blank and remove the item from the autocomplete
        stockAutocompleteSource.Remove(StockNameTxt.Text)
        StockNameTxt.Text = ""
        StockLevelTxt.Text = ""
        MinStockLevelTxt.Text = ""

        currentStockID = ""

        MsgBox("Stock deleted")

    End Sub
End Class