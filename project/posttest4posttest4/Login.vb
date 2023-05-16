Imports MySql.Data.MySqlClient

Public Class Login
    Public idLogin As String
    Public umur As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
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
                    AdminForm.Show()
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

                UserForm.username = username
                UserForm.tgl = tgllahir
                UserForm.kelamin = kelamin
                UserForm.K = kal
                idLogin = RD(0).ToString()
                Diet.idakun = RD(0).ToString()
                Cek.idakun = RD(0).ToString()

                Dim tgl As Date
                Dim hariini As Date = Format(Date.Now(), "dd-MM-yyyy")
                tgl = RD(3)

                umur = Val(hariini.Year) - Val(tgl.Year)
                If Val(hariini.Month) < Val(tgl.Month) And Val(hariini.Day) < Val(tgl.Day) Then
                    umur = umur - 1
                End If

                RD.Close()
                UserForm.Show()

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

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtpassword.Location.X > 44 Then
            txtpassword.Left = txtpassword.Left - 10
        Else
            Timer1.Enabled = False
        End If

    End Sub


End Class