<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnexion))
        Me.tmrFondu = New System.Windows.Forms.Timer(Me.components)
        Me.btnConnexion = New MaterialSkin.Controls.MaterialButton()
        Me.btnQuitter = New MaterialSkin.Controls.MaterialButton()
        Me.mtxtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.mtxtPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'tmrFondu
        '
        Me.tmrFondu.Interval = 10
        '
        'btnConnexion
        '
        Me.btnConnexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConnexion.Depth = 0
        Me.btnConnexion.DrawShadows = True
        Me.btnConnexion.HighEmphasis = True
        Me.btnConnexion.Icon = Nothing
        Me.btnConnexion.Location = New System.Drawing.Point(149, 161)
        Me.btnConnexion.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConnexion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(105, 36)
        Me.btnConnexion.TabIndex = 3
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnConnexion.UseAccentColor = False
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuitter.Depth = 0
        Me.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuitter.DrawShadows = True
        Me.btnQuitter.HighEmphasis = True
        Me.btnQuitter.Icon = Nothing
        Me.btnQuitter.Location = New System.Drawing.Point(13, 161)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnQuitter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(81, 36)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnQuitter.UseAccentColor = False
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'mtxtID
        '
        Me.mtxtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxtID.Depth = 0
        Me.mtxtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.mtxtID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mtxtID.Hint = "Identifiant"
        Me.mtxtID.Location = New System.Drawing.Point(13, 74)
        Me.mtxtID.MaxLength = 50
        Me.mtxtID.MouseState = MaterialSkin.MouseState.OUT
        Me.mtxtID.Multiline = False
        Me.mtxtID.Name = "mtxtID"
        Me.mtxtID.Size = New System.Drawing.Size(240, 36)
        Me.mtxtID.TabIndex = 0
        Me.mtxtID.Text = ""
        Me.mtxtID.UseTallSize = False
        '
        'mtxtPassword
        '
        Me.mtxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxtPassword.Depth = 0
        Me.mtxtPassword.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.mtxtPassword.Hint = "Mot de passe"
        Me.mtxtPassword.Location = New System.Drawing.Point(13, 116)
        Me.mtxtPassword.MaxLength = 50
        Me.mtxtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.mtxtPassword.Multiline = False
        Me.mtxtPassword.Name = "mtxtPassword"
        Me.mtxtPassword.Password = True
        Me.mtxtPassword.Size = New System.Drawing.Size(240, 36)
        Me.mtxtPassword.TabIndex = 1
        Me.mtxtPassword.Text = ""
        Me.mtxtPassword.UseTallSize = False
        '
        'frmConnexion
        '
        Me.AcceptButton = Me.btnConnexion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.btnQuitter
        Me.ClientSize = New System.Drawing.Size(265, 208)
        Me.Controls.Add(Me.mtxtPassword)
        Me.Controls.Add(Me.mtxtID)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnConnexion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnexion"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion à GestionClefs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFondu As Timer
    Friend WithEvents btnConnexion As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnQuitter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents mtxtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents mtxtPassword As MaterialSkin.Controls.MaterialTextBox
End Class
