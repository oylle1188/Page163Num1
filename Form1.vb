Public Class frmEquipmentRental

    Private Sub btnDisplayRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRentalRates.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\EquipmentData.txt")
        Dim strItemName As String = ""
        Dim strHalfDay As String = ""
        Dim strFullDay As String = ""
        Dim fmtStr As String = "{0,-10}, {1,15}, {2,15}"

        lstRentalInformation.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-Day", "Full-Day"))

        While Not sr.EndOfStream

            strItemName = sr.ReadLine
            strHalfDay = sr.ReadLine
            strFullDay = sr.ReadLine

            lstRentalInformation.Items.Add(String.Format(fmtStr, strItemName, strHalfDay, strFullDay))
        End While
    End Sub
End Class
