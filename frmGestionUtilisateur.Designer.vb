<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUtilisateur
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListUser = New System.Windows.Forms.DataGridView()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.MenuListe = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangerLeTypeDutilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuListe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListUser)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 298)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des utilisateurs"
        '
        'dgvListUser
        '
        Me.dgvListUser.AllowUserToAddRows = False
        Me.dgvListUser.AllowUserToDeleteRows = False
        Me.dgvListUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListUser.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListUser.Location = New System.Drawing.Point(6, 21)
        Me.dgvListUser.MultiSelect = False
        Me.dgvListUser.Name = "dgvListUser"
        Me.dgvListUser.ReadOnly = True
        Me.dgvListUser.RowHeadersVisible = False
        Me.dgvListUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListUser.Size = New System.Drawing.Size(316, 271)
        Me.dgvListUser.TabIndex = 45
        '
        'txtRechercher
        '
        Me.txtRechercher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRechercher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRechercher.Location = New System.Drawing.Point(12, 72)
        Me.txtRechercher.MaxLength = 255
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(316, 20)
        Me.txtRechercher.TabIndex = 0
        '
        'MenuListe
        '
        Me.MenuListe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangerLeTypeDutilisateurToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.MenuListe.Name = "MenuListe"
        Me.MenuListe.Size = New System.Drawing.Size(223, 48)
        '
        'ChangerLeTypeDutilisateurToolStripMenuItem
        '
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Name = "ChangerLeTypeDutilisateurToolStripMenuItem"
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Text = "Changer le type d'utilisateur"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'frmGestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 404)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionUtilisateur"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Gestion des utilisateurs..."
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuListe.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListUser As DataGridView
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents MenuListe As ContextMenuStrip
    Friend WithEvents ChangerLeTypeDutilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
End Class
