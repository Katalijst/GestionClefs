Imports MySql.Data.MySqlClient
Public Class frmPersonnesGestion

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmAjouterPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        If frmClefsEmprunterEtAttribuer.IsHandleCreated Then
            If frmClefsEmprunterEtAttribuer.AjoutRechercherPersonne = 1 Then
                MaterialTabControl1.SelectedTab = tabAjouter
            ElseIf frmClefsEmprunterEtAttribuer.AjoutRechercherPersonne = 2 Then
                MaterialTabControl1.SelectedTab = tabRechercher
            End If
        End If
        RefreshFonction()
        RefreshList()
        If GlobalUserType <> "Administrateur" Then
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

    Public Sub RefreshFonction(ByVal Optional name As String = "Empty")
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

            Dim strCmbType(dt.Rows.Count) As String
            Dim index As Integer = 0
            For Each r As DataRow In dt.Rows
                strCmbType(index) = r.Item(0)
                index += 1
            Next
            cbFonction.DataSource = strCmbType

            If name <> "Empty" Then
                cbFonction.Text = name
            End If

            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.ErrorCode & " - " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        frmFonctionAjout.ShowDialog()
    End Sub

    Private Sub btnDelType_Click(sender As Object, e As EventArgs) Handles btnDelType.Click
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer le type """ & cbFonction.Text & """ ?"
        Dim Caption As String = "Supprimer " & cbFonction.Text
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
                sql = "DELETE FROM Genre WHERE GGenre=""" & cbFonction.Text & """"
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
            RefreshFonction()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbFonction.SelectedIndex <> -1 And txtNom.Text.Replace(" ", "") <> "" Then
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
                If txtNom.Text.Replace(" ", "") <> "" And mtxtTel.Text.Replace(" ", "") <> "" Then
                    insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtNom.Text
                    insert_command.Parameters.Add("@genre", MySqlDbType.VarChar).Value = cbFonction.Text
                    insert_command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = mtxtTel.Text
                    insert_command.Parameters.Add("@autre", MySqlDbType.VarChar).Value = txtAutre.Text
                    insert_command.ExecuteNonQuery()
                Else
                    MsgBox("Veuillez remplir tout les champs !", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MsgBox("Une personne existe déjà avec ce nom.", MsgBoxStyle.Critical, "Personne existante")
                Else
                    MsgBox(ex.Number & " - " & ex.Message)
                End If
                connecter().Close()
                Exit Sub
            Finally
                connecter().Close()
            End Try

            If frmTableauxGestion.IsHandleCreated Then
                frmTableauxGestion.RefreshResponsable(txtNom.Text)
            End If
            If frmTableauxEditer.IsHandleCreated Then
                frmTableauxEditer.RefreshResponsable(txtNom.Text)
            End If
            If frmClefsEmprunterEtAttribuer.IsHandleCreated Then
                frmClefsEmprunterEtAttribuer.LoadPersonnes(txtNom.Text)
            End If

            If chkKeepOpen.Checked = False Then
                Me.Close()
            Else
                RefreshList()
            End If

        Else
            MsgBox("Attention", MessageBoxButtons.OK, "Vous devez entrer le nom de la personne ainsi que sa fonction.")
        End If
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
                If frmTableauxGestion.IsHandleCreated Then
                    frmTableauxGestion.RefreshResponsable()
                End If
                If frmClefsEmprunterEtAttribuer.IsHandleCreated Then
                    frmClefsEmprunterEtAttribuer.LoadPersonnes()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        frmPersonnesEditer.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub mtxtTel_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles mtxtTel.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvListPersonne_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListPersonne.CellDoubleClick
        If frmClefsEmprunterEtAttribuer.IsHandleCreated Then
            frmClefsEmprunterEtAttribuer.cbPersonnes.Text = dgvListPersonne.SelectedRows(0).Cells(strTitlePNom).Value
            Me.Close()
        End If
        If frmTableauxGestion.IsHandleCreated Then
            frmTableauxGestion.cbResponsable.Text = dgvListPersonne.SelectedRows(0).Cells(strTitlePNom).Value
        End If
    End Sub

    Private Sub frmPersonnesGestion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class