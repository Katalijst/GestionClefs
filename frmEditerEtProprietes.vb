Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class frmEditerEtProprietes
    Shared intOldQuantity As Integer
    Shared stgKeyId As String
    Shared stgStatus As String
    Public IDToLookFor As String
    Public IDClef As String = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCID).Value
    Private Sub frmEditKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intOldQuantity = frmMain.dgvResultats.SelectedRows(0).Cells("Quantité").Value
        stgStatus = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCStatus).Value
        IDToLookFor = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCID).Value & "-%"
        IDClef = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCID).Value

        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)

        lblBatiment.Visible = False
        btnGrpBatiment.Visible = False
        lblCID.Text = strTitleCID & " :"
        lblCNom.Text = strTitleCNom & " :"
        lblCPosition.Text = strTitleCPosition & " :"
        lblCStatus.Text = strTitleCStatus & " :"
        lblCTrousseau.Text = strTitleCTrousseau & " :"
        lblCDate.Text = strTitleCDate & " :"
        txtID.Hint = strTitleCID
        txtNom.Hint = strTitleCNom
        cmbLoc.Hint = strTitleCPosition
        'txtStatus.Hint = strTitleCStatus
        cmbTrousseauListe.Hint = strTitleCTrousseau
        If frmMain.blnProperties = False Then
            AddHandler btnSave.Click, AddressOf Edit_btnSave_Click
        Else
            AddHandler btnSave.Click, AddressOf Properties_btnSave_Click
            btnSave.Text = "OK"
            swtEditOneKey.Visible = False
            txtID.Enabled = False
            txtQuantity.Enabled = False
            txtNom.Enabled = False
            cmbLoc.Enabled = False
            cmbStatus.Enabled = False
            dtpDate.Enabled = False
            cmbTrousseauListe.Enabled = False
            txtRefOrg.Enabled = False
            txtCnInt.Enabled = False
            txtCnExt.Enabled = False
            txtCnOpt.Enabled = False
            txtEmprunteur.Enabled = False
            txtTel.Enabled = False
            dtpDebut.Enabled = False
            dtpFin.Enabled = False
            btnNewLoc.Enabled = False
            btnNewTrousseau.Enabled = False
            btnNewLoc.Visible = False
            btnNewTrousseau.Visible = False
            Me.Text = "Informations"
        End If

        LoadAndRefresh()
    End Sub

    Public Sub RefreshTrousseau()
        cmbTrousseauListe.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Trousseau where TNom <> 'Aucun';"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim newRow As DataRow = dt.NewRow()
            newRow(0) = "Aucun"
            dt.Rows.InsertAt(newRow, 0)
            For Each r As DataRow In dt.Rows
                cmbTrousseauListe.Items.Add(r.Item(0).ToString)
            Next

            'cmbTrousseauListe.DataSource = dt
            'cmbTrousseauListe.ValueMember = dt.Columns(0).ToString
            'cmbTrousseauListe.DisplayMember = strTitleTNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshPosition()
        cmbLoc.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Position;"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                cmbLoc.Items.Add(r.Item(0).ToString)
            Next

            'cmbLoc.DataSource = dt
            'cmbLoc.ValueMember = dt.Columns(0).ToString
            'cmbLoc.DisplayMember = strTitlePNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAndRefresh()
        Dim blnOption As Boolean = False

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text

        txtID.Text = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCID).Value
        RefreshTrousseau()
        RefreshPosition()

        cmbStatus.Items.Add(frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCStatus).Value)
        cmbStatus.Items.Add("Perdue")
        cmbStatus.SelectedIndex() = 0
        cmbLoc.SelectedItem = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCPosition).Value
        cmbTrousseauListe.SelectedItem = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCTrousseau).Value
        txtQuantity.Text = frmMain.dgvResultats.SelectedRows(0).Cells("Quantité").Value

        With cmd
            .Parameters.Add("@IDClef", MySqlDbType.String)
            .Parameters.Add("@StatusClef", MySqlDbType.VarChar)
            .Parameters.Add("@TableauClef", MySqlDbType.VarChar)
            .Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)
        End With
        Try
            dt.Reset()
            sql = "SELECT CID FROM Clefs WHERE CID LIKE @IDClef AND CStatus=@StatusClef AND CPosition=@TableauClef AND CTrousseau=@TrousseauxClef LIMIT 1;"
            With cmd
                .Parameters("@IDClef").Value = IDToLookFor
                .Parameters("@StatusClef").Value = stgStatus
                .Parameters("@TableauClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCPosition).Value
                .Parameters("@TrousseauxClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCTrousseau).Value
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            stgKeyId = dt.Rows(0)(0)

            dt.Reset()
            sql = "Select CNom, CDate, CBatiment FROM Clefs WHERE CID like @IDClef;"
            With cmd
                .Parameters("@IDClef").Value = stgKeyId
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtNom.Text = dt.Rows(0).Item(0)
            Dim stgDate As String = dt.Rows(0).Item(1)
            Dim newDate As DateTime = Convert.ToDateTime(stgDate)
            Dim batiment As String = dt.Rows(0).Item(2)

            If batiment = "Groupe de Batiments" Then
                lblBatiment.Visible = False
                btnGrpBatiment.Visible = True
                btnGrpBatiment.Enabled = True
            Else
                lblBatiment.Visible = True
                lblBatiment.Text = batiment
                btnGrpBatiment.Visible = False
                btnGrpBatiment.Enabled = False
            End If

            dt.Reset()
            sql = "Select RefOrg, CanonInte, CanonExte, CanonOpt FROM InfosTechniques WHERE IDClef=@IDClef;"
            With cmd
                .Parameters("@IDClef").Value = IDClef
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                blnOption = True
                txtRefOrg.Text = dt.Rows(0).Item(0)
                If Not IsDBNull(dt.Rows(0).Item(1)) Then
                    txtCnInt.Text = dt.Rows(0).Item(1)
                Else
                    txtCnInt.Text = ""
                End If
                If Not IsDBNull(dt.Rows(0).Item(2)) Then
                    txtCnExt.Text = dt.Rows(0).Item(2)
                Else
                    txtCnExt.Text = ""
                End If
                txtCnOpt.Text = dt.Rows(0).Item(3)
            End If

            If stgStatus <> "Disponible" And stgStatus <> "Perdue" Then
                dt.Reset()
                sql = "SELECT EIDGenre, ENomPersonne, EDateDebut, EDateFin, NTelephone FROM Emprunts, NomPersonne WHERE EIDClef=@IDClef AND ENomPersonne = NNom;"
                With cmd
                    .Parameters("@IDClef").Value = stgKeyId
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                txtEmprunteur.Text = dt.Rows(0).Item(1)
                txtTel.Text = dt.Rows(0).Item(4)
                dtpDebut.Value = dt.Rows(0).Item(2)

                txtTel.Visible = True
                lblEmprunteur.Visible = True
                txtEmprunteur.Visible = True
                lblDateDebut.Visible = True
                dtpDebut.Visible = True
                If stgStatus = "Empruntée" Then
                    dtpFin.Value = dt.Rows(0).Item(3)
                    lblEmprunteur.Text = "Emprunteur :"
                    dtpFin.Visible = True
                    lblDateFin.Visible = True
                ElseIf stgStatus = "Attribuée" Then
                    lblEmprunteur.Text = "Attribuée à :"
                    dtpFin.Visible = False
                    lblDateFin.Visible = False
                End If
            Else
                lblEmprunteur.Visible = False
                txtEmprunteur.Visible = False
                dtpDebut.Visible = False
                lblDateDebut.Visible = False
                dtpFin.Visible = False
                lblDateFin.Visible = False
                txtTel.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connecter().Close()
        End Try

    End Sub

    Private Sub frmEditKey_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Private Sub Edit_btnSave_Click(sender As Object, e As EventArgs)
        Try
            If txtQuantity.Text = "0" Or txtQuantity.Text = "" Then
                MsgBox("La quantité ne peut être nul !")
                Exit Sub
            End If
            Dim blnInfTech As Boolean = True
            Dim da As New MySqlDataAdapter
            Dim sql As String
            Dim cmdUpdateClef As New MySqlCommand
            Dim cmdUpdateInfosTechniques As New MySqlCommand
            cmdUpdateClef.CommandType = CommandType.Text

            With cmdUpdateClef
                .Parameters.Add("@IDClef", MySqlDbType.String)
                .Parameters.Add("@Nom", MySqlDbType.VarChar)
                .Parameters.Add("@Tableau", MySqlDbType.VarChar)
                .Parameters.Add("@Date", MySqlDbType.Date)
                .Parameters.Add("@Trousseau", MySqlDbType.VarChar)
                .Parameters.Add("@OldStatusClef", MySqlDbType.VarChar)
                .Parameters.Add("@OldTableauClef", MySqlDbType.VarChar)
                .Parameters.Add("@OldTrousseauxClef", MySqlDbType.VarChar)
            End With

            cmdUpdateInfosTechniques.Parameters.Add("@IDClef", MySqlDbType.VarChar)
            If txtRefOrg.Text = "" And txtCnExt.Text = "" And txtCnInt.Text = "" And txtCnOpt.Text = "" Then
                blnInfTech = False
                cmdUpdateInfosTechniques.CommandText = "DELETE FROM InfosTechniques WHERE IDClef = @IDClef;"
            Else
                blnInfTech = True
                With cmdUpdateInfosTechniques
                    .Parameters.Add("@RefOrg", MySqlDbType.VarChar)
                    .Parameters.Add("@CanonInte", MySqlDbType.Int16)
                    .Parameters.Add("@CanonExte", MySqlDbType.Int16)
                    .Parameters.Add("@CanonOpt", MySqlDbType.VarChar)
                    .CommandText = "INSERT INTO InfosTechniques(IDClef, RefOrg, CanonInte, CanonExte, CanonOpt) VALUES (@IDClef,@RefOrg,@CanonInte,@CanonExte,@CanonOpt)
                                ON DUPLICATE KEY UPDATE IDClef = @IDClef, RefOrg = @RefOrg, CanonInte = @CanonInte, CanonExte = @CanonExte, CanonOpt = @CanonOpt;"
                End With
            End If

            If swtEditOneKey.Checked = False Then 'Editer toutes les clefs
                sql = "UPDATE Clefs SET CNom = @Nom, CPosition = @Tableau, CDate = @Date, CTrousseau = @Trousseau WHERE CID LIKE @IDClef AND CStatus=@OldStatusClef AND CPosition=@OldTableauClef AND CTrousseau=@OldTrousseauxClef;"
                With cmdUpdateClef
                    .Parameters("@IDClef").Value = txtID.Text & "-%"
                    .Parameters("@Nom").Value = txtNom.Text
                    .Parameters("@Tableau").Value = cmbLoc.Text
                    .Parameters("@Date").Value = dtpDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                    .Parameters("@Trousseau").Value = cmbTrousseauListe.Text
                    .Parameters("@OldStatusClef").Value = stgStatus
                    .Parameters("@OldTableauClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCPosition).Value
                    .Parameters("@OldTrousseauxClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCTrousseau).Value
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With


                cmdUpdateInfosTechniques.Parameters("@IDClef").Value = txtID.Text
                If blnInfTech = True Then
                    Dim intCnInt As Integer
                    Dim intCnExt As Integer

                    With cmdUpdateInfosTechniques
                        .Parameters("@RefOrg").Value = txtRefOrg.Text
                        If Not Integer.TryParse(txtCnInt.Text, intCnInt) Then
                            .Parameters("@CanonInte").Value = DBNull.Value
                        Else
                            .Parameters("@CanonInte").Value = intCnInt
                        End If
                        If Not Integer.TryParse(txtCnExt.Text, intCnExt) Then
                            .Parameters("@CanonExte").Value = DBNull.Value
                        Else
                            .Parameters("@CanonExte").Value = intCnExt
                        End If
                        .Parameters("@CanonOpt").Value = txtCnOpt.Text
                    End With
                End If
                cmdUpdateInfosTechniques.Connection = connecter()
                cmdUpdateInfosTechniques.ExecuteNonQuery()

                '
                ' AJOUTER LE CHANGEMENT POUR LA QUANTITÉ
                '
                Dim LastKeyID As Integer = 0
                Dim cmd As String = "Select CID, CNom, CBatiment from Clefs Where CID like @IDClef;"
                Dim dtListClefs As DataTable = New DataTable()
                Dim getKeyID_command As New MySqlCommand(cmd, connecter())
                getKeyID_command.CommandType = CommandType.Text
                da.InsertCommand = getKeyID_command

                With getKeyID_command
                    .Parameters.Add("@IDClef", MySqlDbType.String)
                End With
                connecter()

                Try
                    getKeyID_command.Parameters("@IDClef").Value = IDToLookFor
                    getKeyID_command.ExecuteNonQuery()
                Catch ex As MySqlException
                    'Retour d'une erreur my MySQL si connection impossible
                    MsgBox((ex.Number & " - " & ex.Message))
                End Try
                da.SelectCommand = getKeyID_command
                da.Fill(dtListClefs)
                If dtListClefs.Rows.Count > 0 Then
                    For Each r As DataRow In dtListClefs.Rows
                        Dim input As String = r.Item("CID")
                        Dim index As Integer = input.LastIndexOf("-")
                        If index > 0 Then
                            Dim TempInt As Integer
                            Integer.TryParse(input.Substring(index + 1), TempInt)
                            If TempInt > LastKeyID Then
                                LastKeyID = TempInt
                            End If
                        End If
                    Next
                    Dim intQuantity As Integer = CUInt(txtQuantity.Text)

                    If intQuantity > intOldQuantity Then
                        Dim daSql As MySqlDataAdapter = New MySqlDataAdapter()
                        Dim cmdinsert As String = "INSERT INTO
                                                              `Clefs`(
                                                                `CID`,
                                                                `CNom`,
                                                                `CPosition`,
                                                                `CStatus`,
                                                                `CDate`,
                                                                `CTrousseau`,
                                                                `CBatiment`
                                                              )
                                                            VALUES
                                                              (
                                                                @id,
                                                                @name,
                                                                @pos,
                                                                @status,
                                                                @date,
                                                                @trousseau,
                                                                @batiment
                                                              );"
                        Dim insert_command As New MySqlCommand(cmdinsert, connecter())
                        insert_command.CommandType = CommandType.Text
                        daSql.InsertCommand = insert_command

                        With insert_command
                            .Parameters.Add("@id", MySqlDbType.VarChar)
                            .Parameters.Add("@name", MySqlDbType.VarChar)
                            .Parameters.Add("@pos", MySqlDbType.VarChar)
                            .Parameters.Add("@status", MySqlDbType.VarChar)
                            .Parameters.Add("@date", MySqlDbType.DateTime)
                            .Parameters.Add("@trousseau", MySqlDbType.VarChar)
                            .Parameters.Add("@batiment", MySqlDbType.VarChar)
                        End With

                        Dim i As Integer = 0
                        For i = 1 + LastKeyID To (LastKeyID + intQuantity - intOldQuantity)
                            With insert_command
                                .Parameters("@id").Value = txtID.Text.ToUpper(CultureInfo.InvariantCulture) & "-" & i
                                .Parameters("@name").Value = txtNom.Text
                                .Parameters("@pos").Value = cmbLoc.Text
                                .Parameters("@status").Value = cmbStatus.Text
                                .Parameters("@date").Value = dtpDate.Value
                                If cmbTrousseauListe.SelectedIndex <> -1 Then
                                    .Parameters("@trousseau").Value = cmbTrousseauListe.Text
                                Else
                                    .Parameters("@trousseau").Value = "Aucun"
                                End If
                                If lblBatiment.Visible = True Then
                                    .Parameters("@batiment").Value = lblBatiment.Text
                                Else
                                    .Parameters("@batiment").Value = "Groupe de Batiments"
                                End If
                                .ExecuteNonQuery()
                            End With
                        Next
                    ElseIf intQuantity < intOldQuantity Then
                        Dim AmountToDelete As Integer = intOldQuantity - intQuantity
                        Dim daSql As MySqlDataAdapter = New MySqlDataAdapter()
                        Dim DeleteQuery As String = "DELETE FROM Clefs WHERE CID LIKE @IDClef AND CStatus=@StatusClef AND CPosition=@TableauClef AND CTrousseau=@TrousseauxClef LIMIT " & AmountToDelete & ";"
                        Dim Delete_command As New MySqlCommand(DeleteQuery, connecter)
                        Delete_command.CommandType = CommandType.Text
                        daSql.InsertCommand = Delete_command

                        With Delete_command
                            .Parameters.Add("@IDClef", MySqlDbType.String)
                            .Parameters.Add("@StatusClef", MySqlDbType.VarChar)
                            .Parameters.Add("@TableauClef", MySqlDbType.VarChar)
                            .Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)
                        End With
                        With Delete_command
                            .Parameters("@IDClef").Value = txtID.Text & "-%"
                            .Parameters("@StatusClef").Value = cmbStatus.Text
                            .Parameters("@TableauClef").Value = cmbLoc.Text
                            If cmbTrousseauListe.SelectedIndex <> -1 Then
                                .Parameters("@TrousseauxClef").Value = cmbTrousseauListe.Text
                            Else
                                .Parameters("@TrousseauxClef").Value = "Aucun"
                            End If
                            .ExecuteNonQuery()
                        End With
                    End If
                End If

            Else 'Editer une seule clef

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connecter().Close()
            frmMain.FillDataSource()
            Me.Dispose()
        End Try
    End Sub
    Private Sub Properties_btnSave_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnNewTrousseau_Click(sender As Object, e As EventArgs) Handles btnNewTrousseau.Click
        frmCreerTrousseau.ShowDialog()
    End Sub

    Private Sub btnNewLoc_Click(sender As Object, e As EventArgs) Handles btnNewLoc.Click
        frmGestionPosition.ShowDialog()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGrpBatiment_Click(sender As Object, e As EventArgs) Handles btnGrpBatiment.Click
        frmPropGpBat.ShowDialog()
    End Sub

    Private Sub swtEditOneKey_CheckedChanged(sender As Object, e As EventArgs) Handles swtEditOneKey.CheckedChanged
        If swtEditOneKey.Checked = True Then
            txtQuantity.Enabled = False
            txtRefOrg.Enabled = False
            txtCnExt.Enabled = False
            txtCnInt.Enabled = False
            txtCnOpt.Enabled = False
        Else
            txtQuantity.Enabled = True
            txtRefOrg.Enabled = True
            txtCnExt.Enabled = True
            txtCnInt.Enabled = True
            txtCnOpt.Enabled = True
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.Text = "Disponible" Then
            txtQuantity.Enabled = True
        Else
            txtQuantity.Text = intOldQuantity
            txtQuantity.Enabled = False
        End If

    End Sub

End Class