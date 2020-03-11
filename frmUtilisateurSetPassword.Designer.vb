<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilisateurSetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateurSetPassword))
        Me.txtPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtPasswordConfirm = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblUserName = New MaterialSkin.Controls.MaterialLabel()
        Me.btnChangePassword = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnQuit = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtPassword.Hint = "Nouveau mot de passe"
        Me.txtPassword.Location = New System.Drawing.Point(12, 96)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Password = True
        Me.txtPassword.Size = New System.Drawing.Size(239, 36)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Text = ""
        Me.txtPassword.UseTallSize = False
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordConfirm.Depth = 0
        Me.txtPasswordConfirm.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtPasswordConfirm.Hint = "Confirmer le mot de passe"
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(12, 138)
        Me.txtPasswordConfirm.MaxLength = 50
        Me.txtPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPasswordConfirm.Multiline = False
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Password = True
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(239, 36)
        Me.txtPasswordConfirm.TabIndex = 1
        Me.txtPasswordConfirm.Text = ""
        Me.txtPasswordConfirm.UseTallSize = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Depth = 0
        Me.lblUserName.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblUserName.Location = New System.Drawing.Point(12, 74)
        Me.lblUserName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(121, 19)
        Me.lblUserName.TabIndex = 45
        Me.lblUserName.Text = "Nom d'utilisateur"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangePassword.Depth = 0
        Me.btnChangePassword.DrawShadows = True
        Me.btnChangePassword.HighEmphasis = True
        Me.btnChangePassword.Icon = Nothing
        Me.btnChangePassword.Location = New System.Drawing.Point(172, 190)
        Me.btnChangePassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(80, 36)
        Me.btnChangePassword.TabIndex = 3
        Me.btnChangePassword.Text = "Valider"
        Me.btnChangePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnChangePassword.UseAccentColor = False
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 180)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(240, 1)
        Me.MaterialDivider1.TabIndex = 47
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnQuit
        '
        Me.btnQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuit.Depth = 0
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.DrawShadows = True
        Me.btnQuit.HighEmphasis = True
        Me.btnQuit.Icon = Nothing
        Me.btnQuit.Location = New System.Drawing.Point(13, 190)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnQuit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(81, 36)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnQuit.UseAccentColor = False
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmUtilisateurSetPassword
        '
        Me.AcceptButton = Me.btnChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(264, 240)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateurSetPassword"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau mot de passe"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPasswordConfirm As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblUserName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnChangePassword As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnQuit As MaterialSkin.Controls.MaterialButton
End Class
