<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnexion
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
        Me.tmrFondu = New System.Windows.Forms.Timer(Me.components)
        Me.btnConnexion = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnQuitter = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mtxtID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mtxtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'tmrFondu
        '
        Me.tmrFondu.Interval = 10
        '
        'btnConnexion
        '
        Me.btnConnexion.AutoSize = True
        Me.btnConnexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConnexion.Depth = 0
        Me.btnConnexion.Icon = Nothing
        Me.btnConnexion.Location = New System.Drawing.Point(131, 129)
        Me.btnConnexion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Primary = True
        Me.btnConnexion.Size = New System.Drawing.Size(98, 36)
        Me.btnConnexion.TabIndex = 15
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.AutoSize = True
        Me.btnQuitter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuitter.Depth = 0
        Me.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuitter.Icon = Nothing
        Me.btnQuitter.Location = New System.Drawing.Point(12, 129)
        Me.btnQuitter.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Primary = True
        Me.btnQuitter.Size = New System.Drawing.Size(76, 36)
        Me.btnQuitter.TabIndex = 16
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'mtxtID
        '
        Me.mtxtID.Depth = 0
        Me.mtxtID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mtxtID.Hint = "Identifiant"
        Me.mtxtID.Location = New System.Drawing.Point(12, 70)
        Me.mtxtID.MaxLength = 32767
        Me.mtxtID.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtxtID.Name = "mtxtID"
        Me.mtxtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtID.SelectedText = ""
        Me.mtxtID.SelectionLength = 0
        Me.mtxtID.SelectionStart = 0
        Me.mtxtID.Size = New System.Drawing.Size(214, 23)
        Me.mtxtID.TabIndex = 17
        Me.mtxtID.TabStop = False
        Me.mtxtID.UseSystemPasswordChar = False
        '
        'mtxtPassword
        '
        Me.mtxtPassword.Depth = 0
        Me.mtxtPassword.Hint = "Mot de passe"
        Me.mtxtPassword.Location = New System.Drawing.Point(12, 99)
        Me.mtxtPassword.MaxLength = 32767
        Me.mtxtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtxtPassword.Name = "mtxtPassword"
        Me.mtxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtPassword.SelectedText = ""
        Me.mtxtPassword.SelectionLength = 0
        Me.mtxtPassword.SelectionStart = 0
        Me.mtxtPassword.Size = New System.Drawing.Size(214, 23)
        Me.mtxtPassword.TabIndex = 18
        Me.mtxtPassword.TabStop = False
        Me.mtxtPassword.UseSystemPasswordChar = True
        '
        'frmConnexion
        '
        Me.AcceptButton = Me.btnConnexion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.btnQuitter
        Me.ClientSize = New System.Drawing.Size(238, 176)
        Me.Controls.Add(Me.mtxtPassword)
        Me.Controls.Add(Me.mtxtID)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnConnexion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnexion"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion à GestionClefs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFondu As Timer
    Friend WithEvents btnConnexion As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnQuitter As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mtxtID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents mtxtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
