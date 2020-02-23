Imports MySql.Data.MySqlClient

Public Class frmCreerClefs
    Private Sub frmCreerClefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        LoadAndRefresh()
        RefreshBatiment()
    End Sub

    Private Sub dgvListBatiment_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListBatiment.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvListBatiment.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvListBatiment.PointToClient(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgvSelBatiment_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvSelBatiment.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvSelBatiment.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvSelBatiment.PointToClient(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnGroupeBatiment As Boolean = False
        Dim intQuantity As Integer
        Dim daSql As MySqlDataAdapter = New MySqlDataAdapter()
        Dim cmdinsert As String = "INSERT INTO
                                                              `Clefs`(
                                                                `CID`,
                                                                `CNom`,
                                                                `CPosition`,
                                                                `CStatus`,
                                                                `CDate`,
                                                                `CTrousseau`,
                                                                `CBatiment`
                                                              )
                                                            VALUES
                                                              (
                                                                @id,
                                                                @name,
                                                                @pos,
                                                                @status,
                                                                @date,
                                                                @trousseau,
                                                                @batiment
                                                              );"
        Dim cmdGrpBat As String = "INSERT INTO `GroupeBat`(`GIDClef`, `GIDBat`) VALUES (@keyid,@batid);"
        Dim insert_command As New MySqlCommand(cmdinsert, connecter())
        Dim insert_gp_bt_command As New MySqlCommand(cmdGrpBat, connecter())
        insert_command.CommandType = CommandType.Text
        daSql.InsertCommand = insert_command

        connecter()

        With insert_command
            .Parameters.Add("@id", MySqlDbType.VarChar)
            .Parameters.Add("@name", MySqlDbType.VarChar)
            .Parameters.Add("@pos", MySqlDbType.VarChar)
            .Parameters.Add("@status", MySqlDbType.VarChar)
            .Parameters.Add("@date", MySqlDbType.DateTime)
            .Parameters.Add("@trousseau", MySqlDbType.VarChar)
            .Parameters.Add("@batiment", MySqlDbType.VarChar)
        End With

        With insert_gp_bt_command
            .Parameters.Add("@keyid", MySqlDbType.VarChar)
            .Parameters.Add("@batid", MySqlDbType.VarChar)
        End With

        Try
            Dim i As Integer = 0
            For i = 1 To intQuantity
                With insert_command
                    .Parameters("@id").Value = txtID.Text & "-" & i
                    .Parameters("@name").Value = txtNom.Text
                    .Parameters("@pos").Value = cmbLoc.Text
                    .Parameters("@status").Value = "Disponible"
                    .Parameters("@date").Value = Now
                    If cmbTrousseauListe.Text <> "" Or cmbTrousseauListe.Text = "Aucun" Then
                        .Parameters("@trousseau").Value = cmbTrousseauListe.Text
                    Else
                        .Parameters("@trousseau").Value = "Aucun"
                    End If
                    If dgvSelBatiment.RowCount > 1 Then
                        .Parameters("@batiment").Value = "Groupe de Batiments"
                        blnGroupeBatiment = True
                    ElseIf dgvSelBatiment.RowCount = 1 Then
                        .Parameters("@batiment").Value = dgvSelBatiment.Rows(0).Cells(1).Value.ToString()
                    Else
                        MsgBox("Vous n'avez pas assigné de batiments d'utilisation à la clef !")
                    End If
                    .ExecuteNonQuery()
                End With
                If blnGroupeBatiment = True Then
                    For Each row In dgvSelBatiment.Rows
                        With insert_gp_bt_command
                            .Parameters("@keyid").Value = txtID.Text & "-" & "0" & i
                            .Parameters("@batid").Value = row.Cells(1).Value.ToString()
                            .ExecuteNonQuery()
                        End With
                    Next
                End If
            Next

        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox((ex.Number & " - " & ex.Message))
        Finally
            connecter().Close()
            frmMain.FillDataSource()
            If chkKeepOpen.Checked = False Then
                Me.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnNewTrousseau_Click(sender As Object, e As EventArgs)
        frmCreerTrousseau.Show()
    End Sub

    Public Sub FilldgSelBatiment()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtBatiments As New DataTable

        Dim sql As String

        Try

            sql = "Select BNum, BNom From Batiment" 'Selectionner BID et BNOM

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiments)
            dtBatiments.Columns("BNum").ColumnName = strTitleBNum
            dtBatiments.Columns("BNom").ColumnName = strTitleBNom

            dtBatiments.Rows.Clear()
            dgvSelBatiment.DataSource = dtBatiments
            dgvSelBatiment.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvSelBatiment.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each column In dgvSelBatiment.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshBatiment()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtBatiments As New DataTable
        Dim dtlistBatiments As New DataTable
        Dim sql As String

        Try

            sql = "Select BNum, BNom From Batiment where BNum <> '0' order by BNom ASC" 'Selectionner BID et BNOM

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiments)

            dtBatiments.Columns("BNum").ColumnName = strTitleBNum
            dtBatiments.Columns("BNom").ColumnName = strTitleBNom

            dgvListBatiment.DataSource = dtBatiments
            dgvListBatiment.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListBatiment.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each column In dgvListBatiment.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            connecter().Close()

            If dgvSelBatiment.Rows.Count = 0 Then
                FilldgSelBatiment()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshTrousseau()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Trousseau where TNom <> 'Aucun'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim newRow As DataRow = dt.NewRow()
            newRow(0) = "Aucun"
            newRow(1) = "Personne"
            dt.Rows.InsertAt(newRow, 0)

            cmbTrousseauListe.DataSource = dt
            cmbTrousseauListe.ValueMember = "TNom"
            cmbTrousseauListe.DisplayMember = strTitleTNom
            If cmbTrousseauListe.Items.Count > 0 Then
                cmbTrousseauListe.SelectedIndex = 0
            End If

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshPosition()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Position"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbLoc.DataSource = dt
            cmbLoc.ValueMember = "PNom"
            cmbLoc.DisplayMember = strTitlePNom
            If cmbLoc.Items.Count > 0 Then
                cmbLoc.SelectedIndex = 0
            End If

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadAndRefresh()
        If cmbLoc.Items.Count > 0 Then
            cmbLoc.SelectedIndex = 0
        End If
        If cmbTrousseauListe.Items.Count > 0 Then
            cmbTrousseauListe.SelectedIndex = 0
        End If
        RefreshPosition()
        RefreshTrousseau()
        FilldgSelBatiment()
    End Sub

    Private Sub btnNewTrousseau_Click_1(sender As Object, e As EventArgs) Handles btnNewTrousseau.Click
        frmCreerTrousseau.ShowDialog()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Rechercher()
    End Sub

    Public Sub Rechercher()
        Dim searchValue As String = txtRechercher.Text

        Try
            For i = 0 To dgvListBatiment.RowCount - 1
                If dgvListBatiment.Rows(i).Cells(1).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListBatiment.Rows(i).Selected = True
                    dgvListBatiment.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub addToSel()
        If dgvListBatiment.SelectedRows.Count > 0 Then
            For Each selRow As DataGridViewRow In dgvListBatiment.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                Dim intSelIndex As Integer = selRow.Index
                Dim dtListBatiment As DataTable = CType(dgvListBatiment.DataSource, DataTable)
                Dim dtSelBatiment As DataTable = CType(dgvSelBatiment.DataSource, DataTable)
                Dim drToAdd As DataRow = dtListBatiment.Rows(intSelIndex)
                dtSelBatiment.ImportRow(drToAdd)
                dtSelBatiment.AcceptChanges()
                dtSelBatiment.DefaultView.Sort = strTitleBNom & " ASC"
                dtSelBatiment = dtSelBatiment.DefaultView.ToTable
                dgvSelBatiment.DataSource = dtSelBatiment

                dtListBatiment.Rows(intSelIndex).Delete()
                dtListBatiment.AcceptChanges()
                dtListBatiment.DefaultView.Sort = strTitleBNom & " ASC"
                dtListBatiment = dtListBatiment.DefaultView.ToTable
                dgvListBatiment.DataSource = dtListBatiment
            Next
        End If
    End Sub

    Private Sub removeFromSel()
        If dgvSelBatiment.SelectedRows.Count > 0 Then
            For Each selRow As DataGridViewRow In dgvSelBatiment.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                Dim intSelIndex As Integer = selRow.Index
                Dim dtListBatiment As DataTable = CType(dgvListBatiment.DataSource, DataTable)
                Dim dtSelBatiment As DataTable = CType(dgvSelBatiment.DataSource, DataTable)
                Dim drToAdd As DataRow = dtSelBatiment.Rows(intSelIndex)
                dtListBatiment.ImportRow(drToAdd)
                dtListBatiment.AcceptChanges()
                dtListBatiment.DefaultView.Sort = strTitleBNom & " ASC"
                dtListBatiment = dtListBatiment.DefaultView.ToTable
                dgvListBatiment.DataSource = dtListBatiment

                dtSelBatiment.Rows(intSelIndex).Delete()
                dtSelBatiment.AcceptChanges()
                dtSelBatiment.DefaultView.Sort = strTitleBNom & " ASC"
                dtSelBatiment = dtSelBatiment.DefaultView.ToTable
                dgvSelBatiment.DataSource = dtSelBatiment
            Next
        End If
    End Sub

    Private Sub dgvListBatiment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBatiment.CellDoubleClick
        addToSel()
    End Sub
    Private Sub dgvSelBatiment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelBatiment.CellDoubleClick
        removeFromSel()
    End Sub

    Private Sub btnAddBatiment_Click(sender As Object, e As EventArgs) Handles btnAddBatiment.Click
        frmGestionBatiments.ShowDialog()
    End Sub

    Private Sub btnNewLoc_Click(sender As Object, e As EventArgs) Handles btnNewLoc.Click
        frmGestionPosition.ShowDialog()
    End Sub

    Private Sub btnRemSelBatiment_Click(sender As Object, e As EventArgs) Handles btnRemSelBatiment.Click
        removeFromSel()
    End Sub

    Private Sub btnAddSelBatiment_Click(sender As Object, e As EventArgs) Handles btnAddSelBatiment.Click
        addToSel()
    End Sub

End Class