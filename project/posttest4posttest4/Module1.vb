Imports MySql.Data.MySqlClient

Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public DA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public Sub koneksi()
        Try
            CONN = New MySqlConnection("server=localhost;userid=root;password=;database=papemvis")
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
