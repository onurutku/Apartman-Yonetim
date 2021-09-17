Public Class Gider

    Private Sub Gider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim guncelyil As Integer = Date.Now.Year()
        Dim yillar As Integer
        For yillar = guncelyil To 2050
            yil_ComboBox1.Items.Add(yillar)
        Next
        Dim aylar As New List(Of String) From {"Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"}
        For Each item As String In aylar
            My.Forms.Gider.ay_ComboBox2.Items.Add(item)
        Next
        Dim guncelay As String = DateAndTime.Now.ToString("MMMM")
        Me.yil_ComboBox1.SelectedItem = guncelyil
        Me.ay_ComboBox2.SelectedItem = guncelay

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ay_ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Me.fis_RadioButton1.Checked = True Or Me.makbuz_RadioButton2.Checked = True) And Me.belgesirano_TextBox4.Text <> "" And
            Me.belgeno_TextBox1.Text <> "" And yil_ComboBox1.Text <> "" And ay_ComboBox2.Text <> "" And miktar_TextBox1.Text <> "" And
            Me.aciklama_RichTextBox1.Text <> "" Then

            Dim kayityeri As String = "C:\Users\topal\OneDrive\Desktop\bina"
            System.IO.Directory.CreateDirectory(kayityeri & "\" & Me.yil_ComboBox1.Text)
            System.IO.Directory.CreateDirectory(kayityeri & "\" & Me.yil_ComboBox1.Text & "\" & Me.ay_ComboBox2.Text)

            Dim belgevesiranoid As String = Me.belgesirano_TextBox4.Text
            Dim belgesonkayityeri = kayityeri & "\" & Me.yil_ComboBox1.Text & "\" & Me.ay_ComboBox2.Text & "\" & belgevesiranoid
            If System.IO.Directory.Exists(belgesonkayityeri) = False Then
                System.IO.Directory.CreateDirectory(belgesonkayityeri)

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim belgesirano As String = belgesonkayityeri & "\belgesirano.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(belgesirano, Me.belgesirano_TextBox4.Text)
                '----------------------------------------------------------------------

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim belgeno As String = belgesonkayityeri & "\belgeno.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(belgeno, Me.belgeno_TextBox1.Text)
                '----------------------------------------------------------------------

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim duzenlenmetarihi As String = belgesonkayityeri & "\duzenlenmetarihi.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(duzenlenmetarihi, DateTimePicker1.Value)
                '----------------------------------------------------------------------

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim yili As String = belgesonkayityeri & "\yili.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(yili, Me.yil_ComboBox1.SelectedItem)
                '----------------------------------------------------------------------

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim ayi As String = belgesonkayityeri & "\ayi.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(ayi, Me.ay_ComboBox2.SelectedItem)
                '----------------------------------------------------------------------

                'belgesira noya göre .txt dosyasının nereye kaydedileceği
                Dim aciklama As String = belgesonkayityeri & "\aciklama.txt"
                '--------------------------------------------------------------------------------------
                '.txt dosyasının içine ne yazılacağı
                System.IO.File.WriteAllText(aciklama, Me.aciklama_RichTextBox1.Text)
                '----------------------------------------------------------------------

                Dim miktar As String = belgesonkayityeri & "\miktar.txt"
                System.IO.File.WriteAllText(miktar, miktar_TextBox1.Text)


                Dim fismakbuz As String = belgesonkayityeri & "\fismakbuz.txt"
                If fis_RadioButton1.Checked = True Then
                    System.IO.File.WriteAllText(fismakbuz, "Belge Fiş ya da Fatura Türündedir")
                ElseIf makbuz_RadioButton2.Checked = True Then
                    System.IO.File.WriteAllText(fismakbuz, "Belge Makbuz Türündedir")
                End If
                MessageBox.Show("Belge Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.Gider.Controls.Clear()
                InitializeComponent()
                My.Forms.Gider.Gider_Load(e, e)
            Else
                Dim dialog3 As DialogResult = MessageBox.Show("Zaten girdiğiniz belge sıra no ile kayıtlı bir belge mevcut,üzerine kaydetmek ister misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog3 = DialogResult.Yes Then
                    System.IO.Directory.CreateDirectory(belgesonkayityeri)

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim belgesirano As String = belgesonkayityeri & "\belgesirano.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(belgesirano, Me.belgesirano_TextBox4.Text)
                    '----------------------------------------------------------------------

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim belgeno As String = belgesonkayityeri & "\belgeno.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(belgeno, Me.belgeno_TextBox1.Text)
                    '----------------------------------------------------------------------

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim duzenlenmetarihi As String = belgesonkayityeri & "\duzenlenmetarihi.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(duzenlenmetarihi, DateTimePicker1.Value)
                    '----------------------------------------------------------------------

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim yili As String = belgesonkayityeri & "\yili.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(yili, Me.yil_ComboBox1.SelectedItem)
                    '----------------------------------------------------------------------

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim ayi As String = belgesonkayityeri & "\ayi.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(ayi, Me.ay_ComboBox2.SelectedItem)
                    '----------------------------------------------------------------------

                    'belgesira noya göre .txt dosyasının nereye kaydedileceği
                    Dim aciklama As String = belgesonkayityeri & "\aciklama.txt"
                    '--------------------------------------------------------------------------------------
                    '.txt dosyasının içine ne yazılacağı
                    System.IO.File.WriteAllText(aciklama, Me.aciklama_RichTextBox1.Text)
                    '----------------------------------------------------------------------

                    Dim miktar As String = belgesonkayityeri & "\miktar.txt"
                    System.IO.File.WriteAllText(miktar, miktar_TextBox1.Text)


                    Dim fismakbuz As String = belgesonkayityeri & "\fismakbuz.txt"
                    If fis_RadioButton1.Checked = True Then
                        System.IO.File.WriteAllText(fismakbuz, "Belge Fiş ya da Fatura Türündedir")
                    ElseIf makbuz_RadioButton2.Checked = True Then
                        System.IO.File.WriteAllText(fismakbuz, "Belge Makbuz Türündedir")
                    End If
                    MessageBox.Show("Belge Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    My.Forms.Gider.Controls.Clear()
                    InitializeComponent()
                    My.Forms.Gider.Gider_Load(e, e)
                End If
            End If
        Else
            MessageBox.Show("Lütfen Boş Alanları Doldurunuz ve Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kayityeri As String = "C:\Users\topal\OneDrive\Desktop\bina"

        'Dim bul = My.Computer.FileSystem.FindInFiles("C:\Users\topal\OneDrive\Desktop\bina",
        'Me.belgeno_TextBox1.Text, True, FileIO.SearchOption.SearchTopLevelOnly)
        'MessageBox.Show(bul)

        Dim belgevesiranoid As String = Me.belgesirano_TextBox4.Text
        Dim belgesonkayityeri = kayityeri & "\" & Me.yil_ComboBox1.Text & "\" & Me.ay_ComboBox2.Text & "\" & belgevesiranoid & "\belgesirano.txt"
        Dim read = kayityeri & "\" & Me.yil_ComboBox1.Text & "\" & Me.ay_ComboBox2.Text & "\" & belgevesiranoid

        If System.IO.File.Exists(belgesonkayityeri) Then
            Dim muhabbet As DialogResult = MessageBox.Show("Bilgileri Yüklemek İster Misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If muhabbet = DialogResult.Yes Then
                belgesirano_TextBox4.Text = System.IO.File.ReadAllText(belgesonkayityeri)
                belgeno_TextBox1.Text = System.IO.File.ReadAllText(read & "\belgeno.txt")
                DateTimePicker1.Value = System.IO.File.ReadAllText(read & "\duzenlenmetarihi.txt")
                belgeno_TextBox1.Text = System.IO.File.ReadAllText(read & "\belgeno.txt")
                aciklama_RichTextBox1.Text = System.IO.File.ReadAllText(read & "\aciklama.txt")
                miktar_TextBox1.Text = System.IO.File.ReadAllText(read & "\miktar.txt")
                If System.IO.File.ReadAllText(read & "\fismakbuz.txt") = "Belge Fiş ya da Fatura Türündedir" Then
                    fis_RadioButton1.Checked = True
                ElseIf System.IO.File.ReadAllText(read & "\fismakbuz.txt") = "Belge Makbuz Türündedir" Then
                    makbuz_RadioButton2.Checked = True
                End If
            End If
        Else
            MessageBox.Show("Hata", "Kayıtlarda Böyle Bir Belge Yoktur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kayityeri As String = "C:\Users\topal\OneDrive\Desktop\bina"
        Dim belgevesiranoid As String = Me.belgesirano_TextBox4.Text
        Dim silinecekbelge = kayityeri & "\" & Me.yil_ComboBox1.Text & "\" & Me.ay_ComboBox2.Text & "\" & belgevesiranoid
        If System.IO.Directory.Exists(silinecekbelge) Then
            Dim dialog As DialogResult = MessageBox.Show("Bilgileri Silmek İstediğnize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                System.IO.Directory.Delete(silinecekbelge, True)
                MessageBox.Show("Kayıt Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.Gider.Controls.Clear()
                InitializeComponent()
            End If
        Else
            MessageBox.Show("Böyle bir kayıt bulunmamaktadır.Girdiğiniz bilgileri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class