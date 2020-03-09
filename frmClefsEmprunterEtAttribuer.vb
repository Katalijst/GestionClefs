Imports System.IO
Imports System.Text
Imports iText.Forms
Imports iText.Forms.Fields
Imports iText.Kernel.Colors
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Layout
Imports iText.Layout.Properties
Imports MySql.Data.MySqlClient

Public Class frmClefsEmprunterEtAttribuer
    'Voir comment faire si clef dans trousseau
    Dim dtNomTel As New DataTable
    Dim nbPages As Integer = 1
    Dim nbLignePremièrePage As Integer = 15
    Dim nbLigneAutresPages As Integer = 19

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmEmprunterEtAttribuer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        SkinManager.AddFormToManage(Me)
        ChkTemplatesExists()
        CreateKeyControls()

        dtDebutGlobal.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        dtDebutGlobal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        dtDebutGlobal.Size = New System.Drawing.Size(127, 29)
        dtDebutGlobal.Value = Now
        dtFinGlobal.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        dtFinGlobal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        dtFinGlobal.Size = New System.Drawing.Size(127, 29)
        dtFinGlobal.Value = Now.AddDays(1)
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
            'Dim lblEmprunterAttribuer = New MaterialSkin.Controls.MaterialLabel()
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
            dvLigne.Size = New System.Drawing.Size(462, 1)
            dvLigne.TabIndex = 0
            dvLigne.Text = ""
            '
            'txtKeyID
            '
            txtKeyID.BorderStyle = System.Windows.Forms.BorderStyle.None
            txtKeyID.Depth = 0
            txtKeyID.Enabled = False
            txtKeyID.Font = New System.Drawing.Font("Roboto", 12.0!)
            txtKeyID.Location = New System.Drawing.Point(12, (14 + intY)) 'Passer de x: 165 à x: 12 = 153 d'ecart
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
            dtFin.Location = New System.Drawing.Point(282, (17 + intY))
            dtFin.Name = "dtFin-" & i
            dtFin.Size = New System.Drawing.Size(127, 29)
            dtFin.TabIndex = 6 + i
            '
            'dtDebut
            '
            dtDebut.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtDebut.Location = New System.Drawing.Point(149, (17 + intY))
            dtDebut.Name = "dtDebut-" & i
            dtDebut.Size = New System.Drawing.Size(127, 29)
            dtDebut.TabIndex = 5 + i
            '
            'btnDelete
            '
            btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            btnDelete.Depth = 0
            btnDelete.DrawShadows = True
            btnDelete.HighEmphasis = False
            btnDelete.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
            btnDelete.Location = New System.Drawing.Point(416, (13 + intY))
            btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER
            btnDelete.Name = "btnDelete-" & i
            btnDelete.Size = New System.Drawing.Size(44, 36)
            btnDelete.TabIndex = 7 + i
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
            btnDelete.UseAccentColor = False
            btnDelete.UseVisualStyleBackColor = True

            dtDebut.Value = Now
            dtFin.Value = Now.AddDays(1)

            Panel1.Controls.Add(dvLigne)
            Panel1.Controls.Add(txtKeyID)
            Panel1.Controls.Add(dtFin)
            Panel1.Controls.Add(dtDebut)
            Panel1.Controls.Add(btnDelete)

            AddHandler btnDelete.Click, AddressOf btnDelete_click
            AddHandler dtDebut.ValueChanged, AddressOf dtDebut_ValueChanged
            AddHandler dtFin.ValueChanged, AddressOf dtFin_ValueChanged

            txtKeyID.Text = r.Item(strTitleCID)

            If swtReglageIndividuelle.Checked = True Then
                dtDebut.Enabled = False
                dtFin.Enabled = False
            Else
                dtDebut.Enabled = True
                dtFin.Enabled = True
            End If
            If frmMain.blnEmprunt = False Then
                dtFin.Visible = False
            Else
                dtFin.Visible = True
            End If
            i += 1
        Next
        If frmMain.blnEmprunt = False Then
            dtFinGlobal.Visible = False
        Else
            dtFinGlobal.Visible = True
        End If

        '15 lignes + 1 ligne d'entête sur 1ere pages, 22 + 1 sur les autres
        If i > 1 Then
            lblNombreDeClef.Text = i & " clefs sélectionnées"
        ElseIf i < 1 Then
            lblNombreDeClef.Text = "Aucune clef sélectionnée"
        Else
            lblNombreDeClef.Text = "1 clef sélectionnée"
        End If
        nbPages = 1 + Math.Ceiling((i - nbLignePremièrePage) / nbLigneAutresPages)

        swtReglageIndividuelle.Checked = True

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

    Private Sub dtDebut_ValueChanged(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControle As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControle = stgNomControle.Substring((index + 1))
        End If

        Dim strDtDebut As String = "dtDebut-" & intIndexControle
        Dim strDtFin As String = "dtFin-" & intIndexControle
        Dim ctrlDtDebut As Control() = Me.Controls.Find(strDtDebut, True)
        Dim ctrlDtFin As Control() = Me.Controls.Find(strDtFin, True)
        If ctrlDtDebut.Length = 1 Then
            If ctrlDtFin.Length = 1 Then
                Dim dtDebut As DateTimePicker = TryCast(ctrlDtDebut(0), DateTimePicker)
                Dim dtFin As DateTimePicker = TryCast(ctrlDtFin(0), DateTimePicker)
                dtFin.MinDate = dtDebut.Value
            End If
        End If
    End Sub
    Private Sub dtFin_ValueChanged(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControle As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControle = stgNomControle.Substring((index + 1))
        End If

        Dim strDtDebut As String = "dtDebut-" & intIndexControle
        Dim strDtFin As String = "dtFin-" & intIndexControle
        Dim ctrlDtDebut As Control() = Me.Controls.Find(strDtDebut, True)
        Dim ctrlDtFin As Control() = Me.Controls.Find(strDtFin, True)
        If ctrlDtDebut.Length = 1 Then
            If ctrlDtFin.Length = 1 Then
                Dim dtDebut As DateTimePicker = TryCast(ctrlDtDebut(0), DateTimePicker)
                Dim dtFin As DateTimePicker = TryCast(ctrlDtFin(0), DateTimePicker)
                dtDebut.MaxDate = dtFin.Value
            End If
        End If
    End Sub

    Public Sub LoadPersonnes(ByVal Optional name As String = "Empty")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter

        'sql = "Select NomPersonne from NomPersonne Where NNom like ""%" & txtRechercher.Text & "%"""
        Dim CmdSql As String = "Select NNom, NTelephone from NomPersonne where NNom <> 'Personne'"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtNomTel)
            'dtNomTel.Columns("NNom").ColumnName = strTitleNNom

            Dim strCbPersonne As String() = New String(dtNomTel.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtNomTel.Rows
                strCbPersonne(i) = r.Item(0).ToString
                i += 1
            Next
            cbPersonnes.DataSource = strCbPersonne
            If name <> "Empty" Then
                cbPersonnes.Text = name
            End If
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmPersonnesGestion.ShowDialog()
        frmPersonnesGestion.MaterialTabControl1.SelectTab(frmPersonnesGestion.tabAjouter)
    End Sub

    Private Sub swtReglageIndividuelle_CheckedChanged(sender As Object, e As EventArgs) Handles swtReglageIndividuelle.CheckedChanged
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()


            If swtReglageIndividuelle.Checked = True Then
                dtDebut.Enabled = False
                dtFin.Enabled = False
            Else
                dtDebut.Enabled = True
                dtFin.Enabled = True
            End If
        Next

        If swtReglageIndividuelle.Checked = True Then
            dtDebutGlobal.Enabled = True
            dtFinGlobal.Enabled = True
        Else
            dtDebutGlobal.Enabled = False
            dtFinGlobal.Enabled = False
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
                                    CStatus = @newStatut,
                                    CTrousseau = @newTrousseau
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
            .Parameters.Add("@newTrousseau", MySqlDbType.VarChar)
        End With

        Try
            Dim i As Integer = 0
            Dim ListTrID As List(Of String) = frmMain.listADetacher
            Dim ListTrousseaux As New List(Of String)
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
                    If frmMain.blnEmprunt = True Then
                        .Parameters("@datefin").Value = dtFin.Value
                    Else
                        .Parameters("@datefin").Value = DBNull.Value
                    End If
                    If frmMain.blnEmprunt = True Then
                        .Parameters("@newStatut").Value = "Empruntée"
                    Else
                        .Parameters("@newStatut").Value = "Attribuée"
                    End If
                    If ListTrID.Contains(r.Item(strTitleCTrousseau).ToString & r.Item(strTitleCID).ToString) Then
                        .Parameters("@newTrousseau").Value = "Aucun"
                        ListTrousseaux.Add(r.Item(strTitleCTrousseau).ToString)
                    Else
                        .Parameters("@newTrousseau").Value = r.Item(strTitleCTrousseau).ToString
                    End If
                End With
                CommandeAjouterEmprunt.ExecuteNonQuery()
                i += 1
            Next
            For Each str As String In ListTrousseaux
                'supprimer trousseaux vides
                Dim cmdCheckTrousseaux As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter
                Dim dt1 As New DataTable
                Dim da1 As New MySqlDataAdapter
                Dim sql As String

                cmdCheckTrousseaux.Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)

                sql = "Select CID from Clefs where CTrousseau = @TrousseauxClef"
                With cmdCheckTrousseaux
                    .Parameters("@TrousseauxClef").Value = str
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmdCheckTrousseaux
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    sql = "DELETE FROM Trousseaux where TNom = @TrousseauxClef"
                    With cmdCheckTrousseaux
                        .Parameters("@TrousseauxClef").Value = str
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                End If
            Next

        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox((ex.Number & " - " & ex.Message))
        Finally
            connecter().Close()
            If chkPrint.Checked = True Then
                If frmMain.blnEmprunt = True Then
                    PrintDocEmprunt()
                Else
                    PrintDocAttribuer()
                End If
            Else
                frmMain.FillDataSource()
            End If
            Me.Close()
        End Try
    End Sub

    Private Sub dtDebutGlobal_ValueChanged(sender As Object, e As EventArgs) Handles dtDebutGlobal.ValueChanged
        dtFinGlobal.MinDate = dtDebutGlobal.Value
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            'Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            'Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            'cbEmprunterAttribuer.Text = lblEmprunterAttribuerGlobal.Text
            dtDebut.Value = dtDebutGlobal.Value
            dtFin.Value = dtFinGlobal.Value
        Next
    End Sub

    Private Sub dtFinGlobal_ValueChanged(sender As Object, e As EventArgs) Handles dtFinGlobal.ValueChanged
        dtDebutGlobal.MaxDate = dtFinGlobal.Value
        For i = 0 To frmMain.dtPanier.Rows.Count - 1
            'Dim STRcbEmprunterAttribuer As String = "cbEmprunterAttribuer-" & i
            'Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = Me.Controls.Find(STRcbEmprunterAttribuer, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            'cbEmprunterAttribuer.Text = lblEmprunterAttribuerGlobal.Text
            dtDebut.Value = dtDebutGlobal.Value
            dtFin.Value = dtFinGlobal.Value
        Next
    End Sub

    Public Sub PrintDocEmprunt()
        Dim TemplatePremièrePage As String = My.Application.Info.DirectoryPath & "\Templates\PRET_CLE_P1.pdf"
        Dim TemplateAutresPages As String = My.Application.Info.DirectoryPath & "\Templates\PRET_CLE_PX.pdf"
        Dim strFolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\GestionClefs\"
        If (Not System.IO.Directory.Exists(strFolder)) Then
            System.IO.Directory.CreateDirectory(strFolder)
        End If
        Dim FinalFileName As String = strFolder & cbPersonnes.Text & "_EMPRUNT_" & Now.ToString("dd-MM-yyyy")

        Dim counter As Integer = 2
        Dim newFileName As String = FinalFileName & ".pdf"
        While File.Exists(newFileName)
            newFileName = FinalFileName & " (" & counter & ")" & ".pdf"
            counter = counter + 1
        End While
        FinalFileName = newFileName

        Dim StreamPremièrePage As New MemoryStream
        Dim ReaderPremièrePage As New PdfReader(TemplatePremièrePage)
        Dim WriterPremièrePage As New PdfWriter(StreamPremièrePage)
        WriterPremièrePage.SetCloseStream(False)

        Dim WriterFinalDocument As New PdfWriter(FinalFileName)

        Dim PremièrePageEmprunt As New PdfDocument(ReaderPremièrePage, WriterPremièrePage)
        Dim FinalDocument As New PdfDocument(WriterFinalDocument)


        '#######################
        '#### PREMIERE PAGE ####
        '#######################
        '====================== RECUPERATION ET REMPLISSAGE DES CHAMPS ======================
        Dim Acroform As PdfAcroForm = PdfAcroForm.GetAcroForm(PremièrePageEmprunt, True)
        Dim fields As IDictionary(Of String, PdfFormField) = Acroform.GetFormFields()
        'Obtenir les noms des champs
        Dim sb As StringBuilder = New StringBuilder()
        For Each de As KeyValuePair(Of String, PdfFormField) In fields
            sb.Append(de.Key.ToString() + Environment.NewLine)
        Next
        'MsgBox(sb.ToString)

        'Acroform.GetField("cle")
        fields("date").SetValue(Now.ToString("d MMMM yyyy"))
        fields("page").SetValue("1/" & nbPages)
        If cbPersonnes.SelectedIndex <> -1 Then
            fields("nom").SetValue(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NNom"))
            If IsDBNull(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NTelephone")) = False Then
                fields("tel").SetValue(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NTelephone"))
            End If
        End If

        '====================== CREATION DU TABLEAU D'EMPRUNT ======================
        Dim tailleRow As Integer = 18
        Dim position As Double() = Acroform.GetField("cle").GetWidgets.FirstOrDefault.GetRectangle().ToDoubleArray

        Dim NbreDeRow As Integer = frmMain.dtPanier.Rows.Count

        Dim table As Table = New Table(3, True).UseAllAvailableWidth()
        table.SetMaxHeight((position(3) - position(1)))
        table.SetMargin(0)
        Dim cell As Cell
        Dim doc As Document = New Document(PremièrePageEmprunt)
        cell = New Cell().Add(New Paragraph("Date de retour"))
        cell.SetHeight(tailleRow)
        table.AddCell("N° de clef")
        table.AddCell("Date d'emprunt")
        table.AddCell(cell.Clone(True))
        Dim LigneACopier As Integer

        If NbreDeRow > nbLignePremièrePage Then
            LigneACopier = nbLignePremièrePage - 1
        Else
            LigneACopier = frmMain.dtPanier.Rows.Count - 1
        End If

        For i = 0 To LigneACopier
            Dim STRtxtKeyID As String = "txtKeyID-" & i
            Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = Me.Controls.Find(STRtxtKeyID, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

            Dim STRdtFin As String = "dtFin-" & i
            Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

            cell = New Cell().Add(New Paragraph(dtFin.Value.ToString("dd/MM/yy")))
            cell.SetHeight(tailleRow)
            table.AddCell(txtKeyID.Text)
            table.AddCell(dtDebut.Value.ToString("dd/MM/yy"))
            table.AddCell(cell.Clone(True))
        Next

        Dim result As LayoutResult = table.CreateRendererSubTree().SetParent(doc.GetRenderer()).Layout(New LayoutContext(New LayoutArea(1, New iText.Kernel.Geom.Rectangle(0, 0, 400, 10000.0F))))
        Dim tableHeight As Single = result.GetOccupiedArea().GetBBox().GetHeight()
        Dim bottom As Single = position(3) - tableHeight
        Dim width As Single = position(2) - position(0)
        table.SetFixedPosition(position(0), bottom, width)
        doc.Add(table)
        table.Complete()
        '======================END TABLE CREATION======================
        Acroform.FlattenFields()
        PremièrePageEmprunt.Close()
        StreamPremièrePage.Position = 0
        Dim tempReader As New PdfReader(StreamPremièrePage)
        Dim tempPage As New PdfDocument(tempReader)
        FinalDocument.AddPage(tempPage.GetPage(1).CopyTo(FinalDocument))
        tempPage.Close()
        StreamPremièrePage.Close()

        '###########################
        '#### FIN PREMIERE PAGE ####
        '###########################

        If nbPages > 1 Then
            For n = 2 To nbPages

                '#######################
                '#### AUTRES PAGES #####
                '#######################

                Dim StreamAutresPages As New MemoryStream
                Dim ReaderAutrePages As New PdfReader(TemplateAutresPages)
                Dim WriterAutrePages As New PdfWriter(StreamAutresPages)
                WriterAutrePages.SetCloseStream(False)
                Dim AutresPagesEmprunt As New PdfDocument(ReaderAutrePages, WriterAutrePages)

                '====================== RECUPERATION ET REMPLISSAGE DES CHAMPS ======================
                Acroform = PdfAcroForm.GetAcroForm(AutresPagesEmprunt, True)
                fields.Clear()
                fields = Acroform.GetFormFields()
                'Obtenir les noms des champs
                sb.Clear()
                sb = New StringBuilder()
                For Each de As KeyValuePair(Of String, PdfFormField) In fields
                    sb.Append(de.Key.ToString() + Environment.NewLine)
                Next
                'MsgBox(sb.ToString)

                'Acroform.GetField("cle")
                fields("date").SetValue(Now.ToString("d MMMM yyyy"))
                fields("page").SetValue((FinalDocument.GetNumberOfPages() + 1) & "/" & nbPages)

                '====================== CREATION DU TABLEAU D'EMPRUNT ======================
                position = Acroform.GetField("cle").GetWidgets.FirstOrDefault.GetRectangle().ToDoubleArray

                table = New Table(3, True).UseAllAvailableWidth()
                table.SetMaxHeight((position(3) - position(1)))
                table.SetMargin(0)
                doc = New Document(AutresPagesEmprunt)
                cell = New Cell().Add(New Paragraph("Date de retour"))
                cell.SetHeight(tailleRow)
                table.AddCell("N° de clef")
                table.AddCell("Date d'emprunt")
                table.AddCell(cell.Clone(True))

                If NbreDeRow > (15 + (nbLigneAutresPages * FinalDocument.GetNumberOfPages())) Then
                    LigneACopier = nbLigneAutresPages
                Else
                    LigneACopier = ((frmMain.dtPanier.Rows.Count - 15) Mod nbLigneAutresPages)
                End If
                Dim StartIndex As Integer = 15
                If FinalDocument.GetNumberOfPages() > 1 Then
                    StartIndex = 15 + (nbLigneAutresPages * (FinalDocument.GetNumberOfPages() - 1))
                End If

                For i = StartIndex To (StartIndex + LigneACopier - 1)
                    Dim STRtxtKeyID As String = "txtKeyID-" & i
                    Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = Me.Controls.Find(STRtxtKeyID, True).FirstOrDefault()

                    Dim STRdtDebut As String = "dtDebut-" & i
                    Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

                    Dim STRdtFin As String = "dtFin-" & i
                    Dim dtFin As DateTimePicker = Me.Controls.Find(STRdtFin, True).FirstOrDefault()

                    cell = New Cell().Add(New Paragraph(dtFin.Value.ToString("dd/MM/yy")))
                    cell.SetHeight(tailleRow)
                    table.AddCell(txtKeyID.Text)
                    table.AddCell(dtDebut.Value.ToString("dd/MM/yy"))
                    table.AddCell(cell.Clone(True))
                Next

                result = table.CreateRendererSubTree().SetParent(doc.GetRenderer()).Layout(New LayoutContext(New LayoutArea(1, New iText.Kernel.Geom.Rectangle(0, 0, 400, 10000.0F))))
                tableHeight = result.GetOccupiedArea().GetBBox().GetHeight()
                bottom = position(3) - tableHeight
                width = position(2) - position(0)
                table.SetFixedPosition(position(0), bottom, width)
                doc.Add(table)
                table.Complete()
                '======================END TABLE CREATION======================
                Acroform.FlattenFields()
                AutresPagesEmprunt.Close()
                StreamAutresPages.Position = 0
                Dim tempReader2 As New PdfReader(StreamAutresPages)
                Dim tempPage2 As New PdfDocument(tempReader2)
                FinalDocument.AddPage(tempPage2.GetPage(1).CopyTo(FinalDocument))
                tempPage2.Close()
                StreamAutresPages.Close()

                '###########################
                '#### FIN AUTRES PAGES #####
                '###########################

            Next
        End If

        FinalDocument.Close()

        Dim PrintProcess As New Process()
        PrintProcess.StartInfo.FileName = FinalFileName
        'Décommenter pour lancer l'impression directement
        'PrintProcess.StartInfo.Verb = "printto"
        PrintProcess.Start()

        frmMain.FillDataSource()

    End Sub

    Public Sub PrintDocAttribuer()
        Dim TemplatePremièrePage As String = My.Application.Info.DirectoryPath & "\Templates\ATTRIBUTION_CLE_P1.pdf"
        Dim TemplateAutresPages As String = My.Application.Info.DirectoryPath & "\Templates\ATTRIBUTION_CLE_PX.pdf"
        Dim strFolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\GestionClefs\"
        If (Not System.IO.Directory.Exists(strFolder)) Then
            System.IO.Directory.CreateDirectory(strFolder)
        End If
        Dim FinalFileName As String = strFolder & cbPersonnes.Text & "_ATTRIBUTION_" & Now.ToString("dd-MM-yyyy")

        Dim counter As Integer = 2
        Dim newFileName As String = FinalFileName & ".pdf"
        While File.Exists(newFileName)
            newFileName = FinalFileName & " (" & counter & ")" & ".pdf"
            counter = counter + 1
        End While
        FinalFileName = newFileName

        Dim StreamPremièrePage As New MemoryStream
        Dim ReaderPremièrePage As New PdfReader(TemplatePremièrePage)
        Dim WriterPremièrePage As New PdfWriter(StreamPremièrePage)
        WriterPremièrePage.SetCloseStream(False)

        Dim WriterFinalDocument As New PdfWriter(FinalFileName)

        Dim PremièrePageEmprunt As New PdfDocument(ReaderPremièrePage, WriterPremièrePage)
        Dim FinalDocument As New PdfDocument(WriterFinalDocument)


        '#######################
        '#### PREMIERE PAGE ####
        '#######################
        '====================== RECUPERATION ET REMPLISSAGE DES CHAMPS ======================
        Dim Acroform As PdfAcroForm = PdfAcroForm.GetAcroForm(PremièrePageEmprunt, True)
        Dim fields As IDictionary(Of String, PdfFormField) = Acroform.GetFormFields()
        'Obtenir les noms des champs
        Dim sb As StringBuilder = New StringBuilder()
        For Each de As KeyValuePair(Of String, PdfFormField) In fields
            sb.Append(de.Key.ToString() + Environment.NewLine)
        Next
        'MsgBox(sb.ToString)

        'Acroform.GetField("cle")
        fields("date").SetValue(Now.ToString("d MMMM yyyy"))
        fields("page").SetValue("1/" & nbPages)
        If cbPersonnes.SelectedIndex <> -1 Then
            fields("nom").SetValue(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NNom"))
            If IsDBNull(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NTelephone")) = False Then
                fields("tel").SetValue(dtNomTel.Rows(cbPersonnes.SelectedIndex).Item("NTelephone"))
            End If
        End If

            '====================== CREATION DU TABLEAU D'EMPRUNT ======================
            Dim tailleRow As Integer = 18
        Dim position As Double() = Acroform.GetField("cle").GetWidgets.FirstOrDefault.GetRectangle().ToDoubleArray

        Dim NbreDeRow As Integer = frmMain.dtPanier.Rows.Count

        Dim table As Table = New Table(2, True).UseAllAvailableWidth()
        table.SetMaxHeight((position(3) - position(1)))
        table.SetMargin(0)
        Dim cell As Cell
        Dim doc As Document = New Document(PremièrePageEmprunt)
        cell = New Cell().Add(New Paragraph("Date d'attribution"))
        cell.SetHeight(tailleRow)
        table.AddCell("N° de clef")
        table.AddCell(cell.Clone(True))
        Dim LigneACopier As Integer

        If NbreDeRow > nbLignePremièrePage Then
            LigneACopier = nbLignePremièrePage - 1
        Else
            LigneACopier = frmMain.dtPanier.Rows.Count - 1
        End If

        For i = 0 To LigneACopier
            Dim STRtxtKeyID As String = "txtKeyID-" & i
            Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = Me.Controls.Find(STRtxtKeyID, True).FirstOrDefault()

            Dim STRdtDebut As String = "dtDebut-" & i
            Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()


            cell = New Cell().Add(New Paragraph(dtDebut.Value.ToString("dd/MM/yy")))
            cell.SetHeight(tailleRow)
            table.AddCell(txtKeyID.Text)
            table.AddCell(cell.Clone(True))
        Next

        Dim result As LayoutResult = table.CreateRendererSubTree().SetParent(doc.GetRenderer()).Layout(New LayoutContext(New LayoutArea(1, New iText.Kernel.Geom.Rectangle(0, 0, 400, 10000.0F))))
        Dim tableHeight As Single = result.GetOccupiedArea().GetBBox().GetHeight()
        Dim bottom As Single = position(3) - tableHeight
        Dim width As Single = position(2) - position(0)
        table.SetFixedPosition(position(0), bottom, width)
        doc.Add(table)
        table.Complete()
        '======================END TABLE CREATION======================
        Acroform.FlattenFields()
        PremièrePageEmprunt.Close()
        StreamPremièrePage.Position = 0
        Dim tempReader As New PdfReader(StreamPremièrePage)
        Dim tempPage As New PdfDocument(tempReader)
        FinalDocument.AddPage(tempPage.GetPage(1).CopyTo(FinalDocument))
        tempPage.Close()
        StreamPremièrePage.Close()

        '###########################
        '#### FIN PREMIERE PAGE ####
        '###########################

        If nbPages > 1 Then
            For n = 2 To nbPages

                '#######################
                '#### AUTRES PAGES #####
                '#######################

                Dim StreamAutresPages As New MemoryStream
                Dim ReaderAutrePages As New PdfReader(TemplateAutresPages)
                Dim WriterAutrePages As New PdfWriter(StreamAutresPages)
                WriterAutrePages.SetCloseStream(False)
                Dim AutresPagesEmprunt As New PdfDocument(ReaderAutrePages, WriterAutrePages)

                '====================== RECUPERATION ET REMPLISSAGE DES CHAMPS ======================
                Acroform = PdfAcroForm.GetAcroForm(AutresPagesEmprunt, True)
                fields.Clear()
                fields = Acroform.GetFormFields()
                'Obtenir les noms des champs
                sb.Clear()
                sb = New StringBuilder()
                For Each de As KeyValuePair(Of String, PdfFormField) In fields
                    sb.Append(de.Key.ToString() + Environment.NewLine)
                Next
                'MsgBox(sb.ToString)

                'Acroform.GetField("cle")
                fields("date").SetValue(Now.ToString("d MMMM yyyy"))
                fields("page").SetValue((FinalDocument.GetNumberOfPages() + 1) & "/" & nbPages)

                '====================== CREATION DU TABLEAU D'EMPRUNT ======================
                position = Acroform.GetField("cle").GetWidgets.FirstOrDefault.GetRectangle().ToDoubleArray

                table = New Table(2, True).UseAllAvailableWidth()
                table.SetMaxHeight((position(3) - position(1)))
                table.SetMargin(0)
                doc = New Document(AutresPagesEmprunt)
                cell = New Cell().Add(New Paragraph("Date d'attribution"))
                cell.SetHeight(tailleRow)
                table.AddCell("N° de clef")
                table.AddCell(cell.Clone(True))

                If NbreDeRow > (15 + (nbLigneAutresPages * FinalDocument.GetNumberOfPages())) Then
                    LigneACopier = nbLigneAutresPages
                Else
                    LigneACopier = ((frmMain.dtPanier.Rows.Count - 15) Mod nbLigneAutresPages)
                End If
                Dim StartIndex As Integer = 15
                If FinalDocument.GetNumberOfPages() > 1 Then
                    StartIndex = 15 + (nbLigneAutresPages * (FinalDocument.GetNumberOfPages() - 1))
                End If

                For i = StartIndex To (StartIndex + LigneACopier - 1)
                    Dim STRtxtKeyID As String = "txtKeyID-" & i
                    Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = Me.Controls.Find(STRtxtKeyID, True).FirstOrDefault()

                    Dim STRdtDebut As String = "dtDebut-" & i
                    Dim dtDebut As DateTimePicker = Me.Controls.Find(STRdtDebut, True).FirstOrDefault()

                    cell = New Cell().Add(New Paragraph(dtDebut.Value.ToString("dd/MM/yy")))
                    cell.SetHeight(tailleRow)
                    table.AddCell(txtKeyID.Text)
                    table.AddCell(cell.Clone(True))
                Next

                result = table.CreateRendererSubTree().SetParent(doc.GetRenderer()).Layout(New LayoutContext(New LayoutArea(1, New iText.Kernel.Geom.Rectangle(0, 0, 400, 10000.0F))))
                tableHeight = result.GetOccupiedArea().GetBBox().GetHeight()
                bottom = position(3) - tableHeight
                width = position(2) - position(0)
                table.SetFixedPosition(position(0), bottom, width)
                doc.Add(table)
                table.Complete()
                '======================END TABLE CREATION======================
                Acroform.FlattenFields()
                AutresPagesEmprunt.Close()
                StreamAutresPages.Position = 0
                Dim tempReader2 As New PdfReader(StreamAutresPages)
                Dim tempPage2 As New PdfDocument(tempReader2)
                FinalDocument.AddPage(tempPage2.GetPage(1).CopyTo(FinalDocument))
                tempPage2.Close()
                StreamAutresPages.Close()

                '###########################
                '#### FIN AUTRES PAGES #####
                '###########################

            Next
        End If

        FinalDocument.Close()

        Dim PrintProcess As New Process()
        PrintProcess.StartInfo.FileName = FinalFileName
        'Décommenter pour lancer l'impression directement
        'PrintProcess.StartInfo.Verb = "printto"
        PrintProcess.Start()

        frmMain.FillDataSource()

    End Sub

    Private Sub ChkTemplatesExists()
        If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Templates\")) Then
            System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Templates\")
        End If
        Dim TemplateAttriPremièrePage As String = My.Application.Info.DirectoryPath & "\Templates\ATTRIBUTION_CLE_P1.pdf"
        Dim TemplateAttriAutresPages As String = My.Application.Info.DirectoryPath & "\Templates\ATTRIBUTION_CLE_PX.pdf"
        Dim TemplateEmpruPremièrePage As String = My.Application.Info.DirectoryPath & "\Templates\PRET_CLE_P1.pdf"
        Dim TemplateEmpruAutresPages As String = My.Application.Info.DirectoryPath & "\Templates\PRET_CLE_PX.pdf"
        If File.Exists(TemplateAttriPremièrePage) = False Then
            File.WriteAllBytes(TemplateAttriPremièrePage, My.Resources.ATTRIBUTION_CLE_P1)
        End If
        If File.Exists(TemplateAttriAutresPages) = False Then
            File.WriteAllBytes(TemplateAttriAutresPages, My.Resources.ATTRIBUTION_CLE_PX)
        End If
        If File.Exists(TemplateEmpruPremièrePage) = False Then
            File.WriteAllBytes(TemplateEmpruPremièrePage, My.Resources.PRET_CLE_P1)
        End If
        If File.Exists(TemplateEmpruAutresPages) = False Then
            File.WriteAllBytes(TemplateEmpruAutresPages, My.Resources.PRET_CLE_PX)
        End If
    End Sub

    Private Sub MaterialFloatingActionButton1_Click(sender As Object, e As EventArgs) Handles MaterialFloatingActionButton1.Click
        If frmMain.blnEmprunt = True Then
            PrintDocEmprunt()
        Else
            PrintDocAttribuer()
        End If
    End Sub

    Private Sub btnSearchPeople_Click(sender As Object, e As EventArgs) Handles btnSearchPeople.Click
        frmPersonnesGestion.ShowDialog()
    End Sub
End Class