Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmCreerClefs
    Private Sub frmCreerClefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        LoadAndRefresh()
        RefreshBatiment()
    End Sub

    Private Sub frmCreerClefs_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
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
        Dim blnIncompleteForm As Boolean = False
        If txtQuantity.Text <> "" Then
            If CUInt(txtQuantity.Text) > 49 Then
                If MsgBox("Voulez-vous vraiment ajouter " & txtQuantity.Text.ToString & " au gestionnaire ?", MsgBoxStyle.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Vous n'avez pas remplis tout les champs", MsgBoxStyle.OkOnly)
        End If
        If txtID.Text.ToUpper = "" Then
            MsgBox("Vous n'avez pas remplis tout les champs", MsgBoxStyle.OkOnly)
            blnIncompleteForm = True
        ElseIf txtNom.Text = "" Then
            MsgBox("Vous n'avez pas remplis tout les champs", MsgBoxStyle.OkOnly)
            blnIncompleteForm = True
        ElseIf cmbLoc.SelectedIndex = -1 Then
            MsgBox("Vous n'avez pas remplis tout les champs", MsgBoxStyle.OkOnly)
            blnIncompleteForm = True
        ElseIf cmbTrousseauListe.SelectedIndex = -1 Then
            MsgBox("Vous n'avez pas remplis tout les champs", MsgBoxStyle.OkOnly)
            blnIncompleteForm = True
        ElseIf dgvSelBatiment.RowCount < 1 Then
            MsgBox("Vous n'avez pas assigné de batiments d'utilisation à la clef !")
            blnIncompleteForm = True
        End If
        If blnIncompleteForm = True Then
            Exit Sub
        End If

        Dim blnOption As Boolean = False
        If txtRefOrg.Text <> "" Or txtCnInt.Text <> "" Or txtCnExt.Text <> "" Or txtCnOpt.Text <> "" Then
            blnOption = True
        End If


        Dim blnClefExisteDeja As Boolean = False
        Dim stgNomClef As String = txtNom.Text
        Dim stgBatimentClef As String
        Dim LastKeyID As Integer = 0
        Dim cmd As String = "Select CID, CNom, CBatiment from Clefs Where CID like @IDClef;"
        Dim da As New MySqlDataAdapter
        Dim dtListClefs As DataTable = New DataTable()
        Dim getKeyID_command As New MySqlCommand(cmd, connecter())
        getKeyID_command.CommandType = CommandType.Text
        da.InsertCommand = getKeyID_command

        With getKeyID_command
            .Parameters.Add("@IDClef", MySqlDbType.String)
        End With
        connecter()

        Try
            getKeyID_command.Parameters("@IDClef").Value = txtID.Text.ToUpper & "-%"
            getKeyID_command.ExecuteNonQuery()
        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox((ex.Number & " - " & ex.Message))
        End Try
        da.SelectCommand = getKeyID_command
        da.Fill(dtListClefs)

        If dtListClefs.Rows.Count > 0 Then
            For Each r As DataRow In dtListClefs.Rows
                Dim input As String = r.Item("CID")
                Dim index As Integer = input.LastIndexOf("-")
                If index > 0 Then
                    Dim TempInt As Integer
                    Integer.TryParse(input.Substring(index + 1), TempInt)
                    If TempInt > LastKeyID Then
                        LastKeyID = TempInt
                    End If
                End If
            Next
            Dim DialogAjoutClef As DialogResult = MsgBox("Une clef existe déjà avec ce numéro, voulez-vous vraiment ajouter " & txtQuantity.Text.ToString & " à la quantité de cette clef ?" & System.Environment.NewLine & "(L'accès de la clef et les bâtiments seront remplacés pour correspondre à celui des clefs existantes.)", MsgBoxStyle.OkCancel)
            If DialogAjoutClef = DialogResult.Cancel Then
                Exit Sub
            Else
                blnClefExisteDeja = True
                stgNomClef = dtListClefs.Rows(0).Item(1).ToString
                stgBatimentClef = dtListClefs.Rows(0).Item(2).ToString
            End If
        End If

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
        Dim cmdInfoTech As String = "INSERT INTO InfosTechniques(IDClef, RefOrg, CanonInte, CanonExte, CanonOpt) VALUES (@keyid,@RefOrg,@CanonInt,@CanonExte,@CanonOpt);"
        Dim insert_infotech As New MySqlCommand(cmdInfoTech, connecter())
        insert_infotech.CommandType = CommandType.Text

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

        With insert_infotech
            .Parameters.Add("@keyid", MySqlDbType.VarChar)
            .Parameters.Add("@RefOrg", MySqlDbType.VarChar)
            .Parameters.Add("@CanonInt", MySqlDbType.Float)
            .Parameters.Add("@CanonExte", MySqlDbType.Float)
            .Parameters.Add("@CanonOpt", MySqlDbType.VarChar)
        End With

        Try
            Dim i As Integer = 0
            For i = 1 + LastKeyID To CUInt(txtQuantity.Text) + LastKeyID
                With insert_command
                    .Parameters("@id").Value = txtID.Text.ToUpper(CultureInfo.InvariantCulture) & "-" & i
                    .Parameters("@name").Value = stgNomClef
                    .Parameters("@pos").Value = cmbLoc.Text
                    .Parameters("@status").Value = "Disponible"
                    .Parameters("@date").Value = Now
                    If cmbTrousseauListe.SelectedItem IsNot Nothing Or cmbTrousseauListe.Text = "Aucun" Then
                        .Parameters("@trousseau").Value = cmbTrousseauListe.Text
                    Else
                        .Parameters("@trousseau").Value = "Aucun"
                    End If
                    If blnClefExisteDeja = True Then
                        .Parameters("@batiment").Value = stgBatimentClef
                    Else
                        If dgvSelBatiment.RowCount > 1 Then
                            .Parameters("@batiment").Value = "Groupe de Batiments"
                            blnGroupeBatiment = True
                        ElseIf dgvSelBatiment.RowCount = 1 Then
                            .Parameters("@batiment").Value = dgvSelBatiment.Rows(0).Cells(1).Value.ToString()
                        Else
                            MsgBox("Vous n'avez pas assigné de batiments d'utilisation à la clef !")
                        End If
                    End If

                    .ExecuteNonQuery()
                End With
            Next

            If blnGroupeBatiment = True Then
                For Each row In dgvSelBatiment.Rows
                    With insert_gp_bt_command
                        .Parameters("@keyid").Value = txtID.Text.ToUpper
                        .Parameters("@batid").Value = row.Cells(1).Value.ToString()
                        .ExecuteNonQuery()
                    End With
                Next
            End If

            Dim intCanonInt As Integer
            Dim intCanonExt As Integer
            Integer.TryParse(txtCnInt.Text, intCanonInt)
            Integer.TryParse(txtCnInt.Text, intCanonExt)
            If blnOption = True Then
                With insert_infotech
                    '@keyid,@RefOrg,@CanonInt,@CanonExte,@CanonOpt
                    .Parameters("@keyid").Value = txtID.Text.ToUpper
                    .Parameters("@RefOrg").Value = txtRefOrg.Text
                    .Parameters("@CanonInt").Value = intCanonInt
                    .Parameters("@CanonExte").Value = intCanonExt
                    .Parameters("@CanonOpt").Value = txtCnOpt.Text
                    .ExecuteNonQuery()
                End With
            End If
        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox((ex.Number & " - " & ex.Message))
            connecter().Close()
            Exit Sub
        Finally
            connecter().Close()
            frmMain.FillDataSource()
            If chkKeepOpen.Checked = False Then
                Me.Dispose()
                Me.Close()
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
        cmbTrousseauListe.Items.Clear()
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
            dt.Rows.InsertAt(newRow, 0)

            For Each r As DataRow In dt.Rows
                cmbTrousseauListe.Items.Add(r.Item(0).ToString)
            Next

            'cmbTrousseauListe.DataSource = dt
            'cmbTrousseauListe.ValueMember = dt.Columns(0).ToString
            'cmbTrousseauListe.DisplayMember = strTitleTNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshPosition()
        cmbLoc.Items.Clear()
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

            For Each r As DataRow In dt.Rows
                cmbLoc.Items.Add(r.Item(0).ToString)
            Next

            'cmbLoc.DataSource = dt
            'cmbLoc.ValueMember = dt.Columns(0).ToString
            'cmbLoc.DisplayMember = strTitlePNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadAndRefresh()
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

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCnInt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCnInt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCnExt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCnExt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class