Imports MaterialSkin
Imports MySql.Data.MySqlClient

Public Class frmEmpruntsEtAlertes
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
        strCBFiltre(2) = strTitleENomPersonne
        cbRechercher.DataSource = strCBFiltre

        RefreshAlertes()
        cbRechercher.SelectedIndex = 1
        chkAlertPopUp.Checked = My.Settings.ShowAlert
    End Sub

    Private Sub frmAlertes_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        frmMain.CheckAlerts()
        My.Settings.ShowAlert = chkAlertPopUp.Checked
        My.Settings.Save()
    End Sub

    Public Sub RefreshAlertes()
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
                .CommandText = "Select EIDClef, EDateFin From Emprunts Where EDateFin < DATE(NOW())"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            lblAlertes.Text = "Aucune alerte."
            If dt.Rows.Count > 0 Then
                lblAlertes.Text = dt.Rows.Count & " clefs non rendues !"
                dtAlertes.Reset()
                cmd.Parameters.Add("@IDClef", MySqlDbType.VarChar)
                For i = 0 To dt.Rows.Count - 1
                    With cmd
                        .Connection = connecter()
                        .Parameters("@IDClef").Value = dt.Rows(i)(0).ToString
                        .CommandText = "Select EIDClef, CNom, EIDGenre, ENomPersonne, EDateDebut, EDateFin From Emprunts, Clefs Where EIDClef=@IDClef AND CID=EIDClef AND EDatefin < DATE(NOW() + 1);"
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
                dtAlertes.Columns("EIDClef").ColumnName = strTitleCID
                dtAlertes.Columns("CNom").ColumnName = strTitleCNom
                dtAlertes.Columns("EIDGenre").ColumnName = strTitleEGenre
                dtAlertes.Columns("ENomPersonne").ColumnName = strTitleENomPersonne
                dtAlertes.Columns("EDateDebut").ColumnName = strTitleEDateDebut
                dtAlertes.Columns("EDateFin").ColumnName = strTitleEDateFin

                dgvAlertes.DataSource = dtAlertes
            Else
                dgvAlertes.Rows.Clear()
                dgvAlertes.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connecter().Close()
        End Try
    End Sub

    Public Sub RefreshEmprunt()
        Dim dateNow As Date = Now

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim dtEmprunt As New DataTable
        Dim da As New MySqlDataAdapter


        Dim sql As String = "Select EIDClef, EDateFin From Emprunts Where EDateFin IS NOT NULL"

        Try
            dt.Reset()
            With cmd
                .Connection = connecter()
                .CommandText = "Select EIDClef, EDateFin From Emprunts Where EDateFin IS NOT NULL"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dtEmprunt.Reset()
                cmd.Parameters.Add("@IDClef", MySqlDbType.VarChar)
                For i = 0 To dt.Rows.Count - 1
                    With cmd
                        .Connection = connecter()
                        .Parameters("@IDClef").Value = dt.Rows(i)(0).ToString
                        .CommandText = "Select EIDClef, CNom, EIDGenre, ENomPersonne, EDateDebut, EDateFin From Emprunts, Clefs Where EIDClef=@IDClef AND CID=EIDClef"
                    End With
                    da.SelectCommand = cmd
                    Dim dtTemp As New DataTable
                    da.Fill(dtTemp)
                    For Each dr As DataRow In dtTemp.Rows
                        If dtEmprunt.Rows.Count < 1 Then
                            dtEmprunt = dtTemp
                        Else
                            dtEmprunt.Rows.Add(dr.ItemArray)
                        End If
                    Next
                Next
                dtEmprunt.Columns("EIDClef").ColumnName = strTitleCID
                dtEmprunt.Columns("CNom").ColumnName = strTitleCNom
                dtEmprunt.Columns("EIDGenre").ColumnName = strTitleEGenre
                dtEmprunt.Columns("ENomPersonne").ColumnName = strTitleENomPersonne
                dtEmprunt.Columns("EDateDebut").ColumnName = strTitleEDateDebut
                dtEmprunt.Columns("EDateFin").ColumnName = strTitleEDateFin
                dgvEmpruntsEnCours.DataSource = dtEmprunt
            Else
                dgvEmpruntsEnCours.Rows.Clear()
                dgvEmpruntsEnCours.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connecter().Close()
        End Try
    End Sub

    Private Sub dgvResultats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlertes.CellDoubleClick
        If dgvAlertes.SelectedRows.Count > 0 Then
            frmPropAlertes.ShowDialog()
        End If
    End Sub
    Private Sub dgvResultats_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvAlertes.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvAlertes.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvAlertes.PointToClient(Cursor.Position)
                menuGrid.Show(dgvAlertes, mousePosition)
            End If
        End If
    End Sub

    Private Sub RetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourToolStripMenuItem.Click
        If dgvAlertes.SelectedRows.Count > 0 Then
            RetourClef(dgvAlertes.SelectedRows(0).Cells(strTitleCID).Value.ToString())
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
            RefreshAlertes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PropriétésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriétésToolStripMenuItem.Click
        frmPropAlertes.ShowDialog()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercherAlertes.TextChanged
        Dim searchValue As String = txtRechercherAlertes.Text
        Dim intIndex As Integer = 1

        If cbRechercher.Text = strTitleCID Then
            intIndex = 0
        ElseIf cbRechercher.Text = strTitleCNom Then
            intIndex = 1
        ElseIf cbRechercher.Text = strTitleENomPersonne Then
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
            For Each c As ToolStripMenuItem In menuGrid.Items.OfType(Of ToolStripMenuItem)
                If c.Image IsNot Nothing Then
                    Dim bmp As Bitmap = c.Image
                    c.Image = setColorToBitmap(bmp, Color.Black, Color.White)
                End If
            Next
            menuGrid.BackColor = ColorTranslator.FromHtml("#505050")
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
        End If

    End Sub

End Class