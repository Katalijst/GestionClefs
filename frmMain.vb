Imports MySql.Data.MySqlClient
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Collections.Specialized

'Formulaire principal, peut être optimisé
Public Class frmMain
    Public listADetacher As New List(Of String)
    'Déclaration des sources de données pour la DataGridView
    Dim dtKeyListSansGBat As DataTable = New DataTable()
    Dim dtKeyListAvecGBat As DataTable = New DataTable()
    Dim dtGBat As DataTable = New DataTable()
    Dim intKeyAmount As Integer = 0
    Public dtPanier As New DataTable
    Public dtKeyList As New DataTable
    Dim dtOwner As New DataTable
    Public srcPanier As New BindingSource()
    Public srcKeyList As New BindingSource()
    ReadOnly srcOwner As New BindingSource()
    ReadOnly srcKeyByBat As New BindingSource()
    'Booléeen pour l'affichage des alertes seulement une fois
    Public blnAlertes As Boolean = True
    'Booléeen pour savoir si c'est un emprunt ou une attribution
    Public blnEmprunt As Boolean
    Public blnProperties As Boolean = False
    Public blnLightMode As Boolean = False
    Public AlertesEmpruntPerdu As Integer = 0

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Shared Function Split(ByVal str As String, ByVal chunkSize As Integer) As IEnumerable(Of String)
        Return Enumerable.Range(0, str.Length / chunkSize).[Select](Function(i) str.Substring(i * chunkSize, chunkSize))
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
        Dim bmp As Bitmap = My.Resources.clear_button
        pbClearPanier.Image = setColorToBitmap(bmp, Color.Black, Color.Red)

        FillDataSource()

        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        'SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        'SetStyle(ControlStyles.UserPaint, True)

        BrightOrDarkMode()
        Dim strCBFiltre As String() = New String(5) {}
        strCBFiltre(0) = strTitleCID
        strCBFiltre(1) = strTitleCNom
        strCBFiltre(2) = strTitleCPosition
        strCBFiltre(3) = "Emprunteur"
        strCBFiltre(4) = strTitleCTrousseau
        strCBFiltre(5) = strTitleCBatiment
        cbRechercher.DataSource = strCBFiltre
        'Initialiser l'index du menu déroulant de sélection du type de recherche
        cbRechercher.SelectedIndex = 0
        'Sub d'actualisation et de recherche (Ctrl + clic sur le nom pour y accèder rapidement)
        'FillData2()
        'Désactivation des fonctions administrateur
        If GlobalUserType <> "Administrateur" Then
            btnAddKey.Enabled = False
            btnTrousseaux.Enabled = False
            btnBatiments.Enabled = False
            btnTableaux.Enabled = False
            SupprimerToolStripMenuItem1.Enabled = False
            EditerToolStripMenuItem1.Enabled = False
            btnParametres.Enabled = False
            btnSupprimer.Enabled = False
            btnEditer.Enabled = False
            SupprimerToolStripMenuItem1.Enabled = False
            EditerToolStripMenuItem1.Enabled = False
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
        Dim SqlCommand As String = "Select EIDClef From Emprunts Where EDateFin < DATE(NOW())"
        'Try permet de renvoyer l'erreur si la requète échoue au lieu de freeze le logiciel
        Try
            'reset de la datatable, pas nécessaire à l'initialisation, mais pour les refresh oui
            dt.Reset()
            'execution de la commande via la connection déclarer dans la fonction situé dans modFunction.vb
            With cmd
                .Connection = connecter()
                .CommandText = SqlCommand
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
                        'MaterialMessageBox.Show("Il y a " & dt.Rows.Count & " clefs non rendues !", "Alertes")
                        'Passage du booléen blnAlertes à false pour évite la pop up à chaque actualisation
                        blnAlertes = False
                    End If
                End If
                'Mise en forme du menu alertes suivant le nombre d'alerte
                btnAlertes.Text = "Alertes (" & dt.Rows.Count & ")"
                btnAlertes.ForeColor = Color.Red
                btnAlertes.Font = New Font(btnAlertes.Font, FontStyle.Bold)
                Dim b As Bitmap = New Bitmap(My.Resources.round_error_symbol)
                btnAlertes.Icon = TintBitmap(b, Color.Red, 1)
                lblAlertNotif.Text = "" & dt.Rows.Count
                lblAlertNotif.Visible = True
                CorlorNotifLabel()
            Else
                btnAlertes.Text = "Alertes"
                'If SkinManager.Theme = MaterialSkinManager.Themes.DARK Then
                '    btnAlertes.ForeColor = Color.White
                'Else
                '    btnAlertes.ForeColor = Color.Black
                'End If
                Dim b As Bitmap = New Bitmap(My.Resources.round_error_symbol)
                btnAlertes.Icon = b
                lblAlertNotif.Text = ""
                lblAlertNotif.Visible = False
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

    Public Sub FillDataSource()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtKeyListByOwner As DataTable = New DataTable()
        Dim dtEmpty As DataTable = New DataTable()
        Dim dtAmount As DataTable = New DataTable()
        Dim sql As String

        dtKeyListSansGBat.Reset()
        dtKeyListAvecGBat.Reset()
        dtGBat.Reset()
        dtPanier.Reset()
        dtKeyList.Reset()
        dtOwner.Reset()

        Try
            sql = "SELECT COUNT(CID) FROM Clefs "
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dtAmount)
            If dtAmount.Rows.Count > 0 Then
                intKeyAmount = dtAmount.Rows(0).Item(0)
            End If

            sql = "Select CID, CNom, CPosition, CStatus, CTrousseau, CBatiment from Clefs Where CID <> '0' AND CStatus <> 'Perdue' AND CBatiment <> 'Groupe de Batiments'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyListSansGBat)

            sql = "Select CID, CNom, CPosition, CStatus, CTrousseau, CBatiment from Clefs Where CID <> '0' AND CStatus <> 'Perdue' AND CBatiment = 'Groupe de Batiments'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyListAvecGBat)

            sql = "Select GIDClef, GIDBat FROM GroupeBat"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dtGBat)

            sql = "Select CTrousseau, CID, CNom, CPosition, CStatus, ENomPersonne, EDateDebut, EDateFin FROM Clefs, Emprunts WHERE Clefs.CID = Emprunts.EIDClef And CStatus <> 'Perdue' And CID <> '0'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyListByOwner)

            dtKeyListByOwner.Columns("CTrousseau").ColumnName = strTitleCTrousseau
            dtKeyListByOwner.Columns("CID").ColumnName = strTitleCID
            dtKeyListByOwner.Columns("CNom").ColumnName = strTitleCNom
            dtKeyListByOwner.Columns("CPosition").ColumnName = strTitleCPosition
            dtKeyListByOwner.Columns("CStatus").ColumnName = strTitleCStatus
            dtKeyListByOwner.Columns("ENomPersonne").ColumnName = "Emprunteur"
            dtKeyListByOwner.Columns("EDateDebut").ColumnName = strTitleEDateDebut
            dtKeyListByOwner.Columns("EDateFin").ColumnName = strTitleEDateFin

            dtOwner = dtKeyListByOwner.Copy
            srcOwner.DataSource = dtOwner


            If cbRechercher.Text <> "Emprunteur" Then
                dgvResultats.DataSource = srcKeyList
                dtEmpty = dtKeyListSansGBat.Copy
                dtEmpty.Columns.Add("Quantité")
                dtEmpty.Rows.Clear()
                dtEmpty.Columns("CID").ColumnName = strTitleCID
                dtEmpty.Columns("CNom").ColumnName = strTitleCNom
                dtEmpty.Columns("CPosition").ColumnName = strTitleCPosition
                dtEmpty.Columns("CStatus").ColumnName = strTitleCStatus
                dtEmpty.Columns("CTrousseau").ColumnName = strTitleCTrousseau
                dtEmpty.Columns("CBatiment").ColumnName = strTitleCBatiment
            Else
                dgvResultats.RowHeadersVisible = False
                dgvResultats.DataSource = srcOwner
                dtEmpty = dtOwner.Copy
                dtEmpty.Rows.Clear()
            End If
            dtPanier = dtEmpty.Copy
            srcPanier.DataSource = dtPanier
            dgvPanier.DataSource = srcPanier
            dgvPanier.Columns("Quantité").Visible = False
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
        Finally
            Rechercher()
        End Try
    End Sub

    Private Sub Rechercher()
        If dtKeyListSansGBat.Rows.Count < 1 Or dtGBat.Rows.Count < 1 Then
            Exit Sub
        End If
        Dim dtResultats As DataTable = dtKeyListSansGBat.Copy
        dtResultats.Clear()
        Dim stgRecherche As String = "%" & txtRechercher.Text & "%"
        Dim stgRechercheBat As String
        If cbRechercher.Text = strTitleCBatiment Then
            stgRechercheBat = stgRecherche
        Else
            stgRechercheBat = "%"
        End If
        Dim rClefSansGroupFiltrees() As DataRow = dtKeyListSansGBat.Select("CBatiment LIKE '" & stgRechercheBat & "'")
        Dim rIDClefGroupBatFiltres() As DataRow = dtGBat.Select("GIDBat LIKE '" & stgRechercheBat & "'")
        If rClefSansGroupFiltrees.Count > 0 Then
            dtResultats.Merge(rClefSansGroupFiltrees.CopyToDataTable)
        End If

        For Each r As DataRow In rIDClefGroupBatFiltres
            For Each dr As DataRow In dtKeyListAvecGBat.Select("CID LIKE '" & r.Item("GIDClef") & "-%'").CopyToDataTable.Rows()
                dtResultats.ImportRow(dr)
            Next
        Next

        Dim CheckIDClef As New StringCollection()
        Dim dtTempDistinct As DataTable = dtResultats.Copy
        dtTempDistinct.Clear()

        For Each r As DataRow In dtResultats.Rows
            If CheckIDClef.Contains(r.Item("CID")) = False Then
                CheckIDClef.Add(r.Item("CID"))
                dtTempDistinct.ImportRow(r)
            End If
        Next

        dtResultats.Clear()
        dtResultats = dtTempDistinct.Copy
        dtResultats.Columns.Add("Quantité")

        For Each r As DataRow In dtResultats.Rows
            Dim input As String = r.Item(0)
            Dim index As Integer = input.LastIndexOf("-")
            If index > 0 Then
                r.Item(0) = input.Substring(0, index)
            End If
            r.Item("Quantité") = 1
        Next
        dtResultats.DefaultView.Sort = "CID ASC, CStatus ASC, CPosition ASC, CTrousseau ASC"
        Dim dtKeyListSorted As DataTable = dtResultats.DefaultView.ToTable.Copy

        Dim rowToCompare As DataRow
        Dim duplicateList As ArrayList = New ArrayList()
        Dim dtTemp As DataTable = New DataTable()
        dtTemp = dtKeyListSorted

        For Each drow As DataRow In dtTemp.Rows
            duplicateList.Add(drow)
        Next

        For Each r As DataRow In duplicateList
            Dim blnSimilar As Boolean = False
            If rowToCompare Is Nothing Then
                rowToCompare = r
            Else
                If r.Item("CID") = rowToCompare.Item("CID") Then
                    If r.Item("CStatus") = rowToCompare.Item("CStatus") Then
                        If r.Item("CPosition") = rowToCompare.Item("CPosition") Then
                            If r.Item("CTrousseau") = rowToCompare.Item("CTrousseau") Then
                                blnSimilar = True
                            End If
                        End If
                    End If
                End If
                If blnSimilar = True Then
                    rowToCompare.Item("Quantité") += 1
                    dtTemp.Rows.Remove(r)
                Else
                    rowToCompare = r
                End If
            End If
        Next
        dtKeyListSorted = dtTemp.Copy
        dtKeyListSorted.Columns("CID").ColumnName = strTitleCID
        dtKeyListSorted.Columns("CNom").ColumnName = strTitleCNom
        dtKeyListSorted.Columns("CPosition").ColumnName = strTitleCPosition
        dtKeyListSorted.Columns("CStatus").ColumnName = strTitleCStatus
        dtKeyListSorted.Columns("CTrousseau").ColumnName = strTitleCTrousseau
        dtKeyListSorted.Columns("CBatiment").ColumnName = strTitleCBatiment

        dtResultats.Clear()
        dtKeyList.Clear()

        dgvResultats.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvResultats.RowHeadersVisible = False

        dtResultats = dtKeyListSorted.Copy
        dtKeyList = dtResultats.Copy

        '================================================================================================
        Dim rows_to_remove As List(Of DataRow) = New List(Of DataRow)()

        For Each row1 As DataRow In dtKeyList.Rows
            For Each row2 As DataGridViewRow In dgvPanier.Rows
                Dim Similarities As Integer = 0
                If row1.Item(strTitleCStatus).ToString = "Disponible" And row2.Cells(strTitleCStatus).Value.ToString = "Disponible" Then
                    For i = 0 To (dgvPanier.Columns.Count - 1)
                        If row1.Item(dgvPanier.Columns(i).HeaderText).ToString = row2.Cells(dgvPanier.Columns(i).HeaderText).Value.ToString Then
                            Similarities += 1
                        End If
                    Next
                End If
                If Similarities >= dgvPanier.Columns.Count Then
                    rows_to_remove.Add(row1)
                End If
            Next
        Next
        For Each row As DataRow In rows_to_remove
            dtKeyList.Rows.Remove(row)
            dtKeyList.AcceptChanges()
        Next
        '================================================================================================

        srcKeyList.DataSource = dtKeyList

        '
        ' FILTRES
        '

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
        If txtRechercher.Text <> "" And cbRechercher.Text <> strTitleCBatiment Then
            Dim strTypeDeRecherche As String = "`" & cbRechercher.Text & "`"
            If cbRechercher.Text <> "Emprunteur" Then
                srcKeyList.RemoveFilter()
                Select Case chkNumber
                    Case 1
                        srcKeyList.Filter = strTitleCStatus & "='Attribuée' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 2
                        srcKeyList.Filter = strTitleCStatus & "='Empruntée' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 3
                        srcKeyList.Filter = "(" & strTitleCStatus & "='Attribuée' OR Status= 'Empruntée') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 4
                        srcKeyList.Filter = strTitleCStatus & "='Disponible' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 5
                        srcKeyList.Filter = "(" & strTitleCStatus & "='Attribuée' OR Status= 'Disponible') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 6
                        srcKeyList.Filter = "(" & strTitleCStatus & "='Disponible' OR Status= 'Empruntée') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case Else
                        srcKeyList.Filter = strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                End Select
            Else
                srcOwner.RemoveFilter()
                Select Case chkNumber
                    Case 1
                        srcOwner.Filter = strTitleCStatus & "='Attribuée' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 2
                        srcOwner.Filter = strTitleCStatus & "='Empruntée' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 3
                        srcOwner.Filter = "(" & strTitleCStatus & "='Attribuée' OR Status= 'Empruntée') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 4
                        srcOwner.Filter = strTitleCStatus & "='Disponible' AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 5
                        srcOwner.Filter = "(" & strTitleCStatus & "='Attribuée' OR Status= 'Disponible') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case 6
                        srcOwner.Filter = "(" & strTitleCStatus & "='Disponible' OR Status= 'Empruntée') AND " & strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                    Case Else
                        srcOwner.Filter = strTypeDeRecherche & " like '%" & txtRechercher.Text & "%'"
                End Select
            End If
        Else
            srcKeyList.RemoveFilter()
            If cbRechercher.Text <> "Emprunteur" Then
                Select Case chkNumber
                    Case 1
                        srcKeyList.Filter = strTitleCStatus & "='Attribuée'"
                    Case 2
                        srcKeyList.Filter = strTitleCStatus & "='Empruntée'"
                    Case 3
                        srcKeyList.Filter = strTitleCStatus & "='Attribuée' OR Status= 'Empruntée'"
                    Case 4
                        srcKeyList.Filter = strTitleCStatus & "='Disponible'"
                    Case 5
                        srcKeyList.Filter = strTitleCStatus & "='Attribuée' OR Status= 'Disponible'"
                    Case 6
                        srcKeyList.Filter = strTitleCStatus & "='Disponible' OR Status= 'Empruntée'"
                    Case Else
                        srcKeyList.Filter = ""
                End Select
            Else
                srcOwner.RemoveFilter()
                Select Case chkNumber
                    Case 1
                        srcOwner.Filter = strTitleCStatus & "='Attribuée'"
                    Case 2
                        srcOwner.Filter = strTitleCStatus & "='Empruntée'"
                    Case 3
                        srcOwner.Filter = strTitleCStatus & "='Attribuée' OR Status= 'Empruntée'"
                    Case 4
                        srcOwner.Filter = strTitleCStatus & "='Disponible'"
                    Case 5
                        srcOwner.Filter = strTitleCStatus & "='Attribuée' OR Status= 'Disponible'"
                    Case 6
                        srcOwner.Filter = strTitleCStatus & "='Disponible' OR Status= 'Empruntée'"
                    Case Else
                        srcOwner.Filter = ""
                End Select
            End If
        End If
        Dim nbResultats As Integer = 0
        If cbRechercher.Text <> "Emprunteur" Then
            For Each r As DataGridViewRow In dgvResultats.Rows
                nbResultats += r.Cells("Quantité").Value
            Next
            If nbResultats > 1 Then
                lblNbDeClefs.Text = nbResultats & " clefs trouvées, " & intKeyAmount & " clefs enregistrées."
            ElseIf nbResultats = 1 Then
                lblNbDeClefs.Text = nbResultats & " clef trouvée, " & intKeyAmount & " clefs enregistrées."
            Else
                lblNbDeClefs.Text = "Aucune clef trouvée, " & intKeyAmount & " clefs enregistrées."
            End If
        Else
            lblNbDeClefs.Text = dgvResultats.Rows.Count & " clefs trouvées, " & intKeyAmount & " clefs enregistrées."
        End If
    End Sub

    Private Sub chkDisponibles_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkDisponibles.CheckedChanged
        'SetAutocomplete()
        Rechercher()
    End Sub

    Private Sub chkEmpruntees_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkEmpruntees.CheckedChanged
        'SetAutocomplete()
        Rechercher()
    End Sub

    Private Sub chkAttribuees_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkAttribuees.CheckedChanged
        'SetAutocomplete()
        Rechercher()
    End Sub

    Private Sub cbRechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRechercher.SelectedIndexChanged
        'Filtres du type de recherche

        dgvResultats.RowHeadersVisible = False
        If cbRechercher.Text = "Emprunteur" Then
            dgvResultats.DataSource = srcOwner
            chkDisponibles.Enabled = False
            chkEmpruntees.Checked = True
            chkAttribuees.Checked = True
        Else
            dgvResultats.DataSource = srcKeyList
            chkDisponibles.Enabled = True
        End If

        'SetAutocomplete()
        Rechercher()
    End Sub

    Public Sub DeleteKey()
        If dgvResultats.SelectedRows.Count > 0 Then
            'Pop-up (message box):
            ' Initializes variables to pass to the MessageBox.Show method.
            Dim Message As String
            Dim Caption As String
            If dgvResultats.SelectedRows.Count > 1 Then
                Message = "Voulez vous vraiment supprimer les " & dgvResultats.SelectedRows.Count & " clefs sélectionnées ?"
                Caption = "Supprimer des clefs"
            ElseIf dgvResultats.SelectedRows.Count = 1 Then
                Message = "Voulez vous vraiment supprimer la clef sélectionnée ?"
                Caption = "Supprimer une clef"
            Else
                Exit Sub
            End If
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

            Dim Result As DialogResult

            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)

            ' Gets the result of the MessageBox display.
            'Si l'utilisateur répond oui
            If Result = System.Windows.Forms.DialogResult.Yes Then

                Dim daSql As MySqlDataAdapter = New MySqlDataAdapter()
                Dim dt As New DataTable
                Dim DeleteQuery As String = "DELETE FROM Clefs WHERE CStatus=@StatusClef AND CPosition=@TableauClef AND CTrousseau=@TrousseauxClef AND CID LIKE @IDClef;"
                Dim Delete_command As New MySqlCommand(DeleteQuery, connecter)
                Delete_command.CommandType = CommandType.Text
                daSql.InsertCommand = Delete_command

                With Delete_command
                    .Parameters.Add("@IDClef", MySqlDbType.String)
                    .Parameters.Add("@StatusClef", MySqlDbType.VarChar)
                    .Parameters.Add("@TableauClef", MySqlDbType.VarChar)
                    .Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)
                End With
                Try
                    For Each r As DataGridViewRow In dgvResultats.SelectedRows
                        With Delete_command
                            .Parameters("@IDClef").Value = r.Cells(strTitleCID).Value & "-%"
                            .Parameters("@StatusClef").Value = r.Cells(strTitleCStatus).Value
                            .Parameters("@TableauClef").Value = r.Cells(strTitleCPosition).Value
                            .Parameters("@TrousseauxClef").Value = r.Cells(strTitleCTrousseau).Value
                            .CommandText = "DELETE FROM Clefs WHERE CStatus=@StatusClef AND CPosition=@TableauClef AND CTrousseau=@TrousseauxClef AND  CID LIKE @IDClef;"
                            .ExecuteNonQuery()
                        End With
                        With Delete_command
                            .Parameters("@IDClef").Value = r.Cells(strTitleCID).Value & "-%"
                            .CommandText = "SELECT COUNT(CID) FROM Clefs WHERE CID LIKE @IDClef;"
                            .ExecuteNonQuery()
                        End With
                        daSql.SelectCommand = Delete_command
                        daSql.Fill(dt)
                        If dt.Rows(0).Item(0) < 1 Then
                            With Delete_command
                                .Parameters("@IDClef").Value = r.Cells(strTitleCID).Value
                                .CommandText = "DELETE FROM InfosTechniques WHERE IDClef = @IDClef;"
                                .ExecuteNonQuery()
                            End With
                            With Delete_command
                                .Parameters("@IDClef").Value = r.Cells(strTitleCID).Value
                                .CommandText = "DELETE From GroupeBat Where GIDBat = @IDClef;"
                                .ExecuteNonQuery()
                            End With
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    connecter().Close()
                    FillDataSource()
                End Try
            End If
        End If
    End Sub

    Private Sub addToPanier()
        Dim listDeTrousseau As New List(Of String)
        Dim rows As New List(Of DataRow)

        If cbRechercher.Text <> "Emprunteur" Then
            If dgvResultats.SelectedRows.Count > 0 Then
                For Each selRow As DataGridViewRow In dgvResultats.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                    If selRow.Cells(strTitleCStatus).Value = "Disponible" Then
                        If selRow.Cells(strTitleCTrousseau).Value <> "Aucun" Then
                            If listDeTrousseau.Contains(selRow.Cells(strTitleCTrousseau).Value) Then
                                Continue For
                            End If
                            Dim Message As String = "Une ou plusieurs des clefs emprunter fait partie d'un trousseau, voulez vous emprunter tout le trousseau ?" & System.Environment.NewLine & "(Cliquez sur ""non"" pour la détacher du trousseau)"
                            Dim Caption As String = "Attention !"
                            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning
                            Dim Result As DialogResult
                            'Affichage de la message box
                            Result = MessageBox.Show(Message, Caption, Buttons, Icon)
                            If Result = DialogResult.Yes Then
                                listDeTrousseau.Add(selRow.Cells(strTitleCTrousseau).Value)
                                For Each row As DataRow In dtKeyList.Rows
                                    If row.Item(strTitleCTrousseau).ToString = selRow.Cells(strTitleCTrousseau).Value.ToString And row.Item(strTitleCStatus).ToString = "Disponible" Then
                                        rows.Add(row)
                                        dtPanier.ImportRow(row)
                                        dtPanier.AcceptChanges()
                                    End If
                                Next
                            ElseIf Result = DialogResult.No Then
                                listADetacher.Add(selRow.Cells(strTitleCTrousseau).Value & selRow.Cells(strTitleCID).Value)
                                If selRow.Cells(strTitleCStatus).Value = "Disponible" Then
                                    If selRow.Index >= 0 Then
                                        Dim row As DataRow = (TryCast(selRow.DataBoundItem, DataRowView)).Row
                                        rows.Add(row)
                                        dtPanier.ImportRow(row)
                                        dtPanier.AcceptChanges()
                                    End If
                                End If
                            Else
                                Exit Sub
                            End If
                        Else
                            If selRow.Cells(strTitleCStatus).Value = "Disponible" Then
                                If selRow.Index >= 0 Then
                                    Dim row As DataRow = (TryCast(selRow.DataBoundItem, DataRowView)).Row
                                    rows.Add(row)
                                    dtPanier.ImportRow(row)
                                    dtPanier.AcceptChanges()
                                End If
                            End If
                        End If
                    End If
                Next
                If rows.Count > 0 Then
                    For Each r As DataRow In rows
                        dtKeyList.Rows.Remove(r)
                        dtKeyList.AcceptChanges()
                    Next
                End If
                srcKeyList.DataSource = dtKeyList
                srcPanier.DataSource = dtPanier

                dgvResultats.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                dgvResultats.RowHeadersVisible = False
                dgvResultats.DataSource = srcKeyList

                dgvPanier.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                dgvPanier.RowHeadersVisible = False
                dgvPanier.DataSource = srcPanier
            End If
        End If
    End Sub

    Private Sub removeFromPanier()
        Dim listDeTrousseau As New List(Of String)

        If dgvPanier.SelectedRows.Count > 0 Then
            Dim rows As New List(Of DataRow)
            For Each selRow As DataGridViewRow In dgvPanier.SelectedRows.OfType(Of DataGridViewRow)().ToArray()
                If listADetacher.Contains(selRow.Cells(strTitleCTrousseau).Value & selRow.Cells(strTitleCID).Value) Then
                    listADetacher.Remove(selRow.Cells(strTitleCTrousseau).Value & selRow.Cells(strTitleCID).Value)
                ElseIf selRow.Cells(strTitleCTrousseau).Value <> "Aucun" Then
                    If listDeTrousseau.Contains(selRow.Cells(strTitleCTrousseau).Value) Then
                        Continue For
                    Else
                        listDeTrousseau.Add(selRow.Cells(strTitleCTrousseau).Value)
                    End If
                    'Dim ListRowToDelete As New List(Of DataRow)
                    For Each dr As DataRow In dtPanier.Rows
                        If dr.Item(strTitleCTrousseau).ToString = selRow.Cells(strTitleCTrousseau).Value.ToString Then
                            rows.Add(dr)
                            dtKeyList.ImportRow(dr)
                            dtKeyList.AcceptChanges()
                        End If
                    Next
                    'For Each dr As DataRow In ListRowToDelete
                    '    dtKeyList.ImportRow(dr)
                    '    dtKeyList.AcceptChanges()
                    '    dtPanier.Rows.Remove(dr)
                    '    dtPanier.AcceptChanges()
                    '    dgvResultats.Refresh()
                    '    dgvPanier.Refresh()
                    'Next
                Else
                    Dim intSelIndex As Integer = selRow.Index
                    If selRow.Index >= 0 Then
                        Dim drToAdd As DataRow = dtPanier.Rows(intSelIndex)
                        Dim row As DataRow = (TryCast(selRow.DataBoundItem, DataRowView)).Row
                        rows.Add(row)
                        dtKeyList.ImportRow(drToAdd)
                        dtKeyList.AcceptChanges()
                    End If
                End If
            Next
            For Each r As DataRow In rows
                dtPanier.Rows.Remove(r)
                dtPanier.AcceptChanges()
            Next
            dgvPanier.DataSource = srcPanier
            dgvResultats.DataSource = srcKeyList
        End If
    End Sub

    Private Sub dgvResultats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultats.CellDoubleClick
        addToPanier()
    End Sub

    Private Sub dgvPanier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPanier.CellDoubleClick
        removeFromPanier()
    End Sub

    Private Sub btnEmprunter_Click(sender As Object, e As EventArgs) Handles btnEmprunter.Click
        If dtPanier.Rows.Count > 0 Then
            'Ouverture du menu emprunt/attribution de clef en mode Emprunt
            blnEmprunt = True
            frmClefsEmprunterEtAttribuer.ShowDialog()
        Else
            blnEmprunt = True
            If dgvResultats.SelectedRows.Count > 0 Then addToPanier()
            frmClefsEmprunterEtAttribuer.ShowDialog()
        End If
    End Sub

    Private Sub btnAttribuer_Click(sender As Object, e As EventArgs) Handles btnAttribuer.Click
        If dtPanier.Rows.Count > 0 Then
            'Ouverture du menu emprunt/attribution de clef en mode attribution
            blnEmprunt = False
            frmClefsEmprunterEtAttribuer.ShowDialog()
        Else
            blnEmprunt = False
            addToPanier()
            frmClefsEmprunterEtAttribuer.ShowDialog()
        End If
    End Sub

    Private Sub btnInformations_Click(sender As Object, e As EventArgs) Handles btnInformations.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            'Menu propriété de la clef
            blnProperties = True
            frmClefsEditerEtProprietes.ShowDialog()
        End If
    End Sub

    Private Sub btnEditer_Click(sender As Object, e As EventArgs) Handles btnEditer.Click
        If dgvResultats.SelectedRows.Count > 0 Then
            blnProperties = False
            frmClefsEditerEtProprietes.ShowDialog()
        End If
    End Sub

    Private Sub btnAddKey_Click(sender As Object, e As EventArgs) Handles btnAddKey.Click
        'afficher la fenêtre d'ajout de clef
        frmClefsAjout.ShowDialog()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        'Sub de suppression des clefs sélectionnées
        DeleteKey()
    End Sub

    Private Sub btnPersonnes_Click(sender As Object, e As EventArgs) Handles btnPersonnes.Click
        'Menu gestion des personnes
        frmPersonnesGestion.ShowDialog()
    End Sub

    Private Sub btnTrousseaux_Click(sender As Object, e As EventArgs) Handles btnTrousseaux.Click
        frmTrousseauxGestion.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FillDataSource()
    End Sub

    Private Sub btnTableaux_Click(sender As Object, e As EventArgs) Handles btnTableaux.Click
        frmTableauxGestion.ShowDialog()
    End Sub


    Private Sub btnBatiments_Click(sender As Object, e As EventArgs) Handles btnBatiments.Click
        'Menu gestion des batiments
        frmBatimentsAjoutGestion.ShowDialog()
    End Sub

    Private Sub btnParametres_Click_1(sender As Object, e As EventArgs) Handles btnParametres.Click
        'Ouverture des paramètres
        frmParametres.ShowDialog()
    End Sub

    Private Sub btnAlertes_Click(sender As Object, e As EventArgs) Handles btnAlertes.Click
        'ouverture du menu d'alerte
        AlertesEmpruntPerdu = 1
        frmClefsEmpruntsEtAlertes.ShowDialog()
    End Sub

    Private Sub EmprunterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmprunterToolStripMenuItem1.Click
        'Ouverture du menu emprunt/attribution de clef en mode emprunt
        blnEmprunt = True
        addToPanier()
        frmClefsEmprunterEtAttribuer.ShowDialog()
    End Sub

    Private Sub AttribuerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AttribuerToolStripMenuItem1.Click
        'Ouverture du menu emprunt/attribution de clef en mode attribution
        blnEmprunt = False
        addToPanier()
        frmClefsEmprunterEtAttribuer.ShowDialog()
    End Sub

    Private Sub EditerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem1.Click
        'Ouverture de l'edition de clef (à finir)
        blnProperties = False
        frmClefsEditerEtProprietes.ShowDialog()
    End Sub

    Private Sub PropriétésToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PropriétésToolStripMenuItem1.Click
        'Menu propriété de la clef
        blnProperties = True
        frmClefsEditerEtProprietes.ShowDialog()
    End Sub

    Private Sub SupprimerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem1.Click
        DeleteKey()
    End Sub

    Public Sub BrightOrDarkMode()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkMode = True Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.DeepOrange400, TextShade.WHITE)
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE)

        End If

        If SkinManager.Theme = MaterialSkinManager.Themes.DARK Then
            For Each c As Control In GetAllChildren()
                If TypeOf c Is MaterialSkin.Controls.MaterialButton Then
                    If CType(c, MaterialSkin.Controls.MaterialButton).Icon IsNot Nothing Then
                        Dim bmp As Bitmap = New Bitmap(CType(c, MaterialSkin.Controls.MaterialButton).Icon)
                        CType(c, MaterialSkin.Controls.MaterialButton).Icon = setColorToBitmap(bmp, Color.Black, Color.White)
                    End If
                End If
                If TypeOf c Is MaterialSkin.Controls.MaterialButton Then
                    If CType(c, MaterialSkin.Controls.MaterialButton).Icon IsNot Nothing Then
                        Dim bmp As Bitmap = New Bitmap(CType(c, MaterialSkin.Controls.MaterialButton).Icon)
                        CType(c, MaterialSkin.Controls.MaterialButton).Icon = setColorToBitmap(bmp, Color.Black, Color.White)
                    End If
                End If
                If TypeOf c Is DataGridView Then
                    CType(c, DataGridView).DefaultCellStyle.ForeColor = Color.White
                    CType(c, DataGridView).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#616161")
                    CType(c, DataGridView).AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#424242")
                    CType(c, DataGridView).BackgroundColor = ColorTranslator.FromHtml("#424242")
                    CType(c, DataGridView).EnableHeadersVisualStyles = False
                    CType(c, DataGridView).ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#37474F")
                    CType(c, DataGridView).ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                End If
            Next
            For Each c As ToolStripMenuItem In menuGrid.Items.OfType(Of ToolStripMenuItem)
                If c.Image IsNot Nothing Then
                    Dim bmp As Bitmap = c.Image
                    c.Image = setColorToBitmap(bmp, Color.Black, Color.White)
                End If
            Next
            menuGrid.BackColor = ColorTranslator.FromHtml("#505050")
            'cbRechercher.BackColor = ColorTranslator.FromHtml("#37474f")
            'cbRechercher.ForeColor = Color.White
            Dim b As Bitmap = New Bitmap(My.Resources.clear_button)
            SupprimerToolStripMenuItem1.Image = setColorToBitmap(b, Color.White, Color.Red)
            b = New Bitmap(My.Resources.round_info_button)
            PropriétésToolStripMenuItem1.Image = setColorToBitmap(b, Color.White, Color.RoyalBlue)
        Else
            For Each c As Control In GetAllChildren()
                If TypeOf c Is MaterialSkin.Controls.MaterialButton Then
                    If CType(c, MaterialSkin.Controls.MaterialButton).Icon IsNot Nothing Then
                        Dim bmp As Bitmap = New Bitmap(CType(c, MaterialSkin.Controls.MaterialButton).Icon)
                        CType(c, MaterialSkin.Controls.MaterialButton).Icon = setColorToBitmap(bmp, Color.White, Color.Black)
                    End If
                End If
                If TypeOf c Is MaterialSkin.Controls.MaterialButton Then
                    If CType(c, MaterialSkin.Controls.MaterialButton).Icon IsNot Nothing Then
                        Dim bmp As Bitmap = New Bitmap(CType(c, MaterialSkin.Controls.MaterialButton).Icon)
                        CType(c, MaterialSkin.Controls.MaterialButton).Icon = setColorToBitmap(bmp, Color.White, Color.Black)
                    End If
                End If
                If TypeOf c Is DataGridView Then
                    CType(c, DataGridView).DefaultCellStyle.ForeColor = Color.Black
                    CType(c, DataGridView).DefaultCellStyle.BackColor = Color.White
                    CType(c, DataGridView).AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
                    CType(c, DataGridView).BackgroundColor = Color.White
                    CType(c, DataGridView).EnableHeadersVisualStyles = False
                    CType(c, DataGridView).ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Highlight
                    CType(c, DataGridView).ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                End If
            Next
            For Each c As ToolStripMenuItem In menuGrid.Items.OfType(Of ToolStripMenuItem)
                If c.Image IsNot Nothing Then
                    Dim bmp As Bitmap = c.Image
                    c.Image = setColorToBitmap(bmp, Color.White, Color.Black)
                End If
            Next
            menuGrid.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            'cbRechercher.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            'cbRechercher.ForeColor = Color.Black
            Dim b As Bitmap = New Bitmap(My.Resources.clear_button)
            SupprimerToolStripMenuItem1.Image = setColorToBitmap(b, Color.Black, Color.Red)
            b = New Bitmap(My.Resources.round_info_button)
            PropriétésToolStripMenuItem1.Image = setColorToBitmap(b, Color.Black, Color.RoyalBlue)
        End If
        CorlorNotifLabel()
    End Sub

    Public Sub CorlorNotifLabel()
        If My.Settings.DarkMode = True Then
            Me.lblAlertNotif.ForeColor = Color.Red
        Else
            Me.lblAlertNotif.ForeColor = ColorTranslator.FromHtml("#ff7043")
        End If
        Me.lblAlertNotif.AutoSize = True
        Me.lblAlertNotif.BackColor = System.Drawing.Color.Transparent
        Me.lblAlertNotif.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub btnLightMode_Click(sender As Object, e As EventArgs) Handles btnLightMode.Click
        If My.Settings.DarkMode = True Then
            My.Settings.DarkMode = False
            My.Settings.Save()
        Else
            My.Settings.DarkMode = True
            My.Settings.Save()
        End If
        BrightOrDarkMode()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Rechercher()
    End Sub

    Private Sub btnAddToPanier_Click(sender As Object, e As EventArgs) Handles btnAddToPanier.Click
        addToPanier()
    End Sub

    Private Sub btnRemoveToPanier_Click(sender As Object, e As EventArgs) Handles btnRemoveToPanier.Click
        removeFromPanier()
    End Sub

    Private Sub pbClearPanier_Click(sender As Object, e As EventArgs) Handles pbClearPanier.Click
        dgvPanier.SelectAll()
        removeFromPanier()
    End Sub

    Private Sub txtRechercher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRechercher.KeyDown
        If e.KeyCode = Keys.Enter Then
            Rechercher()
        End If
    End Sub

    Private Sub RechercherBatiment()
        Dim dtKeyByBat As DataTable = New DataTable()
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text

        With cmd
            .Parameters.Add("@Batiment", MySqlDbType.String)
        End With



        sql = "Select CID, CNom, CPosition, CStatus, CTrousseau, CBatiment from Clefs Where CID <> '0' AND CStatus <> 'Perdue' AND CBatiment <> 'Groupe de Batiments' AND CBatiment like '@Batiment' UNION Select CID, CNom, CPosition, CStatus, CTrousseau, GIDBat from Clefs, GroupeBat Where CID <> '0' AND CStatus <> 'Perdue' AND GIDBat like @Batiment AND CID like CONCAT(GIDClef, '-%');"
        With cmd
            .Parameters("@Batiment").Value = "%" & txtRechercher.Text & "%"
            .Connection = connecter()
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        da.SelectCommand = cmd
        da.Fill(dtKeyByBat)

        intKeyAmount = dtKeyByBat.Rows.Count
        dtKeyByBat.Columns.Add("Quantité")
        For Each r As DataRow In dtKeyByBat.Rows
            Dim input As String = r.Item("CID")
            Dim index As Integer = input.LastIndexOf("-")
            If index > 0 Then
                r.Item("CID") = input.Substring(0, index)
            End If
            r.Item("Quantité") = 1
        Next

        'Merge and order rows

        dtKeyByBat.DefaultView.Sort = "CID ASC, CStatus ASC, CPosition ASC, CTrousseau ASC, CBatiment ASC"
        Dim dtKeyListSorted As DataTable = dtKeyByBat.DefaultView.ToTable.Copy

        Dim rowToCompare As DataRow
        Dim duplicateList As ArrayList = New ArrayList()
        Dim dtTemp As DataTable = New DataTable()
        dtTemp = dtKeyListSorted

        For Each drow As DataRow In dtTemp.Rows
            duplicateList.Add(drow)
        Next

        For Each r As DataRow In duplicateList
            Dim blnSimilar As Boolean = False
            If rowToCompare Is Nothing Then
                rowToCompare = r
            Else
                If r.Item("CID") = rowToCompare.Item("CID") Then
                    If r.Item("CStatus") = rowToCompare.Item("CStatus") Then
                        If r.Item("CPosition") = rowToCompare.Item("CPosition") Then
                            If r.Item("CTrousseau") = rowToCompare.Item("CTrousseau") Then
                                blnSimilar = True
                            End If
                        End If
                    End If
                End If
                If blnSimilar = True Then
                    rowToCompare.Item("Quantité") += 1
                    dtTemp.Rows.Remove(r)
                Else
                    rowToCompare = r
                End If
            End If
        Next
        dtKeyListSorted = dtTemp.Copy

        dtKeyListSorted.Columns("CID").ColumnName = strTitleCID
        dtKeyListSorted.Columns("CNom").ColumnName = strTitleCNom
        dtKeyListSorted.Columns("CPosition").ColumnName = strTitleCPosition
        dtKeyListSorted.Columns("CStatus").ColumnName = strTitleCStatus
        dtKeyListSorted.Columns("CTrousseau").ColumnName = strTitleCTrousseau
        dtKeyByBat.Clear()
        dtKeyByBat = dtKeyListSorted.Copy
        srcKeyByBat.DataSource = dtKeyList
        dgvResultats.DataSource = srcKeyByBat
        'dgvResultats.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgvResultats.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Try
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lblNbDeClefs.Text = intKeyAmount & " clefs chargées"
    End Sub

    Private Sub btnClefsPerdues_Click(sender As Object, e As EventArgs) Handles btnClefsPerdues.Click
        'ouverture du menu d'alerte
        AlertesEmpruntPerdu = 3
        frmClefsEmpruntsEtAlertes.ShowDialog()
    End Sub

    Private Sub btnPanierVersTrousseau_Click(sender As Object, e As EventArgs) Handles btnPanierVersTrousseau.Click
        If dgvPanier.Rows.Count > 0 Then
            frmTrousseauCreerOuRemplir.ShowDialog()
        ElseIf dgvResultats.SelectedRows.Count > 0 Then
            addToPanier()
            frmTrousseauCreerOuRemplir.ShowDialog()
        End If
    End Sub

End Class
