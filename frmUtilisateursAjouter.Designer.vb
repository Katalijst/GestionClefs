<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilisateursAjouter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateursAjouter))
        Me.txtPasswordConfirm = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbUserType = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.cbServices = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnAnnuler = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddServices = New MaterialSkin.Controls.MaterialButton()
        Me.lblService = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordConfirm.Depth = 0
        Me.txtPasswordConfirm.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtPasswordConfirm.Hint = "Confirmer le mot de passe"
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(12, 216)
        Me.txtPasswordConfirm.MaxLength = 50
        Me.txtPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPasswordConfirm.Multiline = False
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Password = True
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(276, 36)
        Me.txtPasswordConfirm.TabIndex = 3
        Me.txtPasswordConfirm.Text = ""
        Me.txtPasswordConfirm.UseTallSize = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtPassword.Hint = "Mot de passe"
        Me.txtPassword.Location = New System.Drawing.Point(12, 174)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Password = True
        Me.txtPassword.Size = New System.Drawing.Size(276, 36)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        Me.txtPassword.UseTallSize = False
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtID.Hint = "Identifiant"
        Me.txtID.Location = New System.Drawing.Point(12, 125)
        Me.txtID.MaxLength = 50
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(276, 36)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = ""
        Me.txtID.UseTallSize = False
        '
        'cbUserType
        '
        Me.cbUserType.AutoResize = False
        Me.cbUserType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbUserType.Depth = 0
        Me.cbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbUserType.DropDownHeight = 118
        Me.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserType.DropDownWidth = 121
        Me.cbUserType.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbUserType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbUserType.FormattingEnabled = True
        Me.cbUserType.Hint = "Type de compte"
        Me.cbUserType.IntegralHeight = False
        Me.cbUserType.ItemHeight = 29
        Me.cbUserType.Items.AddRange(New Object() {"Utilisateur", "Chef de service", "Administrateur"})
        Me.cbUserType.Location = New System.Drawing.Point(12, 77)
        Me.cbUserType.MaxDropDownItems = 4
        Me.cbUserType.MouseState = MaterialSkin.MouseState.OUT
        Me.cbUserType.Name = "cbUserType"
        Me.cbUserType.Size = New System.Drawing.Size(276, 35)
        Me.cbUserType.TabIndex = 0
        Me.cbUserType.UseTallSize = False
        '
        'btnValider
        '
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(208, 316)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(80, 36)
        Me.btnValider.TabIndex = 39
        Me.btnValider.Text = "Valider"
        Me.btnValider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnValider.UseAccentColor = False
        Me.btnValider.UseVisualStyleBackColor = True
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
        Me.cbServices.Hint = "Service"
        Me.cbServices.IntegralHeight = False
        Me.cbServices.ItemHeight = 29
        Me.cbServices.Location = New System.Drawing.Point(12, 265)
        Me.cbServices.MaxDropDownItems = 4
        Me.cbServices.MouseState = MaterialSkin.MouseState.OUT
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(225, 35)
        Me.cbServices.TabIndex = 4
        Me.cbServices.UseTallSize = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 118)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(276, 1)
        Me.MaterialDivider1.TabIndex = 40
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(12, 167)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(276, 1)
        Me.MaterialDivider2.TabIndex = 41
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(12, 258)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(276, 1)
        Me.MaterialDivider3.TabIndex = 42
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(12, 306)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(276, 1)
        Me.MaterialDivider4.TabIndex = 43
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAnnuler.Depth = 0
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.DrawShadows = True
        Me.btnAnnuler.HighEmphasis = True
        Me.btnAnnuler.Icon = Nothing
        Me.btnAnnuler.Location = New System.Drawing.Point(13, 316)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAnnuler.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btnAnnuler.TabIndex = 44
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAnnuler.UseAccentColor = False
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnAddServices
        '
        Me.btnAddServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddServices.Depth = 0
        Me.btnAddServices.DrawShadows = True
        Me.btnAddServices.HighEmphasis = True
        Me.btnAddServices.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddServices.Location = New System.Drawing.Point(244, 264)
        Me.btnAddServices.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddServices.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddServices.Name = "btnAddServices"
        Me.btnAddServices.Size = New System.Drawing.Size(44, 36)
        Me.btnAddServices.TabIndex = 45
        Me.btnAddServices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddServices.UseAccentColor = False
        Me.btnAddServices.UseVisualStyleBackColor = True
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Depth = 0
        Me.lblService.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblService.Location = New System.Drawing.Point(27, 273)
        Me.lblService.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(52, 19)
        Me.lblService.TabIndex = 46
        Me.lblService.Text = "Service"
        '
        'frmUtilisateursAjouter
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(300, 364)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.btnAddServices)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.cbServices)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.cbUserType)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateursAjouter"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nouveau compte..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPasswordConfirm As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbUserType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbServices As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnAnnuler As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddServices As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblService As MaterialSkin.Controls.MaterialLabel
End Class
