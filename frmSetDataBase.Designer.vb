<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetDataBase
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
        Me.txtServeur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtActPort = New System.Windows.Forms.TextBox()
        Me.txtActPassword = New System.Windows.Forms.TextBox()
        Me.txtActID = New System.Windows.Forms.TextBox()
        Me.txtActDatabase = New System.Windows.Forms.TextBox()
        Me.txtActServeur = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtServeur
        '
        Me.txtServeur.Location = New System.Drawing.Point(6, 33)
        Me.txtServeur.Name = "txtServeur"
        Me.txtServeur.Size = New System.Drawing.Size(238, 20)
        Me.txtServeur.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serveur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Base de donnée"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(6, 111)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(238, 20)
        Me.txtDatabase.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Identifiant"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 150)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(238, 20)
        Me.txtID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mot de passe"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 189)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(238, 20)
        Me.txtPassword.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDatabase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServeur)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 216)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base de donnée"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(6, 72)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(238, 20)
        Me.txtPort.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtActPort)
        Me.GroupBox2.Controls.Add(Me.txtActPassword)
        Me.GroupBox2.Controls.Add(Me.txtActID)
        Me.GroupBox2.Controls.Add(Me.txtActDatabase)
        Me.GroupBox2.Controls.Add(Me.txtActServeur)
        Me.GroupBox2.Location = New System.Drawing.Point(250, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 216)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valeurs précédentes"
        '
        'txtActPort
        '
        Me.txtActPort.Enabled = False
        Me.txtActPort.Location = New System.Drawing.Point(6, 72)
        Me.txtActPort.Name = "txtActPort"
        Me.txtActPort.Size = New System.Drawing.Size(167, 20)
        Me.txtActPort.TabIndex = 15
        '
        'txtActPassword
        '
        Me.txtActPassword.Enabled = False
        Me.txtActPassword.Location = New System.Drawing.Point(6, 189)
        Me.txtActPassword.Name = "txtActPassword"
        Me.txtActPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActPassword.Size = New System.Drawing.Size(167, 20)
        Me.txtActPassword.TabIndex = 14
        '
        'txtActID
        '
        Me.txtActID.Enabled = False
        Me.txtActID.Location = New System.Drawing.Point(6, 150)
        Me.txtActID.Name = "txtActID"
        Me.txtActID.Size = New System.Drawing.Size(167, 20)
        Me.txtActID.TabIndex = 13
        '
        'txtActDatabase
        '
        Me.txtActDatabase.Enabled = False
        Me.txtActDatabase.Location = New System.Drawing.Point(6, 111)
        Me.txtActDatabase.Name = "txtActDatabase"
        Me.txtActDatabase.Size = New System.Drawing.Size(167, 20)
        Me.txtActDatabase.TabIndex = 12
        '
        'txtActServeur
        '
        Me.txtActServeur.Enabled = False
        Me.txtActServeur.Location = New System.Drawing.Point(6, 33)
        Me.txtActServeur.Name = "txtActServeur"
        Me.txtActServeur.Size = New System.Drawing.Size(167, 20)
        Me.txtActServeur.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(324, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(201, 253)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(12, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(431, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ATTENTION ! Ne modifier les paramètres que si vous savez ce que vous faîtes !"
        '
        'frmSetDataBase
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(453, 285)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(469, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(469, 324)
        Me.Name = "frmSetDataBase"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Paramètres"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServeur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtActPassword As TextBox
    Friend WithEvents txtActID As TextBox
    Friend WithEvents txtActDatabase As TextBox
    Friend WithEvents txtActServeur As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtActPort As TextBox
    Friend WithEvents Label6 As Label
End Class
