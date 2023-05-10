Imports MySql.Data.MySqlClient

Public Class Form1

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
        txtunit.Clear()
        txtnama.Focus()
        jenis.SelectedIndex = 0
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
        ElseIf txtunit.Text = "" Then
            MessageBox.Show("Unit Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtunit.Focus()
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
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jenis.SelectedIndex = 0
        Call koneksi()
        Call Tampil()
        Call Kosong()
        Call Buat()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cekKosong() = 1 Then
            CMD = New MySqlCommand("select * from makanan where nama = '" & txtnama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into makanan(nama, berat, kalori, unit, jenis) values('" & txtnama.Text & "', '" & txtberat.Text & "', '" & txtkalori.Text & "', '" & txtunit.Text & "', '" & jenis.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses!", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Terdapat data duplikat!", MsgBoxStyle.Information, "Perhatian")
            End If

            RD.Close()
            Call Tampil()
            Call Kosong()
            txtnama.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Kosong()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Login.Show()
        Call Login.Kosong()

        Me.Hide()
    End Sub

    Dim selected As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakanan.CellClick
        Dim i As Integer
        i = e.RowIndex
        ''With DataGridView1.Rows.Item(i)
        txtnama.Text = dgvMakanan.Rows(i).Cells(1).Value.ToString
        txtberat.Text = dgvMakanan.Rows(i).Cells(2).Value.ToString
        txtkalori.Text = dgvMakanan.Rows(i).Cells(3).Value.ToString
        txtunit.Text = dgvMakanan.Rows(i).Cells(4).Value.ToString
        jenis.Text = dgvMakanan.Rows(i).Cells(5).Value.ToString
        selected = dgvMakanan.Rows(i).Cells(0).Value.ToString
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If txtnama.Text = "" Then
            MsgBox("kode jenis belum diisi")
            txtnama.Focus()
        Else
            If MessageBox.Show("yakin akan menghapus data " & txtnama.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("delete from makanan where id = '" & selected.ToString & "'", CONN)

                CMD.ExecuteNonQuery()
                Call Kosong()
                Call Tampil()
            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtnama.Text = "" Then
            MsgBox("kode jenis belum diisi")
            txtnama.Focus()
        Else
            CMD = New MySqlCommand("select * from makanan where nama = '" & txtnama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim ubah As String = "update makanan set nama = '" & txtnama.Text & "', berat = '" & txtberat.Text & "', kalori = '" & txtkalori.Text & "', unit = '" & txtunit.Text & "', jenis = '" & jenis.Text & "' where id = '" & selected.ToString & "'"
                CMD = New MySqlCommand(ubah, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Sudah diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Tampil()
                Call Kosong()
                txtnama.Focus()
            Else
                MsgBox("Terdapat data duplikat!", MsgBoxStyle.Information, "Perhatian")
                RD.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DA = New MySqlDataAdapter("select * from makanan where nama like '%" & TextBox1.Text & "%' or jenis like '%" & TextBox1.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "makanan")
        dgvMakanan.DataSource = DS.Tables("makanan")
        dgvMakanan.ReadOnly = True

        If dgvMakanan.RowCount < 1 Then
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DA = New MySqlDataAdapter("select * from makanan where nama like '%" & TextBox1.Text & "%' or jenis like '%" & TextBox1.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "makanan")
        dgvMakanan.DataSource = DS.Tables("makanan")
        dgvMakanan.ReadOnly = True
    End Sub

    Private Sub DataMakananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msDataMakanan.Click
        PanelDataAkun.Hide()
        PanelDataMakanan.Show()

    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msDataUser.Click
        PanelDataMakanan.Hide()
        PanelDataAkun.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DA = New MySqlDataAdapter("select * from akun where nama like '%" & cariakun.Text & "%' or email like '%" & cariakun.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "akun")
        dgvAkun.DataSource = DS.Tables("akun")
        dgvAkun.ReadOnly = True

        If dgvAkun.RowCount < 1 Then
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub cariakun_TextChanged(sender As Object, e As EventArgs) Handles cariakun.TextChanged
        DA = New MySqlDataAdapter("select * from akun where nama like '%" & TextBox1.Text & "%' or email like '%" & TextBox1.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "akun")
        dgvAkun.DataSource = DS.Tables("akun")
        dgvAkun.ReadOnly = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Login.Show()
        Call Login.Kosong()
        Me.Hide()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
    End Sub
End Class
