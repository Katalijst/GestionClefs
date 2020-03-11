<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableauxGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableauxGestion))
        Me.dgvListTableau = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbBatiments = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblPResponsable = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPNom = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbResponsable = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnAddPersonne = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.chkKeepOpen = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabAjouter = New System.Windows.Forms.TabPage()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.TabRechercher = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.dgvListTableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabAjouter.SuspendLayout()
        Me.TabRechercher.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListTableau
        '
        Me.dgvListTableau.AllowUserToAddRows = False
        Me.dgvListTableau.AllowUserToDeleteRows = False
        Me.dgvListTableau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListTableau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListTableau.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListTableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListTableau.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListTableau.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListTableau.Location = New System.Drawing.Point(6, 48)
        Me.dgvListTableau.MultiSelect = False
        Me.dgvListTableau.Name = "dgvListTableau"
        Me.dgvListTableau.ReadOnly = True
        Me.dgvListTableau.RowHeadersVisible = False
        Me.dgvListTableau.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListTableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTableau.Size = New System.Drawing.Size(412, 265)
        Me.dgvListTableau.TabIndex = 45
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
        'cbBatiments
        '
        Me.cbBatiments.AutoResize = False
        Me.cbBatiments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBatiments.Depth = 0
        Me.cbBatiments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbBatiments.DropDownHeight = 118
        Me.cbBatiments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBatiments.DropDownWidth = 121
        Me.cbBatiments.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbBatiments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbBatiments.FormattingEnabled = True
        Me.cbBatiments.IntegralHeight = False
        Me.cbBatiments.ItemHeight = 29
        Me.cbBatiments.Location = New System.Drawing.Point(6, 150)
        Me.cbBatiments.MaxDropDownItems = 4
        Me.cbBatiments.MouseState = MaterialSkin.MouseState.OUT
        Me.cbBatiments.Name = "cbBatiments"
        Me.cbBatiments.Size = New System.Drawing.Size(364, 35)
        Me.cbBatiments.TabIndex = 68
        Me.cbBatiments.UseTallSize = False
        '
        'lblPResponsable
        '
        Me.lblPResponsable.AutoSize = True
        Me.lblPResponsable.Depth = 0
        Me.lblPResponsable.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPResponsable.Location = New System.Drawing.Point(6, 3)
        Me.lblPResponsable.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPResponsable.Name = "lblPResponsable"
        Me.lblPResponsable.Size = New System.Drawing.Size(100, 19)
        Me.lblPResponsable.TabIndex = 69
        Me.lblPResponsable.Text = "Responsable :"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Depth = 0
        Me.lblPNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPNom.Location = New System.Drawing.Point(6, 63)
        Me.lblPNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(67, 19)
        Me.lblPNom.TabIndex = 70
        Me.lblPNom.Text = "Tableau :"
        '
        'lblPBatiment
        '
        Me.lblPBatiment.AutoSize = True
        Me.lblPBatiment.Depth = 0
        Me.lblPBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPBatiment.Location = New System.Drawing.Point(6, 128)
        Me.lblPBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPBatiment.Name = "lblPBatiment"
        Me.lblPBatiment.Size = New System.Drawing.Size(73, 19)
        Me.lblPBatiment.TabIndex = 71
        Me.lblPBatiment.Text = "Batiment :"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(6, 89)
        Me.txtNom.MaxLength = 255
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(364, 36)
        Me.txtNom.TabIndex = 72
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'cbResponsable
        '
        Me.cbResponsable.AutoResize = False
        Me.cbResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbResponsable.Depth = 0
        Me.cbResponsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbResponsable.DropDownHeight = 118
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.DropDownWidth = 121
        Me.cbResponsable.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbResponsable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.IntegralHeight = False
        Me.cbResponsable.ItemHeight = 29
        Me.cbResponsable.Location = New System.Drawing.Point(6, 25)
        Me.cbResponsable.MaxDropDownItems = 4
        Me.cbResponsable.MouseState = MaterialSkin.MouseState.OUT
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(364, 35)
        Me.cbResponsable.TabIndex = 73
        Me.cbResponsable.UseTallSize = False
        '
        'btnAddPersonne
        '
        Me.btnAddPersonne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddPersonne.Depth = 0
        Me.btnAddPersonne.DrawShadows = True
        Me.btnAddPersonne.HighEmphasis = True
        Me.btnAddPersonne.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddPersonne.Location = New System.Drawing.Point(377, 24)
        Me.btnAddPersonne.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddPersonne.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddPersonne.Name = "btnAddPersonne"
        Me.btnAddPersonne.Size = New System.Drawing.Size(44, 36)
        Me.btnAddPersonne.TabIndex = 74
        Me.btnAddPersonne.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddPersonne.UseAccentColor = False
        Me.btnAddPersonne.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(306, 273)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 75
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.DrawShadows = True
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(4, 273)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Depth = 0
        Me.chkKeepOpen.Location = New System.Drawing.Point(0, 230)
        Me.chkKeepOpen.Margin = New System.Windows.Forms.Padding(0)
        Me.chkKeepOpen.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkKeepOpen.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Ripple = True
        Me.chkKeepOpen.Size = New System.Drawing.Size(208, 37)
        Me.chkKeepOpen.TabIndex = 77
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
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
        Me.txtRechercher.Size = New System.Drawing.Size(412, 36)
        Me.txtRechercher.TabIndex = 78
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabAjouter)
        Me.MaterialTabControl1.Controls.Add(Me.TabRechercher)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(4, 70)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(436, 345)
        Me.MaterialTabControl1.TabIndex = 79
        '
        'TabAjouter
        '
        Me.TabAjouter.BackColor = System.Drawing.Color.Transparent
        Me.TabAjouter.Controls.Add(Me.MaterialDivider1)
        Me.TabAjouter.Controls.Add(Me.lblPResponsable)
        Me.TabAjouter.Controls.Add(Me.cbBatiments)
        Me.TabAjouter.Controls.Add(Me.lblPNom)
        Me.TabAjouter.Controls.Add(Me.chkKeepOpen)
        Me.TabAjouter.Controls.Add(Me.lblPBatiment)
        Me.TabAjouter.Controls.Add(Me.btnCancel)
        Me.TabAjouter.Controls.Add(Me.txtNom)
        Me.TabAjouter.Controls.Add(Me.btnSave)
        Me.TabAjouter.Controls.Add(Me.cbResponsable)
        Me.TabAjouter.Controls.Add(Me.btnAddPersonne)
        Me.TabAjouter.Location = New System.Drawing.Point(4, 22)
        Me.TabAjouter.Name = "TabAjouter"
        Me.TabAjouter.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAjouter.Size = New System.Drawing.Size(428, 319)
        Me.TabAjouter.TabIndex = 0
        Me.TabAjouter.Text = "Ajouter"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(3, 217)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(421, 1)
        Me.MaterialDivider1.TabIndex = 78
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'TabRechercher
        '
        Me.TabRechercher.Controls.Add(Me.txtRechercher)
        Me.TabRechercher.Controls.Add(Me.dgvListTableau)
        Me.TabRechercher.Location = New System.Drawing.Point(4, 22)
        Me.TabRechercher.Name = "TabRechercher"
        Me.TabRechercher.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRechercher.Size = New System.Drawing.Size(428, 319)
        Me.TabRechercher.TabIndex = 1
        Me.TabRechercher.Text = "Rechercher"
        Me.TabRechercher.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(197, 26)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(239, 38)
        Me.MaterialTabSelector1.TabIndex = 80
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'frmTableauxGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 416)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableauxGestion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tableaux de clefs"
        CType(Me.dgvListTableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabAjouter.ResumeLayout(False)
        Me.TabAjouter.PerformLayout()
        Me.TabRechercher.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListTableau As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbBatiments As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblPResponsable As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbResponsable As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnAddPersonne As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkKeepOpen As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabAjouter As TabPage
    Friend WithEvents TabRechercher As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
End Class
