Public Class GPA
    Dim grade01 As Double
    Dim grade02 As Double
    Dim grade03 As Double
    Dim huo01 As Double
    Dim huo02 As Double
    Dim huo03 As Double
    Dim result01 As Double
    Private Sub Butresult_Click(sender As Object, e As EventArgs) Handles Butresult.Click
        grade01 = boxgr01.Text
        grade02 = boxgr02.Text
        grade03 = boxgr03.Text
        huo01 = Combhu01.Text
        huo02 = Combhu02.Text
        huo03 = Combhu03.Text

        result01 = ((grade01 * huo01) + (grade02 * huo02) + (grade03 * huo03)) / (huo01 + huo02 + huo03) / 20
        Laresult.Text = result01
        Select Case result01
            Case > 4.75
                gradeof5.Text = "A+"
            Case > 4.5
                gradeof5.Text = "A"
            Case > 4
                gradeof5.Text = "B+"
            Case > 3.5
                gradeof5.Text = "B"
            Case > 3
                gradeof5.Text = "C+"
            Case > 2.5
                gradeof5.Text = "C"
            Case > 2
                gradeof5.Text = "D+"
            Case > 1
                gradeof5.Text = "D"
            Case <= 1
                gradeof5.Text = "F"

        End Select

    End Sub


End Class
