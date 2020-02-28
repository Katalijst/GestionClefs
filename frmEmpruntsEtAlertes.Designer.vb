<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpruntsEtAlertes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpruntsEtAlertes))
        Me.dgvAlertes = New System.Windows.Forms.DataGridView()
        Me.menuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRechercherAlertes = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbRechercher = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblAlertes = New MaterialSkin.Controls.MaterialLabel()
        Me.chkAlertPopUp = New MaterialSkin.Controls.MaterialSwitch()
        Me.TabCtrlAlertesPerduesEmprunts = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabEnCours = New System.Windows.Forms.TabPage()
        Me.MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        Me.dgvEmpruntsEnCours = New System.Windows.Forms.DataGridView()
        Me.MaterialComboBox2 = New MaterialSkin.Controls.MaterialComboBox()
        Me.tabPerdues = New System.Windows.Forms.TabPage()
        Me.MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        Me.dgvClefsPerdues = New System.Windows.Forms.DataGridView()
        Me.MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.tabAlertes = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuGrid.SuspendLayout()
        Me.TabCtrlAlertesPerduesEmprunts.SuspendLayout()
        Me.tabEnCours.SuspendLayout()
        CType(Me.dgvEmpruntsEnCours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPerdues.SuspendLayout()
        CType(Me.dgvClefsPerdues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlertes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlertes
        '
        Me.dgvAlertes.AllowUserToAddRows = False
        Me.dgvAlertes.AllowUserToDeleteRows = False
        Me.dgvAlertes.AllowUserToResizeRows = False
        Me.dgvAlertes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlertes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAlertes.Location = New System.Drawing.Point(7, 55)
        Me.dgvAlertes.MultiSelect = False
        Me.dgvAlertes.Name = "dgvAlertes"
        Me.dgvAlertes.ReadOnly = True
        Me.dgvAlertes.RowHeadersVisible = False
        Me.dgvAlertes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertes.Size = New System.Drawing.Size(802, 341)
        Me.dgvAlertes.TabIndex = 1
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
        'txtRechercherAlertes
        '
        Me.txtRechercherAlertes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRechercherAlertes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercherAlertes.Depth = 0
        Me.txtRechercherAlertes.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercherAlertes.Hint = "Rechercher..."
        Me.txtRechercherAlertes.Location = New System.Drawing.Point(7, -4)
        Me.txtRechercherAlertes.MaxLength = 50
        Me.txtRechercherAlertes.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercherAlertes.Multiline = False
        Me.txtRechercherAlertes.Name = "txtRechercherAlertes"
        Me.txtRechercherAlertes.Size = New System.Drawing.Size(347, 36)
        Me.txtRechercherAlertes.TabIndex = 2
        Me.txtRechercherAlertes.Text = ""
        Me.txtRechercherAlertes.UseTallSize = False
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
        Me.cbRechercher.Location = New System.Drawing.Point(360, -4)
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
        Me.lblAlertes.Location = New System.Drawing.Point(7, 35)
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
        Me.chkAlertPopUp.Location = New System.Drawing.Point(544, -4)
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
        'TabCtrlAlertesPerduesEmprunts
        '
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabEnCours)
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabPerdues)
        Me.TabCtrlAlertesPerduesEmprunts.Controls.Add(Me.tabAlertes)
        Me.TabCtrlAlertesPerduesEmprunts.Depth = 0
        Me.TabCtrlAlertesPerduesEmprunts.Location = New System.Drawing.Point(1, 68)
        Me.TabCtrlAlertesPerduesEmprunts.Margin = New System.Windows.Forms.Padding(2)
        Me.TabCtrlAlertesPerduesEmprunts.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabCtrlAlertesPerduesEmprunts.Name = "TabCtrlAlertesPerduesEmprunts"
        Me.TabCtrlAlertesPerduesEmprunts.Padding = New System.Drawing.Point(0, 0)
        Me.TabCtrlAlertesPerduesEmprunts.SelectedIndex = 0
        Me.TabCtrlAlertesPerduesEmprunts.Size = New System.Drawing.Size(823, 424)
        Me.TabCtrlAlertesPerduesEmprunts.TabIndex = 16
        '
        'tabEnCours
        '
        Me.tabEnCours.Controls.Add(Me.MaterialTextBox2)
        Me.tabEnCours.Controls.Add(Me.dgvEmpruntsEnCours)
        Me.tabEnCours.Controls.Add(Me.MaterialComboBox2)
        Me.tabEnCours.Location = New System.Drawing.Point(4, 22)
        Me.tabEnCours.Name = "tabEnCours"
        Me.tabEnCours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnCours.Size = New System.Drawing.Size(815, 398)
        Me.tabEnCours.TabIndex = 2
        Me.tabEnCours.Text = "En cours"
        Me.tabEnCours.UseVisualStyleBackColor = True
        '
        'MaterialTextBox2
        '
        Me.MaterialTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox2.Depth = 0
        Me.MaterialTextBox2.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialTextBox2.Hint = "Rechercher..."
        Me.MaterialTextBox2.Location = New System.Drawing.Point(7, -4)
        Me.MaterialTextBox2.MaxLength = 50
        Me.MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox2.Multiline = False
        Me.MaterialTextBox2.Name = "MaterialTextBox2"
        Me.MaterialTextBox2.Size = New System.Drawing.Size(347, 36)
        Me.MaterialTextBox2.TabIndex = 17
        Me.MaterialTextBox2.Text = ""
        Me.MaterialTextBox2.UseTallSize = False
        '
        'dgvEmpruntsEnCours
        '
        Me.dgvEmpruntsEnCours.AllowUserToAddRows = False
        Me.dgvEmpruntsEnCours.AllowUserToDeleteRows = False
        Me.dgvEmpruntsEnCours.AllowUserToResizeRows = False
        Me.dgvEmpruntsEnCours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvEmpruntsEnCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpruntsEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpruntsEnCours.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmpruntsEnCours.Location = New System.Drawing.Point(7, 55)
        Me.dgvEmpruntsEnCours.MultiSelect = False
        Me.dgvEmpruntsEnCours.Name = "dgvEmpruntsEnCours"
        Me.dgvEmpruntsEnCours.ReadOnly = True
        Me.dgvEmpruntsEnCours.RowHeadersVisible = False
        Me.dgvEmpruntsEnCours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEmpruntsEnCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpruntsEnCours.Size = New System.Drawing.Size(802, 341)
        Me.dgvEmpruntsEnCours.TabIndex = 16
        '
        'MaterialComboBox2
        '
        Me.MaterialComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialComboBox2.AutoResize = False
        Me.MaterialComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBox2.Depth = 0
        Me.MaterialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBox2.DropDownHeight = 118
        Me.MaterialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox2.DropDownWidth = 121
        Me.MaterialComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBox2.FormattingEnabled = True
        Me.MaterialComboBox2.Hint = "Type de recherche"
        Me.MaterialComboBox2.IntegralHeight = False
        Me.MaterialComboBox2.ItemHeight = 29
        Me.MaterialComboBox2.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.MaterialComboBox2.Location = New System.Drawing.Point(360, -4)
        Me.MaterialComboBox2.MaxDropDownItems = 4
        Me.MaterialComboBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox2.Name = "MaterialComboBox2"
        Me.MaterialComboBox2.Size = New System.Drawing.Size(181, 35)
        Me.MaterialComboBox2.TabIndex = 18
        Me.MaterialComboBox2.UseTallSize = False
        '
        'tabPerdues
        '
        Me.tabPerdues.Controls.Add(Me.MaterialTextBox1)
        Me.tabPerdues.Controls.Add(Me.dgvClefsPerdues)
        Me.tabPerdues.Controls.Add(Me.MaterialComboBox1)
        Me.tabPerdues.Location = New System.Drawing.Point(4, 22)
        Me.tabPerdues.Name = "tabPerdues"
        Me.tabPerdues.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPerdues.Size = New System.Drawing.Size(815, 398)
        Me.tabPerdues.TabIndex = 1
        Me.tabPerdues.Text = "Clefs Perdues"
        Me.tabPerdues.UseVisualStyleBackColor = True
        '
        'MaterialTextBox1
        '
        Me.MaterialTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox1.Depth = 0
        Me.MaterialTextBox1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialTextBox1.Hint = "Rechercher..."
        Me.MaterialTextBox1.Location = New System.Drawing.Point(7, -4)
        Me.MaterialTextBox1.MaxLength = 50
        Me.MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox1.Multiline = False
        Me.MaterialTextBox1.Name = "MaterialTextBox1"
        Me.MaterialTextBox1.Size = New System.Drawing.Size(347, 36)
        Me.MaterialTextBox1.TabIndex = 17
        Me.MaterialTextBox1.Text = ""
        Me.MaterialTextBox1.UseTallSize = False
        '
        'dgvClefsPerdues
        '
        Me.dgvClefsPerdues.AllowUserToAddRows = False
        Me.dgvClefsPerdues.AllowUserToDeleteRows = False
        Me.dgvClefsPerdues.AllowUserToResizeRows = False
        Me.dgvClefsPerdues.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvClefsPerdues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClefsPerdues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClefsPerdues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClefsPerdues.Location = New System.Drawing.Point(7, 55)
        Me.dgvClefsPerdues.MultiSelect = False
        Me.dgvClefsPerdues.Name = "dgvClefsPerdues"
        Me.dgvClefsPerdues.ReadOnly = True
        Me.dgvClefsPerdues.RowHeadersVisible = False
        Me.dgvClefsPerdues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClefsPerdues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClefsPerdues.Size = New System.Drawing.Size(802, 341)
        Me.dgvClefsPerdues.TabIndex = 16
        '
        'MaterialComboBox1
        '
        Me.MaterialComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialComboBox1.AutoResize = False
        Me.MaterialComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBox1.Depth = 0
        Me.MaterialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBox1.DropDownHeight = 118
        Me.MaterialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox1.DropDownWidth = 121
        Me.MaterialComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBox1.FormattingEnabled = True
        Me.MaterialComboBox1.Hint = "Type de recherche"
        Me.MaterialComboBox1.IntegralHeight = False
        Me.MaterialComboBox1.ItemHeight = 29
        Me.MaterialComboBox1.Items.AddRange(New Object() {"ID", "Nom", "Emprunteur", "Lieu"})
        Me.MaterialComboBox1.Location = New System.Drawing.Point(360, -4)
        Me.MaterialComboBox1.MaxDropDownItems = 4
        Me.MaterialComboBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox1.Name = "MaterialComboBox1"
        Me.MaterialComboBox1.Size = New System.Drawing.Size(181, 35)
        Me.MaterialComboBox1.TabIndex = 18
        Me.MaterialComboBox1.UseTallSize = False
        '
        'tabAlertes
        '
        Me.tabAlertes.Controls.Add(Me.txtRechercherAlertes)
        Me.tabAlertes.Controls.Add(Me.dgvAlertes)
        Me.tabAlertes.Controls.Add(Me.chkAlertPopUp)
        Me.tabAlertes.Controls.Add(Me.cbRechercher)
        Me.tabAlertes.Controls.Add(Me.lblAlertes)
        Me.tabAlertes.Location = New System.Drawing.Point(4, 22)
        Me.tabAlertes.Name = "tabAlertes"
        Me.tabAlertes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlertes.Size = New System.Drawing.Size(815, 398)
        Me.tabAlertes.TabIndex = 0
        Me.tabAlertes.Text = "Alertes"
        Me.tabAlertes.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.TabCtrlAlertesPerduesEmprunts
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(209, 26)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(378, 38)
        Me.MaterialTabSelector1.TabIndex = 17
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'frmEmpruntsEtAlertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 497)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.TabCtrlAlertesPerduesEmprunts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpruntsEtAlertes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Emprunts et alertes"
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuGrid.ResumeLayout(False)
        Me.TabCtrlAlertesPerduesEmprunts.ResumeLayout(False)
        Me.tabEnCours.ResumeLayout(False)
        CType(Me.dgvEmpruntsEnCours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPerdues.ResumeLayout(False)
        CType(Me.dgvClefsPerdues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlertes.ResumeLayout(False)
        Me.tabAlertes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAlertes As DataGridView
    Friend WithEvents menuGrid As ContextMenuStrip
    Friend WithEvents RetourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtRechercherAlertes As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbRechercher As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblAlertes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkAlertPopUp As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents TabCtrlAlertesPerduesEmprunts As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabAlertes As TabPage
    Friend WithEvents tabPerdues As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabEnCours As TabPage
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dgvEmpruntsEnCours As DataGridView
    Friend WithEvents MaterialComboBox2 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dgvClefsPerdues As DataGridView
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
End Class
