<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cbRechercher = New System.Windows.Forms.ComboBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.chkAttribuees = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkEmpruntees = New MaterialSkin.Controls.MaterialCheckBox()
        Me.chkDisponibles = New MaterialSkin.Controls.MaterialCheckBox()
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnSupprimer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.dgvPanier = New System.Windows.Forms.DataGridView()
        Me.btnEmprunter = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAttribuer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnEditer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAddKey = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnInformations = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnPersonnes = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnTrousseaux = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTableaux = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnBatiments = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.btnRefresh = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnAlertes = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnParametres = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.menuGrid = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.EmprunterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttribuerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLightMode = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.gbFilter.SuspendLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.menuGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearch.Depth = 0
        Me.btnSearch.Icon = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(767, 215)
        Me.btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(107, 36)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbRechercher
        '
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(284, 221)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(158, 21)
        Me.cbRechercher.TabIndex = 1
        '
        'gbFilter
        '
        Me.gbFilter.Controls.Add(Me.chkAttribuees)
        Me.gbFilter.Controls.Add(Me.chkEmpruntees)
        Me.gbFilter.Controls.Add(Me.chkDisponibles)
        Me.gbFilter.Location = New System.Drawing.Point(448, 206)
        Me.gbFilter.Name = "gbFilter"
        Me.gbFilter.Size = New System.Drawing.Size(313, 51)
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
        Me.chkAttribuees.Location = New System.Drawing.Point(209, 13)
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
        Me.chkEmpruntees.Location = New System.Drawing.Point(105, 13)
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
        Me.chkDisponibles.Location = New System.Drawing.Point(3, 13)
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
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(0, 263)
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(1001, 441)
        Me.dgvResultats.TabIndex = 10
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
        Me.btnSupprimer.Location = New System.Drawing.Point(374, 54)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Primary = False
        Me.btnSupprimer.Size = New System.Drawing.Size(125, 36)
        Me.btnSupprimer.TabIndex = 123
        Me.btnSupprimer.Text = "Supprimer"
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
        Me.dgvPanier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPanier.Location = New System.Drawing.Point(577, 88)
        Me.dgvPanier.Name = "dgvPanier"
        Me.dgvPanier.ReadOnly = True
        Me.dgvPanier.RowHeadersVisible = False
        Me.dgvPanier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPanier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPanier.Size = New System.Drawing.Size(427, 112)
        Me.dgvPanier.TabIndex = 114
        '
        'btnEmprunter
        '
        Me.btnEmprunter.AutoSize = True
        Me.btnEmprunter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEmprunter.Depth = 0
        Me.btnEmprunter.Icon = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.btnEmprunter.Location = New System.Drawing.Point(189, 6)
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
        Me.btnAttribuer.Location = New System.Drawing.Point(374, 6)
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
        Me.btnEditer.Location = New System.Drawing.Point(4, 54)
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
        Me.btnAddKey.Location = New System.Drawing.Point(4, 6)
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
        Me.btnInformations.Location = New System.Drawing.Point(189, 54)
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
        Me.btnPersonnes.Location = New System.Drawing.Point(4, 6)
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
        Me.btnTrousseaux.Location = New System.Drawing.Point(286, 6)
        Me.btnTrousseaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTrousseaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTrousseaux.Name = "btnTrousseaux"
        Me.btnTrousseaux.Primary = False
        Me.btnTrousseaux.Size = New System.Drawing.Size(135, 36)
        Me.btnTrousseaux.TabIndex = 125
        Me.btnTrousseaux.Text = "Trousseaux"
        Me.btnTrousseaux.UseVisualStyleBackColor = True
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 66)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(575, 134)
        Me.MaterialTabControl1.TabIndex = 126
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 108)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clefs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEmprunter, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAttribuer, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEditer, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSupprimer, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddKey, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInformations, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 96)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(567, 108)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.39683!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.86773!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnPersonnes, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTableaux, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTrousseaux, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBatiments, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(567, 108)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnTableaux
        '
        Me.btnTableaux.AutoSize = True
        Me.btnTableaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTableaux.Depth = 0
        Me.btnTableaux.Icon = Global.GestionClefs.My.Resources.Resources.tableaux
        Me.btnTableaux.Location = New System.Drawing.Point(145, 6)
        Me.btnTableaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTableaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTableaux.Name = "btnTableaux"
        Me.btnTableaux.Primary = False
        Me.btnTableaux.Size = New System.Drawing.Size(117, 36)
        Me.btnTableaux.TabIndex = 128
        Me.btnTableaux.Text = "Tableaux"
        Me.btnTableaux.UseVisualStyleBackColor = True
        '
        'btnBatiments
        '
        Me.btnBatiments.AutoSize = True
        Me.btnBatiments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBatiments.Depth = 0
        Me.btnBatiments.Icon = Global.GestionClefs.My.Resources.Resources.web_server
        Me.btnBatiments.Location = New System.Drawing.Point(429, 6)
        Me.btnBatiments.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBatiments.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBatiments.Name = "btnBatiments"
        Me.btnBatiments.Primary = False
        Me.btnBatiments.Size = New System.Drawing.Size(125, 36)
        Me.btnBatiments.TabIndex = 129
        Me.btnBatiments.Text = "Bâtiments"
        Me.btnBatiments.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(158, 29)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(268, 32)
        Me.MaterialTabSelector1.TabIndex = 127
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRefresh.Depth = 0
        Me.btnRefresh.Icon = Global.GestionClefs.My.Resources.Resources.refresh_button
        Me.btnRefresh.Location = New System.Drawing.Point(881, 215)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Primary = False
        Me.btnRefresh.Size = New System.Drawing.Size(44, 36)
        Me.btnRefresh.TabIndex = 131
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(581, 66)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel1.TabIndex = 133
        Me.MaterialLabel1.Text = "Panier"
        '
        'btnAlertes
        '
        Me.btnAlertes.AutoSize = True
        Me.btnAlertes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAlertes.Depth = 0
        Me.btnAlertes.Icon = Global.GestionClefs.My.Resources.Resources.round_error_symbol
        Me.btnAlertes.Location = New System.Drawing.Point(577, 25)
        Me.btnAlertes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAlertes.Name = "btnAlertes"
        Me.btnAlertes.Primary = True
        Me.btnAlertes.Size = New System.Drawing.Size(106, 36)
        Me.btnAlertes.TabIndex = 135
        Me.btnAlertes.Text = "Alertes"
        Me.btnAlertes.UseVisualStyleBackColor = True
        '
        'btnParametres
        '
        Me.btnParametres.AutoSize = True
        Me.btnParametres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParametres.Depth = 0
        Me.btnParametres.Icon = Global.GestionClefs.My.Resources.Resources.settings_cogwheel_button
        Me.btnParametres.Location = New System.Drawing.Point(960, 25)
        Me.btnParametres.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParametres.Name = "btnParametres"
        Me.btnParametres.Primary = True
        Me.btnParametres.Size = New System.Drawing.Size(44, 36)
        Me.btnParametres.TabIndex = 136
        Me.btnParametres.UseVisualStyleBackColor = True
        '
        'txtRechercher
        '
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(14, 219)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRechercher.SelectedText = ""
        Me.txtRechercher.SelectionLength = 0
        Me.txtRechercher.SelectionStart = 0
        Me.txtRechercher.Size = New System.Drawing.Size(264, 23)
        Me.txtRechercher.TabIndex = 137
        Me.txtRechercher.TabStop = False
        Me.txtRechercher.UseSystemPasswordChar = False
        '
        'menuGrid
        '
        Me.menuGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.menuGrid.Depth = 0
        Me.menuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmprunterToolStripMenuItem1, Me.AttribuerToolStripMenuItem1, Me.ToolStripSeparator3, Me.EditerToolStripMenuItem1, Me.PropriétésToolStripMenuItem1, Me.ToolStripSeparator4, Me.SupprimerToolStripMenuItem1})
        Me.menuGrid.MouseState = MaterialSkin.MouseState.HOVER
        Me.menuGrid.Name = "MaterialContextMenuStrip1"
        Me.menuGrid.Size = New System.Drawing.Size(140, 126)
        '
        'EmprunterToolStripMenuItem1
        '
        Me.EmprunterToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.EmprunterToolStripMenuItem1.Name = "EmprunterToolStripMenuItem1"
        Me.EmprunterToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EmprunterToolStripMenuItem1.Text = "Emprunter..."
        '
        'AttribuerToolStripMenuItem1
        '
        Me.AttribuerToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.login
        Me.AttribuerToolStripMenuItem1.Name = "AttribuerToolStripMenuItem1"
        Me.AttribuerToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.AttribuerToolStripMenuItem1.Text = "Attribuer..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(136, 6)
        '
        'EditerToolStripMenuItem1
        '
        Me.EditerToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.writing
        Me.EditerToolStripMenuItem1.Name = "EditerToolStripMenuItem1"
        Me.EditerToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EditerToolStripMenuItem1.Text = "Editer"
        '
        'PropriétésToolStripMenuItem1
        '
        Me.PropriétésToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.round_info_button
        Me.PropriétésToolStripMenuItem1.Name = "PropriétésToolStripMenuItem1"
        Me.PropriétésToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PropriétésToolStripMenuItem1.Text = "Propriétés"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(136, 6)
        '
        'SupprimerToolStripMenuItem1
        '
        Me.SupprimerToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.SupprimerToolStripMenuItem1.Name = "SupprimerToolStripMenuItem1"
        Me.SupprimerToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.SupprimerToolStripMenuItem1.Text = "Supprimer"
        '
        'btnLightMode
        '
        Me.btnLightMode.AutoSize = True
        Me.btnLightMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLightMode.Depth = 0
        Me.btnLightMode.Icon = Global.GestionClefs.My.Resources.Resources.report_symbol
        Me.btnLightMode.Location = New System.Drawing.Point(910, 25)
        Me.btnLightMode.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLightMode.Name = "btnLightMode"
        Me.btnLightMode.Primary = True
        Me.btnLightMode.Size = New System.Drawing.Size(44, 36)
        Me.btnLightMode.TabIndex = 138
        Me.btnLightMode.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btnLightMode)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.btnParametres)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.btnAlertes)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgvPanier)
        Me.Controls.Add(Me.gbFilter)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvResultats)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Gestion des clefs"
        Me.gbFilter.ResumeLayout(False)
        Me.gbFilter.PerformLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.menuGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents cbRechercher As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents dgvPanier As DataGridView
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
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnTableaux As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnBatiments As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRefresh As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAlertes As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnParametres As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents menuGrid As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents EmprunterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AttribuerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EditerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropriétésToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SupprimerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnLightMode As MaterialSkin.Controls.MaterialRaisedButton
End Class
