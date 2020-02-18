<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertes
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
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.gbRechercher = New System.Windows.Forms.GroupBox()
        Me.chkAlertPopUp = New System.Windows.Forms.CheckBox()
        Me.cbRechercher = New System.Windows.Forms.ComboBox()
        Me.lblAlertes = New System.Windows.Forms.Label()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.menuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRechercher.SuspendLayout()
        Me.menuGrid.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(11, 86)
        Me.dgvResultats.MultiSelect = False
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(777, 352)
        Me.dgvResultats.TabIndex = 11
        '
        'gbRechercher
        '
        Me.gbRechercher.Controls.Add(Me.chkAlertPopUp)
        Me.gbRechercher.Controls.Add(Me.cbRechercher)
        Me.gbRechercher.Controls.Add(Me.lblAlertes)
        Me.gbRechercher.Controls.Add(Me.txtRechercher)
        Me.gbRechercher.Location = New System.Drawing.Point(11, 12)
        Me.gbRechercher.Name = "gbRechercher"
        Me.gbRechercher.Size = New System.Drawing.Size(569, 68)
        Me.gbRechercher.TabIndex = 12
        Me.gbRechercher.TabStop = False
        Me.gbRechercher.Text = "Rechercher"
        '
        'chkAlertPopUp
        '
        Me.chkAlertPopUp.AutoSize = True
        Me.chkAlertPopUp.Location = New System.Drawing.Point(381, 45)
        Me.chkAlertPopUp.Name = "chkAlertPopUp"
        Me.chkAlertPopUp.Size = New System.Drawing.Size(165, 17)
        Me.chkAlertPopUp.TabIndex = 13
        Me.chkAlertPopUp.Text = "Pop-up d'alerte au démarrage"
        Me.chkAlertPopUp.UseVisualStyleBackColor = True
        '
        'cbRechercher
        '
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(381, 19)
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(175, 21)
        Me.cbRechercher.TabIndex = 13
        '
        'lblAlertes
        '
        Me.lblAlertes.AutoSize = True
        Me.lblAlertes.Location = New System.Drawing.Point(6, 42)
        Me.lblAlertes.Name = "lblAlertes"
        Me.lblAlertes.Size = New System.Drawing.Size(107, 13)
        Me.lblAlertes.TabIndex = 3
        Me.lblAlertes.Text = "X clefs non rendues !"
        '
        'txtRechercher
        '
        Me.txtRechercher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRechercher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRechercher.Location = New System.Drawing.Point(6, 19)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(369, 20)
        Me.txtRechercher.TabIndex = 0
        '
        'menuGrid
        '
        Me.menuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourToolStripMenuItem, Me.PropriétésToolStripMenuItem})
        Me.menuGrid.Name = "menuGrid"
        Me.menuGrid.Size = New System.Drawing.Size(128, 48)
        '
        'RetourToolStripMenuItem
        '
        Me.RetourToolStripMenuItem.Name = "RetourToolStripMenuItem"
        Me.RetourToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RetourToolStripMenuItem.Text = "Retour..."
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        Me.PropriétésToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PropriétésToolStripMenuItem.Text = "Propriétés"
        '
        'frmAlertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbRechercher)
        Me.Controls.Add(Me.dgvResultats)
        Me.Name = "frmAlertes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Alertes"
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRechercher.ResumeLayout(False)
        Me.gbRechercher.PerformLayout()
        Me.menuGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents gbRechercher As GroupBox
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents lblAlertes As Label
    Friend WithEvents menuGrid As ContextMenuStrip
    Friend WithEvents RetourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbRechercher As ComboBox
    Friend WithEvents chkAlertPopUp As CheckBox
End Class
