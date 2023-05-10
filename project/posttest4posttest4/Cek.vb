Imports MySql.Data.MySqlClient

Public Class Cek
    Public idakun As String


    Private Sub FormmClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Login.Close()
        Registrasi.Close()
        Form1.Close()
        Beranda.Close()
    End Sub

    Public Function bmr() As Double
        If Beranda.kelamin = "Laki-Laki" Then
            Return ((88.4 + (13.4 * berat.Text)) + (4.8 * tinggi.Text) - (5.68 * Beranda.umur))
        Else
            Return ((447.6 + (9.25 * berat.Text)) + (3.1 * tinggi.Text) - (4.33 * Beranda.umur))
        End If
    End Function

    Function cekkosong() As Integer
        If tinggi.Text = "" Or berat.Text = "" Then
            MsgBox("Masukkan data dengan lengkap!")
            Return 1
        End If
        Return 0
    End Function

    Private Sub btncek_Click(sender As Object, e As EventArgs) Handles btncek.Click
        If cekkosong() = 0 Then
            Dim kkal As String = bmr().ToString
            Beranda.labelbmr.Text = "Kebutuhan Kalori: " & kkal & " kkal"
            Beranda.Show()
            Me.Hide()

            Dim ubah As String = "update akun set kalori = '" & kkal & "' where id = '" & idakun & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Cek_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Beranda.Show()
        Me.Hide()
    End Sub

    Private Sub tinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tinggi.KeyPress
        If Not IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            ErrorProvider1.SetError(tinggi, "Masukkan angka")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub berat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles berat.KeyPress
        If Not IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
            ErrorProvider1.SetError(berat, "Masukkan angka")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider1.Clear()

        End If
    End Sub

    Private Sub berat_TextChanged(sender As Object, e As EventArgs) Handles berat.TextChanged

    End Sub
End Class