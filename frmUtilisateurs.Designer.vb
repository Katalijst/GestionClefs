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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUserManager = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnChangePassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtNewPasswordConfirm)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 198)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Changer le mot de passe"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(9, 165)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(222, 23)
        Me.btnChangePassword.TabIndex = 20
        Me.btnChangePassword.Text = "Valider"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Identifiant"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(9, 32)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(222, 20)
        Me.txtID.TabIndex = 23
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(9, 71)
        Me.txtOldPassword.MaxLength = 50
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtOldPassword.TabIndex = 24
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(9, 105)
        Me.txtNewPassword.MaxLength = 50
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtNewPassword.TabIndex = 25
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(9, 131)
        Me.txtNewPasswordConfirm.MaxLength = 50
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(222, 20)
        Me.txtNewPasswordConfirm.TabIndex = 26
        Me.txtNewPasswordConfirm.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Mot de passe"
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(130, 223)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(118, 23)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.Text = "Ajouter un utilisateur"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUserManager)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btnAddUser)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 253)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Utilisateurs"
        '
        'btnUserManager
        '
        Me.btnUserManager.Location = New System.Drawing.Point(6, 223)
        Me.btnUserManager.Name = "btnUserManager"
        Me.btnUserManager.Size = New System.Drawing.Size(118, 23)
        Me.btnUserManager.TabIndex = 3
        Me.btnUserManager.Text = "Gérer les utilisateurs"
        Me.btnUserManager.UseVisualStyleBackColor = True
        '
        'frmUtilisateursPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 342)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateursPassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Utilisateurs..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewPasswordConfirm As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUserManager As Button
End Class
