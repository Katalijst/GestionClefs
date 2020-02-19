Imports MySql.Data.MySqlClient
Public Class frmGestionPersonnes
    Private Sub frmAjouterPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblType.Text = strTitleNGenre & " :"
        lblNom.Text = strTitleNNom & " :"
        lblTelephone.Text = strTitleNTelephone & " :"
        lblAutre.Text = strTitleNAutre & " :"

        RefreshGenre()
        RefreshList()
        If userType <> "Administrateur" Then
            btnDelType.Enabled = False
            SupprimerToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub RefreshList()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtPersonnes As New DataTable
        Dim sql As String

        Try

            sql = "Select * From NomPersonne "

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtPersonnes)

            dtPersonnes.Columns("NNom").ColumnName = strTitleNNom
            dtPersonnes.Columns("NGenre").ColumnName = strTitleNGenre
            dtPersonnes.Columns("NTelephone").ColumnName = strTitleNTelephone
            dtPersonnes.Columns("NAutre").ColumnName = strTitleNAutre

            dgvListPersonne.DataSource = dtPersonnes
            dgvListPersonne.Columns(dgvListPersonne.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()


            Dim intIndexNom As Integer = dgvListPersonne.Columns("Nom").Index
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtRechercher.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dtPersonnes.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtRechercher.AutoCompleteCustomSource.Add(r.Item(intIndexNom).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshGenre()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Genre"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbType.DataSource = dt
            cmbType.ValueMember = "GGenre"
            cmbType.DisplayMember = "GGenre"
            If cmbType.Items.Count > 0 Then
                cmbType.SelectedIndex = 0
            End If
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        frmAjouterGenre.ShowDialog()
    End Sub

    Private Sub btnDelType_Click(sender As Object, e As EventArgs) Handles btnDelType.Click
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer le type """ & cmbType.Text & """ ?"
        Dim Caption As String = "Supprimer " & cmbType.Text
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
                sql = "DELETE FROM Genre WHERE GGenre=""" & cmbType.Text & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                connecter().Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            RefreshGenre()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim insert_command As New MySqlCommand("INSERT INTO
                                                              `NomPersonne`(
                                                                `NNom`,
                                                                `NGenre`,
                                                                `NTelephone`,
                                                                `NAutre`
                                                              )
                                                            VALUES
                                                              (
                                                                @name,
                                                                @genre,
                                                                @tel,
                                                                @autre
                                                              )
                                                            ", connecter())
            If txtNom.Text <> "" And mtxtTel.Text <> "" Then
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtNom.Text
                insert_command.Parameters.Add("@genre", MySqlDbType.VarChar).Value = cmbType.Text
                insert_command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = mtxtTel.Text
                insert_command.Parameters.Add("@autre", MySqlDbType.VarChar).Value = txtAutre.Text
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If


            insert_command.ExecuteNonQuery()
            connecter().Close()
            If frmAjouterClef.IsHandleCreated Then
                frmAjouterClef.RefreshNomEmprunteur()
            End If
            If frmGestionPosition.IsHandleCreated Then
                frmGestionPosition.RefreshResponsable()
            End If
            If frmEmprunterClef.IsHandleCreated Then
                frmEmprunterClef.LoadPersonnes()
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

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndexNom As Integer = dgvListPersonne.Columns("Nom").Index

        Try
            For i = 0 To dgvListPersonne.RowCount - 1
                If dgvListPersonne.Rows(i).Cells(intIndexNom).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListPersonne.Rows(i).Selected = True
                    dgvListPersonne.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub
    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListPersonne.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvListPersonne.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvListPersonne.PointToClient(Cursor.Position)
                ContextMenuStrip1.Show(dgvListPersonne, mousePosition)
            End If
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim intIndexNom As Integer = dgvListPersonne.Columns(strTitleNNom).Index
        Dim stgToDelete As String = dgvListPersonne.SelectedRows(0).Cells(intIndexNom).Value.ToString()
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
                sql = "DELETE FROM NomPersonne WHERE NNom=""" & stgToDelete & """"
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
        frmEditerPersonne.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class