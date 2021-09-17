<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gider
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fis_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.makbuz_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.belgeno_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yil_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ay_ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.belgesirano_TextBox4 = New System.Windows.Forms.TextBox()
        Me.aciklama_RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.miktar_TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fis_RadioButton1
        '
        Me.fis_RadioButton1.AutoSize = True
        Me.fis_RadioButton1.Location = New System.Drawing.Point(12, 9)
        Me.fis_RadioButton1.Name = "fis_RadioButton1"
        Me.fis_RadioButton1.Size = New System.Drawing.Size(77, 19)
        Me.fis_RadioButton1.TabIndex = 1
        Me.fis_RadioButton1.TabStop = True
        Me.fis_RadioButton1.Text = "Fiş/Fatura"
        Me.fis_RadioButton1.UseVisualStyleBackColor = True
        '
        'makbuz_RadioButton2
        '
        Me.makbuz_RadioButton2.AutoSize = True
        Me.makbuz_RadioButton2.Location = New System.Drawing.Point(95, 9)
        Me.makbuz_RadioButton2.Name = "makbuz_RadioButton2"
        Me.makbuz_RadioButton2.Size = New System.Drawing.Size(67, 19)
        Me.makbuz_RadioButton2.TabIndex = 2
        Me.makbuz_RadioButton2.TabStop = True
        Me.makbuz_RadioButton2.Text = "Makbuz"
        Me.makbuz_RadioButton2.UseVisualStyleBackColor = True
        '
        'belgeno_TextBox1
        '
        Me.belgeno_TextBox1.Location = New System.Drawing.Point(104, 70)
        Me.belgeno_TextBox1.Name = "belgeno_TextBox1"
        Me.belgeno_TextBox1.Size = New System.Drawing.Size(192, 23)
        Me.belgeno_TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Belge No:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 49)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dahil Olduğu Gider Zaman Dilimi"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Düzenlenme Tarihi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Açıklama:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Yıl"
        '
        'yil_ComboBox1
        '
        Me.yil_ComboBox1.FormattingEnabled = True
        Me.yil_ComboBox1.Location = New System.Drawing.Point(133, 128)
        Me.yil_ComboBox1.Name = "yil_ComboBox1"
        Me.yil_ComboBox1.Size = New System.Drawing.Size(163, 23)
        Me.yil_ComboBox1.TabIndex = 12
        '
        'ay_ComboBox2
        '
        Me.ay_ComboBox2.FormattingEnabled = True
        Me.ay_ComboBox2.Location = New System.Drawing.Point(133, 157)
        Me.ay_ComboBox2.Name = "ay_ComboBox2"
        Me.ay_ComboBox2.Size = New System.Drawing.Size(163, 23)
        Me.ay_ComboBox2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(107, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Belge Sıra No:"
        '
        'belgesirano_TextBox4
        '
        Me.belgesirano_TextBox4.Location = New System.Drawing.Point(104, 40)
        Me.belgesirano_TextBox4.Name = "belgesirano_TextBox4"
        Me.belgesirano_TextBox4.Size = New System.Drawing.Size(111, 23)
        Me.belgesirano_TextBox4.TabIndex = 15
        '
        'aciklama_RichTextBox1
        '
        Me.aciklama_RichTextBox1.Location = New System.Drawing.Point(104, 218)
        Me.aciklama_RichTextBox1.Name = "aciklama_RichTextBox1"
        Me.aciklama_RichTextBox1.Size = New System.Drawing.Size(192, 115)
        Me.aciklama_RichTextBox1.TabIndex = 17
        Me.aciklama_RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(221, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Bul"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 99)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 23)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(140, 339)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Kaydı Sil"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Miktar:"
        '
        'miktar_TextBox1
        '
        Me.miktar_TextBox1.Location = New System.Drawing.Point(104, 187)
        Me.miktar_TextBox1.Name = "miktar_TextBox1"
        Me.miktar_TextBox1.Size = New System.Drawing.Size(192, 23)
        Me.miktar_TextBox1.TabIndex = 22
        '
        'Gider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(307, 376)
        Me.Controls.Add(Me.miktar_TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.aciklama_RichTextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.belgesirano_TextBox4)
        Me.Controls.Add(Me.ay_ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.yil_ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.belgeno_TextBox1)
        Me.Controls.Add(Me.makbuz_RadioButton2)
        Me.Controls.Add(Me.fis_RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Gider"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gider"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents fis_RadioButton1 As RadioButton
    Friend WithEvents makbuz_RadioButton2 As RadioButton
    Friend WithEvents belgeno_TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents yil_ComboBox1 As ComboBox
    Friend WithEvents ay_ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents belgesirano_TextBox4 As TextBox
    Friend WithEvents aciklama_RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents miktar_TextBox1 As TextBox
End Class
