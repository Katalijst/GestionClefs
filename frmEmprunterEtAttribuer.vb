Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class frmEmprunterEtAttribuer

    'Voir comment faire si clef dans trousseau

    Private Sub frmEmprunterEtAttribuer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        CreateKeyControls()
        If frmMain.blnEmprunt = True Then
            cbEmprunterAttribuerGlobal.SelectedIndex = 0
        Else
            cbEmprunterAttribuerGlobal.SelectedIndex = 1
        End If
        LoadPersonnes()
    End Sub
    Private Sub frmEmprunterEtAttribuer_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Public Sub CreateKeyControls()
        Dim dt As DataTable = frmMain.dtPanier

        Dim i As Integer = 0
        For Each r As DataRow In dt.Rows
            Dim intY As Integer = (29 + 30) * i
            Dim dvLigne = New MaterialSkin.Controls.MaterialDivider()
            Dim cbEmprunterAttribuer = New MaterialSkin.Controls.MaterialComboBox()
            Dim txtKeyID = New MaterialSkin.Controls.MaterialTextBox()
            Dim dtFin = New System.Windows.Forms.DateTimePicker()
            Dim dtDebut = New System.Windows.Forms.DateTimePicker()
            Dim btnDelete = New MaterialSkin.Controls.MaterialButton()

            '
            'dvLigne
            '
            dvLigne.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            dvLigne.Depth = 0
            dvLigne.Location = New System.Drawing.Point(4, (0 + intY))
            dvLigne.MouseState = MaterialSkin.MouseState.HOVER
            dvLigne.Name = "dvLigne-" & i
            dvLigne.Size = New System.Drawing.Size(615, 1)
            dvLigne.TabIndex = 0
            dvLigne.Text = ""
            '
            'cbEmprunterAttribuer
            '
            cbEmprunterAttribuer.AutoResize = False
            cbEmprunterAttribuer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            cbEmprunterAttribuer.Depth = 0
            cbEmprunterAttribuer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            cbEmprunterAttribuer.DropDownHeight = 118
            cbEmprunterAttribuer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cbEmprunterAttribuer.DropDownWidth = 121
            cbEmprunterAttribuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            cbEmprunterAttribuer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            cbEmprunterAttribuer.FormattingEnabled = True
            cbEmprunterAttribuer.Hint = "Emprunt"
            cbEmprunterAttribuer.IntegralHeight = False
            cbEmprunterAttribuer.ItemHeight = 29
            cbEmprunterAttribuer.Items.AddRange(New Object() {"Emprunt", "Attribution"})
            cbEmprunterAttribuer.Location = New System.Drawing.Point(13, (14 + intY))
            cbEmprunterAttribuer.MaxDropDownItems = 4
            cbEmprunterAttribuer.MouseState = MaterialSkin.MouseState.OUT
            cbEmprunterAttribuer.Name = "cbEmprunterAttribuer-" & i
            cbEmprunterAttribuer.Size = New System.Drawing.Size(146, 35)
            cbEmprunterAttribuer.TabIndex = 0
            cbEmprunterAttribuer.UseAccent = False
            cbEmprunterAttribuer.UseTallSize = False
            '
            'txtKeyID
            '
            txtKeyID.BorderStyle = System.Windows.Forms.BorderStyle.None
            txtKeyID.Depth = 0
            txtKeyID.Enabled = False
            txtKeyID.Font = New System.Drawing.Font("Roboto", 12.0!)
            txtKeyID.Location = New System.Drawing.Point(165, (14 + intY))
            txtKeyID.MaxLength = 50
            txtKeyID.MouseState = MaterialSkin.MouseState.OUT
            txtKeyID.Multiline = False
            txtKeyID.Name = "txtKeyID-" & i
            txtKeyID.Size = New System.Drawing.Size(131, 36)
            txtKeyID.TabIndex = 1
            txtKeyID.UseTallSize = False
            '
            'dtFin
            '
            dtFin.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtFin.Location = New System.Drawing.Point(435, (17 + intY))
            dtFin.Name = "dtFin-" & i
            dtFin.Size = New System.Drawing.Size(127, 29)
            dtFin.TabIndex = 2
            '
            'dtDebut
            '
            dtDebut.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtDebut.Location = New System.Drawing.Point(302, (17 + intY))
            dtDebut.Name = "dtDebut-" & i
            dtDebut.Size = New System.Drawing.Size(127, 29)
            dtDebut.TabIndex = 3
            '
            'btnDelete
            '
            btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            btnDelete.Depth = 0
            btnDelete.DrawShadows = True
            btnDelete.HighEmphasis = False
            btnDelete.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
            btnDelete.Location = New System.Drawing.Point(569, (13 + intY))
            btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER
            btnDelete.Name = "btnDelete-" & i
            btnDelete.Size = New System.Drawing.Size(44, 36)
            btnDelete.TabIndex = 4
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
            btnDelete.UseAccentColor = False
            btnDelete.UseVisualStyleBackColor = True

            Panel1.Controls.Add(dvLigne)
            Panel1.Controls.Add(cbEmprunterAttribuer)
            Panel1.Controls.Add(txtKeyID)
            Panel1.Controls.Add(dtFin)
            Panel1.Controls.Add(dtDebut)
            Panel1.Controls.Add(btnDelete)

            AddHandler btnDelete.Click, AddressOf btnDelete_click
            AddHandler cbEmprunterAttribuer.SelectedIndexChanged, AddressOf cbEmprunterAttribuer_SelectedIndexChanged

            If frmMain.blnEmprunt = True Then
                cbEmprunterAttribuer.SelectedIndex = 0
            Else
                cbEmprunterAttribuer.SelectedIndex = 1
            End If

            txtKeyID.Text = r.Item(strTitleCID)

            If swtReglageIndividuelle.Checked = False Then
                cbEmprunterAttribuer.Enabled = False
                dtDebut.Enabled = False
                dtFin.Enabled = False
                If cbEmprunterAttribuer.SelectedIndex = 0 Then
                    dtFin.Visible = True
                Else
                    dtFin.Visible = False
                End If
            Else
                cbEmprunterAttribuer.Enabled = True
                dtDebut.Enabled = True
                If cbEmprunterAttribuer.SelectedIndex = 0 Then
                    dtFin.Enabled = True
                    dtFin.Visible = True
                Else
                    dtFin.Enabled = False
                    dtFin.Visible = False
                End If
            End If

            i += 1
        Next
    End Sub

    Private Sub btnDelete_click(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControl As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControl = stgNomControle.Substring((index + 1))
        End If

        Dim strTxtKeyID As String = "txtKeyID-" & intIndexControl
        Dim controls0 As Control() = Me.Controls.Find(strTxtKeyID, True)
        If controls0.Length = 1 Then
            Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = TryCast(controls0(0), MaterialSkin.Controls.MaterialTextBox)
            If txtKeyID IsNot Nothing Then
                Dim dr As DataRow = frmMain.dtPanier.Rows(intIndexControl)
                frmMain.dtKeyList.Rows.Add(dr.ItemArray)
                frmMain.dtKeyList.AcceptChanges()
                frmMain.dtKeyList.DefaultView.Sort = frmMain.dtKeyList.Columns(0).ColumnName & " ASC"
                frmMain.dtPanier.Rows.Remove(frmMain.dtPanier.Rows(intIndexControl))
                frmMain.dtPanier.AcceptChanges()
                frmMain.dgvPanier.DataSource = frmMain.srcPanier
                frmMain.dgvResultats.DataSource = frmMain.srcKeyList
                Panel1.Controls.Clear()
                CreateKeyControls()
            End If
        End If
    End Sub

    Private Sub cbEmprunterAttribuer_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControle As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControle = stgNomControle.Substring((index + 1))
        End If

        Dim strCbEmprunterName As String = "cbEmprunterAttribuer-" & intIndexControle
        Dim controls0 As Control() = Me.Controls.Find(strCbEmprunterName, True)
        If controls0.Length = 1 Then
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = TryCast(controls0(0), MaterialSkin.Controls.MaterialComboBox)
            If cbEmprunterAttribuer IsNot Nothing Then
                Dim controls1 As Control() = Me.Controls.Find("dtFin-" & intIndexControle, True)
                If controls1.Length = 1 Then
                    Dim dtFin As DateTimePicker = TryCast(controls1(0), DateTimePicker)
                    If dtFin IsNot Nothing Then
                        If cbEmprunterAttribuer.Text = "Emprunt" Then
                            If swtReglageIndividuelle.Checked = True Then
                                dtFin.Enabled = True
                            End If
                            dtFin.Visible = True
                        Else
                            dtFin.Enabled = False
                            dtFin.Visible = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub LoadPersonnes()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim dtPredict As New DataTable
        Dim daPredict As New MySqlDataAdapter

        Dim sql As String = "Select * from NomPersonne"
        Dim stgPredict As String = "Select * from NomPersonne"


        'sql = "Select NomPersonne from NomPersonne Where NNom like ""%" & txtRechercher.Text & "%"""
        stgPredict = "Select NNom from NomPersonne"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            dt.Columns("NNom").ColumnName = strTitleNNom

            Dim strCbPersonne As String() = New String(dt.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dt.Rows
                strCbPersonne(i) = r.Item(0).ToString
                i += 1
            Next
            cbPersonnes.DataSource = strCbPersonne

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmGestionPersonnes.ShowDialog()
    End Sub

    Private Sub swtReglageIndividuelle_CheckedChanged(sender As Object, e As EventArgs) Handles swtReglageIndividuelle.CheckedChanged
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()


            If swtReglageIndividuelle.Checked = False Then
                cbEmprunterAttribuer.Enabled = False
                dtDebut.Enabled = False
                dtFin.Enabled = False
                If cbEmprunterAttribuer.Text = "Emprunt" Then
                    dtFin.Visible = True
                Else
                    dtFin.Visible = False
                End If
            Else
                cbEmprunterAttribuer.Enabled = True
                dtDebut.Enabled = True
                If cbEmprunterAttribuer.Text = "Emprunt" Then
                    dtFin.Enabled = True
                    dtFin.Visible = True
                Else
                    dtFin.Enabled = False
                    dtFin.Visible = False
                End If
            End If
        Next

        If swtReglageIndividuelle.Checked = True Then
            cbEmprunterAttribuerGlobal.Enabled = False
            dtDebutGlobal.Enabled = False
            dtFinGlobal.Enabled = False
            cbEmprunterAttribuerGlobal.Visible = False
            dtDebutGlobal.Visible = False
            dtFinGlobal.Visible = False
            lblDateFin.Visible = True
        Else
            cbEmprunterAttribuerGlobal.Enabled = True
            dtDebutGlobal.Enabled = True
            cbEmprunterAttribuerGlobal.Visible = True
            dtDebutGlobal.Visible = True
            If cbEmprunterAttribuerGlobal.Text <> "Attribution" Then
                dtFinGlobal.Enabled = True
                dtFinGlobal.Visible = True
                lblDateFin.Visible = True
            Else
                dtFinGlobal.Enabled = False
                dtFinGlobal.Visible = False
                lblDateFin.Visible = False
            End If
        End If
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        EmpruntAttributClef()
    End Sub

    Private Sub EmpruntAttributClef()
        If cbPersonnes.SelectedIndex <= -1 Then
            MsgBox("Vous n'avez pas sélectionné la personne !")
            Exit Sub
        End If
        Dim daSql As MySqlDataAdapter = New MySqlDataAdapter()
        Dim cmd As String = "INSERT INTO
                                        Emprunts (
                                        EIDClef,
                                        ENomPersonne,
                                        EDateDebut,
                                        EDateFin,
                                        EIDGenre
                                        )
                                    VALUES
                                        (
                                        (
                                            SELECT
                                            CID
                                            FROM
                                            Clefs
                                            WHERE
                                            CID LIKE @IDClef
                                            AND CStatus LIKE @StatutClef
                                            AND CPosition LIKE @TableauClef
                                            AND CTrousseau LIKE @TrousseauxClef
                                            LIMIT
                                            1
                                        ),@personne,@datedebut,@datefin,(
                                            SELECT
                                            NGenre
                                            FROM
                                            NomPersonne
                                            WHERE
                                            NNom = @personne
                                            LIMIT
                                            1
                                        )
                                        );
                                UPDATE
                                    Clefs
                                SET
                                    CStatus = @newStatut
                                WHERE
                                    CID = (
                                    SELECT
                                        *
                                    FROM(
                                        SELECT
                                            CID
                                        FROM
                                            Clefs
                                        WHERE
                                            CID LIKE @IDClef
                                            AND CStatus LIKE @StatutClef
                                            AND CPosition LIKE @TableauClef
                                            AND CTrousseau LIKE @TrousseauxClef
                                        LIMIT
                                            1
                                        )TempTable
                                    );"
        Dim CommandeAjouterEmprunt As New MySqlCommand(cmd, connecter())
        CommandeAjouterEmprunt.CommandType = CommandType.Text
        daSql.InsertCommand = CommandeAjouterEmprunt

        connecter()

        With CommandeAjouterEmprunt
            .Parameters.Add("@IDClef", MySqlDbType.String)
            .Parameters.Add("@StatutClef", MySqlDbType.VarChar)
            .Parameters.Add("@TableauClef", MySqlDbType.VarChar)
            .Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)
            .Parameters.Add("@personne", MySqlDbType.VarChar)
            .Parameters.Add("@datedebut", MySqlDbType.Date)
            .Parameters.Add("@datefin", MySqlDbType.Date)
            .Parameters.Add("@newStatut", MySqlDbType.VarChar)
        End With

        Try
            Dim i As Integer = 0
            For Each r As DataRow In frmMain.dtPanier.Rows
                Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
                Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()
                Dim STRdtDebut As String = "dtDebut-" & i
                Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()
                Dim STRdtFin As String = "dtFin-" & i
                Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

                With CommandeAjouterEmprunt
                    .Parameters("@IDClef").Value = r.Item(strTitleCID).ToString & "-%"
                    .Parameters("@StatutClef").Value = r.Item(strTitleCStatus).ToString
                    .Parameters("@TableauClef").Value = r.Item(strTitleCPosition).ToString
                    .Parameters("@TrousseauxClef").Value = r.Item(strTitleCTrousseau).ToString
                    .Parameters("@personne").Value = cbPersonnes.Text
                    .Parameters("@datedebut").Value = dtDebut.Value
                    If cbEmprunterAttribuer.Text <> "Attribution" Then
                        .Parameters("@datefin").Value = dtFin.Value
                    ElseIf cbEmprunterAttribuer.Text = "Attribution" Then
                        .Parameters("@datefin").Value = DBNull.Value
                    End If
                    If cbEmprunterAttribuer.Text <> "Attribution" Then
                        .Parameters("@newStatut").Value = "Empruntée"
                    Else
                        .Parameters("@newStatut").Value = "Attribuée"
                    End If
                End With
                CommandeAjouterEmprunt.ExecuteNonQuery()

                i += 1
            Next

        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox((ex.Number & " - " & ex.Message))
        Finally
            connecter().Close()
            frmMain.FillDataSource()
            Me.Dispose()
        End Try
    End Sub

    Private Sub cbEmprunterAttribuerGlobal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmprunterAttribuerGlobal.SelectedIndexChanged
        If cbEmprunterAttribuerGlobal.SelectedIndex <> 1 Then
            dtFinGlobal.Enabled = True
            dtFinGlobal.Visible = True
            lblDateFin.Visible = True
        Else
            dtFinGlobal.Enabled = False
            dtFinGlobal.Visible = False
            lblDateFin.Visible = False
        End If
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            cbEmprunterAttribuer.Text = cbEmprunterAttribuerGlobal.Text
            dtDebut.Value = dtDebutGlobal.Value
            dtFin.Value = dtFinGlobal.Value
        Next
    End Sub

    Private Sub dtDebutGlobal_ValueChanged(sender As Object, e As EventArgs) Handles dtDebutGlobal.ValueChanged
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            cbEmprunterAttribuer.Text = cbEmprunterAttribuerGlobal.Text
            dtDebut.Value = dtDebutGlobal.Value
            dtFin.Value = dtFinGlobal.Value
        Next
    End Sub

    Private Sub dtFinGlobal_ValueChanged(sender As Object, e As EventArgs) Handles dtFinGlobal.ValueChanged
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            cbEmprunterAttribuer.Text = cbEmprunterAttribuerGlobal.Text
            dtDebut.Value = dtDebutGlobal.Value
            dtFin.Value = dtFinGlobal.Value
        Next
    End Sub

End Class