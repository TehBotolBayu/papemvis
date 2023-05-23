﻿Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports MySql.Data.MySqlClient
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Web.Services.Description
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class AdminForm

    Dim Panel1(150) As Panel
    Dim id As Label
    Dim lkarb As Label
    Dim lpro As Label
    Dim llem As Label
    Dim lkal As Label
    Dim k As Label
    Dim pr As Label
    Dim lm As Label
    Dim kl As Label
    Dim nama As Label
    Dim pfood As PictureBox

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
                id.Location = New Point(622 - 100, 28)
                id.Name = "id"
                id.Size = New Size(41, 15)
                id.TabIndex = 10
                id.Text = Module1.RD(0).ToString
                ' 
                ' lkarb
                ' 
                lkarb.AutoSize = True
                lkarb.Location = New Point(499 - 100, 82)
                lkarb.Name = "lkarb"
                lkarb.Size = New Size(41, 15)
                lkarb.TabIndex = 9
                lkarb.Text = Module1.RD(5).ToString
                ' 
                ' lpro
                ' 
                lpro.AutoSize = True
                lpro.Location = New Point(412 - 100, 82)
                lpro.Name = "lpro"
                lpro.Size = New Size(41, 15)
                lpro.TabIndex = 8
                lpro.Text = Module1.RD(4).ToString
                ' 
                ' llem
                ' 
                llem.AutoSize = True
                llem.Location = New Point(316 - 100, 82)
                llem.Name = "llem"
                llem.Size = New Size(41, 15)
                llem.TabIndex = 7
                llem.Text = Module1.RD(3).ToString
                ' 
                ' lkal
                ' 
                lkal.AutoSize = True
                lkal.Location = New Point(228 - 100, 81)
                lkal.Name = "lkal"
                lkal.Size = New Size(41, 15)
                lkal.TabIndex = 6
                lkal.Text = Module1.RD(2).ToString
                ' 
                ' k
                ' 
                k.AutoSize = True
                k.Location = New Point(499 - 100, 49)
                k.Name = "k"
                k.Size = New Size(69, 15)
                k.TabIndex = 5
                k.Text = "Karbohidrat"
                ' 
                ' pr
                ' 
                pr.AutoSize = True
                pr.Location = New Point(412 - 100, 49)
                pr.Name = "pr"
                pr.Size = New Size(45, 15)
                pr.TabIndex = 4
                pr.Text = "Protein"
                ' 
                ' lm
                ' 
                lm.AutoSize = True
                lm.Location = New Point(316 - 100, 49)
                lm.Name = "lm"
                lm.Size = New Size(42, 15)
                lm.TabIndex = 3
                lm.Text = "Lemak"
                ' 
                ' kl
                ' 
                kl.AutoSize = True
                kl.Location = New Point(228 - 100, 49)
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
                Panel1(ii).Controls.Add(id) ''1
                Panel1(ii).Controls.Add(lkarb) ''2
                Panel1(ii).Controls.Add(lpro) ''3
                Panel1(ii).Controls.Add(llem) ''4
                Panel1(ii).Controls.Add(lkal) ''5
                Panel1(ii).Controls.Add(k) ''6
                Panel1(ii).Controls.Add(pr) ''7
                Panel1(ii).Controls.Add(lm) ''8
                Panel1(ii).Controls.Add(kl) ''9
                Panel1(ii).Controls.Add(pfood) ''10
                Panel1(ii).Controls.Add(nama) ''11

                Panel1(ii).Location = New Point(25, 30 + (120 * ii))
                Panel1(ii).Name = "Panel" & ii
                Panel1(ii).Size = New Size(PanelMakanan.Width - 210, 120)
                Panel1(ii).TabIndex = 1

                AddHandler Panel1(ii).MouseClick, AddressOf editmakanan
                PanelMakanan.Controls.Add(Panel1(ii))

                ii = ii + 1
            End While
        Else
        End If
        RD.Close()

    End Sub
    Dim selectid
    Private Sub editmakanan(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)
        Dim inputString As String = clickedPanel.Controls(10).Text
        Dim parts() As String = inputString.Split("/"c)
        selectid = clickedPanel.Controls(0).Text
        txtnama.Text = parts(0)
        txtkalori.Text = clickedPanel.Controls(4).Text
        txtlemak.Text = clickedPanel.Controls(3).Text
        txtprotein.Text = clickedPanel.Controls(2).Text
        txtkarbo.Text = clickedPanel.Controls(1).Text
        Dim brt() As String = parts(1).Split("g"c)
        txtberat.Text = brt(0)
    End Sub


    Private Sub FormmClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Login.Close()
        Registrasi.Close()
        Cek.Close()
        Beranda.Close()
    End Sub

    Sub Kosong()
        txtnama.Clear()
        txtkalori.Clear()
        txtberat.Clear()
        txtlemak.Clear()
        txtprotein.Clear()
        txtnama.Focus()
    End Sub

    Sub Isi()
        txtnama.Clear()
        txtnama.Focus()
    End Sub

    Sub Tampil()

    End Sub

    Function cekKosong() As Integer
        If txtnama.Text = "" Then
            MessageBox.Show("Nama Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnama.Focus()
            Return 0
        ElseIf txtberat.Text = "" Then
            MessageBox.Show("Berat Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtberat.Focus()
            Return 0
        ElseIf txtkalori.Text = "" Then
            MessageBox.Show("Kalori Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkalori.Focus()
            Return 0
        ElseIf txtlemak.Text = "" Then
            MessageBox.Show("Unit Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlemak.Focus()
            Return 0
        ElseIf txtprotein.Text = "" Then
            MessageBox.Show("Unit Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtprotein.Focus()
            Return 0
        Else
            Return 1
        End If
    End Function

    Sub Buat()
    End Sub

    Private Sub bDashboard_Click(sender As Object, e As EventArgs)
        PanelMakanan.Show()
        PanelUser.Hide()
        Paneldata.Show()
    End Sub

    Private Sub bAsupanku_Click(sender As Object, e As EventArgs)
        PanelUser.Show()
        PanelMakanan.Hide()
        Paneldata.Hide()

    End Sub

    Dim user1, user2, user3 As Panel
    Dim id1, id2, id3, nama1, nama2, nama3 As Label
    Dim pp1, pp2, pp3 As PictureBox

    Sub aturuser(ByVal s As String)
        Dim index = 0
        If s = Nothing Then
            s = ""
        End If
        CMD = New MySqlCommand("SELECT * FROM akun WHERE nama LIKE '%" & s & "%'", CONN)
        RD = CMD.ExecuteReader
        Dim ii As Integer = 0

        If RD.HasRows Then
            While RD.Read
                user1 = New Panel()
                id1 = New Label()
                nama1 = New Label()
                pp1 = New PictureBox()
                user2 = New Panel()
                id2 = New Label()
                nama2 = New Label()
                pp2 = New PictureBox()
                user3 = New Panel()
                id3 = New Label()
                nama3 = New Label()
                pp3 = New PictureBox()

                ' 
                ' user1
                ' 
                user1.BackgroundImage = My.Resources.Resources.cardprofile
                user1.BackgroundImageLayout = ImageLayout.Stretch
                user1.Controls.Add(id1)
                user1.Controls.Add(nama1)
                user1.Controls.Add(pp1)
                user1.Location = New Point(75, 10 + (133 * index))
                user1.Name = "user1"
                user1.Size = New Size(136, 123)
                user1.TabIndex = 0
                AddHandler user1.MouseClick, AddressOf edituser
                ' 
                ' id1
                ' 
                id1.AutoSize = True
                id1.BackColor = Color.White
                id1.ForeColor = Color.White
                id1.Location = New Point(3, 9)
                id1.Name = "id1"
                id1.Size = New Size(17, 15)
                id1.TabIndex = 2
                id1.Text = RD(0).ToString
                ' 
                ' nama1
                ' 
                nama1.AutoSize = True
                nama1.Location = New Point(45, 88)
                nama1.Name = "nama1"
                nama1.Size = New Size(41, 15)
                nama1.TabIndex = 1
                nama1.Text = RD(1).ToString
                ' 
                ' PictureBox1
                ' 
                pp1.Image = My.Resources.Resources.login
                pp1.Location = New Point(38, 22)
                pp1.Name = "pp1"
                pp1.Size = New Size(54, 55)
                pp1.SizeMode = PictureBoxSizeMode.StretchImage
                pp1.TabIndex = 0
                pp1.TabStop = False
                PanelUser.Controls.Add(user1)

                RD.Read()

                If RD(0).ToString = id1.Text Then
                    RD.Close()
                    Return
                End If
                ' 
                ' user2
                ' 
                user2.BackgroundImage = My.Resources.Resources.cardprofile
                user2.BackgroundImageLayout = ImageLayout.Stretch
                user2.Controls.Add(id2)
                user2.Controls.Add(nama2)
                user2.Controls.Add(pp2)
                user2.Location = New Point(257, 10 + (133 * index))
                user2.Name = "user2"
                user2.Size = New Size(136, 123)
                user2.TabIndex = 1
                AddHandler user2.MouseClick, AddressOf edituser
                ' 
                ' id2
                ' 
                id2.AutoSize = True
                id2.BackColor = Color.White
                id2.ForeColor = Color.White
                id2.Location = New Point(18, 9)
                id2.Name = "id2"
                id2.Size = New Size(17, 15)
                id2.TabIndex = 3
                id2.Text = RD(0).ToString
                ' 
                ' nama2
                ' 
                nama2.AutoSize = True
                nama2.Location = New Point(48, 88)
                nama2.Name = "nama2"
                nama2.Size = New Size(41, 15)
                nama2.TabIndex = 2
                nama2.Text = RD(1).ToString
                ' 
                ' pp2
                ' 
                pp2.Image = My.Resources.Resources.login
                pp2.Location = New Point(41, 22)
                pp2.Name = "pp2"
                pp2.Size = New Size(54, 55)
                pp2.SizeMode = PictureBoxSizeMode.StretchImage
                pp2.TabIndex = 1
                pp2.TabStop = False

                PanelUser.Controls.Add(user2)


                RD.Read()
                If RD(0).ToString = id2.Text Then
                    RD.Close()
                    Return
                End If

                ' 
                ' user3
                ' 
                user3.BackgroundImage = My.Resources.Resources.cardprofile
                user3.BackgroundImageLayout = ImageLayout.Stretch
                user3.Controls.Add(id3)
                user3.Controls.Add(nama3)
                user3.Controls.Add(pp3)
                user3.Location = New Point(436, 10 + (133 * index))
                user3.Name = "user3"
                user3.Size = New Size(136, 123)
                user3.TabIndex = 2
                AddHandler user3.MouseClick, AddressOf edituser
                ' 
                ' id3
                ' 
                id3.AutoSize = True
                id3.BackColor = Color.White
                id3.ForeColor = Color.White
                id3.Location = New Point(18, 9)
                id3.Name = "id3"
                id3.Size = New Size(17, 15)
                id3.TabIndex = 4
                id3.Text = RD(0).ToString
                ' 
                ' nama3
                ' 
                nama3.AutoSize = True
                nama3.Location = New Point(48, 88)
                nama3.Name = "nama3"
                nama3.Size = New Size(41, 15)
                nama3.TabIndex = 3
                nama3.Text = RD(1).ToString
                ' 
                ' pp3
                ' 
                pp3.Image = My.Resources.Resources.login
                pp3.Location = New Point(41, 22)
                pp3.Name = "pp3"
                pp3.Size = New Size(54, 55)
                pp3.SizeMode = PictureBoxSizeMode.StretchImage
                pp3.TabIndex = 1
                pp3.TabStop = False
                ' 
                ' Form1
                ' 
                PanelUser.Controls.Add(user3)



                index = index + 1
            End While
        Else
        End If
        RD.Close()

    End Sub
    Dim selectuser As String = ""
    Private Sub edituser(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)

        selectuser = clickedPanel.Controls(0).Text
        CMD = New MySqlCommand("SELECT * FROM akun WHERE id = '" & selectuser & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        namauser.Text = RD(1).ToString
        emailuser.Text = RD(2).ToString
        kelaminuser.Text = RD(5).ToString
        tinggiuser.Text = RD(8).ToString
        beratuser.Text = RD(9).ToString
        RD.Close()
        infouser.Show()

    End Sub

    Private Sub aturchart()
        Chart1.Series("AGE").Points.AddXY("John", 33)
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        aturdaftar("")
        aturuser("")
        infouser.Hide()
        aturchart()
    End Sub

    Private Sub bDashboard_Paint(sender As Object, e As PaintEventArgs) Handles bDashboard.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Simpan As String = "delete from makanan where id = '" & selectid & "'"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
        PanelMakanan.Controls.Clear()
        aturdaftar("")
    End Sub



    Private Sub LabelHome_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelHome.MouseClick
        PanelMakanan.Hide()
        PanelUser.Show()
        Paneldata.Hide()
        panelchart.Show()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        panelnow = "user"
    End Sub

    Private Sub bAsupanku_MouseClick(sender As Object, e As MouseEventArgs) Handles bAsupanku.MouseClick
        PanelMakanan.Show()
        PanelUser.Hide()
        Paneldata.Show()
        panelchart.Hide()
        bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
        LabelHome.ForeColor = Color.DimGray
        LabelAsupan.ForeColor = Color.White
        panelnow = "food"
    End Sub

    Private Sub bDashboard_MouseEnter(sender As Object, e As EventArgs) Handles bDashboard.MouseEnter
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub bAsupanku_Paint_1(sender As Object, e As PaintEventArgs) Handles bAsupanku.Paint

    End Sub


    Private Sub bAsupanku_MouseLeave(sender As Object, e As EventArgs) Handles bAsupanku.MouseLeave
        If Not panelnow = "food" Then
            bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub bDashboard_MouseLeave(sender As Object, e As EventArgs) Handles bDashboard.MouseLeave
        If Not panelnow = "user" Then
            bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub bAsupanku_MouseEnter(sender As Object, e As EventArgs) Handles bAsupanku.MouseEnter
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        infouser.Hide()

    End Sub



    Private Sub bAsupanku_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cekKosong() = 1 Then
            Dim ubah As String = "update makanan set nama = '" & txtnama.Text & "', berat = '" & txtberat.Text & "', kalori = '" & txtkalori.Text & "', protein = '" & txtprotein.Text & "', lemak = '" & txtlemak.Text & "' where id = '" & selectid & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PanelMakanan.Controls.Clear()
            aturdaftar("")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Simpan As String = "insert into makanan(nama, kalori, lemak, protein, karbohidrat, berat) values('" & txtnama.Text & "', '" & txtkalori.Text & "', '" & txtlemak.Text & "', '" & txtprotein.Text & "', '" & txtkarbo.Text & "', '" & txtberat.Text & "')"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
        PanelMakanan.Controls.Clear()
        aturdaftar("")
    End Sub
    Dim panelnow = "user"
    Private Sub bDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles bDashboard.MouseClick
        PanelMakanan.Hide()
        PanelUser.Show()
        Paneldata.Hide()
        panelchart.Show()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        panelnow = "user"
    End Sub


    Private Sub LabelHome_Click(sender As Object, e As EventArgs) Handles LabelHome.Click
        PanelMakanan.Hide()
        PanelUser.Show()
        Paneldata.Hide()
        panelchart.Show()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        panelnow = "user"
    End Sub

    Private Sub LabelAsupan_Click(sender As Object, e As EventArgs) Handles LabelAsupan.Click
        PanelMakanan.Show()
        PanelUser.Hide()
        Paneldata.Show()
        panelchart.Hide()
        bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
        LabelHome.ForeColor = Color.DimGray
        LabelAsupan.ForeColor = Color.White
        panelnow = "food"
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PanelMakanan.Controls.Clear()

        aturdaftar(rcari.Text)
        PanelUser.Controls.Clear()
        aturuser(rcari.Text)
    End Sub

End Class