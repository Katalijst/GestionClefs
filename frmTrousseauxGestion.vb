Imports MySql.Data.MySqlClient

Public Class frmTrousseauxGestion

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmAjoutTrousseau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        RefreshTrousseau()
    End Sub

    Public Sub RefreshTrousseau(ByVal Optional selected As String = "Empty")
        Dim dtTrousseaux As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select TNom From Trousseau where TNom <> 'Aucun' order by TNom ASC"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtTrousseaux)

            Dim srcTrousseaux As String() = New String(dtTrousseaux.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtTrousseaux.Rows
                srcTrousseaux(i) = r.Item(0).ToString
                i += 1
            Next
            cbTrousseaux.DataSource = srcTrousseaux
            If selected <> "Empty" Then
                cbTrousseaux.Text = selected
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Code & " - " & ex.Message)
        End Try

    End Sub

    Private Sub cbTrousseaux_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrousseaux.SelectedIndexChanged
        RefreshTrousseauContent()
    End Sub

    Private Sub RetirerDuTrousseauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetirerDuTrousseauToolStripMenuItem.Click
        RetirerClef()
    End Sub

    Private Sub RefreshTrousseauContent()
        If cbTrousseaux.SelectedIndex <> -1 Then
            Dim dtTrousseaux As New DataTable
            Dim cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter
            Dim CmdSql As String = "Select CID, CNom, CPosition, CStatus, CBatiment From Clefs where CTrousseau = @Trousseau"
            cmd.Parameters.Add("@Trousseau", MySqlDbType.String)
            Try
                With cmd
                    .Parameters("@Trousseau").Value = cbTrousseaux.Text
                    .Connection = connecter()
                    .CommandText = CmdSql
                End With
                da.SelectCommand = cmd
                da.Fill(dtTrousseaux)

                dtTrousseaux.Columns("CID").ColumnName = strTitleCID
                dtTrousseaux.Columns("CNom").ColumnName = strTitleCNom
                dtTrousseaux.Columns("CPosition").ColumnName = strTitleCPosition
                dtTrousseaux.Columns("CStatus").ColumnName = strTitleCStatus
                dtTrousseaux.Columns("CBatiment").ColumnName = strTitleCBatiment

                For Each r As DataRow In dtTrousseaux.Rows
                    Dim input As String = r.Item(0)
                    Dim index As Integer = input.LastIndexOf("-")
                    If index > 0 Then
                        r.Item(0) = input.Substring(0, index)
                    End If
                Next

                dgvClefs.DataSource = dtTrousseaux

                connecter().Close()
            Catch ex As MySqlException
                MsgBox(ex.Code & " - " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RetirerClef()
        If dgvClefs.SelectedRows.Count > 0 Then
            'Pop-up (message box):
            ' Initializes variables to pass to the MessageBox.Show method.
            Dim Message As String
            Dim Caption As String
            If dgvClefs.SelectedRows.Count > 1 Then
                Message = "Voulez vous vraiment retirer les " & dgvClefs.SelectedRows.Count & " clefs sélectionnées du trousseau " & cbTrousseaux.Text & " ?"
                Caption = "Supprimer des clefs"
            Else
                Message = "Voulez vous vraiment retirer la clef sélectionnée du trousseau " & cbTrousseaux.Text & " ?"
                Caption = "Supprimer une clef"
            End If
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

            Dim Result As DialogResult

            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)

            ' Gets the result of the MessageBox display.
            'Si l'utilisateur répond oui
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateClef As New MySqlCommand
                cmdUpdateClef.CommandType = CommandType.Text
                With cmdUpdateClef
                    .Parameters.Add("@IDClef", MySqlDbType.String)
                    .Parameters.Add("@Nom", MySqlDbType.VarChar)
                    .Parameters.Add("@Tableau", MySqlDbType.VarChar)
                    .Parameters.Add("@Status", MySqlDbType.VarChar)
                    .Parameters.Add("@Trousseau", MySqlDbType.VarChar)
                    .Parameters.Add("@OldTrousseauxClef", MySqlDbType.VarChar)
                End With
                Try
                    For Each selRow As DataGridViewRow In dgvClefs.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                        With cmdUpdateClef
                            .Parameters("@IDClef").Value = selRow.Cells(0).Value & "-%"
                            .Parameters("@Nom").Value = selRow.Cells(1).Value
                            .Parameters("@Tableau").Value = selRow.Cells(2).Value
                            .Parameters("@Status").Value = selRow.Cells(3).Value
                            .Parameters("@Trousseau").Value = "Aucun"
                            .Parameters("@OldTrousseauxClef").Value = cbTrousseaux.Text
                            .Connection = connecter()
                            .CommandText = "UPDATE Clefs SET CTrousseau=@Trousseau WHERE CID=(SELECT * FROM (SELECT CID FROM Clefs where CNom=@Nom AND CStatus=@Status AND CPosition=@Tableau AND CTrousseau=@OldTrousseauxClef AND CID LIKE @IDClef LIMIT 1) TempTable);"
                            .ExecuteNonQuery()
                        End With
                    Next
                Catch ex As MySqlException
                    MsgBox(ex.ErrorCode & " - " & ex.Message)
                End Try
                frmMain.FillDataSource()
                RefreshTrousseauContent()
            End If
        End If
    End Sub

    Private Sub btnDeleteTrousseau_Click(sender As Object, e As EventArgs) Handles btnDeleteTrousseau.Click
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer le trousseau """ & cbTrousseaux.Text & """ ?"
        Dim Caption As String = "Supprimer " & cbTrousseaux.Text
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
            cmd.Parameters.Add("@Trousseau", MySqlDbType.VarChar)
            Try
                sql = "UPDATE Clefs SET CTrousseau='Aucun' WHERE CTrousseau=@Trousseau"
                With cmd
                    .Parameters("@Trousseau").Value = cbTrousseaux.Text
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                sql = "DELETE FROM Trousseau WHERE TNom=@Trousseau"
                With cmd
                    .Parameters("@Trousseau").Value = cbTrousseaux.Text
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                connecter().Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            RefreshTrousseau()
            frmMain.FillDataSource()
            RefreshTrousseauContent()
        End If
    End Sub

    Private Sub btnCreerTrousseau_Click(sender As Object, e As EventArgs) Handles btnCreerTrousseau.Click
        frmTrousseauxAjout.ShowDialog()
    End Sub

    Private Sub btnRetirerClefsTrousseau_Click(sender As Object, e As EventArgs) Handles btnRetirerClefsTrousseau.Click
        RetirerClef()
    End Sub

    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvClefs.CellMouseDown
        '--- Evenement de clic droit sur la DataGridView ---
        'Vérification si le clic a été fait sur une cellule
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            'Vérification du type de clic
            If e.Button = MouseButtons.Right Then
                'Selection d'un row si se n'est pas déjà fait
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvClefs.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                'récupération de la position du clic
                Dim mousePosition = dgvClefs.PointToClient(Cursor.Position)
                'affichage du menu pour editer, supprimer...
                ContextMenuStrip1.Show(dgvClefs, mousePosition)
            End If
        End If
    End Sub

End Class