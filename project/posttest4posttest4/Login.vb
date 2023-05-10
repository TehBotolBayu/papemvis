Imports MySql.Data.MySqlClient
Imports System.Net

Public Class Login
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckForInternetConnection() Then
            MsgBox("bgs")
        Else
            MsgBox("tidak")
        End If
        Call Kosong()
        Call koneksi()
    End Sub

    Sub Kosong()
        txtnama.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Registrasi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New MySqlCommand("select * from akun where email = '" & txtnama.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Dim pw As String = RD(4).ToString()
            If txtpassword.Text = pw Then
                Dim status = RD(6).ToString()
                If status = "admin" Then
                    RD.Close()
                    Form1.Show()
                    Me.Hide()
                    Exit Sub
                End If
                Dim username = RD(1).ToString()
                Dim tgllahir = RD(3).ToString()
                Dim kelamin = RD(5).ToString()
                Dim kal = RD(7).ToString()

                Profil.txtemail.Text = RD(2).ToString()
                Profil.txtnama.Text = username
                Profil.txtpassword.Text = RD(4).ToString()
                Profil.txttgllahir.Text = tgllahir
                If kelamin = "Perempuan" Then
                    Profil.kelamin.SelectedIndex = 1
                Else
                    Profil.kelamin.SelectedIndex = 0
                End If
                Profil.id = RD(0).ToString()

                Beranda.username = username
                Beranda.tgl = tgllahir
                Beranda.kelamin = kelamin
                Beranda.pass = txtpassword.Text
                Beranda.email = txtnama.Text

                Beranda.K = kal
                Diet.idakun = RD(0).ToString()
                Cek.idakun = RD(0).ToString()
                RD.Close()
                Beranda.Show()

                ''SetDiet.Show()



                Me.Hide()
                Exit Sub
            Else
                MsgBox("Password Salah!", MsgBoxStyle.Information, "Perhatian")

                txtpassword.Focus()
                RD.Close()
            End If
        Else
            MsgBox("Email belum terdaftar!", MsgBoxStyle.Information, "Perhatian")
        End If
        RD.Close()
    End Sub

End Class