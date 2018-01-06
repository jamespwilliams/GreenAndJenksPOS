<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.ShowNewsletter = New System.Windows.Forms.Button()
        Me.ShowStaff2 = New System.Windows.Forms.Button()
        Me.ShowTillItems = New System.Windows.Forms.Button()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.ItemPanel = New GJFinal.TillItemPanel()
        Me.NewsletterPanel = New GJFinal.NewsletterPanel()
        Me.PayrollPanel = New GJFinal.PayrollPanel()
        Me.StaffPanel = New GJFinal.StaffPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowNewsletter
        '
        Me.ShowNewsletter.Location = New System.Drawing.Point(11, 53)
        Me.ShowNewsletter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowNewsletter.Name = "ShowNewsletter"
        Me.ShowNewsletter.Size = New System.Drawing.Size(87, 30)
        Me.ShowNewsletter.TabIndex = 3
        Me.ShowNewsletter.Text = "Newsletter"
        Me.ShowNewsletter.UseVisualStyleBackColor = True
        '
        'ShowStaff2
        '
        Me.ShowStaff2.Location = New System.Drawing.Point(11, 15)
        Me.ShowStaff2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowStaff2.Name = "ShowStaff2"
        Me.ShowStaff2.Size = New System.Drawing.Size(87, 30)
        Me.ShowStaff2.TabIndex = 24
        Me.ShowStaff2.Text = "Staff"
        Me.ShowStaff2.UseVisualStyleBackColor = True
        '
        'ShowTillItems
        '
        Me.ShowTillItems.Location = New System.Drawing.Point(11, 91)
        Me.ShowTillItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowTillItems.Name = "ShowTillItems"
        Me.ShowTillItems.Size = New System.Drawing.Size(87, 30)
        Me.ShowTillItems.TabIndex = 27
        Me.ShowTillItems.Text = "Till Items"
        Me.ShowTillItems.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(11, 130)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(87, 30)
        Me.BackButton.TabIndex = 32
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(534, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LoginLabel.Location = New System.Drawing.Point(590, 213)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(195, 40)
        Me.LoginLabel.TabIndex = 34
        Me.LoginLabel.Text = "ADMIN PANEL"
        '
        'ItemPanel
        '
        Me.ItemPanel.Location = New System.Drawing.Point(561, 480)
        Me.ItemPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(357, 392)
        Me.ItemPanel.TabIndex = 38
        '
        'NewsletterPanel
        '
        Me.NewsletterPanel.Location = New System.Drawing.Point(761, 517)
        Me.NewsletterPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NewsletterPanel.Name = "NewsletterPanel"
        Me.NewsletterPanel.Size = New System.Drawing.Size(377, 429)
        Me.NewsletterPanel.TabIndex = 37
        '
        'PayrollPanel
        '
        Me.PayrollPanel.Location = New System.Drawing.Point(238, 517)
        Me.PayrollPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayrollPanel.Name = "PayrollPanel"
        Me.PayrollPanel.Size = New System.Drawing.Size(429, 467)
        Me.PayrollPanel.TabIndex = 36
        '
        'StaffPanel
        '
        Me.StaffPanel.Location = New System.Drawing.Point(104, 13)
        Me.StaffPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(418, 460)
        Me.StaffPanel.TabIndex = 35
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 468)
        Me.Controls.Add(Me.ItemPanel)
        Me.Controls.Add(Me.NewsletterPanel)
        Me.Controls.Add(Me.PayrollPanel)
        Me.Controls.Add(Me.StaffPanel)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ShowTillItems)
        Me.Controls.Add(Me.ShowStaff2)
        Me.Controls.Add(Me.ShowNewsletter)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdminForm"
        Me.Text = "Green & Jenks Admin Panel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GjprototypeDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShowNewsletter As System.Windows.Forms.Button
    Friend WithEvents ShowStaff2 As System.Windows.Forms.Button
    Friend WithEvents ShowTillItems As System.Windows.Forms.Button
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LoginLabel As System.Windows.Forms.Label
    Friend WithEvents StaffPanel As GJFinal.StaffPanel
    Friend WithEvents PayrollPanel As GJFinal.PayrollPanel
    Friend WithEvents NewsletterPanel As GJFinal.NewsletterPanel
    Friend WithEvents ItemPanel As GJFinal.TillItemPanel
End Class
