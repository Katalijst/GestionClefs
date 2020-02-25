Imports MySql.Data.MySqlClient
Public Class frmPropGpBat

    Private Sub frmPropGpBat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtBatiment As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text

        With cmd
            .Parameters.Add("@IDClef", MySqlDbType.String)
        End With

        dtBatiment.Reset()
        sql = "SELECT DISTINCT BNum, GIDBat FROM Batiment, GroupeBat, Emprunts WHERE GIDClef = @IDClef AND GIDBat = BNom"
            With cmd
            .Parameters("@IDClef").Value = frmEditerEtProprietes.IDClef
            .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiment)
            dtBatiment.Columns("BNum").ColumnName = strTitleBNum
            dtBatiment.Columns("GIDBat").ColumnName = strTitleGIDBat

            dgvListBatiment.DataSource = dtBatiment
            dgvListBatiment.Columns(0).Width = 50
            dgvListBatiment.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Try
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Dispose()
    End Sub
End Class