Imports MySql.Data.MySqlClient

Public Class Diet
    Public idakun As String
    Public setini As String
    Dim idmakanan As String

    Sub TampilJenis()
        DA = New MySqlDataAdapter("select * from makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "makanan")
        DataGridView1.DataSource = DS.Tables("makanan")
        DataGridView1.Refresh()
    End Sub

    Sub TampilDiet()
        Dim tampil As String = "select diet.id, makanan.nama, makanan.berat, makanan.kalori, makanan.unit, makanan.jenis, diet.waktu from diet join makanan on (diet.idmakanan = makanan.id) where idsetdiet = '" & setini & "' order by diet.waktu"
        DA = New MySqlDataAdapter(tampil, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "diet")
        DataGridView2.DataSource = DS.Tables("diet")
        DataGridView2.Refresh()
    End Sub

    Private Sub Diet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SetDiet.Show()

    End Sub

    Sub Buat()
        DataGridView2.Columns(0).Width = 30
        DataGridView2.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView2.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGridView1.Columns(0).Width = 30
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Diet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilJenis()
        Call TampilDiet()
        Call total()
        Call Buat()

        ComboBox1.SelectedIndex = 0
        idmakanan = "-1"
    End Sub

    Function cekkosong() As Integer
        If idmakanan = "-1" Then
            MsgBox("pilih makanan terlebih dahulu")
            Return 1
        End If
        Return 0
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        idmakanan = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Dim selecthapus As String
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        selecthapus = DataGridView2.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Kalori_Click(sender As Object, e As EventArgs) Handles Kalori.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim kosong As String = "delete from diet where idsetdiet = '" & setini & "'"
        CMD = New MySqlCommand(kosong, CONN)
        CMD.ExecuteNonQuery()
        TampilDiet()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DA = New MySqlDataAdapter("select * from makanan where nama like '%" & TextBox1.Text & "%' or jenis like '%" & TextBox1.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "makanan")
        DataGridView1.DataSource = DS.Tables("makanan")
        DataGridView1.ReadOnly = True

        If DataGridView1.RowCount < 1 Then
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DA = New MySqlDataAdapter("select * from makanan where nama like '%" & TextBox1.Text & "%' or jenis like '%" & TextBox1.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "makanan")
        DataGridView1.DataSource = DS.Tables("makanan")
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub total()
        Dim t As Integer = 0
        For i = 0 To (DataGridView2.RowCount - 1)
            t += DataGridView2.Rows(i).Cells(3).Value
        Next
        Kalori.Text = t
    End Sub

    Private Sub Nomor()
        Dim I As Integer

        For I = 1 To DataGridView2.RowCount - 1
            DataGridView2.Rows(I - 1).Cells(0).Value = I
        Next

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cekkosong() = 0 Then
            Dim Simpan As String = "insert into diet(idakun, idmakanan, waktu, idsetdiet) values('" & idakun & "', '" & idmakanan & "', '" & ComboBox1.Text & "', '" & setini & "')"
            CMD = New MySqlCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            TampilDiet()
            Call total()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Hps As String = "delete from diet where id = '" & selecthapus & "'"
        CMD = New MySqlCommand(Hps, CONN)
        CMD.ExecuteNonQuery()
        TampilDiet()
        Call total()
    End Sub
End Class