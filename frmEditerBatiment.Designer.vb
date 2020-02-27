<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditerBatiment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditerBatiment))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFonction = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtFonction = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFonction)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.lblAdresse)
        Me.GroupBox2.Controls.Add(Me.lblNom)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.txtFonction)
        Me.GroupBox2.Controls.Add(Me.txtAdresse)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 227)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editer un bâtiment"
        '
        'lblFonction
        '
        Me.lblFonction.AutoSize = True
        Me.lblFonction.Location = New System.Drawing.Point(6, 146)
        Me.lblFonction.Name = "lblFonction"
        Me.lblFonction.Size = New System.Drawing.Size(54, 13)
        Me.lblFonction.TabIndex = 56
        Me.lblFonction.Text = "Fonction :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(237, 32)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(249, 188)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 32)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(6, 103)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(51, 13)
        Me.lblAdresse.TabIndex = 55
        Me.lblAdresse.Text = "Adresse :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(6, 60)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(78, 13)
        Me.lblNom.TabIndex = 54
        Me.lblNom.Text = "Dénomination :"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 17)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 13)
        Me.lblID.TabIndex = 53
        Me.lblID.Text = "N° :"
        '
        'txtFonction
        '
        Me.txtFonction.Location = New System.Drawing.Point(9, 162)
        Me.txtFonction.MaxLength = 255
        Me.txtFonction.Name = "txtFonction"
        Me.txtFonction.Size = New System.Drawing.Size(335, 20)
        Me.txtFonction.TabIndex = 51
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(9, 119)
        Me.txtAdresse.MaxLength = 255
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(335, 20)
        Me.txtAdresse.TabIndex = 50
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(9, 76)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(335, 20)
        Me.txtNom.TabIndex = 49
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 33)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 48
        '
        'frmEditerBatiment
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(374, 304)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditerBatiment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Editer un batiment..."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFonction As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtFonction As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtID As TextBox
End Class
