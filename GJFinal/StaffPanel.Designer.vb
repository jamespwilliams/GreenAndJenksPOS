<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPanel
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
        Me.GoToPayroll = New System.Windows.Forms.Button()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.DeleteStaff = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SaveStaff = New System.Windows.Forms.Button()
        Me.AddStaff = New System.Windows.Forms.Button()
        Me.EditPassword = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AdminBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PostcodeTxt = New System.Windows.Forms.TextBox()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.LastNameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LookUpID = New System.Windows.Forms.Button()
        Me.StaffIDTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GoToPayroll)
        Me.GroupBox1.Controls.Add(Me.DOBPicker)
        Me.GroupBox1.Controls.Add(Me.DeleteStaff)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.SaveStaff)
        Me.GroupBox1.Controls.Add(Me.AddStaff)
        Me.GroupBox1.Controls.Add(Me.EditPassword)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AdminBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PostcodeTxt)
        Me.GroupBox1.Controls.Add(Me.AddressTxt)
        Me.GroupBox1.Controls.Add(Me.LastNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FirstNameTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LookUpID)
        Me.GroupBox1.Controls.Add(Me.StaffIDTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(318, 337)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Table"
        '
        'GoToPayroll
        '
        Me.GoToPayroll.Location = New System.Drawing.Point(207, 244)
        Me.GoToPayroll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GoToPayroll.Name = "GoToPayroll"
        Me.GoToPayroll.Size = New System.Drawing.Size(105, 39)
        Me.GoToPayroll.TabIndex = 18
        Me.GoToPayroll.Text = "View Payroll"
        Me.GoToPayroll.UseVisualStyleBackColor = True
        '
        'DOBPicker
        '
        Me.DOBPicker.Location = New System.Drawing.Point(117, 106)
        Me.DOBPicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(192, 20)
        Me.DOBPicker.TabIndex = 3
        '
        'DeleteStaff
        '
        Me.DeleteStaff.Location = New System.Drawing.Point(261, 213)
        Me.DeleteStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteStaff.Name = "DeleteStaff"
        Me.DeleteStaff.Size = New System.Drawing.Size(48, 22)
        Me.DeleteStaff.TabIndex = 13
        Me.DeleteStaff.Text = "Delete"
        Me.DeleteStaff.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "then press Save. Also, edit the password and payroll."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "To add new staff, click New Staff Member, enter details"
        '
        'SaveStaff
        '
        Me.SaveStaff.Location = New System.Drawing.Point(207, 213)
        Me.SaveStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveStaff.Name = "SaveStaff"
        Me.SaveStaff.Size = New System.Drawing.Size(48, 22)
        Me.SaveStaff.TabIndex = 6
        Me.SaveStaff.Text = "Save"
        Me.SaveStaff.UseVisualStyleBackColor = True
        '
        'AddStaff
        '
        Me.AddStaff.Location = New System.Drawing.Point(11, 244)
        Me.AddStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddStaff.Name = "AddStaff"
        Me.AddStaff.Size = New System.Drawing.Size(107, 39)
        Me.AddStaff.TabIndex = 15
        Me.AddStaff.Text = "New Staff Member"
        Me.AddStaff.UseVisualStyleBackColor = True
        '
        'EditPassword
        '
        Me.EditPassword.Location = New System.Drawing.Point(11, 213)
        Me.EditPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EditPassword.Name = "EditPassword"
        Me.EditPassword.Size = New System.Drawing.Size(107, 22)
        Me.EditPassword.TabIndex = 10
        Me.EditPassword.Text = "Edit Password"
        Me.EditPassword.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Admin?"
        '
        'AdminBox
        '
        Me.AdminBox.AutoSize = True
        Me.AdminBox.Location = New System.Drawing.Point(294, 191)
        Me.AdminBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdminBox.Name = "AdminBox"
        Me.AdminBox.Size = New System.Drawing.Size(15, 14)
        Me.AdminBox.TabIndex = 13
        Me.AdminBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AdminBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Postcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DOB"
        '
        'PostcodeTxt
        '
        Me.PostcodeTxt.Location = New System.Drawing.Point(117, 163)
        Me.PostcodeTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PostcodeTxt.Name = "PostcodeTxt"
        Me.PostcodeTxt.Size = New System.Drawing.Size(192, 20)
        Me.PostcodeTxt.TabIndex = 5
        Me.PostcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(117, 135)
        Me.AddressTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(192, 20)
        Me.AddressTxt.TabIndex = 4
        Me.AddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LastNameTxt
        '
        Me.LastNameTxt.Location = New System.Drawing.Point(117, 79)
        Me.LastNameTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastNameTxt.Name = "LastNameTxt"
        Me.LastNameTxt.Size = New System.Drawing.Size(192, 20)
        Me.LastNameTxt.TabIndex = 2
        Me.LastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'FirstNameTxt
        '
        Me.FirstNameTxt.Location = New System.Drawing.Point(117, 51)
        Me.FirstNameTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstNameTxt.Name = "FirstNameTxt"
        Me.FirstNameTxt.Size = New System.Drawing.Size(192, 20)
        Me.FirstNameTxt.TabIndex = 1
        Me.FirstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        'LookUpID
        '
        Me.LookUpID.Location = New System.Drawing.Point(225, 21)
        Me.LookUpID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LookUpID.Name = "LookUpID"
        Me.LookUpID.Size = New System.Drawing.Size(87, 21)
        Me.LookUpID.TabIndex = 11
        Me.LookUpID.Text = "Look Up"
        Me.LookUpID.UseVisualStyleBackColor = True
        '
        'StaffIDTxt
        '
        Me.StaffIDTxt.Location = New System.Drawing.Point(117, 22)
        Me.StaffIDTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StaffIDTxt.Name = "StaffIDTxt"
        Me.StaffIDTxt.Size = New System.Drawing.Size(102, 20)
        Me.StaffIDTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "StaffID"
        '
        'StaffPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "StaffPanel"
        Me.Size = New System.Drawing.Size(331, 347)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GoToPayroll As System.Windows.Forms.Button
    Friend WithEvents DOBPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DeleteStaff As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SaveStaff As System.Windows.Forms.Button
    Friend WithEvents AddStaff As System.Windows.Forms.Button
    Friend WithEvents EditPassword As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AdminBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PostcodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LookUpID As System.Windows.Forms.Button
    Friend WithEvents StaffIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
