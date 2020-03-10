Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmBatimentsAjoutGestion

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmGestionBatiments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        lblID.Text = strTitleBNum & " :"
        txtID.Hint = strTitleBNum
        lblAdresse.Text = strTitleBAdresse & " :"
        txtAdresse.Hint = strTitleBAdresse
        lblFonction.Text = strTitleBFonction & " :"
        txtFonction.Hint = strTitleBFonction
        lblNom.Text = strTitleBNom & " :"
        txtNom.Hint = strTitleBNom

        RefreshList()
    End Sub
    Public Sub RefreshList()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtBatiments As New DataTable
        Dim sql As String

        Try

            sql = "Select * From Batiment where BNum <> '0' order by BNom ASC"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiments)

            dtBatiments.Columns("BNum").ColumnName = strTitleBNum
            dtBatiments.Columns("BNom").ColumnName = strTitleBNom
            dtBatiments.Columns("BAdresse").ColumnName = strTitleBAdresse
            dtBatiments.Columns("BFonction").ColumnName = strTitleBFonction

            dgvListBatiment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dgvListBatiment.RowHeadersVisible = False
            dgvListBatiment.DataSource = dtBatiments

            For i = 0 To dgvListBatiment.ColumnCount - 2
                dgvListBatiment.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            dgvListBatiment.Columns(dgvListBatiment.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()

            'Dim r As DataRow
            ''CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            'txtRechercher.AutoCompleteCustomSource.Clear()
            ''LOOPING THE ROW OF DATA IN THE DATATABLE
            'Dim intIndexNomBat As Integer = dgvListBatiment.Columns(strTitleBNom).Index
            'For Each r In dtBatiments.Rows
            '    'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
            '    txtRechercher.AutoCompleteCustomSource.Add(r.Item(intIndexNomBat).ToString)
            'Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddResponsable_Click(sender As Object, e As EventArgs)
        frmPersonnesGestion.ShowDialog()
    End Sub
    Private Sub dgvListBatiment_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListBatiment.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvListBatiment.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvListBatiment.PointToClient(Cursor.Position)
                ContextMenuStrip1.Show(dgvListBatiment, mousePosition)
            End If
        End If
    End Sub
    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndexNomBat As Integer = dgvListBatiment.Columns(strTitleBNom).Index

        Try
            For i = 0 To dgvListBatiment.RowCount - 1
                If dgvListBatiment.Rows(i).Cells(intIndexNomBat).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListBatiment.Rows(i).Selected = True
                    dgvListBatiment.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim stgToDelete As String = dgvListBatiment.SelectedRows(0).Cells(strTitleBNum).Value.ToString()
        Dim stgNameToDelete As String = dgvListBatiment.SelectedRows(0).Cells(strTitleBNom).Value.ToString()
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer """ & stgNameToDelete & """ ?"
        Dim Caption As String = "Supprimer " & stgNameToDelete
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
                sql = "DELETE FROM Batiment WHERE BNum=""" & stgToDelete & """"
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

    Private Sub EditerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        frmBatimentsEditer.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim insert_command As New MySqlCommand("INSERT INTO
                                                              `Batiment`(
                                                                `BNum`,
                                                                `BNom`,
                                                                `BAdresse`,
                                                                `BFonction`
                                                              )
                                                            VALUES
                                                              (
                                                                @numero,
                                                                @nom,
                                                                @adresse,
                                                                @fonction
                                                              )
                                                            ", connecter())
            If txtID.Text <> "" And txtNom.Text <> "" And txtAdresse.Text <> "" And txtFonction.Text <> "" Then
                insert_command.Parameters.Add("@numero", MySqlDbType.VarChar).Value = txtID.Text
                insert_command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = txtNom.Text
                insert_command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = txtAdresse.Text
                insert_command.Parameters.Add("@fonction", MySqlDbType.VarChar).Value = txtFonction.Text
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If

            insert_command.ExecuteNonQuery()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Un batiment existe déjà avec cette dénomination ou ce numéro.", MsgBoxStyle.Critical, "Le batiment existe déjà !")
            Else
                MsgBox(ex.Number & " - " & ex.Message)
                Exit Sub
            End If
        Finally
            connecter().Close()
            If frmClefsAjout.IsHandleCreated Then
                frmClefsAjout.RefreshBatiment()
            End If
            If chkKeepOpen.Checked = False Then
                Me.Close()
            Else
                RefreshList()
            End If
        End Try
    End Sub

    Private Sub dgvListBatiment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBatiment.CellDoubleClick
        frmMain.cbRechercher.SelectedIndex = 5
        frmMain.txtRechercher.Text = dgvListBatiment.SelectedRows(0).Cells(strTitleBNom).Value
        Me.Close()
    End Sub

    Private Sub frmBatimentsAjoutGestion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class