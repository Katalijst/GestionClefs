<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionBatiments
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkKeepOpen = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtFonction = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblFonction = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListBatiment)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 244)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des bâtiments"
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
        Me.dgvListBatiment.Location = New System.Drawing.Point(6, 21)
        Me.dgvListBatiment.MultiSelect = False
        Me.dgvListBatiment.Name = "dgvListBatiment"
        Me.dgvListBatiment.ReadOnly = True
        Me.dgvListBatiment.RowHeadersVisible = False
        Me.dgvListBatiment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListBatiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListBatiment.Size = New System.Drawing.Size(392, 217)
        Me.dgvListBatiment.TabIndex = 45
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(368, 12)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(404, 45)
        Me.gbRechercher.TabIndex = 42
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher un bâtiment"
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
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(237, 32)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Location = New System.Drawing.Point(6, 243)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New System.Drawing.Size(144, 17)
        Me.chkKeepOpen.TabIndex = 46
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(249, 266)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 32)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 33)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 48
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(9, 76)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(335, 20)
        Me.txtNom.TabIndex = 49
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(9, 119)
        Me.txtAdresse.MaxLength = 255
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(335, 20)
        Me.txtAdresse.TabIndex = 50
        '
        'txtFonction
        '
        Me.txtFonction.Location = New System.Drawing.Point(9, 162)
        Me.txtFonction.MaxLength = 255
        Me.txtFonction.Name = "txtFonction"
        Me.txtFonction.Size = New System.Drawing.Size(335, 20)
        Me.txtFonction.TabIndex = 51
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 17)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 13)
        Me.lblID.TabIndex = 53
        Me.lblID.Text = "N° :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(6, 60)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(78, 13)
        Me.lblNom.TabIndex = 54
        Me.lblNom.Text = "Dénomination :"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(6, 103)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(51, 13)
        Me.lblAdresse.TabIndex = 55
        Me.lblAdresse.Text = "Adresse :"
        '
        'lblFonction
        '
        Me.lblFonction.AutoSize = True
        Me.lblFonction.Location = New System.Drawing.Point(6, 146)
        Me.lblFonction.Name = "lblFonction"
        Me.lblFonction.Size = New System.Drawing.Size(54, 13)
        Me.lblFonction.TabIndex = 56
        Me.lblFonction.Text = "Fonction :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFonction)
        Me.GroupBox2.Controls.Add(Me.chkKeepOpen)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.lblAdresse)
        Me.GroupBox2.Controls.Add(Me.lblNom)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.txtFonction)
        Me.GroupBox2.Controls.Add(Me.txtAdresse)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 304)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ajouter un bâtiment"
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
        'frmGestionBatiments
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(784, 323)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbRechercher)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionBatiments"
        Me.ShowIcon = False
        Me.Text = "Gérer les bâtiments"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListBatiment As DataGridView
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtFonction As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblFonction As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
End Class
