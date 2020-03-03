<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClefsEmpruntsEtAlertes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClefsEmpruntsEtAlertes))
        Me.dgvAlertes = New System.Windows.Forms.DataGridView()
        Me.menuAlertes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetourAlertesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationsAlertesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbRechercher = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblInfoRecherche = New MaterialSkin.Controls.MaterialLabel()
        Me.chkAlertPopUp = New MaterialSkin.Controls.MaterialSwitch()
        Me.TabCtrlAlertesPerduesEmprunts = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabEnCours = New System.Windows.Forms.TabPage()
        Me.dgvEmpruntsEnCours = New System.Windows.Forms.DataGridView()
        Me.tabPerdues = New System.Windows.Forms.TabPage()
        Me.dgvClefsPerdues = New System.Windows.Forms.DataGridView()
        Me.tabAlertes = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.menuPerdues = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClefRetrouvéePerduesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationsPerduesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmprunt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetourEmpruntStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationsEmpruntStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuAlertes.SuspendLayout()
        Me.TabCtrlAlertesPerduesEmprunts.SuspendLayout()
        Me.tabEnCours.SuspendLayout()
        CType(Me.dgvEmpruntsEnCours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPerdues.SuspendLayout()
        CType(Me.dgvClefsPerdues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlertes.SuspendLayout()
        Me.menuPerdues.SuspendLayout()
        Me.menuEmprunt.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlertes
        '
        Me.dgvAlertes.AllowUserToAddRows = False
        Me.dgvAlertes.AllowUserToDeleteRows = False
        Me.dgvAlertes.AllowUserToResizeRows = False
        Me.dgvAlertes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlertes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAlertes.Location = New System.Drawing.Point(7, 6)
        Me.dgvAlertes.MultiSelect = False
        Me.dgvAlertes.Name = "dgvAlertes"
        Me.dgvAlertes.ReadOnly = True
        Me.dgvAlertes.RowHeadersVisible = False
        Me.dgvAlertes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertes.Size = New System.Drawing.Size(802, 343)
        Me.dgvAlertes.TabIndex = 1
        '
        'menuAlertes
        '
        Me.menuAlertes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourAlertesStripMenuItem, Me.InformationsAlertesStripMenuItem})
        Me.menuAlertes.Name = "menuGrid"
        Me.menuAlertes.Size = New System.Drawing.Size(146, 48)
        '
        'RetourAlertesStripMenuItem
        '
        Me.RetourAlertesStripMenuItem.Name = "RetourAlertesStripMenuItem"
        Me.RetourAlertesStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RetourAlertesStripMenuItem.Text = "Rendre la clef"
        '
        'InformationsAlertesStripMenuItem
        '
        Me.InformationsAlertesStripMenuItem.Name = "InformationsAlertesStripMenuItem"
        Me.InformationsAlertesStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InformationsAlertesStripMenuItem.Text = "Informations"
        '
        'txtRechercher
        '
        Me.txtRechercher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(12, 70)
        Me.txtRechercher.MaxLength = 50
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(347, 36)
        Me.txtRechercher.TabIndex = 2
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'cbRechercher
        '
        Me.cbRechercher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRechercher.AutoResize = False
        Me.cbRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRechercher.Depth = 0
        Me.cbRechercher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbRechercher.DropDownHeight = 118
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.DropDownWidth = 121
        Me.cbRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbRechercher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Hint = "Type de recherche"
        Me.cbRechercher.IntegralHeight = False
        Me.cbRechercher.ItemHeight = 29
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(365, 70)
        Me.cbRechercher.MaxDropDownItems = 4
        Me.cbRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(181, 35)
        Me.cbRechercher.TabIndex = 3
        Me.cbRechercher.UseTallSize = False
        '
        'lblInfoRecherche
        '
        Me.lblInfoRecherche.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfoRecherche.AutoSize = True
        Me.lblInfoRecherche.Depth = 0
        Me.lblInfoRecherche.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblInfoRecherche.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lblInfoRecherche.Location = New System.Drawing.Point(12, 109)
        Me.lblInfoRecherche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfoRecherche.Name = "lblInfoRecherche"
        Me.lblInfoRecherche.Size = New System.Drawing.Size(129, 17)
        Me.lblInfoRecherche.TabIndex = 15
        Me.lblInfoRecherche.Text = "X clefs non rendues !"
        '
        'chkAlertPopUp
        '
        Me.chkAlertPopUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAlertPopUp.AutoSize = True
        Me.chkAlertPopUp.Depth = 0
        Me.chkAlertPopUp.Location = New System.Drawing.Point(549, 70)
        Me.chkAlertPopUp.Margin = New System.Windows.Forms.Padding(0)
        Me.chkAlertPopUp.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkAlertPopUp.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkAlertPopUp.Name = "chkAlertPopUp"
        Me.chkAlertPopUp.Ripple = True
        Me.chkAlertPopUp.Size = New System.Drawing.Size(265, 37)
        Me.chkAlertPopUp.TabIndex = 4
        Me.chkAlertPopUp.Text = "Pop-up d'alerte au démarrage"
        Me.chkAlertPopUp.UseVisualStyleBackColor = True
        '
        'TabCtrlAlertesPerduesEmprunts
        '
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabEnCours)
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabPerdues)
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabAlertes)
        Me.TabCtrlAlertesPerduesEmprunts.Depth = 0
        Me.TabCtrlAlertesPerduesEmprunts.Location = New System.Drawing.Point(1, 111)
        Me.TabCtrlAlertesPerduesEmprunts.Margin = New System.Windows.Forms.Padding(2)
        Me.TabCtrlAlertesPerduesEmprunts.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabCtrlAlertesPerduesEmprunts.Name = "TabCtrlAlertesPerduesEmprunts"
        Me.TabCtrlAlertesPerduesEmprunts.Padding = New System.Drawing.Point(0, 0)
        Me.TabCtrlAlertesPerduesEmprunts.SelectedIndex = 0
        Me.TabCtrlAlertesPerduesEmprunts.Size = New System.Drawing.Size(823, 381)
        Me.TabCtrlAlertesPerduesEmprunts.TabIndex = 16
        '
        'tabEnCours
        '
        Me.tabEnCours.Controls.Add(Me.dgvEmpruntsEnCours)
        Me.tabEnCours.Location = New System.Drawing.Point(4, 22)
        Me.tabEnCours.Name = "tabEnCours"
        Me.tabEnCours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnCours.Size = New System.Drawing.Size(815, 355)
        Me.tabEnCours.TabIndex = 2
        Me.tabEnCours.Text = "En cours"
        Me.tabEnCours.UseVisualStyleBackColor = True
        '
        'dgvEmpruntsEnCours
        '
        Me.dgvEmpruntsEnCours.AllowUserToAddRows = False
        Me.dgvEmpruntsEnCours.AllowUserToDeleteRows = False
        Me.dgvEmpruntsEnCours.AllowUserToResizeRows = False
        Me.dgvEmpruntsEnCours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvEmpruntsEnCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpruntsEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpruntsEnCours.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmpruntsEnCours.Location = New System.Drawing.Point(7, 6)
        Me.dgvEmpruntsEnCours.MultiSelect = False
        Me.dgvEmpruntsEnCours.Name = "dgvEmpruntsEnCours"
        Me.dgvEmpruntsEnCours.ReadOnly = True
        Me.dgvEmpruntsEnCours.RowHeadersVisible = False
        Me.dgvEmpruntsEnCours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmpruntsEnCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpruntsEnCours.Size = New System.Drawing.Size(802, 343)
        Me.dgvEmpruntsEnCours.TabIndex = 16
        '
        'tabPerdues
        '
        Me.tabPerdues.Controls.Add(Me.dgvClefsPerdues)
        Me.tabPerdues.Location = New System.Drawing.Point(4, 22)
        Me.tabPerdues.Name = "tabPerdues"
        Me.tabPerdues.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPerdues.Size = New System.Drawing.Size(815, 355)
        Me.tabPerdues.TabIndex = 1
        Me.tabPerdues.Text = "Clefs Perdues"
        Me.tabPerdues.UseVisualStyleBackColor = True
        '
        'dgvClefsPerdues
        '
        Me.dgvClefsPerdues.AllowUserToAddRows = False
        Me.dgvClefsPerdues.AllowUserToDeleteRows = False
        Me.dgvClefsPerdues.AllowUserToResizeRows = False
        Me.dgvClefsPerdues.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvClefsPerdues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClefsPerdues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClefsPerdues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClefsPerdues.Location = New System.Drawing.Point(7, 6)
        Me.dgvClefsPerdues.MultiSelect = False
        Me.dgvClefsPerdues.Name = "dgvClefsPerdues"
        Me.dgvClefsPerdues.ReadOnly = True
        Me.dgvClefsPerdues.RowHeadersVisible = False
        Me.dgvClefsPerdues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClefsPerdues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClefsPerdues.Size = New System.Drawing.Size(802, 343)
        Me.dgvClefsPerdues.TabIndex = 16
        '
        'tabAlertes
        '
        Me.tabAlertes.Controls.Add(Me.dgvAlertes)
        Me.tabAlertes.Location = New System.Drawing.Point(4, 22)
        Me.tabAlertes.Name = "tabAlertes"
        Me.tabAlertes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlertes.Size = New System.Drawing.Size(815, 355)
        Me.tabAlertes.TabIndex = 0
        Me.tabAlertes.Text = "Alertes"
        Me.tabAlertes.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.TabCtrlAlertesPerduesEmprunts
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(209, 26)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(378, 38)
        Me.MaterialTabSelector1.TabIndex = 17
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'menuPerdues
        '
        Me.menuPerdues.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClefRetrouvéePerduesStripMenuItem, Me.InformationsPerduesStripMenuItem})
        Me.menuPerdues.Name = "menuPerdues"
        Me.menuPerdues.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuPerdues.Size = New System.Drawing.Size(149, 48)
        '
        'ClefRetrouvéePerduesStripMenuItem
        '
        Me.ClefRetrouvéePerduesStripMenuItem.Name = "ClefRetrouvéePerduesStripMenuItem"
        Me.ClefRetrouvéePerduesStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClefRetrouvéePerduesStripMenuItem.Text = "Clef retrouvée"
        '
        'InformationsPerduesStripMenuItem
        '
        Me.InformationsPerduesStripMenuItem.Name = "InformationsPerduesStripMenuItem"
        Me.InformationsPerduesStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformationsPerduesStripMenuItem.Text = "Informations"
        '
        'menuEmprunt
        '
        Me.menuEmprunt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourEmpruntStripMenuItem, Me.InformationsEmpruntStripMenuItem2})
        Me.menuEmprunt.Name = "menuGrid"
        Me.menuEmprunt.Size = New System.Drawing.Size(181, 70)
        '
        'RetourEmpruntStripMenuItem
        '
        Me.RetourEmpruntStripMenuItem.Name = "RetourEmpruntStripMenuItem"
        Me.RetourEmpruntStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RetourEmpruntStripMenuItem.Text = "Rendre la clef"
        '
        'InformationsEmpruntStripMenuItem2
        '
        Me.InformationsEmpruntStripMenuItem2.Name = "InformationsEmpruntStripMenuItem2"
        Me.InformationsEmpruntStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.InformationsEmpruntStripMenuItem2.Text = "Informations"
        '
        'frmClefsEmpruntsEtAlertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 497)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.chkAlertPopUp)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.lblInfoRecherche)
        Me.Controls.Add(Me.TabCtrlAlertesPerduesEmprunts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClefsEmpruntsEtAlertes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Emprunts et alertes"
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuAlertes.ResumeLayout(False)
        Me.TabCtrlAlertesPerduesEmprunts.ResumeLayout(False)
        Me.tabEnCours.ResumeLayout(False)
        CType(Me.dgvEmpruntsEnCours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPerdues.ResumeLayout(False)
        CType(Me.dgvClefsPerdues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlertes.ResumeLayout(False)
        Me.menuPerdues.ResumeLayout(False)
        Me.menuEmprunt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAlertes As DataGridView
    Friend WithEvents menuAlertes As ContextMenuStrip
    Friend WithEvents RetourAlertesStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationsAlertesStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbRechercher As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblInfoRecherche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkAlertPopUp As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents TabCtrlAlertesPerduesEmprunts As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabAlertes As TabPage
    Friend WithEvents tabPerdues As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabEnCours As TabPage
    Friend WithEvents dgvEmpruntsEnCours As DataGridView
    Friend WithEvents dgvClefsPerdues As DataGridView
    Friend WithEvents menuPerdues As ContextMenuStrip
    Friend WithEvents ClefRetrouvéePerduesStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationsPerduesStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuEmprunt As ContextMenuStrip
    Friend WithEvents RetourEmpruntStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationsEmpruntStripMenuItem2 As ToolStripMenuItem
End Class
