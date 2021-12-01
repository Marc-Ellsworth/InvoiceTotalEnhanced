Public Class frmInvoiceTotal

    Dim numberOfInvoices As Integer
    Dim totalOfInvoices As Decimal
    Dim invoiceAverage As Decimal
    Dim largestInvoice As Decimal = 0
    Dim smallestInvoice As Decimal = 999999
    Dim midpoint As Decimal = 0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        'This below code uses the CDec function to cast the string contained in the txtSubtotal.Text
        'to a decimal type. It is one of the explicit ways to cast/convert data from one type to another
        'Dim subtotal As Decimal = CDec(txtSubtotal.Text)

        'This below code uses the Decimal.Parse function to convert the string contained in the txtSubtotal.Text to an equivalent decimal
        'data value. If the string can’t be converted, an exception occurs. 

        Try
            Dim subtotal As Decimal = Decimal.Parse(txtSubtotal.Text)

            Dim customerType As String = txtCustomerType.Text

            ' The Me statement here functions in a similar way to the "This" statement within Java. Is used to 
            ' refer to the specific instance of a class that the sub procedure is currently functioning within.
            ' This sub procedure can change the actual value of discount percent because we passed it ByRef instead of ByVal.

            Dim discountPercent As Decimal = Me.ComputeDiscountPercent(customerType, subtotal)
            Dim discountAmount As Decimal = subtotal * discountPercent
            Dim invoiceTotal As Decimal = subtotal - discountAmount

            'The below three lines of code are all using the FormatX methods, which accept two arguments, the data that is being formatted
            'and a numerical argument that specifies the precision of the number to be formatted. Because I used ",2", each of the following 
            'statements are formatted to 2 decimal places.
            'txtDiscountPercent.Text = FormatPercent(discountPercent, 2)
            'txtDiscountAmount.Text = FormatCurrency(discountAmount, 2)
            'txtTotal.Text = FormatCurrency(invoiceTotal, 2)

            'The below three statements use the ToString method to convert various text strings to their percent form and currency form.
            'The ToString() method accepts an argument contained within "" 'that determines:
            '1. The type of formatting (decimal, currency, percent)
            '2. The precision as a number (two decimal places etc.)
            txtDiscountPercent.Text = discountPercent.ToString("p2")
            txtDiscountAmount.Text = discountAmount.ToString("c2")
            txtTotal.Text = invoiceTotal.ToString("c2")


            txtCustomerType.Select()


            'Incrementing the number of invoices to display the total to the user every time the calculation is run
            numberOfInvoices = numberOfInvoices + 1

            'Keeping a running tally of the total amount of all invoices calculated
            totalOfInvoices = totalOfInvoices + invoiceTotal

            'Keeping a running average of all invoices calculated
            invoiceAverage = totalOfInvoices / numberOfInvoices

            'Display all previously run invoice calculations to the user
            txtNumberOfInvoices.Text = numberOfInvoices.ToString
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c2")
            txtInvoiceAverage.Text = invoiceAverage.ToString("c2")

            'Determine the maximum value invoice that has been submitted and displaying it to the user
            largestInvoice = Math.Max(largestInvoice, invoiceTotal)
            txtLargestInvoice.Text = largestInvoice.ToString("c2")

            'Determine the minimum value invoice that has been submitted and displaying it to the user
            smallestInvoice = Math.Min(smallestInvoice, invoiceTotal)
            txtSmallestInvoice.Text = smallestInvoice.ToString("c2")

            'Determine the midpoint between the larges and smallest invoices and displaying it to the user
            midpoint = (smallestInvoice + largestInvoice) / 2
            txtMidpoint.Text = midpoint.ToString("c2")

        Catch ex As InvalidCastException
            MessageBox.Show("Please check entries for valid numeric data.", ex.GetType.ToString)
        Catch ex As OverflowException
            MessageBox.Show("Please ensure that entries aren't too large.", ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, ex.GetType.ToString)
        Finally
            txtCustomerType.Select()
        End Try
    End Sub


    ' In this instance, the keyword Private refers to the "Scope" of this sub procedure. Declaring it
    ' as a private procedure, means that it is only accessable to the other modules contained within the 
    ' same class, and won't be available to other procedures in other classes.
    ' The keyword "Function" means that this procedure runs within another procedure, will "return" the values that 
    ' are specified in the function declaration, in this case it returns a Decimal.
    '
    ' The parameters of the procedure are myCustomerType (String) and mySubtotal (Decimal).
    ' Both of the parameters that are passed into this function are passed ByVal
    '
    ' The Return statement literally returns a computed value to the calling statement. In this instance it returns the
    ' computed value "myDiscountPercent" to the variable discountPercent.
    '

    Private Function ComputeDiscountPercent(myCustomerType As String, mySubtotal As Decimal) As Decimal

        Dim myDiscountPercent As Decimal

        Select Case myCustomerType
            Case "R", "r"
                Select Case mySubtotal
                    Case Is < 100
                        myDiscountPercent = 0
                    Case Is < 250
                        myDiscountPercent = 0.1D
                    Case Is < 500
                        myDiscountPercent = 0.25D
                    Case Else
                        myDiscountPercent = 0.3D
                End Select
            Case "C", "c"
                myDiscountPercent = 0.2D
            Case "T", "t"
                Select Case mySubtotal
                    Case Is >= 500
                        myDiscountPercent = 0.5D
                    Case Else
                        myDiscountPercent = 0.4D
                End Select
            Case Else
                myDiscountPercent = 0.1D
        End Select

        If myDiscountPercent >= 0.5 Then
            Throw New Exception("The discount is too big!")
        End If

        Return myDiscountPercent
    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClearTotals_Click(sender As Object, e As EventArgs) Handles btnClearTotals.Click
        'Setting the variables back to 0 to allow the user to restart submitting invoices
        numberOfInvoices = 0
        totalOfInvoices = 0D
        invoiceAverage = 0D
        largestInvoice = 0D
        smallestInvoice = 999999
        midpoint = 0

        'Emptying all textboxes on the form
        txtSubtotal.Text = ""
        txtDiscountPercent.Text = ""
        txtDiscountAmount.Text = ""
        txtTotal.Text = ""
        txtNumberOfInvoices.Text = ""
        txtTotalOfInvoices.Text = ""
        txtInvoiceAverage.Text = ""
        txtLargestInvoice.Text = ""
        txtSmallestInvoice.Text = ""
        txtMidpoint.Text = ""
        txtCustomerType.Text = ""

        txtCustomerType.Select()

    End Sub


    Private Sub ClearAllBoxes(Sender As Object, e As EventArgs) Handles txtCustomerType.DoubleClick, txtSubtotal.DoubleClick

        txtCustomerType.Text = ""
        txtSubtotal.Text = ""
        txtDiscountAmount.Text = ""
        txtDiscountPercent.Text = ""
        txtTotal.Text = ""

        txtNumberOfInvoices.Text = ""
        txtTotalOfInvoices.Text = ""
        txtInvoiceAverage.Text = ""
        txtLargestInvoice.Text = ""
        txtSmallestInvoice.Text = ""
        txtMidpoint.Text = ""

        txtCustomerType.Select()


    End Sub

End Class
