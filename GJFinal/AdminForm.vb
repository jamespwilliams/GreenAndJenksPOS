Imports System.Security.Cryptography

Public Class AdminForm

    Dim transitioningToStockForm = False

    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DataGridView1.DataSource = New GJDatabase(connectionString)

        ' By default, show all records
        ' NewsletterPanel.Init()

        ' Highlight the staff button, as by default the staff panel will show
        ShowStaff2.Select()
        ' Make sure staff panel is showing
        ShowStaff2.PerformClick()

        ' Initialise the item panel
        ItemPanel.Init()

        ' Set up colors to be used for the program colorscheme
        Dim color1 = Color.FromArgb(135, 122, 112)
        Dim color2 = Color.FromArgb(51, 51, 51)

        For Each cont In Me.Controls
            ' Set all buttons to flat style:
            If TypeOf cont Is Button Then
                cont.FlatStyle = FlatStyle.Flat
                cont.FlatAppearance.BorderColor = color1
                cont.ForeColor = color1
            ElseIf TypeOf cont Is Panel Then

                ' Loop through buttons in the separate
                ' panels, and set each to the correct style
                For Each butt In cont.Controls
                    If TypeOf butt Is Button Then
                        cont.FlatStyle = FlatStyle.Flat
                        cont.FlatAppearance.BorderColor = color1
                        cont.ForeColor = color1
                    End If
                Next

            End If
        Next
    End Sub

    Public Sub ShowPayrollPanel(ByVal payrollID)

        ' Called from elsewhere in the program, when the payroll panel needs
        ' to be shown for a given payroll member
        ' Initialise payroll panel
        PayrollPanel.LoadPayroll(payrollID)

        ' Show payroll panel
        PayrollPanel.Location = New Point(139, 15)
        PayrollPanel.Visible = True
        StaffPanel.Visible = False
    End Sub

    Public Sub OpenStockControlForm(Optional ByVal StockID = "")

        ' Called from elsewhere when the stock form needs to be loaded
        ' (when Add/View Stock is pressed on the ItemPanel)

        ' Keep track of the fact that the transition was between
        ' the admin form and the stock form
        transitioningToStockForm = True
        StockControl.fromAdminForm = True
        StockControl.Show()

        ' Ensure StockID exists before viewing
        If StockID <> "" Then
            StockControl.ViewItem(StockID)
        End If

        Me.Close()
    End Sub

    Public Sub ShowStaffPanel()
        ' Simulate click on the ShowStaff button when this method is called
        ShowStaff2.PerformClick()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        ' Close admin form when back pressed
        Me.Close()
    End Sub

    ' When admin form closed, show till form
    Private Sub AdminFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing And Not transitioningToStockForm Then
            Me.Hide()

            ' Ensure that the changes made to item records are reflected on the till
            SharedInstanceModule.TillForm.RepopulateItemPanel()
        End If
    End Sub

    Private Sub ShowTillItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowTillItems.Click

        ' Move ItemPanel to correct location
        ItemPanel.Location = New Point(139, 15)
        ' Hide other panels, show this one
        StaffPanel.Visible = False
        PayrollPanel.Visible = False
        NewsletterPanel.Visible = False
        ItemPanel.Visible = True
    End Sub

    Private Sub ShowStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowStaff2.Click
        ' Move StaffPanel to correct location
        StaffPanel.Location = New Point(139, 15)
        ' Hide other panels, show this one
        StaffPanel.Visible = True
        PayrollPanel.Visible = False
        NewsletterPanel.Visible = False
        ItemPanel.Visible = False

    End Sub

    Private Sub ShowNewsletter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowNewsletter.Click

        ' Move NewsletterPanel to correct location
        NewsletterPanel.Location = New Point(139, 15)
        ' Hide other panels, show this one
        StaffPanel.Visible = False
        PayrollPanel.Visible = False
        NewsletterPanel.Visible = True
        ItemPanel.Visible = False
    End Sub

End Class