Imports MySql.Data.MySqlClient
Imports System.Linq
Public Class frmClefsEditerEtProprietesGroupeBat

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
            If Application.OpenForms().OfType(Of frmAlertesProprietes).Any Then
                .Parameters("@IDClef").Value = frmAlertesProprietes.lblID.Text
            Else
                .Parameters("@IDClef").Value = frmClefsEditerEtProprietes.IDClef
            End If
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

    Private NewPoint As New Point
    Private New_X, New_Y As Integer

    Private Sub DragForm_Label_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvListBatiment.MouseUp
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dgvListBatiment_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvListBatiment.MouseDown
        dgvListBatiment.ClearSelection()
        If Not Me.WindowState = FormWindowState.Maximized Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                New_X = Control.MousePosition.X - Me.Location.X
                New_Y = Control.MousePosition.Y - Me.Location.Y
                Me.Cursor = Cursors.NoMove2D
            End If
        End If
    End Sub

    Private Sub dgvListBatiment_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvListBatiment.MouseMove
        If Not Me.WindowState = FormWindowState.Maximized Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                NewPoint = Control.MousePosition
                NewPoint.X -= (New_X)
                NewPoint.Y -= (New_Y)
                Me.Location = NewPoint
            End If
        End If
    End Sub
End Class