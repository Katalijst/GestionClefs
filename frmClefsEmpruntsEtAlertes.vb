Imports MaterialSkin
Imports MySql.Data.MySqlClient

Public Class frmClefsEmpruntsEtAlertes
    Shared nbEmprunts As Integer = 0
    Shared nbAttribuees As Integer = 0
    Shared nbPerdues As Integer = 0
    Shared nbNonRendues As Integer = 0

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmAlertes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMain.AlertesEmpruntPerdu = 1 Then
            'Alertes
            TabCtrlAlertesPerduesEmprunts.SelectedTab = tabAlertes
        ElseIf frmMain.AlertesEmpruntPerdu = 2 Then
            'Emprunt
            TabCtrlAlertesPerduesEmprunts.SelectedTab = tabEnCours
        ElseIf frmMain.AlertesEmpruntPerdu = 3 Then
            'Perdues
            TabCtrlAlertesPerduesEmprunts.SelectedTab = tabPerdues
        End If
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        BrightOrDarkMode()

        Dim strCBFiltre As String() = New String(2) {}
        strCBFiltre(0) = strTitleCID
        strCBFiltre(1) = strTitleCNom
        strCBFiltre(2) = "Emprunteur"
        cbRechercher.DataSource = strCBFiltre

        RefreshAlertes()
        RefreshEmprunt()
        RefreshPerdues()
        cbRechercher.SelectedIndex = 2
        chkAlertPopUp.Checked = My.Settings.ShowAlert
    End Sub

    Private Sub frmAlertes_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        frmMain.CheckAlerts()
        My.Settings.ShowAlert = chkAlertPopUp.Checked
        My.Settings.Save()
    End Sub

    Public Sub RefreshAlertes()
        Dim cmd As New MySqlCommand
        Dim cmdCount As New MySqlCommand
        Dim dt As New DataTable
        Dim dtAlertes As New DataTable
        Dim da As New MySqlDataAdapter
        Dim SqlCommand As String

        If GlobalServices <> "Global" Then
            SqlCommand = "SELECT COUNT(DISTINCT EIDClef) from Emprunts, Clefs INNER JOIN (SELECT STableau FROM Services, Login where SNom = LServices AND LUserName = @Username) temp ON Clefs.CPosition = temp.STableau WHERE EDateFin < DATE(NOW()) AND CID=EIDClef;"
            cmdCount.Parameters.Add("@Username", MySqlDbType.VarChar).Value = GlobalUserName
        Else
            SqlCommand = "Select COUNT(EIDClef) From Emprunts Where EDateFin < DATE(NOW());"
        End If

        Try
            dt.Reset()
            With cmdCount
                .Connection = connecter()
                .CommandText = SqlCommand
            End With
            da.SelectCommand = cmdCount
            da.Fill(dt)
            nbNonRendues = dt.Rows(0).Item(0)
            If nbNonRendues < 1 Then
                lblInfoRecherche.Text = "Aucune alerte."
            ElseIf nbNonRendues > 1 Then
                lblInfoRecherche.Text = nbNonRendues & " alertes."
            Else
                lblInfoRecherche.Text = "1 alerte."
            End If

            dtAlertes.Reset()
                cmd.Parameters.Add("@IDClef", MySqlDbType.VarChar)
            For i = 0 To dt.Rows.Count - 1
                With cmd
                    .Connection = connecter()
                    .Parameters("@IDClef").Value = dt.Rows(i)(0).ToString
                    If GlobalServices <> "Global" Then
                        .CommandText = "Select DISTINCT EIDClef, CNom, EIDGenre, ENomPersonne, EDateDebut, EDateFin from Emprunts, Clefs INNER JOIN (SELECT STableau FROM Services, Login where SNom = LServices AND LUserName = @Username) temp ON Clefs.CPosition = temp.STableau WHERE EDateFin < DATE(NOW()) AND CID=EIDClef;"
                        .Parameters.Add("@Username", MySqlDbType.VarChar).Value = GlobalUserName
                    Else
                        .CommandText = "Select EIDClef, CNom, EIDGenre, ENomPersonne, EDateDebut, EDateFin From Emprunts, Clefs Where CID=EIDClef AND EDatefin < DATE(NOW());"
                    End If
                End With
                da.SelectCommand = cmd
                da.Fill(dtAlertes)

                dtAlertes.Columns.Add("ID")

                For Each dr As DataRow In dtAlertes.Rows
                    Dim input As String = dr.Item("EIDClef")
                    Dim index As Integer = input.LastIndexOf("-")
                    If index > 0 Then
                        dr.Item("EIDClef") = input.Substring(0, index)
                        dr.Item("ID") = input.Substring(index + 1)
                    End If
                Next

            Next
            If dt.Rows.Count > 0 Then
                dtAlertes.Columns("EIDClef").ColumnName = strTitleCID
                dtAlertes.Columns("CNom").ColumnName = strTitleCNom
                dtAlertes.Columns("EIDGenre").ColumnName = strTitleEGenre
                dtAlertes.Columns("ENomPersonne").ColumnName = strTitleENomPersonne
                dtAlertes.Columns("EDateDebut").ColumnName = strTitleEDateDebut
                dtAlertes.Columns("EDateFin").ColumnName = strTitleEDateFin

                dgvAlertes.DataSource = dtAlertes
                dgvAlertes.Columns("ID").Visible = False
                dgvAlertes.Refresh()

            End If
        Catch ex As MySQLException
            MessageBox.Show(ex.Message)
        Finally
            connecter().Close()
        End Try
    End Sub

    Public Sub RefreshEmprunt()
        Dim dateNow As Date = Now

        Dim cmd As New MySqlCommand
        Dim dtEmprunt As New DataTable
        Dim da As New MySqlDataAdapter

        Try
            dtEmprunt.Reset()
            With cmd
                .Connection = connecter()
                If GlobalServices <> "Global" Then
                    .CommandText = "Select EIDClef, CNom, CStatus, CTrousseau, EIDGenre, ENomPersonne, EDateDebut, EDateFin from Emprunts, Clefs INNER JOIN (SELECT STableau FROM Services, Login where SNom = LServices AND LUserName = @Username) temp ON Clefs.CPosition = temp.STableau WHERE CID=EIDClef;"
                    .Parameters.Add("@Username", MySqlDbType.VarChar)
                    .Parameters("@Username").Value = GlobalUserName
                Else
                    .CommandText = "Select EIDClef, CNom, CStatus, CTrousseau, EIDGenre, ENomPersonne, EDateDebut, EDateFin From Emprunts, Clefs Where CID=EIDClef"
                End If
            End With
            da.SelectCommand = cmd
            da.Fill(dtEmprunt)
            nbEmprunts = dtEmprunt.Rows.Count
            Dim intAttribuees As Integer = 0
                dtEmprunt.Columns.Add("ID")
                For Each dr As DataRow In dtEmprunt.Rows
                    Dim input As String = dr.Item("EIDClef")
                    Dim index As Integer = input.LastIndexOf("-")
                    If index > 0 Then
                        dr.Item("EIDClef") = input.Substring(0, index)
                        dr.Item("ID") = input.Substring(index + 1)
                    End If
                    If dr.Item("CStatus") = "Attribuée" Then
                        intAttribuees += 1
                    End If
                Next
                nbAttribuees = intAttribuees

                dtEmprunt.Columns("EIDClef").ColumnName = strTitleCID
                dtEmprunt.Columns("CNom").ColumnName = strTitleCNom
                dtEmprunt.Columns("CStatus").ColumnName = strTitleCStatus
                dtEmprunt.Columns("EIDGenre").ColumnName = strTitleEGenre
                dtEmprunt.Columns("ENomPersonne").ColumnName = strTitleENomPersonne
                dtEmprunt.Columns("EDateDebut").ColumnName = strTitleEDateDebut
                dtEmprunt.Columns("EDateFin").ColumnName = strTitleEDateFin

                dgvEmpruntsEnCours.DataSource = dtEmprunt
                dgvEmpruntsEnCours.Columns("ID").Visible = False
                dgvEmpruntsEnCours.Refresh()
        Catch ex As MySQLException
            MessageBox.Show(ex.Message)
        Finally
            connecter().Close()
        End Try
    End Sub

    Public Sub RefreshPerdues()
        Dim cmd As New MySqlCommand
        Dim dtPerdues As New DataTable
        Dim da As New MySqlDataAdapter

        Try
            dtPerdues.Reset()
            With cmd
                .Connection = connecter()
                If GlobalServices <> "Global" Then
                    .CommandText = "Select CID, CNom, CTrousseau, CPosition, CBatiment From Clefs INNER JOIN (SELECT STableau FROM Services, Login where SNom = LServices AND LUserName = @Username) temp ON Clefs.CPosition = temp.STableau WHERE CStatus='Perdue'"
                    .Parameters.Add("@Username", MySqlDbType.VarChar)
                    .Parameters("@Username").Value = GlobalUserName
                Else
                    .CommandText = "Select CID, CNom, CTrousseau, CPosition, CBatiment From Clefs Where CStatus='Perdue'"
                End If
            End With
            da.SelectCommand = cmd
            da.Fill(dtPerdues)
            nbPerdues = dtPerdues.Rows.Count

            dtPerdues.Columns.Add("ID")
            For Each dr As DataRow In dtPerdues.Rows
                Dim input As String = dr.Item("CID")
                Dim index As Integer = input.LastIndexOf("-")
                If index > 0 Then
                    dr.Item("CID") = input.Substring(0, index)
                    dr.Item("ID") = input.Substring(index + 1)
                End If
            Next

            dtPerdues.Columns("CID").ColumnName = strTitleCID
            dtPerdues.Columns("CNom").ColumnName = strTitleCNom
            dtPerdues.Columns("CPosition").ColumnName = strTitleCPosition
            dtPerdues.Columns("CBatiment").ColumnName = strTitleCBatiment

            dgvClefsPerdues.DataSource = dtPerdues
            dgvClefsPerdues.Columns("ID").Visible = False
            dgvClefsPerdues.Refresh()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connecter().Close()
        End Try
    End Sub

    Private Sub dgvResultats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlertes.CellDoubleClick
        If dgvAlertes.SelectedRows.Count > 0 Then
            frmAlertesProprietes.ShowDialog()
        End If
    End Sub

    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvAlertes.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvAlertes.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvAlertes.PointToClient(Cursor.Position)
                menuAlertes.Show(dgvAlertes, mousePosition)
            End If
        End If
    End Sub

    Private Sub dgvClefsPerdues_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvClefsPerdues.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvClefsPerdues.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvClefsPerdues.PointToClient(Cursor.Position)
                menuPerdues.Show(dgvClefsPerdues, mousePosition)
            End If
        End If
    End Sub

    Private Sub dgvEmpruntsEnCours_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvEmpruntsEnCours.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvEmpruntsEnCours.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvEmpruntsEnCours.PointToClient(Cursor.Position)
                menuEmprunt.Show(dgvEmpruntsEnCours, mousePosition)
            End If
        End If
    End Sub

    Private Sub RetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourAlertesStripMenuItem.Click
        If dgvAlertes.SelectedRows.Count > 0 Then
            RetourClef(dgvAlertes.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & dgvAlertes.SelectedRows(0).Cells("ID").Value.ToString())
        End If
    End Sub

    Private Sub InformationsAlertesStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationsAlertesStripMenuItem.Click
        frmAlertesProprietes.ShowDialog()
    End Sub

    Private Sub ClefRetrouvéePerduesStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClefRetrouvéePerduesStripMenuItem.Click
        If dgvClefsPerdues.SelectedRows.Count > 0 Then
            ClefRetrouvee(dgvClefsPerdues.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & dgvClefsPerdues.SelectedRows(0).Cells("ID").Value.ToString())
        End If
    End Sub

    Private Sub InformationsPerduesStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationsPerduesStripMenuItem.Click
        frmAlertesProprietes.ShowDialog()
    End Sub

    Private Sub RetourEmpruntStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourEmpruntStripMenuItem.Click
        If dgvEmpruntsEnCours.SelectedRows.Count > 0 Then
            RetourClef(dgvEmpruntsEnCours.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & dgvEmpruntsEnCours.SelectedRows(0).Cells("ID").Value.ToString())
        End If
    End Sub

    Private Sub InformationsEmpruntStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InformationsEmpruntStripMenuItem2.Click
        frmAlertesProprietes.ShowDialog()
    End Sub

    Public Sub RetourClef(stgKeyID As String)
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim stgTrousseau As String = "Aucun"

        cmd.Parameters.Add("@IDClef", MySqlDbType.VarChar)
        Try
            sql = "Select CTrousseau From Clefs WHERE CID=@IDClef"
            With cmd
                .Connection = connecter()
                .Parameters("@IDClef").Value = stgKeyID
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
            RefreshAlertes()
            RefreshEmprunt()
            frmMain.FillDataSource()
        Catch ex As MySQLException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ClefRetrouvee(stgKeyID As String)
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim stgTrousseau As String = "Aucun"
        cmd.Parameters.Add("@IDClef", MySqlDbType.VarChar)
        Try
            sql = "Select CTrousseau From Clefs WHERE CID=@IDClef;"
            With cmd
                .Connection = connecter()
                .Parameters("@IDClef").Value = stgKeyID
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                stgTrousseau = dt.Rows(0).Item(0).ToString
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        If stgTrousseau = "Aucun" Then
            ' Initializes variables to pass to the MessageBox.Show method.
            Dim Message As String = "Confirmez vous que cette clef a été retrouvée ?"
            Dim Caption As String = "Clef retrouvée"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Question

            Dim Result As DialogResult

            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)

            ' Gets the result of the MessageBox display.
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Try
                    sql = "UPDATE Clefs SET CStatus = 'Disponible' WHERE CID=@IDClef;"
                    With cmd
                        .Connection = connecter()
                        .Parameters("@IDClef").Value = stgKeyID
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    RefreshPerdues()
                    frmMain.FillDataSource()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try
            Else
                Exit Sub
            End If
        Else
            Dim AmountLost As Integer = 0
            Try
                dt.Clear()
                sql = "Select COUNT(CID) From Clefs WHERE CTrousseau=(Select CTrousseau From Clefs WHERE CID=@IDClef) AND CStatus=(Select CStatus From Clefs WHERE CID=@IDClef) AND CTrousseau <> 'Aucun';"
                With cmd
                    .Connection = connecter()
                    .Parameters("@IDClef").Value = stgKeyID
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    AmountLost = dt.Rows(0).Item("COUNT(CID)")
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
            If AmountLost > 1 Then
                ' Initializes variables to pass to the MessageBox.Show method.
                Dim Message As String = "Cette clef fait partie d'un trousseau, voulez vous passez tout le trousseau au status ""Disponible"" ?"
                Dim Caption As String = "Clef retrouvée"
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Icon As MessageBoxIcon = MessageBoxIcon.Question

                Dim Result As DialogResult

                'Displays the MessageBox
                Result = MessageBox.Show(Message, Caption, Buttons, Icon)

                ' Gets the result of the MessageBox display.
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    cmd.Parameters.Add("@Trousseau", MySqlDbType.VarChar)
                    Try
                        sql = "UPDATE Clefs SET CStatus = 'Disponible' WHERE Ctrousseau=@Trousseau"
                        With cmd
                            .Connection = connecter()
                            .Parameters("@Trousseau").Value = stgTrousseau
                            .CommandText = sql
                            .ExecuteNonQuery()
                        End With
                        RefreshPerdues()
                        frmMain.FillDataSource()
                    Catch ex As MySqlException
                        MsgBox(ex.Message)
                    End Try
                Else
                    Exit Sub
                End If
            Else
                Try
                    sql = "UPDATE Clefs SET CStatus = 'Disponible' WHERE CID=@IDClef"
                    With cmd
                        .Connection = connecter()
                        .Parameters("@IDClef").Value = stgKeyID
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                    RefreshPerdues()
                    frmMain.FillDataSource()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndex As Integer = 1

        If cbRechercher.Text = strTitleCID Then
            intIndex = 0
        ElseIf cbRechercher.Text = strTitleCNom Then
            intIndex = 1
        ElseIf cbRechercher.Text = "Emprunteur" Then
            intIndex = 3
        End If

        Try
            For i = 0 To dgvAlertes.RowCount - 1
                If dgvAlertes.Rows(i).Cells(intIndex).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvAlertes.Rows(i).Selected = True
                    dgvAlertes.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
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
            For Each c As ToolStripMenuItem In menuAlertes.Items.OfType(Of ToolStripMenuItem)
                If c.Image IsNot Nothing Then
                    Dim bmp As Bitmap = c.Image
                    c.Image = setColorToBitmap(bmp, Color.Black, Color.White)
                End If
            Next
            menuAlertes.BackColor = ColorTranslator.FromHtml("#505050")
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
            For Each c As ToolStripMenuItem In menuAlertes.Items.OfType(Of ToolStripMenuItem)
                If c.Image IsNot Nothing Then
                    Dim bmp As Bitmap = c.Image
                    c.Image = setColorToBitmap(bmp, Color.White, Color.Black)
                End If
            Next
            menuAlertes.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        End If

    End Sub

    Private Sub TabCtrlAlertesPerduesEmprunts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabCtrlAlertesPerduesEmprunts.SelectedIndexChanged
        If TabCtrlAlertesPerduesEmprunts.SelectedTab Is tabAlertes Then 'Index Alertes = 2
            lblInfoRecherche.Text = nbNonRendues & " clefs non rendues !"
            chkAlertPopUp.Visible = True
        Else
            chkAlertPopUp.Visible = False
            If TabCtrlAlertesPerduesEmprunts.SelectedTab Is tabEnCours Then 'Index Emprunt en cours = 0
                lblInfoRecherche.Text = nbEmprunts & " emprunts en cours, dont " & nbAttribuees & " attributions."
            Else
                lblInfoRecherche.Text = nbPerdues & " clefs perdues."
            End If
        End If
    End Sub

End Class