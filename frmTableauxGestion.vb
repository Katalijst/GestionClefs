Imports MySql.Data.MySqlClient
Public Class frmTableauxGestion

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Public Sub RefreshList()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtPosition As New DataTable
        Dim sql As String

        Try

            sql = "Select * From Position WHERE PNom <> 'Aucun'"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtPosition)

            dtPosition.Columns("PNom").ColumnName = strTitlePNom
            dtPosition.Columns("PResponsable").ColumnName = strTitlePResponsable
            dtPosition.Columns("PBatiment").ColumnName = strTitlePBatiment

            dgvListTableau.DataSource = dtPosition

            'Dim intIndexNom As Integer = dgvListTableau.Columns("Nom").Index
            'Dim r As DataRow
            ''CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            'txtRechercher.AutoCompleteCustomSource.Clear()
            ''LOOPING THE ROW OF DATA IN THE DATATABLE
            'For Each r In dtPosition.Rows
            '    'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
            '    txtRechercher.AutoCompleteCustomSource.Add(r.Item(intIndexNom).ToString)
            'Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'For i = 0 To dgvListTableau.ColumnCount - 2
            '    dgvListTableau.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Next
            'dgvListTableau.Columns(dgvListTableau.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()
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
        Catch ex As MySqlException
            MsgBox(ex.Code & " - " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshBatiment(ByVal Optional selected As String = "Empty")
        Dim dtBatiments As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select BNom From Batiment where BNum <> '0' order by BNom ASC"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiments)

            Dim strCbBatiments As String() = New String(dtBatiments.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtBatiments.Rows
                strCbBatiments(i) = r.Item(0).ToString
                i += 1
            Next
            cbBatiments.DataSource = strCbBatiments
            If selected <> "Empty" Then
                cbBatiments.Text = selected
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Code & " - " & ex.Message)
        End Try
    End Sub

    Private Sub frmGestionPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        lblPNom.Text = strTitlePNom & " :"
        lblPBatiment.Text = strTitlePBatiment & " :"
        lblPResponsable.Text = strTitlePResponsable & " :"

        txtNom.Hint = strTitlePNom
        cbBatiments.Hint = strTitlePBatiment
        cbResponsable.Hint = strTitlePResponsable

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
        frmPersonnesGestion.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndexNom As Integer = dgvListTableau.Columns(strTitlePNom).Index

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
        frmTableauxEditer.ShowDialog()
    End Sub

    Private Sub SupprimerTableau()
        Dim TableauASupprimer As String = dgvListTableau.SelectedRows(0).Cells(strTitlePNom).Value.ToString
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer le tableau """ & TableauASupprimer & """ ?" & Environment.NewLine & "Cela retirera toutes les clefs du tableau sans les supprimer."
        Dim Caption As String = "Supprimer " & TableauASupprimer
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
            cmd.Parameters.Add("@Tableau", MySqlDbType.VarChar)
            Try
                sql = "UPDATE Clefs SET CPosition='Aucun' WHERE CPosition=@Tableau"
                With cmd
                    .Parameters("@Tableau").Value = TableauASupprimer
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                sql = "DELETE FROM Position WHERE PNom=@Tableau"
                With cmd
                    .Parameters("@Tableau").Value = TableauASupprimer
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
                connecter().Close()
                Exit Sub
            Finally
                connecter.close
                frmMain.FillDataSource()
            End Try
            RefreshList()
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        SupprimerTableau()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim stgBatNom As String = cbBatiments.Text
        Try
            Using insert_command As New MySqlCommand("INSERT INTO
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
                If txtNom.Text.Replace(" ", "") <> "" Then
                    insert_command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = txtNom.Text
                    insert_command.Parameters.Add("@responsable", MySqlDbType.VarChar).Value = cbResponsable.Text
                    insert_command.Parameters.Add("@batiment", MySqlDbType.VarChar).Value = stgBatNom
                Else
                    MsgBox("Veuillez remplir tout les champs !")
                    Exit Sub
                End If
                insert_command.ExecuteNonQuery()
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Un tableau existe déjà avec cette dénomination.", MsgBoxStyle.Critical, "Tableau existant")
            Else
                MsgBox(ex.Number & " - " & ex.Message)
            End If
            connecter().Close()
            Exit Sub
        Finally
            connecter().Close()
        End Try

        If frmClefsAjout.IsHandleCreated Then
            frmClefsAjout.RefreshTableau(txtNom.Text)
        End If
        If chkKeepOpen.Checked = False Then
            Me.Close()
        Else
            RefreshList()
        End If
    End Sub

    Private Sub frmGestionPosition_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class