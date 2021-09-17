<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Düzenle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.daireno_TextBox1 = New System.Windows.Forms.TextBox()
        Me.mulksahibi_TextBox2 = New System.Windows.Forms.TextBox()
        Me.kiraci_TextBox3 = New System.Windows.Forms.TextBox()
        Me.aidat_TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.susayac_TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.elektrik_TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gaz_TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.yoneticinotu_RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.mulktel_TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kiraci_TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.borcuyoktur_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mulk_CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.kiraci_CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.borcuvar_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.borc_RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daire No:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mülk Sahibi:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(39, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kiracı:"
        '
        'daireno_TextBox1
        '
        Me.daireno_TextBox1.Location = New System.Drawing.Point(121, 34)
        Me.daireno_TextBox1.Name = "daireno_TextBox1"
        Me.daireno_TextBox1.Size = New System.Drawing.Size(194, 23)
        Me.daireno_TextBox1.TabIndex = 5
        '
        'mulksahibi_TextBox2
        '
        Me.mulksahibi_TextBox2.Location = New System.Drawing.Point(121, 64)
        Me.mulksahibi_TextBox2.Name = "mulksahibi_TextBox2"
        Me.mulksahibi_TextBox2.Size = New System.Drawing.Size(194, 23)
        Me.mulksahibi_TextBox2.TabIndex = 6
        '
        'kiraci_TextBox3
        '
        Me.kiraci_TextBox3.Location = New System.Drawing.Point(121, 94)
        Me.kiraci_TextBox3.Name = "kiraci_TextBox3"
        Me.kiraci_TextBox3.Size = New System.Drawing.Size(194, 23)
        Me.kiraci_TextBox3.TabIndex = 7
        '
        'aidat_TextBox4
        '
        Me.aidat_TextBox4.Location = New System.Drawing.Point(121, 123)
        Me.aidat_TextBox4.Name = "aidat_TextBox4"
        Me.aidat_TextBox4.Size = New System.Drawing.Size(194, 23)
        Me.aidat_TextBox4.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(39, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Aidat Bedeli:"
        '
        'susayac_TextBox5
        '
        Me.susayac_TextBox5.Location = New System.Drawing.Point(121, 152)
        Me.susayac_TextBox5.Name = "susayac_TextBox5"
        Me.susayac_TextBox5.Size = New System.Drawing.Size(194, 23)
        Me.susayac_TextBox5.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(39, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Su Sayaç No:"
        '
        'elektrik_TextBox6
        '
        Me.elektrik_TextBox6.Location = New System.Drawing.Point(121, 181)
        Me.elektrik_TextBox6.Name = "elektrik_TextBox6"
        Me.elektrik_TextBox6.Size = New System.Drawing.Size(194, 23)
        Me.elektrik_TextBox6.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(39, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 37)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Elektrik Sayaç No:"
        '
        'gaz_TextBox7
        '
        Me.gaz_TextBox7.Location = New System.Drawing.Point(121, 215)
        Me.gaz_TextBox7.Name = "gaz_TextBox7"
        Me.gaz_TextBox7.Size = New System.Drawing.Size(194, 23)
        Me.gaz_TextBox7.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(39, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 30)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Gaz Sayaç No:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(39, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 30)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Yönetici Notu:"
        '
        'yoneticinotu_RichTextBox1
        '
        Me.yoneticinotu_RichTextBox1.Location = New System.Drawing.Point(121, 251)
        Me.yoneticinotu_RichTextBox1.Name = "yoneticinotu_RichTextBox1"
        Me.yoneticinotu_RichTextBox1.Size = New System.Drawing.Size(194, 68)
        Me.yoneticinotu_RichTextBox1.TabIndex = 20
        Me.yoneticinotu_RichTextBox1.Text = ""
        '
        'mulktel_TextBox8
        '
        Me.mulktel_TextBox8.Location = New System.Drawing.Point(360, 64)
        Me.mulktel_TextBox8.Name = "mulktel_TextBox8"
        Me.mulktel_TextBox8.Size = New System.Drawing.Size(191, 23)
        Me.mulktel_TextBox8.TabIndex = 21
        Me.mulktel_TextBox8.Text = "(0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tel:"
        '
        'kiraci_TextBox9
        '
        Me.kiraci_TextBox9.Location = New System.Drawing.Point(360, 94)
        Me.kiraci_TextBox9.Name = "kiraci_TextBox9"
        Me.kiraci_TextBox9.Size = New System.Drawing.Size(191, 23)
        Me.kiraci_TextBox9.TabIndex = 23
        Me.kiraci_TextBox9.Text = "(0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tel:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'borcuyoktur_RadioButton2
        '
        Me.borcuyoktur_RadioButton2.AutoSize = True
        Me.borcuyoktur_RadioButton2.Location = New System.Drawing.Point(121, 331)
        Me.borcuyoktur_RadioButton2.Name = "borcuyoktur_RadioButton2"
        Me.borcuyoktur_RadioButton2.Size = New System.Drawing.Size(93, 19)
        Me.borcuyoktur_RadioButton2.TabIndex = 25
        Me.borcuyoktur_RadioButton2.TabStop = True
        Me.borcuyoktur_RadioButton2.Text = "Borcu Yoktur"
        Me.borcuyoktur_RadioButton2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "İptal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mulk_CheckBox1
        '
        Me.mulk_CheckBox1.AutoSize = True
        Me.mulk_CheckBox1.Location = New System.Drawing.Point(18, 66)
        Me.mulk_CheckBox1.Name = "mulk_CheckBox1"
        Me.mulk_CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.mulk_CheckBox1.TabIndex = 27
        Me.mulk_CheckBox1.UseVisualStyleBackColor = True
        '
        'kiraci_CheckBox2
        '
        Me.kiraci_CheckBox2.AutoSize = True
        Me.kiraci_CheckBox2.Location = New System.Drawing.Point(18, 96)
        Me.kiraci_CheckBox2.Name = "kiraci_CheckBox2"
        Me.kiraci_CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.kiraci_CheckBox2.TabIndex = 28
        Me.kiraci_CheckBox2.UseVisualStyleBackColor = True
        '
        'borcuvar_RadioButton1
        '
        Me.borcuvar_RadioButton1.AutoSize = True
        Me.borcuvar_RadioButton1.Location = New System.Drawing.Point(121, 357)
        Me.borcuvar_RadioButton1.Name = "borcuvar_RadioButton1"
        Me.borcuvar_RadioButton1.Size = New System.Drawing.Size(75, 19)
        Me.borcuvar_RadioButton1.TabIndex = 29
        Me.borcuvar_RadioButton1.TabStop = True
        Me.borcuvar_RadioButton1.Text = "Borcu Var"
        Me.borcuvar_RadioButton1.UseVisualStyleBackColor = True
        '
        'borc_RichTextBox1
        '
        Me.borc_RichTextBox1.Location = New System.Drawing.Point(121, 383)
        Me.borc_RichTextBox1.Name = "borc_RichTextBox1"
        Me.borc_RichTextBox1.Size = New System.Drawing.Size(194, 96)
        Me.borc_RichTextBox1.TabIndex = 30
        Me.borc_RichTextBox1.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(39, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 51)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Lütfen Açıklama Giriniz:"
        '
        'Düzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(562, 513)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.borc_RichTextBox1)
        Me.Controls.Add(Me.borcuvar_RadioButton1)
        Me.Controls.Add(Me.kiraci_CheckBox2)
        Me.Controls.Add(Me.mulk_CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.borcuyoktur_RadioButton2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kiraci_TextBox9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mulktel_TextBox8)
        Me.Controls.Add(Me.yoneticinotu_RichTextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gaz_TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.elektrik_TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.susayac_TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.aidat_TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.kiraci_TextBox3)
        Me.Controls.Add(Me.mulksahibi_TextBox2)
        Me.Controls.Add(Me.daireno_TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Düzenle"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Düzenle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents daireno_TextBox1 As TextBox
    Friend WithEvents mulksahibi_TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents aidat_TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents susayac_TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents elektrik_TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gaz_TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents yoneticinotu_RichTextBox1 As RichTextBox
    Friend WithEvents mulktel_TextBox8 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents kiraci_TextBox9 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents borcuyoktur_RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents mulk_CheckBox1 As CheckBox
    Friend WithEvents kiraci_CheckBox1 As CheckBox
    Friend WithEvents kiraci_CheckBox2 As CheckBox
    Friend WithEvents kiraci_TextBox3 As TextBox
    Friend WithEvents borcuvar_RadioButton1 As RadioButton
    Friend WithEvents borc_RichTextBox1 As RichTextBox
    Friend WithEvents Label11 As Label
End Class
