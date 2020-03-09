Imports MySql.Data.MySqlClient

Public Class frmTableauxEditer
    Shared stgPosID

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmEditerPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)

        lblPNom.Text = strTitlePNom & " :"
        lblPBatiment.Text = strTitlePBatiment & " :"
        lblPResponsable.Text = strTitlePResponsable & " :"

        cbResponsable.Hint = strTitlePResponsable
        txtNom.Hint = strTitlePNom

        RefreshResponsable()
        RefreshBatiment()
        RemplissageAuto()
    End Sub
    Public Sub RemplissageAuto()
        Dim intIndexNom As Integer = frmTableauxGestion.dgvListTableau.Columns("Nom").Index
        stgPosID = frmTableauxGestion.dgvListTableau.SelectedRows(0).Cells(intIndexNom).Value.ToString()
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
            For i As Integer = 0 To (cbResponsable.Items.Count - 1)
                If cbResponsable.GetItemText(cbResponsable.Items(i)) = stgType Then
                    cbResponsable.SelectedIndex = i
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

    Public Sub RefreshResponsable(ByVal Optional name As String = "Empty")
        Dim dtNom As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select NNom from NomPersonne where NNom <> 'Personne'"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtNom)

            Dim strCbPersonne As String() = New String(dtNom.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtNom.Rows
                strCbPersonne(i) = r.Item(0).ToString
                i += 1
            Next
            cbResponsable.DataSource = strCbPersonne
            If name <> "Empty" Then
                cbResponsable.Text = name
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

    Private Sub btnCancel_Click2(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddPersonne_Click(sender As Object, e As EventArgs) Handles btnAddPersonne.Click
        frmPersonnesEditer.ShowDialog()
    End Sub

    Private Sub btnSave_Click2(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Dim intIndexNom As Integer = dgvListBatiment.Columns("Nom").Index
        Dim stgBatNom As String = dgvListBatiment.SelectedRows(0).Cells(intIndexNom).Value.ToString()

        Try
            If txtNom.Text <> "" Then
                sql = "UPDATE Position SET PNom = '" & txtNom.Text & "', PResponsable = '" & cbResponsable.Text & "', PBatiment = '" & stgBatNom & "' WHERE PNom = '" & stgPosID & "'"
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
        If frmClefsAjout.IsHandleCreated Then
            frmClefsAjout.RefreshTableau()
        End If
        If frmTableauxGestion.IsHandleCreated Then
            frmTableauxGestion.RefreshList()
        End If
    End Sub

End Class