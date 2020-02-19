<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.chkDisponibles = New System.Windows.Forms.CheckBox()
        Me.chkEmpruntees = New System.Windows.Forms.CheckBox()
        Me.chkAttribuees = New System.Windows.Forms.CheckBox()
        Me.btnAddClef = New System.Windows.Forms.Button()
        Me.btnAddTrousseau = New System.Windows.Forms.Button()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.cbRechercher = New System.Windows.Forms.ComboBox()
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.menuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EmprunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttribuerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menAlertes = New System.Windows.Forms.ToolStripMenuItem()
        Me.RafraichirLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesPersonnesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesTableauxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesBâtimentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaisieÀLaVoléToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEditer = New System.Windows.Forms.Label()
        Me.lblAttribuer = New System.Windows.Forms.Label()
        Me.lblGestionPersonnes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbProperties = New System.Windows.Forms.PictureBox()
        Me.pbPersonnes = New System.Windows.Forms.PictureBox()
        Me.pbEditer = New System.Windows.Forms.PictureBox()
        Me.pbAttribuer = New System.Windows.Forms.PictureBox()
        Me.pbSupprimer = New System.Windows.Forms.PictureBox()
        Me.pbEmprunter = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.layMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gbRechercher.SuspendLayout()
        Me.gbFilter.SuspendLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuGrid.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPersonnes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEditer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttribuer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSupprimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmprunter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layMenu.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDisponibles
        '
        Me.chkDisponibles.AutoSize = True
        Me.chkDisponibles.Checked = True
        Me.chkDisponibles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisponibles.Location = New System.Drawing.Point(6, 19)
        Me.chkDisponibles.Name = "chkDisponibles"
        Me.chkDisponibles.Size = New System.Drawing.Size(80, 17)
        Me.chkDisponibles.TabIndex = 3
        Me.chkDisponibles.Text = "Disponibles"
        Me.chkDisponibles.UseVisualStyleBackColor = True
        '
        'chkEmpruntees
        '
        Me.chkEmpruntees.AutoSize = True
        Me.chkEmpruntees.Checked = True
        Me.chkEmpruntees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmpruntees.Location = New System.Drawing.Point(93, 19)
        Me.chkEmpruntees.Name = "chkEmpruntees"
        Me.chkEmpruntees.Size = New System.Drawing.Size(82, 17)
        Me.chkEmpruntees.TabIndex = 4
        Me.chkEmpruntees.Text = "Empruntées"
        Me.chkEmpruntees.UseVisualStyleBackColor = True
        '
        'chkAttribuees
        '
        Me.chkAttribuees.AutoSize = True
        Me.chkAttribuees.Checked = True
        Me.chkAttribuees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAttribuees.Location = New System.Drawing.Point(180, 19)
        Me.chkAttribuees.Name = "chkAttribuees"
        Me.chkAttribuees.Size = New System.Drawing.Size(73, 17)
        Me.chkAttribuees.TabIndex = 5
        Me.chkAttribuees.Text = "Attribuées"
        Me.chkAttribuees.UseVisualStyleBackColor = True
        '
        'btnAddClef
        '
        Me.btnAddClef.Location = New System.Drawing.Point(3, 129)
        Me.btnAddClef.Name = "btnAddClef"
        Me.btnAddClef.Size = New System.Drawing.Size(140, 23)
        Me.btnAddClef.TabIndex = 7
        Me.btnAddClef.Text = "Ajouter une clef"
        Me.btnAddClef.UseVisualStyleBackColor = True
        '
        'btnAddTrousseau
        '
        Me.btnAddTrousseau.Location = New System.Drawing.Point(149, 129)
        Me.btnAddTrousseau.Name = "btnAddTrousseau"
        Me.btnAddTrousseau.Size = New System.Drawing.Size(140, 23)
        Me.btnAddTrousseau.TabIndex = 8
        Me.btnAddTrousseau.Text = "Trousseaux"
        Me.btnAddTrousseau.UseVisualStyleBackColor = True
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.btnSearch)
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Controls.Add(Me.gbFilter)
        Me.gbRechercher.Controls.Add(Me.cbRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(3, 3)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(277, 158)
        Me.gbRechercher.TabIndex = 5
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher"
        '
        'txtRechercher
        '
        Me.txtRechercher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRechercher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRechercher.Location = New System.Drawing.Point(6, 19)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(262, 20)
        Me.txtRechercher.TabIndex = 0
        '
        'gbFilter
        '
        Me.gbFilter.Controls.Add(Me.chkDisponibles)
        Me.gbFilter.Controls.Add(Me.chkEmpruntees)
        Me.gbFilter.Controls.Add(Me.chkAttribuees)
        Me.gbFilter.Location = New System.Drawing.Point(6, 48)
        Me.gbFilter.Name = "gbFilter"
        Me.gbFilter.Size = New System.Drawing.Size(262, 45)
        Me.gbFilter.TabIndex = 2
        Me.gbFilter.TabStop = False
        Me.gbFilter.Text = "Filtres"
        '
        'cbRechercher
        '
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(6, 105)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(161, 21)
        Me.cbRechercher.TabIndex = 1
        '
        'dgvResultats
        '
        Me.dgvResultats.AllowUserToAddRows = False
        Me.dgvResultats.AllowUserToDeleteRows = False
        Me.dgvResultats.AllowUserToOrderColumns = True
        Me.dgvResultats.AllowUserToResizeRows = False
        Me.dgvResultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultats.ContextMenuStrip = Me.menuGrid
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(3, 197)
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(1001, 507)
        Me.dgvResultats.TabIndex = 10
        '
        'menuGrid
        '
        Me.menuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmprunterToolStripMenuItem, Me.AttribuerToolStripMenuItem, Me.ToolStripSeparator1, Me.EditerToolStripMenuItem, Me.PropriétésToolStripMenuItem, Me.ToolStripSeparator2, Me.SupprimerToolStripMenuItem})
        Me.menuGrid.Name = "menuGrid"
        Me.menuGrid.Size = New System.Drawing.Size(140, 126)
        '
        'EmprunterToolStripMenuItem
        '
        Me.EmprunterToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.EmprunterToolStripMenuItem.Name = "EmprunterToolStripMenuItem"
        Me.EmprunterToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmprunterToolStripMenuItem.Text = "Emprunter..."
        '
        'AttribuerToolStripMenuItem
        '
        Me.AttribuerToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.login
        Me.AttribuerToolStripMenuItem.Name = "AttribuerToolStripMenuItem"
        Me.AttribuerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AttribuerToolStripMenuItem.Text = "Attribuer..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'EditerToolStripMenuItem
        '
        Me.EditerToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.writing
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EditerToolStripMenuItem.Text = "Editer"
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.round_info_button
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        Me.PropriétésToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PropriétésToolStripMenuItem.Text = "Propriétés"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(136, 6)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menAlertes, Me.RafraichirLaPageToolStripMenuItem, Me.OutilsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menAlertes
        '
        Me.menAlertes.Image = Global.GestionClefs.My.Resources.Resources.round_error_symbol
        Me.menAlertes.Name = "menAlertes"
        Me.menAlertes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menAlertes.Size = New System.Drawing.Size(71, 20)
        Me.menAlertes.Text = "&Alertes"
        '
        'RafraichirLaPageToolStripMenuItem
        '
        Me.RafraichirLaPageToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.refresh_button
        Me.RafraichirLaPageToolStripMenuItem.Name = "RafraichirLaPageToolStripMenuItem"
        Me.RafraichirLaPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RafraichirLaPageToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.RafraichirLaPageToolStripMenuItem.Text = "&Rafraichir la page"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesPersonnesToolStripMenuItem, Me.GestionDesTableauxToolStripMenuItem, Me.GestionDesBâtimentsToolStripMenuItem, Me.ToolStripSeparator3, Me.SaisieÀLaVoléToolStripMenuItem, Me.ToolStripSeparator4, Me.SettingsToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "&Outils"
        '
        'GestionDesPersonnesToolStripMenuItem
        '
        Me.GestionDesPersonnesToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.two_men
        Me.GestionDesPersonnesToolStripMenuItem.Name = "GestionDesPersonnesToolStripMenuItem"
        Me.GestionDesPersonnesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GestionDesPersonnesToolStripMenuItem.Text = "Gestion des personnes"
        '
        'GestionDesTableauxToolStripMenuItem
        '
        Me.GestionDesTableauxToolStripMenuItem.Name = "GestionDesTableauxToolStripMenuItem"
        Me.GestionDesTableauxToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GestionDesTableauxToolStripMenuItem.Text = "Gestion des tableaux"
        '
        'GestionDesBâtimentsToolStripMenuItem
        '
        Me.GestionDesBâtimentsToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.web_server
        Me.GestionDesBâtimentsToolStripMenuItem.Name = "GestionDesBâtimentsToolStripMenuItem"
        Me.GestionDesBâtimentsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GestionDesBâtimentsToolStripMenuItem.Text = "Gestion des bâtiments"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(189, 6)
        '
        'SaisieÀLaVoléToolStripMenuItem
        '
        Me.SaisieÀLaVoléToolStripMenuItem.Name = "SaisieÀLaVoléToolStripMenuItem"
        Me.SaisieÀLaVoléToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SaisieÀLaVoléToolStripMenuItem.Text = "Saisie Multiple"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(189, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.settings_cogwheel_button
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SettingsToolStripMenuItem.Text = "&Paramètres"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AProposToolStripMenuItem.Text = "A propos..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 101
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEditer
        '
        Me.lblEditer.Location = New System.Drawing.Point(39, 0)
        Me.lblEditer.Name = "lblEditer"
        Me.lblEditer.Size = New System.Drawing.Size(37, 36)
        Me.lblEditer.TabIndex = 108
        Me.lblEditer.Text = "Editer"
        Me.lblEditer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAttribuer
        '
        Me.lblAttribuer.Location = New System.Drawing.Point(39, 0)
        Me.lblAttribuer.Name = "lblAttribuer"
        Me.lblAttribuer.Size = New System.Drawing.Size(47, 36)
        Me.lblAttribuer.TabIndex = 109
        Me.lblAttribuer.Text = "Attribuer"
        Me.lblAttribuer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGestionPersonnes
        '
        Me.lblGestionPersonnes.Location = New System.Drawing.Point(39, 0)
        Me.lblGestionPersonnes.Name = "lblGestionPersonnes"
        Me.lblGestionPersonnes.Size = New System.Drawing.Size(96, 36)
        Me.lblGestionPersonnes.TabIndex = 110
        Me.lblGestionPersonnes.Text = "Gestion personnes"
        Me.lblGestionPersonnes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 36)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Informations"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 36)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Supprimer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbProperties
        '
        Me.pbProperties.Image = Global.GestionClefs.My.Resources.Resources.round_info_button
        Me.pbProperties.Location = New System.Drawing.Point(3, 3)
        Me.pbProperties.Name = "pbProperties"
        Me.pbProperties.Size = New System.Drawing.Size(30, 30)
        Me.pbProperties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProperties.TabIndex = 107
        Me.pbProperties.TabStop = False
        '
        'pbPersonnes
        '
        Me.pbPersonnes.Image = Global.GestionClefs.My.Resources.Resources.two_men
        Me.pbPersonnes.Location = New System.Drawing.Point(3, 3)
        Me.pbPersonnes.Name = "pbPersonnes"
        Me.pbPersonnes.Size = New System.Drawing.Size(30, 30)
        Me.pbPersonnes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPersonnes.TabIndex = 106
        Me.pbPersonnes.TabStop = False
        '
        'pbEditer
        '
        Me.pbEditer.Image = Global.GestionClefs.My.Resources.Resources.writing
        Me.pbEditer.Location = New System.Drawing.Point(3, 3)
        Me.pbEditer.Name = "pbEditer"
        Me.pbEditer.Size = New System.Drawing.Size(30, 30)
        Me.pbEditer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEditer.TabIndex = 105
        Me.pbEditer.TabStop = False
        '
        'pbAttribuer
        '
        Me.pbAttribuer.Image = Global.GestionClefs.My.Resources.Resources.login
        Me.pbAttribuer.Location = New System.Drawing.Point(3, 3)
        Me.pbAttribuer.Name = "pbAttribuer"
        Me.pbAttribuer.Size = New System.Drawing.Size(30, 30)
        Me.pbAttribuer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAttribuer.TabIndex = 104
        Me.pbAttribuer.TabStop = False
        '
        'pbSupprimer
        '
        Me.pbSupprimer.Image = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.pbSupprimer.Location = New System.Drawing.Point(3, 3)
        Me.pbSupprimer.Name = "pbSupprimer"
        Me.pbSupprimer.Size = New System.Drawing.Size(30, 30)
        Me.pbSupprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSupprimer.TabIndex = 103
        Me.pbSupprimer.TabStop = False
        '
        'pbEmprunter
        '
        Me.pbEmprunter.Image = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.pbEmprunter.Location = New System.Drawing.Point(3, 3)
        Me.pbEmprunter.Name = "pbEmprunter"
        Me.pbEmprunter.Size = New System.Drawing.Size(30, 30)
        Me.pbEmprunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmprunter.TabIndex = 102
        Me.pbEmprunter.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(39, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 30)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Emprunter"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.menuGrid
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(390, 133)
        Me.DataGridView1.TabIndex = 114
        '
        'layMenu
        '
        Me.layMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel3)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel4)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel5)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel6)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel7)
        Me.layMenu.Controls.Add(Me.FlowLayoutPanel8)
        Me.layMenu.Controls.Add(Me.btnAddClef)
        Me.layMenu.Controls.Add(Me.btnAddTrousseau)
        Me.layMenu.Location = New System.Drawing.Point(289, 3)
        Me.layMenu.Name = "layMenu"
        Me.layMenu.Size = New System.Drawing.Size(308, 158)
        Me.layMenu.TabIndex = 116
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.pbEmprunter)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel3.TabIndex = 114
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.pbAttribuer)
        Me.FlowLayoutPanel4.Controls.Add(Me.lblAttribuer)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(149, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel4.TabIndex = 115
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.pbEditer)
        Me.FlowLayoutPanel5.Controls.Add(Me.lblEditer)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 45)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel5.TabIndex = 116
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.pbProperties)
        Me.FlowLayoutPanel6.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(149, 45)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel6.TabIndex = 117
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.pbPersonnes)
        Me.FlowLayoutPanel7.Controls.Add(Me.lblGestionPersonnes)
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 87)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel7.TabIndex = 118
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.pbSupprimer)
        Me.FlowLayoutPanel8.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(149, 87)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(140, 36)
        Me.FlowLayoutPanel8.TabIndex = 119
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(601, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 158)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panier"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.gbRechercher, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.layMenu, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1005, 164)
        Me.TableLayoutPanel1.TabIndex = 117
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(173, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvResultats)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Gestion des clefs"
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.gbFilter.ResumeLayout(False)
        Me.gbFilter.PerformLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuGrid.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPersonnes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEditer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttribuer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSupprimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmprunter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layMenu.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDisponibles As CheckBox
    Friend WithEvents chkEmpruntees As CheckBox
    Friend WithEvents chkAttribuees As CheckBox
    Friend WithEvents btnAddClef As Button
    Friend WithEvents btnAddTrousseau As Button
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents cbRechercher As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menAlertes As ToolStripMenuItem
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents menuGrid As ContextMenuStrip
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaisieÀLaVoléToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GestionDesPersonnesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GestionDesBâtimentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDesTableauxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmprunterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttribuerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RafraichirLaPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbEmprunter As PictureBox
    Friend WithEvents pbSupprimer As PictureBox
    Friend WithEvents pbAttribuer As PictureBox
    Friend WithEvents pbEditer As PictureBox
    Friend WithEvents pbPersonnes As PictureBox
    Friend WithEvents pbProperties As PictureBox
    Friend WithEvents lblEditer As Label
    Friend WithEvents lblAttribuer As Label
    Friend WithEvents lblGestionPersonnes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents layMenu As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSearch As Button
End Class
