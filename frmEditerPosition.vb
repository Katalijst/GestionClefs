Imports MySql.Data.MySqlClient

Public Class frmEditerPosition
    Shared stgPosID
    Private Sub frmEditerPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)

        lblPNom.Text = strTitlePNom & " :"
        lblPBatiment.Text = strTitlePBatiment & " :"
        lblPResponsable.Text = strTitlePResponsable & " :"

        RefreshResponsable()
        RefreshBatiment()
        RemplissageAuto()
    End Sub
    Public Sub RemplissageAuto()
        Dim intIndexNom As Integer = frmGestionPosition.dgvListTableau.Columns("Nom").Index
        stgPosID = frmGestionPosition.dgvListTableau.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        txtNom.Text = stgPosID

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try
            dt.Reset()
            sql = "Select PResponsable FROM Position WHERE PNom=""" & stgPosID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Dim stgType As String = dt.Rows(0)(0)
            For i As Integer = 0 To (cmbResponsable.Items.Count - 1)
                If cmbResponsable.GetItemText(cmbResponsable.Items(i)) = stgType Then
                    cmbResponsable.SelectedIndex = i
                End If
            Next
            connecter().Close()

            dt.Reset()
            sql = "Select PBatiment FROM Position WHERE PNom=""" & stgPosID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Try
                Dim intIndexNomBat As Integer = dgvListBatiment.Columns("Nom").Index
                For i = 0 To dgvListBatiment.RowCount - 1
                    If dgvListBatiment.Rows(i).Cells(intIndexNomBat).Value.ToString.IndexOf(dt.Rows(0)(0).ToString, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                        dgvListBatiment.Rows(i).Selected = True
                        dgvListBatiment.FirstDisplayedScrollingRowIndex = i
                        Exit For
                    End If
                Next
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshResponsable()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from NomPersonne"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbResponsable.DataSource = dt
            cmbResponsable.ValueMember = "NNom"
            cmbResponsable.DisplayMember = "NNom"
            If cmbResponsable.Items.Count > 0 Then
                cmbResponsable.SelectedIndex = 0
            End If
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshBatiment()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtBatiment As New DataTable
        Dim sql As String

        Try

            sql = "Select BNum, BNom From Batiment where BNum <> '0' order by BNom ASC"

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddPersonne_Click(sender As Object, e As EventArgs) Handles btnAddPersonne.Click
        frmEditerPersonne.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Dim intIndexNom As Integer = dgvListBatiment.Columns("Nom").Index
        Dim stgBatNom As String = dgvListBatiment.SelectedRows(0).Cells(intIndexNom).Value.ToString()

        Try
            If txtNom.Text <> "" Then
                sql = "UPDATE Position SET PNom = '" & txtNom.Text & "', PResponsable = '" & cmbResponsable.Text & "', PBatiment = '" & stgBatNom & "' WHERE PNom = '" & stgPosID & "'"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                connecter().Close()
                frmMain.FillDataSource()
                Me.Close()
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If frmCreerClefs.IsHandleCreated Then
            frmCreerClefs.RefreshPosition()
        End If
        If frmGestionPosition.IsHandleCreated Then
            frmGestionPosition.RefreshList()
        End If
    End Sub
End Class