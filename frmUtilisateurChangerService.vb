Imports MySql.Data.MySqlClient

Public Class frmUtilisateurChangerService
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmUtilisateurChangerService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        LoadServices(frmUtilisateursGestion.dgvListUser.SelectedRows(0).Cells(2).Value)
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Dim cmd As New MySqlCommand
        Dim sql As String

        Try
            sql = "UPDATE Login SET LServices=@Services WHERE LUserName=@Username"
            With cmd
                .Parameters.Add("@Services", MySqlDbType.VarChar).Value = frmUtilisateursGestion.dgvListUser.SelectedRows(0).Cells(2).Value
                .Parameters.Add("@Username", MySqlDbType.VarChar).Value = cbServices.Text
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            connecter().Close()
            frmUtilisateursGestion.RefreshList()
            Me.Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
        End Try
    End Sub

    Public Sub LoadServices(ByVal Optional name As String = "Empty")
        cbServices.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select DISTINCT SNom from Services where SNom <> 'Global'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                cbServices.Items.Add(r.Item(0).ToString)
            Next
            If name <> "Empty" Then
                cbServices.Text = name
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            connecter().Close()
        End Try
    End Sub

    Private Sub frmUtilisateurChangerService_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class