<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersonnesEditer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonnesEditer))
        Me.cbType = New MaterialSkin.Controls.MaterialComboBox()
        Me.lblType = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNom = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTelephone = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAutre = New MaterialSkin.Controls.MaterialLabel()
        Me.txtAutre = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtTel = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddType = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.SuspendLayout()
        '
        'cbType
        '
        Me.cbType.AutoResize = False
        Me.cbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbType.Depth = 0
        Me.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbType.DropDownHeight = 118
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.DropDownWidth = 121
        Me.cbType.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbType.FormattingEnabled = True
        Me.cbType.IntegralHeight = False
        Me.cbType.ItemHeight = 29
        Me.cbType.Location = New System.Drawing.Point(15, 91)
        Me.cbType.MaxDropDownItems = 4
        Me.cbType.MouseState = MaterialSkin.MouseState.OUT
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(121, 35)
        Me.cbType.TabIndex = 64
        Me.cbType.UseTallSize = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Depth = 0
        Me.lblType.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblType.Location = New System.Drawing.Point(12, 69)
        Me.lblType.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(71, 19)
        Me.lblType.TabIndex = 65
        Me.lblType.Text = "Fonction :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Depth = 0
        Me.lblNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNom.Location = New System.Drawing.Point(12, 129)
        Me.lblNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(43, 19)
        Me.lblNom.TabIndex = 66
        Me.lblNom.Text = "Nom :"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Depth = 0
        Me.lblTelephone.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTelephone.Location = New System.Drawing.Point(12, 190)
        Me.lblTelephone.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(83, 19)
        Me.lblTelephone.TabIndex = 67
        Me.lblTelephone.Text = "Téléphone :"
        '
        'lblAutre
        '
        Me.lblAutre.AutoSize = True
        Me.lblAutre.Depth = 0
        Me.lblAutre.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAutre.Location = New System.Drawing.Point(12, 251)
        Me.lblAutre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAutre.Name = "lblAutre"
        Me.lblAutre.Size = New System.Drawing.Size(107, 19)
        Me.lblAutre.TabIndex = 68
        Me.lblAutre.Text = "Compléments :"
        '
        'txtAutre
        '
        Me.txtAutre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAutre.Depth = 0
        Me.txtAutre.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtAutre.Location = New System.Drawing.Point(15, 273)
        Me.txtAutre.MaxLength = 255
        Me.txtAutre.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAutre.Multiline = False
        Me.txtAutre.Name = "txtAutre"
        Me.txtAutre.Size = New System.Drawing.Size(324, 36)
        Me.txtAutre.TabIndex = 69
        Me.txtAutre.Text = ""
        Me.txtAutre.UseTallSize = False
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(15, 151)
        Me.txtNom.MaxLength = 255
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(324, 36)
        Me.txtNom.TabIndex = 70
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel.Depth = 0
        Me.txtTel.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtTel.Location = New System.Drawing.Point(15, 212)
        Me.txtTel.MaxLength = 15
        Me.txtTel.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTel.Multiline = False
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(146, 36)
        Me.txtTel.TabIndex = 71
        Me.txtTel.Text = ""
        Me.txtTel.UseTallSize = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(222, 326)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 72
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.DrawShadows = True
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(15, 326)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 73
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddType.Depth = 0
        Me.btnAddType.DrawShadows = True
        Me.btnAddType.HighEmphasis = True
        Me.btnAddType.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddType.Location = New System.Drawing.Point(143, 90)
        Me.btnAddType.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddType.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(44, 36)
        Me.btnAddType.TabIndex = 74
        Me.btnAddType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddType.UseAccentColor = False
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(15, 316)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(324, 1)
        Me.MaterialDivider1.TabIndex = 75
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'frmPersonnesEditer
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(354, 374)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnAddType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtAutre)
        Me.Controls.Add(Me.lblAutre)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cbType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonnesEditer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Editer une personne..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents lblType As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTelephone As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAutre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtAutre As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtTel As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddType As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
End Class
