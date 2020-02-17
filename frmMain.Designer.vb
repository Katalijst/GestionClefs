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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbEmprunter = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.gbRechercher.SuspendLayout()
        Me.gbFilter.SuspendLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuGrid.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmprunter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAddClef.Location = New System.Drawing.Point(279, 62)
        Me.btnAddClef.Name = "btnAddClef"
        Me.btnAddClef.Size = New System.Drawing.Size(111, 23)
        Me.btnAddClef.TabIndex = 7
        Me.btnAddClef.Text = "Ajouter une clef"
        Me.btnAddClef.UseVisualStyleBackColor = True
        '
        'btnAddTrousseau
        '
        Me.btnAddTrousseau.Location = New System.Drawing.Point(396, 62)
        Me.btnAddTrousseau.Name = "btnAddTrousseau"
        Me.btnAddTrousseau.Size = New System.Drawing.Size(111, 23)
        Me.btnAddTrousseau.TabIndex = 8
        Me.btnAddTrousseau.Text = "Trousseaux"
        Me.btnAddTrousseau.UseVisualStyleBackColor = True
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Controls.Add(Me.gbFilter)
        Me.gbRechercher.Controls.Add(Me.cbRechercher)
        Me.gbRechercher.Controls.Add(Me.btnAddClef)
        Me.gbRechercher.Controls.Add(Me.btnAddTrousseau)
        Me.gbRechercher.Location = New System.Drawing.Point(3, 27)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(514, 107)
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
        Me.txtRechercher.Size = New System.Drawing.Size(320, 20)
        Me.txtRechercher.TabIndex = 0
        '
        'gbFilter
        '
        Me.gbFilter.Controls.Add(Me.chkDisponibles)
        Me.gbFilter.Controls.Add(Me.chkEmpruntees)
        Me.gbFilter.Controls.Add(Me.chkAttribuees)
        Me.gbFilter.Location = New System.Drawing.Point(11, 49)
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
        Me.cbRechercher.Location = New System.Drawing.Point(332, 19)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(175, 21)
        Me.cbRechercher.TabIndex = 1
        '
        'dgvResultats
        '
        Me.dgvResultats.AllowUserToAddRows = False
        Me.dgvResultats.AllowUserToDeleteRows = False
        Me.dgvResultats.AllowUserToResizeRows = False
        Me.dgvResultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultats.ContextMenuStrip = Me.menuGrid
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(3, 140)
        Me.dgvResultats.MultiSelect = False
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(777, 396)
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
        Me.EmprunterToolStripMenuItem.Name = "EmprunterToolStripMenuItem"
        Me.EmprunterToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmprunterToolStripMenuItem.Text = "Emprunter..."
        '
        'AttribuerToolStripMenuItem
        '
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
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EditerToolStripMenuItem.Text = "Editer"
        '
        'PropriétésToolStripMenuItem
        '
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
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menAlertes, Me.RafraichirLaPageToolStripMenuItem, Me.OutilsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menAlertes
        '
        Me.menAlertes.Name = "menAlertes"
        Me.menAlertes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.menAlertes.Size = New System.Drawing.Size(55, 20)
        Me.menAlertes.Text = "&Alertes"
        '
        'RafraichirLaPageToolStripMenuItem
        '
        Me.RafraichirLaPageToolStripMenuItem.Name = "RafraichirLaPageToolStripMenuItem"
        Me.RafraichirLaPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RafraichirLaPageToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
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
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SettingsToolStripMenuItem.Text = "&Paramètres"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 101
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AProposToolStripMenuItem.Text = "A propos..."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GestionClefs.My.Resources.Resources.writing
        Me.PictureBox3.Location = New System.Drawing.Point(560, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 105
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GestionClefs.My.Resources.Resources.login
        Me.PictureBox2.Location = New System.Drawing.Point(560, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GestionClefs.My.Resources.Resources.name
        Me.PictureBox1.Location = New System.Drawing.Point(523, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'pbEmprunter
        '
        Me.pbEmprunter.Image = Global.GestionClefs.My.Resources.Resources.key1
        Me.pbEmprunter.Location = New System.Drawing.Point(597, 37)
        Me.pbEmprunter.Name = "pbEmprunter"
        Me.pbEmprunter.Size = New System.Drawing.Size(59, 66)
        Me.pbEmprunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmprunter.TabIndex = 102
        Me.pbEmprunter.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GestionClefs.My.Resources.Resources.name
        Me.PictureBox4.Location = New System.Drawing.Point(523, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 106
        Me.PictureBox4.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbEmprunter)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvResultats)
        Me.Controls.Add(Me.gbRechercher)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmprunter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
