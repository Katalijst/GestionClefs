<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnexion
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrFondu = New System.Windows.Forms.Timer(Me.components)
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "GestionClefs"
        '
        'tmrFondu
        '
        Me.tmrFondu.Interval = 15
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(12, 96)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(214, 20)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(12, 65)
        Me.txtID.MaxLength = 50
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(214, 20)
        Me.txtID.TabIndex = 11
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersion.Location = New System.Drawing.Point(16, 159)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(217, 20)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.Green
        Me.btnValider.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.ForeColor = System.Drawing.Color.White
        Me.btnValider.Location = New System.Drawing.Point(128, 133)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(101, 23)
        Me.btnValider.TabIndex = 9
        Me.btnValider.Text = "Connexion"
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.DarkRed
        Me.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(12, 133)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(101, 23)
        Me.btnQuitter.TabIndex = 14
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'frmConnexion
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CancelButton = Me.btnQuitter
        Me.ClientSize = New System.Drawing.Size(238, 181)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnexion"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion à GestionClefs"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tmrFondu As Timer
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnValider As Button
    Friend WithEvents btnQuitter As Button
End Class
