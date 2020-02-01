<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAjouterClef
    Inherits System.Windows.Forms.Form

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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.udQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkKeepOpen = New System.Windows.Forms.CheckBox()
        Me.cmbTrousseauListe = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewLoc = New System.Windows.Forms.Button()
        Me.btnNewTrousseau = New System.Windows.Forms.Button()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnAddSelBatiment = New System.Windows.Forms.Button()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.btnAddBatiment = New System.Windows.Forms.Button()
        Me.btnRemSelBatiment = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvSelBatiment = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbEmprunteur = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFinEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDebutEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmbNomEmprunteur = New System.Windows.Forms.ComboBox()
        CType(Me.udQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSelBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbEmprunteur.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(9, 32)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(71, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'udQuantity
        '
        Me.udQuantity.Location = New System.Drawing.Point(86, 32)
        Me.udQuantity.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.udQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udQuantity.Name = "udQuantity"
        Me.udQuantity.Size = New System.Drawing.Size(71, 20)
        Me.udQuantity.TabIndex = 4
        Me.udQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(9, 72)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(208, 20)
        Me.txtNom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantité"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Disponible", "Empruntée", "Attribuée", "Perdue"})
        Me.cmbStatus.Location = New System.Drawing.Point(9, 190)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(208, 21)
        Me.cmbStatus.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Trousseau"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(436, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(243, 32)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(685, 366)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 32)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Location = New System.Drawing.Point(274, 373)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New System.Drawing.Size(144, 17)
        Me.chkKeepOpen.TabIndex = 15
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'cmbTrousseauListe
        '
        Me.cmbTrousseauListe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTrousseauListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrousseauListe.FormattingEnabled = True
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(9, 150)
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(208, 21)
        Me.cmbTrousseauListe.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 233)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Date d'ajout"
        '
        'cmbLoc
        '
        Me.cmbLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(9, 110)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(208, 21)
        Me.cmbLoc.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Localisation de la clef"
        '
        'btnNewLoc
        '
        Me.btnNewLoc.Location = New System.Drawing.Point(223, 109)
        Me.btnNewLoc.Name = "btnNewLoc"
        Me.btnNewLoc.Size = New System.Drawing.Size(23, 23)
        Me.btnNewLoc.TabIndex = 37
        Me.btnNewLoc.Text = "+"
        Me.btnNewLoc.UseVisualStyleBackColor = True
        '
        'btnNewTrousseau
        '
        Me.btnNewTrousseau.Location = New System.Drawing.Point(223, 149)
        Me.btnNewTrousseau.Name = "btnNewTrousseau"
        Me.btnNewTrousseau.Size = New System.Drawing.Size(23, 23)
        Me.btnNewTrousseau.TabIndex = 36
        Me.btnNewTrousseau.Text = "+"
        Me.btnNewTrousseau.UseVisualStyleBackColor = True
        '
        'txtRechercher
        '
        Me.txtRechercher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRechercher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRechercher.Location = New System.Drawing.Point(6, 17)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(384, 20)
        Me.txtRechercher.TabIndex = 0
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(252, 43)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(138, 23)
        Me.btnRechercher.TabIndex = 6
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'btnAddSelBatiment
        '
        Me.btnAddSelBatiment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSelBatiment.Location = New System.Drawing.Point(249, 190)
        Me.btnAddSelBatiment.Name = "btnAddSelBatiment"
        Me.btnAddSelBatiment.Size = New System.Drawing.Size(42, 29)
        Me.btnAddSelBatiment.TabIndex = 41
        Me.btnAddSelBatiment.Text = "→"
        Me.btnAddSelBatiment.UseVisualStyleBackColor = True
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Controls.Add(Me.btnAddBatiment)
        Me.gbRechercher.Controls.Add(Me.btnRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(6, 17)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(404, 75)
        Me.gbRechercher.TabIndex = 42
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher un bâtiment"
        '
        'btnAddBatiment
        '
        Me.btnAddBatiment.Location = New System.Drawing.Point(6, 43)
        Me.btnAddBatiment.Name = "btnAddBatiment"
        Me.btnAddBatiment.Size = New System.Drawing.Size(240, 23)
        Me.btnAddBatiment.TabIndex = 43
        Me.btnAddBatiment.Text = "Gérer ou ajouter un bâtiment"
        Me.btnAddBatiment.UseVisualStyleBackColor = True
        '
        'btnRemSelBatiment
        '
        Me.btnRemSelBatiment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemSelBatiment.Location = New System.Drawing.Point(249, 225)
        Me.btnRemSelBatiment.Name = "btnRemSelBatiment"
        Me.btnRemSelBatiment.Size = New System.Drawing.Size(42, 29)
        Me.btnRemSelBatiment.TabIndex = 40
        Me.btnRemSelBatiment.Text = "←"
        Me.btnRemSelBatiment.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSelBatiment)
        Me.GroupBox2.Location = New System.Drawing.Point(297, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 244)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bâtiment où utiliser la clef"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelBatiment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSelBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSelBatiment.Location = New System.Drawing.Point(6, 21)
        Me.dgvSelBatiment.MultiSelect = False
        Me.dgvSelBatiment.Name = "dgvSelBatiment"
        Me.dgvSelBatiment.ReadOnly = True
        Me.dgvSelBatiment.RowHeadersVisible = False
        Me.dgvSelBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSelBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelBatiment.Size = New System.Drawing.Size(225, 217)
        Me.dgvSelBatiment.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListBatiment)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 244)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des bâtiments"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListBatiment.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListBatiment.Location = New System.Drawing.Point(6, 21)
        Me.dgvListBatiment.MultiSelect = False
        Me.dgvListBatiment.Name = "dgvListBatiment"
        Me.dgvListBatiment.ReadOnly = True
        Me.dgvListBatiment.RowHeadersVisible = False
        Me.dgvListBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBatiment.Size = New System.Drawing.Size(225, 217)
        Me.dgvListBatiment.TabIndex = 45
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.btnAddSelBatiment)
        Me.GroupBox3.Controls.Add(Me.gbRechercher)
        Me.GroupBox3.Controls.Add(Me.btnRemSelBatiment)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(274, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 348)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bâtiments"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gbEmprunteur)
        Me.GroupBox4.Controls.Add(Me.btnNewLoc)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.btnNewTrousseau)
        Me.GroupBox4.Controls.Add(Me.cmbLoc)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmbTrousseauListe)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cmbStatus)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtID)
        Me.GroupBox4.Controls.Add(Me.udQuantity)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtNom)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 386)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Informations"
        '
        'gbEmprunteur
        '
        Me.gbEmprunteur.Controls.Add(Me.Label10)
        Me.gbEmprunteur.Controls.Add(Me.dtpFinEmprunt)
        Me.gbEmprunteur.Controls.Add(Me.Label9)
        Me.gbEmprunteur.Controls.Add(Me.dtpDebutEmprunt)
        Me.gbEmprunteur.Controls.Add(Me.Button5)
        Me.gbEmprunteur.Controls.Add(Me.cmbNomEmprunteur)
        Me.gbEmprunteur.Enabled = False
        Me.gbEmprunteur.Location = New System.Drawing.Point(0, 259)
        Me.gbEmprunteur.Name = "gbEmprunteur"
        Me.gbEmprunteur.Size = New System.Drawing.Size(256, 127)
        Me.gbEmprunteur.TabIndex = 49
        Me.gbEmprunteur.TabStop = False
        Me.gbEmprunteur.Text = "Emprunteur"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Au"
        '
        'dtpFinEmprunt
        '
        Me.dtpFinEmprunt.Location = New System.Drawing.Point(9, 97)
        Me.dtpFinEmprunt.Name = "dtpFinEmprunt"
        Me.dtpFinEmprunt.Size = New System.Drawing.Size(208, 20)
        Me.dtpFinEmprunt.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Emprunter du"
        '
        'dtpDebutEmprunt
        '
        Me.dtpDebutEmprunt.Location = New System.Drawing.Point(9, 58)
        Me.dtpDebutEmprunt.Name = "dtpDebutEmprunt"
        Me.dtpDebutEmprunt.Size = New System.Drawing.Size(208, 20)
        Me.dtpDebutEmprunt.TabIndex = 45
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(223, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmbNomEmprunteur
        '
        Me.cmbNomEmprunteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNomEmprunteur.FormattingEnabled = True
        Me.cmbNomEmprunteur.Items.AddRange(New Object() {"Disponible", "Empruntée", "Attribuée", "Perdue"})
        Me.cmbNomEmprunteur.Location = New System.Drawing.Point(9, 19)
        Me.cmbNomEmprunteur.Name = "cmbNomEmprunteur"
        Me.cmbNomEmprunteur.Size = New System.Drawing.Size(208, 21)
        Me.cmbNomEmprunteur.TabIndex = 38
        '
        'frmAjouterClef
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(827, 404)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjouterClef"
        Me.ShowIcon = False
        Me.Text = "Ajout d'une clef..."
        CType(Me.udQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSelBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbEmprunteur.ResumeLayout(False)
        Me.gbEmprunteur.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents udQuantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents cmbTrousseauListe As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbLoc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNewLoc As Button
    Friend WithEvents btnNewTrousseau As Button
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnAddSelBatiment As Button
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents btnAddBatiment As Button
    Friend WithEvents btnRemSelBatiment As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbEmprunteur As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFinEmprunt As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDebutEmprunt As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents cmbNomEmprunteur As ComboBox
    Friend WithEvents dgvListBatiment As DataGridView
    Friend WithEvents dgvSelBatiment As DataGridView
End Class
