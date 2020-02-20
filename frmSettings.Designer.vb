<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.gbMySQL = New System.Windows.Forms.GroupBox()
        Me.btnMySQL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActDatabase = New System.Windows.Forms.TextBox()
        Me.txtActPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtActID = New System.Windows.Forms.TextBox()
        Me.txtActServeur = New System.Windows.Forms.TextBox()
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtActPort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbMySQL.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMySQL
        '
        Me.gbMySQL.Controls.Add(Me.btnCancel)
        Me.gbMySQL.Controls.Add(Me.txtActPort)
        Me.gbMySQL.Controls.Add(Me.Label6)
        Me.gbMySQL.Controls.Add(Me.btnMySQL)
        Me.gbMySQL.Controls.Add(Me.Label1)
        Me.gbMySQL.Controls.Add(Me.Label4)
        Me.gbMySQL.Controls.Add(Me.txtActDatabase)
        Me.gbMySQL.Controls.Add(Me.txtActPassword)
        Me.gbMySQL.Controls.Add(Me.Label2)
        Me.gbMySQL.Controls.Add(Me.Label3)
        Me.gbMySQL.Controls.Add(Me.txtActID)
        Me.gbMySQL.Controls.Add(Me.txtActServeur)
        Me.gbMySQL.Location = New System.Drawing.Point(272, 12)
        Me.gbMySQL.Name = "gbMySQL"
        Me.gbMySQL.Size = New System.Drawing.Size(187, 253)
        Me.gbMySQL.TabIndex = 0
        Me.gbMySQL.TabStop = False
        Me.gbMySQL.Text = "Paramètre MySQL"
        '
        'btnMySQL
        '
        Me.btnMySQL.Location = New System.Drawing.Point(9, 223)
        Me.btnMySQL.Name = "btnMySQL"
        Me.btnMySQL.Size = New System.Drawing.Size(104, 23)
        Me.btnMySQL.TabIndex = 19
        Me.btnMySQL.Text = "Modifier..."
        Me.btnMySQL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Serveur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mot de passe"
        '
        'txtActDatabase
        '
        Me.txtActDatabase.Enabled = False
        Me.txtActDatabase.Location = New System.Drawing.Point(9, 110)
        Me.txtActDatabase.Name = "txtActDatabase"
        Me.txtActDatabase.Size = New System.Drawing.Size(167, 20)
        Me.txtActDatabase.TabIndex = 16
        '
        'txtActPassword
        '
        Me.txtActPassword.Enabled = False
        Me.txtActPassword.Location = New System.Drawing.Point(9, 188)
        Me.txtActPassword.Name = "txtActPassword"
        Me.txtActPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActPassword.Size = New System.Drawing.Size(167, 20)
        Me.txtActPassword.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Base de donnée"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Identifiant"
        '
        'txtActID
        '
        Me.txtActID.Enabled = False
        Me.txtActID.Location = New System.Drawing.Point(9, 149)
        Me.txtActID.Name = "txtActID"
        Me.txtActID.Size = New System.Drawing.Size(167, 20)
        Me.txtActID.TabIndex = 17
        '
        'txtActServeur
        '
        Me.txtActServeur.Enabled = False
        Me.txtActServeur.Location = New System.Drawing.Point(9, 32)
        Me.txtActServeur.Name = "txtActServeur"
        Me.txtActServeur.Size = New System.Drawing.Size(167, 20)
        Me.txtActServeur.TabIndex = 15
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
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
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(119, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(62, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Quitter"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtActPort
        '
        Me.txtActPort.Enabled = False
        Me.txtActPort.Location = New System.Drawing.Point(9, 71)
        Me.txtActPort.Name = "txtActPort"
        Me.txtActPort.Size = New System.Drawing.Size(167, 20)
        Me.txtActPort.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Port"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(471, 277)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbMySQL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Paramètres..."
        Me.gbMySQL.ResumeLayout(False)
        Me.gbMySQL.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMySQL As GroupBox
    Friend WithEvents btnMySQL As Button
    Friend WithEvents txtActPassword As TextBox
    Friend WithEvents txtActServeur As TextBox
    Friend WithEvents txtActID As TextBox
    Friend WithEvents txtActDatabase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewPasswordConfirm As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUserManager As Button
    Friend WithEvents txtActPort As TextBox
    Friend WithEvents Label6 As Label
End Class
