<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.sidenav = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bAsupanku = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bDashboard = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelMakanan = New System.Windows.Forms.Panel()
        Me.dgvMakanan = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtberat = New System.Windows.Forms.TextBox()
        Me.txtlemak = New System.Windows.Forms.TextBox()
        Me.txtprotein = New System.Windows.Forms.TextBox()
        Me.txtkalori = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelUser = New System.Windows.Forms.Panel()
        Me.dgvAkun = New System.Windows.Forms.DataGridView()
        Me.sidenav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.PanelMakanan.SuspendLayout()
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.PanelUser.SuspendLayout()
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidenav
        '
        Me.sidenav.BackColor = System.Drawing.Color.DarkViolet
        Me.sidenav.Controls.Add(Me.Label1)
        Me.sidenav.Controls.Add(Me.PictureBox1)
        Me.sidenav.Controls.Add(Me.Panel4)
        Me.sidenav.Controls.Add(Me.bAsupanku)
        Me.sidenav.Controls.Add(Me.Panel3)
        Me.sidenav.Controls.Add(Me.bDashboard)
        Me.sidenav.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidenav.Location = New System.Drawing.Point(0, 0)
        Me.sidenav.Name = "sidenav"
        Me.sidenav.Size = New System.Drawing.Size(171, 500)
        Me.sidenav.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = " Administrator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.posttest4posttest4.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(14, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Turquoise
        Me.Panel4.Location = New System.Drawing.Point(0, 140)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(9, 36)
        Me.Panel4.TabIndex = 4
        '
        'bAsupanku
        '
        Me.bAsupanku.FlatAppearance.BorderSize = 0
        Me.bAsupanku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAsupanku.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bAsupanku.ForeColor = System.Drawing.Color.White
        Me.bAsupanku.Image = Global.posttest4posttest4.My.Resources.Resources.y1
        Me.bAsupanku.Location = New System.Drawing.Point(0, 140)
        Me.bAsupanku.Name = "bAsupanku"
        Me.bAsupanku.Size = New System.Drawing.Size(169, 36)
        Me.bAsupanku.TabIndex = 3
        Me.bAsupanku.Text = "   Data User"
        Me.bAsupanku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAsupanku.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Turquoise
        Me.Panel3.Location = New System.Drawing.Point(0, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(9, 36)
        Me.Panel3.TabIndex = 2
        '
        'bDashboard
        '
        Me.bDashboard.FlatAppearance.BorderSize = 0
        Me.bDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bDashboard.ForeColor = System.Drawing.Color.White
        Me.bDashboard.Image = Global.posttest4posttest4.My.Resources.Resources.y1
        Me.bDashboard.Location = New System.Drawing.Point(0, 88)
        Me.bDashboard.Name = "bDashboard"
        Me.bDashboard.Size = New System.Drawing.Size(169, 36)
        Me.bDashboard.TabIndex = 0
        Me.bDashboard.Text = "   Makanan"
        Me.bDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bDashboard.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.DarkViolet
        Me.header.Controls.Add(Me.TextBox2)
        Me.header.Controls.Add(Me.Label13)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(171, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(564, 66)
        Me.header.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(404, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(365, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 19)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cari"
        '
        'PanelMakanan
        '
        Me.PanelMakanan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMakanan.Controls.Add(Me.dgvMakanan)
        Me.PanelMakanan.Controls.Add(Me.Panel9)
        Me.PanelMakanan.Location = New System.Drawing.Point(171, 62)
        Me.PanelMakanan.Name = "PanelMakanan"
        Me.PanelMakanan.Size = New System.Drawing.Size(564, 438)
        Me.PanelMakanan.TabIndex = 17
        '
        'dgvMakanan
        '
        Me.dgvMakanan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMakanan.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvMakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakanan.Location = New System.Drawing.Point(0, 0)
        Me.dgvMakanan.Name = "dgvMakanan"
        Me.dgvMakanan.RowHeadersVisible = False
        Me.dgvMakanan.RowTemplate.Height = 25
        Me.dgvMakanan.Size = New System.Drawing.Size(353, 435)
        Me.dgvMakanan.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Controls.Add(Me.Button2)
        Me.Panel9.Controls.Add(Me.txtberat)
        Me.Panel9.Controls.Add(Me.txtlemak)
        Me.Panel9.Controls.Add(Me.txtprotein)
        Me.Panel9.Controls.Add(Me.txtkalori)
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.Label16)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.txtnama)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(358, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(206, 438)
        Me.Panel9.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(15, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 36)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Ubah"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(15, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 36)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Hapus"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtberat
        '
        Me.txtberat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtberat.Location = New System.Drawing.Point(14, 263)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(180, 20)
        Me.txtberat.TabIndex = 22
        '
        'txtlemak
        '
        Me.txtlemak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlemak.Location = New System.Drawing.Point(14, 206)
        Me.txtlemak.Name = "txtlemak"
        Me.txtlemak.Size = New System.Drawing.Size(180, 20)
        Me.txtlemak.TabIndex = 21
        '
        'txtprotein
        '
        Me.txtprotein.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprotein.Location = New System.Drawing.Point(14, 150)
        Me.txtprotein.Name = "txtprotein"
        Me.txtprotein.Size = New System.Drawing.Size(180, 20)
        Me.txtprotein.TabIndex = 20
        '
        'txtkalori
        '
        Me.txtkalori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkalori.Location = New System.Drawing.Point(14, 94)
        Me.txtkalori.Name = "txtkalori"
        Me.txtkalori.Size = New System.Drawing.Size(180, 20)
        Me.txtkalori.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Fuchsia
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Tambah"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(15, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 19)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Lemak"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(15, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 19)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Protein"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(14, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 19)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Kalori"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(14, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 19)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Nama Makanan"
        '
        'txtnama
        '
        Me.txtnama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnama.Location = New System.Drawing.Point(15, 37)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(180, 20)
        Me.txtnama.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(18, 241)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 19)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Berat"
        '
        'PanelUser
        '
        Me.PanelUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUser.BackColor = System.Drawing.Color.LavenderBlush
        Me.PanelUser.Controls.Add(Me.dgvAkun)
        Me.PanelUser.Location = New System.Drawing.Point(171, 65)
        Me.PanelUser.Name = "PanelUser"
        Me.PanelUser.Size = New System.Drawing.Size(564, 435)
        Me.PanelUser.TabIndex = 18
        '
        'dgvAkun
        '
        Me.dgvAkun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAkun.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAkun.Location = New System.Drawing.Point(5, 6)
        Me.dgvAkun.Name = "dgvAkun"
        Me.dgvAkun.RowHeadersVisible = False
        Me.dgvAkun.RowTemplate.Height = 25
        Me.dgvAkun.Size = New System.Drawing.Size(549, 419)
        Me.dgvAkun.TabIndex = 0
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 500)
        Me.Controls.Add(Me.PanelUser)
        Me.Controls.Add(Me.PanelMakanan)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidenav)
        Me.Name = "AdminForm"
        Me.Text = "Admin"
        Me.sidenav.ResumeLayout(False)
        Me.sidenav.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.PanelMakanan.ResumeLayout(False)
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.PanelUser.ResumeLayout(False)
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidenav As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bAsupanku As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bDashboard As Button
    Friend WithEvents header As Panel
    Friend WithEvents PanelMakanan As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvMakanan As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtberat As TextBox
    Friend WithEvents txtlemak As TextBox
    Friend WithEvents txtprotein As TextBox
    Friend WithEvents txtkalori As TextBox
    Friend WithEvents PanelUser As Panel
    Friend WithEvents dgvAkun As DataGridView
End Class
