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
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.chkAttribuees = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkEmpruntees = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkDisponibles = New MaterialSkin.Controls.MaterialCheckBox()
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
        Me.GestionDesTrousseauxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaisieÀLaVoléToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSupprimer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.dgvPanier = New System.Windows.Forms.DataGridView()
        Me.layMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEmprunter = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAttribuer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnEditer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAddKey = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnInformations = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnPersonnes = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnTrousseaux = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRechercher.SuspendLayout()
        Me.gbFilter.SuspendLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuGrid.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
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
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearch.Depth = 0
        Me.btnSearch.Icon = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(147, 99)
        Me.btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(107, 36)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.gbFilter.Controls.Add(Me.chkAttribuees)
        Me.gbFilter.Controls.Add(Me.chkEmpruntees)
        Me.gbFilter.Controls.Add(Me.chkDisponibles)
        Me.gbFilter.Location = New System.Drawing.Point(6, 48)
        Me.gbFilter.Name = "gbFilter"
        Me.gbFilter.Size = New System.Drawing.Size(116, 104)
        Me.gbFilter.TabIndex = 2
        Me.gbFilter.TabStop = False
        Me.gbFilter.Text = "Filtres"
        '
        'chkAttribuees
        '
        Me.chkAttribuees.AutoSize = True
        Me.chkAttribuees.Checked = True
        Me.chkAttribuees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAttribuees.Depth = 0
        Me.chkAttribuees.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkAttribuees.Location = New System.Drawing.Point(3, 72)
        Me.chkAttribuees.Margin = New System.Windows.Forms.Padding(0)
        Me.chkAttribuees.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkAttribuees.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkAttribuees.Name = "chkAttribuees"
        Me.chkAttribuees.Ripple = True
        Me.chkAttribuees.Size = New System.Drawing.Size(94, 30)
        Me.chkAttribuees.TabIndex = 6
        Me.chkAttribuees.Text = "Attribuées"
        Me.chkAttribuees.UseVisualStyleBackColor = True
        '
        'chkEmpruntees
        '
        Me.chkEmpruntees.AutoSize = True
        Me.chkEmpruntees.Checked = True
        Me.chkEmpruntees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmpruntees.Depth = 0
        Me.chkEmpruntees.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkEmpruntees.Location = New System.Drawing.Point(3, 42)
        Me.chkEmpruntees.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEmpruntees.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEmpruntees.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEmpruntees.Name = "chkEmpruntees"
        Me.chkEmpruntees.Ripple = True
        Me.chkEmpruntees.Size = New System.Drawing.Size(104, 30)
        Me.chkEmpruntees.TabIndex = 5
        Me.chkEmpruntees.Text = "Empruntées"
        Me.chkEmpruntees.UseVisualStyleBackColor = True
        '
        'chkDisponibles
        '
        Me.chkDisponibles.AutoSize = True
        Me.chkDisponibles.Checked = True
        Me.chkDisponibles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisponibles.Depth = 0
        Me.chkDisponibles.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkDisponibles.Location = New System.Drawing.Point(3, 12)
        Me.chkDisponibles.Margin = New System.Windows.Forms.Padding(0)
        Me.chkDisponibles.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkDisponibles.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkDisponibles.Name = "chkDisponibles"
        Me.chkDisponibles.Ripple = True
        Me.chkDisponibles.Size = New System.Drawing.Size(102, 30)
        Me.chkDisponibles.TabIndex = 4
        Me.chkDisponibles.Text = "Disponibles"
        Me.chkDisponibles.UseVisualStyleBackColor = True
        '
        'cbRechercher
        '
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(128, 55)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(140, 21)
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
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesPersonnesToolStripMenuItem, Me.GestionDesTableauxToolStripMenuItem, Me.GestionDesBâtimentsToolStripMenuItem, Me.GestionDesTrousseauxToolStripMenuItem, Me.ToolStripSeparator3, Me.SaisieÀLaVoléToolStripMenuItem, Me.ToolStripSeparator4, Me.SettingsToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "&Outils"
        '
        'GestionDesPersonnesToolStripMenuItem
        '
        Me.GestionDesPersonnesToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.two_men
        Me.GestionDesPersonnesToolStripMenuItem.Name = "GestionDesPersonnesToolStripMenuItem"
        Me.GestionDesPersonnesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionDesPersonnesToolStripMenuItem.Text = "Gestion des personnes"
        '
        'GestionDesTableauxToolStripMenuItem
        '
        Me.GestionDesTableauxToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.tableaux
        Me.GestionDesTableauxToolStripMenuItem.Name = "GestionDesTableauxToolStripMenuItem"
        Me.GestionDesTableauxToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionDesTableauxToolStripMenuItem.Text = "Gestion des tableaux"
        '
        'GestionDesBâtimentsToolStripMenuItem
        '
        Me.GestionDesBâtimentsToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.web_server
        Me.GestionDesBâtimentsToolStripMenuItem.Name = "GestionDesBâtimentsToolStripMenuItem"
        Me.GestionDesBâtimentsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionDesBâtimentsToolStripMenuItem.Text = "Gestion des bâtiments"
        '
        'GestionDesTrousseauxToolStripMenuItem
        '
        Me.GestionDesTrousseauxToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.trousseaux
        Me.GestionDesTrousseauxToolStripMenuItem.Name = "GestionDesTrousseauxToolStripMenuItem"
        Me.GestionDesTrousseauxToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionDesTrousseauxToolStripMenuItem.Text = "Gestion des trousseaux"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'SaisieÀLaVoléToolStripMenuItem
        '
        Me.SaisieÀLaVoléToolStripMenuItem.Name = "SaisieÀLaVoléToolStripMenuItem"
        Me.SaisieÀLaVoléToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SaisieÀLaVoléToolStripMenuItem.Text = "Saisie Multiple"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.GestionClefs.My.Resources.Resources.settings_cogwheel_button
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SettingsToolStripMenuItem.Text = "&Paramètres"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
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
        'btnSupprimer
        '
        Me.btnSupprimer.AutoSize = True
        Me.btnSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSupprimer.Depth = 0
        Me.btnSupprimer.Icon = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.btnSupprimer.Location = New System.Drawing.Point(4, 102)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Primary = False
        Me.btnSupprimer.Size = New System.Drawing.Size(125, 36)
        Me.btnSupprimer.TabIndex = 123
        Me.btnSupprimer.Text = "Supprimer"
        Me.ToolTip1.SetToolTip(Me.btnSupprimer, "Supprimer la clef")
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'dgvPanier
        '
        Me.dgvPanier.AllowUserToAddRows = False
        Me.dgvPanier.AllowUserToDeleteRows = False
        Me.dgvPanier.AllowUserToOrderColumns = True
        Me.dgvPanier.AllowUserToResizeRows = False
        Me.dgvPanier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPanier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPanier.ContextMenuStrip = Me.menuGrid
        Me.dgvPanier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPanier.Location = New System.Drawing.Point(420, 3)
        Me.dgvPanier.Name = "dgvPanier"
        Me.dgvPanier.ReadOnly = True
        Me.dgvPanier.RowHeadersVisible = False
        Me.dgvPanier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPanier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPanier.Size = New System.Drawing.Size(290, 152)
        Me.dgvPanier.TabIndex = 114
        '
        'layMenu
        '
        Me.layMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layMenu.Controls.Add(Me.btnEmprunter)
        Me.layMenu.Controls.Add(Me.btnAttribuer)
        Me.layMenu.Controls.Add(Me.btnEditer)
        Me.layMenu.Controls.Add(Me.btnAddKey)
        Me.layMenu.Controls.Add(Me.btnInformations)
        Me.layMenu.Controls.Add(Me.btnSupprimer)
        Me.layMenu.Controls.Add(Me.btnPersonnes)
        Me.layMenu.Controls.Add(Me.btnTrousseaux)
        Me.layMenu.Location = New System.Drawing.Point(3, 3)
        Me.layMenu.Name = "layMenu"
        Me.layMenu.Size = New System.Drawing.Size(411, 152)
        Me.layMenu.TabIndex = 116
        '
        'btnEmprunter
        '
        Me.btnEmprunter.AutoSize = True
        Me.btnEmprunter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEmprunter.Depth = 0
        Me.btnEmprunter.Icon = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.btnEmprunter.Location = New System.Drawing.Point(4, 6)
        Me.btnEmprunter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEmprunter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEmprunter.Name = "btnEmprunter"
        Me.btnEmprunter.Primary = False
        Me.btnEmprunter.Size = New System.Drawing.Size(129, 36)
        Me.btnEmprunter.TabIndex = 118
        Me.btnEmprunter.Text = "Emprunter"
        Me.btnEmprunter.UseVisualStyleBackColor = True
        '
        'btnAttribuer
        '
        Me.btnAttribuer.AutoSize = True
        Me.btnAttribuer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAttribuer.Depth = 0
        Me.btnAttribuer.Icon = Global.GestionClefs.My.Resources.Resources.login
        Me.btnAttribuer.Location = New System.Drawing.Point(141, 6)
        Me.btnAttribuer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAttribuer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAttribuer.Name = "btnAttribuer"
        Me.btnAttribuer.Primary = False
        Me.btnAttribuer.Size = New System.Drawing.Size(121, 36)
        Me.btnAttribuer.TabIndex = 119
        Me.btnAttribuer.Text = "Attribuer"
        Me.btnAttribuer.UseVisualStyleBackColor = True
        '
        'btnEditer
        '
        Me.btnEditer.AutoSize = True
        Me.btnEditer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditer.Depth = 0
        Me.btnEditer.Icon = Global.GestionClefs.My.Resources.Resources.writing
        Me.btnEditer.Location = New System.Drawing.Point(270, 6)
        Me.btnEditer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditer.Name = "btnEditer"
        Me.btnEditer.Primary = False
        Me.btnEditer.Size = New System.Drawing.Size(94, 36)
        Me.btnEditer.TabIndex = 120
        Me.btnEditer.Text = "Editer"
        Me.btnEditer.UseVisualStyleBackColor = True
        '
        'btnAddKey
        '
        Me.btnAddKey.AutoSize = True
        Me.btnAddKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddKey.Depth = 0
        Me.btnAddKey.Icon = Global.GestionClefs.My.Resources.Resources.ajouter_clefs
        Me.btnAddKey.Location = New System.Drawing.Point(4, 54)
        Me.btnAddKey.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddKey.Name = "btnAddKey"
        Me.btnAddKey.Primary = False
        Me.btnAddKey.Size = New System.Drawing.Size(174, 36)
        Me.btnAddKey.TabIndex = 124
        Me.btnAddKey.Text = "Ajouter une clef"
        Me.btnAddKey.UseVisualStyleBackColor = True
        '
        'btnInformations
        '
        Me.btnInformations.AutoSize = True
        Me.btnInformations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInformations.Depth = 0
        Me.btnInformations.Icon = Global.GestionClefs.My.Resources.Resources.round_info_button
        Me.btnInformations.Location = New System.Drawing.Point(186, 54)
        Me.btnInformations.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInformations.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInformations.Name = "btnInformations"
        Me.btnInformations.Primary = False
        Me.btnInformations.Size = New System.Drawing.Size(141, 36)
        Me.btnInformations.TabIndex = 121
        Me.btnInformations.Text = "Information"
        Me.btnInformations.UseVisualStyleBackColor = True
        '
        'btnPersonnes
        '
        Me.btnPersonnes.AutoSize = True
        Me.btnPersonnes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPersonnes.Depth = 0
        Me.btnPersonnes.Icon = Global.GestionClefs.My.Resources.Resources.two_men
        Me.btnPersonnes.Location = New System.Drawing.Point(137, 102)
        Me.btnPersonnes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPersonnes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPersonnes.Name = "btnPersonnes"
        Me.btnPersonnes.Primary = False
        Me.btnPersonnes.Size = New System.Drawing.Size(127, 36)
        Me.btnPersonnes.TabIndex = 122
        Me.btnPersonnes.Text = "Personnes"
        Me.btnPersonnes.UseVisualStyleBackColor = True
        '
        'btnTrousseaux
        '
        Me.btnTrousseaux.AutoSize = True
        Me.btnTrousseaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTrousseaux.Depth = 0
        Me.btnTrousseaux.Icon = Global.GestionClefs.My.Resources.Resources.trousseaux
        Me.btnTrousseaux.Location = New System.Drawing.Point(272, 102)
        Me.btnTrousseaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTrousseaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTrousseaux.Name = "btnTrousseaux"
        Me.btnTrousseaux.Primary = False
        Me.btnTrousseaux.Size = New System.Drawing.Size(135, 36)
        Me.btnTrousseaux.TabIndex = 125
        Me.btnTrousseaux.Text = "Trousseaux"
        Me.btnTrousseaux.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbRechercher, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1005, 164)
        Me.TableLayoutPanel1.TabIndex = 117
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.layMenu, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvPanier, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(289, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(713, 158)
        Me.TableLayoutPanel2.TabIndex = 6
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
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layMenu.ResumeLayout(False)
        Me.layMenu.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dgvPanier As DataGridView
    Friend WithEvents layMenu As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chkAttribuees As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkEmpruntees As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents chkDisponibles As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnEmprunter As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnAttribuer As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnInformations As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnEditer As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnAddKey As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSupprimer As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnPersonnes As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnTrousseaux As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GestionDesTrousseauxToolStripMenuItem As ToolStripMenuItem
End Class
