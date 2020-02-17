Imports MySql.Data.MySqlClient

'Formulaire principal, peut être optimisé
Public Class frmMain
    Dim dtByKey As DataTable
    Dim dtByOwner As DataTable
    'Booléeen pour l'affichage des alertes seulement une fois
    Public blnAlertes As Boolean = True
    'Booléeen pour savoir si c'est un emprunt ou une attribution
    Public blnEmprunt As Boolean
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
        SearchAndRefresh()
        'Sub du remplissage de l'autocomplétion
        SetAutocomplete()
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
        'Sub de remplissage de l'autocomplétion
        Dim cmd As New MySqlCommand
        Dim dtPredict As New DataTable
        Dim daPredict As New MySqlDataAdapter
        'Déclaration des pré-requetes MySQL
        Dim stgPredict As String = "Select * from Clefs"
        Dim stgStatus As String = "CStatus=*"

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

        Select Case chkNumber
            Case 1
                stgStatus = "CStatus=""Attribuée"""
            Case 2
                stgStatus = "CStatus=""Empruntée"""
            Case 3
                stgStatus = "CStatus=""Attribuée"" OR CStatus= ""Empruntée"""
            Case 4
                stgStatus = "CStatus=""Disponible"""
            Case 5
                stgStatus = "CStatus=""Attribuée"" OR CStatus= ""Disponible"""
            Case 6
                stgStatus = "CStatus=""Disponible"" OR CStatus= ""Empruntée"""
            Case Else
                stgStatus = "CStatus like ""%"""
        End Select

        'Filtres du type de recherche
        If cbRechercher.Text = "ID" Then
            stgPredict = "Select CID from Clefs where CID <> ""0"""
        ElseIf cbRechercher.Text = "Nom" Then
            stgPredict = "Select CNom from Clefs where CID <> ""0"""
        ElseIf cbRechercher.Text = "Emprunteur" Then
            stgPredict = "Select ENomPersonne from Emprunts"
        ElseIf cbRechercher.Text = "Lieu" Then
            stgPredict = "Select CPosition from Clefs where CID <> ""0"""
        End If
        'Requetes et remplissage de l'autocomplétion
        Try
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
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub LoadData()
        'Faire pré chargement des données
    End Sub

    Public Sub SearchAndRefresh()
        'Sub de recherche
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        'Déclaration des pré-requetes MySQL
        Dim sql As String = "Select CID, CNom, Cposition, CStatus, CTrousseau, CBatiment from Clefs"
        Dim stgStatus As String = "CStatus=*"

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
        Select Case chkNumber
            Case 1
                stgStatus = "CStatus=""Attribuée"""
            Case 2
                stgStatus = "CStatus=""Empruntée"""
            Case 3
                stgStatus = "CStatus=""Attribuée"" OR CStatus= ""Empruntée"""
            Case 4
                stgStatus = "CStatus=""Disponible"""
            Case 5
                stgStatus = "CStatus=""Attribuée"" OR CStatus= ""Disponible"""
            Case 6
                stgStatus = "CStatus=""Disponible"" OR CStatus= ""Empruntée"""
            Case Else
                stgStatus = "CStatus like ""%"""
        End Select
        'Filtres du type de recherche
        If cbRechercher.Text = "ID" Then
            sql = "Select CID, CNom, Cposition, CStatus, CTrousseau, CBatiment from Clefs Where " & stgStatus & " and CID <> ""0"""
        ElseIf cbRechercher.Text = "Nom" Then
            sql = "Select CID, CNom, Cposition, CStatus, CTrousseau, CBatiment from Clefs Where " & stgStatus & " and CID <> ""0"""
        ElseIf cbRechercher.Text = "Emprunteur" Then
            sql = "SELECT CTrousseau, CID, CNom, CPosition, ENomPersonne, EDateDebut, EDateFin FROM Clefs, Emprunts WHERE Clefs.CID = Emprunts.EIDClef AND " & stgStatus & " and CID <> ""0"""
        ElseIf cbRechercher.Text = "Lieu" Then
            sql = "SELECT CID, CNom, Cposition, CStatus, CTrousseau, CBatiment FROM Clefs WHERE " & stgStatus & " and CID <> ""0"""
        End If
        'Requetes et recherche
        Try
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            da = Nothing

            For i As Integer = 0 To dt.Columns.Count - 1
                dt.Columns(i).ColumnName = dt.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next

            dgvResultats.DataSource = dt
            connecter().Close()
            Search()
        Catch ex As Exception
        End Try

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
                SearchAndRefresh()
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

    Private Sub chkDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisponibles.CheckedChanged
        'Actualisation au changement des filtres à cochés
        SearchAndRefresh()
        SetAutocomplete()
    End Sub

    Private Sub chkEmpruntees_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmpruntees.CheckedChanged
        'Actualisation au changement des filtres à cochés
        SearchAndRefresh()
        SetAutocomplete()
    End Sub

    Private Sub chkAttribuees_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttribuees.CheckedChanged
        'Actualisation au changement des filtres à cochés
        SearchAndRefresh()
        SetAutocomplete()
    End Sub

    Private Sub cbRechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRechercher.SelectedIndexChanged
        'Actualisation au changement du type de recherche
        SearchAndRefresh()
        SetAutocomplete()
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
        SearchAndRefresh()
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
End Class
