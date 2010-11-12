Public Class Form1

    Dim RandomClass As New Random()
    Dim RandomNumber0 As Integer, RandomNumber1 As Integer, RandomNumber2 As Integer, RandomNumber3 As Integer

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        RandomNumber0 = RandomClass.Next(0, 255)
        RandomNumber1 = RandomClass.Next(0, 255)
        RandomNumber2 = RandomClass.Next(0, 255)
        RandomNumber3 = RandomClass.Next(0, 255)
        Label1.Text = RandomNumber0.ToString + "." + RandomNumber1.ToString + "." + RandomNumber2.ToString + "." + RandomNumber3.ToString
    End Sub

End Class
