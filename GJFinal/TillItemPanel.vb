Public Class TillItemPanel

    ' This panel will be part of the Admin form

    Dim currentItemID As String
    Dim itemAutocompleteSource As AutoCompleteStringCollection

    Public Sub Init()
        reloadItemAutocompleteSource()
    End Sub

    Private Sub SaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get the record of the current customer being edited
        Dim itemQuery = SearchTable(itemTable, Function(r As Item)
                                                   Return r.ItemID = currentItemID
                                               End Function)

        For Each txtbox In {ItemNameTxt, ItemCategoryTxt, ItemSalesTxt, ItemPriceTxt}
            ' Stop blank entries
            If txtbox.Text = "" Then
                MsgBox("Please ensure all fields are filled in")
                Return
            End If
        Next

        ' Handle price formatting
        For Each txtbox In {ItemSalesTxt, ItemPriceTxt}
            ' The price must be at least 2 characters (£d)
            If txtbox.Text.Length <= 2 Then
                MsgBox("Please check prices entered")
                Return
            End If

            ' Make sure price starts with a £
            If Not txtbox.Text.Substring(0, 1) = "£" Then
                MsgBox("Please include £ sign before any prices.")
                Return
            End If

            ' Make sure the number after the £ is valid
            Dim result = 0
            If Not Single.TryParse(txtbox.Text.Substring(1), result) Then
                MsgBox("Please ensure any prices inputted are valid")
                Return
            End If
        Next


        If (itemQuery.Length > 0) Then
            ' Item does exist, so update the item
            Dim item = itemQuery(0)

            If Not ItemNameTxt.Text = "Enter item name..." Then

                ' Edit the item to reflect the newly entered data
                EditTableMember(itemTable, item, Function(i As Item)
                                                     i.ItemName = ItemNameTxt.Text
                                                     i.ItemCategory = ItemCategoryTxt.Text
                                                     i.ItemSales = CSng(ItemSalesTxt.Text.Substring(1))
                                                     i.ItemPrice = CSng(ItemPriceTxt.Text.Substring(1))
                                                     Return True
                                                 End Function)

                ' reload the autocomplete (the name could have changed)
                reloadItemAutocompleteSource()
            Else
                MsgBox("Please enter a name and category for the item.")
            End If

        ElseIf itemAddMode Then
            ' Item doesn't exist, so add to the database
            Dim newItem As New Item() With {.ItemID = currentItemID, .ItemName = ItemNameTxt.Text, .ItemCategory = ItemCategoryTxt.Text, _
                                            .ItemSales = CSng(ItemSalesTxt.Text.Substring(1)), .ItemPrice = CSng(ItemPriceTxt.Text.Substring(1))}

            ' add to the autocomplete so it is accessible
            itemAutocompleteSource.Add(ItemNameTxt.Text)

            ' add new item to table
            AddToTable(itemTable, newItem)
            MsgBox("Item added")

            ' go back to item editing mode
            itemAddMode = False
            Return
        Else
            MsgBox("Item does not exist.")
        End If

        MsgBox("Item saved")
    End Sub

    Dim itemAddMode = False
    Private Sub AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Keep track of whether the current item is a new one, so we know whether to create
        ' a new record or update an old one when Save is pressed
        itemAddMode = True

        ' Get a list of all items in the database
        Dim itemQuery = SearchTable(itemTable, Function(r As Item)
                                                   Return True
                                               End Function)

        ' Find the highest current ID
        Dim maxID = 0
        For Each i In itemQuery
            If CInt(i.ItemID) > maxID Then
                maxID = CInt(i.itemID)
            End If
        Next

        ' Add one and make it the ID of this item
        Dim newID = CStr(maxID + 1)

        ' Set up form inputs to defaults
        currentItemID = newID
        ItemNameTxt.Text = "Enter item name..."
        ItemCategoryTxt.Text = "Enter category..."
        ItemPriceTxt.Text = "£0.00"
        ItemSalesTxt.Text = "£0.00"

    End Sub

    

    Private Sub ItemNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNameTxt.TextChanged
        ' This function will be called when the itemnametxt box changes (so when the user types in a letter,
        ' or when an item is autocompleted - which is what we are interested in).

        ' Only look the item up if it has been autocompleted (or at least if it exists in the autocomplete strings):
        If itemAutocompleteSource.Contains(ItemNameTxt.Text) Then

            ' Find the record of the item in question
            Dim itemQuery = SearchTable(itemTable, Function(r As Item)
                                                       Return r.ItemName = ItemNameTxt.Text
                                                   End Function)

            ' Fill in the data from this item onto the form
            If (itemQuery.Length > 0) Then
                Dim item = itemQuery(0)

                ' Fill in the data from this item onto the form
                ItemNameTxt.Text = item.ItemName
                ItemCategoryTxt.Text = item.ItemCategory
                ItemPriceTxt.Text = "£" & CStr(FormatNumber(item.ItemPrice, 2))
                ItemSalesTxt.Text = "£" & CStr(FormatNumber(item.ItemSales, 2))
                currentItemID = item.ItemID

                ' Set whether the item should add a new stock entry, or view an existing one
                ' based on whether it already has a stock record or not.
                If item.StockID Is Nothing Then
                    AddOrViewStock.Text = "Add Stock Entry For This Item"
                Else
                    AddOrViewStock.Text = "View Stock Entry For This Item"
                End If
            Else
                MsgBox("No item found")
            End If
        End If
    End Sub

    Private Sub AddOrViewStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrViewStock.Click
        If Not itemAutocompleteSource.Contains(ItemNameTxt.Text) Then
            MsgBox("Item does not exist.")
            Return
        End If

        Dim itemHasBeenAdded = False
        If AddOrViewStock.Text = "Add Stock Entry For This Item" Then
            ' Get the record of the current item being edited
            Dim itemQuery = SearchTable(itemTable, Function(r As Item)
                                                       Return r.ItemName = ItemNameTxt.Text
                                                   End Function)



            ' AddItem returns the new stockID
            Dim newStockID = StockControl.AddItem(ItemNameTxt.Text)

            ' Set the StockID of the record to this new stockID
            EditTableMember(itemTable, itemQuery(0), Function(record As Item)
                                                         record.StockID = newStockID
                                                         Return False
                                                     End Function)

            ' Set the form up to show "View" instead of Add
            AddOrViewStock.Text = "View Stock Entry For This Item"
            itemHasBeenAdded = True

        ElseIf Not itemHasBeenAdded Then
            ' Get the record of the current item being edited
            Dim itemQuery = SearchTable(itemTable, Function(r As Item)
                                                       Return r.ItemName = ItemNameTxt.Text
                                                   End Function)

            ' Show the stock for this item's StockID
            AdminForm.OpenStockControlForm(itemQuery(0).StockID)
        End If
    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItem.Click

        ' Ensure that the item to be deleted exists
        If itemAutocompleteSource.Contains(ItemNameTxt.Text) Then

            ' Get the record of the item to be deleted
            Dim item As Item = SearchTable(itemTable, Function(r As Item)
                                                          Return r.ItemID = currentItemID
                                                      End Function)(0)

            ' remove the item from the table
            DeleteFromTable(itemTable, item)

            ' if the item has a stock record, delete that too.
            If Not item.StockID = Nothing Then

                Dim stockQuery = SearchTable(stockTable, Function(r As StockItem)
                                                             Return r.StockID = item.StockID
                                                         End Function)

                If stockQuery.Length > 0 Then
                    Dim stock As StockItem = stockQuery(0)

                    DeleteFromTable(stockTable, stock)
                End If
            End If

            ' reset the form to blank text boxes
            MsgBox("Item Deleted")
            itemAutocompleteSource.Remove(ItemNameTxt.Text)
            ItemNameTxt.Text = ""
            ItemCategoryTxt.Text = ""
            ItemPriceTxt.Text = ""
            ItemSalesTxt.Text = ""
        Else
            MsgBox("Item does not exist.")
        End If



    End Sub



    Private Sub reloadItemAutocompleteSource()
        ' Create autocomplete for items:
        itemAutocompleteSource = New AutoCompleteStringCollection()

        ' search every item in the database and add their names
        ' to the itemAutocompleteSource
        Dim itemNames As List(Of String) = New List(Of String)

        SearchTable(itemTable, Function(r As Item)
                                   itemNames.Add(r.ItemName)
                                   Return False
                               End Function)

        itemAutocompleteSource.AddRange(itemNames.ToArray())

        ' Setting up the autocomplete on the textbox to use my custom source
        ItemNameTxt.AutoCompleteCustomSource = itemAutocompleteSource
        ItemNameTxt.AutoCompleteMode = AutoCompleteMode.Suggest
        ItemNameTxt.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

End Class
