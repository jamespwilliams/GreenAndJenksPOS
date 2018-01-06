<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NIPaidTxt = New System.Windows.Forms.TextBox()
        Me.SortCode3 = New System.Windows.Forms.TextBox()
        Me.SortCode2 = New System.Windows.Forms.TextBox()
        Me.SortCode1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ShowStaff = New System.Windows.Forms.Button()
        Me.BankNumTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TaxPaidTxt = New System.Windows.Forms.TextBox()
        Me.SavePayroll = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NetPayTxt = New System.Windows.Forms.TextBox()
        Me.GrossPayTxt = New System.Windows.Forms.TextBox()
        Me.PayRateTxt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MonthHoursTxt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.NIPaidTxt)
        Me.GroupBox1.Controls.Add(Me.SortCode3)
        Me.GroupBox1.Controls.Add(Me.SortCode2)
        Me.GroupBox1.Controls.Add(Me.SortCode1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.ShowStaff)
        Me.GroupBox1.Controls.Add(Me.BankNumTxt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TaxPaidTxt)
        Me.GroupBox1.Controls.Add(Me.SavePayroll)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.NetPayTxt)
        Me.GroupBox1.Controls.Add(Me.GrossPayTxt)
        Me.GroupBox1.Controls.Add(Me.PayRateTxt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.MonthHoursTxt)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(289, 276)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "NI Paid to Date"
        '
        'NIPaidTxt
        '
        Me.NIPaidTxt.Location = New System.Drawing.Point(159, 129)
        Me.NIPaidTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NIPaidTxt.Name = "NIPaidTxt"
        Me.NIPaidTxt.Size = New System.Drawing.Size(116, 20)
        Me.NIPaidTxt.TabIndex = 4
        Me.NIPaidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SortCode3
        '
        Me.SortCode3.Location = New System.Drawing.Point(243, 218)
        Me.SortCode3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SortCode3.Name = "SortCode3"
        Me.SortCode3.Size = New System.Drawing.Size(32, 20)
        Me.SortCode3.TabIndex = 9
        '
        'SortCode2
        '
        Me.SortCode2.Location = New System.Drawing.Point(201, 218)
        Me.SortCode2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SortCode2.Name = "SortCode2"
        Me.SortCode2.Size = New System.Drawing.Size(32, 20)
        Me.SortCode2.TabIndex = 8
        '
        'SortCode1
        '
        Me.SortCode1.Location = New System.Drawing.Point(160, 218)
        Me.SortCode1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SortCode1.Name = "SortCode1"
        Me.SortCode1.Size = New System.Drawing.Size(32, 20)
        Me.SortCode1.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Sort Code"
        '
        'ShowStaff
        '
        Me.ShowStaff.Location = New System.Drawing.Point(159, 246)
        Me.ShowStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowStaff.Name = "ShowStaff"
        Me.ShowStaff.Size = New System.Drawing.Size(116, 21)
        Me.ShowStaff.TabIndex = 11
        Me.ShowStaff.Text = "Back"
        Me.ShowStaff.UseVisualStyleBackColor = True
        '
        'BankNumTxt
        '
        Me.BankNumTxt.Location = New System.Drawing.Point(159, 191)
        Me.BankNumTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankNumTxt.Name = "BankNumTxt"
        Me.BankNumTxt.Size = New System.Drawing.Size(116, 20)
        Me.BankNumTxt.TabIndex = 6
        Me.BankNumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Bank Account Number"
        '
        'TaxPaidTxt
        '
        Me.TaxPaidTxt.Location = New System.Drawing.Point(159, 157)
        Me.TaxPaidTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TaxPaidTxt.Name = "TaxPaidTxt"
        Me.TaxPaidTxt.Size = New System.Drawing.Size(116, 20)
        Me.TaxPaidTxt.TabIndex = 5
        Me.TaxPaidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SavePayroll
        '
        Me.SavePayroll.Location = New System.Drawing.Point(11, 246)
        Me.SavePayroll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SavePayroll.Name = "SavePayroll"
        Me.SavePayroll.Size = New System.Drawing.Size(87, 21)
        Me.SavePayroll.TabIndex = 10
        Me.SavePayroll.Text = "Save"
        Me.SavePayroll.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tax Paid to Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Net Pay to Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Gross Pay to Date"
        '
        'NetPayTxt
        '
        Me.NetPayTxt.Location = New System.Drawing.Point(159, 101)
        Me.NetPayTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NetPayTxt.Name = "NetPayTxt"
        Me.NetPayTxt.Size = New System.Drawing.Size(116, 20)
        Me.NetPayTxt.TabIndex = 3
        Me.NetPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrossPayTxt
        '
        Me.GrossPayTxt.Location = New System.Drawing.Point(159, 73)
        Me.GrossPayTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrossPayTxt.Name = "GrossPayTxt"
        Me.GrossPayTxt.Size = New System.Drawing.Size(116, 20)
        Me.GrossPayTxt.TabIndex = 2
        Me.GrossPayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PayRateTxt
        '
        Me.PayRateTxt.Location = New System.Drawing.Point(159, 45)
        Me.PayRateTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayRateTxt.Name = "PayRateTxt"
        Me.PayRateTxt.Size = New System.Drawing.Size(116, 20)
        Me.PayRateTxt.TabIndex = 1
        Me.PayRateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Rate of Pay/Hour"
        '
        'MonthHoursTxt
        '
        Me.MonthHoursTxt.Location = New System.Drawing.Point(159, 17)
        Me.MonthHoursTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MonthHoursTxt.Name = "MonthHoursTxt"
        Me.MonthHoursTxt.Size = New System.Drawing.Size(116, 20)
        Me.MonthHoursTxt.TabIndex = 0
        Me.MonthHoursTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Hours worked this month"
        '
        'PayrollPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PayrollPanel"
        Me.Size = New System.Drawing.Size(303, 285)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NIPaidTxt As System.Windows.Forms.TextBox
    Friend WithEvents SortCode3 As System.Windows.Forms.TextBox
    Friend WithEvents SortCode2 As System.Windows.Forms.TextBox
    Friend WithEvents SortCode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ShowStaff As System.Windows.Forms.Button
    Friend WithEvents BankNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TaxPaidTxt As System.Windows.Forms.TextBox
    Friend WithEvents SavePayroll As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NetPayTxt As System.Windows.Forms.TextBox
    Friend WithEvents GrossPayTxt As System.Windows.Forms.TextBox
    Friend WithEvents PayRateTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MonthHoursTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
