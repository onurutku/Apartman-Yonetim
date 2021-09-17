Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month As String = DateAndTime.Now.Month.ToString
        Dim name As String
        If month = 1 Then
            name = "Ocak"
        End If
        If month = 2 Then
            name = "Şubat"
        End If
        If month = 3 Then
            name = "Mart"
        End If
        If month = 4 Then
            name = "Nisan"
        End If
        If month = 5 Then
            name = "Mayıs"
        End If
        If month = 6 Then
            name = "Haziran"
        End If
        If month = 7 Then
            name = "Temmuz"
        End If
        If month = 8 Then
            name = "Ağustos"
        End If
        If month = 9 Then
            name = "Eylül"
        End If
        If month = 10 Then
            name = "Ekim"
        End If
        If month = 11 Then
            name = "Kasım"
        End If
        If month = 12 Then
            name = "Aralık"
        End If
        Me.Text = "Angün Apt" & " " & Date.Now.Day & "." & name & "." & Date.Now.Year
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Daireler.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Aidat_Takip.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.Gider.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        My.Forms.Hesapla.Show()
    End Sub
End Class