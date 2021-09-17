Public Class Daireler
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub Daireler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file14 As String
        file14 = "C:\Users\topal\OneDrive\Desktop\bina\14"
        If System.IO.Directory.Exists(file14) Then
            Dim okukiraciadi14 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Kiracının Adı.txt")
            Dim okumulksahibiadi14 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Mülk Sahibinin Adı.txt")
            Dim korm14 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Dairede Kim Oturuyor.txt")
            If korm14 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire14_Button1.Text = "14" & " " & okukiraciadi14 & " " & "(Kiracı)"
            ElseIf korm14 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire14_Button1.Text = "14" & " " & okumulksahibiadi14 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file13 As String
        file13 = "C:\Users\topal\OneDrive\Desktop\bina\13"
        If System.IO.Directory.Exists(file13) Then
            Dim okukiraciadi13 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Kiracının Adı.txt")
            Dim okumulksahibiadi13 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Mülk Sahibinin Adı.txt")
            Dim korm13 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Dairede Kim Oturuyor.txt")
            If korm13 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire13_Button1.Text = "13" & " " & okukiraciadi13 & " " & "(Kiracı)"
            ElseIf korm13 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire13_Button1.Text = "13" & " " & okumulksahibiadi13 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file12 As String
        file12 = "C:\Users\topal\OneDrive\Desktop\bina\12"
        If System.IO.Directory.Exists(file12) Then
            Dim okukiraciadi12 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Kiracının Adı.txt")
            Dim okumulksahibiadi12 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Mülk Sahibinin Adı.txt")
            Dim korm12 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Dairede Kim Oturuyor.txt")
            If korm12 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire12_Button1.Text = "12" & " " & okukiraciadi12 & " " & "(Kiracı)"
            ElseIf korm12 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire12_Button1.Text = "12" & " " & okumulksahibiadi12 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file11 As String
        file11 = "C:\Users\topal\OneDrive\Desktop\bina\11"
        If System.IO.Directory.Exists(file11) Then
            Dim okukiraciadi11 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Kiracının Adı.txt")
            Dim okumulksahibiadi11 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Mülk Sahibinin Adı.txt")
            Dim korm11 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Dairede Kim Oturuyor.txt")
            If korm11 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire11_Button1.Text = "11" & " " & okukiraciadi11 & " " & "(Kiracı)"
            ElseIf korm11 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire11_Button1.Text = "11" & " " & okumulksahibiadi11 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file10 As String
        file10 = "C:\Users\topal\OneDrive\Desktop\bina\10"
        If System.IO.Directory.Exists(file10) Then
            Dim okukiraciadi10 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Kiracının Adı.txt")
            Dim okumulksahibiadi10 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Mülk Sahibinin Adı.txt")
            Dim korm10 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Dairede Kim Oturuyor.txt")
            If korm10 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire10_Button1.Text = "10" & " " & okukiraciadi10 & " " & "(Kiracı)"
            ElseIf korm10 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire10_Button1.Text = "10" & " " & okumulksahibiadi10 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file9 As String
        file9 = "C:\Users\topal\OneDrive\Desktop\bina\9"
        If System.IO.Directory.Exists(file9) Then
            Dim okukiraciadi9 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Kiracının Adı.txt")
            Dim okumulksahibiadi9 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Mülk Sahibinin Adı.txt")
            Dim korm9 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Dairede Kim Oturuyor.txt")
            If korm9 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire9_Button1.Text = "9" & " " & okukiraciadi9 & " " & "(Kiracı)"
            ElseIf korm9 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire9_Button1.Text = "9" & " " & okumulksahibiadi9 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file8 As String
        file8 = "C:\Users\topal\OneDrive\Desktop\bina\8"
        If System.IO.Directory.Exists(file8) Then
            Dim okukiraciadi8 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Kiracının Adı.txt")
            Dim okumulksahibiadi8 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Mülk Sahibinin Adı.txt")
            Dim korm8 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Dairede Kim Oturuyor.txt")
            If korm8 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire8_Button1.Text = "8" & " " & okukiraciadi8 & " " & "(Kiracı)"
            ElseIf korm8 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire8_Button1.Text = "8" & " " & okumulksahibiadi8 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file7 As String
        file7 = "C:\Users\topal\OneDrive\Desktop\bina\7"
        If System.IO.Directory.Exists(file7) Then
            Dim okukiraciadi7 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Kiracının Adı.txt")
            Dim okumulksahibiadi7 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Mülk Sahibinin Adı.txt")
            Dim korm7 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Dairede Kim Oturuyor.txt")
            If korm7 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire7_Button1.Text = "7" & " " & okukiraciadi7 & " " & "(Kiracı)"
            ElseIf korm7 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire7_Button1.Text = "7" & " " & okumulksahibiadi7 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file6 As String
        file6 = "C:\Users\topal\OneDrive\Desktop\bina\6"
        If System.IO.Directory.Exists(file6) Then
            Dim okukiraciadi6 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Kiracının Adı.txt")
            Dim okumulksahibiadi6 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Mülk Sahibinin Adı.txt")
            Dim korm6 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Dairede Kim Oturuyor.txt")
            If korm6 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire6_Button1.Text = "6" & " " & okukiraciadi6 & " " & "(Kiracı)"
            ElseIf korm6 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire6_Button1.Text = "6" & " " & okumulksahibiadi6 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file5 As String
        file5 = "C:\Users\topal\OneDrive\Desktop\bina\5"
        If System.IO.Directory.Exists(file5) Then
            Dim okukiraciadi5 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Kiracının Adı.txt")
            Dim okumulksahibiadi5 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Mülk Sahibinin Adı.txt")
            Dim korm5 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Dairede Kim Oturuyor.txt")
            If korm5 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire5_Button1.Text = "5" & " " & okukiraciadi5 & " " & "(Kiracı)"
            ElseIf korm5 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire5_Button1.Text = "5" & " " & okumulksahibiadi5 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file4 As String
        file4 = "C:\Users\topal\OneDrive\Desktop\bina\4"
        If System.IO.Directory.Exists(file4) Then
            Dim okukiraciadi4 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Kiracının Adı.txt")
            Dim okumulksahibiadi4 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Mülk Sahibinin Adı.txt")
            Dim korm4 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Dairede Kim Oturuyor.txt")
            If korm4 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire4_Button1.Text = "4" & " " & okukiraciadi4 & " " & "(Kiracı)"
            ElseIf korm4 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire4_Button1.Text = "4" & " " & okumulksahibiadi4 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file3 As String
        file3 = "C:\Users\topal\OneDrive\Desktop\bina\3"
        If System.IO.Directory.Exists(file3) Then
            Dim okukiraciadi3 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Kiracının Adı.txt")
            Dim okumulksahibiadi3 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Mülk Sahibinin Adı.txt")
            Dim korm3 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Dairede Kim Oturuyor.txt")
            If korm3 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire3_Button1.Text = "3" & " " & okukiraciadi3 & " " & "(Kiracı)"
            ElseIf korm3 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire3_Button1.Text = "3" & " " & okumulksahibiadi3 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file2 As String
        file2 = "C:\Users\topal\OneDrive\Desktop\bina\2"
        If System.IO.Directory.Exists(file2) Then
            Dim okukiraciadi2 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Kiracının Adı.txt")
            Dim okumulksahibiadi2 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Mülk Sahibinin Adı.txt")
            Dim korm2 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Dairede Kim Oturuyor.txt")
            If korm2 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire2_Button1.Text = "2" & " " & okukiraciadi2 & " " & "(Kiracı)"
            ElseIf korm2 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire2_Button1.Text = "2" & " " & okumulksahibiadi2 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file1 As String
        file1 = "C:\Users\topal\OneDrive\Desktop\bina\1"
        If System.IO.Directory.Exists(file1) Then
            Dim okukiraciadi1 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Kiracının Adı.txt")
            Dim okumulksahibiadi1 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Mülk Sahibinin Adı.txt")
            Dim korm1 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Dairede Kim Oturuyor.txt")
            If korm1 = "Dairede şu an kiracı ikamet etmektedir." Then
                daire1_Button1.Text = "1" & " " & okukiraciadi1 & " " & "(Kiracı)"
            ElseIf korm1 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                daire1_Button1.Text = "1" & " " & okumulksahibiadi1 & " " & "(Mülk Sahibi)"
            End If
        End If
        Dim file15 As String
        file15 = "C:\Users\topal\OneDrive\Desktop\bina\Görevli"
        If System.IO.Directory.Exists(file15) Then
            Dim okukiraciadi15 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Kiracının Adı.txt")
            Dim okumulksahibiadi15 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Mülk Sahibinin Adı.txt")
            Dim korm1 As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Dairede Kim Oturuyor.txt")
            If korm1 = "Dairede şu an kiracı ikamet etmektedir." Then
                apt_Button1.Text = okukiraciadi15 & " " & "(Görevli)"
            ElseIf korm1 = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                apt_Button1.Text = okumulksahibiadi15 & " " & "(Boş)"
            End If
        End If
        Dim file16 As String
        file16 = "C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi"
        If System.IO.Directory.Exists(file16) Then
            kazan_Button1.Text = "Kazan Dairesi"
        End If

        'Dim no As Integer
        'Dim file As String
        'For no = 1 To 16
        '    file = "C:\Users\topal\OneDrive\Desktop\bina\" & no
        '    If System.IO.Directory.Exists(file) Then
        '        Dim okukiraciadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Kiracının Adı.txt")
        '        Dim okumulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Mülk Sahibinin Adı.txt")
        '        Dim korm As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Dairede Kim Oturuyor.txt")
        '        If korm = "Dairede şu an kiracı ikamet etmektedir." Then
        '            daire7_Button1.Text = no & " " & okukiraciadi & " " & "(Kiracı)"
        '        ElseIf korm = "Dairede şu an mülk sahibi ikamet etmektedir." Then
        '            daire7_Button1.Text = no & " " & okumulksahibiadi & " " & "(Mülk Sahibi)"
        '        End If
        '    End If
        'Next

        'Dim letters() As String = {"daire1_button1.text", "daire2_button1.text", "daire3_button1.text", "daire4_button1.text", "daire5_button1.text",
        '"daire6_button1.text", "daire7_button1.text", "daire8_button1.text", "daire9_button1.text", "daire10_button1.text", "daire11_button1.text",
        '"daire12_button1.text", "daire13_button1.text", "daire14_button1.text", "daire15_button1.text", "daire16_button1.text"}

        'For no = 1 To 16
        '    'Dim buton = "daire" & no & "_button1.text"
        '    Dim file As String
        '    file = "C:\Users\topal\OneDrive\Desktop\bina\" & no
        '    If System.IO.Directory.Exists(file) Then
        '        Dim buton As Button
        '        Dim okukiraciadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Kiracının Adı.txt")
        '        Dim okumulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Mülk Sahibinin Adı.txt")
        '        Dim korm As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\" & no & "\Dairede Kim Oturuyor.txt")
        '        If buton.Name = "daire" & no & "_button1" Then
        '            If korm = "Dairede şu an kiracı ikamet etmektedir." Then
        '                buton.Text = no & " " & okukiraciadi & " " & "(Kiracı)"
        '            ElseIf korm = "Dairede şu an mülk sahibi ikamet etmektedir." Then
        '                buton.Text = no & " " & okumulksahibiadi & " " & "(Mülk Sahibi)"
        '            ElseIf korm = "" Then
        '                buton.Text = no & " " & okumulksahibiadi & " " & "(Daire Boş)"
        '            End If
        '        End If
        '    End If
        'Next


    End Sub

    Private Sub daire14_Button1_Click(sender As Object, e As EventArgs) Handles daire14_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file14 As String
        file14 = "C:\Users\topal\OneDrive\Desktop\bina\14"
        If System.IO.Directory.Exists(file14) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\14\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire13_Button1_Click(sender As Object, e As EventArgs) Handles daire13_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file13 As String
        file13 = "C:\Users\topal\OneDrive\Desktop\bina\13"
        If System.IO.Directory.Exists(file13) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\13\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire12_Button1_Click(sender As Object, e As EventArgs) Handles daire12_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file12 As String
        file12 = "C:\Users\topal\OneDrive\Desktop\bina\12"
        If System.IO.Directory.Exists(file12) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\12\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire11_Button1_Click(sender As Object, e As EventArgs) Handles daire11_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file11 As String
        file11 = "C:\Users\topal\OneDrive\Desktop\bina\11"
        If System.IO.Directory.Exists(file11) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\11\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub
    Private Sub daire10_Button1_Click(sender As Object, e As EventArgs) Handles daire10_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file10 As String
        file10 = "C:\Users\topal\OneDrive\Desktop\bina\10"
        If System.IO.Directory.Exists(file10) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\10\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire9_Button1_Click(sender As Object, e As EventArgs) Handles daire9_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file9 As String
        file9 = "C:\Users\topal\OneDrive\Desktop\bina\9"
        If System.IO.Directory.Exists(file9) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\9\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire8_Button1_Click(sender As Object, e As EventArgs) Handles daire8_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file8 As String
        file8 = "C:\Users\topal\OneDrive\Desktop\bina\8"
        If System.IO.Directory.Exists(file8) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\8\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire7_Button1_Click(sender As Object, e As EventArgs) Handles daire7_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file7 As String
        file7 = "C:\Users\topal\OneDrive\Desktop\bina\7"
        If System.IO.Directory.Exists(file7) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\7\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire6_Button1_Click(sender As Object, e As EventArgs) Handles daire6_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file6 As String
        file6 = "C:\Users\topal\OneDrive\Desktop\bina\6"
        If System.IO.Directory.Exists(file6) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\6\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire5_Button1_Click(sender As Object, e As EventArgs) Handles daire5_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file5 As String
        file5 = "C:\Users\topal\OneDrive\Desktop\bina\5"
        If System.IO.Directory.Exists(file5) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\5\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire4_Button1_Click(sender As Object, e As EventArgs) Handles daire4_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file4 As String
        file4 = "C:\Users\topal\OneDrive\Desktop\bina\4"
        If System.IO.Directory.Exists(file4) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\4\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire3_Button1_Click(sender As Object, e As EventArgs) Handles daire3_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file3 As String
        file3 = "C:\Users\topal\OneDrive\Desktop\bina\3"
        If System.IO.Directory.Exists(file3) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\3\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire2_Button1_Click(sender As Object, e As EventArgs) Handles daire2_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file2 As String
        file2 = "C:\Users\topal\OneDrive\Desktop\bina\2"
        If System.IO.Directory.Exists(file2) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\2\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub daire1_Button1_Click(sender As Object, e As EventArgs) Handles daire1_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file1 As String
        file1 = "C:\Users\topal\OneDrive\Desktop\bina\1"
        If System.IO.Directory.Exists(file1) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\1\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub apt_Button1_Click(sender As Object, e As EventArgs) Handles apt_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file15 As String
        file15 = "C:\Users\topal\OneDrive\Desktop\bina\Görevli"
        If System.IO.Directory.Exists(file15) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Görevli\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub kazan_Button1_Click(sender As Object, e As EventArgs) Handles kazan_Button1.Click
        My.Forms.Düzenle.Show()
        Dim file16 As String
        file16 = "C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi"
        If System.IO.Directory.Exists(file16) Then
            Dim aidatbedeli As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Aidat Bedeli.txt")
            Dim borcaciklamasi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Borç Açıklaması.txt")
            Dim borcdurumu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Borç Durumu.txt")
            Dim daireno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Daire No.txt")
            Dim dairedekimoturuyor As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Dairede Kim Oturuyor.txt")
            Dim elektriksayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Elektrik Sayaç No.txt")
            Dim gazsayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Gaz Sayaç No.txt")
            Dim kiracininadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Kiracının Adı.txt")
            Dim kiracitelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Kiracının Telefon Numarası.txt")
            Dim mulksahibiadi As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Mülk Sahibinin Adı.txt")
            Dim mulktelno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Mülk Sahibinin Telefon Numarası.txt")
            Dim susayacno As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Su Sayaç No.txt")
            Dim yoneticinotu As String = System.IO.File.ReadAllText("C:\Users\topal\OneDrive\Desktop\bina\Kazan Dairesi\Yönetici Notu.txt")
            My.Forms.Düzenle.aidat_TextBox4.Text = aidatbedeli
            My.Forms.Düzenle.borc_RichTextBox1.Text = borcaciklamasi
            If borcdurumu = "Borcu var Lütfen Borç Açıklamasını Okuyunuz" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = True
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = False
            ElseIf borcdurumu = "Borcu Yoktur" Then
                My.Forms.Düzenle.borcuvar_RadioButton1.Checked = False
                My.Forms.Düzenle.borcuyoktur_RadioButton2.Checked = True
            End If
            My.Forms.Düzenle.daireno_TextBox1.Text = daireno
            If dairedekimoturuyor = "Dairede şu an hiçkimse oturmuyor." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an mülk sahibi ikamet etmektedir." Then
                My.Forms.Düzenle.mulk_CheckBox1.Checked = True
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = False
            ElseIf dairedekimoturuyor = "Dairede şu an kiracı ikamet etmektedir." Then
                My.Forms.Düzenle.kiraci_CheckBox2.Checked = True
                My.Forms.Düzenle.mulk_CheckBox1.Checked = False
            End If
            My.Forms.Düzenle.elektrik_TextBox6.Text = elektriksayacno
            My.Forms.Düzenle.gaz_TextBox7.Text = gazsayacno
            My.Forms.Düzenle.kiraci_TextBox3.Text = kiracininadi
            My.Forms.Düzenle.kiraci_TextBox9.Text = kiracitelno
            My.Forms.Düzenle.mulksahibi_TextBox2.Text = mulksahibiadi
            My.Forms.Düzenle.mulktel_TextBox8.Text = mulktelno
            My.Forms.Düzenle.susayac_TextBox5.Text = susayacno
            My.Forms.Düzenle.yoneticinotu_RichTextBox1.Text = yoneticinotu
        End If
    End Sub
End Class