Imports MySql.Data.MySqlClient
Public Class frmGestionPosition
    Public Sub RefreshList()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtPosition As New DataTable
        Dim sql As String

        Try

            sql = "Select * From Position "

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtPosition)

            For i As Integer = 0 To dtPosition.Columns.Count - 1
                dtPosition.Columns(i).ColumnName = dtPosition.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            dgvListTableau.DataSource = dtPosition

            For i = 0 To dgvListTableau.ColumnCount - 2
                dgvListTableau.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            dgvListTableau.Columns(dgvListTableau.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()

            Dim intIndexNom As Integer = dgvListTableau.Columns("Nom").Index
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtRechercher.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dtPosition.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtRechercher.AutoCompleteCustomSource.Add(r.Item(intIndexNom).ToString)
            Next
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
    Private Sub frmGestionPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshList()
        RefreshResponsable()
        RefreshBatiment()
    End Sub
    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListTableau.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvListTableau.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvListTableau.PointToClient(Cursor.Position)
                ContextMenuStrip1.Show(dgvListTableau, mousePosition)
            End If
        End If
    End Sub

    Private Sub btnAddPersonne_Click(sender As Object, e As EventArgs) Handles btnAddPersonne.Click
        frmGestionPersonnes.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndexNom As Integer = dgvListTableau.Columns("Nom").Index

        Try
            For i = 0 To dgvListTableau.RowCount - 1
                If dgvListTableau.Rows(i).Cells(intIndexNom).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListTableau.Rows(i).Selected = True
                    dgvListTableau.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub EditerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        frmEditerPosition.ShowDialog()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim intIndexNom As Integer = dgvListTableau.Columns("Nom").Index
        Dim stgToDelete As String = dgvListTableau.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer """ & stgToDelete & """ ?"
        Dim Caption As String = "Supprimer " & stgToDelete
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
                sql = "DELETE FROM Position WHERE PNom=""" & stgToDelete & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                connecter().Close()
                RefreshList()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim intIndexNom As Integer = dgvListBatiment.Columns("Nom").Index
            Dim stgBatNom As String = dgvListBatiment.SelectedRows(0).Cells(intIndexNom).Value.ToString()

            Dim insert_command As New MySqlCommand("INSERT INTO
                                                              `Position`(
                                                                `PNom`,
                                                                `PResponsable`,
                                                                `PBatiment`
                                                              )
                                                            VALUES
                                                              (
                                                                @nom,
                                                                @responsable,
                                                                @batiment
                                                              )
                                                            ", connecter())
            If txtNom.Text <> "" Then
                insert_command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = txtNom.Text
                insert_command.Parameters.Add("@responsable", MySqlDbType.VarChar).Value = cmbResponsable.Text
                insert_command.Parameters.Add("@batiment", MySqlDbType.VarChar).Value = stgBatNom
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If

            insert_command.ExecuteNonQuery()
            connecter().Close()
            If frmAjouterClef.IsHandleCreated Then
                frmAjouterClef.RefreshPosition()
            End If
            If chkKeepOpen.Checked = False Then
                Me.Close()
            Else
                RefreshList()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class