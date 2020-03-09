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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabClefs = New System.Windows.Forms.TabPage()
        Me.tlytClefs = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEmprunter = New MaterialSkin.Controls.MaterialButton()
        Me.btnAttribuer = New MaterialSkin.Controls.MaterialButton()
        Me.btnEditer = New MaterialSkin.Controls.MaterialButton()
        Me.btnSupprimer = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddKey = New MaterialSkin.Controls.MaterialButton()
        Me.btnInformations = New MaterialSkin.Controls.MaterialButton()
        Me.tabGestion = New System.Windows.Forms.TabPage()
        Me.tlytGestion = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBatiments = New MaterialSkin.Controls.MaterialButton()
        Me.btnAlertes = New MaterialSkin.Controls.MaterialButton()
        Me.btnTableaux = New MaterialSkin.Controls.MaterialButton()
        Me.btnTrousseaux = New MaterialSkin.Controls.MaterialButton()
        Me.btnParametres = New MaterialSkin.Controls.MaterialButton()
        Me.btnLightMode = New MaterialSkin.Controls.MaterialButton()
        Me.btnPersonnes = New MaterialSkin.Controls.MaterialButton()
        Me.btnClefsPerdues = New MaterialSkin.Controls.MaterialButton()
        Me.menuGrid = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.EmprunterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttribuerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkAttribuees = New MaterialSkin.Controls.MaterialCheckbox()
        Me.chkEmpruntees = New MaterialSkin.Controls.MaterialCheckbox()
        Me.chkDisponibles = New MaterialSkin.Controls.MaterialCheckbox()
        Me.dgvPanier = New System.Windows.Forms.DataGridView()
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.cbRechercher = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblNbDeClefs = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRemoveToPanier = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddToPanier = New MaterialSkin.Controls.MaterialButton()
        Me.btnRefresh = New MaterialSkin.Controls.MaterialButton()
        Me.pbClearPanier = New System.Windows.Forms.PictureBox()
        Me.lblAlertNotif = New System.Windows.Forms.Label()
        Me.btnPanierVersTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTabControl1.SuspendLayout()
        Me.tabClefs.SuspendLayout()
        Me.tlytClefs.SuspendLayout()
        Me.tabGestion.SuspendLayout()
        Me.tlytGestion.SuspendLayout()
        Me.menuGrid.SuspendLayout()
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClearPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRechercher
        '
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(8, 176)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(344, 36)
        Me.txtRechercher.TabIndex = 153
        Me.txtRechercher.TabStop = False
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(593, 69)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MaterialLabel1.TabIndex = 150
        Me.MaterialLabel1.Text = "Panier"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(170, 25)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(350, 39)
        Me.MaterialTabSelector1.TabIndex = 148
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.tabClefs)
        Me.MaterialTabControl1.Controls.Add(Me.tabGestion)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(8, 69)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(575, 134)
        Me.MaterialTabControl1.TabIndex = 147
        '
        'tabClefs
        '
        Me.tabClefs.BackColor = System.Drawing.Color.Transparent
        Me.tabClefs.Controls.Add(Me.tlytClefs)
        Me.tabClefs.Location = New System.Drawing.Point(4, 22)
        Me.tabClefs.Name = "tabClefs"
        Me.tabClefs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClefs.Size = New System.Drawing.Size(567, 108)
        Me.tabClefs.TabIndex = 0
        Me.tabClefs.Text = "Clefs"
        '
        'tlytClefs
        '
        Me.tlytClefs.BackColor = System.Drawing.Color.Transparent
        Me.tlytClefs.ColumnCount = 3
        Me.tlytClefs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlytClefs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlytClefs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlytClefs.Controls.Add(Me.btnEmprunter, 1, 0)
        Me.tlytClefs.Controls.Add(Me.btnAttribuer, 2, 0)
        Me.tlytClefs.Controls.Add(Me.btnEditer, 0, 1)
        Me.tlytClefs.Controls.Add(Me.btnSupprimer, 2, 1)
        Me.tlytClefs.Controls.Add(Me.btnAddKey, 0, 0)
        Me.tlytClefs.Controls.Add(Me.btnInformations, 1, 1)
        Me.tlytClefs.Location = New System.Drawing.Point(6, 6)
        Me.tlytClefs.Name = "tlytClefs"
        Me.tlytClefs.RowCount = 2
        Me.tlytClefs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlytClefs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlytClefs.Size = New System.Drawing.Size(555, 96)
        Me.tlytClefs.TabIndex = 0
        '
        'btnEmprunter
        '
        Me.btnEmprunter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEmprunter.Depth = 0
        Me.btnEmprunter.DrawShadows = True
        Me.btnEmprunter.HighEmphasis = False
        Me.btnEmprunter.Icon = Global.GestionClefs.My.Resources.Resources.emprunt
        Me.btnEmprunter.Location = New System.Drawing.Point(189, 6)
        Me.btnEmprunter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEmprunter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEmprunter.Name = "btnEmprunter"
        Me.btnEmprunter.Size = New System.Drawing.Size(136, 36)
        Me.btnEmprunter.TabIndex = 118
        Me.btnEmprunter.Text = "Emprunter"
        Me.btnEmprunter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnEmprunter.UseAccentColor = False
        Me.btnEmprunter.UseVisualStyleBackColor = True
        '
        'btnAttribuer
        '
        Me.btnAttribuer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAttribuer.Depth = 0
        Me.btnAttribuer.DrawShadows = True
        Me.btnAttribuer.HighEmphasis = False
        Me.btnAttribuer.Icon = Global.GestionClefs.My.Resources.Resources.login
        Me.btnAttribuer.Location = New System.Drawing.Point(374, 6)
        Me.btnAttribuer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAttribuer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAttribuer.Name = "btnAttribuer"
        Me.btnAttribuer.Size = New System.Drawing.Size(127, 36)
        Me.btnAttribuer.TabIndex = 119
        Me.btnAttribuer.Text = "Attribuer"
        Me.btnAttribuer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAttribuer.UseAccentColor = False
        Me.btnAttribuer.UseVisualStyleBackColor = True
        '
        'btnEditer
        '
        Me.btnEditer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditer.Depth = 0
        Me.btnEditer.DrawShadows = True
        Me.btnEditer.HighEmphasis = False
        Me.btnEditer.Icon = Global.GestionClefs.My.Resources.Resources.writing
        Me.btnEditer.Location = New System.Drawing.Point(4, 54)
        Me.btnEditer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEditer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditer.Name = "btnEditer"
        Me.btnEditer.Size = New System.Drawing.Size(116, 36)
        Me.btnEditer.TabIndex = 120
        Me.btnEditer.Text = "Modifier"
        Me.btnEditer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnEditer.UseAccentColor = False
        Me.btnEditer.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSupprimer.Depth = 0
        Me.btnSupprimer.DrawShadows = True
        Me.btnSupprimer.HighEmphasis = False
        Me.btnSupprimer.Icon = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.btnSupprimer.Location = New System.Drawing.Point(374, 54)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(130, 36)
        Me.btnSupprimer.TabIndex = 123
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnSupprimer.UseAccentColor = False
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnAddKey
        '
        Me.btnAddKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddKey.Depth = 0
        Me.btnAddKey.DrawShadows = True
        Me.btnAddKey.HighEmphasis = False
        Me.btnAddKey.Icon = Global.GestionClefs.My.Resources.Resources.ajouter_clefs
        Me.btnAddKey.Location = New System.Drawing.Point(4, 6)
        Me.btnAddKey.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddKey.Name = "btnAddKey"
        Me.btnAddKey.Size = New System.Drawing.Size(177, 36)
        Me.btnAddKey.TabIndex = 124
        Me.btnAddKey.Text = "Ajouter une clef"
        Me.btnAddKey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddKey.UseAccentColor = False
        Me.btnAddKey.UseVisualStyleBackColor = True
        '
        'btnInformations
        '
        Me.btnInformations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInformations.Depth = 0
        Me.btnInformations.DrawShadows = True
        Me.btnInformations.HighEmphasis = False
        Me.btnInformations.Icon = Global.GestionClefs.My.Resources.Resources.round_info_button
        Me.btnInformations.Location = New System.Drawing.Point(189, 54)
        Me.btnInformations.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInformations.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInformations.Name = "btnInformations"
        Me.btnInformations.Size = New System.Drawing.Size(157, 36)
        Me.btnInformations.TabIndex = 121
        Me.btnInformations.Text = "Informations"
        Me.btnInformations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnInformations.UseAccentColor = False
        Me.btnInformations.UseVisualStyleBackColor = True
        '
        'tabGestion
        '
        Me.tabGestion.Controls.Add(Me.tlytGestion)
        Me.tabGestion.Location = New System.Drawing.Point(4, 22)
        Me.tabGestion.Name = "tabGestion"
        Me.tabGestion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGestion.Size = New System.Drawing.Size(567, 108)
        Me.tabGestion.TabIndex = 1
        Me.tabGestion.Text = "Gestion"
        Me.tabGestion.UseVisualStyleBackColor = True
        '
        'tlytGestion
        '
        Me.tlytGestion.BackColor = System.Drawing.Color.Transparent
        Me.tlytGestion.ColumnCount = 4
        Me.tlytGestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlytGestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlytGestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlytGestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlytGestion.Controls.Add(Me.btnBatiments, 3, 0)
        Me.tlytGestion.Controls.Add(Me.btnAlertes, 0, 1)
        Me.tlytGestion.Controls.Add(Me.btnTableaux, 2, 0)
        Me.tlytGestion.Controls.Add(Me.btnTrousseaux, 1, 0)
        Me.tlytGestion.Controls.Add(Me.btnParametres, 3, 1)
        Me.tlytGestion.Controls.Add(Me.btnLightMode, 2, 1)
        Me.tlytGestion.Controls.Add(Me.btnPersonnes, 0, 0)
        Me.tlytGestion.Controls.Add(Me.btnClefsPerdues, 1, 1)
        Me.tlytGestion.Location = New System.Drawing.Point(6, 6)
        Me.tlytGestion.Name = "tlytGestion"
        Me.tlytGestion.RowCount = 2
        Me.tlytGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlytGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlytGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlytGestion.Size = New System.Drawing.Size(555, 96)
        Me.tlytGestion.TabIndex = 160
        '
        'btnBatiments
        '
        Me.btnBatiments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBatiments.Depth = 0
        Me.btnBatiments.DrawShadows = True
        Me.btnBatiments.HighEmphasis = False
        Me.btnBatiments.Icon = Global.GestionClefs.My.Resources.Resources.web_server
        Me.btnBatiments.Location = New System.Drawing.Point(418, 6)
        Me.btnBatiments.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBatiments.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBatiments.Name = "btnBatiments"
        Me.btnBatiments.Size = New System.Drawing.Size(131, 36)
        Me.btnBatiments.TabIndex = 129
        Me.btnBatiments.Text = "Bâtiments"
        Me.btnBatiments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnBatiments.UseAccentColor = False
        Me.btnBatiments.UseVisualStyleBackColor = True
        '
        'btnAlertes
        '
        Me.btnAlertes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAlertes.BackColor = System.Drawing.Color.Transparent
        Me.btnAlertes.Depth = 0
        Me.btnAlertes.DrawShadows = True
        Me.btnAlertes.HighEmphasis = False
        Me.btnAlertes.Icon = Global.GestionClefs.My.Resources.Resources.round_error_symbol
        Me.btnAlertes.Location = New System.Drawing.Point(4, 54)
        Me.btnAlertes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAlertes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAlertes.Name = "btnAlertes"
        Me.btnAlertes.Size = New System.Drawing.Size(111, 36)
        Me.btnAlertes.TabIndex = 151
        Me.btnAlertes.Text = "Alertes"
        Me.btnAlertes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAlertes.UseAccentColor = False
        Me.btnAlertes.UseVisualStyleBackColor = False
        '
        'btnTableaux
        '
        Me.btnTableaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTableaux.Depth = 0
        Me.btnTableaux.DrawShadows = True
        Me.btnTableaux.HighEmphasis = False
        Me.btnTableaux.Icon = Global.GestionClefs.My.Resources.Resources.tableaux
        Me.btnTableaux.Location = New System.Drawing.Point(280, 6)
        Me.btnTableaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTableaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTableaux.Name = "btnTableaux"
        Me.btnTableaux.Size = New System.Drawing.Size(122, 36)
        Me.btnTableaux.TabIndex = 128
        Me.btnTableaux.Text = "Tableaux"
        Me.btnTableaux.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnTableaux.UseAccentColor = False
        Me.btnTableaux.UseVisualStyleBackColor = True
        '
        'btnTrousseaux
        '
        Me.btnTrousseaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTrousseaux.Depth = 0
        Me.btnTrousseaux.DrawShadows = True
        Me.btnTrousseaux.HighEmphasis = False
        Me.btnTrousseaux.Icon = Global.GestionClefs.My.Resources.Resources.trousseaux
        Me.btnTrousseaux.Location = New System.Drawing.Point(142, 6)
        Me.btnTrousseaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTrousseaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTrousseaux.Name = "btnTrousseaux"
        Me.btnTrousseaux.Size = New System.Drawing.Size(130, 36)
        Me.btnTrousseaux.TabIndex = 125
        Me.btnTrousseaux.Text = "Trousseaux"
        Me.btnTrousseaux.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnTrousseaux.UseAccentColor = False
        Me.btnTrousseaux.UseVisualStyleBackColor = True
        '
        'btnParametres
        '
        Me.btnParametres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnParametres.Depth = 0
        Me.btnParametres.DrawShadows = True
        Me.btnParametres.HighEmphasis = False
        Me.btnParametres.Icon = Global.GestionClefs.My.Resources.Resources.settings_cogwheel_button
        Me.btnParametres.Location = New System.Drawing.Point(418, 54)
        Me.btnParametres.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParametres.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnParametres.Name = "btnParametres"
        Me.btnParametres.Size = New System.Drawing.Size(133, 36)
        Me.btnParametres.TabIndex = 152
        Me.btnParametres.Text = "Paramètres"
        Me.btnParametres.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnParametres.UseAccentColor = False
        Me.btnParametres.UseVisualStyleBackColor = True
        '
        'btnLightMode
        '
        Me.btnLightMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLightMode.Depth = 0
        Me.btnLightMode.DrawShadows = True
        Me.btnLightMode.HighEmphasis = False
        Me.btnLightMode.Icon = Global.GestionClefs.My.Resources.Resources.light_bulb_on
        Me.btnLightMode.Location = New System.Drawing.Point(280, 54)
        Me.btnLightMode.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLightMode.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLightMode.Name = "btnLightMode"
        Me.btnLightMode.Size = New System.Drawing.Size(98, 36)
        Me.btnLightMode.TabIndex = 154
        Me.btnLightMode.Text = "Theme"
        Me.btnLightMode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnLightMode.UseAccentColor = False
        Me.btnLightMode.UseVisualStyleBackColor = True
        '
        'btnPersonnes
        '
        Me.btnPersonnes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPersonnes.Depth = 0
        Me.btnPersonnes.DrawShadows = True
        Me.btnPersonnes.HighEmphasis = False
        Me.btnPersonnes.Icon = Global.GestionClefs.My.Resources.Resources.two_men
        Me.btnPersonnes.Location = New System.Drawing.Point(4, 6)
        Me.btnPersonnes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPersonnes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPersonnes.Name = "btnPersonnes"
        Me.btnPersonnes.Size = New System.Drawing.Size(130, 36)
        Me.btnPersonnes.TabIndex = 122
        Me.btnPersonnes.Text = "Personnes"
        Me.btnPersonnes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnPersonnes.UseAccentColor = False
        Me.btnPersonnes.UseVisualStyleBackColor = True
        '
        'btnClefsPerdues
        '
        Me.btnClefsPerdues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClefsPerdues.Depth = 0
        Me.btnClefsPerdues.DrawShadows = True
        Me.btnClefsPerdues.HighEmphasis = False
        Me.btnClefsPerdues.Icon = Global.GestionClefs.My.Resources.Resources.clefperdue
        Me.btnClefsPerdues.Location = New System.Drawing.Point(142, 54)
        Me.btnClefsPerdues.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClefsPerdues.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClefsPerdues.Name = "btnClefsPerdues"
        Me.btnClefsPerdues.Size = New System.Drawing.Size(113, 36)
        Me.btnClefsPerdues.TabIndex = 155
        Me.btnClefsPerdues.Text = "Perdues"
        Me.btnClefsPerdues.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnClefsPerdues.UseAccentColor = False
        Me.btnClefsPerdues.UseVisualStyleBackColor = True
        '
        'menuGrid
        '
        Me.menuGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.menuGrid.Depth = 0
        Me.menuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmprunterToolStripMenuItem1, Me.AttribuerToolStripMenuItem1, Me.EditerToolStripMenuItem1, Me.PropriétésToolStripMenuItem1, Me.SupprimerToolStripMenuItem1})
        Me.menuGrid.MouseState = MaterialSkin.MouseState.HOVER
        Me.menuGrid.Name = "MaterialContextMenuStrip1"
        Me.menuGrid.Size = New System.Drawing.Size(140, 114)
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
        'SupprimerToolStripMenuItem1
        '
        Me.SupprimerToolStripMenuItem1.Image = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.SupprimerToolStripMenuItem1.Name = "SupprimerToolStripMenuItem1"
        Me.SupprimerToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.SupprimerToolStripMenuItem1.Text = "Supprimer"
        '
        'chkAttribuees
        '
        Me.chkAttribuees.AutoSize = True
        Me.chkAttribuees.Depth = 0
        Me.chkAttribuees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkAttribuees.Location = New System.Drawing.Point(246, 216)
        Me.chkAttribuees.Margin = New System.Windows.Forms.Padding(0)
        Me.chkAttribuees.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkAttribuees.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkAttribuees.Name = "chkAttribuees"
        Me.chkAttribuees.Ripple = True
        Me.chkAttribuees.Size = New System.Drawing.Size(106, 37)
        Me.chkAttribuees.TabIndex = 144
        Me.chkAttribuees.Text = "Attribuées"
        Me.chkAttribuees.UseVisualStyleBackColor = True
        '
        'chkEmpruntees
        '
        Me.chkEmpruntees.AutoSize = True
        Me.chkEmpruntees.Depth = 0
        Me.chkEmpruntees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkEmpruntees.Location = New System.Drawing.Point(126, 216)
        Me.chkEmpruntees.Margin = New System.Windows.Forms.Padding(0)
        Me.chkEmpruntees.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkEmpruntees.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkEmpruntees.Name = "chkEmpruntees"
        Me.chkEmpruntees.Ripple = True
        Me.chkEmpruntees.Size = New System.Drawing.Size(119, 37)
        Me.chkEmpruntees.TabIndex = 143
        Me.chkEmpruntees.Text = "Empruntées"
        Me.chkEmpruntees.UseVisualStyleBackColor = True
        '
        'chkDisponibles
        '
        Me.chkDisponibles.AutoSize = True
        Me.chkDisponibles.Checked = True
        Me.chkDisponibles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisponibles.Depth = 0
        Me.chkDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkDisponibles.Location = New System.Drawing.Point(8, 216)
        Me.chkDisponibles.Margin = New System.Windows.Forms.Padding(0)
        Me.chkDisponibles.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkDisponibles.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkDisponibles.Name = "chkDisponibles"
        Me.chkDisponibles.Ripple = True
        Me.chkDisponibles.Size = New System.Drawing.Size(118, 37)
        Me.chkDisponibles.TabIndex = 142
        Me.chkDisponibles.Text = "Disponibles"
        Me.chkDisponibles.UseVisualStyleBackColor = True
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
        Me.dgvPanier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPanier.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPanier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPanier.Location = New System.Drawing.Point(589, 89)
        Me.dgvPanier.MaximumSize = New System.Drawing.Size(3840, 167)
        Me.dgvPanier.Name = "dgvPanier"
        Me.dgvPanier.ReadOnly = True
        Me.dgvPanier.RowHeadersVisible = False
        Me.dgvPanier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPanier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPanier.Size = New System.Drawing.Size(423, 167)
        Me.dgvPanier.TabIndex = 146
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
        Me.dgvResultats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultats.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(8, 264)
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(1004, 479)
        Me.dgvResultats.TabIndex = 141
        '
        'cbRechercher
        '
        Me.cbRechercher.AutoResize = False
        Me.cbRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRechercher.Depth = 0
        Me.cbRechercher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbRechercher.DropDownHeight = 176
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.DropDownWidth = 121
        Me.cbRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbRechercher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.IntegralHeight = False
        Me.cbRechercher.ItemHeight = 29
        Me.cbRechercher.Location = New System.Drawing.Point(358, 176)
        Me.cbRechercher.MaxDropDownItems = 6
        Me.cbRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(221, 35)
        Me.cbRechercher.TabIndex = 157
        Me.cbRechercher.UseTallSize = False
        '
        'lblNbDeClefs
        '
        Me.lblNbDeClefs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNbDeClefs.AutoSize = True
        Me.lblNbDeClefs.Depth = 0
        Me.lblNbDeClefs.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNbDeClefs.Location = New System.Drawing.Point(9, 746)
        Me.lblNbDeClefs.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNbDeClefs.Name = "lblNbDeClefs"
        Me.lblNbDeClefs.Size = New System.Drawing.Size(274, 19)
        Me.lblNbDeClefs.TabIndex = 158
        Me.lblNbDeClefs.Text = "25 clefs trouvées, 135 clefs enregistrés"
        '
        'btnRemoveToPanier
        '
        Me.btnRemoveToPanier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRemoveToPanier.Depth = 0
        Me.btnRemoveToPanier.DrawShadows = True
        Me.btnRemoveToPanier.HighEmphasis = True
        Me.btnRemoveToPanier.Icon = Global.GestionClefs.My.Resources.Resources.shopping_cart_remove
        Me.btnRemoveToPanier.Location = New System.Drawing.Point(491, 219)
        Me.btnRemoveToPanier.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRemoveToPanier.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRemoveToPanier.Name = "btnRemoveToPanier"
        Me.btnRemoveToPanier.Size = New System.Drawing.Size(44, 36)
        Me.btnRemoveToPanier.TabIndex = 156
        Me.btnRemoveToPanier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnRemoveToPanier.UseAccentColor = False
        Me.btnRemoveToPanier.UseVisualStyleBackColor = True
        '
        'btnAddToPanier
        '
        Me.btnAddToPanier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddToPanier.Depth = 0
        Me.btnAddToPanier.DrawShadows = True
        Me.btnAddToPanier.HighEmphasis = True
        Me.btnAddToPanier.Icon = Global.GestionClefs.My.Resources.Resources.shopping_cart_add
        Me.btnAddToPanier.Location = New System.Drawing.Point(538, 219)
        Me.btnAddToPanier.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddToPanier.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddToPanier.Name = "btnAddToPanier"
        Me.btnAddToPanier.Size = New System.Drawing.Size(44, 36)
        Me.btnAddToPanier.TabIndex = 155
        Me.btnAddToPanier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddToPanier.UseAccentColor = False
        Me.btnAddToPanier.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRefresh.Depth = 0
        Me.btnRefresh.DrawShadows = True
        Me.btnRefresh.HighEmphasis = True
        Me.btnRefresh.Icon = Global.GestionClefs.My.Resources.Resources.refresh_button
        Me.btnRefresh.Location = New System.Drawing.Point(392, 219)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(44, 36)
        Me.btnRefresh.TabIndex = 149
        Me.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnRefresh.UseAccentColor = False
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'pbClearPanier
        '
        Me.pbClearPanier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbClearPanier.Image = Global.GestionClefs.My.Resources.Resources.clear_button
        Me.pbClearPanier.Location = New System.Drawing.Point(993, 67)
        Me.pbClearPanier.Name = "pbClearPanier"
        Me.pbClearPanier.Size = New System.Drawing.Size(19, 19)
        Me.pbClearPanier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClearPanier.TabIndex = 159
        Me.pbClearPanier.TabStop = False
        '
        'lblAlertNotif
        '
        Me.lblAlertNotif.AutoSize = True
        Me.lblAlertNotif.BackColor = System.Drawing.Color.Transparent
        Me.lblAlertNotif.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertNotif.ForeColor = System.Drawing.Color.Red
        Me.lblAlertNotif.Location = New System.Drawing.Point(348, 32)
        Me.lblAlertNotif.Name = "lblAlertNotif"
        Me.lblAlertNotif.Size = New System.Drawing.Size(13, 14)
        Me.lblAlertNotif.TabIndex = 160
        Me.lblAlertNotif.Text = "1"
        Me.lblAlertNotif.Visible = False
        '
        'btnPanierVersTrousseau
        '
        Me.btnPanierVersTrousseau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPanierVersTrousseau.Depth = 0
        Me.btnPanierVersTrousseau.DrawShadows = True
        Me.btnPanierVersTrousseau.HighEmphasis = True
        Me.btnPanierVersTrousseau.Icon = Global.GestionClefs.My.Resources.Resources.key_1_
        Me.btnPanierVersTrousseau.Location = New System.Drawing.Point(444, 219)
        Me.btnPanierVersTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPanierVersTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPanierVersTrousseau.Name = "btnPanierVersTrousseau"
        Me.btnPanierVersTrousseau.Size = New System.Drawing.Size(44, 36)
        Me.btnPanierVersTrousseau.TabIndex = 161
        Me.btnPanierVersTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnPanierVersTrousseau.UseAccentColor = False
        Me.btnPanierVersTrousseau.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnPanierVersTrousseau)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.pbClearPanier)
        Me.Controls.Add(Me.lblNbDeClefs)
        Me.Controls.Add(Me.cbRechercher)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnRemoveToPanier)
        Me.Controls.Add(Me.btnAddToPanier)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chkAttribuees)
        Me.Controls.Add(Me.chkEmpruntees)
        Me.Controls.Add(Me.chkDisponibles)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.dgvPanier)
        Me.Controls.Add(Me.dgvResultats)
        Me.Controls.Add(Me.lblAlertNotif)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMain"
        Me.Text = "GestionClefs"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.tabClefs.ResumeLayout(False)
        Me.tlytClefs.ResumeLayout(False)
        Me.tlytClefs.PerformLayout()
        Me.tabGestion.ResumeLayout(False)
        Me.tlytGestion.ResumeLayout(False)
        Me.tlytGestion.PerformLayout()
        Me.menuGrid.ResumeLayout(False)
        CType(Me.dgvPanier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClearPanier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPersonnes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabClefs As TabPage
    Friend WithEvents tlytClefs As TableLayoutPanel
    Friend WithEvents btnEmprunter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAttribuer As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEditer As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSupprimer As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddKey As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnInformations As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tabGestion As TabPage
    Friend WithEvents btnTableaux As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTrousseaux As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBatiments As MaterialSkin.Controls.MaterialButton
    Friend WithEvents menuGrid As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents EmprunterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AttribuerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropriétésToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnRemoveToPanier As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddToPanier As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnParametres As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAlertes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnRefresh As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkAttribuees As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents chkEmpruntees As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents chkDisponibles As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents dgvPanier As DataGridView
    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents cbRechercher As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents tlytGestion As TableLayoutPanel
    Friend WithEvents lblNbDeClefs As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnClefsPerdues As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pbClearPanier As PictureBox
    Friend WithEvents lblAlertNotif As Label
    Friend WithEvents btnLightMode As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPanierVersTrousseau As MaterialSkin.Controls.MaterialButton
End Class
