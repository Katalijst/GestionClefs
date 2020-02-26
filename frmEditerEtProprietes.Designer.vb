<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditerEtProprietes
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
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.lblCID = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCNom = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCPosition = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.cmbLoc = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbTrousseauListe = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnGrpBatiment = New MaterialSkin.Controls.MaterialButton()
        Me.lblCDate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCTrousseau = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnNewLoc = New MaterialSkin.Controls.MaterialButton()
        Me.btnNewTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckbox2 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckbox3 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckbox4 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtQuantity = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblQuantity = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbStatus = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.swtEditOneKey = New MaterialSkin.Controls.MaterialSwitch()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtCnOpt = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCnExt = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCnInt = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtRefOrg = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtEmprunteur = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblEmprunteur = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateDebut = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpDebut = New System.Windows.Forms.DateTimePicker()
        Me.lblDateFin = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.txtTel = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(137, 286)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(182, 26)
        Me.dtpDate.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(484, 474)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Depth = 0
        Me.lblCID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCID.Location = New System.Drawing.Point(12, 82)
        Me.lblCID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(24, 19)
        Me.lblCID.TabIndex = 36
        Me.lblCID.Text = "ID :"
        '
        'lblCNom
        '
        Me.lblCNom.AutoSize = True
        Me.lblCNom.Depth = 0
        Me.lblCNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCNom.Location = New System.Drawing.Point(12, 166)
        Me.lblCNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCNom.Name = "lblCNom"
        Me.lblCNom.Size = New System.Drawing.Size(43, 19)
        Me.lblCNom.TabIndex = 37
        Me.lblCNom.Text = "Nom :"
        '
        'lblCPosition
        '
        Me.lblCPosition.AutoSize = True
        Me.lblCPosition.Depth = 0
        Me.lblCPosition.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCPosition.Location = New System.Drawing.Point(12, 207)
        Me.lblCPosition.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCPosition.Name = "lblCPosition"
        Me.lblCPosition.Size = New System.Drawing.Size(96, 19)
        Me.lblCPosition.TabIndex = 38
        Me.lblCPosition.Text = "Localisation :"
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Depth = 0
        Me.lblCStatus.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCStatus.Location = New System.Drawing.Point(12, 249)
        Me.lblCStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(55, 19)
        Me.lblCStatus.TabIndex = 39
        Me.lblCStatus.Text = "Status :"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Depth = 0
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(137, 73)
        Me.txtID.MaxLength = 50
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(182, 36)
        Me.txtID.TabIndex = 40
        Me.txtID.Text = ""
        Me.txtID.UseTallSize = False
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Enabled = False
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(137, 157)
        Me.txtNom.MaxLength = 50
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(182, 36)
        Me.txtNom.TabIndex = 41
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'cmbLoc
        '
        Me.cmbLoc.AutoResize = False
        Me.cmbLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbLoc.Depth = 0
        Me.cmbLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbLoc.DropDownHeight = 118
        Me.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoc.DropDownWidth = 121
        Me.cmbLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbLoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.IntegralHeight = False
        Me.cmbLoc.ItemHeight = 29
        Me.cmbLoc.Location = New System.Drawing.Point(137, 199)
        Me.cmbLoc.MaxDropDownItems = 4
        Me.cmbLoc.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(182, 35)
        Me.cmbLoc.TabIndex = 42
        Me.cmbLoc.UseTallSize = False
        '
        'cmbTrousseauListe
        '
        Me.cmbTrousseauListe.AutoResize = False
        Me.cmbTrousseauListe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTrousseauListe.Depth = 0
        Me.cmbTrousseauListe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbTrousseauListe.DropDownHeight = 118
        Me.cmbTrousseauListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrousseauListe.DropDownWidth = 121
        Me.cmbTrousseauListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbTrousseauListe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbTrousseauListe.FormattingEnabled = True
        Me.cmbTrousseauListe.IntegralHeight = False
        Me.cmbTrousseauListe.ItemHeight = 29
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(137, 324)
        Me.cmbTrousseauListe.MaxDropDownItems = 4
        Me.cmbTrousseauListe.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(182, 35)
        Me.cmbTrousseauListe.TabIndex = 44
        Me.cmbTrousseauListe.UseTallSize = False
        '
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGrpBatiment.Depth = 0
        Me.btnGrpBatiment.DrawShadows = True
        Me.btnGrpBatiment.HighEmphasis = True
        Me.btnGrpBatiment.Icon = Nothing
        Me.btnGrpBatiment.Location = New System.Drawing.Point(140, 397)
        Me.btnGrpBatiment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGrpBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(176, 36)
        Me.btnGrpBatiment.TabIndex = 45
        Me.btnGrpBatiment.Text = "Groupe de bâtiment"
        Me.btnGrpBatiment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnGrpBatiment.UseAccentColor = False
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'lblCDate
        '
        Me.lblCDate.AutoSize = True
        Me.lblCDate.Depth = 0
        Me.lblCDate.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCDate.Location = New System.Drawing.Point(12, 290)
        Me.lblCDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCDate.Name = "lblCDate"
        Me.lblCDate.Size = New System.Drawing.Size(94, 19)
        Me.lblCDate.TabIndex = 46
        Me.lblCDate.Text = "Date d'ajout :"
        '
        'lblCTrousseau
        '
        Me.lblCTrousseau.AutoSize = True
        Me.lblCTrousseau.Depth = 0
        Me.lblCTrousseau.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCTrousseau.Location = New System.Drawing.Point(12, 332)
        Me.lblCTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCTrousseau.Name = "lblCTrousseau"
        Me.lblCTrousseau.Size = New System.Drawing.Size(84, 19)
        Me.lblCTrousseau.TabIndex = 47
        Me.lblCTrousseau.Text = "Trousseau :"
        '
        'lblCBatiment
        '
        Me.lblCBatiment.AutoSize = True
        Me.lblCBatiment.Depth = 0
        Me.lblCBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCBatiment.Location = New System.Drawing.Point(12, 374)
        Me.lblCBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCBatiment.Name = "lblCBatiment"
        Me.lblCBatiment.Size = New System.Drawing.Size(81, 19)
        Me.lblCBatiment.TabIndex = 48
        Me.lblCBatiment.Text = "Bâtiments :"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-69, 465)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(668, 1)
        Me.MaterialDivider1.TabIndex = 49
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnNewLoc
        '
        Me.btnNewLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewLoc.Depth = 0
        Me.btnNewLoc.DrawShadows = True
        Me.btnNewLoc.HighEmphasis = True
        Me.btnNewLoc.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnNewLoc.Location = New System.Drawing.Point(326, 198)
        Me.btnNewLoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNewLoc.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNewLoc.Name = "btnNewLoc"
        Me.btnNewLoc.Size = New System.Drawing.Size(44, 36)
        Me.btnNewLoc.TabIndex = 50
        Me.btnNewLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnNewLoc.UseAccentColor = False
        Me.btnNewLoc.UseVisualStyleBackColor = True
        '
        'btnNewTrousseau
        '
        Me.btnNewTrousseau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewTrousseau.Depth = 0
        Me.btnNewTrousseau.DrawShadows = True
        Me.btnNewTrousseau.HighEmphasis = True
        Me.btnNewTrousseau.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnNewTrousseau.Location = New System.Drawing.Point(326, 323)
        Me.btnNewTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNewTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNewTrousseau.Name = "btnNewTrousseau"
        Me.btnNewTrousseau.Size = New System.Drawing.Size(44, 36)
        Me.btnNewTrousseau.TabIndex = 51
        Me.btnNewTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnNewTrousseau.UseAccentColor = False
        Me.btnNewTrousseau.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox1
        '
        Me.MaterialCheckbox1.Depth = 0
        Me.MaterialCheckbox1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCheckbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox1.Name = "MaterialCheckbox1"
        Me.MaterialCheckbox1.Ripple = True
        Me.MaterialCheckbox1.Size = New System.Drawing.Size(104, 37)
        Me.MaterialCheckbox1.TabIndex = 0
        Me.MaterialCheckbox1.Text = "MaterialCheckbox1"
        Me.MaterialCheckbox1.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox2
        '
        Me.MaterialCheckbox2.Depth = 0
        Me.MaterialCheckbox2.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCheckbox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox2.Name = "MaterialCheckbox2"
        Me.MaterialCheckbox2.Ripple = True
        Me.MaterialCheckbox2.Size = New System.Drawing.Size(104, 37)
        Me.MaterialCheckbox2.TabIndex = 0
        Me.MaterialCheckbox2.Text = "MaterialCheckbox2"
        Me.MaterialCheckbox2.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox3
        '
        Me.MaterialCheckbox3.Depth = 0
        Me.MaterialCheckbox3.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCheckbox3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox3.Name = "MaterialCheckbox3"
        Me.MaterialCheckbox3.Ripple = True
        Me.MaterialCheckbox3.Size = New System.Drawing.Size(104, 37)
        Me.MaterialCheckbox3.TabIndex = 0
        Me.MaterialCheckbox3.Text = "MaterialCheckbox3"
        Me.MaterialCheckbox3.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox4
        '
        Me.MaterialCheckbox4.Depth = 0
        Me.MaterialCheckbox4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCheckbox4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox4.Name = "MaterialCheckbox4"
        Me.MaterialCheckbox4.Ripple = True
        Me.MaterialCheckbox4.Size = New System.Drawing.Size(104, 37)
        Me.MaterialCheckbox4.TabIndex = 0
        Me.MaterialCheckbox4.Text = "MaterialCheckbox4"
        Me.MaterialCheckbox4.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Depth = 0
        Me.txtQuantity.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtQuantity.Location = New System.Drawing.Point(137, 115)
        Me.txtQuantity.MaxLength = 50
        Me.txtQuantity.MouseState = MaterialSkin.MouseState.OUT
        Me.txtQuantity.Multiline = False
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(182, 36)
        Me.txtQuantity.TabIndex = 53
        Me.txtQuantity.Text = ""
        Me.txtQuantity.UseTallSize = False
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Depth = 0
        Me.lblQuantity.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblQuantity.Location = New System.Drawing.Point(12, 124)
        Me.lblQuantity.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(69, 19)
        Me.lblQuantity.TabIndex = 52
        Me.lblQuantity.Text = "Quantité :"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoResize = False
        Me.cmbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.Depth = 0
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbStatus.DropDownHeight = 118
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.DropDownWidth = 121
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Hint = "Status"
        Me.cmbStatus.IntegralHeight = False
        Me.cmbStatus.ItemHeight = 29
        Me.cmbStatus.Location = New System.Drawing.Point(137, 240)
        Me.cmbStatus.MaxDropDownItems = 4
        Me.cmbStatus.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(182, 35)
        Me.cmbStatus.TabIndex = 54
        Me.cmbStatus.UseTallSize = False
        '
        'lblBatiment
        '
        Me.lblBatiment.Depth = 0
        Me.lblBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBatiment.Location = New System.Drawing.Point(134, 395)
        Me.lblBatiment.MaximumSize = New System.Drawing.Size(235, 71)
        Me.lblBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBatiment.Name = "lblBatiment"
        Me.lblBatiment.Size = New System.Drawing.Size(235, 71)
        Me.lblBatiment.TabIndex = 55
        Me.lblBatiment.Text = "Bâtiment"
        '
        'swtEditOneKey
        '
        Me.swtEditOneKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.swtEditOneKey.AutoSize = True
        Me.swtEditOneKey.Depth = 0
        Me.swtEditOneKey.Location = New System.Drawing.Point(240, 474)
        Me.swtEditOneKey.Margin = New System.Windows.Forms.Padding(0)
        Me.swtEditOneKey.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtEditOneKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtEditOneKey.Name = "swtEditOneKey"
        Me.swtEditOneKey.Ripple = True
        Me.swtEditOneKey.Size = New System.Drawing.Size(199, 37)
        Me.swtEditOneKey.TabIndex = 56
        Me.swtEditOneKey.Text = "Editer une seule clef"
        Me.swtEditOneKey.UseVisualStyleBackColor = True
        Me.swtEditOneKey.Visible = False
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.Location = New System.Drawing.Point(393, 73)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(200, 19)
        Me.MaterialLabel10.TabIndex = 74
        Me.MaterialLabel10.Text = "Références/Organigrammes"
        '
        'txtCnOpt
        '
        Me.txtCnOpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnOpt.Depth = 0
        Me.txtCnOpt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnOpt.Hint = "Options"
        Me.txtCnOpt.Location = New System.Drawing.Point(396, 240)
        Me.txtCnOpt.MaxLength = 255
        Me.txtCnOpt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnOpt.Multiline = False
        Me.txtCnOpt.Name = "txtCnOpt"
        Me.txtCnOpt.Size = New System.Drawing.Size(197, 36)
        Me.txtCnOpt.TabIndex = 73
        Me.txtCnOpt.Text = ""
        Me.txtCnOpt.UseTallSize = False
        '
        'txtCnExt
        '
        Me.txtCnExt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnExt.Depth = 0
        Me.txtCnExt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnExt.Hint = "Extérieur"
        Me.txtCnExt.Location = New System.Drawing.Point(507, 197)
        Me.txtCnExt.MaxLength = 20
        Me.txtCnExt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnExt.Multiline = False
        Me.txtCnExt.Name = "txtCnExt"
        Me.txtCnExt.Size = New System.Drawing.Size(86, 36)
        Me.txtCnExt.TabIndex = 72
        Me.txtCnExt.Text = ""
        Me.txtCnExt.UseTallSize = False
        '
        'txtCnInt
        '
        Me.txtCnInt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnInt.Depth = 0
        Me.txtCnInt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnInt.Hint = "Intérieur"
        Me.txtCnInt.Location = New System.Drawing.Point(396, 197)
        Me.txtCnInt.MaxLength = 20
        Me.txtCnInt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnInt.Multiline = False
        Me.txtCnInt.Name = "txtCnInt"
        Me.txtCnInt.Size = New System.Drawing.Size(86, 36)
        Me.txtCnInt.TabIndex = 71
        Me.txtCnInt.Text = ""
        Me.txtCnInt.UseTallSize = False
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(393, 176)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(195, 19)
        Me.MaterialLabel9.TabIndex = 70
        Me.MaterialLabel9.Text = "Canon (intérieur x extérieur)"
        '
        'txtRefOrg
        '
        Me.txtRefOrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefOrg.Depth = 0
        Me.txtRefOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtRefOrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRefOrg.Hint = "Informations complémentaires"
        Me.txtRefOrg.Location = New System.Drawing.Point(396, 97)
        Me.txtRefOrg.MaxLength = 512
        Me.txtRefOrg.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRefOrg.Name = "txtRefOrg"
        Me.txtRefOrg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.txtRefOrg.Size = New System.Drawing.Size(197, 76)
        Me.txtRefOrg.TabIndex = 69
        Me.txtRefOrg.Text = ""
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(375, 78)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(1, 362)
        Me.MaterialDivider2.TabIndex = 77
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(488, 206)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel1.TabIndex = 75
        Me.MaterialLabel1.Text = " x "
        '
        'txtEmprunteur
        '
        Me.txtEmprunteur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmprunteur.Depth = 0
        Me.txtEmprunteur.DetectUrls = False
        Me.txtEmprunteur.Enabled = False
        Me.txtEmprunteur.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtEmprunteur.Hint = "Emprunteur"
        Me.txtEmprunteur.Location = New System.Drawing.Point(396, 312)
        Me.txtEmprunteur.MaxLength = 50
        Me.txtEmprunteur.MouseState = MaterialSkin.MouseState.OUT
        Me.txtEmprunteur.Multiline = False
        Me.txtEmprunteur.Name = "txtEmprunteur"
        Me.txtEmprunteur.Size = New System.Drawing.Size(197, 36)
        Me.txtEmprunteur.TabIndex = 79
        Me.txtEmprunteur.Text = ""
        Me.txtEmprunteur.UseTallSize = False
        '
        'lblEmprunteur
        '
        Me.lblEmprunteur.AutoSize = True
        Me.lblEmprunteur.Depth = 0
        Me.lblEmprunteur.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblEmprunteur.Location = New System.Drawing.Point(393, 290)
        Me.lblEmprunteur.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEmprunteur.Name = "lblEmprunteur"
        Me.lblEmprunteur.Size = New System.Drawing.Size(91, 19)
        Me.lblEmprunteur.TabIndex = 78
        Me.lblEmprunteur.Text = "Emprunteur :"
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Depth = 0
        Me.lblDateDebut.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateDebut.Location = New System.Drawing.Point(393, 400)
        Me.lblDateDebut.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(66, 19)
        Me.lblDateDebut.TabIndex = 81
        Me.lblDateDebut.Text = "Depuis le"
        '
        'dtpDebut
        '
        Me.dtpDebut.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDebut.Enabled = False
        Me.dtpDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDebut.Location = New System.Drawing.Point(465, 396)
        Me.dtpDebut.Name = "dtpDebut"
        Me.dtpDebut.Size = New System.Drawing.Size(128, 26)
        Me.dtpDebut.TabIndex = 80
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Depth = 0
        Me.lblDateFin.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateFin.Location = New System.Drawing.Point(393, 436)
        Me.lblDateFin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(70, 19)
        Me.lblDateFin.TabIndex = 83
        Me.lblDateFin.Text = "Jusqu'au "
        Me.lblDateFin.Visible = False
        '
        'dtpFin
        '
        Me.dtpFin.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Enabled = False
        Me.dtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(465, 432)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(128, 26)
        Me.dtpFin.TabIndex = 82
        Me.dtpFin.Visible = False
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel.Depth = 0
        Me.txtTel.DetectUrls = False
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtTel.Hint = "Téléphone"
        Me.txtTel.Location = New System.Drawing.Point(396, 354)
        Me.txtTel.MaxLength = 50
        Me.txtTel.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTel.Multiline = False
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(197, 36)
        Me.txtTel.TabIndex = 84
        Me.txtTel.Text = ""
        Me.txtTel.UseTallSize = False
        '
        'frmEditerEtProprietes
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 522)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblDateFin)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.lblDateDebut)
        Me.Controls.Add(Me.dtpDebut)
        Me.Controls.Add(Me.txtEmprunteur)
        Me.Controls.Add(Me.lblEmprunteur)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.txtCnOpt)
        Me.Controls.Add(Me.txtCnExt)
        Me.Controls.Add(Me.txtCnInt)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.txtRefOrg)
        Me.Controls.Add(Me.swtEditOneKey)
        Me.Controls.Add(Me.lblBatiment)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnNewTrousseau)
        Me.Controls.Add(Me.btnNewLoc)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.lblCBatiment)
        Me.Controls.Add(Me.lblCTrousseau)
        Me.Controls.Add(Me.lblCDate)
        Me.Controls.Add(Me.btnGrpBatiment)
        Me.Controls.Add(Me.cmbTrousseauListe)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblCStatus)
        Me.Controls.Add(Me.lblCPosition)
        Me.Controls.Add(Me.lblCNom)
        Me.Controls.Add(Me.lblCID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDate)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(614, 522)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(614, 522)
        Me.Name = "frmEditerEtProprietes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Editer une clef..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblCID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCPosition As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cmbLoc As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbTrousseauListe As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnGrpBatiment As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblCDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCTrousseau As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnNewLoc As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNewTrousseau As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox2 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox3 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox4 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents txtQuantity As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblQuantity As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbStatus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents swtEditOneKey As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtCnOpt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCnExt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCnInt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtRefOrg As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEmprunteur As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblEmprunteur As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateDebut As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpDebut As DateTimePicker
    Friend WithEvents lblDateFin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents txtTel As MaterialSkin.Controls.MaterialTextBox
End Class
