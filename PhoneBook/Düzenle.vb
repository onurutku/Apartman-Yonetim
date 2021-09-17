Public Class Düzenle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'kaydedilecek dosyanın klasör adının değişkene atanması
        Dim klasoradi As String
        klasoradi = Me.daireno_TextBox1.Text
        '-------------------------------------------------------

        'klasörün kaydedileceği yolun ve adının değişkene atanması
        Dim klasoryeriveadi As String
        klasoryeriveadi = "C:\Users\topal\OneDrive\Desktop\bina\" & klasoradi
        '--------------------------------------------------------------------------

        'klasörün açılması
        System.IO.Directory.CreateDirectory(klasoryeriveadi)
        '-----------------------------------------------------

        'daireno alanının kayıt yerinin ve içine ne yazılacağının kodlanması
        Dim dairenovekayityeri As String
        dairenovekayityeri = klasoryeriveadi & "\" & "Daire No" & ".txt"
        System.IO.File.WriteAllText(dairenovekayityeri, Me.daireno_TextBox1.Text)
        '--------------------------------------------------------------------------

        'klasörün altına formdaki isim ve soyisim alanı için Adi.txt dosyasının yeri ve adının değişkene atanması
        Dim isimveyeri As String
        isimveyeri = klasoryeriveadi & "\" & "Mülk Sahibinin Adı" & ".txt"
        'Adi.txt dosyasının kayıt yeri ve içerisine yazılacak olan bilgi yani formdaki isim ve soyisim alanı
        System.IO.File.WriteAllText(isimveyeri, Me.mulksahibi_TextBox2.Text)
        '------------------------------------------------------------------------------

        'klasörün altına formdaki isim ve soyisim alanı için Adi.txt dosyasının yeri ve adının değişkene atanması
        Dim kiraciisimveyeri As String
        kiraciisimveyeri = klasoryeriveadi & "\" & "Kiracının Adı" & ".txt"
        'Adi.txt dosyasının kayıt yeri ve içerisine yazılacak olan bilgi yani formdaki isim ve soyisim alanı
        System.IO.File.WriteAllText(kiraciisimveyeri, Me.kiraci_TextBox3.Text)
        '------------------------------------------------------------------------------

        'aidat bedeli için dosya açmak ve içini doldurmak
        Dim aidatbedelivekayityeri As String
        aidatbedelivekayityeri = klasoryeriveadi & "\" & "Aidat Bedeli" & ".txt"
        System.IO.File.WriteAllText(aidatbedelivekayityeri, Me.aidat_TextBox4.Text)
        '----------------------------------------------------------------------

        'su sayac için dosya açmak kaydedileceği yeri belirlemek ve içerisine ne yazılacağını belirlemek
        Dim susayacnovekayityeri As String
        susayacnovekayityeri = klasoryeriveadi & "\" & "Su Sayaç No" & ".txt"
        System.IO.File.WriteAllText(susayacnovekayityeri, Me.susayac_TextBox5.Text)

        'elektrik sayaç numarası için açılacak dosyanın adı yeri ve içine ne yazılacağı
        Dim elektriksayacnovekayityeri As String
        elektriksayacnovekayityeri = klasoryeriveadi & "\" & "Elektrik Sayaç No" & ".txt"
        System.IO.File.WriteAllText(elektriksayacnovekayityeri, Me.elektrik_TextBox6.Text)
        '-----------------------------------------------------------------------------------

        'gaz sayaç numarası için açılacak olan dosyanın yolunun ve adının bir değişkene atanması
        Dim gazsayacnovekayityeri As String
        gazsayacnovekayityeri = klasoryeriveadi & "\" & "Gaz Sayaç No" & ".txt"
        'gaz sayacı için oluşturulan değişkenin dosya açılması için kullanılması ve içine ne yazılacağının belirlenmesi
        System.IO.File.WriteAllText(gazsayacnovekayityeri, Me.gaz_TextBox7.Text)
        '--------------------------------------------------------------------------------------

        'yönetici notu için açılacak olan dosyanın yolunun ve adının bir değişkene atanması
        Dim yoneticinotuvekayityeri As String
        yoneticinotuvekayityeri = klasoryeriveadi & "\" & "Yönetici Notu" & ".txt"
        'yönetici notu için oluşturulan değişkenin dosya açılması için kullanılması ve içine ne yazılacağının belirlenmesi
        System.IO.File.WriteAllText(yoneticinotuvekayityeri, Me.yoneticinotu_RichTextBox1.Text)
        '--------------------------------------------------------------------------------------

        'Borcu yoktur raido buton için işaretli ya da değiş IF döngüsü ve sonuca göre .txt dosyasının açılması
        Dim borcdurumuvekayityeri As String
        If borcuyoktur_RadioButton2.Checked = True Then
            borcdurumuvekayityeri = klasoryeriveadi & "\" & "Borç Durumu" & ".txt"
            System.IO.File.WriteAllText(borcdurumuvekayityeri, "Borcu Yoktur")
        Else
            borcdurumuvekayityeri = klasoryeriveadi & "\" & "Borç Durumu" & ".txt"
            System.IO.File.WriteAllText(borcdurumuvekayityeri, "Borcu var Lütfen Borç Açıklamasını Okuyunuz")
        End If
        '-------------------------------------------------------------------------------------------------------

        'Borç açıklaması için richbox oluşturulması ve içerik
        Dim borcaciklamasivekayityeri As String
        borcaciklamasivekayityeri = klasoryeriveadi & "\" & "Borç Açıklaması" & ".txt"
        System.IO.File.WriteAllText(borcaciklamasivekayityeri, Me.borc_RichTextBox1.Text)
        '-----------------------------------------------------------------------------------------------------

        'dairede kim oturuyor .txt dosyasının checkboxlara göre oluşturulması ve değiştirilmesi
        Dim dairedekimoturuyor As String
        dairedekimoturuyor = klasoryeriveadi & "\" & "Dairede Kim Oturuyor" & ".txt"
        If mulk_CheckBox1.Checked = True Then
            System.IO.File.WriteAllText(dairedekimoturuyor, "Dairede şu an mülk sahibi ikamet etmektedir.")
        ElseIf mulk_CheckBox1.Checked = False And kiraci_CheckBox2.checked = False Then
            System.IO.File.WriteAllText(dairedekimoturuyor, "Dairede şu an hiçkimse oturmuyor.")
        ElseIf kiraci_checkBox2.Checked = True Then
            System.IO.File.WriteAllText(dairedekimoturuyor, "Dairede şu an kiracı ikamet etmektedir.")
        End If
        '-------------------------------------------------------------------------------------------------

        'Mülk sahibinin telefonunun kayıt yeri ve içeriğinin kaydedilmesi
        Dim mulksahibitelvekayityeri As String
        mulksahibitelvekayityeri = klasoryeriveadi & "\" & "Mülk Sahibinin Telefon Numarası" & ".txt"
        System.IO.File.WriteAllText(mulksahibitelvekayityeri, Me.mulktel_TextBox8.Text)
        '---------------------------------------------------------------------------------------------------

        'Kiracının telefonunun kayıt yeri ve içeriğinin kaydedilmesi
        Dim kiracitelvekayityeri As String
        kiracitelvekayityeri = klasoryeriveadi & "\" & "Kiracının Telefon Numarası" & ".txt"
        System.IO.File.WriteAllText(kiracitelvekayityeri, Me.kiraci_TextBox9.Text)
        '---------------------------------------------------------------------------------------------------
        MessageBox.Show("Bilgiler Başarıyla Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Forms.Düzenle.Close()
        My.Forms.Daireler.Close()
        My.Forms.Daireler.Show()
    End Sub

    Private Sub mulk_CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles mulk_CheckBox1.CheckedChanged
        If mulk_CheckBox1.Checked = True Then
            kiraci_CheckBox2.Enabled = False
        ElseIf mulk_CheckBox1.Checked = False Then
            kiraci_CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub kiraci_CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles kiraci_CheckBox2.CheckedChanged
        If kiraci_CheckBox2.Checked = True Then
            mulk_CheckBox1.Enabled = False
        ElseIf kiraci_CheckBox2.Checked = False Then
            mulk_CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub borcuyoktur_RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles borcuyoktur_RadioButton2.CheckedChanged
        borc_RichTextBox1.Text = ""
        borc_RichTextBox1.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles borcuvar_RadioButton1.CheckedChanged
        borc_RichTextBox1.Enabled = True
    End Sub
End Class