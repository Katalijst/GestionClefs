<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditerClef
    Inherits System.Windows.Forms.Form

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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGrpBatiment = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.btnNewLoc = New System.Windows.Forms.Button()
        Me.lblCNom = New System.Windows.Forms.Label()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnNewTrousseau = New System.Windows.Forms.Button()
        Me.cmbTrousseauListe = New System.Windows.Forms.ComboBox()
        Me.lblCPosition = New System.Windows.Forms.Label()
        Me.lblCStatus = New System.Windows.Forms.Label()
        Me.lblCDate = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCTrousseau = New System.Windows.Forms.Label()
        Me.lblCBatiment = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(206, 228)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 23)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.Location = New System.Drawing.Point(93, 179)
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(168, 20)
        Me.btnGrpBatiment.TabIndex = 26
        Me.btnGrpBatiment.Text = "Batiments"
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGrpBatiment)
        Me.GroupBox1.Controls.Add(Me.lblCID)
        Me.GroupBox1.Controls.Add(Me.btnNewLoc)
        Me.GroupBox1.Controls.Add(Me.lblCNom)
        Me.GroupBox1.Controls.Add(Me.cmbLoc)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.btnNewTrousseau)
        Me.GroupBox1.Controls.Add(Me.cmbTrousseauListe)
        Me.GroupBox1.Controls.Add(Me.lblCPosition)
        Me.GroupBox1.Controls.Add(Me.lblCStatus)
        Me.GroupBox1.Controls.Add(Me.lblCDate)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblCTrousseau)
        Me.GroupBox1.Controls.Add(Me.lblCBatiment)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 210)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité de la clefs"
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Location = New System.Drawing.Point(6, 25)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(24, 13)
        Me.lblCID.TabIndex = 1
        Me.lblCID.Text = "ID :"
        '
        'btnNewLoc
        '
        Me.btnNewLoc.Location = New System.Drawing.Point(267, 73)
        Me.btnNewLoc.Name = "btnNewLoc"
        Me.btnNewLoc.Size = New System.Drawing.Size(23, 23)
        Me.btnNewLoc.TabIndex = 35
        Me.btnNewLoc.Text = "+"
        Me.btnNewLoc.UseVisualStyleBackColor = True
        '
        'lblCNom
        '
        Me.lblCNom.AutoSize = True
        Me.lblCNom.Location = New System.Drawing.Point(6, 51)
        Me.lblCNom.Name = "lblCNom"
        Me.lblCNom.Size = New System.Drawing.Size(35, 13)
        Me.lblCNom.TabIndex = 3
        Me.lblCNom.Text = "Nom :"
        '
        'cmbLoc
        '
        Me.cmbLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(93, 74)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(168, 21)
        Me.cmbLoc.TabIndex = 31
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(93, 126)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(168, 20)
        Me.dtpDate.TabIndex = 12
        '
        'btnNewTrousseau
        '
        Me.btnNewTrousseau.Location = New System.Drawing.Point(267, 151)
        Me.btnNewTrousseau.Name = "btnNewTrousseau"
        Me.btnNewTrousseau.Size = New System.Drawing.Size(23, 23)
        Me.btnNewTrousseau.TabIndex = 26
        Me.btnNewTrousseau.Text = "+"
        Me.btnNewTrousseau.UseVisualStyleBackColor = True
        '
        'cmbTrousseauListe
        '
        Me.cmbTrousseauListe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbTrousseauListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrousseauListe.FormattingEnabled = True
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(93, 152)
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(168, 21)
        Me.cmbTrousseauListe.TabIndex = 27
        '
        'lblCPosition
        '
        Me.lblCPosition.AutoSize = True
        Me.lblCPosition.Location = New System.Drawing.Point(6, 77)
        Me.lblCPosition.Name = "lblCPosition"
        Me.lblCPosition.Size = New System.Drawing.Size(69, 13)
        Me.lblCPosition.TabIndex = 7
        Me.lblCPosition.Text = "Localisation :"
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Location = New System.Drawing.Point(6, 103)
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblCStatus.TabIndex = 8
        Me.lblCStatus.Text = "Status :"
        '
        'lblCDate
        '
        Me.lblCDate.AutoSize = True
        Me.lblCDate.Location = New System.Drawing.Point(6, 129)
        Me.lblCDate.Name = "lblCDate"
        Me.lblCDate.Size = New System.Drawing.Size(70, 13)
        Me.lblCDate.TabIndex = 10
        Me.lblCDate.Text = "Date d'ajout :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(93, 22)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 20)
        Me.txtID.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(93, 103)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 13)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "Disponible"
        '
        'lblCTrousseau
        '
        Me.lblCTrousseau.AutoSize = True
        Me.lblCTrousseau.Location = New System.Drawing.Point(6, 155)
        Me.lblCTrousseau.Name = "lblCTrousseau"
        Me.lblCTrousseau.Size = New System.Drawing.Size(63, 13)
        Me.lblCTrousseau.TabIndex = 11
        Me.lblCTrousseau.Text = "Trousseau :"
        '
        'lblCBatiment
        '
        Me.lblCBatiment.AutoSize = True
        Me.lblCBatiment.Location = New System.Drawing.Point(6, 181)
        Me.lblCBatiment.Name = "lblCBatiment"
        Me.lblCBatiment.Size = New System.Drawing.Size(81, 13)
        Me.lblCBatiment.TabIndex = 15
        Me.lblCBatiment.Text = "Utilisable dans :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(93, 48)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(168, 20)
        Me.txtNom.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(97, 228)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 23)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEditerClef
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(321, 259)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditerClef"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Editer une clef..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGrpBatiment As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCID As Label
    Friend WithEvents btnNewLoc As Button
    Friend WithEvents lblCNom As Label
    Friend WithEvents cmbLoc As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnNewTrousseau As Button
    Friend WithEvents cmbTrousseauListe As ComboBox
    Friend WithEvents lblCPosition As Label
    Friend WithEvents lblCStatus As Label
    Friend WithEvents lblCDate As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCTrousseau As Label
    Friend WithEvents lblCBatiment As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnSave As Button
End Class
