<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtkonpassword = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btnregis = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttgllahir = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kelamin = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.txtberat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.taktivitas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(418, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 285)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(39, 366)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Konfirmasi Password"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(45, 158)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(330, 26)
        Me.txtnama.TabIndex = 6
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(45, 305)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(330, 26)
        Me.txtpassword.TabIndex = 5
        '
        'txtkonpassword
        '
        Me.txtkonpassword.Location = New System.Drawing.Point(45, 391)
        Me.txtkonpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtkonpassword.Name = "txtkonpassword"
        Me.txtkonpassword.Size = New System.Drawing.Size(330, 26)
        Me.txtkonpassword.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(45, 226)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(330, 26)
        Me.txtemail.TabIndex = 9
        '
        'btnregis
        '
        Me.btnregis.BackColor = System.Drawing.Color.Violet
        Me.btnregis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnregis.FlatAppearance.BorderSize = 0
        Me.btnregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregis.Location = New System.Drawing.Point(168, 535)
        Me.btnregis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnregis.Name = "btnregis"
        Me.btnregis.Size = New System.Drawing.Size(468, 35)
        Me.btnregis.TabIndex = 10
        Me.btnregis.Text = "Registrasi"
        Me.btnregis.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(450, 598)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 598)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sudah punya akun?"
        '
        'txttgllahir
        '
        Me.txttgllahir.Location = New System.Drawing.Point(422, 305)
        Me.txttgllahir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttgllahir.Name = "txttgllahir"
        Me.txttgllahir.Size = New System.Drawing.Size(331, 26)
        Me.txttgllahir.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(418, 366)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jenis Kelamin"
        '
        'kelamin
        '
        Me.kelamin.FormattingEnabled = True
        Me.kelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.kelamin.Location = New System.Drawing.Point(423, 391)
        Me.kelamin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kelamin.Name = "kelamin"
        Me.kelamin.Size = New System.Drawing.Size(330, 28)
        Me.kelamin.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(333, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Registrasi"
        '
        'txttinggi
        '
        Me.txttinggi.Location = New System.Drawing.Point(423, 226)
        Me.txttinggi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(330, 26)
        Me.txttinggi.TabIndex = 20
        '
        'txtberat
        '
        Me.txtberat.Location = New System.Drawing.Point(423, 158)
        Me.txtberat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(330, 26)
        Me.txtberat.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(418, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tinggi Badan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(418, 120)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Berat Badan"
        '
        'taktivitas
        '
        Me.taktivitas.FormattingEnabled = True
        Me.taktivitas.Items.AddRange(New Object() {"Santai", "Ringan", "Sedang", "Berat", "Ekstrem"})
        Me.taktivitas.Location = New System.Drawing.Point(244, 462)
        Me.taktivitas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.taktivitas.Name = "taktivitas"
        Me.taktivitas.Size = New System.Drawing.Size(330, 28)
        Me.taktivitas.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(240, 437)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Aktivitas"
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkPassword.ForeColor = System.Drawing.Color.White
        Me.chkPassword.Location = New System.Drawing.Point(348, 394)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(22, 21)
        Me.chkPassword.TabIndex = 23
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'Registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(801, 645)
        Me.Controls.Add(Me.chkPassword)
        Me.Controls.Add(Me.taktivitas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.txtberat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kelamin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttgllahir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnregis)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtkonpassword)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Registrasi"
        Me.Text = "Registrasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtkonpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btnregis As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents kelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents txtberat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents taktivitas As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkPassword As CheckBox
End Class
