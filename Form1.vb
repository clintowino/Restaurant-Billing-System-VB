Public Class Form1

    Const WhitewinePrice = 5
    Const redwinePrice = 4.5
    Const rosePrice = 3
    Const cocktailPrice = 4.75
    Const Beerprice = 2.5

    Dim mcSubtotal As Double
    Dim mcTotal As Double
    Const mcTax_Rate = 0.75

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        With txtQuantity
            .Text = " "
            .Focus()
        End With
        txtAmount.Text = " "
        txtSubtotal.Text = " "
        txtVAT.Text = " "
        txtAmountDue.Text = " "

        radBeer.Checked = False
        radCocktail.Checked = False
        radWhitewine.Checked = False
        radRose.Checked = False
        radRedwine.Checked = False


    End Sub
    Private Function cWineTax(ByVal cAmount As Double) As Double
        cWineTax = cAmount - (cAmount * mcTax_Rate)

    End Function

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim cCost As Double
        Dim cQuantity As Double
        Dim cTax As Double
        Dim cItemAmount As Double
        If radRedwine.Checked = True Then
            cCost = redwinePrice
        ElseIf radWhitewine.Checked Then
            cCost = WhitewinePrice
        ElseIf radCocktail.Checked = True Then
            cCost = cocktailPrice
        ElseIf radRose.Checked = True Then
            cCost = rosePrice
        ElseIf radBeer.Checked = True Then
            cCost = Beerprice
        Else
            MsgBox("Please select a drink.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If

        If IsNumeric(txtQuantity.Text) Then
            cQuantity = Val(txtQuantity.Text)
            cItemAmount = cCost * cQuantity
            mcSubtotal = mcSubtotal + cItemAmount

            If chkTax.Checked = True Then
                cTax = cWineTax(mcSubtotal)

            End If

            mcTotal = mcSubtotal + cTax
            txtAmount.Text = FormatCurrency(mcSubtotal)
            txtSubtotal.Text = FormatCurrency(mcSubtotal)
            txtVAT.Text = FormatCurrency(cTax)
            txtAmountDue.Text = FormatCurrency(mcTotal)

        Else
            MsgBox("Enter the number of the items customer orderd.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)


        End If
    End Sub

End Class
