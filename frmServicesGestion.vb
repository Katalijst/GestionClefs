Imports MySql.Data.MySqlClient

Public Class frmServicesGestion
    Dim hasModificationBeenDone As Boolean = False
    Dim indexServices As Integer = -1
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmServicesGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        LoadTableaux()
        LoadServices()
    End Sub

    Private Sub frmServicesGestion_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub


    Public Sub Rechercher()
        Dim searchValue As String = txtRechercher.Text

        Try
            For i = 0 To dgvListTableaux.RowCount - 1
                If dgvListTableaux.Rows(i).Cells(0).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListTableaux.Rows(i).Selected = True
                    dgvListTableaux.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Public Sub LoadTableaux(ByVal Optional Services As String = "")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtTableaux As New DataTable
        Dim dtSelTableaux As New DataTable

        Dim sql As String

        Try
            sql = "SELECT Pnom FROM Position WHERE PNom NOT IN (SELECT STableau FROM Services WHERE SNom=@Services) AND PNom <> 'Aucun'"
            With cmd
                .Parameters.Add("@Services", MySqlDbType.VarChar).Value = Services
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtTableaux)
            dtTableaux.Columns("PNom").ColumnName = strTitlePNom
            dgvListTableaux.DataSource = dtTableaux

            sql = "SELECT STableau FROM Services WHERE SNom=@Services AND STableau <> 'Aucun'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtSelTableaux)
            If dtSelTableaux.Rows.Count > 0 Then
                dtSelTableaux.Columns("STableau").ColumnName = strTitlePNom
            Else
                dtSelTableaux = dtTableaux.Copy
                dtSelTableaux.Rows.Clear()
            End If
            dgvSelTableaux.DataSource = dtSelTableaux

            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            connecter().Close()
        End Try
    End Sub

    Public Sub LoadServices(ByVal Optional name As String = "Empty")
        cbServices.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select DISTINCT SNom from Services where SNom <> 'Global'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                cbServices.Items.Add(r.Item(0).ToString)
            Next
            If name <> "Empty" Then
                cbServices.Text = name
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            connecter().Close()
        End Try
    End Sub

    Private Sub addToSel()
        If cbServices.SelectedIndex <> -1 Then
            If dgvListTableaux.SelectedRows.Count > 0 Then
                hasModificationBeenDone = True
                For Each selRow As DataGridViewRow In dgvListTableaux.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                    Dim intSelIndex As Integer = selRow.Index
                    Dim dtListBatiment As DataTable = CType(dgvListTableaux.DataSource, DataTable)
                    Dim dtSelBatiment As DataTable = CType(dgvSelTableaux.DataSource, DataTable)
                    Dim drToAdd As DataRow = dtListBatiment.Rows(intSelIndex)
                    dtSelBatiment.ImportRow(drToAdd)
                    dtSelBatiment.AcceptChanges()
                    dtSelBatiment.DefaultView.Sort = strTitlePNom & " ASC"
                    dtSelBatiment = dtSelBatiment.DefaultView.ToTable
                    dgvSelTableaux.DataSource = dtSelBatiment

                    dtListBatiment.Rows(intSelIndex).Delete()
                    dtListBatiment.AcceptChanges()
                    dtListBatiment.DefaultView.Sort = strTitlePNom & " ASC"
                    dtListBatiment = dtListBatiment.DefaultView.ToTable
                    dgvListTableaux.DataSource = dtListBatiment
                Next
            End If
        End If
    End Sub

    Private Sub removeFromSel()
        If cbServices.SelectedIndex <> -1 Then
            If dgvSelTableaux.SelectedRows.Count > 0 Then
                hasModificationBeenDone = True
                For Each selRow As DataGridViewRow In dgvSelTableaux.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                    Dim intSelIndex As Integer = selRow.Index
                    Dim dtListBatiment As DataTable = CType(dgvListTableaux.DataSource, DataTable)
                    Dim dtSelBatiment As DataTable = CType(dgvSelTableaux.DataSource, DataTable)
                    Dim drToAdd As DataRow = dtSelBatiment.Rows(intSelIndex)
                    dtListBatiment.ImportRow(drToAdd)
                    dtListBatiment.AcceptChanges()
                    dtListBatiment.DefaultView.Sort = strTitlePNom & " ASC"
                    dtListBatiment = dtListBatiment.DefaultView.ToTable
                    dgvListTableaux.DataSource = dtListBatiment

                    dtSelBatiment.Rows(intSelIndex).Delete()
                    dtSelBatiment.AcceptChanges()
                    dtSelBatiment.DefaultView.Sort = strTitlePNom & " ASC"
                    dtSelBatiment = dtSelBatiment.DefaultView.ToTable
                    dgvSelTableaux.DataSource = dtSelBatiment
                Next
            End If
        End If
    End Sub

    Private Sub SaveChanges()
        Dim cmdDelete As New MySqlCommand
        Dim cmdInsert As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "DELETE FROM Services WHERE SNom=@Service"
            With cmdDelete
                .Parameters.Add("@Service", MySqlDbType.VarChar).Value = cbServices.Text
                .Connection = connecter()
                .CommandText = sql
                .CommandType = CommandType.Text
                .Connection = connecter()
                .ExecuteNonQuery()
            End With

            sql = "INSERT INTO Services(SNom, STableau) VALUES (@Service,@Tableau);"
            With cmdInsert
                .Parameters.Add("@Service", MySqlDbType.VarChar)
                .Parameters.Add("@Tableau", MySqlDbType.VarChar)
            End With

            For Each r As DataGridViewRow In dgvSelTableaux.Rows
                With cmdInsert
                    .Parameters("@Service").Value = cbServices.Text
                    .Parameters("@Tableau").Value = r.Cells(0).Value
                    .CommandText = sql
                    .CommandType = CommandType.Text
                    .Connection = connecter()
                    .ExecuteNonQuery()
                End With
            Next
            connecter.close
            MsgBox("Changements effectuer avec succès.", MsgBoxStyle.OkOnly, "Succès !")
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            connecter().Close()
        Finally
            hasModificationBeenDone = False
        End Try

    End Sub

    Private Sub SupprimerService()
        If cbServices.SelectedIndex > -1 Then
            ' Initializes variables to pass to the MessageBox.Show method.
            Dim Message As String = "Voulez vous vraiment supprimer le service " & cbServices.Text & " ?"
            Dim Caption As String = "Supprimer un service"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning
            Dim Result As DialogResult
            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)
            ' Gets the result of the MessageBox display.
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Dim cmdDelete As New MySqlCommand
                Dim cmdInsert As New MySqlCommand
                Dim da As New MySqlDataAdapter
                Dim sql As String

                Try
                    sql = "DELETE FROM Services WHERE SNom=@Service"
                    With cmdDelete
                        .Parameters.Add("@Service", MySqlDbType.VarChar).Value = cbServices.Text
                        .Connection = connecter()
                        .CommandText = sql
                        .CommandType = CommandType.Text
                        .Connection = connecter()
                        .ExecuteNonQuery()
                    End With
                    connecter.close
                Catch ex As MySqlException
                    MsgBox(ex.Number & " - " & ex.Message)
                    connecter().Close()
                Finally
                    hasModificationBeenDone = False
                    LoadServices()
                End Try
            End If
        End If
    End Sub

    Private Sub cbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServices.SelectedIndexChanged
        If cbServices.SelectedIndex <> indexServices Then
            If hasModificationBeenDone = True Then
                ' Initializes variables to pass to the MessageBox.Show method.
                Dim Message As String = "Des modification ont été faites, si vous changer de services vous les perdrez." & Environment.NewLine & "Voulez vous quand même changer de services ?"
                Dim Caption As String = "Attention !"
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning
                Dim Result As DialogResult
                'Displays the MessageBox
                Result = MessageBox.Show(Message, Caption, Buttons, Icon)
                ' Gets the result of the MessageBox display.
                If Result = System.Windows.Forms.DialogResult.No Then
                    cbServices.SelectedIndex = indexServices
                    Exit Sub
                Else
                    hasModificationBeenDone = False
                End If
            End If
            indexServices = cbServices.SelectedIndex
            If cbServices.Text <> "" Then
                LoadTableaux(cbServices.Text)
            End If
        End If
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Rechercher()
    End Sub

    Private Sub btnAddSelTableaux_Click(sender As Object, e As EventArgs) Handles btnAddSelTableaux.Click
        addToSel()
    End Sub

    Private Sub btnRemSelTableaux_Click(sender As Object, e As EventArgs) Handles btnRemSelTableaux.Click
        removeFromSel()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveChanges()
    End Sub

    Private Sub dgvListTableaux_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListTableaux.CellDoubleClick
        addToSel()
    End Sub

    Private Sub dgvSelTableaux_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelTableaux.CellDoubleClick
        removeFromSel()
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        frmServicesAjouter.ShowDialog()
    End Sub

    Private Sub btnSupprimerService_Click(sender As Object, e As EventArgs) Handles btnSupprimerService.Click
        SupprimerService()
    End Sub
End Class