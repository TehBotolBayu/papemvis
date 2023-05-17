Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
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
    Dim selected As Integer = -1

    Friend WithEvents Labelx As Label
    Dim Panel1(15) As Panel

    Dim lemakmax, proteinmax, karbomax As Double

    Dim progresskal As Double
    Dim progresspro As Double
    Dim progresskar As Double
    Dim progresslem As Double

    Dim panelnow As String
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





    Private Sub ceknutrisi()
        If Login.umur < 3 Then
            lemakmax = (kalori * 35 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 15 / 100)
        ElseIf Login.umur < 18 And Login.umur >= 3 Then
            lemakmax = (kalori * 30 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 20 / 100)
        ElseIf Login.umur >= 18 Then
            lemakmax = (kalori * 25 / 100)
            karbomax = (kalori * 50 / 100)
            proteinmax = (kalori * 25 / 100)
        End If
    End Sub

    Private Sub aturDashboard()
        barkalori.Width = 0
        barkarbo.Width = 0
        barlemak.Width = 0
        barprotein.Width = 0

        Dim tglasupan As String = dt1.Value.Year.ToString & "-" & dt1.Value.Month.ToString & "-" & dt1.Value.Day.ToString
        Dim kaltotal, prototal, lemtotal, karbototal As Double
        kaltotal = 0
        prototal = 0
        lemtotal = 0
        karbototal = 0


        CMD = New MySqlCommand("select * from nutrisi where tanggal = '" & tglasupan & "'", CONN)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            While RD.Read
                kaltotal = kaltotal + RD(1)
                prototal = prototal + RD(2)
                lemtotal = lemtotal + RD(3)
                karbototal = karbototal + RD(4)
            End While
        Else
        End If
        RD.Close()

        LabelKalori.Text = kaltotal.ToString & "/" & kalori.ToString
        LabelProtein.Text = prototal.ToString & "/" & proteinmax.ToString
        LabelLemak.Text = lemtotal.ToString & "/" & lemakmax.ToString
        LabelKarbo.Text = karbototal.ToString & "/" & karbomax.ToString





        CMD = New MySqlCommand("SELECT makanan.nama, makanan.kalori, makanan.lemak, makanan.protein, makanan.karbohidrat, nutrisi.porsi FROM nutrisi JOIN makanan WHERE nutrisi.idmakanan = makanan.id AND nutrisi.tanggal = '" & tglasupan & "'", CONN)
        RD = CMD.ExecuteReader
        Dim ii As Integer = 0
        If RD.HasRows Then
            While RD.Read
                Panel1(ii) = New Panel()
                Labelx = New Label()

                Labelx.AutoSize = True
                Labelx.Location = New Point(22, 19)
                Labelx.Name = "Label" & ii
                Labelx.Size = New Size(41, 15)
                Labelx.TabIndex = 0
                Labelx.Text = RD(0).ToString

                Panel1(ii).Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
                Panel1(ii).BackColor = Color.Transparent
                Panel1(ii).BackgroundImage = My.Resources.Resources.Rectangle_12
                Panel1(ii).BackgroundImageLayout = ImageLayout.Stretch
                Panel1(ii).Controls.Add(Labelx)
                Panel1(ii).Location = New Point(25, 253 + (120 * ii))
                Panel1(ii).Name = "Panel" & ii
                Panel1(ii).Size = New Size(730, 120)
                Panel1(ii).TabIndex = 1

                AddHandler Panel1(ii).MouseClick, AddressOf tes
                PanelDashboard.Controls.Add(Panel1(ii))
                ''Controls.Add(Panel1(ii))
                ii = ii + 1
            End While
        Else
        End If
        RD.Close()

        progresskal = kaltotal / kalori
        progresskar = karbototal / karbomax
        progresslem = lemtotal / lemakmax
        progresspro = prototal / proteinmax

        Timer1.Enabled = True
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tgltgl.Text = hariini.Day & " " & MonthName(hariini.Month) & " " & hariini.Year
        ambilAkun()
        ambilAsupan()
        ceknutrisi()
        aturDashboard()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        LabelHome.ForeColor = Color.White
        panelnow = "db"

    End Sub

    Sub tes(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = CType(sender, Panel)
        MsgBox("tes" & clickedPanel.Name)
    End Sub

    Private Sub UserForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
        Registrasi.Close()
    End Sub

    Private Sub tPorsi_TextChanged(sender As Object, e As EventArgs) Handles tPorsi.TextChanged
        If tPorsi.Text = "" Then
            tPorsi.Text = "1"
        End If
        If Not selected = -1 Then
            lkalori.Text = (Val(tPorsi.Text) * dgvAsupan.Rows(selected).Cells(2).Value).ToString
            llemak.Text = (Val(tPorsi.Text) * dgvAsupan.Rows(selected).Cells(3).Value).ToString
            lprotein.Text = (Val(tPorsi.Text) * dgvAsupan.Rows(selected).Cells(4).Value).ToString
            lkarbo.Text = (Val(tPorsi.Text) * dgvAsupan.Rows(selected).Cells(5).Value).ToString
        End If

    End Sub

    Private Sub tPorsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tPorsi.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

    End Sub

    Private Sub LabelKalori_Click(sender As Object, e As EventArgs) Handles LabelKalori.Click

    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        aturDashboard()
        tgltgl.Text = dt1.Text
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(hariini)
        If selected = -1 Then
            MsgBox("Pilih makanan terlebih dahulu")
            Return
        End If
        If tPorsi.Text = "" Then
            MsgBox("Masukkan porsi terlebih dahulu")
        End If

        Dim kal, pro, lem, kar As Double
        Dim idakun As String = Login.idLogin
        Dim idmakanan As String = dgvAsupan.Rows(selected).Cells(0).Value.ToString
        kal = Val(lkalori.Text)
        pro = Val(lprotein.Text)
        lem = Val(llemak.Text)
        kar = Val(lkarbo.Text)
        Dim tglhari As String
        tglhari = hariini.Year.ToString & "-" & hariini.Month.ToString & "-" & hariini.Day.ToString
        Dim Simpan As String = "insert into nutrisi(kalori, protein, lemak, karbohidrat, tanggal, idakun, kalorimax, lemakmax, proteinmax, karbomax, idmakanan, porsi) values('" & kal & "', '" & pro & "', '" & lem & "', '" & kar & "', '" & tglhari & "', '" & Login.idLogin & "', '" & kalori & "', '" & lemakmax & "', '" & proteinmax & "', '" & karbomax & "', '" & idmakanan & "', '" & tPorsi.Text & "')"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()

        aturDashboard()
    End Sub


    Private Sub dgvAsupan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsupan.CellClick
        selected = e.RowIndex
        lkalori.Text = dgvAsupan.Rows(selected).Cells(2).Value.ToString
        llemak.Text = dgvAsupan.Rows(selected).Cells(3).Value.ToString
        lprotein.Text = dgvAsupan.Rows(selected).Cells(4).Value.ToString
        lkarbo.Text = dgvAsupan.Rows(selected).Cells(5).Value.ToString


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If barkalori.Width < (143 * progresskal) Then
            barkalori.Width = barkalori.Width + 5
        ElseIf barkarbo.Width < (143 * progresskar) Then
            barkarbo.Width = barkarbo.Width + 5
        ElseIf barprotein.Width < (143 * progresspro) Then
            barprotein.Width = barprotein.Width + 5
        ElseIf barlemak.Width < (143 * progresslem) Then
            barlemak.Width = barlemak.Width + 5
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub bDashboard_Paint(sender As Object, e As PaintEventArgs) Handles bDashboard.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        tgltgl.Text = dt1.Text
        dt1.Show()
        dt1.Select()
        SendKeys.Send("%{DOWN}")
        tgltgl.Text = dt1.Text
    End Sub

    Private Sub tgltgl_Click(sender As Object, e As EventArgs) Handles tgltgl.Click

    End Sub

    Private Sub bAsupanku_MouseClick(sender As Object, e As MouseEventArgs) Handles bAsupanku.MouseClick
        PanelAsupan.Show()
        PanelDashboard.Hide()
        PanelProfil.Hide()
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
        bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        LabelAsupan.ForeColor = Color.White
        LabelHome.ForeColor = Color.DimGray
        panelnow = "as"
    End Sub

    Private Sub bDashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles bDashboard.MouseClick
        PanelAsupan.Hide()
        PanelDashboard.Show()
        PanelProfil.Hide()
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
        bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        LabelHome.ForeColor = Color.White
        LabelAsupan.ForeColor = Color.DimGray
        panelnow = "db"
    End Sub

    Private Sub dt1_LostFocus(sender As Object, e As EventArgs) Handles dt1.LostFocus
        tgltgl.Text = dt1.Text
    End Sub

    Private Sub bDashboard_MouseEnter(sender As Object, e As EventArgs) Handles bDashboard.MouseEnter
        bDashboard.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub bAsupanku_MouseEnter(sender As Object, e As EventArgs) Handles bAsupanku.MouseEnter
        bAsupanku.BackColor = Color.FromArgb(191, 139, 255)
    End Sub

    Private Sub bAsupanku_MouseLeave(sender As Object, e As EventArgs) Handles bAsupanku.MouseLeave
        If Not panelnow = "as" Then
            bAsupanku.BackColor = Color.FromArgb(255, 255, 255)
        End If

    End Sub

    Private Sub bDashboard_MouseLeave(sender As Object, e As EventArgs) Handles bDashboard.MouseLeave
        If Not panelnow = "db" Then
            bDashboard.BackColor = Color.FromArgb(255, 255, 255)
        End If

    End Sub
End Class