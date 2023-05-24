<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvMakanan = New System.Windows.Forms.DataGridView()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtberat = New System.Windows.Forms.TextBox()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkalori = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.jenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msDataMakanan = New System.Windows.Forms.ToolStripMenuItem()
        Me.msDataUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDataMakanan = New System.Windows.Forms.Panel()
        Me.PanelDataAkun = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cariakun = New System.Windows.Forms.TextBox()
        Me.dgvAkun = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelDataMakanan.SuspendLayout()
        Me.PanelDataAkun.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMakanan
        '
        Me.dgvMakanan.AllowUserToAddRows = False
        Me.dgvMakanan.AllowUserToDeleteRows = False
        Me.dgvMakanan.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvMakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakanan.Location = New System.Drawing.Point(420, 17)
        Me.dgvMakanan.Name = "dgvMakanan"
        Me.dgvMakanan.ReadOnly = True
        Me.dgvMakanan.RowHeadersVisible = False
        Me.dgvMakanan.Size = New System.Drawing.Size(567, 328)
        Me.dgvMakanan.TabIndex = 0
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(28, 96)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(367, 20)
        Me.txtnama.TabIndex = 1
        '
        'txtberat
        '
        Me.txtberat.Location = New System.Drawing.Point(28, 148)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(367, 20)
        Me.txtberat.TabIndex = 2
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(28, 255)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(367, 20)
        Me.txtunit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Berat(gr)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kalori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unit"
        '
        'txtkalori
        '
        Me.txtkalori.Location = New System.Drawing.Point(28, 205)
        Me.txtkalori.Name = "txtkalori"
        Me.txtkalori.Size = New System.Drawing.Size(367, 20)
        Me.txtkalori.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(91, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Manajemen Data Makanan"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(28, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightPink
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(125, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Kosong"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'jenis
        '
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {"Makanan Pokok", "Minuman", "Sayuran", "Buah-buahan", "Lauk-pauk"})
        Me.jenis.Location = New System.Drawing.Point(28, 303)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(367, 21)
        Me.jenis.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jenis Makanan"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightPink
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(222, 368)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightPink
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(320, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Ubah"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.PictureBox2.Image = Global.posttest4posttest4.My.Resources.Resources.search_interface_symbol
        Me.PictureBox2.Location = New System.Drawing.Point(802, 368)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posttest4posttest4.My.Resources.Resources.Vector
        Me.PictureBox1.Location = New System.Drawing.Point(28, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(420, 368)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 20)
        Me.TextBox1.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msDataMakanan, Me.msDataUser, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1005, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msDataMakanan
        '
        Me.msDataMakanan.Name = "msDataMakanan"
        Me.msDataMakanan.Size = New System.Drawing.Size(95, 20)
        Me.msDataMakanan.Text = "Data Makanan"
        '
        'msDataUser
        '
        Me.msDataUser.Name = "msDataUser"
        Me.msDataUser.Size = New System.Drawing.Size(69, 20)
        Me.msDataUser.Text = "Data User"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PanelDataMakanan
        '
        Me.PanelDataMakanan.BackColor = System.Drawing.Color.DarkMagenta
        Me.PanelDataMakanan.Controls.Add(Me.PictureBox2)
        Me.PanelDataMakanan.Controls.Add(Me.Label5)
        Me.PanelDataMakanan.Controls.Add(Me.TextBox1)
        Me.PanelDataMakanan.Controls.Add(Me.Button4)
        Me.PanelDataMakanan.Controls.Add(Me.txtnama)
        Me.PanelDataMakanan.Controls.Add(Me.dgvMakanan)
        Me.PanelDataMakanan.Controls.Add(Me.Button5)
        Me.PanelDataMakanan.Controls.Add(Me.Label1)
        Me.PanelDataMakanan.Controls.Add(Me.PictureBox1)
        Me.PanelDataMakanan.Controls.Add(Me.txtberat)
        Me.PanelDataMakanan.Controls.Add(Me.Button2)
        Me.PanelDataMakanan.Controls.Add(Me.jenis)
        Me.PanelDataMakanan.Controls.Add(Me.Button1)
        Me.PanelDataMakanan.Controls.Add(Me.Label6)
        Me.PanelDataMakanan.Controls.Add(Me.Label2)
        Me.PanelDataMakanan.Controls.Add(Me.Label3)
        Me.PanelDataMakanan.Controls.Add(Me.txtkalori)
        Me.PanelDataMakanan.Controls.Add(Me.txtunit)
        Me.PanelDataMakanan.Controls.Add(Me.Label4)
        Me.PanelDataMakanan.Location = New System.Drawing.Point(0, 27)
        Me.PanelDataMakanan.Name = "PanelDataMakanan"
        Me.PanelDataMakanan.Size = New System.Drawing.Size(1005, 454)
        Me.PanelDataMakanan.TabIndex = 21
        '
        'PanelDataAkun
        '
        Me.PanelDataAkun.BackColor = System.Drawing.Color.DarkMagenta
        Me.PanelDataAkun.Controls.Add(Me.PictureBox3)
        Me.PanelDataAkun.Controls.Add(Me.Label7)
        Me.PanelDataAkun.Controls.Add(Me.cariakun)
        Me.PanelDataAkun.Controls.Add(Me.dgvAkun)
        Me.PanelDataAkun.Controls.Add(Me.PictureBox4)
        Me.PanelDataAkun.Location = New System.Drawing.Point(0, 29)
        Me.PanelDataAkun.Name = "PanelDataAkun"
        Me.PanelDataAkun.Size = New System.Drawing.Size(1005, 465)
        Me.PanelDataAkun.TabIndex = 22
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.PictureBox3.Image = Global.posttest4posttest4.My.Resources.Resources.search_interface_symbol
        Me.PictureBox3.Location = New System.Drawing.Point(485, 392)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(91, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Manajemen Data Akun"
        '
        'cariakun
        '
        Me.cariakun.Location = New System.Drawing.Point(95, 395)
        Me.cariakun.Name = "cariakun"
        Me.cariakun.Size = New System.Drawing.Size(367, 20)
        Me.cariakun.TabIndex = 19
        '
        'dgvAkun
        '
        Me.dgvAkun.AllowUserToAddRows = False
        Me.dgvAkun.AllowUserToDeleteRows = False
        Me.dgvAkun.AllowUserToResizeColumns = False
        Me.dgvAkun.AllowUserToResizeRows = False
        Me.dgvAkun.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAkun.Location = New System.Drawing.Point(95, 58)
        Me.dgvAkun.Name = "dgvAkun"
        Me.dgvAkun.ReadOnly = True
        Me.dgvAkun.RowHeadersVisible = False
        Me.dgvAkun.Size = New System.Drawing.Size(801, 328)
        Me.dgvAkun.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.posttest4posttest4.My.Resources.Resources.Vector
        Me.PictureBox4.Location = New System.Drawing.Point(28, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1005, 473)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelDataAkun)
        Me.Controls.Add(Me.PanelDataMakanan)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelDataMakanan.ResumeLayout(False)
        Me.PanelDataMakanan.PerformLayout()
        Me.PanelDataAkun.ResumeLayout(False)
        Me.PanelDataAkun.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMakanan As System.Windows.Forms.DataGridView
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtberat As System.Windows.Forms.TextBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkalori As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents msDataMakanan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msDataUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelDataMakanan As System.Windows.Forms.Panel
    Friend WithEvents PanelDataAkun As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cariakun As System.Windows.Forms.TextBox
    Friend WithEvents dgvAkun As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
End Class
