<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlertesProprietes
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertesProprietes))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCID = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCNom = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCPosition = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCTrousseau = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCDate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.lblBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTrousseau = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateAjout = New MaterialSkin.Controls.MaterialLabel()
        Me.lblStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.lblLoc = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNbClef = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNom = New MaterialSkin.Controls.MaterialLabel()
        Me.lblID = New MaterialSkin.Controls.MaterialLabel()
        Me.btnGrpBatiment = New MaterialSkin.Controls.MaterialButton()
        Me.btnOK = New MaterialSkin.Controls.MaterialButton()
        Me.lblTel = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPersonne = New MaterialSkin.Controls.MaterialLabel()
        Me.lblGenre = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNTelephone = New MaterialSkin.Controls.MaterialLabel()
        Me.lblENomPersonne = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateFin = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateDebut = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNAutre = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTitleDateFin = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTitleDateDebut = New MaterialSkin.Controls.MaterialLabel()
        Me.txtAutres = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Depth = 0
        Me.lblCID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCID.Location = New System.Drawing.Point(12, 72)
        Me.lblCID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(26, 19)
        Me.lblCID.TabIndex = 29
        Me.lblCID.Text = "N° :"
        '
        'lblCNom
        '
        Me.lblCNom.AutoSize = True
        Me.lblCNom.Depth = 0
        Me.lblCNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCNom.Location = New System.Drawing.Point(12, 99)
        Me.lblCNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCNom.Name = "lblCNom"
        Me.lblCNom.Size = New System.Drawing.Size(51, 19)
        Me.lblCNom.TabIndex = 30
        Me.lblCNom.Text = "Accès :"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 126)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(69, 19)
        Me.MaterialLabel3.TabIndex = 31
        Me.MaterialLabel3.Text = "Quantité :"
        '
        'lblCPosition
        '
        Me.lblCPosition.AutoSize = True
        Me.lblCPosition.Depth = 0
        Me.lblCPosition.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCPosition.Location = New System.Drawing.Point(12, 205)
        Me.lblCPosition.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCPosition.Name = "lblCPosition"
        Me.lblCPosition.Size = New System.Drawing.Size(67, 19)
        Me.lblCPosition.TabIndex = 37
        Me.lblCPosition.Text = "Tableau :"
        '
        'lblCTrousseau
        '
        Me.lblCTrousseau.AutoSize = True
        Me.lblCTrousseau.Depth = 0
        Me.lblCTrousseau.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCTrousseau.Location = New System.Drawing.Point(12, 286)
        Me.lblCTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCTrousseau.Name = "lblCTrousseau"
        Me.lblCTrousseau.Size = New System.Drawing.Size(84, 19)
        Me.lblCTrousseau.TabIndex = 40
        Me.lblCTrousseau.Text = "Trousseau :"
        '
        'lblCDate
        '
        Me.lblCDate.AutoSize = True
        Me.lblCDate.Depth = 0
        Me.lblCDate.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCDate.Location = New System.Drawing.Point(12, 259)
        Me.lblCDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCDate.Name = "lblCDate"
        Me.lblCDate.Size = New System.Drawing.Size(94, 19)
        Me.lblCDate.TabIndex = 39
        Me.lblCDate.Text = "Date d'ajout :"
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Depth = 0
        Me.lblCStatus.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCStatus.Location = New System.Drawing.Point(12, 232)
        Me.lblCStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(55, 19)
        Me.lblCStatus.TabIndex = 38
        Me.lblCStatus.Text = "Status :"
        '
        'lblCBatiment
        '
        Me.lblCBatiment.AutoSize = True
        Me.lblCBatiment.Depth = 0
        Me.lblCBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCBatiment.Location = New System.Drawing.Point(12, 313)
        Me.lblCBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCBatiment.Name = "lblCBatiment"
        Me.lblCBatiment.Size = New System.Drawing.Size(81, 19)
        Me.lblCBatiment.TabIndex = 41
        Me.lblCBatiment.Text = "Bâtiments :"
        '
        'lblBatiment
        '
        Me.lblBatiment.Depth = 0
        Me.lblBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBatiment.Location = New System.Drawing.Point(160, 313)
        Me.lblBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBatiment.Name = "lblBatiment"
        Me.lblBatiment.Size = New System.Drawing.Size(185, 55)
        Me.lblBatiment.TabIndex = 53
        Me.lblBatiment.Text = "ECOLE ELEMENTAIRE J. E. JAMBON - ACCUEIL PERISCO."
        '
        'lblTrousseau
        '
        Me.lblTrousseau.AutoSize = True
        Me.lblTrousseau.Depth = 0
        Me.lblTrousseau.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTrousseau.Location = New System.Drawing.Point(160, 286)
        Me.lblTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTrousseau.Name = "lblTrousseau"
        Me.lblTrousseau.Size = New System.Drawing.Size(46, 19)
        Me.lblTrousseau.TabIndex = 52
        Me.lblTrousseau.Text = "Aucun"
        '
        'lblDateAjout
        '
        Me.lblDateAjout.AutoSize = True
        Me.lblDateAjout.Depth = 0
        Me.lblDateAjout.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateAjout.Location = New System.Drawing.Point(160, 259)
        Me.lblDateAjout.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateAjout.Name = "lblDateAjout"
        Me.lblDateAjout.Size = New System.Drawing.Size(87, 19)
        Me.lblDateAjout.TabIndex = 51
        Me.lblDateAjout.Text = "25/12/2019"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Depth = 0
        Me.lblStatus.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblStatus.Location = New System.Drawing.Point(160, 232)
        Me.lblStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(76, 19)
        Me.lblStatus.TabIndex = 50
        Me.lblStatus.Text = "Disponible"
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Depth = 0
        Me.lblLoc.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblLoc.Location = New System.Drawing.Point(160, 205)
        Me.lblLoc.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(83, 19)
        Me.lblLoc.TabIndex = 49
        Me.lblLoc.Text = "Tableau ST"
        '
        'lblNbClef
        '
        Me.lblNbClef.Depth = 0
        Me.lblNbClef.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNbClef.Location = New System.Drawing.Point(160, 126)
        Me.lblNbClef.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNbClef.Name = "lblNbClef"
        Me.lblNbClef.Size = New System.Drawing.Size(185, 65)
        Me.lblNbClef.TabIndex = 46
        Me.lblNbClef.Text = "28 disponibles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 empruntées" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TOTAL : 33 clefs"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Depth = 0
        Me.lblNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNom.Location = New System.Drawing.Point(160, 99)
        Me.lblNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(47, 19)
        Me.lblNom.TabIndex = 45
        Me.lblNom.Text = "Portail"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Depth = 0
        Me.lblID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblID.Location = New System.Drawing.Point(160, 72)
        Me.lblID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(37, 19)
        Me.lblID.TabIndex = 44
        Me.lblID.Text = "1816"
        '
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGrpBatiment.Depth = 0
        Me.btnGrpBatiment.DrawShadows = True
        Me.btnGrpBatiment.HighEmphasis = True
        Me.btnGrpBatiment.Icon = Nothing
        Me.btnGrpBatiment.Location = New System.Drawing.Point(160, 313)
        Me.btnGrpBatiment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGrpBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(185, 36)
        Me.btnGrpBatiment.TabIndex = 54
        Me.btnGrpBatiment.Text = "Groupe de bâtiments"
        Me.btnGrpBatiment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnGrpBatiment.UseAccentColor = False
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOK.Depth = 0
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.DrawShadows = True
        Me.btnOK.HighEmphasis = True
        Me.btnOK.Icon = Nothing
        Me.btnOK.Location = New System.Drawing.Point(589, 348)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOK.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(41, 36)
        Me.btnOK.TabIndex = 55
        Me.btnOK.Text = "OK"
        Me.btnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOK.UseAccentColor = False
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Depth = 0
        Me.lblTel.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTel.Location = New System.Drawing.Point(532, 126)
        Me.lblTel.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(91, 19)
        Me.lblTel.TabIndex = 61
        Me.lblTel.Text = "0601020304"
        '
        'lblPersonne
        '
        Me.lblPersonne.AutoSize = True
        Me.lblPersonne.Depth = 0
        Me.lblPersonne.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPersonne.Location = New System.Drawing.Point(532, 91)
        Me.lblPersonne.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPersonne.Name = "lblPersonne"
        Me.lblPersonne.Size = New System.Drawing.Size(67, 19)
        Me.lblPersonne.TabIndex = 60
        Me.lblPersonne.Text = "Personne"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Depth = 0
        Me.lblGenre.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblGenre.Location = New System.Drawing.Point(532, 72)
        Me.lblGenre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(63, 19)
        Me.lblGenre.TabIndex = 59
        Me.lblGenre.Text = "Fonction"
        '
        'lblNTelephone
        '
        Me.lblNTelephone.AutoSize = True
        Me.lblNTelephone.Depth = 0
        Me.lblNTelephone.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNTelephone.Location = New System.Drawing.Point(384, 126)
        Me.lblNTelephone.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNTelephone.Name = "lblNTelephone"
        Me.lblNTelephone.Size = New System.Drawing.Size(83, 19)
        Me.lblNTelephone.TabIndex = 58
        Me.lblNTelephone.Text = "Téléphone :"
        '
        'lblENomPersonne
        '
        Me.lblENomPersonne.AutoSize = True
        Me.lblENomPersonne.Depth = 0
        Me.lblENomPersonne.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblENomPersonne.Location = New System.Drawing.Point(384, 72)
        Me.lblENomPersonne.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblENomPersonne.Name = "lblENomPersonne"
        Me.lblENomPersonne.Size = New System.Drawing.Size(75, 19)
        Me.lblENomPersonne.TabIndex = 56
        Me.lblENomPersonne.Text = "Personne :"
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Depth = 0
        Me.lblDateFin.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateFin.Location = New System.Drawing.Point(532, 184)
        Me.lblDateFin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(87, 19)
        Me.lblDateFin.TabIndex = 72
        Me.lblDateFin.Text = "31/12/2999"
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Depth = 0
        Me.lblDateDebut.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateDebut.Location = New System.Drawing.Point(532, 155)
        Me.lblDateDebut.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(87, 19)
        Me.lblDateDebut.TabIndex = 71
        Me.lblDateDebut.Text = "01/01/1901"
        '
        'lblNAutre
        '
        Me.lblNAutre.AutoSize = True
        Me.lblNAutre.Depth = 0
        Me.lblNAutre.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNAutre.Location = New System.Drawing.Point(384, 211)
        Me.lblNAutre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNAutre.Name = "lblNAutre"
        Me.lblNAutre.Size = New System.Drawing.Size(226, 19)
        Me.lblNAutre.TabIndex = 70
        Me.lblNAutre.Text = "Informations complémentaires :"
        '
        'lblTitleDateFin
        '
        Me.lblTitleDateFin.AutoSize = True
        Me.lblTitleDateFin.Depth = 0
        Me.lblTitleDateFin.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTitleDateFin.Location = New System.Drawing.Point(384, 184)
        Me.lblTitleDateFin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTitleDateFin.Name = "lblTitleDateFin"
        Me.lblTitleDateFin.Size = New System.Drawing.Size(108, 19)
        Me.lblTitleDateFin.TabIndex = 69
        Me.lblTitleDateFin.Text = "Date de retour :"
        '
        'lblTitleDateDebut
        '
        Me.lblTitleDateDebut.AutoSize = True
        Me.lblTitleDateDebut.Depth = 0
        Me.lblTitleDateDebut.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTitleDateDebut.Location = New System.Drawing.Point(384, 155)
        Me.lblTitleDateDebut.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTitleDateDebut.Name = "lblTitleDateDebut"
        Me.lblTitleDateDebut.Size = New System.Drawing.Size(117, 19)
        Me.lblTitleDateDebut.TabIndex = 68
        Me.lblTitleDateDebut.Text = "Date d'emprunt :"
        '
        'txtAutres
        '
        Me.txtAutres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAutres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutres.Depth = 0
        Me.txtAutres.Enabled = False
        Me.txtAutres.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAutres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAutres.Hint = "Aucunes"
        Me.txtAutres.Location = New System.Drawing.Point(387, 238)
        Me.txtAutres.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAutres.Name = "txtAutres"
        Me.txtAutres.Size = New System.Drawing.Size(236, 96)
        Me.txtAutres.TabIndex = 74
        Me.txtAutres.Text = ""
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(363, 76)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1, 310)
        Me.MaterialDivider1.TabIndex = 75
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'frmAlertesProprietes
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(643, 399)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.txtAutres)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblDateFin)
        Me.Controls.Add(Me.lblPersonne)
        Me.Controls.Add(Me.lblDateDebut)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblNAutre)
        Me.Controls.Add(Me.lblNTelephone)
        Me.Controls.Add(Me.lblTitleDateFin)
        Me.Controls.Add(Me.lblTitleDateDebut)
        Me.Controls.Add(Me.lblENomPersonne)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnGrpBatiment)
        Me.Controls.Add(Me.lblBatiment)
        Me.Controls.Add(Me.lblTrousseau)
        Me.Controls.Add(Me.lblDateAjout)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.lblNbClef)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCBatiment)
        Me.Controls.Add(Me.lblCTrousseau)
        Me.Controls.Add(Me.lblCDate)
        Me.Controls.Add(Me.lblCStatus)
        Me.Controls.Add(Me.lblCPosition)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.lblCNom)
        Me.Controls.Add(Me.lblCID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlertesProprietes"
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Propriétés de :"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lblCID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCPosition As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCTrousseau As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTrousseau As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateAjout As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLoc As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNbClef As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnGrpBatiment As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnOK As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblTel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPersonne As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblGenre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNTelephone As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblENomPersonne As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateFin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateDebut As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNAutre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTitleDateFin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTitleDateDebut As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtAutres As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
End Class
