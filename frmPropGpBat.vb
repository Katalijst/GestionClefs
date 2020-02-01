Imports MySql.Data.MySqlClient
Public Class frmPropGpBat
    Private Sub frmPropGpBat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtBatiment As New DataTable
        Dim sql As String

        Dim stgIDClef As String = frmProprietes.lblID.Text
        Try

            sql = "SELECT DISTINCT BNum, GIDBat FROM Batiment, GroupeBat, Emprunts  WHERE GIDClef = '" & stgIDClef & "' AND GIDBat = BNom"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiment)

            For i As Integer = 0 To dtBatiment.Columns.Count - 1
                dtBatiment.Columns(i).ColumnName = dtBatiment.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            dgvListBatiment.DataSource = dtBatiment

            For i = 0 To dgvListBatiment.ColumnCount - 2
                dgvListBatiment.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            dgvListBatiment.Columns(dgvListBatiment.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class