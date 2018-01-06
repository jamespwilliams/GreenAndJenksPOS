Imports System.Security.Cryptography
Imports System.Linq
Imports System.Runtime.InteropServices

Public Class SplashScreen

    Dim failedLogInAlreadyShowing = False
    ' when the user closes this form, we want the program to quit.
    Private Sub splashscreenclosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            MainForm.Finish()
        Else
            Me.Hide()
        End If

    End Sub

    Private Sub LogInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton.Click
        Dim id = StaffIdTxt.Text
        Dim password = PasswordTxt.Text

        Dim success = False

        ' Set up algorithm to hash the entered password, so that they can be checked against the database
        Dim algorithm = New SHA256Managed()
        ' hash the bytes of the password
        Dim bytes = System.Text.Encoding.Unicode.GetBytes(password)
        Dim hashbytes = algorithm.ComputeHash(bytes)

        ' GJDatabase is defined in the GJDatabaseHelper module (along with StaffMember).
        ' This module centralises the code required to access the database, leading to less code repetition.
        Dim query = SearchTable(staffTable, Function(r As StaffMember)
                                                Return r.StaffID = id
                                            End Function)

        Dim record
        Try
            record = query(0)

        Catch ex As Exception

            MessageBox.Show("Failed Log In")
            Return
        End Try

        ' To compare byte arrays SequenceEqual must be used, rather than the usual equal sign.
        If hashbytes.SequenceEqual(record.passwordHash) Then
            ' If they are equal, the log-on was successful
            success = True
        Else
            MessageBox.Show("Failed Log In")
        End If

        ' Log in
        If success Then
            ' Set the global StaffID for the system
            SetStaffID(id)
            LogIn()

            Me.Hide()
        End If
    End Sub

    Private Sub LogIn()

        Dim TF As TillForm = New TillForm()
        ' Global instance of TillForm - there should only be one at any time.
        SharedInstanceModule.TillForm = TF

        TF.Show()
        ' Remove redunant reference
        TF = Nothing

    End Sub

    Private Sub Password_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTxt.KeyUp

        If e.KeyCode = Keys.Enter Then
            ' Ensure that the failed log in msgbox isn't already showing
            If Not failedLogInAlreadyShowing Then
                LogInButton.PerformClick()
            End If
        End If
    End Sub


    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' This function is just setting up some aesthetic properties for the form:

        ' Create colors for the form color scheme
        Dim color1 = Color.FromArgb(135, 122, 112)
        Dim color2 = Color.FromArgb(51, 51, 51)

        ' Set the form colors to these colors
        LoginLabel.ForeColor = color1
        Label2.ForeColor = color1
        Label3.ForeColor = color1

        StaffIdTxt.ForeColor = color1
        PasswordTxt.ForeColor = color1

        ' Set the button style to flat
        LogInButton.FlatStyle = FlatStyle.Flat
        LogInButton.FlatAppearance.BorderColor = color1
        LogInButton.ForeColor = color1

    End Sub

End Class