<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtilisateursPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateursPassword))
        Me.lblID = New MaterialSkin.Controls.MaterialLabel()
        Me.txtOldPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNewPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNewPasswordConfirm = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnChangePassword = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnAnnuler = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Depth = 0
        Me.lblID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblID.Location = New System.Drawing.Point(12, 72)
        Me.lblID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(72, 19)
        Me.lblID.TabIndex = 27
        Me.lblID.Text = "Username"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldPassword.Depth = 0
        Me.txtOldPassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtOldPassword.Hint = "Mot de passe actuel"
        Me.txtOldPassword.Location = New System.Drawing.Point(15, 94)
        Me.txtOldPassword.MaxLength = 50
        Me.txtOldPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOldPassword.Multiline = False
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Password = True
        Me.txtOldPassword.Size = New System.Drawing.Size(237, 36)
        Me.txtOldPassword.TabIndex = 0
        Me.txtOldPassword.Text = ""
        Me.txtOldPassword.UseTallSize = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Depth = 0
        Me.txtNewPassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNewPassword.Hint = "Nouveau mot de passe"
        Me.txtNewPassword.Location = New System.Drawing.Point(15, 143)
        Me.txtNewPassword.MaxLength = 50
        Me.txtNewPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNewPassword.Multiline = False
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Password = True
        Me.txtNewPassword.Size = New System.Drawing.Size(237, 36)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.Text = ""
        Me.txtNewPassword.UseTallSize = False
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPasswordConfirm.Depth = 0
        Me.txtNewPasswordConfirm.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNewPasswordConfirm.Hint = "Confirmer le mot de passe"
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(15, 185)
        Me.txtNewPasswordConfirm.MaxLength = 50
        Me.txtNewPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNewPasswordConfirm.Multiline = False
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.Password = True
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(237, 36)
        Me.txtNewPasswordConfirm.TabIndex = 2
        Me.txtNewPasswordConfirm.Text = ""
        Me.txtNewPasswordConfirm.UseTallSize = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangePassword.Depth = 0
        Me.btnChangePassword.DrawShadows = True
        Me.btnChangePassword.HighEmphasis = True
        Me.btnChangePassword.Icon = Nothing
        Me.btnChangePassword.Location = New System.Drawing.Point(171, 238)
        Me.btnChangePassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(80, 36)
        Me.btnChangePassword.TabIndex = 4
        Me.btnChangePassword.Text = "Valider"
        Me.btnChangePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnChangePassword.UseAccentColor = False
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(14, 228)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(239, 1)
        Me.MaterialDivider1.TabIndex = 32
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAnnuler.Depth = 0
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.DrawShadows = True
        Me.btnAnnuler.HighEmphasis = True
        Me.btnAnnuler.Icon = Nothing
        Me.btnAnnuler.Location = New System.Drawing.Point(13, 238)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAnnuler.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(87, 36)
        Me.btnAnnuler.TabIndex = 3
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAnnuler.UseAccentColor = False
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(14, 136)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(239, 1)
        Me.MaterialDivider2.TabIndex = 34
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'frmUtilisateursPassword
        '
        Me.AcceptButton = Me.btnChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(264, 286)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.txtNewPasswordConfirm)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.lblID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateursPassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Changer le mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtOldPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNewPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNewPasswordConfirm As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnChangePassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnAnnuler As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
End Class
