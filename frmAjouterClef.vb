Imports MySql.Data.MySqlClient

Public Class frmAjouterClef

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
    Private Sub udQuantity_ValueChanged(sender As Object, e As EventArgs) Handles udQuantity.ValueChanged
        If udQuantity.Value > 1 Then
            cmbStatus.Enabled = False
            cmbStatus.SelectedIndex = 0
            cmbTrousseauListe.Enabled = False
            btnNewTrousseau.Enabled = False
            gbEmprunteur.Enabled = False
        Else
            cmbStatus.Enabled = True
            cmbTrousseauListe.Enabled = True
            btnNewTrousseau.Enabled = True
            gbEmprunteur.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnGroupeBatiment As Boolean = False
        Try
            For i = 1 To udQuantity.Value
                Dim insert_command As New MySqlCommand("INSERT INTO
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
                                                              )
                                                            ", connecter())

                insert_command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text & "-" & i
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtNom.Text
                insert_command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = cmbLoc.Text
                insert_command.Parameters.Add("@status", MySqlDbType.VarChar).Value = cmbStatus.Text
                insert_command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTimePicker1.Value
                If cmbTrousseauListe.Text <> "" Or cmbTrousseauListe.Text = "Aucun" Then
                    insert_command.Parameters.Add("@trousseau", MySqlDbType.VarChar).Value = cmbTrousseauListe.Text
                Else
                    insert_command.Parameters.Add("@trousseau", MySqlDbType.VarChar).Value = "Aucun"
                End If
                If dgvSelBatiment.RowCount > 1 Then
                    insert_command.Parameters.Add("@batiment", MySqlDbType.VarChar).Value = "Groupe de Batiments"
                    blnGroupeBatiment = True
                ElseIf dgvSelBatiment.RowCount = 1 Then
                    insert_command.Parameters.Add("@batiment", MySqlDbType.VarChar).Value = dgvSelBatiment.Rows(0).Cells(1).Value.ToString()
                Else
                    MsgBox("Vous n'avez pas assigné de batiments d'utilisation à la clef !")
                End If
                insert_command.ExecuteNonQuery()
                connecter().Close()

                If blnGroupeBatiment = True Then
                    For Each row In dgvSelBatiment.Rows
                        Dim insert_gp_bt_command As New MySqlCommand("INSERT INTO `GroupeBat`(`GIDClef`, `GIDBat`) VALUES (@keyid,@batid)", connecter())
                        insert_gp_bt_command.Parameters.Add("@keyid", MySqlDbType.VarChar).Value = txtID.Text & "-" & "0" & i
                        insert_gp_bt_command.Parameters.Add("@batid", MySqlDbType.VarChar).Value = row.Cells(1).Value.ToString()
                        insert_gp_bt_command.ExecuteNonQuery()
                        connecter().Close()
                    Next
                End If

            Next
            frmMain.SearchAndRefresh()
            frmMain.SetAutocomplete()
            If chkKeepOpen.Checked = False Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNewTrousseau_Click(sender As Object, e As EventArgs)
        frmCreerTrousseau.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub SetAutocomplete()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String

        Try
            sql = "Select BNom From Batiment" 'Selectionner BID et BNOM
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtRechercher.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dt.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtRechercher.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

            For i As Integer = 0 To dtBatiments.Columns.Count - 1
                dtBatiments.Columns(i).ColumnName = dtBatiments.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
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

            For i As Integer = 0 To dtBatiments.Columns.Count - 1
                dtBatiments.Columns(i).ColumnName = dtBatiments.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
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
            cmbTrousseauListe.DisplayMember = "TNom"
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
            cmbLoc.DisplayMember = "PNom"
            If cmbLoc.Items.Count > 0 Then
                cmbLoc.SelectedIndex = 0
            End If

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshNomEmprunteur()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from NomPersonne Order By NNom ASC"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbNomEmprunteur.DataSource = dt
            cmbNomEmprunteur.ValueMember = "NNom"
            cmbNomEmprunteur.DisplayMember = "NNom"
            If cmbNomEmprunteur.Items.Count > 0 Then
                cmbNomEmprunteur.SelectedIndex = 0
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
        If cmbStatus.Items.Count > 0 Then
            cmbStatus.SelectedIndex = 0
        End If
        If cmbTrousseauListe.Items.Count > 0 Then
            cmbTrousseauListe.SelectedIndex = 0
        End If
        RefreshPosition()
        RefreshTrousseau()
        RefreshNomEmprunteur()
        FilldgSelBatiment()
    End Sub

    Private Sub frmAjoutClef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAndRefresh()
        SetAutocomplete()
        RefreshBatiment()
    End Sub

    Private Sub btnNewTrousseau_Click_1(sender As Object, e As EventArgs) Handles btnNewTrousseau.Click
        frmCreerTrousseau.ShowDialog()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbTrousseauListe.Text = "Aucun" Or cmbTrousseauListe.Text = "" Then
            Select Case cmbStatus.SelectedIndex
                Case 0 'Disponible
                    gbEmprunteur.Enabled = False
                    dtpDebutEmprunt.Enabled = False
                    dtpFinEmprunt.Enabled = False
                Case 1 'Empruntée
                    gbEmprunteur.Enabled = True
                    dtpDebutEmprunt.Enabled = True
                    dtpFinEmprunt.Enabled = True
                Case 2 'Attribuée
                    gbEmprunteur.Enabled = True
                    dtpDebutEmprunt.Enabled = True
                    dtpFinEmprunt.Enabled = False
                Case 3 'Perdu
                    gbEmprunteur.Enabled = False
                    dtpDebutEmprunt.Enabled = False
                    dtpFinEmprunt.Enabled = False
            End Select
        Else
            cmbStatus.Enabled = False
            gbEmprunteur.Enabled = False
            dtpDebutEmprunt.Enabled = False
            dtpFinEmprunt.Enabled = False
        End If
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Rechercher()
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
        'Dim bs As BindingSource = New BindingSource()
        'bs.DataSource = dgvListBatiment.DataSource
        'bs.Filter = "Nom like '%" & txtRechercher.Text & "%'"
        'dgvListBatiment.DataSource = bs.DataSource
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
                dtSelBatiment.DefaultView.Sort = "Nom ASC"
                dtSelBatiment = dtSelBatiment.DefaultView.ToTable
                dgvSelBatiment.DataSource = dtSelBatiment

                dtListBatiment.Rows(intSelIndex).Delete()
                dtListBatiment.AcceptChanges()
                dtListBatiment.DefaultView.Sort = "Nom ASC"
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
                dtListBatiment.DefaultView.Sort = "Nom ASC"
                dtListBatiment = dtListBatiment.DefaultView.ToTable
                dgvListBatiment.DataSource = dtListBatiment

                dtSelBatiment.Rows(intSelIndex).Delete()
                dtSelBatiment.AcceptChanges()
                dtSelBatiment.DefaultView.Sort = "Nom ASC"
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

    Private Sub cmbTrousseauListe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrousseauListe.SelectedIndexChanged
        If cmbTrousseauListe.Text = "Aucun" Or cmbTrousseauListe.Text = "" Then
            cmbStatus.Enabled = True
            gbEmprunteur.Enabled = True
            dtpDebutEmprunt.Enabled = True
            dtpFinEmprunt.Enabled = True
            Select Case cmbStatus.SelectedIndex
                Case 0 'Disponible
                    gbEmprunteur.Enabled = False
                    dtpDebutEmprunt.Enabled = False
                    dtpFinEmprunt.Enabled = False
                Case 1 'Empruntée
                    gbEmprunteur.Enabled = True
                    dtpDebutEmprunt.Enabled = True
                    dtpFinEmprunt.Enabled = True
                Case 2 'Attribuée
                    gbEmprunteur.Enabled = True
                    dtpDebutEmprunt.Enabled = True
                    dtpFinEmprunt.Enabled = False
                Case 3 'Perdu
                    gbEmprunteur.Enabled = False
                    dtpDebutEmprunt.Enabled = False
                    dtpFinEmprunt.Enabled = False


            End Select
        Else
            cmbStatus.Enabled = False
            gbEmprunteur.Enabled = False
            dtpDebutEmprunt.Enabled = False
            dtpFinEmprunt.Enabled = False
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            Dim sql As String
            Try
                dt.Reset()
                sql = "SELECT DISTINCT TNom, TPersonne, CStatus, EDateDebut, EDateFin FROM Clefs, Trousseau, Emprunts WHERE TNom = '" & cmbTrousseauListe.Text & "' AND TNom = CTrousseau AND CID = EIDClef"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To (cmbNomEmprunteur.Items.Count - 1)
                        If cmbNomEmprunteur.GetItemText(cmbNomEmprunteur.Items(i)) = dt.Rows(0)("TPersonne").ToString() Then
                            cmbNomEmprunteur.SelectedIndex = i
                        End If
                    Next
                    For i As Integer = 0 To (cmbStatus.Items.Count - 1)
                        If cmbStatus.GetItemText(cmbStatus.Items(i)) = dt.Rows(0)("CStatus").ToString() Then
                            cmbStatus.SelectedIndex = i
                        End If
                    Next
                    Dim stgDateDebut As String = dt.Rows(0)("EDateDebut").ToString()
                    Dim stgDateFin As String = dt.Rows(0)("EDateFin").ToString()
                    Dim dtDateDebut As DateTime = DateTime.ParseExact(stgDateDebut, "dd/MM/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                    Dim dtDateFin As DateTime = DateTime.ParseExact(stgDateFin, "dd/MM/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                    dtpDebutEmprunt.Value = dtDateDebut
                    dtpFinEmprunt.Value = dtDateFin.Date
                End If
                connecter().Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnAddBatiment_Click(sender As Object, e As EventArgs) Handles btnAddBatiment.Click
        frmGestionBatiments.ShowDialog()
    End Sub

    Private Sub btnNewLoc_Click(sender As Object, e As EventArgs) Handles btnNewLoc.Click
        frmGestionPosition.ShowDialog()
    End Sub

    Private Sub pbRemSelBatiment_Click(sender As Object, e As EventArgs) Handles pbRemSelBatiment.Click
        removeFromSel()
    End Sub

    Private Sub pbAddSelBatiment_Click(sender As Object, e As EventArgs) Handles pbAddSelBatiment.Click
        addToSel()
    End Sub

    Private Sub pbAddPersonne_Click(sender As Object, e As EventArgs) Handles pbAddPersonne.Click
        frmGestionPersonnes.ShowDialog()
    End Sub
End Class