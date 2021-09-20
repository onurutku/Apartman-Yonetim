<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hesapla
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.yil_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ay_ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gider_TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.giderler_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'yil_ComboBox1
        '
        Me.yil_ComboBox1.FormattingEnabled = True
        Me.yil_ComboBox1.Items.AddRange(New Object() {"2021", "2022", "2023"})
        Me.yil_ComboBox1.Location = New System.Drawing.Point(84, 39)
        Me.yil_ComboBox1.Name = "yil_ComboBox1"
        Me.yil_ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.yil_ComboBox1.TabIndex = 0
        '
        'ay_ComboBox2
        '
        Me.ay_ComboBox2.FormattingEnabled = True
        Me.ay_ComboBox2.Location = New System.Drawing.Point(84, 68)
        Me.ay_ComboBox2.Name = "ay_ComboBox2"
        Me.ay_ComboBox2.Size = New System.Drawing.Size(121, 23)
        Me.ay_ComboBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hesapla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Yıl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ay"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(94, 189)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(232, 160)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Açıklama:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Aidat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Gider"
        '
        'gider_TextBox2
        '
        Me.gider_TextBox2.Location = New System.Drawing.Point(106, 126)
        Me.gider_TextBox2.Name = "gider_TextBox2"
        Me.gider_TextBox2.ReadOnly = True
        Me.gider_TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.gider_TextBox2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kalan"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(105, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 12
        '
        'giderler_ComboBox1
        '
        Me.giderler_ComboBox1.FormattingEnabled = True
        Me.giderler_ComboBox1.Location = New System.Drawing.Point(212, 126)
        Me.giderler_ComboBox1.Name = "giderler_ComboBox1"
        Me.giderler_ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.giderler_ComboBox1.TabIndex = 14
        '
        'Hesapla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(338, 390)
        Me.Controls.Add(Me.giderler_ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gider_TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ay_ComboBox2)
        Me.Controls.Add(Me.yil_ComboBox1)
        Me.Name = "Hesapla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hesapla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yil_ComboBox1 As ComboBox
    Friend WithEvents ay_ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents giderler_ComboBox1 As ComboBox
    Friend WithEvents gider_TextBox2 As TextBox
End Class
