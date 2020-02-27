<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.cbUserType = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(12, 228)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(222, 23)
        Me.btnChangePassword.TabIndex = 5
        Me.btnChangePassword.Text = "Valider"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 97)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(222, 20)
        Me.txtID.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 123)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(222, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(12, 149)
        Me.txtPasswordConfirm.MaxLength = 50
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(222, 20)
        Me.txtPasswordConfirm.TabIndex = 3
        Me.txtPasswordConfirm.UseSystemPasswordChar = True
        '
        'cbUserType
        '
        Me.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserType.FormattingEnabled = True
        Me.cbUserType.Items.AddRange(New Object() {"Administrateur", "Utilisateur"})
        Me.cbUserType.Location = New System.Drawing.Point(12, 188)
        Me.cbUserType.Name = "cbUserType"
        Me.cbUserType.Size = New System.Drawing.Size(222, 21)
        Me.cbUserType.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 71)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(222, 20)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Type d'utilisateur :"
        '
        'frmAddUser
        '
        Me.AcceptButton = Me.btnChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 267)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbUserType)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddUser"
        Me.ShowIcon = False
        Me.Text = "Nouveau compte..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPasswordConfirm As TextBox
    Friend WithEvents cbUserType As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
