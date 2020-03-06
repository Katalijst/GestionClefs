<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatimentsEditer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatimentsEditer))
        Me.txtID = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblID = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNom = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblAdresse = New MaterialSkin.Controls.MaterialLabel()
        Me.txtAdresse = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblFonction = New MaterialSkin.Controls.MaterialLabel()
        Me.txtFonction = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Depth = 0
        Me.txtID.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(15, 92)
        Me.txtID.MaxLength = 20
        Me.txtID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 36)
        Me.txtID.TabIndex = 61
        Me.txtID.Text = ""
        Me.txtID.UseTallSize = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Depth = 0
        Me.lblID.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblID.Location = New System.Drawing.Point(12, 70)
        Me.lblID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 19)
        Me.lblID.TabIndex = 65
        Me.lblID.Text = "N° :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Depth = 0
        Me.lblNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNom.Location = New System.Drawing.Point(12, 131)
        Me.lblNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(109, 19)
        Me.lblNom.TabIndex = 67
        Me.lblNom.Text = "Dénomination :"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(15, 153)
        Me.txtNom.MaxLength = 255
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(323, 36)
        Me.txtNom.TabIndex = 66
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Depth = 0
        Me.lblAdresse.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAdresse.Location = New System.Drawing.Point(12, 192)
        Me.lblAdresse.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(65, 19)
        Me.lblAdresse.TabIndex = 69
        Me.lblAdresse.Text = "Adresse :"
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdresse.Depth = 0
        Me.txtAdresse.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtAdresse.Location = New System.Drawing.Point(15, 214)
        Me.txtAdresse.MaxLength = 255
        Me.txtAdresse.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAdresse.Multiline = False
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(323, 36)
        Me.txtAdresse.TabIndex = 68
        Me.txtAdresse.Text = ""
        Me.txtAdresse.UseTallSize = False
        '
        'lblFonction
        '
        Me.lblFonction.AutoSize = True
        Me.lblFonction.Depth = 0
        Me.lblFonction.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblFonction.Location = New System.Drawing.Point(12, 253)
        Me.lblFonction.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFonction.Name = "lblFonction"
        Me.lblFonction.Size = New System.Drawing.Size(71, 19)
        Me.lblFonction.TabIndex = 71
        Me.lblFonction.Text = "Fonction :"
        '
        'txtFonction
        '
        Me.txtFonction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFonction.Depth = 0
        Me.txtFonction.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtFonction.Location = New System.Drawing.Point(15, 275)
        Me.txtFonction.MaxLength = 255
        Me.txtFonction.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFonction.Multiline = False
        Me.txtFonction.Name = "txtFonction"
        Me.txtFonction.Size = New System.Drawing.Size(323, 36)
        Me.txtFonction.TabIndex = 70
        Me.txtFonction.Text = ""
        Me.txtFonction.UseTallSize = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(222, 327)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 73
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 317)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(328, 1)
        Me.MaterialDivider1.TabIndex = 74
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.DrawShadows = True
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(13, 327)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 72
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmBatimentsEditer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 372)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblFonction)
        Me.Controls.Add(Me.txtFonction)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBatimentsEditer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Editer un batiment..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblAdresse As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtAdresse As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblFonction As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtFonction As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
End Class
