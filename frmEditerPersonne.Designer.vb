<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditerPersonne
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddType = New System.Windows.Forms.Button()
        Me.mtxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblAutre = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtAutre = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddType)
        Me.GroupBox2.Controls.Add(Me.mtxtTel)
        Me.GroupBox2.Controls.Add(Me.cmbType)
        Me.GroupBox2.Controls.Add(Me.lblAutre)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.lblTelephone)
        Me.GroupBox2.Controls.Add(Me.lblNom)
        Me.GroupBox2.Controls.Add(Me.lblType)
        Me.GroupBox2.Controls.Add(Me.txtAutre)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 229)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editer une personne"
        '
        'btnAddType
        '
        Me.btnAddType.Location = New System.Drawing.Point(136, 32)
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(23, 23)
        Me.btnAddType.TabIndex = 63
        Me.btnAddType.Text = "+"
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'mtxtTel
        '
        Me.mtxtTel.Location = New System.Drawing.Point(9, 119)
        Me.mtxtTel.Mask = "00 00 00 00 00"
        Me.mtxtTel.Name = "mtxtTel"
        Me.mtxtTel.Size = New System.Drawing.Size(121, 20)
        Me.mtxtTel.TabIndex = 58
        Me.mtxtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(9, 33)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 57
        '
        'lblAutre
        '
        Me.lblAutre.AutoSize = True
        Me.lblAutre.Location = New System.Drawing.Point(6, 146)
        Me.lblAutre.Name = "lblAutre"
        Me.lblAutre.Size = New System.Drawing.Size(38, 13)
        Me.lblAutre.TabIndex = 56
        Me.lblAutre.Text = "Autre :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(234, 32)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Ajouter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(252, 188)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 32)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(6, 103)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(64, 13)
        Me.lblTelephone.TabIndex = 55
        Me.lblTelephone.Text = "Téléphone :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(6, 60)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(35, 13)
        Me.lblNom.TabIndex = 54
        Me.lblNom.Text = "Nom :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 17)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(37, 13)
        Me.lblType.TabIndex = 53
        Me.lblType.Text = "Type :"
        '
        'txtAutre
        '
        Me.txtAutre.Location = New System.Drawing.Point(9, 162)
        Me.txtAutre.MaxLength = 255
        Me.txtAutre.Name = "txtAutre"
        Me.txtAutre.Size = New System.Drawing.Size(335, 20)
        Me.txtAutre.TabIndex = 51
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(9, 76)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(335, 20)
        Me.txtNom.TabIndex = 49
        '
        'frmEditerPersonne
        '
        Me.AcceptButton = Me.btnAddType
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(374, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditerPersonne"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Editer une personne..."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddType As Button
    Friend WithEvents mtxtTel As MaskedTextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblAutre As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblType As Label
    Friend WithEvents txtAutre As TextBox
    Friend WithEvents txtNom As TextBox
End Class
