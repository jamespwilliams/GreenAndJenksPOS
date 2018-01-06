Public Class PayrollPanel

    Dim currentPayrollID
    Private Sub SavePayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePayroll.Click
        ' Get record of the currently viewed payroll record
        Dim payrollRecordQuery = SearchTable(payrollTable, Function(p As PayrollMember)
                                                               Return p.PayrollID = currentPayrollID
                                                           End Function)

        'VALIDATION:
        For Each c In {PayRateTxt, GrossPayTxt, NetPayTxt, NIPaidTxt, TaxPaidTxt}
            ' Need at least £d where d is a digit, so length must be >1 
            If Not c.Text.Length > 1 Then
                MsgBox("Please enter an amount of currency")
                Return
            End If

            ' Check for missing £ sign
            If Not c.Text.Substring(0, 1) = "£" Then
                MsgBox("Please include £ sign at front of any currency amounts")
                Return
            Else
                ' First part of string is as expected, check that second part is valid single
                Dim success = False
                If Not Single.TryParse(c.Text.Substring(1), success) Then

                    MsgBox("Please enter a valid currency amount.")
                    Return

                End If

            End If
        Next

        For Each c In {MonthHoursTxt, SortCode1, SortCode2, SortCode3}
            ' Check that all of the above text boxes aren't empty
            If Not c.Text.Length > 0 Then
                MsgBox("Please ensure all fields are non-empty")
                Return
            End If

            Dim r As Integer
            ' Check that all of the above text boxes are integers
            If Not Integer.TryParse(c.Text, r) Then
                MsgBox("Please ensure that numeric fields do not contain alphabet characters")
                Return
            Else
                ' Check that all of the above text boxes aren't negative
                If r < 0 Then
                    MsgBox("Please ensure that numeric fields are not negative")
                    Return
                End If
            End If
            ' Check that all of the sortcode boxes are of length two
            If c.Equals(SortCode1) Or c.Equals(SortCode2) Or c.Equals(SortCode3) Then
                If Not c.Text.Length = 2 Then
                    MsgBox("Please ensure sort code numbers are of length 2")
                    Return
                End If
            End If
        Next

        ' Check that the bank numbre input is present
        If BankNumTxt.Text.Length = 0 Then
            MsgBox("Please enter a bank number")
            Return
        End If

        ' Check that each character of the bank number is a valid digit
        For Each character In BankNumTxt.Text
            Dim a As Integer
            If Not Integer.TryParse(character, a) Then
                MsgBox("Please ensure bank number is valid")
                Return
            End If
        Next

        'END VALIDATION

        If payrollRecordQuery.Length > 0 Then
            Dim record = payrollRecordQuery(0)

            'Save the data from the form text boxes back into the payroll record in the database
            EditTableMember(payrollTable, record, Function(payrollRecord As PayrollMember)
                                                      payrollRecord.MonthHours = CSng(MonthHoursTxt.Text)
                                                      ' Use substring(1) to ignore £
                                                      payrollRecord.HourlyPay = CSng(PayRateTxt.Text.Substring(1))
                                                      payrollRecord.GrossPayToDate = CSng(GrossPayTxt.Text.Substring(1))
                                                      payrollRecord.NetPayToDate = CSng(NetPayTxt.Text.Substring(1))
                                                      payrollRecord.TaxPaidToDate = CSng(TaxPaidTxt.Text.Substring(1))
                                                      payrollRecord.NIPaidToDate = CSng(NIPaidTxt.Text.Substring(1))
                                                      payrollRecord.BankAccountNumber = BankNumTxt.Text
                                                      ' Concatenate sort code text boxes when saving
                                                      payrollRecord.SortCode = SortCode1.Text & SortCode2.Text & SortCode3.Text
                                                      Return False
                                                  End Function)

            MsgBox("Payroll Successfully Changed")

        End If

    End Sub


    Private Sub DeletePayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Delete the currently viewed payroll from the payroll table
        DeleteFromTable(payrollTable, SearchTable(payrollTable, Function(r As PayrollMember)
                                                                    Return r.PayrollID = currentPayrollID
                                                                End Function)(0))

        MsgBox("Payroll Deleted")
        ' Reset form inputs to blank
        MonthHoursTxt.Text = ""

        PayRateTxt.Text = ""
        GrossPayTxt.Text = ""
        NetPayTxt.Text = ""
        TaxPaidTxt.Text = ""
        NIPaidTxt.Text = ""
        BankNumTxt.Text = ""

        SortCode1.Text = ""
        SortCode2.Text = ""
        SortCode3.Text = ""

    End Sub

    Sub LoadPayroll(ByVal payrollID)
        ' Set the current payroll ID to the requested payroll ID
        currentPayrollID = payrollID

        Dim payrollRecordQuery = SearchTable(payrollTable, Function(r As PayrollMember)
                                                               Return r.PayrollID = currentPayrollID
                                                           End Function)
        ' Get the record for the requested payroll
        Dim payrollRecord = payrollRecordQuery(0)

        ' Fill in the text boxes with the data from the record
        MonthHoursTxt.Text = payrollRecord.MonthHours
        PayRateTxt.Text = "£" & CStr(payrollRecord.HourlyPay)
        GrossPayTxt.Text = "£" & CStr(payrollRecord.GrossPayToDate)
        NetPayTxt.Text = "£" & CStr(payrollRecord.NetPayToDate)
        TaxPaidTxt.Text = "£" & CStr(payrollRecord.TaxPaidToDate)
        NIPaidTxt.Text = "£" & CStr(payrollRecord.NIPaidToDate)
        BankNumTxt.Text = payrollRecord.BankAccountNumber

        ' Ensure that the Sort Code exists to avoid crashing when Chars is called
        If payrollRecord.SortCode IsNot Nothing Then

            Dim sortcode = payrollRecord.SortCode.ToString

            If Len(sortcode.ToString.Length) Then
                ' Separate the sort code into 3 parts for easier input
                SortCode1.Text = sortcode.Chars(0) & sortcode.Chars(1)
                SortCode2.Text = sortcode.Chars(2) & sortcode.Chars(3)
                SortCode3.Text = sortcode.Chars(4) & sortcode.Chars(5)
            End If
        End If

    End Sub


    Private Sub ShowStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowStaff.Click
        Me.Hide()
        AdminForm.ShowStaffPanel()
    End Sub
End Class
