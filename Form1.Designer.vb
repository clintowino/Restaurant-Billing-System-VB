<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBeer = New System.Windows.Forms.RadioButton()
        Me.radRose = New System.Windows.Forms.RadioButton()
        Me.radCocktail = New System.Windows.Forms.RadioButton()
        Me.radRedwine = New System.Windows.Forms.RadioButton()
        Me.radWhitewine = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtMenu)
        Me.GroupBox2.Controls.Add(Me.radBeer)
        Me.GroupBox2.Controls.Add(Me.radRose)
        Me.GroupBox2.Controls.Add(Me.radCocktail)
        Me.GroupBox2.Controls.Add(Me.radRedwine)
        Me.GroupBox2.Controls.Add(Me.radWhitewine)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(7, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 240)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "z"
        Me.GroupBox2.Text = "Drink Selection"
        '
        'radBeer
        '
        Me.radBeer.AutoSize = True
        Me.radBeer.Location = New System.Drawing.Point(6, 183)
        Me.radBeer.Name = "radBeer"
        Me.radBeer.Size = New System.Drawing.Size(72, 28)
        Me.radBeer.TabIndex = 4
        Me.radBeer.TabStop = True
        Me.radBeer.Text = "Beer"
        Me.radBeer.UseVisualStyleBackColor = True
        '
        'radRose
        '
        Me.radRose.AutoSize = True
        Me.radRose.Location = New System.Drawing.Point(6, 145)
        Me.radRose.Name = "radRose"
        Me.radRose.Size = New System.Drawing.Size(76, 28)
        Me.radRose.TabIndex = 3
        Me.radRose.TabStop = True
        Me.radRose.Text = "Rose"
        Me.radRose.UseVisualStyleBackColor = True
        '
        'radCocktail
        '
        Me.radCocktail.AutoSize = True
        Me.radCocktail.Location = New System.Drawing.Point(6, 111)
        Me.radCocktail.Name = "radCocktail"
        Me.radCocktail.Size = New System.Drawing.Size(149, 28)
        Me.radCocktail.TabIndex = 2
        Me.radCocktail.TabStop = True
        Me.radCocktail.Text = "Fruit Cocktail"
        Me.radCocktail.UseVisualStyleBackColor = True
        '
        'radRedwine
        '
        Me.radRedwine.AutoSize = True
        Me.radRedwine.Location = New System.Drawing.Point(6, 77)
        Me.radRedwine.Name = "radRedwine"
        Me.radRedwine.Size = New System.Drawing.Size(120, 28)
        Me.radRedwine.TabIndex = 1
        Me.radRedwine.TabStop = True
        Me.radRedwine.Text = "Red Wine"
        Me.radRedwine.UseVisualStyleBackColor = True
        '
        'radWhitewine
        '
        Me.radWhitewine.AutoSize = True
        Me.radWhitewine.Location = New System.Drawing.Point(6, 43)
        Me.radWhitewine.Name = "radWhitewine"
        Me.radWhitewine.Size = New System.Drawing.Size(135, 28)
        Me.radWhitewine.TabIndex = 0
        Me.radWhitewine.TabStop = True
        Me.radWhitewine.Text = "White Wine"
        Me.radWhitewine.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox3.Controls.Add(Me.btnclear)
        Me.GroupBox3.Controls.Add(Me.btnTotal)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkTax)
        Me.GroupBox3.Location = New System.Drawing.Point(337, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 240)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclear.Location = New System.Drawing.Point(223, 190)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(107, 44)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTotal.Location = New System.Drawing.Point(49, 190)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(107, 44)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(156, 34)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(154, 29)
        Me.txtQuantity.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'chkTax
        '
        Me.chkTax.AutoSize = True
        Me.chkTax.Location = New System.Drawing.Point(146, 106)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(64, 28)
        Me.chkTax.TabIndex = 0
        Me.chkTax.Text = "Tax"
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox4.Controls.Add(Me.txtAmountDue)
        Me.GroupBox4.Controls.Add(Me.txtVAT)
        Me.GroupBox4.Controls.Add(Me.txtSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Location = New System.Drawing.Point(8, 310)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 114)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Amount Paid"
        '
        'txtAmountDue
        '
        Me.txtAmountDue.Location = New System.Drawing.Point(317, 85)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.ReadOnly = True
        Me.txtAmountDue.Size = New System.Drawing.Size(165, 29)
        Me.txtAmountDue.TabIndex = 5
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(318, 51)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(165, 29)
        Me.txtVAT.TabIndex = 4
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(318, 16)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(165, 29)
        Me.txtSubtotal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Amount Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "VAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sub Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(21, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(342, 275)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(166, 29)
        Me.txtAmount.TabIndex = 4
        '
        'txtMenu
        '
        Me.txtMenu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtMenu.ForeColor = System.Drawing.SystemColors.Info
        Me.txtMenu.Location = New System.Drawing.Point(207, 31)
        Me.txtMenu.Multiline = True
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(106, 152)
        Me.txtMenu.TabIndex = 5
        Me.txtMenu.Text = "PRICES"
        Me.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "White Wine...$5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rose...........$3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(209, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cocktail....$4.75"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Beer..........$2.5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(209, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Red wine...$4.5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "BIlling System"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radBeer As RadioButton
    Friend WithEvents radRose As RadioButton
    Friend WithEvents radCocktail As RadioButton
    Friend WithEvents radRedwine As RadioButton
    Friend WithEvents radWhitewine As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkTax As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtMenu As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
