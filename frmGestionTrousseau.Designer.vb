<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionTrousseau
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbListeClefs = New System.Windows.Forms.GroupBox()
        Me.dgvListClefs = New System.Windows.Forms.DataGridView()
        Me.gbTrousseau = New System.Windows.Forms.GroupBox()
        Me.dgvSelTrousseau = New System.Windows.Forms.DataGridView()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTrousseauAfficher = New System.Windows.Forms.Label()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.cmbTrousseauListe = New System.Windows.Forms.ComboBox()
        Me.btnSupprimerTrousseau = New System.Windows.Forms.Button()
        Me.btnCreerTrousseau = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkKeepOpen = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pbRemSelBatiment = New System.Windows.Forms.PictureBox()
        Me.pbAddSelBatiment = New System.Windows.Forms.PictureBox()
        Me.gbListeClefs.SuspendLayout()
        CType(Me.dgvListClefs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTrousseau.SuspendLayout()
        CType(Me.dgvSelTrousseau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbRemSelBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddSelBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbListeClefs
        '
        Me.gbListeClefs.Controls.Add(Me.dgvListClefs)
        Me.gbListeClefs.Location = New System.Drawing.Point(3, 99)
        Me.gbListeClefs.Name = "gbListeClefs"
        Me.gbListeClefs.Size = New System.Drawing.Size(364, 328)
        Me.gbListeClefs.TabIndex = 17
        Me.gbListeClefs.TabStop = False
        Me.gbListeClefs.Text = "Liste des clefs"
        '
        'dgvListClefs
        '
        Me.dgvListClefs.AllowUserToAddRows = False
        Me.dgvListClefs.AllowUserToDeleteRows = False
        Me.dgvListClefs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListClefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListClefs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListClefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListClefs.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListClefs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListClefs.Location = New System.Drawing.Point(6, 19)
        Me.dgvListClefs.MultiSelect = False
        Me.dgvListClefs.Name = "dgvListClefs"
        Me.dgvListClefs.ReadOnly = True
        Me.dgvListClefs.RowHeadersVisible = False
        Me.dgvListClefs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListClefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListClefs.Size = New System.Drawing.Size(352, 299)
        Me.dgvListClefs.TabIndex = 49
        '
        'gbTrousseau
        '
        Me.gbTrousseau.Controls.Add(Me.dgvSelTrousseau)
        Me.gbTrousseau.Location = New System.Drawing.Point(421, 99)
        Me.gbTrousseau.Name = "gbTrousseau"
        Me.gbTrousseau.Size = New System.Drawing.Size(355, 328)
        Me.gbTrousseau.TabIndex = 18
        Me.gbTrousseau.TabStop = False
        Me.gbTrousseau.Text = "Trousseau"
        '
        'dgvSelTrousseau
        '
        Me.dgvSelTrousseau.AllowUserToAddRows = False
        Me.dgvSelTrousseau.AllowUserToDeleteRows = False
        Me.dgvSelTrousseau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSelTrousseau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelTrousseau.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSelTrousseau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelTrousseau.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSelTrousseau.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSelTrousseau.Location = New System.Drawing.Point(6, 19)
        Me.dgvSelTrousseau.MultiSelect = False
        Me.dgvSelTrousseau.Name = "dgvSelTrousseau"
        Me.dgvSelTrousseau.ReadOnly = True
        Me.dgvSelTrousseau.RowHeadersVisible = False
        Me.dgvSelTrousseau.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSelTrousseau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelTrousseau.Size = New System.Drawing.Size(341, 303)
        Me.dgvSelTrousseau.TabIndex = 50
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(3, 14)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(396, 42)
        Me.gbRechercher.TabIndex = 23
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher une clef"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTrousseauAfficher)
        Me.GroupBox3.Controls.Add(Me.btnAfficher)
        Me.GroupBox3.Controls.Add(Me.cmbTrousseauListe)
        Me.GroupBox3.Controls.Add(Me.btnSupprimerTrousseau)
        Me.GroupBox3.Location = New System.Drawing.Point(405, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 79)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trousseau"
        '
        'lblTrousseauAfficher
        '
        Me.lblTrousseauAfficher.AutoSize = True
        Me.lblTrousseauAfficher.Location = New System.Drawing.Point(7, 48)
        Me.lblTrousseauAfficher.Name = "lblTrousseauAfficher"
        Me.lblTrousseauAfficher.Size = New System.Drawing.Size(104, 13)
        Me.lblTrousseauAfficher.TabIndex = 27
        Me.lblTrousseauAfficher.Text = "Trousseau afficher : "
        '
        'btnAfficher
        '
        Me.btnAfficher.Location = New System.Drawing.Point(235, 19)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(101, 23)
        Me.btnAfficher.TabIndex = 26
        Me.btnAfficher.Text = "Afficher"
        Me.btnAfficher.UseVisualStyleBackColor = True
        '
        'cmbTrousseauListe
        '
        Me.cmbTrousseauListe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTrousseauListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrousseauListe.FormattingEnabled = True
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(6, 19)
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(223, 21)
        Me.cmbTrousseauListe.TabIndex = 23
        '
        'btnSupprimerTrousseau
        '
        Me.btnSupprimerTrousseau.Location = New System.Drawing.Point(235, 47)
        Me.btnSupprimerTrousseau.Name = "btnSupprimerTrousseau"
        Me.btnSupprimerTrousseau.Size = New System.Drawing.Size(101, 23)
        Me.btnSupprimerTrousseau.TabIndex = 25
        Me.btnSupprimerTrousseau.Text = "Supprimer"
        Me.btnSupprimerTrousseau.UseVisualStyleBackColor = True
        '
        'btnCreerTrousseau
        '
        Me.btnCreerTrousseau.Location = New System.Drawing.Point(9, 62)
        Me.btnCreerTrousseau.Name = "btnCreerTrousseau"
        Me.btnCreerTrousseau.Size = New System.Drawing.Size(223, 23)
        Me.btnCreerTrousseau.TabIndex = 24
        Me.btnCreerTrousseau.Text = "Créer un nouveau trousseau"
        Me.btnCreerTrousseau.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(397, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(243, 32)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkKeepOpen
        '
        Me.chkKeepOpen.AutoSize = True
        Me.chkKeepOpen.Location = New System.Drawing.Point(235, 440)
        Me.chkKeepOpen.Name = "chkKeepOpen"
        Me.chkKeepOpen.Size = New System.Drawing.Size(144, 17)
        Me.chkKeepOpen.TabIndex = 51
        Me.chkKeepOpen.Text = "Garder la fenêtre ouverte"
        Me.chkKeepOpen.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(646, 433)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 32)
        Me.btnCancel.TabIndex = 50
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pbRemSelBatiment
        '
        Me.pbRemSelBatiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbRemSelBatiment.Image = Global.GestionClefs.My.Resources.Resources.left_arrow_key
        Me.pbRemSelBatiment.Location = New System.Drawing.Point(373, 273)
        Me.pbRemSelBatiment.Name = "pbRemSelBatiment"
        Me.pbRemSelBatiment.Size = New System.Drawing.Size(42, 42)
        Me.pbRemSelBatiment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRemSelBatiment.TabIndex = 53
        Me.pbRemSelBatiment.TabStop = False
        '
        'pbAddSelBatiment
        '
        Me.pbAddSelBatiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAddSelBatiment.Image = Global.GestionClefs.My.Resources.Resources.keyboard_right_arrow_button
        Me.pbAddSelBatiment.Location = New System.Drawing.Point(373, 222)
        Me.pbAddSelBatiment.Name = "pbAddSelBatiment"
        Me.pbAddSelBatiment.Size = New System.Drawing.Size(42, 42)
        Me.pbAddSelBatiment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddSelBatiment.TabIndex = 52
        Me.pbAddSelBatiment.TabStop = False
        '
        'frmGestionTrousseau
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(780, 471)
        Me.Controls.Add(Me.pbRemSelBatiment)
        Me.Controls.Add(Me.pbAddSelBatiment)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkKeepOpen)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreerTrousseau)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbRechercher)
        Me.Controls.Add(Me.gbTrousseau)
        Me.Controls.Add(Me.gbListeClefs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGestionTrousseau"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestions des trousseaux"
        Me.gbListeClefs.ResumeLayout(False)
        CType(Me.dgvListClefs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTrousseau.ResumeLayout(False)
        CType(Me.dgvSelTrousseau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbRemSelBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddSelBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbListeClefs As GroupBox
    Friend WithEvents gbTrousseau As GroupBox
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSupprimerTrousseau As Button
    Friend WithEvents btnCreerTrousseau As Button
    Friend WithEvents cmbTrousseauListe As ComboBox
    Friend WithEvents btnAfficher As Button
    Friend WithEvents dgvListClefs As DataGridView
    Friend WithEvents dgvSelTrousseau As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents chkKeepOpen As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTrousseauAfficher As Label
    Friend WithEvents pbRemSelBatiment As PictureBox
    Friend WithEvents pbAddSelBatiment As PictureBox
End Class
