Imports MySql.Data.MySqlClient
Public Class frmEmprunterClef
    Dim stgKeyId As String
    Dim stgTrousseau As String
    Dim blnEmprunt As Boolean
    'Déclaration des sources de données pour la DataGridView
    Dim srcPersonnes As New BindingSource()

    Public Sub LoadPersonnes()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim dtPredict As New DataTable
        Dim daPredict As New MySqlDataAdapter

        Dim sql As String = "Select * from NomPersonne"
        Dim stgPredict As String = "Select * from NomPersonne"


        sql = "Select * from NomPersonne Where NNom like ""%" & txtRechercher.Text & "%"""
        stgPredict = "Select NNom from NomPersonne"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For i As Integer = 0 To dt.Columns.Count - 1
                dt.Columns(i).ColumnName = dt.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            dgvResultats.DataSource = dt

            With cmd
                .Connection = connecter()
                .CommandText = stgPredict
            End With
            daPredict.SelectCommand = cmd
            daPredict.Fill(dtPredict)
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtRechercher.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dtPredict.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtRechercher.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                txtRechercher.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmEmpruntClef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPersonnes()
        blnEmprunt = frmMain.blnEmprunt
        If frmMain.blnEmprunt = False Then
            dtpFinEmprunt.Enabled = False
            btnSave.Text = "Attribuer"
            Me.Text = "Attribuer une clef..."
            lblDu.Text = "Attribuer à partir du"
            lblAu.Visible = False
            dtpFinEmprunt.Visible = False
        Else
            dtpFinEmprunt.Enabled = True
            btnSave.Text = "Emprunter"
            Me.Text = "Emprunter une clef..."
            lblDu.Text = "Emprunter du"
            lblAu.Visible = True
            dtpFinEmprunt.Visible = True
        End If
        Dim intIndexNom As Integer = frmMain.dgvResultats.Columns("Nom").Index
        Dim intIndexID As Integer = frmMain.dgvResultats.Columns("ID").Index
        Dim stgKeyName = frmMain.dgvResultats.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        stgKeyId = frmMain.dgvResultats.SelectedRows(0).Cells(intIndexID).Value.ToString()
        txtKeyID.Text = stgKeyId
        txtKeyName.Text = stgKeyName

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String = "Select CTrousseau from Clefs Where CID='" & stgKeyId & "'"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(0).ToString <> "Aucun" And dt.Rows(0).Item(0).ToString <> "" Then
                    stgTrousseau = dt.Rows(0).Item(0).ToString
                    txtKeyTrousseau.Text = dt.Rows(0).Item(0).ToString
                Else
                    txtKeyTrousseau.Text = "Aucun trousseau"
                End If
            End If

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Rechercher()
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Rechercher()
    End Sub

    Private Sub Rechercher()
        Try
            For i = 0 To dgvResultats.RowCount - 1
                If dgvResultats.Rows(i).Cells(1).Value.ToString.IndexOf(txtRechercher.Text, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvResultats.Rows(i).Selected = True
                    dgvResultats.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtKeyTrousseau.Text = "Aucun trousseau" Then
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter

                Dim sql As String

                If blnEmprunt = True Then
                    sql = "UPDATE Clefs SET CStatus = 'Empruntée' Where CID='" & txtKeyID.Text & "'"
                Else
                    sql = "UPDATE Clefs SET CStatus = 'Attribuée' Where CID='" & txtKeyID.Text & "'"
                End If
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                Dim intIndexGenre As Integer = dgvResultats.Columns("Genre").Index
                Dim intIndexPersonne As Integer = dgvResultats.Columns("Nom").Index
                Dim stgGenre = dgvResultats.SelectedRows(0).Cells(intIndexGenre).Value.ToString()
                Dim stgPersonne = dgvResultats.SelectedRows(0).Cells(intIndexPersonne).Value.ToString()
                Dim cmdEmprunt As String
                If blnEmprunt = True Then
                    cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EDateFin`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @datefin,
                                                                @genre
                                                              )
                                                            "
                Else
                    cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @genre
                                                              )
                                                            "
                End If

                dt.Reset()
                Dim insertEmprunt As New MySqlCommand(cmdEmprunt, connecter())

                insertEmprunt.Parameters.Add("@keyid", MySqlDbType.VarChar).Value = stgKeyId
                insertEmprunt.Parameters.Add("@personne", MySqlDbType.VarChar).Value = stgPersonne
                insertEmprunt.Parameters.Add("@datedebut", MySqlDbType.DateTime).Value = dtpDebutEmprunt.Value
                If blnEmprunt = True Then
                    insertEmprunt.Parameters.Add("@datefin", MySqlDbType.DateTime).Value = dtpFinEmprunt.Value
                End If
                insertEmprunt.Parameters.Add("@genre", MySqlDbType.VarChar).Value = stgGenre
                insertEmprunt.ExecuteNonQuery()
            Else
                ' Initializes variables to pass to the MessageBox.Show method.
                Dim Message As String = "Cette clef fait partie d'un trousseau, voulez vous emprunter le trousseau complet ?" & Environment.NewLine & "Répondez ""non"" pour détacher la clef du trousseau."
                Dim Caption As String = "Emprunter le trousseau ?"
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
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
                    Dim sql As String

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
                            Dim cmd As New MySqlCommand
                            Dim dt As New DataTable
                            Dim da As New MySqlDataAdapter

                            If blnEmprunt = True Then
                                sql = "UPDATE Clefs SET CStatus = 'Empruntée' Where CID='" & stgKeyFromTrousseau & "'"
                            Else
                                sql = "UPDATE Clefs SET CStatus = 'Attribuée' Where CID='" & stgKeyFromTrousseau & "'"
                            End If
                            With cmd
                                .Connection = connecter()
                                .CommandText = sql
                                .ExecuteNonQuery()
                            End With

                            Dim intIndexGenre As Integer = dgvResultats.Columns("Genre").Index
                            Dim intIndexPersonne As Integer = dgvResultats.Columns("Nom").Index
                            Dim stgGenre = dgvResultats.SelectedRows(0).Cells(intIndexGenre).Value.ToString()
                            Dim stgPersonne = dgvResultats.SelectedRows(0).Cells(intIndexPersonne).Value.ToString()
                            Dim cmdEmprunt As String
                            If blnEmprunt = True Then
                                cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EDateFin`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @datefin,
                                                                @genre
                                                              )
                                                            "
                            Else
                                cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @genre
                                                              )
                                                            "
                            End If

                            dt.Reset()
                            Dim insertEmprunt As New MySqlCommand(cmdEmprunt, connecter())

                            insertEmprunt.Parameters.Add("@keyid", MySqlDbType.VarChar).Value = stgKeyFromTrousseau
                            insertEmprunt.Parameters.Add("@personne", MySqlDbType.VarChar).Value = stgPersonne
                            insertEmprunt.Parameters.Add("@datedebut", MySqlDbType.DateTime).Value = dtpDebutEmprunt.Value
                            If blnEmprunt = True Then
                                insertEmprunt.Parameters.Add("@datefin", MySqlDbType.DateTime).Value = dtpFinEmprunt.Value
                            End If
                            insertEmprunt.Parameters.Add("@genre", MySqlDbType.VarChar).Value = stgGenre
                            insertEmprunt.ExecuteNonQuery()
                        Next
                    End If
                ElseIf Result = System.Windows.Forms.DialogResult.No Then
                    '===Emprunter clef===
                    'Retirer la clef du trousseau
                    Dim cmd As New MySqlCommand
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter

                    Dim sql As String

                    sql = "UPDATE Clefs SET CTrousseau = 'Aucun' Where CID='" & txtKeyID.Text & "'"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    'Créer l'emprunt de la clef
                    If blnEmprunt = True Then
                        sql = "UPDATE Clefs SET CStatus = 'Empruntée' Where CID='" & txtKeyID.Text & "'"
                    Else
                        sql = "UPDATE Clefs SET CStatus = 'Attribuée' Where CID='" & txtKeyID.Text & "'"
                    End If
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With

                    Dim intIndexGenre As Integer = dgvResultats.Columns("Genre").Index
                    Dim intIndexPersonne As Integer = dgvResultats.Columns("Nom").Index
                    Dim stgGenre = dgvResultats.SelectedRows(0).Cells(intIndexGenre).Value.ToString()
                    Dim stgPersonne = dgvResultats.SelectedRows(0).Cells(intIndexPersonne).Value.ToString()
                    Dim cmdEmprunt As String
                    If blnEmprunt = True Then
                        cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EDateFin`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @datefin,
                                                                @genre
                                                              )
                                                            "
                    Else
                        cmdEmprunt = "INSERT INTO
                                                              `Emprunts`(
                                                                `EIDClef`,
                                                                `ENomPersonne`,
                                                                `EDateDebut`,
                                                                `EIDGenre`
                                                              )
                                                            VALUES
                                                              (
                                                                @keyid,
                                                                @personne,
                                                                @datedebut,
                                                                @genre
                                                              )
                                                            "
                    End If

                    dt.Reset()
                    Dim insertEmprunt As New MySqlCommand(cmdEmprunt, connecter())

                    insertEmprunt.Parameters.Add("@keyid", MySqlDbType.VarChar).Value = stgKeyId
                    insertEmprunt.Parameters.Add("@personne", MySqlDbType.VarChar).Value = stgPersonne
                    insertEmprunt.Parameters.Add("@datedebut", MySqlDbType.DateTime).Value = dtpDebutEmprunt.Value
                    If blnEmprunt = True Then
                        insertEmprunt.Parameters.Add("@datefin", MySqlDbType.DateTime).Value = dtpFinEmprunt.Value
                    End If
                    insertEmprunt.Parameters.Add("@genre", MySqlDbType.VarChar).Value = stgGenre
                    insertEmprunt.ExecuteNonQuery()
                End If
            End If
            connecter().Close()
            frmMain.FillDataSource()
            frmMain.SetAutocomplete()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnPersonne_Click(sender As Object, e As EventArgs) Handles btnPersonne.Click
        frmGestionPersonnes.ShowDialog()
    End Sub
End Class