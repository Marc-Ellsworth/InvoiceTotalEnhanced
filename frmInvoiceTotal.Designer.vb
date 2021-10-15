<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceTotal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberOfInvoices = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAverage = New System.Windows.Forms.TextBox()
        Me.txtLargestInvoice = New System.Windows.Forms.TextBox()
        Me.txtSmallestInvoice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMidpoint = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalOfInvoices = New System.Windows.Forms.TextBox()
        Me.btnClearTotals = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount percent:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discount amount: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(150, 15)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(76, 20)
        Me.txtSubtotal.TabIndex = 1
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(150, 44)
        Me.txtDiscountPercent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.ReadOnly = True
        Me.txtDiscountPercent.Size = New System.Drawing.Size(76, 20)
        Me.txtDiscountPercent.TabIndex = 5
        Me.txtDiscountPercent.TabStop = False
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(150, 80)
        Me.txtDiscountAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(76, 20)
        Me.txtDiscountAmount.TabIndex = 6
        Me.txtDiscountAmount.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(150, 115)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(211, 191)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 19)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(394, 191)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 19)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumberOfInvoices
        '
        Me.txtNumberOfInvoices.Location = New System.Drawing.Point(361, 15)
        Me.txtNumberOfInvoices.Name = "txtNumberOfInvoices"
        Me.txtNumberOfInvoices.ReadOnly = True
        Me.txtNumberOfInvoices.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfInvoices.TabIndex = 8
        Me.txtNumberOfInvoices.TabStop = False
        '
        'txtInvoiceAverage
        '
        Me.txtInvoiceAverage.Location = New System.Drawing.Point(361, 67)
        Me.txtInvoiceAverage.Name = "txtInvoiceAverage"
        Me.txtInvoiceAverage.ReadOnly = True
        Me.txtInvoiceAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceAverage.TabIndex = 10
        Me.txtInvoiceAverage.TabStop = False
        '
        'txtLargestInvoice
        '
        Me.txtLargestInvoice.Location = New System.Drawing.Point(361, 93)
        Me.txtLargestInvoice.Name = "txtLargestInvoice"
        Me.txtLargestInvoice.ReadOnly = True
        Me.txtLargestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtLargestInvoice.TabIndex = 11
        Me.txtLargestInvoice.TabStop = False
        '
        'txtSmallestInvoice
        '
        Me.txtSmallestInvoice.Location = New System.Drawing.Point(361, 119)
        Me.txtSmallestInvoice.Name = "txtSmallestInvoice"
        Me.txtSmallestInvoice.ReadOnly = True
        Me.txtSmallestInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtSmallestInvoice.TabIndex = 12
        Me.txtSmallestInvoice.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Number of invoices:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Invoice Average"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(254, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Largest invoice:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(254, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Smallest Invoice:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Mid point:"
        '
        'txtMidpoint
        '
        Me.txtMidpoint.Location = New System.Drawing.Point(361, 145)
        Me.txtMidpoint.Name = "txtMidpoint"
        Me.txtMidpoint.ReadOnly = True
        Me.txtMidpoint.Size = New System.Drawing.Size(100, 20)
        Me.txtMidpoint.TabIndex = 13
        Me.txtMidpoint.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total of invoices:"
        '
        'txtTotalOfInvoices
        '
        Me.txtTotalOfInvoices.Location = New System.Drawing.Point(361, 41)
        Me.txtTotalOfInvoices.Name = "txtTotalOfInvoices"
        Me.txtTotalOfInvoices.ReadOnly = True
        Me.txtTotalOfInvoices.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOfInvoices.TabIndex = 9
        Me.txtTotalOfInvoices.TabStop = False
        '
        'btnClearTotals
        '
        Me.btnClearTotals.Location = New System.Drawing.Point(298, 191)
        Me.btnClearTotals.Name = "btnClearTotals"
        Me.btnClearTotals.Size = New System.Drawing.Size(91, 19)
        Me.btnClearTotals.TabIndex = 3
        Me.btnClearTotals.Text = "C&lear Totals"
        Me.btnClearTotals.UseVisualStyleBackColor = True
        '
        'frmInvoiceTotal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(496, 236)
        Me.Controls.Add(Me.btnClearTotals)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMidpoint)
        Me.Controls.Add(Me.txtSmallestInvoice)
        Me.Controls.Add(Me.txtLargestInvoice)
        Me.Controls.Add(Me.txtInvoiceAverage)
        Me.Controls.Add(Me.txtTotalOfInvoices)
        Me.Controls.Add(Me.txtNumberOfInvoices)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmInvoiceTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDiscountPercent As TextBox
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumberOfInvoices As TextBox
    Friend WithEvents txtInvoiceAverage As TextBox
    Friend WithEvents txtLargestInvoice As TextBox
    Friend WithEvents txtSmallestInvoice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMidpoint As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalOfInvoices As TextBox
    Friend WithEvents btnClearTotals As Button
End Class
