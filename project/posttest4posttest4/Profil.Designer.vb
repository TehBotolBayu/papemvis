<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kelamin = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttgllahir = New System.Windows.Forms.DateTimePicker()
        Me.btnregis = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(165, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Profil"
        '
        'kelamin
        '
        Me.kelamin.FormattingEnabled = True
        Me.kelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.kelamin.Location = New System.Drawing.Point(31, 231)
        Me.kelamin.Name = "kelamin"
        Me.kelamin.Size = New System.Drawing.Size(311, 21)
        Me.kelamin.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(28, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txttgllahir
        '
        Me.txttgllahir.Location = New System.Drawing.Point(30, 179)
        Me.txttgllahir.Name = "txttgllahir"
        Me.txttgllahir.Size = New System.Drawing.Size(312, 20)
        Me.txttgllahir.TabIndex = 29
        '
        'btnregis
        '
        Me.btnregis.BackColor = System.Drawing.Color.Violet
        Me.btnregis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnregis.FlatAppearance.BorderSize = 0
        Me.btnregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregis.ForeColor = System.Drawing.Color.White
        Me.btnregis.Location = New System.Drawing.Point(30, 335)
        Me.btnregis.Name = "btnregis"
        Me.btnregis.Size = New System.Drawing.Size(312, 23)
        Me.btnregis.TabIndex = 26
        Me.btnregis.Text = "Ubah"
        Me.btnregis.UseVisualStyleBackColor = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(31, 130)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(311, 20)
        Me.txtemail.TabIndex = 25
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(31, 86)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(311, 20)
        Me.txtnama.TabIndex = 23
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(31, 281)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(311, 20)
        Me.txtpassword.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nama"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.posttest4posttest4.My.Resources.Resources.Vector
        Me.PictureBox2.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(369, 406)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kelamin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttgllahir)
        Me.Controls.Add(Me.btnregis)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Profil"
        Me.Text = "Profil"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents kelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnregis As System.Windows.Forms.Button
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
