<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TillForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TillForm))
        Me.SubTotal = New System.Windows.Forms.Label()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.LoggedInLabel = New System.Windows.Forms.Label()
        Me.ButtonsControl = New System.Windows.Forms.TabControl()
        Me.ClockInButton = New System.Windows.Forms.Button()
        Me.ClockOutButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.StockControlButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FinishOrderButton = New System.Windows.Forms.Button()
        Me.CancelOrderButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubTotal
        '
        Me.SubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.Location = New System.Drawing.Point(583, 194)
        Me.SubTotal.MinimumSize = New System.Drawing.Size(723, 0)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Padding = New System.Windows.Forms.Padding(6)
        Me.SubTotal.Size = New System.Drawing.Size(723, 45)
        Me.SubTotal.TabIndex = 7
        Me.SubTotal.Text = "£0.00"
        Me.SubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AdminButton
        '
        Me.AdminButton.BackColor = System.Drawing.Color.White
        Me.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminButton.Location = New System.Drawing.Point(1219, 246)
        Me.AdminButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(87, 30)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "ADMIN"
        Me.AdminButton.UseVisualStyleBackColor = False
        '
        'LoggedInLabel
        '
        Me.LoggedInLabel.AutoSize = True
        Me.LoggedInLabel.Location = New System.Drawing.Point(1133, 743)
        Me.LoggedInLabel.Name = "LoggedInLabel"
        Me.LoggedInLabel.Size = New System.Drawing.Size(87, 17)
        Me.LoggedInLabel.TabIndex = 2
        Me.LoggedInLabel.Text = "Logged in as:"
        '
        'ButtonsControl
        '
        Me.ButtonsControl.Location = New System.Drawing.Point(583, 246)
        Me.ButtonsControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonsControl.Name = "ButtonsControl"
        Me.ButtonsControl.SelectedIndex = 0
        Me.ButtonsControl.Size = New System.Drawing.Size(628, 460)
        Me.ButtonsControl.TabIndex = 8
        '
        'ClockInButton
        '
        Me.ClockInButton.BackColor = System.Drawing.Color.White
        Me.ClockInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockInButton.Location = New System.Drawing.Point(1219, 578)
        Me.ClockInButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClockInButton.Name = "ClockInButton"
        Me.ClockInButton.Size = New System.Drawing.Size(87, 30)
        Me.ClockInButton.TabIndex = 4
        Me.ClockInButton.Text = "CLOCK IN"
        Me.ClockInButton.UseVisualStyleBackColor = False
        '
        'ClockOutButton
        '
        Me.ClockOutButton.BackColor = System.Drawing.Color.White
        Me.ClockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockOutButton.Location = New System.Drawing.Point(1217, 616)
        Me.ClockOutButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClockOutButton.Name = "ClockOutButton"
        Me.ClockOutButton.Size = New System.Drawing.Size(87, 52)
        Me.ClockOutButton.TabIndex = 5
        Me.ClockOutButton.Text = "CLOCK OUT"
        Me.ClockOutButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.White
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Location = New System.Drawing.Point(1219, 676)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(87, 30)
        Me.QuitButton.TabIndex = 6
        Me.QuitButton.Text = "QUIT"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'StockControlButton
        '
        Me.StockControlButton.BackColor = System.Drawing.Color.White
        Me.StockControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StockControlButton.Location = New System.Drawing.Point(1217, 284)
        Me.StockControlButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockControlButton.Name = "StockControlButton"
        Me.StockControlButton.Size = New System.Drawing.Size(87, 49)
        Me.StockControlButton.TabIndex = 8
        Me.StockControlButton.Text = "STOCK CONTROL"
        Me.StockControlButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CURRENT ORDER:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderPanel
        '
        Me.OrderPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OrderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OrderPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OrderPanel.Location = New System.Drawing.Point(12, 228)
        Me.OrderPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderPanel.Name = "OrderPanel"
        Me.OrderPanel.Padding = New System.Windows.Forms.Padding(0, 6, 12, 0)
        Me.OrderPanel.Size = New System.Drawing.Size(562, 477)
        Me.OrderPanel.TabIndex = 4
        '
        'FinishOrderButton
        '
        Me.FinishOrderButton.BackColor = System.Drawing.Color.White
        Me.FinishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinishOrderButton.Location = New System.Drawing.Point(462, 713)
        Me.FinishOrderButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FinishOrderButton.Name = "FinishOrderButton"
        Me.FinishOrderButton.Size = New System.Drawing.Size(112, 30)
        Me.FinishOrderButton.TabIndex = 0
        Me.FinishOrderButton.Text = "FINISH ORDER"
        Me.FinishOrderButton.UseVisualStyleBackColor = False
        '
        'CancelOrderButton
        '
        Me.CancelOrderButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelOrderButton.Location = New System.Drawing.Point(12, 714)
        Me.CancelOrderButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelOrderButton.Name = "CancelOrderButton"
        Me.CancelOrderButton.Size = New System.Drawing.Size(119, 30)
        Me.CancelOrderButton.TabIndex = 0
        Me.CancelOrderButton.Text = "CANCEL ORDER"
        Me.CancelOrderButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(-165, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1514, 172)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1327, 763)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelOrderButton)
        Me.Controls.Add(Me.FinishOrderButton)
        Me.Controls.Add(Me.OrderPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StockControlButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ClockOutButton)
        Me.Controls.Add(Me.ClockInButton)
        Me.Controls.Add(Me.ButtonsControl)
        Me.Controls.Add(Me.LoggedInLabel)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.SubTotal)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TillForm"
        Me.Text = "Green & Jenks Till"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubTotal As System.Windows.Forms.Label
    Friend WithEvents AdminButton As System.Windows.Forms.Button
    Friend WithEvents LoggedInLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonsControl As System.Windows.Forms.TabControl
    Friend WithEvents ClockInButton As System.Windows.Forms.Button
    Friend WithEvents ClockOutButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents StockControlButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FinishOrderButton As System.Windows.Forms.Button
    Friend WithEvents CancelOrderButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
