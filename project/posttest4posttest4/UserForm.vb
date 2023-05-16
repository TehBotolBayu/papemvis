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

    Private Sub ambilAkun()
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
        kalori = RD(7)
        RD.Close()
    End Sub

    Private Sub ambilAsupan()

        DA = New MySqlDataAdapter("select * from makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "makanan")
        dgvAsupan.DataSource = DS.Tables("makanan")
        dgvAsupan.Refresh()

        dgvAsupan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvAsupan.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ambilAkun()
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

    Private Sub ceknutrisi()
        MsgBox(Login.umur)
        LabelKalori.Text = kalori
        If Login.umur < 3 Then
            LabelLemak.Text = (kalori * 35 / 100).ToString()
            LabelKarbo.Text = (kalori * 50 / 100).ToString()
            LabelProtein.Text = (kalori * 15 / 100).ToString()
        ElseIf Login.umur < 18 Then
            LabelLemak.Text = (kalori * 30 / 100).ToString()
            LabelKarbo.Text = (kalori * 50 / 100).ToString()
            LabelProtein.Text = (kalori * 20 / 100).ToString()
        ElseIf Login.umur >= 18 Then
            LabelLemak.Text = (kalori * 25 / 100).ToString()
            LabelKarbo.Text = (kalori * 50 / 100).ToString()
            LabelProtein.Text = (kalori * 25 / 100).ToString()
        End If
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilAkun()
        ambilAsupan()

        ceknutrisi()
    End Sub

    Private Sub UserForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
        Registrasi.Close()
    End Sub
    Dim selected As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not selected = Nothing Then
            MsgBox("Pilih Makanan Terlebih Dahulu")
            Return
        ElseIf tPorsi.Text = "" Then
            MsgBox("Masukan Porsi")
            Return
        End If

    End Sub
End Class
