﻿Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports MySql.Data.MySqlClient
Imports System.Web.Services.Description
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class UserForm
    Public username As String
    Public email As String
    Public kelamin As String
    Public pass As String

    Public tgl As Date
    Dim hariini As Date = Format(Date.Now(), "dd-MM-yyyy")
    Public umur As Integer
    Public status As String

    Dim kalori As Double
    Dim selected As Integer = -1

    Friend WithEvents Labelx As Label
    Friend WithEvents k As Label
    Friend WithEvents kl As Label
    Friend WithEvents pr As Label
    Friend WithEvents lm As Label
    Friend WithEvents lkal As Label
    Friend WithEvents llem As Label
    Friend WithEvents lkarb As Label
    Friend WithEvents id As Label
    Friend WithEvents lpro As Label
    Friend WithEvents nama As Label
    Friend WithEvents pfood As PictureBox
    Friend WithEvents porsi As Label

    Dim Panel1(150) As Panel

    Dim lemakmax, proteinmax, karbomax As Double

    Dim progresskal As Double
    Dim progresspro As Double
    Dim progresskar As Double
    Dim progresslem As Double

    Dim panelnow As String
    Private Sub ambilAkun()
        CMD = New MySqlCommand("select * from akun where id = '" & Login.idLogin & "'", CONN)
        Module1.RD = CMD.ExecuteReader
        Module1.RD.Read()
        tNama.Text = Module1.RD(1).ToString()
        tEmail.Text = Module1.RD(2).ToString()
        tPw.Text = Module1.RD(4).ToString()
        If Module1.RD(5).ToString() = "Laki-Laki" Then
            tJenis.SelectedIndex = 0
        Else
            tJenis.SelectedIndex = 1
        End If

        tDate.Text = Module1.RD(3).ToString()
        tTinggi.Text = Module1.RD(8).ToString()
        tBerat.Text = Module1.RD(9).ToString()
        kalori = Module1.RD(7)
        Module1.RD.Close()
    End Sub

    Private Sub ambilAsupan()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ambilAkun()
        infoasupan.Hide()
        PanelProfil.Show()
        PanelAsupan.Hide()
        PanelDashboard.Hide()
        PanelStat.Hide()
    End Sub

    Private Sub ceknutrisi()
        If Login.umur < 3 Then
            lemakmax = (kalori * 35 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 15 / 100)
        ElseIf Login.umur < 18 And Login.umur >= 3 Then
            lemakmax = (kalori * 30 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 20 / 100)
        ElseIf Login.umur >= 18 Then
            lemakmax = (kalori * 25 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 25 / 100)
        End If
    End Sub

    Private Sub aturDashboard()
        barkalori.Width = 0
        barkarbo.Width = 0
        barlemak.Width = 0
        barprotein.Width = 0

        Dim tglasupan As String = dt1.Value.Year.ToString & "-" & dt1.Value.Month.ToString & "-" & dt1.Value.Day.ToString
        Dim kaltotal, prototal, lemtotal, karbototal As Double
        kaltotal = 0
        prototal = 0
        lemtotal = 0
        karbototal = 0

        CMD = New MySqlCommand("select * from nutrisi where tanggal = '" & tglasupan & "'", CONN)
        Module1.RD = CMD.ExecuteReader
        If Module1.RD.HasRows Then
            While Module1.RD.Read
                kalori = Module1.RD(7)
                lemakmax = Module1.RD(8)
                proteinmax = Module1.RD(9)
                karbomax = Module1.RD(10)
                kaltotal = kaltotal + Module1.RD(1)
                prototal = prototal + Module1.RD(2)
                lemtotal = lemtotal + Module1.RD(3)
                karbototal = karbototal + Module1.RD(4)
            End While
        Else
        End If
        Module1.RD.Close()
        progresskal = kaltotal / kalori
        progresskar = karbototal / karbomax
        progresslem = lemtotal / lemakmax
        progresspro = prototal / proteinmax

        LabelKalori.Text = kaltotal.ToString & "/" & kalori.ToString
        LabelProtein.Text = prototal.ToString & "/" & proteinmax.ToString
        LabelLemak.Text = lemtotal.ToString & "/" & lemakmax.ToString
        LabelKarbo.Text = karbototal.ToString & "/" & karbomax.ToString

        CMD = New MySqlCommand("SELECT nutrisi.id, makanan.nama, makanan.kalori, makanan.lemak, makanan.protein, makanan.karbohidrat, nutrisi.porsi FROM nutrisi JOIN makanan WHERE nutrisi.idmakanan = makanan.id AND nutrisi.tanggal = '" & tglasupan & "' AND nutrisi.idakun = '" & Login.idLogin & "'", CONN)
        Module1.RD = CMD.ExecuteReader
        Dim ii As Integer = 0

        If Module1.RD.HasRows Then
            While Module1.RD.Read
                Panel1(ii) = New Panel()
                id = New Label()
                porsi = New Label()
                lkarb = New Label()
                lpro = New Label()
                llem = New Label()
                lkal = New Label()
                k = New Label()
                pr = New Label()
                lm = New Label()
                kl = New Label()
                nama = New Label()
                pfood = New PictureBox()
                ' 
                ' id
                ' 
                id.ForeColor = Color.FromArgb(CByte(249), CByte(244), CByte(255))
                id.Location = New Point(622, 28)
                id.Name = "id"
                id.Size = New Size(41, 15)
                id.TabIndex = 10
                id.Text = Module1.RD(0).ToString
                ' 
                ' porsi
                ' 
                porsi.ForeColor = Color.FromArgb(CByte(249), CByte(244), CByte(255))
                porsi.Location = New Point(622, 28)
                porsi.Name = "porsi"
                porsi.Size = New Size(41, 15)
                porsi.TabIndex = 10
                porsi.Text = Module1.RD(6).ToString
                ' 
                ' lkarb
                ' 
                lkarb.AutoSize = True
                lkarb.Location = New Point(499, 82)
                lkarb.Name = "lkarb"
                lkarb.Size = New Size(41, 15)
                lkarb.TabIndex = 9
                lkarb.Text = (Module1.RD(5) * Module1.RD(6)).ToString
                ' 
                ' lpro
                ' 
                lpro.AutoSize = True
                lpro.Location = New Point(412, 82)
                lpro.Name = "lpro"
                lpro.Size = New Size(41, 15)
                lpro.TabIndex = 8
                lpro.Text = (Module1.RD(4) * Module1.RD(6)).ToString
                ' 
                ' llem
                ' 
                llem.AutoSize = True
                llem.Location = New Point(316, 82)
                llem.Name = "llem"
                llem.Size = New Size(41, 15)
                llem.TabIndex = 7
                llem.Text = (Module1.RD(3) * Module1.RD(6)).ToString
                ' 
                ' lkal
                ' 
                lkal.AutoSize = True
                lkal.Location = New Point(228, 81)
                lkal.Name = "lkal"
                lkal.Size = New Size(41, 15)
                lkal.TabIndex = 6
                lkal.Text = (Module1.RD(3) * Module1.RD(6)).ToString
                ' 
                ' k
                ' 
                k.AutoSize = True
                k.Location = New Point(499, 49)
                k.Name = "k"
                k.Size = New Size(69, 15)
                k.TabIndex = 5
                k.Text = "Karbohidrat"
                ' 
                ' pr
                ' 
                pr.AutoSize = True
                pr.Location = New Point(412, 49)
                pr.Name = "pr"
                pr.Size = New Size(45, 15)
                pr.TabIndex = 4
                pr.Text = "Protein"
                ' 
                ' lm
                ' 
                lm.AutoSize = True
                lm.Location = New Point(316, 49)
                lm.Name = "lm"
                lm.Size = New Size(42, 15)
                lm.TabIndex = 3
                lm.Text = "Lemak"
                ' 
                ' kl
                ' 
                kl.AutoSize = True
                kl.Location = New Point(228, 49)
                kl.Name = "kl"
                kl.Size = New Size(37, 15)
                kl.TabIndex = 2
                kl.Text = "Kalori"
                ' 
                ' pfood
                ' 
                pfood.Image = My.Resources.Resources.food
                pfood.Location = New Point(22, 23)
                pfood.Name = "pfood"
                pfood.Size = New Size(101, 93)
                pfood.TabIndex = 1
                pfood.TabStop = False
                ' 
                ' nama
                ' 
                nama.AutoSize = True
                nama.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
                nama.Location = New Point(141, 23)
                nama.Name = "nama"
                nama.Size = New Size(60, 21)
                nama.TabIndex = 0
                nama.Text = Module1.RD(1).ToString & " x " & Module1.RD(6).ToString & " porsi"

                Panel1(ii).Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
                Panel1(ii).BackColor = Color.Transparent
                Panel1(ii).BackgroundImage = My.Resources.Resources.Rectangle_12
                Panel1(ii).BackgroundImageLayout = ImageLayout.Stretch

                ''Panel1(ii).Controls.Add(Labelx)
                Panel1(ii).Controls.Add(id)
                Panel1(ii).Controls.Add(lkarb)
                Panel1(ii).Controls.Add(lpro)
                Panel1(ii).Controls.Add(llem)
                Panel1(ii).Controls.Add(lkal)
                Panel1(ii).Controls.Add(k)
                Panel1(ii).Controls.Add(pr)
                Panel1(ii).Controls.Add(lm)
                Panel1(ii).Controls.Add(kl)
                Panel1(ii).Controls.Add(pfood)
                Panel1(ii).Controls.Add(nama)
                Panel1(ii).Controls.Add(porsi)

                Panel1(ii).Location = New Point(25, 30 + (120 * ii))
                Panel1(ii).Name = "Panel" & ii
                Panel1(ii).Size = New Size(730, 120)
                Panel1(ii).TabIndex = 1

                AddHandler Panel1(ii).MouseClick, AddressOf tes
                PanelDashboard.Controls.Add(Panel1(ii))

                ii = ii + 1
            End While
        Else
        End If
        Module1.RD.Close()

        Timer1.Enabled = True
    End Sub


    Private Sub aturdaftar(ByVal cari As String)
        If cari = Nothing Then
            cari = ""
        End If
        CMD = New MySqlCommand("SELECT * FROM makanan WHERE nama LIKE '%" & cari & "%'", CONN)
        RD = CMD.ExecuteReader
        Dim ii As Integer = 0

        If RD.HasRows Then
            While RD.Read
                Panel1(ii) = New Panel()
                id = New Label()
                lkarb = New Label()
                lpro = New Label()
                llem = New Label()
                lkal = New Label()
                k = New Label()
                pr = New Label()
                lm = New Label()
                kl = New Label()
                nama = New Label()
                pfood = New PictureBox()
                ' 
                ' id
                ' 
                id.ForeColor = Color.FromArgb(CByte(249), CByte(244), CByte(255))
                id.Location = New Point(622, 28)
                id.Name = "id"
                id.Size = New Size(41, 15)
                id.TabIndex = 10
                id.Text = Module1.RD(0).ToString
                ' 
                ' lkarb
                ' 
                lkarb.AutoSize = True
                lkarb.Location = New Point(499, 82)
                lkarb.Name = "lkarb"
                lkarb.Size = New Size(41, 15)
                lkarb.TabIndex = 9
                lkarb.Text = Module1.RD(5).ToString
                ' 
                ' lpro
                ' 
                lpro.AutoSize = True
                lpro.Location = New Point(412, 82)
                lpro.Name = "lpro"
                lpro.Size = New Size(41, 15)
                lpro.TabIndex = 8
                lpro.Text = Module1.RD(4).ToString
                ' 
                ' llem
                ' 
                llem.AutoSize = True
                llem.Location = New Point(316, 82)
                llem.Name = "llem"
                llem.Size = New Size(41, 15)
                llem.TabIndex = 7
                llem.Text = Module1.RD(3).ToString
                ' 
                ' lkal
                ' 
                lkal.AutoSize = True
                lkal.Location = New Point(228, 81)
                lkal.Name = "lkal"
                lkal.Size = New Size(41, 15)
                lkal.TabIndex = 6
                lkal.Text = Module1.RD(2).ToString
                ' 
                ' k
                ' 
                k.AutoSize = True
                k.Location = New Point(499, 49)
                k.Name = "k"
                k.Size = New Size(69, 15)
                k.TabIndex = 5
                k.Text = "Karbohidrat"
                ' 
                ' pr
                ' 
                pr.AutoSize = True
                pr.Location = New Point(412, 49)
                pr.Name = "pr"
                pr.Size = New Size(45, 15)
                pr.TabIndex = 4
                pr.Text = "Protein"
                ' 
                ' lm
                ' 
                lm.AutoSize = True
                lm.Location = New Point(316, 49)
                lm.Name = "lm"
                lm.Size = New Size(42, 15)
                lm.TabIndex = 3
                lm.Text = "Lemak"
                ' 
                ' kl
                ' 
                kl.AutoSize = True
                kl.Location = New Point(228, 49)
                kl.Name = "kl"
                kl.Size = New Size(37, 15)
                kl.TabIndex = 2
                kl.Text = "Kalori"
                ' 
                ' pfood
                ' 
                pfood.Image = My.Resources.Resources.food
                pfood.Location = New Point(22, 23)
                pfood.Name = "pfood"
                pfood.Size = New Size(101, 93)
                pfood.TabIndex = 1
                pfood.TabStop = False
                ' 
                ' nama
                ' 
                nama.AutoSize = True
                nama.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
                nama.Location = New Point(141, 23)
                nama.Name = "nama"
                nama.Size = New Size(60, 21)
                nama.TabIndex = 0
                nama.Text = Module1.RD(1).ToString & " / " & Module1.RD(6).ToString & " gram"


                Panel1(ii).Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
                Panel1(ii).BackColor = Color.Transparent
                Panel1(ii).BackgroundImage = My.Resources.Resources.Rectangle_12
                Panel1(ii).BackgroundImageLayout = ImageLayout.Stretch

                ''Panel1(ii).Controls.Add(Labelx)
                Panel1(ii).Controls.Add(id)
                Panel1(ii).Controls.Add(lkarb)
                Panel1(ii).Controls.Add(lpro)
                Panel1(ii).Controls.Add(llem)
                Panel1(ii).Controls.Add(lkal)
                Panel1(ii).Controls.Add(k)
                Panel1(ii).Controls.Add(pr)
                Panel1(ii).Controls.Add(lm)
                Panel1(ii).Controls.Add(kl)
                Panel1(ii).Controls.Add(pfood)
                Panel1(ii).Controls.Add(nama)
                Panel1(ii).Controls.Add(porsi)

                Panel1(ii).Location = New Point(25, 30 + (120 * ii))
                Panel1(ii).Name = "Panel" & ii
                Panel1(ii).Size = New Size(750, 120)
                Panel1(ii).TabIndex = 1

                AddHandler Panel1(ii).MouseClick, AddressOf addasupanku
                daftarmakanan.Controls.Add(Panel1(ii))

                ii = ii + 1
            End While
        Else
        End If
        RD.Close()

    End Sub
    Dim muncul As Boolean = False
    Private Sub addasupanku(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)
        '' MsgBox("tes" & clickedPanel.Controls(0).Text)
        selected = clickedPanel.Controls(0).Text
        Label15.Text = clickedPanel.Controls(10).Text
        lkalori.Text = clickedPanel.Controls(4).Text
        llemak.Text = clickedPanel.Controls(3).Text
        lkarbo.Text = clickedPanel.Controls(1).Text
        lprotein.Text = clickedPanel.Controls(2).Text
        tPorsi.Text = 1
        If muncul = False Then
            Timer4.Enabled = True
        End If

    End Sub

    Private Sub hitungbmi()
        ''rumus bmi disini
        nilaibmi.Text = "123"
        statusbmi.Text = "bagus"
    End Sub

    Private Sub makananfavorit()
        CMD = New MySqlCommand("SELECT makanan.nama, COUNT(*) AS count FROM nutrisi INNER JOIN makanan ON nutrisi.idmakanan = makanan.id WHERE nutrisi.idakun = '" & Login.idLogin & "' GROUP BY idmakanan ORDER BY count DESC;", CONN)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            fav1.Text = "#1 " & RD(0).ToString
            RD.Read()
            fav2.Text = "#2 " & RD(0).ToString
            RD.Read()
            fav3.Text = "#3 " & RD(0).ToString
        End If
        RD.Close()

    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoasupan.Hide()
        tgltgl.Text = hariini.Day & " " & MonthName(hariini.Month) & " " & hariini.Year
        ambilAkun()
        ambilAsupan()
        ceknutrisi()
        aturDashboard()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        LabelHome.ForeColor = Color.White
        panelnow = "db"
        aturdaftar("")
        hitungbmi()
        makananfavorit()
    End Sub

    Sub tes(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)
        '' MsgBox("tes" & clickedPanel.Controls(0).Text)
        namanutrisi.Text = clickedPanel.Controls(10).Text
        kalorinutrisi.Text = clickedPanel.Controls(4).Text
        lemaknutrisi.Text = clickedPanel.Controls(3).Text
        karbonutrisi.Text = clickedPanel.Controls(1).Text
        pronutrisi.Text = clickedPanel.Controls(2).Text
        nutrisiporsi.Text = clickedPanel.Controls(11).Text
        infoasupan.Show()
    End Sub

    Private Sub UserForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Login.Close()
        Registrasi.Close()
    End Sub

    Private Sub tPorsi_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub tPorsi_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub LabelKalori_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        aturDashboard()
        tgltgl.Text = dt1.Text
        PanelDashboard.Controls.Clear()
        ceknutrisi()
        aturDashboard()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Berhasil Ditambahkan!")
        If selected = -1 Then
            MsgBox("Pilih makanan terlebih dahulu")
            Return
        End If
        If tPorsi.Text = "" Then
            MsgBox("Masukkan porsi terlebih dahulu")
        End If

        Dim kal, pro, lem, kar As Double
        Dim idakun As String = Login.idLogin
        Dim idmakanan As String = selected
        kal = Val(lkalori.Text)
        pro = Val(lprotein.Text)
        lem = Val(llemak.Text)
        kar = Val(lkarbo.Text)
        Dim tglhari As String
        tglhari = rdate.Value.Year.ToString & "-" & rdate.Value.Month.ToString & "-" & rdate.Value.Day.ToString
        Dim Simpan As String = "insert into nutrisi(kalori, protein, lemak, karbohidrat, tanggal, idakun, kalorimax, lemakmax, proteinmax, karbomax, idmakanan, porsi) values('" & kal & "', '" & pro & "', '" & lem & "', '" & kar & "', '" & tglhari & "', '" & Login.idLogin & "', '" & kalori & "', '" & lemakmax & "', '" & proteinmax & "', '" & karbomax & "', '" & idmakanan & "', '" & tPorsi.Text & "')"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()

        aturDashboard()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If barkalori.Width < (135 * progresskal) Then
            barkalori.Width = barkalori.Width + 5
        ElseIf barkarbo.Width < (135 * progresskar) Then
            barkarbo.Width = barkarbo.Width + 5
        ElseIf barprotein.Width < (135 * progresspro) Then
            barprotein.Width = barprotein.Width + 5
        ElseIf barlemak.Width < (135 * progresslem) Then
            barlemak.Width = barlemak.Width + 5
        Else
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.MouseClick
        tgltgl.Text = dt1.Text
        dt1.Show()
        dt1.Select()
        SendKeys.Send("%{DOWN}")
        tgltgl.Text = dt1.Text

    End Sub

    Private Sub tgltgl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bAsupanku_MouseClick(sender As Object, e As MouseEventArgs) Handles bAsupanku.MouseClick
        PanelAsupan.Show()
        PanelDashboard.Hide()
        PanelStat.Hide()
        PanelProfil.Hide()
        infoasupan.Hide()
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
        bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        LabelAsupan.ForeColor = Color.White
        LabelHome.ForeColor = Color.DimGray
        panelnow = "as"
    End Sub

    Private Sub bDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles bDashboard.MouseClick
        PanelAsupan.Hide()
        PanelDashboard.Show()
        PanelProfil.Hide()
        PanelStat.Show()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        panelnow = "db"
    End Sub

    Private Sub dt1_LostFocus(sender As Object, e As EventArgs) Handles dt1.LostFocus
        tgltgl.Text = dt1.Text
    End Sub

    Private Sub bDashboard_MouseEnter(sender As Object, e As EventArgs) Handles bDashboard.MouseEnter
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub bAsupanku_MouseEnter(sender As Object, e As EventArgs) Handles bAsupanku.MouseEnter
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles paneledit.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If paneledit.Location.X > Me.Width - 530 Then
            paneledit.Left = paneledit.Left - 30
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub bAsupanku_MouseLeave(sender As Object, e As EventArgs) Handles bAsupanku.MouseLeave
        If Not panelnow = "as" Then
            bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If paneledit.Location.X < PanelProfil.Width Then
            paneledit.Left = paneledit.Left + 30
        Else
            Timer3.Enabled = False
        End If
    End Sub


    Private Sub bDashboard_MouseLeave(sender As Object, e As EventArgs) Handles bDashboard.MouseLeave
        If Not panelnow = "db" Then
            bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        End If

    End Sub


    Private Sub nutrisiporsi_TextChanged(sender As Object, e As EventArgs) Handles nutrisiporsi.TextChanged
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If paneltambah.Location.X > PanelAsupan.Width - 237 Then
            paneltambah.Left = paneltambah.Left - 30
        Else
            Timer4.Enabled = False
            muncul = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If paneltambah.Location.X <= PanelAsupan.Width Then
            paneltambah.Left = paneltambah.Left + 30
        Else
            Timer5.Enabled = False
            muncul = False
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Timer5.Enabled = True
        selected = -1
    End Sub

    Private Sub tPorsi_TextChanged_1(sender As Object, e As EventArgs) Handles tPorsi.TextChanged
        If tPorsi.Text = "" Then
            tPorsi.Text = "1"
        End If
        If Not selected = -1 Then
            CMD = New MySqlCommand("select * from makanan where id = '" & selected & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            lkalori.Text = (Val(tPorsi.Text) * RD(2)).ToString
            llemak.Text = (Val(tPorsi.Text) * RD(3)).ToString
            lprotein.Text = (Val(tPorsi.Text) * RD(4)).ToString
            lkarbo.Text = (Val(tPorsi.Text) * RD(5)).ToString
            RD.Close()
        End If
    End Sub

    Private Sub PanelAsupan_Paint(sender As Object, e As PaintEventArgs) Handles PanelAsupan.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick

    End Sub

    Private Sub RadiusBox7_TextChanged(sender As Object, e As EventArgs) Handles rcari.TextChanged

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        daftarmakanan.Controls.Clear()
        aturdaftar(rcari.Text)
    End Sub

    Private Sub PictureBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick
        Timer3.Enabled = True
    End Sub

    Private Sub bAsupanku_Click(sender As Object, e As EventArgs) Handles bAsupanku.Click
        PanelStat.Hide()
        infoasupan.Hide()
    End Sub

End Class