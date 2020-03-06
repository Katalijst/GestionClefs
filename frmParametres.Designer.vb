<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParametres
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
        Me.swtDarkMode = New MaterialSkin.Controls.MaterialSwitch()
        Me.swtAlertPopUp = New MaterialSkin.Controls.MaterialSwitch()
        Me.btnOK = New MaterialSkin.Controls.MaterialButton()
        Me.btnAbout = New MaterialSkin.Controls.MaterialButton()
        Me.btnMySQL = New MaterialSkin.Controls.MaterialButton()
        Me.btnGestionUtilisateurs = New MaterialSkin.Controls.MaterialButton()
        Me.btnChangerMotDePasse = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'swtDarkMode
        '
        Me.swtDarkMode.AutoSize = True
        Me.swtDarkMode.Depth = 0
        Me.swtDarkMode.Location = New System.Drawing.Point(13, 246)
        Me.swtDarkMode.Margin = New System.Windows.Forms.Padding(0)
        Me.swtDarkMode.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtDarkMode.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtDarkMode.Name = "swtDarkMode"
        Me.swtDarkMode.Ripple = True
        Me.swtDarkMode.Size = New System.Drawing.Size(155, 37)
        Me.swtDarkMode.TabIndex = 13
        Me.swtDarkMode.Text = "Mode sombre"
        Me.swtDarkMode.UseVisualStyleBackColor = True
        '
        'swtAlertPopUp
        '
        Me.swtAlertPopUp.AutoSize = True
        Me.swtAlertPopUp.Depth = 0
        Me.swtAlertPopUp.Location = New System.Drawing.Point(13, 206)
        Me.swtAlertPopUp.Margin = New System.Windows.Forms.Padding(0)
        Me.swtAlertPopUp.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtAlertPopUp.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtAlertPopUp.Name = "swtAlertPopUp"
        Me.swtAlertPopUp.Ripple = True
        Me.swtAlertPopUp.Size = New System.Drawing.Size(265, 37)
        Me.swtAlertPopUp.TabIndex = 12
        Me.swtAlertPopUp.Text = "Pop-up d'alerte au démarrage"
        Me.swtAlertPopUp.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOK.Depth = 0
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.DrawShadows = True
        Me.btnOK.HighEmphasis = True
        Me.btnOK.Icon = Nothing
        Me.btnOK.Location = New System.Drawing.Point(243, 289)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOK.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(41, 36)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "Ok"
        Me.btnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOK.UseAccentColor = False
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAbout.Depth = 0
        Me.btnAbout.DrawShadows = True
        Me.btnAbout.HighEmphasis = True
        Me.btnAbout.Icon = Nothing
        Me.btnAbout.Location = New System.Drawing.Point(13, 289)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAbout.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(222, 36)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "A propos de GestionClefs"
        Me.btnAbout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAbout.UseAccentColor = False
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnMySQL
        '
        Me.btnMySQL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMySQL.Depth = 0
        Me.btnMySQL.DrawShadows = True
        Me.btnMySQL.HighEmphasis = True
        Me.btnMySQL.Icon = Nothing
        Me.btnMySQL.Location = New System.Drawing.Point(13, 164)
        Me.btnMySQL.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnMySQL.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnMySQL.Name = "btnMySQL"
        Me.btnMySQL.Size = New System.Drawing.Size(148, 36)
        Me.btnMySQL.TabIndex = 9
        Me.btnMySQL.Text = "Paramètres BDD"
        Me.btnMySQL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnMySQL.UseAccentColor = False
        Me.btnMySQL.UseVisualStyleBackColor = True
        '
        'btnGestionUtilisateurs
        '
        Me.btnGestionUtilisateurs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGestionUtilisateurs.Depth = 0
        Me.btnGestionUtilisateurs.DrawShadows = True
        Me.btnGestionUtilisateurs.HighEmphasis = True
        Me.btnGestionUtilisateurs.Icon = Nothing
        Me.btnGestionUtilisateurs.Location = New System.Drawing.Point(13, 116)
        Me.btnGestionUtilisateurs.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGestionUtilisateurs.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGestionUtilisateurs.Name = "btnGestionUtilisateurs"
        Me.btnGestionUtilisateurs.Size = New System.Drawing.Size(120, 36)
        Me.btnGestionUtilisateurs.TabIndex = 14
        Me.btnGestionUtilisateurs.Text = "Utilisateurs"
        Me.btnGestionUtilisateurs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnGestionUtilisateurs.UseAccentColor = False
        Me.btnGestionUtilisateurs.UseVisualStyleBackColor = True
        '
        'btnChangerMotDePasse
        '
        Me.btnChangerMotDePasse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangerMotDePasse.Depth = 0
        Me.btnChangerMotDePasse.DrawShadows = True
        Me.btnChangerMotDePasse.HighEmphasis = True
        Me.btnChangerMotDePasse.Icon = Nothing
        Me.btnChangerMotDePasse.Location = New System.Drawing.Point(13, 70)
        Me.btnChangerMotDePasse.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnChangerMotDePasse.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangerMotDePasse.Name = "btnChangerMotDePasse"
        Me.btnChangerMotDePasse.Size = New System.Drawing.Size(233, 36)
        Me.btnChangerMotDePasse.TabIndex = 15
        Me.btnChangerMotDePasse.Text = "Changer mon mot de passe"
        Me.btnChangerMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangerMotDePasse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.btnChangerMotDePasse.UseAccentColor = False
        Me.btnChangerMotDePasse.UseVisualStyleBackColor = True
        '
        'frmParametres
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(296, 338)
        Me.Controls.Add(Me.btnChangerMotDePasse)
        Me.Controls.Add(Me.btnGestionUtilisateurs)
        Me.Controls.Add(Me.swtDarkMode)
        Me.Controls.Add(Me.swtAlertPopUp)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnMySQL)
        Me.Name = "frmParametres"
        Me.Sizable = False
        Me.Text = "Paramètres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents swtDarkMode As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents swtAlertPopUp As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents btnOK As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAbout As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnMySQL As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGestionUtilisateurs As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnChangerMotDePasse As MaterialSkin.Controls.MaterialButton
End Class
