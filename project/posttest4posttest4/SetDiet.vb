Imports MySql.Data.MySqlClient

Public Class SetDiet

    Dim idakun = Diet.idakun

    Sub tambah()
        CMD = New MySqlCommand("select * from setdiet where nama = '" & TextBox1.Text & "' and idakun = '" & idakun & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            MsgBox("Nama Set sudah ada!", MsgBoxStyle.Information, "Perhatian")
            TextBox1.Focus()
            Exit Sub
        End If
        RD.Close()

        Dim Simpan As String = "insert into setdiet(nama, idakun) values('" & TextBox1.Text & "', '" & idakun & "')"
        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
    End Sub
    Sub tampil()
        DA = New MySqlDataAdapter("select id, nama from setdiet where idakun = '" & idakun & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "setdiet")
        DataGridView1.DataSource = DS.Tables("setdiet")
        DataGridView1.Refresh()
    End Sub
    Dim selected As String

    Private Sub SetDiet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Beranda.Show()

    End Sub

    Sub buat()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 250

    End Sub


    Private Sub SetDiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        buat()

        selected = "-1"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selected = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If selected = "-1" Then
            MsgBox("Pilih set terlebih dahulu!")
        Else
            Diet.setini = selected
            Diet.idakun = idakun
            Me.Hide()
            Diet.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan nama set terlebih dahulu")
        Else
            tambah()
            tampil()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Hapus As String = "delete from diet where idsetdiet = '" & selected & "'"
        CMD = New MySqlCommand(Hapus, CONN)
        CMD.ExecuteNonQuery()
        Hapus = "delete from setdiet where id = '" & selected & "'"
        CMD = New MySqlCommand(Hapus, CONN)
        CMD.ExecuteNonQuery()
        tampil()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub
End Class