Public Class TillForm

    Dim refundMode = False
    Dim timeClockedIn As DateTime
    Dim clockedIn = False
    Dim orderItems() As OrderPanelItem

    Private Sub TillForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Setting up color scheme:
        Me.BackColor = Color.FromArgb(196, 221, 181)

        Dim color1 = Color.FromArgb(135, 122, 112)
        Dim color2 = Color.FromArgb(51, 51, 51)

        ' Go through each button in the form
        ' and set to the correct style
        For Each cont In Me.Controls
            If TypeOf cont Is Button Then
                cont.FlatStyle = FlatStyle.Flat
                cont.FlatAppearance.BorderColor = color1
                cont.ForeColor = color1
            End If
        Next

        ' Initialise the till
        Initialise()
    End Sub

    ' Initialise the form when the form is loaded, and when it is reshown after the admin panel is used
    ' this means changes made in the admin form are put into immediate effect
    Private Sub Initialise()
        ' The staffID is stored by the GJDatabaseHelper module, which is accessible to all forms
        LoggedInLabel.Text = "Currently logged in as: " & GetStaffID()

        RepopulateItemPanel()
        ' Initalise order item array
        orderItems = {}

        ' allow vertical scrolling on Order Panel
        OrderPanel.AutoScroll = True
        OrderPanel.WrapContents = False

    End Sub

    Public Sub RepopulateItemPanel()

        ' Loop through each tab page in the till item panel and clear it:
        For Each TillTabPage In ButtonsControl.TabPages

            For Each control In TillTabPage.Controls
                If TypeOf control Is Button Then
                    Dim button As Button = control
                    ' Remove any existing handlers from the old buttons
                    RemoveHandler button.Click, AddressOf TillButtonClicked
                End If
            Next

            ' Remove the tab page itself
            ButtonsControl.Controls.Remove(TillTabPage)
        Next

        ' This code gets a list of all the item category names so that we can generate the new tab pages
        Dim itemCategories = New List(Of String)
        SearchTable(itemTable, Function(r As Item)
                                   ' add to categories list if not already in there
                                   If Not itemCategories.Contains(r.ItemCategory) Then
                                       itemCategories.Add(r.ItemCategory)
                                   End If
                                   ' We don't want to return any records
                                   Return False
                               End Function)

        ' Loop through the categories we just found
        For Each itemCategory In itemCategories

            ' Set up the new tab page for this category
            Dim newTabPage = New TabPage()
            newTabPage.Text = itemCategory
            newTabPage.BackColor = Color.White


            Dim category = itemCategory
            ' Get all the items in this category
            Dim itemsInThisCategory = SearchTable(itemTable, Function(r As Item)
                                                                 ' we want the item to be returned if the item category 
                                                                 ' of the record matches the item category of this tabpage
                                                                 Return r.ItemCategory = category
                                                             End Function)

            ' Keep track of which item we are adding
            Dim count = 0

            ' Loop through and add each item to the tabpage
            For Each item In itemsInThisCategory
                Dim width = 100
                Dim height = 60
                ' 4 items per row, also add 15px padding
                Dim x_pos = 15 + (count Mod 5) * (width + 15)
                Dim y_pos = 15 + (count \ 5) * (height + 15)

                ' I add the itemId as a tag to the button so that when it calls the .Click event when it is clicked
                ' the method that is called can use sender.Tag to find which item has been ordered
                Dim tag = item.ItemID

                Dim newButton As New Button With {.Width = width, .Height = height, _
                                          .Location = New Point(x_pos, y_pos), _
                                          .Tag = tag, .Text = item.ItemName}

                ' Add handler for the onclick event of the button:
                AddHandler newButton.Click, AddressOf TillButtonClicked

                ' Add button to the tab page
                newTabPage.Controls.Add(newButton)

                count += 1
            Next

            ' Set the width and height to the correct values and then add.
            newTabPage.Width = 525
            newTabPage.Height = 303
            ButtonsControl.TabPages.Add(newTabPage)
        Next
        Me.Show()
    End Sub

    Private Sub TillFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If clockedIn Then
            ' If the user is clocked in, they should first be clocked out
            ClockOutButton.PerformClick()
        End If

        ' If the user has pressed the X button, show the splashscreen, otherwise just hide the form
        If e.CloseReason = CloseReason.UserClosing Then
            Me.Hide()
            SplashScreen.Show()
        Else
            Me.Hide()
        End If

    End Sub

    Private Sub TillButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' the tag property of the button will contain the ItemID which is represents:
        Dim ID As String = sender.Tag

        ' Find the record corresponding to the clicked item
        Dim record = SearchTable(itemTable, Function(i As Item) As Boolean
                                                Return i.ItemID = ID
                                            End Function)(0)




        Dim currentPrice As Single = CSng(SubTotal.Text.Substring(1))
        Dim newPrice As Single = currentPrice + record.ItemPrice

        ' always display to 2 d.p
        SubTotal.Text = "£" & FormatNumber(newPrice, 2)


        ' Add to the order panel
        Dim itemAlreadyInOrder = False
        For Each orderItem In orderItems

            If Not itemAlreadyInOrder Then
                If ID = orderItem.itemID Then

                    ' If the item is already in the order, simulate a click on the order item
                    ' Add button (reduces repeated code for adding the item to the order).
                    OrderPanelItemAddButtonCallback(orderItem)
                    itemAlreadyInOrder = True
                End If
            End If

        Next

        If Not itemAlreadyInOrder Then

            ' Create a new item with the required properties
            Dim newItem As OrderPanelItem = New OrderPanelItem(ID) With {.ItemName = record.ItemName,
                                                                 .SubTotalString = "£" + CStr(FormatNumber(record.ItemPrice, 2)),
                                                                         .AddButtonCallback = AddressOf OrderPanelItemAddButtonCallback,
                                                                         .SubtractButtonCallback = AddressOf OrderPanelItemSubtractButtonCallback,
                                                                         .DeleteButtonCallback = AddressOf OrderPanelItemDeleteButtonCallback}

            ' Resize the array ready to fit the new item
            Array.Resize(orderItems, orderItems.Length + 1)
            ' Add the new item to the array
            orderItems(orderItems.Length - 1) = newItem
            ' Add the new item to the OrderPanel
            OrderPanel.Controls.Add(newItem)

        End If

    End Sub

    Public Function OrderPanelItemAddButtonCallback(ByVal senderItem As OrderPanelItem) As Boolean

        ' This function will be called when the "Add" Button is pressed on an OrderPanelItem

        ' Increment the ItemCount by 1
        senderItem.ItemCount += 1
        Dim id = senderItem.itemID

        ' Find the record of the item in question in the database
        Dim record = SearchTable(itemTable, Function(i As Item) As Boolean
                                                Return i.ItemID = id
                                            End Function)(0)


        Dim itemPrice = record.ItemPrice
        Dim senderSubtotal = senderItem.SubTotalString

        ' Increment the subtotal of the order item
        Dim newSubtotal = CDbl(senderSubtotal.Substring(1)) + itemPrice

        ' Set this new subtotal
        senderItem.SubTotalString = "£" + CStr(FormatNumber(newSubtotal, 2))

        Dim currentPrice As Single = CSng(SubTotal.Text.Substring(1))
        Dim newPrice As Single = currentPrice + record.ItemPrice

        ' Add the new amount of money to the main subtotal label
        ' always display to 2 d.p
        SubTotal.Text = "£" & FormatNumber(newPrice, 2)

        Return False
    End Function

    Public Function OrderPanelItemSubtractButtonCallback(ByVal senderItem As OrderPanelItem) As Boolean

        ' This function will be called when the "Subtract" Button is pressed on an OrderPanelItem

        ' The value should not become negative so this ensures it doesn't
        If senderItem.ItemCount > 0 Then
            senderItem.ItemCount -= 1
            Dim id = senderItem.itemID

            ' Search for the item in question in the database
            Dim record = SearchTable(itemTable, Function(i As Item) As Boolean
                                                    Return i.ItemID = id
                                                End Function)(0)

            ' Calculate a new subtotal value for the orderitem:
            Dim itemPrice = record.ItemPrice
            Dim senderSubtotal = senderItem.SubTotalString
            Dim newSubtotal = CDbl(senderSubtotal.Substring(1)) - itemPrice

            ' Set the subtotal of the orderitem to this new subtotal string
            senderItem.SubTotalString = "£" + CStr(FormatNumber(newSubtotal, 2))

            ' Add the new cost to the main till form subtotal label
            Dim currentPrice As Single = CSng(SubTotal.Text.Substring(1))
            Dim newPrice As Single = currentPrice - record.ItemPrice

            ' always display to 2 d.p
            SubTotal.Text = "£" & FormatNumber(newPrice, 2)
        End If

        Return False
    End Function

    Public Function OrderPanelItemDeleteButtonCallback(ByVal senderItem As OrderPanelItem) As Boolean

        ' This function will be called when the "Delete" Button is pressed on an OrderPanelItem

        ' Create a new orderItem list with 1 less item
        Dim newOrderItemList(orderItems.Length - 2) As OrderPanelItem

        Dim count = 0
        ' Iterate through each item in the orderItemPanel
        For Each orderItem In orderItems
            If Not (orderItem.itemID = senderItem.itemID) Then
                ' If it isn't the one we want to delete, just add it to the new list
                newOrderItemList(count) = orderItem
                ' increment the count
                count += 1
            Else
                ' if it is the one we want to delete, remove it
                OrderPanel.Controls.Remove(orderItem)

                ' substract the price of the item from the till subtotal:
                Dim priceToRemove = CDbl(orderItem.SubTotalString.Substring(1))

                Dim currentPrice As Single = CSng(SubTotal.Text.Substring(1))
                Dim newPrice As Single = currentPrice - priceToRemove

                ' always display to 2 d.p
                SubTotal.Text = "£" & FormatNumber(newPrice, 2)
            End If
        Next

        ' set the orderItem list to this new orderItem list
        orderItems = newOrderItemList

        Return False
    End Function

    Private Sub AdminButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminButton.Click
        ' Get the record of the current staff member
        Dim staffQuery = SearchTable(staffTable, Function(r As StaffMember)
                                                     Return r.StaffID = GetStaffID()
                                                 End Function)
        Dim currentStaff As StaffMember = staffQuery(0)

        ' Ensure they're an admin before showing the admin form
        If currentStaff.Admin Then

            AdminForm.Show()
        Else
            MsgBox("Admin privileges required.")
        End If

    End Sub

    Private Sub ClockInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockInButton.Click
        ' Keep track of when the user clocked in (will be used later)
        timeClockedIn = DateTime.UtcNow()
        clockedIn = True

        ' ADDED:
        MsgBox("Staff member clocked in at: " + timeClockedIn.ToString("HH:mm"))
    End Sub


    Private Sub ClockOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockOutButton.Click
        
        If clockedIn Then
            Dim timeClockedOut = DateTime.UtcNow()

            ' Calculate the amount of time spent clocked in
            Dim timeWorked = timeClockedOut - timeClockedIn


            ' Get the details of the currently logged in user
            Dim staffQuery = SearchTable(staffTable, Function(r As StaffMember)
                                                         Return r.StaffID = GetStaffID()
                                                     End Function)

            Dim currentStaff As StaffMember = staffQuery(0)

            ' Get the PayrollID for the current user, in order to access their payroll
            ' record to add the hours.
            Dim payrollID As Guid = currentStaff.PayrollID

            ' Get the payroll record for the current user, from their payroll ID
            Dim payrollQuery = SearchTable(payrollTable, Function(r As PayrollMember)
                                                             Return r.PayrollID = payrollID
                                                         End Function)

            Dim record = payrollQuery(0)

            ' Add the hours to the record
            EditTableMember(payrollTable, record, Function(r As PayrollMember)
                                                      r.MonthHours += timeWorked.TotalHours
                                                      Return True
                                                  End Function)

            ' Show message so that the user knows they have clocked out successfully.
            Dim message = ""
            message += "Staff member clocked out at: " + timeClockedOut.ToString("HH:mm")
            message += vbNewLine
            message += "A total of " + FormatNumber(timeWorked.TotalHours, 2) + " hours were worked."

            MsgBox(message)

            clockedIn = False

        Else
            'ADDED:
            MsgBox("Staff member not yet clocked in!")
        End If

    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        ' Show the splash screen when "Quit" is clicked
        SplashScreen.Show()
        SplashScreen.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub TillForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ' Set up till data
        Initialise()
    End Sub


    Private Sub StockControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockControlButton.Click
        StockControl.Show()
        StockControl.fromAdminForm = False
    End Sub

    Private Sub FinishOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishOrderButton.Click
        For Each orderItem In orderItems

            Dim id = orderItem.itemID
            ' Find the record of the orderItem
            Dim record = SearchTable(itemTable, Function(i As Item) As Boolean
                                                    Return i.ItemID = id
                                                End Function)(0)

            ' Add the correct number of sales to the record
            Dim itemCount = orderItem.ItemCount
            EditTableMember(itemTable, record, Function(r As Item)
                                                   ' Add the amount of money for this record
                                                   r.ItemSales += itemCount * r.ItemPrice
                                                   Return True
                                               End Function)

            ' Add one to stock.
            If record.StockID IsNot Nothing Then
                StockControl.SubtractFromStock(record.StockID, orderItem.ItemCount)
            End If

            ' Remove from the Order Panel
            OrderPanel.Controls.Remove(orderItem)

        Next

        ' Reset the till interface
        orderItems = {}
        SubTotal.Text = "£0.00"
    End Sub

    Private Sub CancelOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelOrderButton.Click
        SubTotal.Text = "£0.00"

        ' Remove all of the order items
        For Each orderItem In orderItems
            OrderPanel.Controls.Remove(orderItem)

        Next

        orderItems = {}
    End Sub
End Class