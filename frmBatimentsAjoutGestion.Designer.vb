<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatimentsAjoutGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatimentsAjoutGestion))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabAjouterBat = New System.Windows.Forms.TabPage()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.chkKeepOpen = New MaterialSkin.Controls.MaterialCheckbox()
        Me.lblFonction = New MaterialSkin.Controls.MaterialLabel()
        Me.lblID = New MaterialSkin.Controls.MaterialLabel()
        Me.txtFonction = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblAdresse = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtAdresse = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblNom = New MaterialSkin.Controls.MaterialLabel()
        Me.tabRechercher = New System.Windows.Forms.TabPage()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabAjouterBat.SuspendLayout()
        Me.tabRechercher.SuspendLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MaterialTabControl1.Controls.Add(Me.TabAjouterBat)
        Me.MaterialTabControl1.Controls.Add(Me.tabRechercher)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 65)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(594, 357)
        Me.MaterialTabControl1.TabIndex = 60
        '
        'TabAjouterBat
        '
        Me.TabAjouterBat.BackColor = System.Drawing.Color.White
        Me.TabAjouterBat.Controls.Add(Me.btnSave)
        Me.TabAjouterBat.Controls.Add(Me.btnCancel)
        Me.TabAjouterBat.Controls.Add(Me.chkKeepOpen)
        Me.TabAjouterBat.Controls.Add(Me.lblFonction)
        Me.TabAjouterBat.Controls.Add(Me.lblID)
        Me.TabAjouterBat.Controls.Add(Me.txtFonction)
        Me.TabAjouterBat.Controls.Add(Me.txtID)
        Me.TabAjouterBat.Controls.Add(Me.lblAdresse)
        Me.TabAjouterBat.Controls.Add(Me.txtNom)
        Me.TabAjouterBat.Controls.Add(Me.txtAdresse)
        Me.TabAjouterBat.Controls.Add(Me.lblNom)
        Me.TabAjouterBat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabAjouterBat.Location = New System.Drawing.Point(4, 22)
        Me.TabAjouterBat.Name = "TabAjouterBat"
        Me.TabAjouterBat.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAjouterBat.Size = New System.Drawing.Size(586, 331)
        Me.TabAjouterBat.TabIndex = 0
        Me.TabAjouterBat.Text = "Ajouter"
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(494, 289)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 65
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
        Me.btnCancel.Location = New System.Drawing.Point(14, 289)
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
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Depth = 0
        Me.chkKeepOpen.Location = New System.Drawing.Point(14, 247)
        Me.chkKeepOpen.Margin = New System.Windows.Forms.Padding(0)
        Me.chkKeepOpen.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkKeepOpen.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Ripple = True
        Me.chkKeepOpen.Size = New System.Drawing.Size(208, 37)
        Me.chkKeepOpen.TabIndex = 63
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'lblFonction
        '
        Me.lblFonction.AutoSize = True
        Me.lblFonction.Depth = 0
        Me.lblFonction.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblFonction.Location = New System.Drawing.Point(11, 186)
        Me.lblFonction.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFonction.Name = "lblFonction"
        Me.lblFonction.Size = New System.Drawing.Size(71, 19)
        Me.lblFonction.TabIndex = 61
        Me.lblFonction.Text = "Fonction :"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Depth = 0
        Me.lblID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblID.Location = New System.Drawing.Point(11, 3)
        Me.lblID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 19)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "N° :"
        '
        'txtFonction
        '
        Me.txtFonction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFonction.Depth = 0
        Me.txtFonction.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtFonction.Location = New System.Drawing.Point(14, 208)
        Me.txtFonction.MaxLength = 50
        Me.txtFonction.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFonction.Multiline = False
        Me.txtFonction.Name = "txtFonction"
        Me.txtFonction.Size = New System.Drawing.Size(440, 36)
        Me.txtFonction.TabIndex = 62
        Me.txtFonction.Text = ""
        Me.txtFonction.UseTallSize = False
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(14, 25)
        Me.txtID.MaxLength = 50
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(208, 36)
        Me.txtID.TabIndex = 4
        Me.txtID.Text = ""
        Me.txtID.UseTallSize = False
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Depth = 0
        Me.lblAdresse.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAdresse.Location = New System.Drawing.Point(11, 125)
        Me.lblAdresse.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(65, 19)
        Me.lblAdresse.TabIndex = 59
        Me.lblAdresse.Text = "Adresse :"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(14, 86)
        Me.txtNom.MaxLength = 50
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(440, 36)
        Me.txtNom.TabIndex = 58
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdresse.Depth = 0
        Me.txtAdresse.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtAdresse.Location = New System.Drawing.Point(14, 147)
        Me.txtAdresse.MaxLength = 50
        Me.txtAdresse.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAdresse.Multiline = False
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(440, 36)
        Me.txtAdresse.TabIndex = 60
        Me.txtAdresse.Text = ""
        Me.txtAdresse.UseTallSize = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Depth = 0
        Me.lblNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNom.Location = New System.Drawing.Point(11, 64)
        Me.lblNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(109, 19)
        Me.lblNom.TabIndex = 57
        Me.lblNom.Text = "Dénomination :"
        '
        'tabRechercher
        '
        Me.tabRechercher.BackColor = System.Drawing.Color.White
        Me.tabRechercher.Controls.Add(Me.dgvListBatiment)
        Me.tabRechercher.Controls.Add(Me.txtRechercher)
        Me.tabRechercher.Location = New System.Drawing.Point(4, 22)
        Me.tabRechercher.Name = "tabRechercher"
        Me.tabRechercher.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRechercher.Size = New System.Drawing.Size(586, 331)
        Me.tabRechercher.TabIndex = 1
        Me.tabRechercher.Text = "Rechercher"
        '
        'dgvListBatiment
        '
        Me.dgvListBatiment.AllowUserToAddRows = False
        Me.dgvListBatiment.AllowUserToDeleteRows = False
        Me.dgvListBatiment.AllowUserToOrderColumns = True
        Me.dgvListBatiment.AllowUserToResizeRows = False
        Me.dgvListBatiment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListBatiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListBatiment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvListBatiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListBatiment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListBatiment.Location = New System.Drawing.Point(6, 48)
        Me.dgvListBatiment.MaximumSize = New System.Drawing.Size(3840, 277)
        Me.dgvListBatiment.MultiSelect = False
        Me.dgvListBatiment.Name = "dgvListBatiment"
        Me.dgvListBatiment.ReadOnly = True
        Me.dgvListBatiment.RowHeadersVisible = False
        Me.dgvListBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBatiment.Size = New System.Drawing.Size(574, 277)
        Me.dgvListBatiment.TabIndex = 147
        '
        'txtRechercher
        '
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(6, 6)
        Me.txtRechercher.MaxLength = 50
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(574, 36)
        Me.txtRechercher.TabIndex = 61
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(243, 25)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(240, 39)
        Me.MaterialTabSelector1.TabIndex = 61
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'frmBatimentsAjoutGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 401)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBatimentsAjoutGestion"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.Text = "Gérer les bâtiments"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabAjouterBat.ResumeLayout(False)
        Me.TabAjouterBat.PerformLayout()
        Me.tabRechercher.ResumeLayout(False)
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabAjouterBat As TabPage
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkKeepOpen As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents lblFonction As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtFonction As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblAdresse As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtAdresse As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tabRechercher As TabPage
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents dgvListBatiment As DataGridView
End Class
