<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertes
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
        Me.dgvResultats = New System.Windows.Forms.DataGridView()
        Me.menuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbRechercher = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblAlertes = New MaterialSkin.Controls.MaterialLabel()
        Me.chkAlertPopUp = New MaterialSkin.Controls.MaterialSwitch()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabEmprunts = New System.Windows.Forms.TabPage()
        Me.tabPerdues = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuGrid.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.tabEmprunts.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResultats
        '
        Me.dgvResultats.AllowUserToAddRows = False
        Me.dgvResultats.AllowUserToDeleteRows = False
        Me.dgvResultats.AllowUserToResizeRows = False
        Me.dgvResultats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvResultats.Location = New System.Drawing.Point(7, 54)
        Me.dgvResultats.MultiSelect = False
        Me.dgvResultats.Name = "dgvResultats"
        Me.dgvResultats.ReadOnly = True
        Me.dgvResultats.RowHeadersVisible = False
        Me.dgvResultats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultats.Size = New System.Drawing.Size(802, 341)
        Me.dgvResultats.TabIndex = 1
        '
        'menuGrid
        '
        Me.menuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetourToolStripMenuItem, Me.PropriétésToolStripMenuItem})
        Me.menuGrid.Name = "menuGrid"
        Me.menuGrid.Size = New System.Drawing.Size(146, 48)
        '
        'RetourToolStripMenuItem
        '
        Me.RetourToolStripMenuItem.Name = "RetourToolStripMenuItem"
        Me.RetourToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RetourToolStripMenuItem.Text = "Rendre la clef"
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        Me.PropriétésToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PropriétésToolStripMenuItem.Text = "Informations"
        '
        'txtRechercher
        '
        Me.txtRechercher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher..."
        Me.txtRechercher.Location = New System.Drawing.Point(7, -5)
        Me.txtRechercher.MaxLength = 50
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(347, 36)
        Me.txtRechercher.TabIndex = 2
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'cbRechercher
        '
        Me.cbRechercher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRechercher.AutoResize = False
        Me.cbRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRechercher.Depth = 0
        Me.cbRechercher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbRechercher.DropDownHeight = 118
        Me.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercher.DropDownWidth = 121
        Me.cbRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbRechercher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbRechercher.FormattingEnabled = True
        Me.cbRechercher.Hint = "Type de recherche"
        Me.cbRechercher.IntegralHeight = False
        Me.cbRechercher.ItemHeight = 29
        Me.cbRechercher.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.cbRechercher.Location = New System.Drawing.Point(360, -5)
        Me.cbRechercher.MaxDropDownItems = 4
        Me.cbRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.cbRechercher.Name = "cbRechercher"
        Me.cbRechercher.Size = New System.Drawing.Size(181, 35)
        Me.cbRechercher.TabIndex = 3
        Me.cbRechercher.UseTallSize = False
        '
        'lblAlertes
        '
        Me.lblAlertes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAlertes.AutoSize = True
        Me.lblAlertes.Depth = 0
        Me.lblAlertes.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAlertes.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lblAlertes.Location = New System.Drawing.Point(7, 34)
        Me.lblAlertes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAlertes.Name = "lblAlertes"
        Me.lblAlertes.Size = New System.Drawing.Size(129, 17)
        Me.lblAlertes.TabIndex = 15
        Me.lblAlertes.Text = "X clefs non rendues !"
        '
        'chkAlertPopUp
        '
        Me.chkAlertPopUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAlertPopUp.AutoSize = True
        Me.chkAlertPopUp.Depth = 0
        Me.chkAlertPopUp.Location = New System.Drawing.Point(544, -5)
        Me.chkAlertPopUp.Margin = New System.Windows.Forms.Padding(0)
        Me.chkAlertPopUp.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkAlertPopUp.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkAlertPopUp.Name = "chkAlertPopUp"
        Me.chkAlertPopUp.Ripple = True
        Me.chkAlertPopUp.Size = New System.Drawing.Size(265, 37)
        Me.chkAlertPopUp.TabIndex = 4
        Me.chkAlertPopUp.Text = "Pop-up d'alerte au démarrage"
        Me.chkAlertPopUp.UseVisualStyleBackColor = True
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.tabEmprunts)
        Me.MaterialTabControl1.Controls.Add(Me.tabPerdues)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(1, 68)
        Me.MaterialTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(823, 424)
        Me.MaterialTabControl1.TabIndex = 16
        '
        'tabEmprunts
        '
        Me.tabEmprunts.Controls.Add(Me.txtRechercher)
        Me.tabEmprunts.Controls.Add(Me.dgvResultats)
        Me.tabEmprunts.Controls.Add(Me.chkAlertPopUp)
        Me.tabEmprunts.Controls.Add(Me.cbRechercher)
        Me.tabEmprunts.Controls.Add(Me.lblAlertes)
        Me.tabEmprunts.Location = New System.Drawing.Point(4, 22)
        Me.tabEmprunts.Name = "tabEmprunts"
        Me.tabEmprunts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmprunts.Size = New System.Drawing.Size(815, 398)
        Me.tabEmprunts.TabIndex = 0
        Me.tabEmprunts.Text = "Emprunts"
        Me.tabEmprunts.UseVisualStyleBackColor = True
        '
        'tabPerdues
        '
        Me.tabPerdues.Location = New System.Drawing.Point(4, 22)
        Me.tabPerdues.Name = "tabPerdues"
        Me.tabPerdues.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPerdues.Size = New System.Drawing.Size(805, 423)
        Me.tabPerdues.TabIndex = 1
        Me.tabPerdues.Text = "Clefs Perdues"
        Me.tabPerdues.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(147, 25)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(312, 38)
        Me.MaterialTabSelector1.TabIndex = 17
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'frmAlertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 497)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "frmAlertes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Alertes"
        CType(Me.dgvResultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuGrid.ResumeLayout(False)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.tabEmprunts.ResumeLayout(False)
        Me.tabEmprunts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResultats As DataGridView
    Friend WithEvents menuGrid As ContextMenuStrip
    Friend WithEvents RetourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbRechercher As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblAlertes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkAlertPopUp As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabEmprunts As TabPage
    Friend WithEvents tabPerdues As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
End Class
