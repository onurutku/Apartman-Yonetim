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
            Dim erb As Integer
            For i = 1 To giderler_ComboBox1.Items.Count
                erb = giderler_ComboBox1.Items(i - 1) + erb
            Next
            gider_TextBox2.Text = erb
            giderler_ComboBox1.Items.Clear()
        End If

        Dim aidat As String = "C:\Users\topal\OneDrive\Desktop\bina"
        For Each filePath In System.IO.Directory.GetFiles(aidat, "Aidat Bedeli.txt", System.IO.SearchOption.AllDirectories)
            aidatlar_ComboBox1.Items.Add(System.IO.File.ReadAllText(filePath))
        Next
        Dim im As Integer
        Dim erbm As Integer
        For im = 1 To aidatlar_ComboBox1.Items.Count
            erbm = aidatlar_ComboBox1.Items(im - 1) + erbm
        Next
        aidat_TextBox1.Text = erbm
        aidatlar_ComboBox1.Items.Clear()

        Dim kalan As Integer = aidat_TextBox1.Text - gider_TextBox2.Text
        kalan_TextBox3.Text = kalan
    End Sub
End Class