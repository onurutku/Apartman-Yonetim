Public Class Hesapla
    Private Sub Hesapla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 2021 To 2055
            yil_ComboBox1.Items.Add(i)
        Next

        yil_ComboBox1.Text = Date.Now.Year.ToString()

        ay_ComboBox2.Items.AddRange(New String() {"Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"})
        ay_ComboBox2.Text = DateAndTime.Now.ToString("MMMM")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim yil As String = yil_ComboBox1.Text
        Dim ay As String = ay_ComboBox2.Text
        Dim kayitbulma As String = "C:\Users\topal\OneDrive\Desktop\bina" & "\" & yil & "\" & ay
        If System.IO.Directory.Exists(kayitbulma) = True Then


            For Each filePath In System.IO.Directory.GetFiles(kayitbulma, "miktar.txt", System.IO.SearchOption.AllDirectories)
                giderler_ComboBox1.Items.Add(System.IO.File.ReadAllText(filePath))
            Next
            Dim i As Integer
            For i = 1 To giderler_ComboBox1.Items.Count
                Dim erb As Integer = giderler_ComboBox1.Items(i - 1) + erb
                gider_TextBox2.Text = erb
            Next i

        End If


    End Sub
End Class