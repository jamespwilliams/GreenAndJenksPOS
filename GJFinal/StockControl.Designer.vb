<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockControl))
        Me.ItemPanel = New System.Windows.Forms.GroupBox()
        Me.DeleteItem = New System.Windows.Forms.Button()
        Me.SaveStock = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.MinStockLevelTxt = New System.Windows.Forms.TextBox()
        Me.StockLevelTxt = New System.Windows.Forms.TextBox()
        Me.StockNameTxt = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ItemPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.DeleteItem)
        Me.ItemPanel.Controls.Add(Me.SaveStock)
        Me.ItemPanel.Controls.Add(Me.Label36)
        Me.ItemPanel.Controls.Add(Me.Label37)
        Me.ItemPanel.Controls.Add(Me.MinStockLevelTxt)
        Me.ItemPanel.Controls.Add(Me.StockLevelTxt)
        Me.ItemPanel.Controls.Add(Me.StockNameTxt)
        Me.ItemPanel.Controls.Add(Me.Label38)
        Me.ItemPanel.Location = New System.Drawing.Point(132, 16)
        Me.ItemPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPanel.Size = New System.Drawing.Size(346, 247)
        Me.ItemPanel.TabIndex = 27
        Me.ItemPanel.TabStop = False
        Me.ItemPanel.Text = "Stock Items"
        '
        'DeleteItem
        '
        Me.DeleteItem.Location = New System.Drawing.Point(105, 143)
        Me.DeleteItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(87, 30)
        Me.DeleteItem.TabIndex = 26
        Me.DeleteItem.Text = "Delete"
        Me.DeleteItem.UseVisualStyleBackColor = True
        '
        'SaveStock
        '
        Me.SaveStock.Location = New System.Drawing.Point(10, 143)
        Me.SaveStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveStock.Name = "SaveStock"
        Me.SaveStock.Size = New System.Drawing.Size(87, 30)
        Me.SaveStock.TabIndex = 32
        Me.SaveStock.Text = "Save"
        Me.SaveStock.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 105)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 17)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Minimum Level"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 71)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 17)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Stock Level"
        '
        'MinStockLevelTxt
        '
        Me.MinStockLevelTxt.Location = New System.Drawing.Point(114, 101)
        Me.MinStockLevelTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinStockLevelTxt.Name = "MinStockLevelTxt"
        Me.MinStockLevelTxt.Size = New System.Drawing.Size(116, 25)
        Me.MinStockLevelTxt.TabIndex = 3
        '
        'StockLevelTxt
        '
        Me.StockLevelTxt.Location = New System.Drawing.Point(114, 67)
        Me.StockLevelTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockLevelTxt.Name = "StockLevelTxt"
        Me.StockLevelTxt.Size = New System.Drawing.Size(116, 25)
        Me.StockLevelTxt.TabIndex = 2
        '
        'StockNameTxt
        '
        Me.StockNameTxt.Location = New System.Drawing.Point(114, 33)
        Me.StockNameTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockNameTxt.Name = "StockNameTxt"
        Me.StockNameTxt.Size = New System.Drawing.Size(116, 25)
        Me.StockNameTxt.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 37)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 17)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "Stock Name"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(14, 16)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(87, 30)
        Me.BackButton.TabIndex = 33
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LoginLabel.Location = New System.Drawing.Point(566, 223)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(233, 40)
        Me.LoginLabel.TabIndex = 36
        Me.LoginLabel.Text = "STOCK CONTROL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(530, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'StockControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 292)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ItemPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StockControl"
        Me.Text = "StockControl"
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemPanel As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteItem As System.Windows.Forms.Button
    Friend WithEvents SaveStock As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents MinStockLevelTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockLevelTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents LoginLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
