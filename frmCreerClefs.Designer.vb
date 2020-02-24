<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreerClefs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreerClefs))
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.cmbLoc = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbTrousseauListe = New MaterialSkin.Controls.MaterialComboBox()
        Me.chkKeepOpen = New MaterialSkin.Controls.MaterialCheckbox()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.dgvSelBatiment = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnAddSelBatiment = New MaterialSkin.Controls.MaterialButton()
        Me.btnRemSelBatiment = New MaterialSkin.Controls.MaterialButton()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnAddBatiment = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtQuantity = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnNewLoc = New MaterialSkin.Controls.MaterialButton()
        Me.btnNewTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.txtRefOrg = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtCnInt = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCnExt = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCnOpt = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtID.Hint = "N° de clef"
        Me.txtID.Location = New System.Drawing.Point(12, 96)
        Me.txtID.MaxLength = 50
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(203, 36)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = ""
        Me.txtID.UseTallSize = False
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Hint = "Accès"
        Me.txtNom.Location = New System.Drawing.Point(12, 157)
        Me.txtNom.MaxLength = 50
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(203, 36)
        Me.txtNom.TabIndex = 2
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
        Me.cmbLoc.Hint = "Tableau"
        Me.cmbLoc.IntegralHeight = False
        Me.cmbLoc.ItemHeight = 29
        Me.cmbLoc.Location = New System.Drawing.Point(12, 218)
        Me.cmbLoc.MaxDropDownItems = 4
        Me.cmbLoc.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(203, 35)
        Me.cmbLoc.TabIndex = 3
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
        Me.cmbTrousseauListe.Hint = "Trousseau"
        Me.cmbTrousseauListe.IntegralHeight = False
        Me.cmbTrousseauListe.ItemHeight = 29
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(12, 278)
        Me.cmbTrousseauListe.MaxDropDownItems = 4
        Me.cmbTrousseauListe.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(203, 35)
        Me.cmbTrousseauListe.TabIndex = 5
        Me.cmbTrousseauListe.UseTallSize = False
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Depth = 0
        Me.chkKeepOpen.Location = New System.Drawing.Point(465, 425)
        Me.chkKeepOpen.Margin = New System.Windows.Forms.Padding(0)
        Me.chkKeepOpen.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkKeepOpen.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Ripple = True
        Me.chkKeepOpen.Size = New System.Drawing.Size(208, 37)
        Me.chkKeepOpen.TabIndex = 14
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'dgvListBatiment
        '
        Me.dgvListBatiment.AllowUserToAddRows = False
        Me.dgvListBatiment.AllowUserToDeleteRows = False
        Me.dgvListBatiment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListBatiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListBatiment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListBatiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListBatiment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListBatiment.Location = New System.Drawing.Point(293, 157)
        Me.dgvListBatiment.MultiSelect = False
        Me.dgvListBatiment.Name = "dgvListBatiment"
        Me.dgvListBatiment.ReadOnly = True
        Me.dgvListBatiment.RowHeadersVisible = False
        Me.dgvListBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBatiment.Size = New System.Drawing.Size(225, 209)
        Me.dgvListBatiment.TabIndex = 10
        '
        'dgvSelBatiment
        '
        Me.dgvSelBatiment.AllowUserToAddRows = False
        Me.dgvSelBatiment.AllowUserToDeleteRows = False
        Me.dgvSelBatiment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSelBatiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelBatiment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSelBatiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelBatiment.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSelBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSelBatiment.Location = New System.Drawing.Point(576, 160)
        Me.dgvSelBatiment.MultiSelect = False
        Me.dgvSelBatiment.Name = "dgvSelBatiment"
        Me.dgvSelBatiment.ReadOnly = True
        Me.dgvSelBatiment.RowHeadersVisible = False
        Me.dgvSelBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSelBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelBatiment.Size = New System.Drawing.Size(225, 206)
        Me.dgvSelBatiment.TabIndex = 13
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(290, 135)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(139, 19)
        Me.MaterialLabel1.TabIndex = 47
        Me.MaterialLabel1.Text = "Liste des bâtiments"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(573, 138)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(100, 19)
        Me.MaterialLabel2.TabIndex = 48
        Me.MaterialLabel2.Text = "La clef ouvre :"
        '
        'btnAddSelBatiment
        '
        Me.btnAddSelBatiment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnAddSelBatiment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddSelBatiment.Depth = 0
        Me.btnAddSelBatiment.DrawShadows = True
        Me.btnAddSelBatiment.HighEmphasis = True
        Me.btnAddSelBatiment.Icon = Global.GestionClefs.My.Resources.Resources.keyboard_right_arrow_button
        Me.btnAddSelBatiment.Location = New System.Drawing.Point(525, 218)
        Me.btnAddSelBatiment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddSelBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddSelBatiment.Name = "btnAddSelBatiment"
        Me.btnAddSelBatiment.Size = New System.Drawing.Size(44, 36)
        Me.btnAddSelBatiment.TabIndex = 11
        Me.btnAddSelBatiment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnAddSelBatiment.UseAccentColor = False
        Me.btnAddSelBatiment.UseVisualStyleBackColor = True
        '
        'btnRemSelBatiment
        '
        Me.btnRemSelBatiment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnRemSelBatiment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRemSelBatiment.Depth = 0
        Me.btnRemSelBatiment.DrawShadows = True
        Me.btnRemSelBatiment.HighEmphasis = True
        Me.btnRemSelBatiment.Icon = Global.GestionClefs.My.Resources.Resources.left_arrow_key
        Me.btnRemSelBatiment.Location = New System.Drawing.Point(525, 266)
        Me.btnRemSelBatiment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRemSelBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRemSelBatiment.Name = "btnRemSelBatiment"
        Me.btnRemSelBatiment.Size = New System.Drawing.Size(44, 36)
        Me.btnRemSelBatiment.TabIndex = 12
        Me.btnRemSelBatiment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnRemSelBatiment.UseAccentColor = False
        Me.btnRemSelBatiment.UseVisualStyleBackColor = True
        '
        'txtRechercher
        '
        Me.txtRechercher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher un bâtiment"
        Me.txtRechercher.Location = New System.Drawing.Point(293, 96)
        Me.txtRechercher.MaxLength = 50
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(320, 36)
        Me.txtRechercher.TabIndex = 8
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'btnAddBatiment
        '
        Me.btnAddBatiment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBatiment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddBatiment.Depth = 0
        Me.btnAddBatiment.DrawShadows = True
        Me.btnAddBatiment.HighEmphasis = True
        Me.btnAddBatiment.Icon = Nothing
        Me.btnAddBatiment.Location = New System.Drawing.Point(620, 96)
        Me.btnAddBatiment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddBatiment.Name = "btnAddBatiment"
        Me.btnAddBatiment.Size = New System.Drawing.Size(181, 36)
        Me.btnAddBatiment.TabIndex = 9
        Me.btnAddBatiment.Text = "Gérer les bâtiments"
        Me.btnAddBatiment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnAddBatiment.UseAccentColor = False
        Me.btnAddBatiment.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 74)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(80, 19)
        Me.MaterialLabel3.TabIndex = 53
        Me.MaterialLabel3.Text = "N° de clef *"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(12, 135)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(54, 19)
        Me.MaterialLabel4.TabIndex = 54
        Me.MaterialLabel4.Text = "Accès *"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.Location = New System.Drawing.Point(12, 196)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel5.TabIndex = 55
        Me.MaterialLabel5.Text = "Tableau *"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.Location = New System.Drawing.Point(12, 256)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel6.TabIndex = 56
        Me.MaterialLabel6.Text = "Trousseau *"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.Location = New System.Drawing.Point(12, 316)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel7.TabIndex = 57
        Me.MaterialLabel7.Text = "Quantité *"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Depth = 0
        Me.txtQuantity.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtQuantity.Hint = "Quantité"
        Me.txtQuantity.Location = New System.Drawing.Point(11, 338)
        Me.txtQuantity.MaxLength = 50
        Me.txtQuantity.MouseState = MaterialSkin.MouseState.OUT
        Me.txtQuantity.Multiline = False
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(204, 36)
        Me.txtQuantity.TabIndex = 7
        Me.txtQuantity.Text = ""
        Me.txtQuantity.UseTallSize = False
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.Location = New System.Drawing.Point(290, 74)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(84, 19)
        Me.MaterialLabel8.TabIndex = 59
        Me.MaterialLabel8.Text = "Bâtiments *"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(702, 424)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(10, 379)
        Me.MaterialDivider1.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(794, 1)
        Me.MaterialDivider1.TabIndex = 61
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(273, 74)
        Me.MaterialDivider2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(1, 292)
        Me.MaterialDivider2.TabIndex = 62
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'btnNewLoc
        '
        Me.btnNewLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewLoc.Depth = 0
        Me.btnNewLoc.DrawShadows = True
        Me.btnNewLoc.HighEmphasis = True
        Me.btnNewLoc.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnNewLoc.Location = New System.Drawing.Point(222, 217)
        Me.btnNewLoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNewLoc.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNewLoc.Name = "btnNewLoc"
        Me.btnNewLoc.Size = New System.Drawing.Size(44, 36)
        Me.btnNewLoc.TabIndex = 4
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
        Me.btnNewTrousseau.Location = New System.Drawing.Point(222, 277)
        Me.btnNewTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNewTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNewTrousseau.Name = "btnNewTrousseau"
        Me.btnNewTrousseau.Size = New System.Drawing.Size(44, 36)
        Me.btnNewTrousseau.TabIndex = 6
        Me.btnNewTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnNewTrousseau.UseAccentColor = False
        Me.btnNewTrousseau.UseVisualStyleBackColor = True
        '
        'txtRefOrg
        '
        Me.txtRefOrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefOrg.Depth = 0
        Me.txtRefOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtRefOrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRefOrg.Hint = "Informations complémentaires"
        Me.txtRefOrg.Location = New System.Drawing.Point(12, 413)
        Me.txtRefOrg.MaxLength = 512
        Me.txtRefOrg.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRefOrg.Name = "txtRefOrg"
        Me.txtRefOrg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.txtRefOrg.Size = New System.Drawing.Size(223, 76)
        Me.txtRefOrg.TabIndex = 63
        Me.txtRefOrg.Text = ""
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(238, 389)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel9.TabIndex = 64
        Me.MaterialLabel9.Text = "Canon"
        '
        'txtCnInt
        '
        Me.txtCnInt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnInt.Depth = 0
        Me.txtCnInt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnInt.Hint = "Intérieur"
        Me.txtCnInt.Location = New System.Drawing.Point(241, 411)
        Me.txtCnInt.MaxLength = 20
        Me.txtCnInt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnInt.Multiline = False
        Me.txtCnInt.Name = "txtCnInt"
        Me.txtCnInt.Size = New System.Drawing.Size(86, 36)
        Me.txtCnInt.TabIndex = 65
        Me.txtCnInt.Text = ""
        Me.txtCnInt.UseTallSize = False
        '
        'txtCnExt
        '
        Me.txtCnExt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnExt.Depth = 0
        Me.txtCnExt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnExt.Hint = "Extérieur"
        Me.txtCnExt.Location = New System.Drawing.Point(333, 411)
        Me.txtCnExt.MaxLength = 20
        Me.txtCnExt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnExt.Multiline = False
        Me.txtCnExt.Name = "txtCnExt"
        Me.txtCnExt.Size = New System.Drawing.Size(86, 36)
        Me.txtCnExt.TabIndex = 66
        Me.txtCnExt.Text = ""
        Me.txtCnExt.UseTallSize = False
        '
        'txtCnOpt
        '
        Me.txtCnOpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCnOpt.Depth = 0
        Me.txtCnOpt.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCnOpt.Hint = "Options"
        Me.txtCnOpt.Location = New System.Drawing.Point(240, 453)
        Me.txtCnOpt.MaxLength = 255
        Me.txtCnOpt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCnOpt.Multiline = False
        Me.txtCnOpt.Name = "txtCnOpt"
        Me.txtCnOpt.Size = New System.Drawing.Size(179, 36)
        Me.txtCnOpt.TabIndex = 67
        Me.txtCnOpt.Text = ""
        Me.txtCnOpt.UseTallSize = False
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.Location = New System.Drawing.Point(9, 389)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(200, 19)
        Me.MaterialLabel10.TabIndex = 68
        Me.MaterialLabel10.Text = "Références/Organigrammes"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(439, 392)
        Me.MaterialDivider3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(1, 101)
        Me.MaterialDivider3.TabIndex = 69
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'frmCreerClefs
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 504)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.txtCnOpt)
        Me.Controls.Add(Me.txtCnExt)
        Me.Controls.Add(Me.txtCnInt)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.txtRefOrg)
        Me.Controls.Add(Me.btnNewTrousseau)
        Me.Controls.Add(Me.btnNewLoc)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.btnRemSelBatiment)
        Me.Controls.Add(Me.btnAddSelBatiment)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dgvSelBatiment)
        Me.Controls.Add(Me.dgvListBatiment)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.cmbTrousseauListe)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.btnAddBatiment)
        Me.Controls.Add(Me.txtID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(817, 504)
        Me.MinimumSize = New System.Drawing.Size(817, 460)
        Me.Name = "frmCreerClefs"
        Me.Text = "Ajouter une clef au gestionnaire"
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cmbLoc As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbTrousseauListe As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents chkKeepOpen As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents dgvListBatiment As DataGridView
    Friend WithEvents dgvSelBatiment As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAddSelBatiment As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRemSelBatiment As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnAddBatiment As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtQuantity As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnNewLoc As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNewTrousseau As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtRefOrg As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtCnInt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCnExt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCnOpt As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
End Class
