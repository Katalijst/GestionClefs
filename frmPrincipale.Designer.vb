<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.gbFilter = New System.Windows.Forms.GroupBox()
        Me.chkDisponibles = New System.Windows.Forms.CheckBox()
        Me.chkEmpruntees = New System.Windows.Forms.CheckBox()
        Me.chkAttribuees = New System.Windows.Forms.CheckBox()
        Me.cbRechercher = New System.Windows.Forms.ComboBox()
        Me.btnAddClef = New System.Windows.Forms.Button()
        Me.btnAddTrousseau = New System.Windows.Forms.Button()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.gbFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResultats
        '
        Me.dgvResultats.AllowUserToAddRows = False
        Me.dgvResultats.AllowUserToDeleteRows = False
        Me.dgvResultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultats.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(12, 125)
        Me.dgvResultats.MultiSelect = False
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(776, 313)
        Me.dgvResultats.TabIndex = 50
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Controls.Add(Me.gbFilter)
        Me.gbRechercher.Controls.Add(Me.cbRechercher)
        Me.gbRechercher.Controls.Add(Me.btnAddClef)
        Me.gbRechercher.Controls.Add(Me.btnAddTrousseau)
        Me.gbRechercher.Location = New System.Drawing.Point(12, 12)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(514, 107)
        Me.gbRechercher.TabIndex = 52
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
        'frmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbRechercher)
        Me.Controls.Add(Me.dgvResultats)
        Me.Name = "frmPrincipale"
        Me.Text = "frmPrincipale"
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.gbFilter.ResumeLayout(False)
        Me.gbFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents chkDisponibles As CheckBox
    Friend WithEvents chkEmpruntees As CheckBox
    Friend WithEvents chkAttribuees As CheckBox
    Friend WithEvents cbRechercher As ComboBox
    Friend WithEvents btnAddClef As Button
    Friend WithEvents btnAddTrousseau As Button
End Class
