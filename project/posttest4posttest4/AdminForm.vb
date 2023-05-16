Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports MySql.Data.MySqlClient

Public Class AdminForm

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
        DA = New MySqlDataAdapter("select * from makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "makanan")
        dgvMakanan.DataSource = DS.Tables("makanan")
        dgvMakanan.Refresh()

        DA = New MySqlDataAdapter("select nama, email, tanggal, kelamin, kalori from akun", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "akun")
        dgvAkun.DataSource = DS.Tables("akun")
        dgvAkun.Refresh()
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
        dgvAkun.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAkun.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAkun.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAkun.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAkun.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        dgvMakanan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMakanan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMakanan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMakanan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMakanan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub bDashboard_Click(sender As Object, e As EventArgs) Handles bDashboard.Click
        PanelMakanan.Show()
        PanelUser.Hide()
        Panel3.Show()
        Panel4.Hide()
        Panel9.Show()

    End Sub

    Private Sub bAsupanku_Click(sender As Object, e As EventArgs) Handles bAsupanku.Click
        PanelUser.Show()
        PanelMakanan.Hide()
        Panel3.Hide()
        Panel4.Show()
        Panel9.Hide()

    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampil()
        Call Kosong()
        Call Buat()
        Panel4.Hide()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If PanelMakanan.Visible Then
            DA = New MySqlDataAdapter("select * from makanan where nama like '%" & TextBox2.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "makanan")
            dgvMakanan.DataSource = DS.Tables("makanan")
            dgvMakanan.ReadOnly = True
        Else
            DA = New MySqlDataAdapter("select nama, email, tanggal, kelamin, kalori from akun where nama like '%" & TextBox2.Text & "%' or email like '%" & TextBox2.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "akun")
            dgvAkun.DataSource = DS.Tables("akun")
            dgvAkun.ReadOnly = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class