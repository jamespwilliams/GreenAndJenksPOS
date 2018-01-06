Imports System.Security.Cryptography

Public Class StaffPanel

    ' Quicksort implementation:
    Private Sub QuickSort(ByVal arr() As Integer, ByVal First As Long, ByVal Last As Long)
        Dim Low As Long, High As Long
        Dim MidValue As Integer

        ' set up variables to be used in the algorithm
        Low = First
        High = Last
        ' use the middle value as a pivot
        MidValue = arr((First + Last) \ 2)

        Do
            ' Move the low pointer up to where the pivot value is
            While arr(Low) < MidValue
                Low = Low + 1
            End While

            ' move the high value down to where the pivot value is
            While arr(High) > MidValue
                High = High - 1
            End While

            ' sort the subarray by swapping the low and high elements
            If Low <= High Then
                Swap(arr(Low), arr(High))
                ' increment/decrement low and high ready for the next pass
                Low = Low + 1
                High = High - 1
            End If
        Loop While Low <= High

        ' recursively call this algorithm on subarrays of the current array
        If First < High Then QuickSort(arr, First, High)
        If Low < Last Then QuickSort(arr, Low, Last)
    End Sub

    Private Sub Swap(ByRef A As String, ByRef B As String)
        Dim T As String

        ' swap the values:
        T = A
        A = B
        B = T
    End Sub


    Private Sub LookUpID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpID.Click
        ' Called when user presses the "Look Up" button to find a staff member's record
        Dim query = SearchTable(staffTable, Function(r As StaffMember)
                                                Return r.StaffID = StaffIDTxt.Text
                                            End Function)

        ' Assume no record has been found until we explicitly set that it has
        Dim recordFound = False

        ' set the text boxes to the returned data:
        For Each record In query
            FirstNameTxt.Text = record.FirstName
            LastNameTxt.Text = record.LastName
            DOBPicker.Value = record.DOB
            AddressTxt.Text = record.Address
            PostcodeTxt.Text = record.Postcode
            AdminBox.Checked = record.Admin

            recordFound = True
        Next

        ' If no record was found:
        If Not recordFound Then
            MsgBox("No staff member with this ID found")
        End If
    End Sub

    Private Sub SaveStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStaff.Click
        ' Find the record of the staff member to be saved
        Dim query = SearchTable(staffTable, Function(r As StaffMember)
                                                Return r.StaffID = StaffIDTxt.Text
                                            End Function)

        If query.Length > 0 Then
            Dim record = query(0)

            ' ensure DOB is not in the future
            If DOBPicker.Value.Year > DateTime.UtcNow.Year Then
                MsgBox("DOB cannnot be in future")
                Return
            End If

            ' Save the entered data to the database
            EditTableMember(staffTable, record, Function(r As StaffMember)
                                                    r.FirstName = FirstNameTxt.Text
                                                    r.LastName = LastNameTxt.Text
                                                    r.DOB = DOBPicker.Value
                                                    r.Address = AddressTxt.Text
                                                    r.Postcode = PostcodeTxt.Text
                                                    r.Admin = AdminBox.Checked
                                                    Return False
                                                End Function)
            MsgBox("Staff Details Successfully Saved")
        Else
            MsgBox("Staff Member Not Found")
        End If


    End Sub

    Private Sub EditPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPassword.Click

        ' Find the record of the staff member to be saved
        Dim query = SearchTable(staffTable, Function(r As StaffMember)
                                                Return r.StaffID = StaffIDTxt.Text
                                            End Function)
        ' If the record exists:
        If query.Length > 0 Then
            Dim record = query(0)

            ' Set up hashing algorithm
            Dim algorithm = New SHA256Managed()

            ' Get user to input the new password
            Dim password = InputBox("Enter new password:", "New Password: ")

            If password <> "" Then
                ' Hash the bytes of the password
                Dim bytes = System.Text.Encoding.Unicode.GetBytes(password)
                Dim hashbytes = algorithm.ComputeHash(bytes)

                ' Save these hashed bytes to the database
                EditTableMember(staffTable, record, Function(r As StaffMember)
                                                        r.PasswordHash = hashbytes
                                                        Return False
                                                    End Function)

                MsgBox("Password Successfully Changed")
            Else
                MsgBox("Password cannot be empty")
            End If

        Else
            MsgBox("User not found")
        End If

    End Sub

    Private Sub AddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaff.Click

        ' Find a new staff ID by adding one to the current maximum:
        Dim newID = ""

        Dim staffIDList(staffTable.Length - 1) As Integer
        Dim count = 0
        SearchTable(staffTable, Function(r As StaffMember)
                                    staffIDList(count) = CInt(r.StaffID)
                                    count += 1
                                    Return False
                                End Function)

        ' Sort array using QuickSort (implementation at top of file):
        QuickSort(staffIDList, 0, staffIDList.Length)

        newID = CStr(staffIDList(staffIDList.Length - 1) + 1)

        ' Create new GUID to use as the PayrollID for this staff member:
        ' The chances of this not being unique are minute, but to be safe I will check:

        Dim payrollid As Guid
        Dim clash = True
        While clash
            payrollid = Guid.NewGuid()
            clash = False

            For Each record In staffTable
                If record.PayrollID = payrollid Then
                    clash = True
                End If
            Next
            ' If none have matched, clash will be false and the while loop will end
        End While

        ' create new staff member object with the appropriate data
        Dim newStaff As New StaffMember With {.StaffID = newID, .DOB = DateTime.Now, _
                                              .PayrollID = payrollid}
        ' Create new payroll object with the generated PayrollID
        Dim newPayroll As New PayrollMember With {.PayrollID = payrollid}

        ' Add both to their respective tables
        AddToTable(staffTable, newStaff)
        AddToTable(payrollTable, newPayroll)

        ' Reset the form input boxes to their default, other than the StaffID
        ' which is set to the new StaffID
        StaffIDTxt.Text = CStr(newID)
        FirstNameTxt.Text = ""
        LastNameTxt.Text = ""
        DOBPicker.Value = DateTime.Now
        AddressTxt.Text = ""
        PostcodeTxt.Text = ""
        AdminBox.Checked = False

        MsgBox("Staff Successfully Added")

    End Sub

    Private Sub DeleteStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStaff.Click

        ' Search for the staff member that needs to be deleted
        Dim staffRecordQuery = SearchTable(staffTable, Function(r As StaffMember)
                                                           Return r.StaffID = StaffIDTxt.Text

                                                       End Function)

        If staffRecordQuery.Length > 0 Then
            ' If exists, delete
            DeleteFromTable(staffTable, staffRecordQuery(0))

            ' alert user
            MsgBox("Staff Member Deleted")

            ' reset form inputs to blank
            StaffIDTxt.Text = ""
            FirstNameTxt.Text = ""
            LastNameTxt.Text = ""
            DOBPicker.Value = DateTime.Now
            AddressTxt.Text = ""
            PostcodeTxt.Text = ""
            AdminBox.Checked = False
        Else
            MsgBox("Staff member not found")
        End If

    End Sub

    Private Sub GoToPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToPayroll.Click
        ' Called when user clicks to see the payroll for the currently shown staff member:
        Dim pid
        Dim staffRecordQuery = SearchTable(staffTable, Function(r As StaffMember)
                                                           Return r.StaffID = StaffIDTxt.Text

                                                       End Function)

        ' if staff member exists:
        If staffRecordQuery.Length > 0 Then
            Dim staffRecord = staffRecordQuery(0)
            pid = staffRecord.PayrollID

            ' show the payroll panel and load the appropriate payroll record.
            AdminForm.ShowPayrollPanel(pid)
        Else
            MsgBox("Staff member not found")
        End If

    End Sub

End Class
