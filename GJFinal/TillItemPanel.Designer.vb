<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TillItemPanel
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
        Me.ItemPanel = New System.Windows.Forms.GroupBox()
        Me.DeleteItem = New System.Windows.Forms.Button()
        Me.SaveItem = New System.Windows.Forms.Button()
        Me.AddOrViewStock = New System.Windows.Forms.Button()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ItemSalesTxt = New System.Windows.Forms.TextBox()
        Me.ItemCategoryTxt = New System.Windows.Forms.TextBox()
        Me.ItemPriceTxt = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ItemNameTxt = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ItemPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.DeleteItem)
        Me.ItemPanel.Controls.Add(Me.SaveItem)
        Me.ItemPanel.Controls.Add(Me.AddOrViewStock)
        Me.ItemPanel.Controls.Add(Me.AddItem)
        Me.ItemPanel.Controls.Add(Me.Label36)
        Me.ItemPanel.Controls.Add(Me.Label37)
        Me.ItemPanel.Controls.Add(Me.ItemSalesTxt)
        Me.ItemPanel.Controls.Add(Me.ItemCategoryTxt)
        Me.ItemPanel.Controls.Add(Me.ItemPriceTxt)
        Me.ItemPanel.Controls.Add(Me.Label38)
        Me.ItemPanel.Controls.Add(Me.ItemNameTxt)
        Me.ItemPanel.Controls.Add(Me.Label39)
        Me.ItemPanel.Location = New System.Drawing.Point(3, 4)
        Me.ItemPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPanel.Size = New System.Drawing.Size(244, 224)
        Me.ItemPanel.TabIndex = 27
        Me.ItemPanel.TabStop = False
        Me.ItemPanel.Text = "Till Items"
        '
        'DeleteItem
        '
        Me.DeleteItem.Location = New System.Drawing.Point(139, 195)
        Me.DeleteItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(90, 21)
        Me.DeleteItem.TabIndex = 26
        Me.DeleteItem.Text = "Delete"
        Me.DeleteItem.UseVisualStyleBackColor = True
        '
        'SaveItem
        '
        Me.SaveItem.Location = New System.Drawing.Point(11, 195)
        Me.SaveItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveItem.Name = "SaveItem"
        Me.SaveItem.Size = New System.Drawing.Size(87, 21)
        Me.SaveItem.TabIndex = 32
        Me.SaveItem.Text = "Save"
        Me.SaveItem.UseVisualStyleBackColor = True
        '
        'AddOrViewStock
        '
        Me.AddOrViewStock.Location = New System.Drawing.Point(139, 140)
        Me.AddOrViewStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddOrViewStock.Name = "AddOrViewStock"
        Me.AddOrViewStock.Size = New System.Drawing.Size(90, 47)
        Me.AddOrViewStock.TabIndex = 12
        Me.AddOrViewStock.Text = "Add Stock Entry For This Item"
        Me.AddOrViewStock.UseVisualStyleBackColor = True
        '
        'AddItem
        '
        Me.AddItem.Location = New System.Drawing.Point(12, 140)
        Me.AddItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(87, 49)
        Me.AddItem.TabIndex = 10
        Me.AddItem.Text = "Add New Item"
        Me.AddItem.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 111)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Item Sales"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 83)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 13)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Item Category"
        '
        'ItemSalesTxt
        '
        Me.ItemSalesTxt.Location = New System.Drawing.Point(114, 108)
        Me.ItemSalesTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemSalesTxt.Name = "ItemSalesTxt"
        Me.ItemSalesTxt.Size = New System.Drawing.Size(115, 20)
        Me.ItemSalesTxt.TabIndex = 3
        Me.ItemSalesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ItemCategoryTxt
        '
        Me.ItemCategoryTxt.Location = New System.Drawing.Point(114, 80)
        Me.ItemCategoryTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemCategoryTxt.Name = "ItemCategoryTxt"
        Me.ItemCategoryTxt.Size = New System.Drawing.Size(115, 20)
        Me.ItemCategoryTxt.TabIndex = 2
        Me.ItemCategoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ItemPriceTxt
        '
        Me.ItemPriceTxt.Location = New System.Drawing.Point(114, 52)
        Me.ItemPriceTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemPriceTxt.Name = "ItemPriceTxt"
        Me.ItemPriceTxt.Size = New System.Drawing.Size(115, 20)
        Me.ItemPriceTxt.TabIndex = 1
        Me.ItemPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 55)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(54, 13)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "Item Price"
        '
        'ItemNameTxt
        '
        Me.ItemNameTxt.Location = New System.Drawing.Point(114, 24)
        Me.ItemNameTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemNameTxt.Name = "ItemNameTxt"
        Me.ItemNameTxt.Size = New System.Drawing.Size(115, 20)
        Me.ItemNameTxt.TabIndex = 0
        Me.ItemNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 27)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Item Name"
        '
        'TillItemPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ItemPanel)
        Me.Name = "TillItemPanel"
        Me.Size = New System.Drawing.Size(256, 233)
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemPanel As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteItem As System.Windows.Forms.Button
    Friend WithEvents SaveItem As System.Windows.Forms.Button
    Friend WithEvents AddOrViewStock As System.Windows.Forms.Button
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ItemSalesTxt As System.Windows.Forms.TextBox
    Friend WithEvents ItemCategoryTxt As System.Windows.Forms.TextBox
    Friend WithEvents ItemPriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ItemNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label

End Class
