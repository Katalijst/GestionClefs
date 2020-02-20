Imports MySql.Data.MySqlClient

Public Class frmGestionTrousseau
    Public Sub RefreshTrousseau()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select TNom from Trousseau"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

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

    Private Sub frmAjoutTrousseau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilldgvListClef()
        RefreshTrousseau()
        FilldgvSelClefs()

    End Sub
    Public Sub FilldgvListClef()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtKeyList As New DataTable
        Dim sql As String

        Try

            sql = "Select CID, CNom, CPosition, CBatiment From Clefs Where CTrousseau='Aucun' order by CNom ASC"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyList)

            dtKeyList.Columns("CID").ColumnName = strTitleCID
            dtKeyList.Columns("CNom").ColumnName = strTitleCNom
            dtKeyList.Columns("CPosition").ColumnName = strTitleCPosition
            dtKeyList.Columns("CStatus").ColumnName = strTitleCStatus
            dtKeyList.Columns("CTrousseau").ColumnName = strTitleCTrousseau
            dtKeyList.Columns("CBatiment").ColumnName = strTitleCBatiment

            dgvListClefs.DataSource = dtKeyList
            dgvListClefs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListClefs.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each column In dgvListClefs.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            connecter().Close()

            If dgvSelTrousseau.Rows.Count = 0 Then
                FilldgvSelClefs()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FilldgvSelClefs()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtKeyList As New DataTable
        Dim sql As String

        gbTrousseau.Text = cmbTrousseauListe.Text
        lblTrousseauAfficher.Text = "Trousseau afficher : " & cmbTrousseauListe.Text

        Try

            sql = "Select CID, CNom, CPosition, CBatiment From Clefs Where CTrousseau='" & cmbTrousseauListe.Text & "'"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyList)

            dtKeyList.Columns("CID").ColumnName = strTitleCID
            dtKeyList.Columns("CNom").ColumnName = strTitleCNom
            dtKeyList.Columns("CPosition").ColumnName = strTitleCPosition
            dtKeyList.Columns("CStatus").ColumnName = strTitleCStatus
            dtKeyList.Columns("CTrousseau").ColumnName = strTitleCTrousseau
            dtKeyList.Columns("CBatiment").ColumnName = strTitleCBatiment

            dgvSelTrousseau.DataSource = dtKeyList
            dgvSelTrousseau.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvSelTrousseau.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each column In dgvSelTrousseau.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCreerTrousseau_Click(sender As Object, e As EventArgs) Handles btnCreerTrousseau.Click
        frmCreerTrousseau.Show()
    End Sub

    Private Sub btnSupprimerTrousseau_Click(sender As Object, e As EventArgs) Handles btnSupprimerTrousseau.Click
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer le trousseau """ & cmbTrousseauListe.Text & """ ?"
        Dim Caption As String = "Supprimer " & cmbTrousseauListe.Text
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

        Dim Result As DialogResult

        'Displays the MessageBox
        Result = MessageBox.Show(Message, Caption, Buttons, Icon)

        ' Gets the result of the MessageBox display.
        If Result = System.Windows.Forms.DialogResult.Yes Then

            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            Dim sql As String

            Try
                sql = "UPDATE Clefs SET CTrousseau='Aucun' WHERE CTrousseau='" & cmbTrousseauListe.Text & "'"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                sql = "DELETE FROM Trousseau WHERE TNom=""" & cmbTrousseauListe.Text & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd

                da.Fill(dt)
                cmbTrousseauListe.DataSource = dt
                cmbTrousseauListe.ValueMember = "TNom"
                cmbTrousseauListe.DisplayMember = "TNom"

                connecter().Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            RefreshTrousseau()
        End If
    End Sub
    Private Sub addToSel()
        If dgvListClefs.SelectedRows.Count > 0 Then
            For Each selRow As DataGridViewRow In dgvListClefs.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                Dim dt2 As New DataTable
                Dim gv2r As DataRow = dt2.newrow()
                'A finir ! Optimisation pour l'envois entre deux dgv

                Dim intSelIndex As Integer = selRow.Index
                Dim dtListClef As DataTable = CType(dgvListClefs.DataSource, DataTable)
                Dim dtSelClef As DataTable = CType(dgvSelTrousseau.DataSource, DataTable)
                Dim drToAdd As DataRow = dtListClef.Rows(intSelIndex)
                dtSelClef.ImportRow(drToAdd)
                dtSelClef.AcceptChanges()
                dtSelClef.DefaultView.Sort = strTitleBNom & " ASC"
                dtSelClef = dtSelClef.DefaultView.ToTable
                dgvSelTrousseau.DataSource = dtSelClef

                dtListClef.Rows(intSelIndex).Delete()
                dtListClef.AcceptChanges()
                dtListClef.DefaultView.Sort = strTitleBNom & " ASC"
                dtListClef = dtListClef.DefaultView.ToTable
                dgvListClefs.DataSource = dtListClef
            Next
        End If
    End Sub

    Private Sub removeFromSel()
        If dgvSelTrousseau.SelectedRows.Count > 0 Then
            For Each selRow As DataGridViewRow In dgvSelTrousseau.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                Dim intSelIndex As Integer = selRow.Index
                Dim dtListClef As DataTable = CType(dgvListClefs.DataSource, DataTable)
                Dim dtSelClef As DataTable = CType(dgvSelTrousseau.DataSource, DataTable)
                Dim drToAdd As DataRow = dtSelClef.Rows(intSelIndex)
                dtListClef.ImportRow(drToAdd)
                dtListClef.AcceptChanges()
                dtListClef.DefaultView.Sort = strTitleBNom & " ASC"
                dtListClef = dtListClef.DefaultView.ToTable
                dgvListClefs.DataSource = dtListClef

                dtSelClef.Rows(intSelIndex).Delete()
                dtSelClef.AcceptChanges()
                dtSelClef.DefaultView.Sort = strTitleBNom & " ASC"
                dtSelClef = dtSelClef.DefaultView.ToTable
                dgvSelTrousseau.DataSource = dtSelClef
            Next
        End If
    End Sub

    Private Sub dgvListBatiment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListClefs.CellDoubleClick
        addToSel()
    End Sub
    Private Sub dgvSelBatiment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelTrousseau.CellDoubleClick
        removeFromSel()
    End Sub

    Public Sub Rechercher()
        Dim searchValue As String = txtRechercher.Text

        Try
            For i = 0 To dgvListClefs.RowCount - 1
                If dgvListClefs.Rows(i).Cells(1).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListClefs.Rows(i).Selected = True
                    dgvListClefs.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Rechercher()
    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        FilldgvSelClefs()
    End Sub

    Private Sub cmbTrousseauListe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrousseauListe.SelectedIndexChanged
        FilldgvSelClefs()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dtSelTrousseau As DataTable = CType(dgvSelTrousseau.DataSource, DataTable)
        Dim dtListClefs As DataTable = CType(dgvListClefs.DataSource, DataTable)

        If dtSelTrousseau.Rows.Count > 0 Then
            For Each r In dtSelTrousseau.Rows
                Dim stgKeyFromTrousseau As String = r.item(strTitleCID).ToString
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter
                Dim sql As String = "Update Clefs Set CTrousseau='" & gbTrousseau.Text & "' Where CID='" & stgKeyFromTrousseau & "'"

                Try
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    connecter().Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
        If dtListClefs.Rows.Count > 0 Then
            For Each r In dtListClefs.Rows
                Dim stgKeyFromTrousseau As String = r.item(strTitleCID).ToString
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter
                Dim sql As String = "Update Clefs Set CTrousseau='Aucun' Where CID='" & stgKeyFromTrousseau & "'"

                Try
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    connecter().Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
        If chkKeepOpen.Checked = False Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub pbAddSelBatiment_Click(sender As Object, e As EventArgs) Handles pbAddSelBatiment.Click
        addToSel()
    End Sub

    Private Sub pbRemSelBatiment_Click(sender As Object, e As EventArgs) Handles pbRemSelBatiment.Click
        removeFromSel()
    End Sub
End Class