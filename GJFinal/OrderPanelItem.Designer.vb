<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderPanelItem
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
        Me.ItemNameLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.SubtotalLabel = New System.Windows.Forms.Label()
        Me.ItemNumberLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.AutoSize = True
        Me.ItemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameLabel.Location = New System.Drawing.Point(19, 4)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(87, 20)
        Me.ItemNameLabel.TabIndex = 0
        Me.ItemNameLabel.Text = "Item Name"
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(224, -1)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(25, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractButton.Location = New System.Drawing.Point(296, -1)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(25, 23)
        Me.SubtractButton.TabIndex = 2
        Me.SubtractButton.Text = "-"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'SubtotalLabel
        '
        Me.SubtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SubtotalLabel.AutoSize = True
        Me.SubtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalLabel.Location = New System.Drawing.Point(330, 4)
        Me.SubtotalLabel.Name = "SubtotalLabel"
        Me.SubtotalLabel.Size = New System.Drawing.Size(49, 20)
        Me.SubtotalLabel.TabIndex = 3
        Me.SubtotalLabel.Text = "£0.00"
        '
        'ItemNumberLabel
        '
        Me.ItemNumberLabel.AutoSize = True
        Me.ItemNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNumberLabel.Location = New System.Drawing.Point(263, 3)
        Me.ItemNumberLabel.Name = "ItemNumberLabel"
        Me.ItemNumberLabel.Size = New System.Drawing.Size(18, 20)
        Me.ItemNumberLabel.TabIndex = 4
        Me.ItemNumberLabel.Text = "1"
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(392, 0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(25, 23)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "X"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(467, 42)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 504
        Me.LineShape1.Y1 = 37
        Me.LineShape1.Y2 = 37
        '
        'OrderPanelItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ItemNumberLabel)
        Me.Controls.Add(Me.SubtotalLabel)
        Me.Controls.Add(Me.SubtractButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "OrderPanelItem"
        Me.Size = New System.Drawing.Size(467, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SubtractButton As System.Windows.Forms.Button
    Friend WithEvents SubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents ItemNumberLabel As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
