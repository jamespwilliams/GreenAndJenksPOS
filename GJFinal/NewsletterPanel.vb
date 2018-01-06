Public Class NewsletterPanel
    ' Keeps a list of the customers returned by the search query so they can be iterated upon and edited.
    Dim customerQueryResults As TableMember()

    Dim currentNewsletterIndex As Integer

    Public Sub Init()
        customerQueryResults = newsletterTable
        currentNewsletterIndex = -1
        ShiftNewsletterRecord(True)

        ' Load the newsletter records
        NewsletterSearchButton.PerformClick()
    End Sub

    Private Sub NewsletterSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' By default, search through all customers
        Dim searchFunction = Function(r As Customer)
                                 Return True
                             End Function

        ' Add the where clauses if the text boxes for the relevant fields aren't empty:
        If Not CustomerIDTxt.Text = "" Then

            ' If the customerIDTxt textbox is not empty:
            ' Add a where clause, which is a function that checks if the record's customer ID matches
            ' the customer ID the user typed in
            ' If this anonymous function returns true when called by the linq system, the record is
            ' returned. This means that the records returned would have to have matching CustomerIDs (which we want)
            searchFunction = Function(r As Customer)
                                 ' Return all
                                 Return r.CustomerID = CustomerIDTxt.Text
                             End Function

        End If

        ' Check to see which text box the search should be performed upon
        If Not CustomerTitleTxt.Text = "" Then searchFunction = Function(cust As Customer) cust.Title = CustomerTitleTxt.Text
        If Not CustomerInitialTxt.Text = "" Then searchFunction = Function(cust As Customer) cust.Initial = CustomerInitialTxt.Text
        If Not CustomerSurnameTxt.Text = "" Then searchFunction = Function(cust As Customer) cust.Surname = CustomerSurnameTxt.Text
        If Not CustomerAddressTxt.Text = "" Then searchFunction = Function(cust As Customer) cust.Address = CustomerAddressTxt.Text
        If Not CustomerPostcodeTxt.Text = "" Then searchFunction = Function(cust As Customer) cust.Postcode = CustomerPostcodeTxt.Text

        customerQueryResults = SearchTable(newsletterTable, searchFunction)
        ' -1 so that it goes to 0 when the nextnewsletterrecord subroutine is called
        currentNewsletterIndex = -1
        ShiftNewsletterRecord(True)

    End Sub

    ' ex. ShiftNewsletterRecord(True) moves to the next record
    ' ShiftNewsletterRecord(False) moves to the previous record

    Private Sub ShiftNewsletterRecord(ByVal forward As Boolean)

        If forward And currentNewsletterIndex = customerQueryResults.Length - 1 Then
            ' If the index would overflow (if we are moving forwards but already on the
            ' last record)
            ' wrap around to the start
            currentNewsletterIndex = 0

        ElseIf (Not forward) And currentNewsletterIndex = 0 Then
            ' Else If the index would overflow backwards (if the shift is backwards and we are
            ' already on the last record:
            ' wrap around to the end
            currentNewsletterIndex = customerQueryResults.Length - 1

        ElseIf forward Then
            ' If there are no overflows and we're moving forward, we can just add one to the index.
            currentNewsletterIndex += 1
        ElseIf Not forward Then
            ' If there are no overflows and we're moving backwards, we can just subtract one from the index.
            currentNewsletterIndex -= 1
        End If

        ' If there is a customer to display (should always be the case, but ensures no crashing)
        If customerQueryResults.Length <> 0 Then

            ' Get a reference to the new customer to be displayed
            Dim currentCustomer As Customer = customerQueryResults(currentNewsletterIndex)

            ' Fill their details into the text boxes on the form
            CustomerIDTxt.Text = currentCustomer.CustomerID
            CustomerTitleTxt.Text = currentCustomer.Title
            CustomerInitialTxt.Text = currentCustomer.Initial
            CustomerSurnameTxt.Text = currentCustomer.Surname
            CustomerAddressTxt.Text = currentCustomer.Address
            CustomerPostcodeTxt.Text = currentCustomer.Postcode
        End If
    End Sub

    Private Sub AddNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim newsletterRecordQuery = SearchTable(newsletterTable, Function(r As Customer)
                                                                     ' Return all
                                                                     Return True
                                                                 End Function)

        ' If it's the first record, set the ID to 10000000
        If newsletterRecordQuery.Length = 0 Then
            CustomerIDTxt.Text = "10000000"
        Else
            'If not, add one to max ID
            Dim currentMaxID = 0
            For Each record In newsletterRecordQuery
                If CInt(record.CustomerID) > currentMaxID Then
                    currentMaxID = CInt(record.CustomerID)
                End If
            Next

            ' Set the form text boxes back to default (other than the new
            ' ID field)
            CustomerIDTxt.Text = CStr(currentMaxID + 1)
            CustomerTitleTxt.Text = ""
            CustomerInitialTxt.Text = ""
            CustomerSurnameTxt.Text = ""
            CustomerAddressTxt.Text = ""
            CustomerPostcodeTxt.Text = ""
        End If

        ' Create a new customer object with the appropriate customer ID
        ' and add it to the table
        Dim newCustomer As New Customer With {.CustomerID = CustomerIDTxt.Text}
        AddToTable(newsletterTable, newCustomer)

        ' Resize customerQueryResults to make room for this new customer
        Array.Resize(customerQueryResults, customerQueryResults.Length + 1)
        ' Add the new customer at the end
        customerQueryResults(customerQueryResults.Length - 1) = newCustomer

        ' View the last record (the one we just added)
        currentNewsletterIndex = customerQueryResults.Length - 1

        MsgBox("New customer added")
    End Sub

    Private Sub NewsletterSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Get the record of the current customer being edited
        Dim newsletterRecordQuery = SearchTable(newsletterTable, Function(c As Customer)
                                                                     Return c.CustomerID = CustomerIDTxt.Text
                                                                 End Function)

        If newsletterRecordQuery.Length > 0 Then
            Dim cust = newsletterRecordQuery(0)
            Dim custBeingViewed As Customer = customerQueryResults(currentNewsletterIndex)

            ' Ensure that the user has not changed the Customer ID as this could lead
            ' to further errors
            If custBeingViewed.CustomerID <> CustomerIDTxt.Text Then
                MsgBox("Customer ID cannot be changed.")
                ' Reset the customer ID  to the correct one
                CustomerIDTxt.Text = custBeingViewed.CustomerID
                Return
            End If

            ' Change the record to reflect the new data that the user has entered
            ' on the form.
            EditTableMember(newsletterTable, cust, Function(customer As Customer)
                                                       customer.CustomerID = CustomerIDTxt.Text
                                                       customer.Title = CustomerTitleTxt.Text
                                                       customer.Initial = CustomerInitialTxt.Text
                                                       customer.Surname = CustomerSurnameTxt.Text
                                                       customer.Address = CustomerAddressTxt.Text
                                                       customer.Postcode = CustomerPostcodeTxt.Text
                                                       Return True
                                                   End Function)

            MsgBox("Customer Details Updated")
        Else
            MsgBox("Invalid Customer ID")
        End If

    End Sub

    Private Sub PreviousNewsletterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Pass false to ShiftNewsletterRecord to indicate a backward shift
        ShiftNewsletterRecord(False)
    End Sub

    Private Sub NextNewsletterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Pass true to ShiftNewsletterRecord to indicate a forward shift
        ShiftNewsletterRecord(True)
    End Sub


    Private Sub DeleteNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get reference to the customer that needs to be deleted
        Dim query = SearchTable(newsletterTable, Function(r As Customer)
                                                     Return r.CustomerID = CustomerIDTxt.Text
                                                 End Function)

        If query.Length > 0 Then
            Dim recordToDelete = query(0)

            ' Delete the customer from the table
            DeleteFromTable(newsletterTable, recordToDelete)

            MsgBox("Customer Deleted")

            ' Reset the text boxes on the form
            CustomerIDTxt.Text = ""
            CustomerTitleTxt.Text = ""
            CustomerInitialTxt.Text = ""
            CustomerSurnameTxt.Text = ""
            CustomerAddressTxt.Text = ""
            CustomerPostcodeTxt.Text = ""

            ' Initialise a new customerQueryResults array that is 1 shorter ( -2 because of
            ' 0 based indices but 1-based length)
            Dim newCustomerQueryResults(customerQueryResults.Length - 2) As TableMember

            Dim newcount = 0
            Dim count = 0

            ' Iterate through each customer in the customerQueryResults array
            For Each cust In customerQueryResults

                If Not cust.Equals(recordToDelete) Then
                    ' If they aren't the record to delete, add them to the new array
                    newCustomerQueryResults(newcount) = customerQueryResults(count)
                    newcount += 1
                    count += 1
                Else
                    ' If they are the record to delete, don't add them
                    count += 1
                End If
            Next
            ' Set this new array to the array used elsewhere on the form
            customerQueryResults = newCustomerQueryResults

            ' Move to the end of the query results
            currentNewsletterIndex = customerQueryResults.Length - 1
        End If

    End Sub

End Class
