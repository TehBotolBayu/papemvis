Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Public Class Registrasi


    Function cekKosong() As Integer
        If txtnama.Text = "" Then
            MessageBox.Show("Username belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnama.Focus()
            Return 0
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Email belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtemail.Focus()
            Return 0
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Password Makanan belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Return 0
        ElseIf txtkonpassword.Text = "" Then
            MessageBox.Show("Konfirmasi Password belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkonpassword.Focus()
            Return 0
        ElseIf txttgllahir.Text = "" Then
            MessageBox.Show("Tanggal Lahir belum terisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txttgllahir.Focus()
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub Registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kelamin.SelectedIndex = 0
        Call koneksi()
    End Sub

    Private Sub btnregis_Click(sender As Object, e As EventArgs) Handles btnregis.Click
        If cekKosong() = 1 Then



            Dim emailPattern As String = "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
            Dim email As String = txtemail.Text

            Try
                If Regex.IsMatch(email, emailPattern) Then
                    ' Email format is valid
                    ' Lakukan tindakan yang diinginkan di sini
                Else
                    ' Email format is invalid
                    MessageBox.Show("Format email tidak valid.")
                    Return
                End If
            Catch ex As Exception
                ' Exception handling
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Return
            End Try






            If Not txtkonpassword.Text = txtpassword.Text Then
                MsgBox("Konfirmasi Password tidak sama!", MsgBoxStyle.Information, "Perhatian")
                txtkonpassword.Focus()
                Exit Sub
            End If
            CMD = New MySqlCommand("select * from akun where email = '" & txtemail.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                MsgBox("Email telah dipakai!", MsgBoxStyle.Information, "Perhatian")
                txtemail.Focus()
                Exit Sub
            End If
            RD.Close()

            Dim Simpan As String = "insert into akun(nama, email, tanggal, password, kelamin, status, tinggi, berat) values('" & txtnama.Text & "', '" & txtemail.Text & "', '" & txttgllahir.Value.Year.ToString() & "-" & txttgllahir.Value.Month.ToString() & "-" & txttgllahir.Value.Day.ToString() & "', '" & txtpassword.Text & "', '" & kelamin.Text & "', 'user', '" & txttinggi.Text & "', '" & txtberat.Text & "')"
            CMD = New MySqlCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Registrasi sukses!", MsgBoxStyle.Information, "Perhatian")

            CMD = New MySqlCommand("select * from akun where email = '" & txtemail.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            Login.idLogin = RD(0).ToString
            RD.Close()

            UserForm.Show()
            Me.Hide()
            If Not Application.OpenForms.OfType(Of Beranda).Any Then
                Close()

            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class