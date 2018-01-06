Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Data.Linq
Imports System.Data.Linq.Mapping

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Hide self - this form is only being used to initialise other forms and procedures
        Me.Visible = False

        SplashScreen.Show()

    End Sub

    ' Called when the entire program ends
    Public Sub Finish()
        ' Commit all changes made during the running of the program to the database
        GJDatabaseHelper.SubmitChanges()
        Me.Close()
    End Sub

    Private Sub MainForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ' Ensure that the form never shows
        Me.Visible = False
    End Sub
End Class
