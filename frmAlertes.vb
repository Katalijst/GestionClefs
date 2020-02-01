Imports MySql.Data.MySqlClient

Public Class frmAlertes
    Private Sub frmAlertes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchAndRefresh()
        cbRechercher.SelectedIndex = 1
        chkAlertPopUp.Checked = My.Settings.ShowAlert
    End Sub

    Private Sub frmAlertes_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        frmMain.CheckAlerts()
        My.Settings.ShowAlert = chkAlertPopUp.Checked
        My.Settings.Save()
    End Sub

    Public Sub SearchAndRefresh()
        Dim dateNow As Date = Now

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim dtAlertes As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String = "Select EIDClef, EDateFin From Emprunts Where EDateFin IS NOT NULL"
        Try
            dt.Reset()
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            lblAlertes.Text = "Aucune alerte."
            If dt.Rows.Count > 0 Then
                lblAlertes.Text = dt.Rows.Count & " clefs non rendues !"
                dtAlertes.Reset()
                For i = 0 To dt.Rows.Count - 1
                    sql = "Select EIDClef, CNom, EIDGenre, ENomPersonne, EDateDebut, EDateFin From Emprunts, Clefs Where EIDClef='" & dt.Rows(i)(0).ToString & "' AND CID=EIDClef"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                    End With
                    da.SelectCommand = cmd
                    Dim dtTemp As New DataTable
                    da.Fill(dtTemp)
                    For Each dr As DataRow In dtTemp.Rows
                        If dtAlertes.Rows.Count < 1 Then
                            dtAlertes = dtTemp
                        Else
                            dtAlertes.Rows.Add(dr.ItemArray)
                        End If
                    Next
                Next
                dtAlertes.Columns(0).ColumnName = "ID"
                dtAlertes.Columns(1).ColumnName = "Nom de la clef"
                dtAlertes.Columns(2).ColumnName = "Type d'emprunteur"
                dtAlertes.Columns(3).ColumnName = "Nom de l'emprunteur"
                dtAlertes.Columns(4).ColumnName = "Date d'emprunt"
                dtAlertes.Columns(5).ColumnName = "Date de retour"

                dgvResultats.DataSource = dtAlertes
                connecter().Close()
            Else
                'clear la dgv
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvResultats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultats.CellDoubleClick
        If dgvResultats.SelectedRows.Count > 0 Then
            frmPropAlertes.ShowDialog()
        End If
    End Sub
    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvResultats.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvResultats.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvResultats.PointToClient(Cursor.Position)
                menuGrid.Show(dgvResultats, mousePosition)
            End If
        End If
    End Sub

    Private Sub RetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourToolStripMenuItem.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            RetourClef(dgvResultats.SelectedRows(0).Cells(0).Value.ToString())
        End If
    End Sub

    Public Sub RetourClef(stgKeyID As String)
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim stgTrousseau As String = "Aucun"
        Try
            sql = "Select CTrousseau From Clefs WHERE CID='" & stgKeyID & "'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                stgTrousseau = dt.Rows(0)(0).ToString
            End If

            If stgTrousseau = "Aucun" Then
                ' Initializes variables to pass to the MessageBox.Show method.
                Dim Message As String = "Confirmer le retour de la clef ?"
                Dim Caption As String = "Retour de clef"
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Icon As MessageBoxIcon = MessageBoxIcon.Question

                Dim Result As DialogResult

                'Displays the MessageBox
                Result = MessageBox.Show(Message, Caption, Buttons, Icon)

                ' Gets the result of the MessageBox display.
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    dt.Clear()
                    If stgTrousseau = "Aucun" Then
                        sql = "DELETE FROM Emprunts WHERE EIDClef=""" & stgKeyID & """"
                        With cmd
                            .Connection = connecter()
                            .CommandText = sql
                            .ExecuteNonQuery()
                        End With

                        sql = "Update Clefs Set CStatus='Disponible' WHERE CID='" & stgKeyID & "'"
                        With cmd
                            .Connection = connecter()
                            .CommandText = sql
                            .ExecuteNonQuery()
                        End With
                    End If
                End If
            Else
                ' Initializes variables to pass to the MessageBox.Show method.
                Dim Message As String = "Cette clef fait partie d'un trousseau, voulez vous rendre le trousseau complet ?" & Environment.NewLine & Environment.NewLine & "Répondez ""non"" pour détacher la clef du trousseau et la rendre seule."
                Dim Caption As String = "Rendre le trousseau ?"
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNoCancel
                Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

                Dim Result As DialogResult

                'Displays the MessageBox
                Result = MessageBox.Show(Message, Caption, Buttons, Icon)

                ' Gets the result of the MessageBox display.
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    '===Emprunter trousseau===
                    'Récupération des clefs du trousseau
                    Dim cmdKey As New MySqlCommand
                    Dim dtClefDuTrousseau As New DataTable
                    Dim daKey As New MySqlDataAdapter

                    sql = "Select CID from Clefs where CTrousseau='" & stgTrousseau & "'"
                    With cmdKey
                        .Connection = connecter()
                        .CommandText = sql
                    End With
                    daKey.SelectCommand = cmdKey
                    dtClefDuTrousseau.Clear()
                    daKey.Fill(dtClefDuTrousseau)
                    'Faire Emprunt pour chaque clef du trousseau
                    If dtClefDuTrousseau.Rows.Count > 0 Then
                        For Each r In dtClefDuTrousseau.Rows
                            Dim stgKeyFromTrousseau As String = r.item("CID").ToString
                            sql = "DELETE FROM Emprunts WHERE EIDClef=""" & stgKeyFromTrousseau & """"
                            With cmd
                                .Connection = connecter()
                                .CommandText = sql
                                .ExecuteNonQuery()
                            End With

                            sql = "Update Clefs Set CStatus='Disponible' WHERE CID='" & stgKeyFromTrousseau & "'"
                            With cmd
                                .Connection = connecter()
                                .CommandText = sql
                                .ExecuteNonQuery()
                            End With
                        Next
                    End If
                ElseIf Result = System.Windows.Forms.DialogResult.No Then
                    sql = "UPDATE Clefs SET CTrousseau = 'Aucun' Where CID='" & stgKeyID & "'"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    dt.Clear()
                    sql = "DELETE FROM Emprunts WHERE EIDClef=""" & stgKeyID & """"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With

                    sql = "Update Clefs Set CStatus='Disponible' WHERE CID='" & stgKeyID & "'"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                End If
            End If
            connecter().Close()
            SearchAndRefresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PropriétésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriétésToolStripMenuItem.Click
        frmPropAlertes.ShowDialog()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndex As Integer = 1

        If cbRechercher.Text = "ID" Then
            intIndex = 0
        ElseIf cbRechercher.Text = "Nom" Then
            intIndex = 1
        ElseIf cbRechercher.Text = "Emprunteur" Then
            intIndex = 3
        End If

        Try
            For i = 0 To dgvResultats.RowCount - 1
                If dgvResultats.Rows(i).Cells(intIndex).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvResultats.Rows(i).Selected = True
                    dgvResultats.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

End Class