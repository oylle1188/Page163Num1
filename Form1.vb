Public Class frmEquipmentRental

    Private Sub btnDisplayRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRentalRates.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\EquipmentData.txt")
        Dim strItemName As String = ""
        Dim strHalfDay As String = ""
        Dim strFullDay As String = ""
        Dim fmtStr As String = "{0,-10} {1,15} {2,15}"

        lstRentalInformation.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-Day", "Full-Day"))

        While Not sr.EndOfStream

            strItemName = sr.ReadLine
            strHalfDay = sr.ReadLine
            strFullDay = sr.ReadLine

            lstRentalInformation.Items.Add(String.Format(fmtStr, strItemName, strHalfDay, strFullDay))
        End While
    End Sub

    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click

        Dim strItem1 As String = "Rug Cleaner"
        Dim strItem2 As String = "Lawn Mower"
        Dim strItem3 As String = "Paint Sprayer"
        Dim dblRugCostFull As Double = 24
        Dim dblRugCostHalf As Double = 16
        Dim dblMowerCostFull As Double = 28
        Dim dblMowerCostHalf As Double = 12
        Dim dblSprayerCostFull As Double = 30
        Dim dblSprayerCostHalf As Double = 20
        Dim fmtStr As String = "{0,-10} {1,10} {2,20}"

       


        If TextBox1.Text = "1" And TextBox2.Text.ToUpper = "F" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem1, FormatCurrency(dblRugCostFull), "Full day Rental"))
        ElseIf TextBox1.Text = "1" And TextBox2.Text.ToUpper = "H" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem1, FormatCurrency(dblRugCostHalf), "Half day Rental"))
        ElseIf TextBox1.Text = "2" And TextBox2.Text.ToUpper = "F" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem2, FormatCurrency(dblMowerCostFull), "Full day Rental"))
        ElseIf TextBox1.Text = "2" And TextBox2.Text.ToUpper = "H" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem2, FormatCurrency(dblMowerCostHalf), "Half day Rental"))
        ElseIf TextBox1.Text = "3" And TextBox2.Text.ToUpper = "F" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem3, FormatCurrency(dblSprayerCostFull), "Full day Rental"))
        ElseIf TextBox1.Text = "3" And TextBox2.Text.ToUpper = "H" Then
            lstBillingInformation.Items.Add(String.Format(fmtStr, strItem3, FormatCurrency(dblSprayerCostHalf), "Half day Rental"))
        Else
            MessageBox.Show("Please enter 1, 2, or 3 in the select item textbox")
            MessageBox.Show("Please enter H or F in the duration textbox")
        End If

    End Sub
End Class
