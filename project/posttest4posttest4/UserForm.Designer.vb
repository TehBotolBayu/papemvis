<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.sidenav = New System.Windows.Forms.Panel()
        Me.bAsupanku = New System.Windows.Forms.Panel()
        Me.LabelAsupan = New System.Windows.Forms.Label()
        Me.bDashboard = New System.Windows.Forms.Panel()
        Me.LabelHome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.tgltgl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PanelAsupan = New System.Windows.Forms.Panel()
        Me.dgvAsupan = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lkarbo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.llemak = New System.Windows.Forms.Label()
        Me.lprotein = New System.Windows.Forms.Label()
        Me.lkalori = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tPorsi = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelProfil = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tAktif = New System.Windows.Forms.Label()
        Me.tDate = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tBerat = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tTinggi = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tJenis = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tPw = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lahir = New System.Windows.Forms.Label()
        Me.labelemail = New System.Windows.Forms.Label()
        Me.namauser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.barkarbo = New System.Windows.Forms.Panel()
        Me.LabelKarbo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.barlemak = New System.Windows.Forms.Panel()
        Me.LabelLemak = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.barprotein = New System.Windows.Forms.Panel()
        Me.LabelProtein = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.barkalori = New System.Windows.Forms.Panel()
        Me.LabelKalori = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sidenav.SuspendLayout()
        Me.bAsupanku.SuspendLayout()
        Me.bDashboard.SuspendLayout()
        Me.header.SuspendLayout()
        Me.PanelDashboard.SuspendLayout()
        Me.PanelAsupan.SuspendLayout()
        CType(Me.dgvAsupan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.PanelProfil.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidenav
        '
        Me.sidenav.BackColor = System.Drawing.Color.White
        Me.sidenav.Controls.Add(Me.bAsupanku)
        Me.sidenav.Controls.Add(Me.bDashboard)
        Me.sidenav.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidenav.ForeColor = System.Drawing.Color.Gray
        Me.sidenav.Location = New System.Drawing.Point(0, 0)
        Me.sidenav.Name = "sidenav"
        Me.sidenav.Size = New System.Drawing.Size(171, 525)
        Me.sidenav.TabIndex = 0
        '
        'bAsupanku
        '
        Me.bAsupanku.Controls.Add(Me.LabelAsupan)
        Me.bAsupanku.Location = New System.Drawing.Point(3, 148)
        Me.bAsupanku.Name = "bAsupanku"
        Me.bAsupanku.Size = New System.Drawing.Size(166, 41)
        Me.bAsupanku.TabIndex = 6
        '
        'LabelAsupan
        '
        Me.LabelAsupan.AutoSize = True
        Me.LabelAsupan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAsupan.ForeColor = System.Drawing.Color.DimGray
        Me.LabelAsupan.Location = New System.Drawing.Point(99, 9)
        Me.LabelAsupan.Name = "LabelAsupan"
        Me.LabelAsupan.Size = New System.Drawing.Size(64, 20)
        Me.LabelAsupan.TabIndex = 4
        Me.LabelAsupan.Text = "Asupan"
        '
        'bDashboard
        '
        Me.bDashboard.Controls.Add(Me.LabelHome)
        Me.bDashboard.Location = New System.Drawing.Point(3, 93)
        Me.bDashboard.Name = "bDashboard"
        Me.bDashboard.Size = New System.Drawing.Size(166, 41)
        Me.bDashboard.TabIndex = 5
        '
        'LabelHome
        '
        Me.LabelHome.AutoSize = True
        Me.LabelHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHome.ForeColor = System.Drawing.Color.DimGray
        Me.LabelHome.Location = New System.Drawing.Point(99, 9)
        Me.LabelHome.Name = "LabelHome"
        Me.LabelHome.Size = New System.Drawing.Size(52, 20)
        Me.LabelHome.TabIndex = 4
        Me.LabelHome.Text = "Home"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(628, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.White
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Controls.Add(Me.Label1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.ForeColor = System.Drawing.Color.Gray
        Me.header.Location = New System.Drawing.Point(171, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(778, 66)
        Me.header.TabIndex = 1
        '
        'dt1
        '
        Me.dt1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dt1.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.dt1.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dt1.Location = New System.Drawing.Point(159, 41)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(172, 20)
        Me.dt1.TabIndex = 1
        Me.dt1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'PanelDashboard
        '
        Me.PanelDashboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelDashboard.Controls.Add(Me.tgltgl)
        Me.PanelDashboard.Controls.Add(Me.PictureBox3)
        Me.PanelDashboard.Controls.Add(Me.Label2)
        Me.PanelDashboard.Controls.Add(Me.dt1)
        Me.PanelDashboard.Controls.Add(Me.Panel2)
        Me.PanelDashboard.Controls.Add(Me.Label12)
        Me.PanelDashboard.Controls.Add(Me.Panel7)
        Me.PanelDashboard.Controls.Add(Me.Panel6)
        Me.PanelDashboard.Controls.Add(Me.Panel5)
        Me.PanelDashboard.ForeColor = System.Drawing.Color.Black
        Me.PanelDashboard.Location = New System.Drawing.Point(171, 61)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(778, 464)
        Me.PanelDashboard.TabIndex = 2
        '
        'tgltgl
        '
        Me.tgltgl.AutoSize = True
        Me.tgltgl.BackColor = System.Drawing.Color.Transparent
        Me.tgltgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgltgl.ForeColor = System.Drawing.Color.DimGray
        Me.tgltgl.Location = New System.Drawing.Point(109, 28)
        Me.tgltgl.Name = "tgltgl"
        Me.tgltgl.Size = New System.Drawing.Size(44, 16)
        Me.tgltgl.TabIndex = 5
        Me.tgltgl.Text = "Home"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(21, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 21)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Asupan Hari Ini"
        '
        'PanelAsupan
        '
        Me.PanelAsupan.Controls.Add(Me.dgvAsupan)
        Me.PanelAsupan.Controls.Add(Me.Label4)
        Me.PanelAsupan.Controls.Add(Me.TextBox1)
        Me.PanelAsupan.Controls.Add(Me.Panel9)
        Me.PanelAsupan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAsupan.ForeColor = System.Drawing.Color.Black
        Me.PanelAsupan.Location = New System.Drawing.Point(0, 0)
        Me.PanelAsupan.Name = "PanelAsupan"
        Me.PanelAsupan.Size = New System.Drawing.Size(949, 525)
        Me.PanelAsupan.TabIndex = 16
        '
        'dgvAsupan
        '
        Me.dgvAsupan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAsupan.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgvAsupan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsupan.Location = New System.Drawing.Point(171, 114)
        Me.dgvAsupan.Name = "dgvAsupan"
        Me.dgvAsupan.RowHeadersVisible = False
        Me.dgvAsupan.Size = New System.Drawing.Size(576, 411)
        Me.dgvAsupan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(184, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cari"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel9.Controls.Add(Me.lkarbo)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.llemak)
        Me.Panel9.Controls.Add(Me.lprotein)
        Me.Panel9.Controls.Add(Me.lkalori)
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.Label16)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.tPorsi)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.TextBox2)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(743, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(206, 525)
        Me.Panel9.TabIndex = 1
        '
        'lkarbo
        '
        Me.lkarbo.AutoSize = True
        Me.lkarbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkarbo.ForeColor = System.Drawing.Color.White
        Me.lkarbo.Location = New System.Drawing.Point(101, 208)
        Me.lkarbo.Name = "lkarbo"
        Me.lkarbo.Size = New System.Drawing.Size(63, 20)
        Me.lkarbo.TabIndex = 23
        Me.lkarbo.Text = "Label5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Karbohidrat"
        '
        'llemak
        '
        Me.llemak.AutoSize = True
        Me.llemak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llemak.ForeColor = System.Drawing.Color.White
        Me.llemak.Location = New System.Drawing.Point(101, 177)
        Me.llemak.Name = "llemak"
        Me.llemak.Size = New System.Drawing.Size(63, 20)
        Me.llemak.TabIndex = 21
        Me.llemak.Text = "Label5"
        '
        'lprotein
        '
        Me.lprotein.AutoSize = True
        Me.lprotein.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lprotein.ForeColor = System.Drawing.Color.White
        Me.lprotein.Location = New System.Drawing.Point(99, 144)
        Me.lprotein.Name = "lprotein"
        Me.lprotein.Size = New System.Drawing.Size(63, 20)
        Me.lprotein.TabIndex = 20
        Me.lprotein.Text = "Label5"
        '
        'lkalori
        '
        Me.lkalori.AutoSize = True
        Me.lkalori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkalori.ForeColor = System.Drawing.Color.White
        Me.lkalori.Location = New System.Drawing.Point(99, 113)
        Me.lkalori.Name = "lkalori"
        Me.lkalori.Size = New System.Drawing.Size(63, 20)
        Me.lkalori.TabIndex = 19
        Me.lkalori.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Violet
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 296)
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
        Me.Label17.Location = New System.Drawing.Point(16, 180)
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
        Me.Label18.Location = New System.Drawing.Point(16, 147)
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
        Me.Label16.Location = New System.Drawing.Point(16, 114)
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
        Me.Label15.Location = New System.Drawing.Point(15, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 19)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Nama Makanan"
        '
        'tPorsi
        '
        Me.tPorsi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tPorsi.Location = New System.Drawing.Point(73, 253)
        Me.tPorsi.Name = "tPorsi"
        Me.tPorsi.Size = New System.Drawing.Size(124, 20)
        Me.tPorsi.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 19)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Porsi"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(60, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 19)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Cari"
        '
        'PanelProfil
        '
        Me.PanelProfil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelProfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelProfil.Controls.Add(Me.Panel3)
        Me.PanelProfil.Controls.Add(Me.ComboBox1)
        Me.PanelProfil.Controls.Add(Me.tAktif)
        Me.PanelProfil.Controls.Add(Me.tDate)
        Me.PanelProfil.Controls.Add(Me.Button3)
        Me.PanelProfil.Controls.Add(Me.Label24)
        Me.PanelProfil.Controls.Add(Me.tBerat)
        Me.PanelProfil.Controls.Add(Me.Label23)
        Me.PanelProfil.Controls.Add(Me.tTinggi)
        Me.PanelProfil.Controls.Add(Me.Label22)
        Me.PanelProfil.Controls.Add(Me.Label21)
        Me.PanelProfil.Controls.Add(Me.tJenis)
        Me.PanelProfil.Controls.Add(Me.Label20)
        Me.PanelProfil.Controls.Add(Me.tPw)
        Me.PanelProfil.Controls.Add(Me.Label19)
        Me.PanelProfil.Controls.Add(Me.tEmail)
        Me.PanelProfil.Controls.Add(Me.Label11)
        Me.PanelProfil.Controls.Add(Me.tNama)
        Me.PanelProfil.Location = New System.Drawing.Point(171, 61)
        Me.PanelProfil.Name = "PanelProfil"
        Me.PanelProfil.Size = New System.Drawing.Size(778, 464)
        Me.PanelProfil.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(98, 395)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'tAktif
        '
        Me.tAktif.AutoSize = True
        Me.tAktif.ForeColor = System.Drawing.Color.Black
        Me.tAktif.Location = New System.Drawing.Point(44, 395)
        Me.tAktif.Name = "tAktif"
        Me.tAktif.Size = New System.Drawing.Size(47, 13)
        Me.tAktif.TabIndex = 26
        Me.tAktif.Text = "Aktivitas"
        '
        'tDate
        '
        Me.tDate.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.tDate.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.tDate.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.tDate.Location = New System.Drawing.Point(306, 269)
        Me.tDate.Name = "tDate"
        Me.tDate.Size = New System.Drawing.Size(139, 20)
        Me.tDate.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(234, 353)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Berat Badan"
        '
        'tBerat
        '
        Me.tBerat.Location = New System.Drawing.Point(306, 349)
        Me.tBerat.Name = "tBerat"
        Me.tBerat.Size = New System.Drawing.Size(139, 20)
        Me.tBerat.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(234, 313)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Tinggi Badan"
        '
        'tTinggi
        '
        Me.tTinggi.Location = New System.Drawing.Point(306, 309)
        Me.tTinggi.Name = "tTinggi"
        Me.tTinggi.Size = New System.Drawing.Size(139, 20)
        Me.tTinggi.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(234, 273)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Tanggal Lahir"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(234, 398)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Jenis Kelamin"
        '
        'tJenis
        '
        Me.tJenis.Location = New System.Drawing.Point(306, 395)
        Me.tJenis.Name = "tJenis"
        Me.tJenis.Size = New System.Drawing.Size(139, 20)
        Me.tJenis.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(44, 353)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Password"
        '
        'tPw
        '
        Me.tPw.Location = New System.Drawing.Point(98, 349)
        Me.tPw.Name = "tPw"
        Me.tPw.Size = New System.Drawing.Size(122, 20)
        Me.tPw.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(44, 313)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Email"
        '
        'tEmail
        '
        Me.tEmail.Location = New System.Drawing.Point(98, 309)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(122, 20)
        Me.tEmail.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(44, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Nama"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(98, 269)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(122, 20)
        Me.tNama.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.lahir)
        Me.Panel3.Controls.Add(Me.labelemail)
        Me.Panel3.Controls.Add(Me.namauser)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(25, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 197)
        Me.Panel3.TabIndex = 28
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.posttest4posttest4.My.Resources.Resources.edit
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.posttest4posttest4.My.Resources.Resources.edit1
        Me.PictureBox4.Location = New System.Drawing.Point(638, 39)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'lahir
        '
        Me.lahir.AutoSize = True
        Me.lahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lahir.ForeColor = System.Drawing.Color.Black
        Me.lahir.Location = New System.Drawing.Point(162, 103)
        Me.lahir.Name = "lahir"
        Me.lahir.Size = New System.Drawing.Size(122, 16)
        Me.lahir.TabIndex = 22
        Me.lahir.Text = "12, November 2003"
        '
        'labelemail
        '
        Me.labelemail.AutoSize = True
        Me.labelemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelemail.ForeColor = System.Drawing.Color.Black
        Me.labelemail.Location = New System.Drawing.Point(162, 73)
        Me.labelemail.Name = "labelemail"
        Me.labelemail.Size = New System.Drawing.Size(108, 16)
        Me.labelemail.TabIndex = 21
        Me.labelemail.Text = "udin@gmail.com"
        '
        'namauser
        '
        Me.namauser.AutoSize = True
        Me.namauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namauser.ForeColor = System.Drawing.Color.Black
        Me.namauser.Location = New System.Drawing.Point(161, 39)
        Me.namauser.Name = "namauser"
        Me.namauser.Size = New System.Drawing.Size(94, 20)
        Me.namauser.TabIndex = 5
        Me.namauser.Text = "Udin Petot"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.posttest4posttest4.My.Resources.Resources.login
        Me.PictureBox2.Location = New System.Drawing.Point(51, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(582, 134)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 32)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "LogOut"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.posttest4posttest4.My.Resources.Resources.button
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(50, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 29)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Ubah Foto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(600, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 32)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.posttest4posttest4.My.Resources.Resources.Rectangle_5
        Me.PictureBox3.Location = New System.Drawing.Point(98, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(237, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.barkarbo)
        Me.Panel2.Controls.Add(Me.LabelKarbo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(209, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 115)
        Me.Panel2.TabIndex = 15
        '
        'barkarbo
        '
        Me.barkarbo.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barkarbo.Location = New System.Drawing.Point(15, 76)
        Me.barkarbo.Name = "barkarbo"
        Me.barkarbo.Size = New System.Drawing.Size(0, 20)
        Me.barkarbo.TabIndex = 15
        '
        'LabelKarbo
        '
        Me.LabelKarbo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelKarbo.AutoSize = True
        Me.LabelKarbo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelKarbo.ForeColor = System.Drawing.Color.Black
        Me.LabelKarbo.Location = New System.Drawing.Point(11, 36)
        Me.LabelKarbo.Name = "LabelKarbo"
        Me.LabelKarbo.Size = New System.Drawing.Size(80, 21)
        Me.LabelKarbo.TabIndex = 13
        Me.LabelKarbo.Text = "123/2300"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Karbohidrat"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.barlemak)
        Me.Panel7.Controls.Add(Me.LabelLemak)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Location = New System.Drawing.Point(393, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(171, 115)
        Me.Panel7.TabIndex = 14
        '
        'barlemak
        '
        Me.barlemak.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barlemak.Location = New System.Drawing.Point(15, 76)
        Me.barlemak.Name = "barlemak"
        Me.barlemak.Size = New System.Drawing.Size(0, 20)
        Me.barlemak.TabIndex = 16
        '
        'LabelLemak
        '
        Me.LabelLemak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelLemak.AutoSize = True
        Me.LabelLemak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelLemak.ForeColor = System.Drawing.Color.Black
        Me.LabelLemak.Location = New System.Drawing.Point(11, 36)
        Me.LabelLemak.Name = "LabelLemak"
        Me.LabelLemak.Size = New System.Drawing.Size(80, 21)
        Me.LabelLemak.TabIndex = 13
        Me.LabelLemak.Text = "123/2300"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Lemak"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.barprotein)
        Me.Panel6.Controls.Add(Me.LabelProtein)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(577, 86)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(171, 115)
        Me.Panel6.TabIndex = 14
        '
        'barprotein
        '
        Me.barprotein.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barprotein.Location = New System.Drawing.Point(10, 76)
        Me.barprotein.Name = "barprotein"
        Me.barprotein.Size = New System.Drawing.Size(0, 20)
        Me.barprotein.TabIndex = 17
        '
        'LabelProtein
        '
        Me.LabelProtein.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelProtein.AutoSize = True
        Me.LabelProtein.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelProtein.ForeColor = System.Drawing.Color.Black
        Me.LabelProtein.Location = New System.Drawing.Point(11, 36)
        Me.LabelProtein.Name = "LabelProtein"
        Me.LabelProtein.Size = New System.Drawing.Size(80, 21)
        Me.LabelProtein.TabIndex = 13
        Me.LabelProtein.Text = "123/2300"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Protein"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.posttest4posttest4.My.Resources.Resources.Rectangle1
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.barkalori)
        Me.Panel5.Controls.Add(Me.LabelKalori)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(25, 86)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(171, 115)
        Me.Panel5.TabIndex = 0
        '
        'barkalori
        '
        Me.barkalori.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barkalori.Location = New System.Drawing.Point(15, 76)
        Me.barkalori.Name = "barkalori"
        Me.barkalori.Size = New System.Drawing.Size(0, 20)
        Me.barkalori.TabIndex = 14
        '
        'LabelKalori
        '
        Me.LabelKalori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelKalori.AutoSize = True
        Me.LabelKalori.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelKalori.ForeColor = System.Drawing.Color.Black
        Me.LabelKalori.Location = New System.Drawing.Point(11, 36)
        Me.LabelKalori.Name = "LabelKalori"
        Me.LabelKalori.Size = New System.Drawing.Size(80, 21)
        Me.LabelKalori.TabIndex = 13
        Me.LabelKalori.Text = "123/2300"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kalori"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.posttest4posttest4.My.Resources.Resources.akun
        Me.PictureBox1.Location = New System.Drawing.Point(732, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(949, 525)
        Me.Controls.Add(Me.PanelProfil)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidenav)
        Me.Controls.Add(Me.PanelAsupan)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UserForm"
        Me.Text = "User"
        Me.sidenav.ResumeLayout(False)
        Me.bAsupanku.ResumeLayout(False)
        Me.bAsupanku.PerformLayout()
        Me.bDashboard.ResumeLayout(False)
        Me.bDashboard.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.PanelDashboard.ResumeLayout(False)
        Me.PanelDashboard.PerformLayout()
        Me.PanelAsupan.ResumeLayout(False)
        Me.PanelAsupan.PerformLayout()
        CType(Me.dgvAsupan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.PanelProfil.ResumeLayout(False)
        Me.PanelProfil.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidenav As Panel
    Friend WithEvents header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LabelLemak As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LabelProtein As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelKalori As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelAsupan As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tPorsi As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PanelProfil As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents tBerat As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tTinggi As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tJenis As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tPw As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tNama As TextBox
    Friend WithEvents tDate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelKarbo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tAktif As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvAsupan As DataGridView
    Friend WithEvents llemak As Label
    Friend WithEvents lprotein As Label
    Friend WithEvents lkalori As Label
    Friend WithEvents lkarbo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bAsupanku As Panel
    Friend WithEvents LabelAsupan As Label
    Friend WithEvents bDashboard As Panel
    Friend WithEvents LabelHome As Label
    Friend WithEvents barkarbo As Panel
    Friend WithEvents barlemak As Panel
    Friend WithEvents barprotein As Panel
    Friend WithEvents barkalori As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tgltgl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lahir As Label
    Friend WithEvents labelemail As Label
    Friend WithEvents namauser As Label
End Class
