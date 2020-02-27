<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropAlertes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPropAlertes))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtAutres = New System.Windows.Forms.TextBox()
        Me.lblDateFin = New System.Windows.Forms.Label()
        Me.lblPersonne = New System.Windows.Forms.Label()
        Me.lblDateDebut = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.gbEmprunt = New System.Windows.Forms.GroupBox()
        Me.lblENomPersonne = New System.Windows.Forms.Label()
        Me.lblNTelephone = New System.Windows.Forms.Label()
        Me.lblNAutre = New System.Windows.Forms.Label()
        Me.lblTitleDateDebut = New System.Windows.Forms.Label()
        Me.lblTitleDateFin = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNbClef = New System.Windows.Forms.Label()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.lblCNom = New System.Windows.Forms.Label()
        Me.btnGrpBatiment = New System.Windows.Forms.Button()
        Me.lblCPosition = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblCStatus = New System.Windows.Forms.Label()
        Me.lblBatiment = New System.Windows.Forms.Label()
        Me.lblCDate = New System.Windows.Forms.Label()
        Me.lblTrousseau = New System.Windows.Forms.Label()
        Me.lblCTrousseau = New System.Windows.Forms.Label()
        Me.lblDateAjout = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbEmprunt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(407, 325)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 23)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtAutres
        '
        Me.txtAutres.Enabled = False
        Me.txtAutres.Location = New System.Drawing.Point(7, 163)
        Me.txtAutres.Multiline = True
        Me.txtAutres.Name = "txtAutres"
        Me.txtAutres.Size = New System.Drawing.Size(208, 35)
        Me.txtAutres.TabIndex = 24
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Location = New System.Drawing.Point(94, 120)
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(0, 13)
        Me.lblDateFin.TabIndex = 23
        '
        'lblPersonne
        '
        Me.lblPersonne.AutoSize = True
        Me.lblPersonne.Location = New System.Drawing.Point(93, 34)
        Me.lblPersonne.Name = "lblPersonne"
        Me.lblPersonne.Size = New System.Drawing.Size(0, 13)
        Me.lblPersonne.TabIndex = 22
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Location = New System.Drawing.Point(93, 94)
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(0, 13)
        Me.lblDateDebut.TabIndex = 19
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(93, 68)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(0, 13)
        Me.lblTel.TabIndex = 17
        '
        'gbEmprunt
        '
        Me.gbEmprunt.Controls.Add(Me.lblENomPersonne)
        Me.gbEmprunt.Controls.Add(Me.lblNTelephone)
        Me.gbEmprunt.Controls.Add(Me.txtAutres)
        Me.gbEmprunt.Controls.Add(Me.lblNAutre)
        Me.gbEmprunt.Controls.Add(Me.lblDateFin)
        Me.gbEmprunt.Controls.Add(Me.lblTitleDateDebut)
        Me.gbEmprunt.Controls.Add(Me.lblPersonne)
        Me.gbEmprunt.Controls.Add(Me.lblTitleDateFin)
        Me.gbEmprunt.Controls.Add(Me.lblDateDebut)
        Me.gbEmprunt.Controls.Add(Me.lblTel)
        Me.gbEmprunt.Controls.Add(Me.lblGenre)
        Me.gbEmprunt.Location = New System.Drawing.Point(288, 72)
        Me.gbEmprunt.Name = "gbEmprunt"
        Me.gbEmprunt.Size = New System.Drawing.Size(222, 247)
        Me.gbEmprunt.TabIndex = 27
        Me.gbEmprunt.TabStop = False
        Me.gbEmprunt.Text = "Emprunter/Attribuer"
        '
        'lblENomPersonne
        '
        Me.lblENomPersonne.AutoSize = True
        Me.lblENomPersonne.Location = New System.Drawing.Point(6, 16)
        Me.lblENomPersonne.Name = "lblENomPersonne"
        Me.lblENomPersonne.Size = New System.Drawing.Size(58, 13)
        Me.lblENomPersonne.TabIndex = 29
        Me.lblENomPersonne.Text = "Personne :"
        '
        'lblNTelephone
        '
        Me.lblNTelephone.AutoSize = True
        Me.lblNTelephone.Location = New System.Drawing.Point(6, 68)
        Me.lblNTelephone.Name = "lblNTelephone"
        Me.lblNTelephone.Size = New System.Drawing.Size(64, 13)
        Me.lblNTelephone.TabIndex = 30
        Me.lblNTelephone.Text = "Téléphone :"
        '
        'lblNAutre
        '
        Me.lblNAutre.AutoSize = True
        Me.lblNAutre.Location = New System.Drawing.Point(7, 146)
        Me.lblNAutre.Name = "lblNAutre"
        Me.lblNAutre.Size = New System.Drawing.Size(102, 13)
        Me.lblNAutre.TabIndex = 31
        Me.lblNAutre.Text = "Autres informations :"
        '
        'lblTitleDateDebut
        '
        Me.lblTitleDateDebut.AutoSize = True
        Me.lblTitleDateDebut.Location = New System.Drawing.Point(6, 94)
        Me.lblTitleDateDebut.Name = "lblTitleDateDebut"
        Me.lblTitleDateDebut.Size = New System.Drawing.Size(85, 13)
        Me.lblTitleDateDebut.TabIndex = 32
        Me.lblTitleDateDebut.Text = "Date d'emprunt :"
        '
        'lblTitleDateFin
        '
        Me.lblTitleDateFin.AutoSize = True
        Me.lblTitleDateFin.Location = New System.Drawing.Point(7, 120)
        Me.lblTitleDateFin.Name = "lblTitleDateFin"
        Me.lblTitleDateFin.Size = New System.Drawing.Size(81, 13)
        Me.lblTitleDateFin.TabIndex = 33
        Me.lblTitleDateFin.Text = "Date de retour :"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(93, 16)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(0, 13)
        Me.lblGenre.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblNbClef)
        Me.GroupBox1.Controls.Add(Me.lblCID)
        Me.GroupBox1.Controls.Add(Me.lblCNom)
        Me.GroupBox1.Controls.Add(Me.btnGrpBatiment)
        Me.GroupBox1.Controls.Add(Me.lblCPosition)
        Me.GroupBox1.Controls.Add(Me.lblNom)
        Me.GroupBox1.Controls.Add(Me.lblCStatus)
        Me.GroupBox1.Controls.Add(Me.lblBatiment)
        Me.GroupBox1.Controls.Add(Me.lblCDate)
        Me.GroupBox1.Controls.Add(Me.lblTrousseau)
        Me.GroupBox1.Controls.Add(Me.lblCTrousseau)
        Me.GroupBox1.Controls.Add(Me.lblDateAjout)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblLoc)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 276)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité de la clefs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Quantité :"
        '
        'lblNbClef
        '
        Me.lblNbClef.Location = New System.Drawing.Point(93, 68)
        Me.lblNbClef.Name = "lblNbClef"
        Me.lblNbClef.Size = New System.Drawing.Size(171, 62)
        Me.lblNbClef.TabIndex = 28
        Me.lblNbClef.Text = "x exemplaires disponibles"
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Location = New System.Drawing.Point(6, 16)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(24, 13)
        Me.lblCID.TabIndex = 29
        Me.lblCID.Text = "ID :"
        '
        'lblCNom
        '
        Me.lblCNom.AutoSize = True
        Me.lblCNom.Location = New System.Drawing.Point(6, 42)
        Me.lblCNom.Name = "lblCNom"
        Me.lblCNom.Size = New System.Drawing.Size(35, 13)
        Me.lblCNom.TabIndex = 30
        Me.lblCNom.Text = "Nom :"
        '
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.Location = New System.Drawing.Point(93, 229)
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(122, 23)
        Me.btnGrpBatiment.TabIndex = 26
        Me.btnGrpBatiment.Text = "Groupe de batiments"
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'lblCPosition
        '
        Me.lblCPosition.AutoSize = True
        Me.lblCPosition.Location = New System.Drawing.Point(6, 130)
        Me.lblCPosition.Name = "lblCPosition"
        Me.lblCPosition.Size = New System.Drawing.Size(69, 13)
        Me.lblCPosition.TabIndex = 31
        Me.lblCPosition.Text = "Localisation :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(93, 42)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(75, 13)
        Me.lblNom.TabIndex = 22
        Me.lblNom.Text = "Nom de la clef"
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Location = New System.Drawing.Point(6, 156)
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblCStatus.TabIndex = 32
        Me.lblCStatus.Text = "Status :"
        '
        'lblBatiment
        '
        Me.lblBatiment.Location = New System.Drawing.Point(93, 234)
        Me.lblBatiment.Name = "lblBatiment"
        Me.lblBatiment.Size = New System.Drawing.Size(122, 39)
        Me.lblBatiment.TabIndex = 21
        Me.lblBatiment.Text = "Groupe de Batiment"
        '
        'lblCDate
        '
        Me.lblCDate.AutoSize = True
        Me.lblCDate.Location = New System.Drawing.Point(6, 182)
        Me.lblCDate.Name = "lblCDate"
        Me.lblCDate.Size = New System.Drawing.Size(70, 13)
        Me.lblCDate.TabIndex = 33
        Me.lblCDate.Text = "Date d'ajout :"
        '
        'lblTrousseau
        '
        Me.lblTrousseau.AutoSize = True
        Me.lblTrousseau.Location = New System.Drawing.Point(93, 208)
        Me.lblTrousseau.Name = "lblTrousseau"
        Me.lblTrousseau.Size = New System.Drawing.Size(38, 13)
        Me.lblTrousseau.TabIndex = 20
        Me.lblTrousseau.Text = "Aucun"
        '
        'lblCTrousseau
        '
        Me.lblCTrousseau.AutoSize = True
        Me.lblCTrousseau.Location = New System.Drawing.Point(6, 208)
        Me.lblCTrousseau.Name = "lblCTrousseau"
        Me.lblCTrousseau.Size = New System.Drawing.Size(63, 13)
        Me.lblCTrousseau.TabIndex = 34
        Me.lblCTrousseau.Text = "Trousseau :"
        '
        'lblDateAjout
        '
        Me.lblDateAjout.AutoSize = True
        Me.lblDateAjout.Location = New System.Drawing.Point(93, 182)
        Me.lblDateAjout.Name = "lblDateAjout"
        Me.lblDateAjout.Size = New System.Drawing.Size(65, 13)
        Me.lblDateAjout.TabIndex = 19
        Me.lblDateAjout.Text = "25/12/2019"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Utilisable dans :"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(93, 156)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 13)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "Disponible"
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Location = New System.Drawing.Point(93, 130)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(97, 13)
        Me.lblLoc.TabIndex = 17
        Me.lblLoc.Text = "Tableaux de la clef"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(93, 16)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "IDKEY"
        '
        'frmPropAlertes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 360)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.gbEmprunt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPropAlertes"
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Propriétés de :"
        Me.gbEmprunt.ResumeLayout(False)
        Me.gbEmprunt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents txtAutres As TextBox
    Friend WithEvents lblDateFin As Label
    Friend WithEvents lblPersonne As Label
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents gbEmprunt As GroupBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNbClef As Label
    Friend WithEvents btnGrpBatiment As Button
    Friend WithEvents lblNom As Label
    Friend WithEvents lblBatiment As Label
    Friend WithEvents lblTrousseau As Label
    Friend WithEvents lblDateAjout As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents lblID As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCID As Label
    Friend WithEvents lblCNom As Label
    Friend WithEvents lblCPosition As Label
    Friend WithEvents lblCStatus As Label
    Friend WithEvents lblCDate As Label
    Friend WithEvents lblCTrousseau As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblENomPersonne As Label
    Friend WithEvents lblNTelephone As Label
    Friend WithEvents lblNAutre As Label
    Friend WithEvents lblTitleDateDebut As Label
    Friend WithEvents lblTitleDateFin As Label
End Class
