<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicesGestion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicesGestion))
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRemSelTableaux = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddSelTableaux = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvSelTableaux = New System.Windows.Forms.DataGridView()
        Me.dgvListTableaux = New System.Windows.Forms.DataGridView()
        Me.txtRechercher = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnAddService = New MaterialSkin.Controls.MaterialButton()
        Me.cbServices = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnSupprimerService = New MaterialSkin.Controls.MaterialButton()
        CType(Me.dgvSelTableaux, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListTableaux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.Location = New System.Drawing.Point(125, 96)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(1, 0)
        Me.MaterialLabel8.TabIndex = 68
        '
        'btnRemSelTableaux
        '
        Me.btnRemSelTableaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRemSelTableaux.Depth = 0
        Me.btnRemSelTableaux.DrawShadows = True
        Me.btnRemSelTableaux.HighEmphasis = True
        Me.btnRemSelTableaux.Icon = Global.GestionClefs.My.Resources.Resources.left_arrow_key
        Me.btnRemSelTableaux.Location = New System.Drawing.Point(339, 246)
        Me.btnRemSelTableaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRemSelTableaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRemSelTableaux.Name = "btnRemSelTableaux"
        Me.btnRemSelTableaux.Size = New System.Drawing.Size(44, 36)
        Me.btnRemSelTableaux.TabIndex = 64
        Me.btnRemSelTableaux.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnRemSelTableaux.UseAccentColor = False
        Me.btnRemSelTableaux.UseVisualStyleBackColor = True
        '
        'btnAddSelTableaux
        '
        Me.btnAddSelTableaux.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddSelTableaux.Depth = 0
        Me.btnAddSelTableaux.DrawShadows = True
        Me.btnAddSelTableaux.HighEmphasis = True
        Me.btnAddSelTableaux.Icon = Global.GestionClefs.My.Resources.Resources.keyboard_right_arrow_button
        Me.btnAddSelTableaux.Location = New System.Drawing.Point(339, 198)
        Me.btnAddSelTableaux.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddSelTableaux.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddSelTableaux.Name = "btnAddSelTableaux"
        Me.btnAddSelTableaux.Size = New System.Drawing.Size(44, 36)
        Me.btnAddSelTableaux.TabIndex = 63
        Me.btnAddSelTableaux.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnAddSelTableaux.UseAccentColor = False
        Me.btnAddSelTableaux.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(390, 112)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(113, 19)
        Me.MaterialLabel2.TabIndex = 67
        Me.MaterialLabel2.Text = "Le service gère :"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 112)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(129, 19)
        Me.MaterialLabel1.TabIndex = 66
        Me.MaterialLabel1.Text = "Liste des tableaux"
        '
        'dgvSelTableaux
        '
        Me.dgvSelTableaux.AllowUserToAddRows = False
        Me.dgvSelTableaux.AllowUserToDeleteRows = False
        Me.dgvSelTableaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelTableaux.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSelTableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelTableaux.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSelTableaux.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSelTableaux.Location = New System.Drawing.Point(390, 134)
        Me.dgvSelTableaux.MultiSelect = False
        Me.dgvSelTableaux.Name = "dgvSelTableaux"
        Me.dgvSelTableaux.ReadOnly = True
        Me.dgvSelTableaux.RowHeadersVisible = False
        Me.dgvSelTableaux.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSelTableaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelTableaux.Size = New System.Drawing.Size(323, 209)
        Me.dgvSelTableaux.TabIndex = 65
        '
        'dgvListTableaux
        '
        Me.dgvListTableaux.AllowUserToAddRows = False
        Me.dgvListTableaux.AllowUserToDeleteRows = False
        Me.dgvListTableaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListTableaux.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListTableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListTableaux.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListTableaux.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListTableaux.Location = New System.Drawing.Point(12, 134)
        Me.dgvListTableaux.MultiSelect = False
        Me.dgvListTableaux.Name = "dgvListTableaux"
        Me.dgvListTableaux.ReadOnly = True
        Me.dgvListTableaux.RowHeadersVisible = False
        Me.dgvListTableaux.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListTableaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTableaux.Size = New System.Drawing.Size(320, 209)
        Me.dgvListTableaux.TabIndex = 62
        '
        'txtRechercher
        '
        Me.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRechercher.Depth = 0
        Me.txtRechercher.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtRechercher.Hint = "Rechercher un tableau"
        Me.txtRechercher.Location = New System.Drawing.Point(12, 73)
        Me.txtRechercher.MaxLength = 144
        Me.txtRechercher.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRechercher.Multiline = False
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(320, 36)
        Me.txtRechercher.TabIndex = 60
        Me.txtRechercher.Text = ""
        Me.txtRechercher.UseTallSize = False
        '
        'btnAddService
        '
        Me.btnAddService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddService.Depth = 0
        Me.btnAddService.DrawShadows = True
        Me.btnAddService.HighEmphasis = True
        Me.btnAddService.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddService.Location = New System.Drawing.Point(625, 71)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddService.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(44, 36)
        Me.btnAddService.TabIndex = 61
        Me.btnAddService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddService.UseAccentColor = False
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'cbServices
        '
        Me.cbServices.AutoResize = False
        Me.cbServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbServices.Depth = 0
        Me.cbServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbServices.DropDownHeight = 118
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.DropDownWidth = 121
        Me.cbServices.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Hint = "Service à éditer"
        Me.cbServices.IntegralHeight = False
        Me.cbServices.ItemHeight = 29
        Me.cbServices.Location = New System.Drawing.Point(390, 72)
        Me.cbServices.MaxDropDownItems = 4
        Me.cbServices.MouseState = MaterialSkin.MouseState.OUT
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(232, 35)
        Me.cbServices.TabIndex = 69
        Me.cbServices.UseTallSize = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(593, 352)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSupprimerService
        '
        Me.btnSupprimerService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSupprimerService.Depth = 0
        Me.btnSupprimerService.DrawShadows = True
        Me.btnSupprimerService.HighEmphasis = True
        Me.btnSupprimerService.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
        Me.btnSupprimerService.Location = New System.Drawing.Point(669, 71)
        Me.btnSupprimerService.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSupprimerService.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSupprimerService.Name = "btnSupprimerService"
        Me.btnSupprimerService.Size = New System.Drawing.Size(44, 36)
        Me.btnSupprimerService.TabIndex = 71
        Me.btnSupprimerService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnSupprimerService.UseAccentColor = False
        Me.btnSupprimerService.UseVisualStyleBackColor = True
        '
        'frmServicesGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 398)
        Me.Controls.Add(Me.btnSupprimerService)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbServices)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.btnRemSelTableaux)
        Me.Controls.Add(Me.btnAddSelTableaux)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dgvSelTableaux)
        Me.Controls.Add(Me.dgvListTableaux)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.btnAddService)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServicesGestion"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Services"
        CType(Me.dgvSelTableaux, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListTableaux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnRemSelTableaux As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddSelTableaux As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvSelTableaux As DataGridView
    Friend WithEvents dgvListTableaux As DataGridView
    Friend WithEvents txtRechercher As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnAddService As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbServices As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSupprimerService As MaterialSkin.Controls.MaterialButton
End Class
