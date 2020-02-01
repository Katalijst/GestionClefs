<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmprunterClef
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
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.btnPersonne = New System.Windows.Forms.Button()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.lblAu = New System.Windows.Forms.Label()
        Me.dtpFinEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.lblDu = New System.Windows.Forms.Label()
        Me.dtpDebutEmprunt = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtKeyID = New System.Windows.Forms.TextBox()
        Me.txtKeyName = New System.Windows.Forms.TextBox()
        Me.txtKeyTrousseau = New System.Windows.Forms.TextBox()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.btnPersonne)
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Controls.Add(Me.btnRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(6, 17)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(404, 75)
        Me.gbRechercher.TabIndex = 42
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher un emprunteur"
        '
        'btnPersonne
        '
        Me.btnPersonne.Location = New System.Drawing.Point(77, 43)
        Me.btnPersonne.Name = "btnPersonne"
        Me.btnPersonne.Size = New System.Drawing.Size(169, 23)
        Me.btnPersonne.TabIndex = 44
        Me.btnPersonne.Text = "Ajouter/gérer les emprunteurs..."
        Me.btnPersonne.UseVisualStyleBackColor = True
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
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(252, 43)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(138, 23)
        Me.btnRechercher.TabIndex = 6
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvResultats)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 244)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des emprunteurs"
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
        Me.dgvResultats.Location = New System.Drawing.Point(6, 21)
        Me.dgvResultats.MultiSelect = False
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(616, 217)
        Me.dgvResultats.TabIndex = 45
        '
        'lblAu
        '
        Me.lblAu.AutoSize = True
        Me.lblAu.Location = New System.Drawing.Point(416, 56)
        Me.lblAu.Name = "lblAu"
        Me.lblAu.Size = New System.Drawing.Size(20, 13)
        Me.lblAu.TabIndex = 48
        Me.lblAu.Text = "Au"
        '
        'dtpFinEmprunt
        '
        Me.dtpFinEmprunt.Location = New System.Drawing.Point(419, 72)
        Me.dtpFinEmprunt.Name = "dtpFinEmprunt"
        Me.dtpFinEmprunt.Size = New System.Drawing.Size(209, 20)
        Me.dtpFinEmprunt.TabIndex = 47
        '
        'lblDu
        '
        Me.lblDu.AutoSize = True
        Me.lblDu.Location = New System.Drawing.Point(416, 17)
        Me.lblDu.Name = "lblDu"
        Me.lblDu.Size = New System.Drawing.Size(70, 13)
        Me.lblDu.TabIndex = 46
        Me.lblDu.Text = "Emprunter du"
        '
        'dtpDebutEmprunt
        '
        Me.dtpDebutEmprunt.Location = New System.Drawing.Point(419, 33)
        Me.dtpDebutEmprunt.Name = "dtpDebutEmprunt"
        Me.dtpDebutEmprunt.Size = New System.Drawing.Size(209, 20)
        Me.dtpDebutEmprunt.TabIndex = 45
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.lblAu)
        Me.GroupBox3.Controls.Add(Me.gbRechercher)
        Me.GroupBox3.Controls.Add(Me.lblDu)
        Me.GroupBox3.Controls.Add(Me.dtpDebutEmprunt)
        Me.GroupBox3.Controls.Add(Me.dtpFinEmprunt)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 348)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Emprunteur"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(285, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(219, 45)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Emprunter/Attribuer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(510, 366)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 45)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtKeyID
        '
        Me.txtKeyID.Enabled = False
        Me.txtKeyID.Location = New System.Drawing.Point(12, 366)
        Me.txtKeyID.Name = "txtKeyID"
        Me.txtKeyID.Size = New System.Drawing.Size(77, 20)
        Me.txtKeyID.TabIndex = 49
        Me.txtKeyID.Text = "ID"
        '
        'txtKeyName
        '
        Me.txtKeyName.Enabled = False
        Me.txtKeyName.Location = New System.Drawing.Point(95, 366)
        Me.txtKeyName.Name = "txtKeyName"
        Me.txtKeyName.Size = New System.Drawing.Size(174, 20)
        Me.txtKeyName.TabIndex = 50
        Me.txtKeyName.Text = "Clef"
        '
        'txtKeyTrousseau
        '
        Me.txtKeyTrousseau.Enabled = False
        Me.txtKeyTrousseau.Location = New System.Drawing.Point(12, 392)
        Me.txtKeyTrousseau.Name = "txtKeyTrousseau"
        Me.txtKeyTrousseau.Size = New System.Drawing.Size(174, 20)
        Me.txtKeyTrousseau.TabIndex = 51
        Me.txtKeyTrousseau.Text = "Aucun trousseau"
        '
        'frmEmprunterClef
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(670, 423)
        Me.Controls.Add(Me.txtKeyTrousseau)
        Me.Controls.Add(Me.txtKeyName)
        Me.Controls.Add(Me.txtKeyID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmprunterClef"
        Me.Text = "Emprunter une clef..."
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents btnPersonne As Button
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents btnRechercher As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents lblAu As Label
    Friend WithEvents dtpFinEmprunt As DateTimePicker
    Friend WithEvents lblDu As Label
    Friend WithEvents dtpDebutEmprunt As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtKeyID As TextBox
    Friend WithEvents txtKeyName As TextBox
    Friend WithEvents txtKeyTrousseau As TextBox
End Class
