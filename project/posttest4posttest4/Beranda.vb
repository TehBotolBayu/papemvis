Imports MySql.Data.MySqlClient

Public Class Beranda
    Public username As String
    Public email As String
    Public kelamin As String
    Public pass As String

    Public tgl As Date
    Dim hariini As Date = Format(Date.Now(), "dd-MM-yyyy")
    Public umur As Integer
    Public status As String
    Public K As String

    Private Sub FormmClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Login.Close()
        Registrasi.Close()
    End Sub

    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If status = "admin" Then
            Form1.Show()
            Close()
        End If
        If K = "NA" Then
            labelbmr.Text = ""
        Else
            labelbmr.Text = "Kebutuhan Kalori: " & K & " kkal"

        End If

        umur = Val(hariini.Year) - Val(tgl.Year)
        If Val(hariini.Month) < Val(tgl.Month) And Val(hariini.Day) < Val(tgl.Day) Then
            umur = umur - 1
        End If
        Label2.Text = username

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cek.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Call Login.Kosong()

        Me.Hide()

    End Sub



    Private Sub labelbmr_Click(sender As Object, e As EventArgs) Handles labelbmr.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Profil.Show()
    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        SetDiet.Show()

    End Sub
End Class