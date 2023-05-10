Imports MySql.Data.MySqlClient

Public Class Profil

    Public id As String

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Beranda.Show()
        Me.Hide()
    End Sub

    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnama.Text = Beranda.Label2.Text
        txtemail.Text = Beranda.email
        txttgllahir.Value = Beranda.tgl
        kelamin.Text = Beranda.kelamin
        txtpassword.Text = Beranda.pass
    End Sub

    Private Sub btnregis_Click(sender As Object, e As EventArgs) Handles btnregis.Click
        Dim ubah As String = "update akun set nama = '" & txtnama.Text & "', email = '" & txtemail.Text & "', tanggal = '" & txttgllahir.Value.Year.ToString() & "-" & txttgllahir.Value.Month.ToString() & "-" & txttgllahir.Value.Day.ToString() & "', password = '" & txtpassword.Text & "', kelamin = '" & kelamin.Text & "' where id = '" & id.ToString & "'"
        CMD = New MySqlCommand(ubah, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data Sudah diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtnama.Focus()
        Beranda.Label2.Text = txtnama.Text
    End Sub
End Class