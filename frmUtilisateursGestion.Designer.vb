<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilisateursGestion
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateursGestion))
        Me.dgvListUser = New System.Windows.Forms.DataGridView()
        Me.MenuListe = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangerLeTypeDutilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefDeServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangerLeServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéinitialiserLeMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuListe.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListUser.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListUser.Location = New System.Drawing.Point(12, 121)
        Me.dgvListUser.MultiSelect = False
        Me.dgvListUser.Name = "dgvListUser"
        Me.dgvListUser.ReadOnly = True
        Me.dgvListUser.RowHeadersVisible = False
        Me.dgvListUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListUser.Size = New System.Drawing.Size(316, 271)
        Me.dgvListUser.TabIndex = 45
        '
        'MenuListe
        '
        Me.MenuListe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangerLeTypeDutilisateurToolStripMenuItem, Me.ChangerLeServiceToolStripMenuItem, Me.RéinitialiserLeMotDePasseToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.MenuListe.Name = "MenuListe"
        Me.MenuListe.Size = New System.Drawing.Size(223, 114)
        '
        'ChangerLeTypeDutilisateurToolStripMenuItem
        '
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilisateurToolStripMenuItem, Me.ChefDeServiceToolStripMenuItem, Me.AdministrateurToolStripMenuItem})
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Name = "ChangerLeTypeDutilisateurToolStripMenuItem"
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ChangerLeTypeDutilisateurToolStripMenuItem.Text = "Changer le type d'utilisateur"
        '
        'UtilisateurToolStripMenuItem
        '
        Me.UtilisateurToolStripMenuItem.Name = "UtilisateurToolStripMenuItem"
        Me.UtilisateurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UtilisateurToolStripMenuItem.Text = "Utilisateur"
        '
        'ChefDeServiceToolStripMenuItem
        '
        Me.ChefDeServiceToolStripMenuItem.Name = "ChefDeServiceToolStripMenuItem"
        Me.ChefDeServiceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChefDeServiceToolStripMenuItem.Text = "Chef de service"
        '
        'AdministrateurToolStripMenuItem
        '
        Me.AdministrateurToolStripMenuItem.Name = "AdministrateurToolStripMenuItem"
        Me.AdministrateurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdministrateurToolStripMenuItem.Text = "Administrateur"
        '
        'ChangerLeServiceToolStripMenuItem
        '
        Me.ChangerLeServiceToolStripMenuItem.Name = "ChangerLeServiceToolStripMenuItem"
        Me.ChangerLeServiceToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ChangerLeServiceToolStripMenuItem.Text = "Changer le service"
        '
        'RéinitialiserLeMotDePasseToolStripMenuItem
        '
        Me.RéinitialiserLeMotDePasseToolStripMenuItem.Name = "RéinitialiserLeMotDePasseToolStripMenuItem"
        Me.RéinitialiserLeMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.RéinitialiserLeMotDePasseToolStripMenuItem.Text = "Réinitialiser le mot de passe"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'txtRechercher
        '
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(12, 79)
        Me.txtRechercher.MaxLength = 50
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(263, 36)
        Me.txtRechercher.TabIndex = 46
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.DrawShadows = True
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Global.GestionClefs.My.Resources.Resources.add_user_button
        Me.MaterialButton1.Location = New System.Drawing.Point(282, 79)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.Size = New System.Drawing.Size(44, 36)
        Me.MaterialButton1.TabIndex = 47
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'frmUtilisateursGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 404)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.dgvListUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateursGestion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des utilisateurs..."
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuListe.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListUser As DataGridView
    Friend WithEvents MenuListe As ContextMenuStrip
    Friend WithEvents ChangerLeTypeDutilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents RéinitialiserLeMotDePasseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangerLeServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefDeServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrateurToolStripMenuItem As ToolStripMenuItem
End Class
