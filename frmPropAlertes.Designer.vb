<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropAlertes
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtAutres = New System.Windows.Forms.TextBox()
        Me.lblDateFin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPersonne = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDateDebut = New System.Windows.Forms.Label()
        Me.lblTitleDateDebut = New System.Windows.Forms.Label()
        Me.lblTitleDateFin = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.gbEmprunt = New System.Windows.Forms.GroupBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNbClef = New System.Windows.Forms.Label()
        Me.btnGrpBatiment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBatiment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTrousseau = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDateAjout = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnOK.Location = New System.Drawing.Point(407, 265)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Personne :"
        '
        'lblPersonne
        '
        Me.lblPersonne.AutoSize = True
        Me.lblPersonne.Location = New System.Drawing.Point(93, 34)
        Me.lblPersonne.Name = "lblPersonne"
        Me.lblPersonne.Size = New System.Drawing.Size(0, 13)
        Me.lblPersonne.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Téléphone :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Autres informations :"
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Location = New System.Drawing.Point(93, 94)
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(0, 13)
        Me.lblDateDebut.TabIndex = 19
        '
        'lblTitleDateDebut
        '
        Me.lblTitleDateDebut.AutoSize = True
        Me.lblTitleDateDebut.Location = New System.Drawing.Point(6, 94)
        Me.lblTitleDateDebut.Name = "lblTitleDateDebut"
        Me.lblTitleDateDebut.Size = New System.Drawing.Size(85, 13)
        Me.lblTitleDateDebut.TabIndex = 10
        Me.lblTitleDateDebut.Text = "Date d'emprunt :"
        '
        'lblTitleDateFin
        '
        Me.lblTitleDateFin.AutoSize = True
        Me.lblTitleDateFin.Location = New System.Drawing.Point(7, 120)
        Me.lblTitleDateFin.Name = "lblTitleDateFin"
        Me.lblTitleDateFin.Size = New System.Drawing.Size(84, 13)
        Me.lblTitleDateFin.TabIndex = 11
        Me.lblTitleDateFin.Text = "Date de remise :"
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
        Me.gbEmprunt.Controls.Add(Me.txtAutres)
        Me.gbEmprunt.Controls.Add(Me.lblDateFin)
        Me.gbEmprunt.Controls.Add(Me.Label5)
        Me.gbEmprunt.Controls.Add(Me.lblPersonne)
        Me.gbEmprunt.Controls.Add(Me.Label12)
        Me.gbEmprunt.Controls.Add(Me.Label14)
        Me.gbEmprunt.Controls.Add(Me.lblDateDebut)
        Me.gbEmprunt.Controls.Add(Me.lblTitleDateDebut)
        Me.gbEmprunt.Controls.Add(Me.lblTitleDateFin)
        Me.gbEmprunt.Controls.Add(Me.lblTel)
        Me.gbEmprunt.Controls.Add(Me.lblGenre)
        Me.gbEmprunt.Location = New System.Drawing.Point(288, 12)
        Me.gbEmprunt.Name = "gbEmprunt"
        Me.gbEmprunt.Size = New System.Drawing.Size(222, 247)
        Me.gbEmprunt.TabIndex = 27
        Me.gbEmprunt.TabStop = False
        Me.gbEmprunt.Text = "Emprunter/Attribuer"
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
        Me.GroupBox1.Controls.Add(Me.btnGrpBatiment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblBatiment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTrousseau)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDateAjout)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblLoc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
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
        Me.Label9.TabIndex = 27
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
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.Location = New System.Drawing.Point(93, 229)
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(122, 23)
        Me.btnGrpBatiment.TabIndex = 26
        Me.btnGrpBatiment.Text = "Groupe de batiments"
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID :"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom :"
        '
        'lblBatiment
        '
        Me.lblBatiment.Location = New System.Drawing.Point(93, 234)
        Me.lblBatiment.Name = "lblBatiment"
        Me.lblBatiment.Size = New System.Drawing.Size(122, 39)
        Me.lblBatiment.TabIndex = 21
        Me.lblBatiment.Text = "Groupe de Batiment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Localisation :"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status :"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Date d'ajout :"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Trousseau :"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Utilisable dans :"
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
        Me.ClientSize = New System.Drawing.Size(521, 300)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.gbEmprunt)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPropAlertes"
        Me.ShowInTaskbar = False
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
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPersonne As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblTitleDateDebut As Label
    Friend WithEvents lblTitleDateFin As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents gbEmprunt As GroupBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNbClef As Label
    Friend WithEvents btnGrpBatiment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBatiment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTrousseau As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDateAjout As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
