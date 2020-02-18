﻿Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

'Formulaire principal, peut être optimisé
Public Class frmMain
    'Déclaration des sources de données pour la DataGridView
    Dim srcKeyList As New BindingSource()
    Dim srcOwner As New BindingSource()
    'Booléeen pour l'affichage des alertes seulement une fois
    Public blnAlertes As Boolean = True
    'Booléeen pour savoir si c'est un emprunt ou une attribution
    Public blnEmprunt As Boolean

    Private Shared Function Split(ByVal str As String, ByVal chunkSize As Integer) As IEnumerable(Of String)
        Return Enumerable.Range(0, str.Length / chunkSize).[Select](Function(i) str.Substring(i * chunkSize, chunkSize))
    End Function

    Private Function TintBitmap(b As Bitmap, color As Color, intensity As Single) As Bitmap
        Dim b2 As New Bitmap(b.Width, b.Height)

        Dim ia As New ImageAttributes

        Dim m As ColorMatrix
        m = New ColorMatrix(New Single()() _
            {New Single() {1, 0, 0, 0, 0},
             New Single() {0, 1, 0, 0, 0},
             New Single() {0, 0, 1, 0, 0},
             New Single() {0, 0, 0, 1, 0},
             New Single() {color.R / 255 * intensity, color.G / 255 * intensity, color.B / 255 * intensity, 0, 1}})

        ia.SetColorMatrix(m)
        Dim g As Graphics = Graphics.FromImage(b2)
        g.DrawImage(b, New Rectangle(0, 0, b.Width, b.Height), 0, 0, b.Width, b.Height, GraphicsUnit.Pixel, ia)
        Return b2

    End Function

    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvResultats.CellMouseDown
        '--- Evenement de clic droit sur la DataGridView ---
        'Vérification si le clic a été fait sur une cellule
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            'Vérification du type de clic
            If e.Button = MouseButtons.Right Then
                'Selection d'un row si se n'est pas déjà fait
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvResultats.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                'récupération de la position du clic
                Dim mousePosition = dgvResultats.PointToClient(Cursor.Position)
                'affichage du menu pour editer, supprimer...
                menuGrid.Show(dgvResultats, mousePosition)
            End If
        End If
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialiser l'index du menu déroulant de sélection du type de recherche
        cbRechercher.SelectedIndex = 1
        'Sub d'actualisation et de recherche (Ctrl + clic sur le nom pour y accèder rapidement)
        FillDataSource()
        'Désactivation des fonctions administrateur
        If userType <> "Administrateur" Then
            btnAddClef.Enabled = False
            btnAddTrousseau.Enabled = False
            GestionDesBâtimentsToolStripMenuItem.Enabled = False
            GestionDesTableauxToolStripMenuItem.Enabled = False
            SupprimerToolStripMenuItem.Enabled = False
            EditerToolStripMenuItem.Enabled = False
        End If
        'Check des alertes
        CheckAlerts()
    End Sub

    Public Sub CheckAlerts()
        'Déclaration d'une variable qui à pour valeur la date actuelle
        Dim dateNow As Date = Now
        'Déclarations des variables nécessaires pour l'accès à la base de données et la récupération des données
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        'Déclaration de la requète
        Dim sql As String = "Select EIDClef, EDateFin From Emprunts Where EDateFin IS NOT NULL"
        'Try permet de renvoyer l'erreur si la requète échoue au lieu de freeze le logiciel
        Try
            'reset de la datatable, pas nécessaire à l'initialisation, mais pour les refresh oui
            dt.Reset()
            'execution de la commande via la connection déclarer dans la fonction situé dans modFunction.vb
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            'récupération des données
            da.SelectCommand = cmd
            'remplissage de la table avec les données
            da.Fill(dt)

            'Si il y a des données retournées par la requètes
            'et donc s'il y a des alertes
            If dt.Rows.Count > 0 Then
                'Si l'utilisateur à les pop up d'alertes activées
                If My.Settings.ShowAlert = True Then
                    'Si c'est la première pop up depuis le lancement du logiciel
                    If blnAlertes = True Then
                        'Création de la messagebox
                        Dim Message As String = "Il y a " & dt.Rows.Count & " clefs non rendues !"
                        Dim Caption As String = "Alertes"
                        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
                        Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning
                        Dim Result As DialogResult
                        'Affichage de la message box
                        Result = MessageBox.Show(Message, Caption, Buttons, Icon)
                        'Passage du booléen blnAlertes à false pour évite la pop up à chaque actualisation
                        blnAlertes = False
                    End If
                End If
                'Mise en forme du menu alertes suivant le nombre d'alerte
                menAlertes.Text = "Alertes (" & dt.Rows.Count & ")"
                menAlertes.ForeColor = Color.Red
                menAlertes.Font = New Font(menAlertes.Font, FontStyle.Bold)
            Else
                menAlertes.Text = "Alertes"
                menAlertes.ForeColor = Color.Black
                menAlertes.Font = New Font(menAlertes.Font, FontStyle.Regular)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub main_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        'Fermé l'application à la fermeture de cette fenêtre
        Application.Exit()
        End
    End Sub

    Private Sub btnAddClef_Click(sender As Object, e As EventArgs) Handles btnAddClef.Click
        'afficher la fenêtre d'ajout de clef
        frmAjouterClef.ShowDialog()
    End Sub

    Private Sub btnAddTrousseau_Click(sender As Object, e As EventArgs) Handles btnAddTrousseau.Click
        'afficher la fenêtre d'ajout de trousseau
        frmGestionTrousseau.ShowDialog()
    End Sub

    Private Sub EmprunterLaClefToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'afficher la fenêtre d'emprunt de clef
        frmEmprunterClef.ShowDialog()
    End Sub

    Public Sub SetAutocomplete()
        Dim stgPredict As String = ""
        'Filtres du type de recherche
        Try
            If dgvResultats.RowCount > 0 Then
                If cbRechercher.Text = "Nom" Then
                    stgPredict = "Nom"
                ElseIf cbRechercher.Text = "Emprunteur" Then
                    stgPredict = "NomPersonne"
                ElseIf cbRechercher.Text = "Lieu" Then
                    stgPredict = "Position"
                ElseIf cbRechercher.Text = "ID" Then
                    stgPredict = "ID"
                Else
                    Exit Sub
                End If
                'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
                txtRechercher.AutoCompleteCustomSource.Clear()
                'LOOPING THE ROW OF DATA IN THE DATATABLE
                For Each r In dgvResultats.Rows
                    'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                    txtRechercher.AutoCompleteCustomSource.Add(r.Cells(stgPredict).Value.ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub FillDataSource()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtKeyList As DataTable = New DataTable()
        Dim dtOwner As DataTable = New DataTable()
        Dim sql As String

        Try

            sql = "Select CID, CNom, CPosition, CStatus, CTrousseau, CBatiment from Clefs Where CID <> ""0"""

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyList)
            For i As Integer = 0 To dtKeyList.Columns.Count - 1
                dtKeyList.Columns(i).ColumnName = dtKeyList.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            srcKeyList.DataSource = dtKeyList

            For Each column In dgvResultats.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            sql = "SELECT CTrousseau, CID, CNom, CPosition, CStatus, ENomPersonne, EDateDebut, EDateFin FROM Clefs, Emprunts WHERE Clefs.CID = Emprunts.EIDClef AND CStatus like ""%"" and CID <> ""0"""
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtOwner)
            For i As Integer = 0 To dtOwner.Columns.Count - 1
                dtOwner.Columns(i).ColumnName = dtOwner.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            srcOwner.DataSource = dtOwner

            If cbRechercher.Text = "Emprunteur" Then
                dgvResultats.DataSource = srcOwner
            Else
                dgvResultats.DataSource = srcKeyList
            End If

            dgvResultats.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvResultats.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            connecter().Close()

            'Sub du remplissage de l'autocomplétion
            SetAutocomplete()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Filter()
        Dim chkNumber As Integer = 0
        'Création de tout les cas possible de filtre pour les cases à cochées
        '(utilisation d'une sorte de "table de Karnaugh")
        If chkDisponibles.Checked = True Then
            chkNumber += 4
        End If
        If chkEmpruntees.Checked = True Then
            chkNumber += 2
        End If
        If chkAttribuees.Checked = True Then
            chkNumber += 1
        End If
        If cbRechercher.Text <> "Emprunteur" Then
            Select Case chkNumber
                Case 1
                    srcKeyList.Filter = "Status='Attribuée'"
                Case 2
                    srcKeyList.Filter = "Status='Empruntée'"
                Case 3
                    srcKeyList.Filter = "Status='Attribuée' OR Status= 'Empruntée'"
                Case 4
                    srcKeyList.Filter = "Status='Disponible'"
                Case 5
                    srcKeyList.Filter = "Status='Attribuée' OR Status= 'Disponible'"
                Case 6
                    srcKeyList.Filter = "Status='Disponible' OR Status= 'Empruntée'"
                Case Else
                    srcKeyList.Filter = ""
            End Select
        Else
            Select Case chkNumber
                Case 1
                    srcOwner.Filter = "Status='Attribuée'"
                Case 2
                    srcOwner.Filter = "Status='Empruntée'"
                Case 3
                    srcOwner.Filter = "Status='Attribuée' OR Status= 'Empruntée'"
                Case 4
                    srcOwner.Filter = "Status='Disponible'"
                Case 5
                    srcOwner.Filter = "Status='Attribuée' OR Status= 'Disponible'"
                Case 6
                    srcOwner.Filter = "Status='Disponible' OR Status= 'Empruntée'"
                Case Else
                    srcOwner.Filter = ""
            End Select
        End If
    End Sub

    Private Sub chkDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisponibles.CheckedChanged
        SetAutocomplete()
        Filter()
    End Sub

    Private Sub chkEmpruntees_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmpruntees.CheckedChanged
        SetAutocomplete()
        Filter()
    End Sub

    Private Sub chkAttribuees_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttribuees.CheckedChanged
        SetAutocomplete()
        Filter()
    End Sub

    Private Sub cbRechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRechercher.SelectedIndexChanged
        'Filtres du type de recherche
        If cbRechercher.Text = "Emprunteur" Then
            dgvResultats.DataSource = srcOwner
        Else
            dgvResultats.DataSource = srcKeyList
        End If
        SetAutocomplete()
        Filter()
    End Sub

    Public Sub DeleteKey(stgKeyID As String)
        'Pop-up (message box):
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer la clef sélectionnée ?"
        Dim Caption As String = "Supprimer une clef"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

        Dim Result As DialogResult

        'Displays the MessageBox
        Result = MessageBox.Show(Message, Caption, Buttons, Icon)

        ' Gets the result of the MessageBox display.
        'Si l'utilisateur répond oui
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Dim cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter

            Dim sql As String

            Try
                sql = "DELETE FROM Clefs WHERE CID=""" & stgKeyID & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                connecter().Close()
                'actualisation du tableau
                'RefreshData()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Search()
        Dim searchValue As String = txtRechercher.Text
        Dim intColumnNb As Integer = 1
        'Filtres du type de recherche
        If cbRechercher.Text = "ID" Then
            intColumnNb = dgvResultats.Columns("ID").Index
        ElseIf cbRechercher.Text = "Nom" Then
            intColumnNb = dgvResultats.Columns("Nom").Index
        ElseIf cbRechercher.Text = "Emprunteur" Then
            intColumnNb = dgvResultats.Columns("NomPersonne").Index
        ElseIf cbRechercher.Text = "Lieu" Then
            intColumnNb = dgvResultats.Columns("Position").Index
        End If

        Try
            For i = 0 To dgvResultats.RowCount - 1
                If dgvResultats.Rows(i).Cells(intColumnNb).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvResultats.Rows(i).Selected = True
                    dgvResultats.FirstDisplayedScrollingRowIndex = i
                    Exit For
                    MsgBox("found on row " & i)
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        'recherche à chaque caractère entré dans le champ de recherche
        Search()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        'Récupération de l'id de la ligne cliquée
        Dim intIndexNom As Integer = dgvResultats.Columns("Nom").Index
        'Sub de suppression de la clef à partir de son ID
        DeleteKey(dgvResultats.SelectedRows(0).Cells(intIndexNom).Value.ToString())
    End Sub

    Private Sub PropriétésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        'Ouverture de l'edition de clef (à finir)
        frmEditerClef.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        'Ouverture des paramètres
        frmSettings.ShowDialog()
    End Sub

    Private Sub ActualiserToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Menu actualiser
        FillDataSource()
    End Sub

    Private Sub GestionDesPersonnesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesPersonnesToolStripMenuItem.Click
        'Menu gestion des personnes
        frmGestionPersonnes.ShowDialog()
    End Sub

    Private Sub GestionDesBâtimentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesBâtimentsToolStripMenuItem.Click
        'Menu gestion des batiments
        frmGestionBatiments.ShowDialog()
    End Sub

    Private Sub GestionDesTableauxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesTableauxToolStripMenuItem.Click
        frmGestionPosition.ShowDialog()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriétésToolStripMenuItem.Click
        'Menu propriété de la clef
        frmProprietes.ShowDialog()
    End Sub

    Private Sub EmprunterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmprunterToolStripMenuItem.Click
        'Ouverture du menu emprunt/attribution de clef en mode emprunt
        blnEmprunt = True
        frmEmprunterClef.ShowDialog()
    End Sub

    Private Sub AttribuerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttribuerToolStripMenuItem.Click
        'Ouverture du menu emprunt/attribution de clef en mode attribution
        blnEmprunt = False
        frmEmprunterClef.ShowDialog()
    End Sub

    Private Sub dgvResultats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultats.CellDoubleClick
        'Ouverture des propriétés au double clique sur une cellule
        If dgvResultats.SelectedRows.Count > 0 Then
            frmProprietes.ShowDialog()
        End If
    End Sub

    Private Sub menAlertes_Click(sender As Object, e As EventArgs) Handles menAlertes.Click
        'ouverture du menu d'alerte
        frmAlertes.ShowDialog()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub pbPersonnes_Click(sender As Object, e As EventArgs) Handles pbPersonnes.Click
        frmGestionPersonnes.ShowDialog()
    End Sub

    Private Sub pbSupprimer_Click(sender As Object, e As EventArgs) Handles pbSupprimer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Récupération de l'id de la ligne cliquée
            Dim intIndexNom As Integer = dgvResultats.Columns("Nom").Index
            'Sub de suppression de la clef à partir de son ID
            DeleteKey(dgvResultats.SelectedRows(0).Cells(intIndexNom).Value.ToString())
        End If
    End Sub

    Private Sub pbAttribuer_Click(sender As Object, e As EventArgs) Handles pbAttribuer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Ouverture du menu emprunt/attribution de clef en mode attribution
            blnEmprunt = False
            frmEmprunterClef.ShowDialog()
        End If
    End Sub

    Private Sub pbAttribuer_MouseEnter() Handles pbAttribuer.MouseEnter
        Dim b As Bitmap = New Bitmap(GestionClefs.My.Resources.login)
        pbAttribuer.Image = TintBitmap(b, Color.White, 0.3)
    End Sub

    Private Sub pbAttribuer_MouseLeave() Handles pbAttribuer.MouseLeave
        Dim b As Bitmap = New Bitmap(GestionClefs.My.Resources.login)
        pbAttribuer.Image = TintBitmap(b, Color.Black, 1)
    End Sub

    Private Sub pbEmprunter_Click(sender As Object, e As EventArgs) Handles pbEmprunter.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Ouverture du menu emprunt/attribution de clef en mode Emprun
            blnEmprunt = True
            frmEmprunterClef.ShowDialog()
        End If
    End Sub

    Private Sub pbEmprunter_MouseEnter() Handles pbEmprunter.MouseEnter
        Dim b As Bitmap = New Bitmap(GestionClefs.My.Resources.key1)
        pbEmprunter.Image = TintBitmap(b, Color.White, 0.3)
    End Sub

    Private Sub pbEmprunter_MouseLeave() Handles pbEmprunter.MouseLeave
        Dim b As Bitmap = New Bitmap(GestionClefs.My.Resources.key1)
        pbEmprunter.Image = TintBitmap(b, Color.Black, 1)
    End Sub

    Private Sub pbEditer_Click(sender As Object, e As EventArgs) Handles pbEditer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            frmEditerClef.ShowDialog()
        End If
    End Sub

    Private Sub pbProperties_Click(sender As Object, e As EventArgs) Handles pbProperties.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Menu propriété de la clef
            frmProprietes.ShowDialog()
        End If
    End Sub

    Private Sub lblEditer_Click(sender As Object, e As EventArgs) Handles lblEditer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            frmEditerClef.ShowDialog()
        End If
    End Sub

    Private Sub lblAttribuer_Click(sender As Object, e As EventArgs) Handles lblAttribuer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Ouverture du menu emprunt/attribution de clef en mode attribution
            blnEmprunt = False
            frmEmprunterClef.ShowDialog()
        End If
    End Sub

    Private Sub lblGestionPersonnes_Click(sender As Object, e As EventArgs) Handles lblGestionPersonnes.Click
        frmGestionPersonnes.ShowDialog()
    End Sub

End Class
