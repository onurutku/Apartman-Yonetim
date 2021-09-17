Public Class Hesapla
    Private Sub Hesapla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 2021 To 2055
            yil_ComboBox1.Items.Add(i)
        Next

        yil_ComboBox1.Text = Date.Now.Year.ToString()
    End Sub
End Class