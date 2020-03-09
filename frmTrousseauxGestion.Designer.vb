<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTrousseauxGestion
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrousseauxGestion))
        Me.cbTrousseaux = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvClefs = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetirerDuTrousseauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.btnCreerTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.btnRetirerClefsTrousseau = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClefs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTrousseaux
        '
        Me.cbTrousseaux.AutoResize = False
        Me.cbTrousseaux.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTrousseaux.Depth = 0
        Me.cbTrousseaux.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbTrousseaux.DropDownHeight = 118
        Me.cbTrousseaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrousseaux.DropDownWidth = 121
        Me.cbTrousseaux.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbTrousseaux.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbTrousseaux.FormattingEnabled = True
        Me.cbTrousseaux.Hint = "Trousseaux"
        Me.cbTrousseaux.IntegralHeight = False
        Me.cbTrousseaux.ItemHeight = 29
        Me.cbTrousseaux.Location = New System.Drawing.Point(12, 72)
        Me.cbTrousseaux.MaxDropDownItems = 4
        Me.cbTrousseaux.MouseState = MaterialSkin.MouseState.OUT
        Me.cbTrousseaux.Name = "cbTrousseaux"
        Me.cbTrousseaux.Size = New System.Drawing.Size(352, 35)
        Me.cbTrousseaux.TabIndex = 0
        Me.cbTrousseaux.UseTallSize = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.PictureBox1)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(61, 473)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(352, 67)
        Me.MaterialCard1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GestionClefs.My.Resources.Resources.key_1_
        Me.PictureBox1.Location = New System.Drawing.Point(279, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 14)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(318, 45)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Pour créer ou remplir un trousseau, remplisser votre panier et cliquer sur"
        '
        'dgvClefs
        '
        Me.dgvClefs.AllowUserToAddRows = False
        Me.dgvClefs.AllowUserToDeleteRows = False
        Me.dgvClefs.AllowUserToOrderColumns = True
        Me.dgvClefs.AllowUserToResizeRows = False
        Me.dgvClefs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClefs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvClefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClefs.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClefs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClefs.Location = New System.Drawing.Point(12, 113)
        Me.dgvClefs.Name = "dgvClefs"
        Me.dgvClefs.ReadOnly = True
        Me.dgvClefs.RowHeadersVisible = False
        Me.dgvClefs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClefs.Size = New System.Drawing.Size(451, 307)
        Me.dgvClefs.TabIndex = 147
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetirerDuTrousseauToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 26)
        '
        'RetirerDuTrousseauToolStripMenuItem
        '
        Me.RetirerDuTrousseauToolStripMenuItem.Name = "RetirerDuTrousseauToolStripMenuItem"
        Me.RetirerDuTrousseauToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RetirerDuTrousseauToolStripMenuItem.Text = "Retirer du trousseau"
        '
        'btnDeleteTrousseau
        '
        Me.btnDeleteTrousseau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteTrousseau.Depth = 0
        Me.btnDeleteTrousseau.DrawShadows = True
        Me.btnDeleteTrousseau.HighEmphasis = True
        Me.btnDeleteTrousseau.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
        Me.btnDeleteTrousseau.Location = New System.Drawing.Point(422, 71)
        Me.btnDeleteTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDeleteTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDeleteTrousseau.Name = "btnDeleteTrousseau"
        Me.btnDeleteTrousseau.Size = New System.Drawing.Size(44, 36)
        Me.btnDeleteTrousseau.TabIndex = 148
        Me.btnDeleteTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnDeleteTrousseau.UseAccentColor = False
        Me.btnDeleteTrousseau.UseVisualStyleBackColor = True
        '
        'btnCreerTrousseau
        '
        Me.btnCreerTrousseau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreerTrousseau.Depth = 0
        Me.btnCreerTrousseau.DrawShadows = True
        Me.btnCreerTrousseau.HighEmphasis = True
        Me.btnCreerTrousseau.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnCreerTrousseau.Location = New System.Drawing.Point(371, 71)
        Me.btnCreerTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCreerTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCreerTrousseau.Name = "btnCreerTrousseau"
        Me.btnCreerTrousseau.Size = New System.Drawing.Size(44, 36)
        Me.btnCreerTrousseau.TabIndex = 149
        Me.btnCreerTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnCreerTrousseau.UseAccentColor = False
        Me.btnCreerTrousseau.UseVisualStyleBackColor = True
        '
        'btnRetirerClefsTrousseau
        '
        Me.btnRetirerClefsTrousseau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRetirerClefsTrousseau.Depth = 0
        Me.btnRetirerClefsTrousseau.DrawShadows = True
        Me.btnRetirerClefsTrousseau.HighEmphasis = True
        Me.btnRetirerClefsTrousseau.Icon = Global.GestionClefs.My.Resources.Resources.retirer_clefs
        Me.btnRetirerClefsTrousseau.Location = New System.Drawing.Point(32, 429)
        Me.btnRetirerClefsTrousseau.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRetirerClefsTrousseau.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRetirerClefsTrousseau.Name = "btnRetirerClefsTrousseau"
        Me.btnRetirerClefsTrousseau.Size = New System.Drawing.Size(410, 36)
        Me.btnRetirerClefsTrousseau.TabIndex = 150
        Me.btnRetirerClefsTrousseau.Text = "Retirer les clefs séléctionnées du trousseau"
        Me.btnRetirerClefsTrousseau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnRetirerClefsTrousseau.UseAccentColor = False
        Me.btnRetirerClefsTrousseau.UseVisualStyleBackColor = True
        '
        'frmTrousseauxGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 551)
        Me.Controls.Add(Me.btnRetirerClefsTrousseau)
        Me.Controls.Add(Me.btnCreerTrousseau)
        Me.Controls.Add(Me.btnDeleteTrousseau)
        Me.Controls.Add(Me.dgvClefs)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.cbTrousseaux)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrousseauxGestion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestions des trousseaux"
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClefs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTrousseaux As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvClefs As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnDeleteTrousseau As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCreerTrousseau As MaterialSkin.Controls.MaterialButton
    Friend WithEvents RetirerDuTrousseauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRetirerClefsTrousseau As MaterialSkin.Controls.MaterialButton
End Class
