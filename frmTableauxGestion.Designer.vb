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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableauxGestion))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPBatiment = New System.Windows.Forms.Label()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.btnAddPersonne = New System.Windows.Forms.Button()
        Me.cbResponsable = New System.Windows.Forms.ComboBox()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.lblPResponsable = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.chkKeepOpen = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListTableau = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListTableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPBatiment)
        Me.GroupBox2.Controls.Add(Me.dgvListBatiment)
        Me.GroupBox2.Controls.Add(Me.btnAddPersonne)
        Me.GroupBox2.Controls.Add(Me.cbResponsable)
        Me.GroupBox2.Controls.Add(Me.lblPNom)
        Me.GroupBox2.Controls.Add(Me.lblPResponsable)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 307)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ajouter une personne"
        '
        'lblPBatiment
        '
        Me.lblPBatiment.AutoSize = True
        Me.lblPBatiment.Location = New System.Drawing.Point(6, 96)
        Me.lblPBatiment.Name = "lblPBatiment"
        Me.lblPBatiment.Size = New System.Drawing.Size(54, 13)
        Me.lblPBatiment.TabIndex = 64
        Me.lblPBatiment.Text = "Batiment :"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListBatiment.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListBatiment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListBatiment.Location = New System.Drawing.Point(9, 112)
        Me.dgvListBatiment.MultiSelect = False
        Me.dgvListBatiment.Name = "dgvListBatiment"
        Me.dgvListBatiment.ReadOnly = True
        Me.dgvListBatiment.RowHeadersVisible = False
        Me.dgvListBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBatiment.Size = New System.Drawing.Size(333, 189)
        Me.dgvListBatiment.TabIndex = 45
        '
        'btnAddPersonne
        '
        Me.btnAddPersonne.Location = New System.Drawing.Point(252, 32)
        Me.btnAddPersonne.Name = "btnAddPersonne"
        Me.btnAddPersonne.Size = New System.Drawing.Size(23, 23)
        Me.btnAddPersonne.TabIndex = 63
        Me.btnAddPersonne.Text = "+"
        Me.btnAddPersonne.UseVisualStyleBackColor = True
        '
        'cbResponsable
        '
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.Location = New System.Drawing.Point(9, 33)
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(234, 21)
        Me.cbResponsable.TabIndex = 57
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Location = New System.Drawing.Point(6, 57)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(35, 13)
        Me.lblPNom.TabIndex = 54
        Me.lblPNom.Text = "Nom :"
        '
        'lblPResponsable
        '
        Me.lblPResponsable.AutoSize = True
        Me.lblPResponsable.Location = New System.Drawing.Point(6, 17)
        Me.lblPResponsable.Name = "lblPResponsable"
        Me.lblPResponsable.Size = New System.Drawing.Size(75, 13)
        Me.lblPResponsable.TabIndex = 53
        Me.lblPResponsable.Text = "Responsable :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(9, 73)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(234, 20)
        Me.txtNom.TabIndex = 49
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Location = New System.Drawing.Point(360, 392)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New System.Drawing.Size(144, 17)
        Me.chkKeepOpen.TabIndex = 46
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 383)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(219, 32)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(368, 70)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(404, 45)
        Me.gbRechercher.TabIndex = 65
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher un tableaux"
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
        Me.GroupBox1.Controls.Add(Me.dgvListTableau)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 256)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des tableaux"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListTableau.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListTableau.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListTableau.Location = New System.Drawing.Point(6, 21)
        Me.dgvListTableau.MultiSelect = False
        Me.dgvListTableau.Name = "dgvListTableau"
        Me.dgvListTableau.ReadOnly = True
        Me.dgvListTableau.RowHeadersVisible = False
        Me.dgvListTableau.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListTableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTableau.Size = New System.Drawing.Size(392, 229)
        Me.dgvListTableau.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(237, 383)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 32)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'frmTableauxGestion
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(784, 425)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbRechercher)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableauxGestion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Gérer les tableaux de clefs"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListTableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddPersonne As Button
    Friend WithEvents cbResponsable As ComboBox
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblPNom As Label
    Friend WithEvents lblPResponsable As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents lblPBatiment As Label
    Friend WithEvents dgvListBatiment As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListTableau As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
End Class
