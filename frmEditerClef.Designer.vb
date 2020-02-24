<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditerClef
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGrpBatiment = New System.Windows.Forms.Button()
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
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialTextBox3 = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialComboBox2 = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(205, 289)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 23)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGrpBatiment
        '
        Me.btnGrpBatiment.Location = New System.Drawing.Point(104, 232)
        Me.btnGrpBatiment.Name = "btnGrpBatiment"
        Me.btnGrpBatiment.Size = New System.Drawing.Size(168, 20)
        Me.btnGrpBatiment.TabIndex = 26
        Me.btnGrpBatiment.Text = "Batiments"
        Me.btnGrpBatiment.UseVisualStyleBackColor = True
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Location = New System.Drawing.Point(17, 78)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(24, 13)
        Me.lblCID.TabIndex = 1
        Me.lblCID.Text = "ID :"
        '
        'btnNewLoc
        '
        Me.btnNewLoc.Location = New System.Drawing.Point(278, 126)
        Me.btnNewLoc.Name = "btnNewLoc"
        Me.btnNewLoc.Size = New System.Drawing.Size(23, 23)
        Me.btnNewLoc.TabIndex = 35
        Me.btnNewLoc.Text = "+"
        Me.btnNewLoc.UseVisualStyleBackColor = True
        '
        'lblCNom
        '
        Me.lblCNom.AutoSize = True
        Me.lblCNom.Location = New System.Drawing.Point(17, 104)
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
        Me.cmbLoc.Location = New System.Drawing.Point(104, 127)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(168, 21)
        Me.cmbLoc.TabIndex = 31
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(104, 179)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(168, 20)
        Me.dtpDate.TabIndex = 12
        '
        'btnNewTrousseau
        '
        Me.btnNewTrousseau.Location = New System.Drawing.Point(278, 204)
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
        Me.cmbTrousseauListe.Location = New System.Drawing.Point(104, 205)
        Me.cmbTrousseauListe.Name = "cmbTrousseauListe"
        Me.cmbTrousseauListe.Size = New System.Drawing.Size(168, 21)
        Me.cmbTrousseauListe.TabIndex = 27
        '
        'lblCPosition
        '
        Me.lblCPosition.AutoSize = True
        Me.lblCPosition.Location = New System.Drawing.Point(17, 130)
        Me.lblCPosition.Name = "lblCPosition"
        Me.lblCPosition.Size = New System.Drawing.Size(69, 13)
        Me.lblCPosition.TabIndex = 7
        Me.lblCPosition.Text = "Localisation :"
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Location = New System.Drawing.Point(17, 156)
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblCStatus.TabIndex = 8
        Me.lblCStatus.Text = "Status :"
        '
        'lblCDate
        '
        Me.lblCDate.AutoSize = True
        Me.lblCDate.Location = New System.Drawing.Point(17, 182)
        Me.lblCDate.Name = "lblCDate"
        Me.lblCDate.Size = New System.Drawing.Size(70, 13)
        Me.lblCDate.TabIndex = 10
        Me.lblCDate.Text = "Date d'ajout :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(104, 75)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 20)
        Me.txtID.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(104, 156)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 13)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "Disponible"
        '
        'lblCTrousseau
        '
        Me.lblCTrousseau.AutoSize = True
        Me.lblCTrousseau.Location = New System.Drawing.Point(17, 208)
        Me.lblCTrousseau.Name = "lblCTrousseau"
        Me.lblCTrousseau.Size = New System.Drawing.Size(63, 13)
        Me.lblCTrousseau.TabIndex = 11
        Me.lblCTrousseau.Text = "Trousseau :"
        '
        'lblCBatiment
        '
        Me.lblCBatiment.AutoSize = True
        Me.lblCBatiment.Location = New System.Drawing.Point(17, 234)
        Me.lblCBatiment.Name = "lblCBatiment"
        Me.lblCBatiment.Size = New System.Drawing.Size(81, 13)
        Me.lblCBatiment.TabIndex = 15
        Me.lblCBatiment.Text = "Utilisable dans :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(104, 101)
        Me.txtNom.MaxLength = 255
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(168, 20)
        Me.txtNom.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(96, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 23)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.DrawShadows = True
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(20, 334)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.Size = New System.Drawing.Size(117, 36)
        Me.MaterialButton1.TabIndex = 30
        Me.MaterialButton1.Text = "Enregistrer"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.DrawShadows = True
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(155, 334)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.Size = New System.Drawing.Size(87, 36)
        Me.MaterialButton2.TabIndex = 31
        Me.MaterialButton2.Text = "Annuler"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(366, 75)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel1.TabIndex = 36
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(399, 130)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel2.TabIndex = 37
        Me.MaterialLabel2.Text = "MaterialLabel2"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(414, 232)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel3.TabIndex = 38
        Me.MaterialLabel3.Text = "MaterialLabel3"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(378, 277)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel4.TabIndex = 39
        Me.MaterialLabel4.Text = "MaterialLabel4"
        '
        'MaterialTextBox1
        '
        Me.MaterialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox1.Depth = 0
        Me.MaterialTextBox1.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialTextBox1.Location = New System.Drawing.Point(559, 73)
        Me.MaterialTextBox1.MaxLength = 50
        Me.MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox1.Multiline = False
        Me.MaterialTextBox1.Name = "MaterialTextBox1"
        Me.MaterialTextBox1.Size = New System.Drawing.Size(100, 36)
        Me.MaterialTextBox1.TabIndex = 40
        Me.MaterialTextBox1.Text = ""
        Me.MaterialTextBox1.UseTallSize = False
        '
        'MaterialTextBox2
        '
        Me.MaterialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox2.Depth = 0
        Me.MaterialTextBox2.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialTextBox2.Location = New System.Drawing.Point(559, 115)
        Me.MaterialTextBox2.MaxLength = 50
        Me.MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox2.Multiline = False
        Me.MaterialTextBox2.Name = "MaterialTextBox2"
        Me.MaterialTextBox2.Size = New System.Drawing.Size(100, 36)
        Me.MaterialTextBox2.TabIndex = 41
        Me.MaterialTextBox2.Text = ""
        Me.MaterialTextBox2.UseTallSize = False
        '
        'MaterialComboBox1
        '
        Me.MaterialComboBox1.AutoResize = False
        Me.MaterialComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBox1.Depth = 0
        Me.MaterialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBox1.DropDownHeight = 118
        Me.MaterialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox1.DropDownWidth = 121
        Me.MaterialComboBox1.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBox1.FormattingEnabled = True
        Me.MaterialComboBox1.IntegralHeight = False
        Me.MaterialComboBox1.ItemHeight = 29
        Me.MaterialComboBox1.Location = New System.Drawing.Point(559, 157)
        Me.MaterialComboBox1.MaxDropDownItems = 4
        Me.MaterialComboBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox1.Name = "MaterialComboBox1"
        Me.MaterialComboBox1.Size = New System.Drawing.Size(121, 35)
        Me.MaterialComboBox1.TabIndex = 42
        Me.MaterialComboBox1.UseTallSize = False
        '
        'MaterialTextBox3
        '
        Me.MaterialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox3.Depth = 0
        Me.MaterialTextBox3.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.MaterialTextBox3.Location = New System.Drawing.Point(559, 198)
        Me.MaterialTextBox3.MaxLength = 50
        Me.MaterialTextBox3.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox3.Multiline = False
        Me.MaterialTextBox3.Name = "MaterialTextBox3"
        Me.MaterialTextBox3.Size = New System.Drawing.Size(100, 36)
        Me.MaterialTextBox3.TabIndex = 43
        Me.MaterialTextBox3.Text = ""
        Me.MaterialTextBox3.UseTallSize = False
        '
        'MaterialComboBox2
        '
        Me.MaterialComboBox2.AutoResize = False
        Me.MaterialComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBox2.Depth = 0
        Me.MaterialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBox2.DropDownHeight = 118
        Me.MaterialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox2.DropDownWidth = 121
        Me.MaterialComboBox2.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBox2.FormattingEnabled = True
        Me.MaterialComboBox2.IntegralHeight = False
        Me.MaterialComboBox2.ItemHeight = 29
        Me.MaterialComboBox2.Location = New System.Drawing.Point(559, 240)
        Me.MaterialComboBox2.MaxDropDownItems = 4
        Me.MaterialComboBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox2.Name = "MaterialComboBox2"
        Me.MaterialComboBox2.Size = New System.Drawing.Size(121, 35)
        Me.MaterialComboBox2.TabIndex = 44
        Me.MaterialComboBox2.UseTallSize = False
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.DrawShadows = True
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Nothing
        Me.MaterialButton3.Location = New System.Drawing.Point(499, 317)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.Size = New System.Drawing.Size(117, 36)
        Me.MaterialButton3.TabIndex = 45
        Me.MaterialButton3.Text = "Enregistrer"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'frmEditerClef
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(701, 397)
        Me.Controls.Add(Me.MaterialButton3)
        Me.Controls.Add(Me.MaterialComboBox2)
        Me.Controls.Add(Me.MaterialTextBox3)
        Me.Controls.Add(Me.MaterialComboBox1)
        Me.Controls.Add(Me.MaterialTextBox2)
        Me.Controls.Add(Me.MaterialTextBox1)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.btnGrpBatiment)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.lblCID)
        Me.Controls.Add(Me.btnNewLoc)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.lblCNom)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnNewTrousseau)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.cmbTrousseauListe)
        Me.Controls.Add(Me.lblCBatiment)
        Me.Controls.Add(Me.lblCPosition)
        Me.Controls.Add(Me.lblCTrousseau)
        Me.Controls.Add(Me.lblCStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblCDate)
        Me.Controls.Add(Me.txtID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditerClef"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Editer une clef..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGrpBatiment As Button
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
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialTextBox3 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialComboBox2 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
End Class
