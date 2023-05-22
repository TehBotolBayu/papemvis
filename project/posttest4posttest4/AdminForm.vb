Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Web.Services.Description
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
        '' MsgBox("tes" & clickedPanel.Controls(0).Text)
        selectid = clickedPanel.Controls(0).Text
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

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampil()
        Call Kosong()
        Call Buat()
        aturdaftar("")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub bDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles bDashboard.MouseClick
        PanelMakanan.Hide()
        PanelUser.Show()
        Paneldata.Hide()
    End Sub

    Private Sub bAsupanku_Paint(sender As Object, e As MouseEventArgs) Handles bAsupanku.MouseClick
        PanelMakanan.Show()
        PanelUser.Hide()
        Paneldata.Show()

    End Sub

    Private Sub LabelHome_Click(sender As Object, e As EventArgs) Handles LabelHome.Click
        PanelMakanan.Hide()
        PanelUser.Show()
        Paneldata.Hide()

    End Sub

    Private Sub LabelAsupan_Click(sender As Object, e As EventArgs) Handles LabelAsupan.Click
        PanelMakanan.Show()
        PanelUser.Hide()
        Paneldata.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PanelMakanan.Controls.Clear()

        aturdaftar(rcari.Text)
    End Sub

    Private Sub bDashboard_Paint(sender As Object, e As PaintEventArgs) Handles bDashboard.Paint

    End Sub

    Private Sub bAsupanku_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub bAsupanku_Paint_1(sender As Object, e As PaintEventArgs) Handles bAsupanku.Paint

    End Sub
End Class