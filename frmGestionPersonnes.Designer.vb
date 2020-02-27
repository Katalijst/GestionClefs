<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPersonnes
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionPersonnes))
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListPersonne = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabAjouter = New System.Windows.Forms.TabPage()
        Me.btnDelType = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddType = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtAutre = New MaterialSkin.Controls.MaterialTextBox()
        Me.chkKeepOpen = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.mtxtTel = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbType = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.tabRechercher = New System.Windows.Forms.TabPage()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListPersonne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.tabAjouter.SuspendLayout()
        Me.tabRechercher.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(5, 5)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(404, 45)
        Me.gbRechercher.TabIndex = 61
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher une personne"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListPersonne)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 229)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des personnes"
        '
        'dgvListPersonne
        '
        Me.dgvListPersonne.AllowUserToAddRows = False
        Me.dgvListPersonne.AllowUserToDeleteRows = False
        Me.dgvListPersonne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListPersonne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListPersonne.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListPersonne.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListPersonne.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListPersonne.Location = New System.Drawing.Point(6, 21)
        Me.dgvListPersonne.MultiSelect = False
        Me.dgvListPersonne.Name = "dgvListPersonne"
        Me.dgvListPersonne.ReadOnly = True
        Me.dgvListPersonne.RowHeadersVisible = False
        Me.dgvListPersonne.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListPersonne.Size = New System.Drawing.Size(392, 202)
        Me.dgvListPersonne.TabIndex = 45
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditerToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 48)
        '
        'EditerToolStripMenuItem
        '
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.EditerToolStripMenuItem.Text = "Editer"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.tabAjouter)
        Me.MaterialTabControl1.Controls.Add(Me.tabRechercher)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 73)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(422, 317)
        Me.MaterialTabControl1.TabIndex = 46
        '
        'tabAjouter
        '
        Me.tabAjouter.BackColor = System.Drawing.SystemColors.Control
        Me.tabAjouter.Controls.Add(Me.btnDelType)
        Me.tabAjouter.Controls.Add(Me.btnAddType)
        Me.tabAjouter.Controls.Add(Me.MaterialLabel4)
        Me.tabAjouter.Controls.Add(Me.txtAutre)
        Me.tabAjouter.Controls.Add(Me.chkKeepOpen)
        Me.tabAjouter.Controls.Add(Me.MaterialLabel3)
        Me.tabAjouter.Controls.Add(Me.mtxtTel)
        Me.tabAjouter.Controls.Add(Me.MaterialLabel2)
        Me.tabAjouter.Controls.Add(Me.cmbType)
        Me.tabAjouter.Controls.Add(Me.MaterialLabel1)
        Me.tabAjouter.Controls.Add(Me.txtNom)
        Me.tabAjouter.Location = New System.Drawing.Point(4, 22)
        Me.tabAjouter.Name = "tabAjouter"
        Me.tabAjouter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAjouter.Size = New System.Drawing.Size(414, 291)
        Me.tabAjouter.TabIndex = 0
        Me.tabAjouter.Text = "Ajouter"
        '
        'btnDelType
        '
        Me.btnDelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelType.Depth = 0
        Me.btnDelType.DrawShadows = True
        Me.btnDelType.HighEmphasis = True
        Me.btnDelType.Icon = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.btnDelType.Location = New System.Drawing.Point(265, 28)
        Me.btnDelType.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelType.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelType.Name = "btnDelType"
        Me.btnDelType.Size = New System.Drawing.Size(130, 36)
        Me.btnDelType.TabIndex = 10
        Me.btnDelType.Text = "Supprimer"
        Me.btnDelType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnDelType.UseAccentColor = False
        Me.btnDelType.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddType.Depth = 0
        Me.btnAddType.DrawShadows = True
        Me.btnAddType.HighEmphasis = True
        Me.btnAddType.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddType.Location = New System.Drawing.Point(213, 28)
        Me.btnAddType.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddType.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(44, 36)
        Me.btnAddType.TabIndex = 9
        Me.btnAddType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddType.UseAccentColor = False
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(6, 189)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(99, 19)
        Me.MaterialLabel4.TabIndex = 8
        Me.MaterialLabel4.Text = "Complément :"
        '
        'txtAutre
        '
        Me.txtAutre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutre.Depth = 0
        Me.txtAutre.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtAutre.Hint = "Complément d'informations"
        Me.txtAutre.Location = New System.Drawing.Point(6, 211)
        Me.txtAutre.MaxLength = 50
        Me.txtAutre.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAutre.Multiline = False
        Me.txtAutre.Name = "txtAutre"
        Me.txtAutre.Size = New System.Drawing.Size(249, 36)
        Me.txtAutre.TabIndex = 7
        Me.txtAutre.Text = ""
        Me.txtAutre.UseTallSize = False
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Depth = 0
        Me.chkKeepOpen.Location = New System.Drawing.Point(6, 250)
        Me.chkKeepOpen.Margin = New System.Windows.Forms.Padding(0)
        Me.chkKeepOpen.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkKeepOpen.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Ripple = True
        Me.chkKeepOpen.Size = New System.Drawing.Size(208, 37)
        Me.chkKeepOpen.TabIndex = 6
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(6, 128)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Téléphone :"
        '
        'mtxtTel
        '
        Me.mtxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxtTel.Depth = 0
        Me.mtxtTel.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.mtxtTel.Hint = "Téléphone"
        Me.mtxtTel.Location = New System.Drawing.Point(6, 150)
        Me.mtxtTel.MaxLength = 50
        Me.mtxtTel.MouseState = MaterialSkin.MouseState.OUT
        Me.mtxtTel.Multiline = False
        Me.mtxtTel.Name = "mtxtTel"
        Me.mtxtTel.Size = New System.Drawing.Size(121, 36)
        Me.mtxtTel.TabIndex = 4
        Me.mtxtTel.Text = ""
        Me.mtxtTel.UseTallSize = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(6, 67)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Nom :"
        '
        'cmbType
        '
        Me.cmbType.AutoResize = False
        Me.cmbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.Depth = 0
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbType.DropDownHeight = 118
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.DropDownWidth = 121
        Me.cmbType.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Hint = "Fonction"
        Me.cmbType.IntegralHeight = False
        Me.cmbType.ItemHeight = 29
        Me.cmbType.Location = New System.Drawing.Point(6, 29)
        Me.cmbType.MaxDropDownItems = 4
        Me.cmbType.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 35)
        Me.cmbType.TabIndex = 2
        Me.cmbType.UseTallSize = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 7)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Fonction :"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Hint = "Nom de la personne"
        Me.txtNom.Location = New System.Drawing.Point(6, 89)
        Me.txtNom.MaxLength = 50
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(249, 36)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'tabRechercher
        '
        Me.tabRechercher.Controls.Add(Me.gbRechercher)
        Me.tabRechercher.Controls.Add(Me.GroupBox1)
        Me.tabRechercher.Location = New System.Drawing.Point(4, 22)
        Me.tabRechercher.Name = "tabRechercher"
        Me.tabRechercher.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRechercher.Size = New System.Drawing.Size(414, 291)
        Me.tabRechercher.TabIndex = 1
        Me.tabRechercher.Text = "Rechercher"
        Me.tabRechercher.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(351, 375)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.DrawShadows = True
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(254, 375)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(197, 27)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(239, 38)
        Me.MaterialTabSelector1.TabIndex = 65
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'frmGestionPersonnes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 422)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionPersonnes"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.Text = "Gérer les personnes"
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListPersonne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.tabAjouter.ResumeLayout(False)
        Me.tabAjouter.PerformLayout()
        Me.tabRechercher.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListPersonne As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabAjouter As TabPage
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtAutre As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents chkKeepOpen As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mtxtTel As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents tabRechercher As TabPage
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelType As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddType As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
End Class
