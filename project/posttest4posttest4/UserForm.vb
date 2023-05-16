Imports MySql.Data.MySqlClient

Public Class UserForm
    Public username As String
    Public email As String
    Public kelamin As String
    Public pass As String

    Public tgl As Date
    Dim hariini As Date = Format(Date.Now(), "dd-MM-yyyy")
    Public umur As Integer
    Public status As String
    Public K As String

    Dim kalori As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        CMD = New MySqlCommand("select * from akun where id = '" & Login.idLogin & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        tNama.Text = RD(1).ToString()
        tEmail.Text = RD(2).ToString()
        tPw.Text = RD(4).ToString()
        tJenis.Text = RD(5).ToString()
        tDate.Text = RD(3).ToString()
        tTinggi.Text = RD(8).ToString()
        tBerat.Text = RD(9).ToString()
        RD.Close()
        PanelProfil.Show()
        PanelAsupan.Hide()
        PanelDashboard.Hide()
    End Sub

    Private Sub bAsupanku_Click(sender As Object, e As EventArgs) Handles bAsupanku.Click
        PanelAsupan.Show()
        PanelDashboard.Hide()
        PanelProfil.Hide()
    End Sub

    Private Sub bDashboard_Click(sender As Object, e As EventArgs) Handles bDashboard.Click
        PanelDashboard.Show()
        PanelAsupan.Hide()
        PanelProfil.Hide()
        Panel3.Show()
        Panel1.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Dim berat As Double = 10
    Dim tinggi As Double = 10


    Public Function bmr() As Double
        If Beranda.kelamin = "Laki-Laki" Then
            Return ((88.4 + (13.4 * berat)) + (4.8 * tinggi) - (5.68 * Beranda.umur))
        Else
            Return ((447.6 + (9.25 * berat)) + (3.1 * tinggi) - (4.33 * Beranda.umur))
        End If
    End Function

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        umur = Val(hariini.Year) - Val(tgl.Year)
        If Val(hariini.Month) < Val(tgl.Month) And Val(hariini.Day) < Val(tgl.Day) Then
            umur = umur - 1
        End If

        kalori = bmr()
    End Sub

    Private Sub UserForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
        Registrasi.Close()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles tAktif.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
