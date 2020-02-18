<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditerPosition
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPBatiment = New System.Windows.Forms.Label()
        Me.dgvListBatiment = New System.Windows.Forms.DataGridView()
        Me.btnAddPersonne = New System.Windows.Forms.Button()
        Me.cmbResponsable = New System.Windows.Forms.ComboBox()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.lblPResponsable = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(237, 325)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 32)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPBatiment)
        Me.GroupBox2.Controls.Add(Me.dgvListBatiment)
        Me.GroupBox2.Controls.Add(Me.btnAddPersonne)
        Me.GroupBox2.Controls.Add(Me.cmbResponsable)
        Me.GroupBox2.Controls.Add(Me.lblPNom)
        Me.GroupBox2.Controls.Add(Me.lblPResponsable)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 307)
        Me.GroupBox2.TabIndex = 69
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
        'cmbResponsable
        '
        Me.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResponsable.FormattingEnabled = True
        Me.cmbResponsable.Location = New System.Drawing.Point(9, 33)
        Me.cmbResponsable.Name = "cmbResponsable"
        Me.cmbResponsable.Size = New System.Drawing.Size(234, 21)
        Me.cmbResponsable.TabIndex = 57
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
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 325)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(219, 32)
        Me.btnSave.TabIndex = 68
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEditerPosition
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(373, 364)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditerPosition"
        Me.ShowIcon = False
        Me.Text = "Editer un tableau..."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListBatiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPBatiment As Label
    Friend WithEvents dgvListBatiment As DataGridView
    Friend WithEvents btnAddPersonne As Button
    Friend WithEvents cmbResponsable As ComboBox
    Friend WithEvents lblPNom As Label
    Friend WithEvents lblPResponsable As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnSave As Button
End Class
