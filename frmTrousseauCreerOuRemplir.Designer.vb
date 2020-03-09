<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrousseauCreerOuRemplir
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
        Me.chkAjouter = New MaterialSkin.Controls.MaterialRadioButton()
        Me.chkCreer = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.txtNomTrousseau = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbTrousseaux = New MaterialSkin.Controls.MaterialComboBox()
        Me.SuspendLayout()
        '
        'chkAjouter
        '
        Me.chkAjouter.AutoSize = True
        Me.chkAjouter.Checked = True
        Me.chkAjouter.Depth = 0
        Me.chkAjouter.Location = New System.Drawing.Point(9, 70)
        Me.chkAjouter.Margin = New System.Windows.Forms.Padding(0)
        Me.chkAjouter.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkAjouter.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkAjouter.Name = "chkAjouter"
        Me.chkAjouter.Ripple = True
        Me.chkAjouter.Size = New System.Drawing.Size(194, 37)
        Me.chkAjouter.TabIndex = 0
        Me.chkAjouter.TabStop = True
        Me.chkAjouter.Text = "Ajouter à un trousseau"
        Me.chkAjouter.UseVisualStyleBackColor = True
        '
        'chkCreer
        '
        Me.chkCreer.AutoSize = True
        Me.chkCreer.Depth = 0
        Me.chkCreer.Location = New System.Drawing.Point(209, 70)
        Me.chkCreer.Margin = New System.Windows.Forms.Padding(0)
        Me.chkCreer.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkCreer.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkCreer.Name = "chkCreer"
        Me.chkCreer.Ripple = True
        Me.chkCreer.Size = New System.Drawing.Size(167, 37)
        Me.chkCreer.TabIndex = 1
        Me.chkCreer.TabStop = True
        Me.chkCreer.Text = "Créer un trousseau"
        Me.chkCreer.UseVisualStyleBackColor = True
        '
        'btnValider
        '
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(335, 110)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(41, 36)
        Me.btnValider.TabIndex = 2
        Me.btnValider.Text = "OK"
        Me.btnValider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnValider.UseAccentColor = False
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'txtNomTrousseau
        '
        Me.txtNomTrousseau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomTrousseau.Depth = 0
        Me.txtNomTrousseau.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNomTrousseau.Hint = "Nom du trousseau..."
        Me.txtNomTrousseau.Location = New System.Drawing.Point(12, 110)
        Me.txtNomTrousseau.MaxLength = 255
        Me.txtNomTrousseau.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNomTrousseau.Multiline = False
        Me.txtNomTrousseau.Name = "txtNomTrousseau"
        Me.txtNomTrousseau.Size = New System.Drawing.Size(316, 36)
        Me.txtNomTrousseau.TabIndex = 3
        Me.txtNomTrousseau.Text = ""
        Me.txtNomTrousseau.UseTallSize = False
        '
        'cbTrousseaux
        '
        Me.cbTrousseaux.AutoResize = False
        Me.cbTrousseaux.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTrousseaux.Depth = 0
        Me.cbTrousseaux.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbTrousseaux.DropDownHeight = 118
        Me.cbTrousseaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrousseaux.DropDownWidth = 121
        Me.cbTrousseaux.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbTrousseaux.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbTrousseaux.FormattingEnabled = True
        Me.cbTrousseaux.Hint = "Trousseaux"
        Me.cbTrousseaux.IntegralHeight = False
        Me.cbTrousseaux.ItemHeight = 29
        Me.cbTrousseaux.Location = New System.Drawing.Point(12, 111)
        Me.cbTrousseaux.MaxDropDownItems = 4
        Me.cbTrousseaux.MouseState = MaterialSkin.MouseState.OUT
        Me.cbTrousseaux.Name = "cbTrousseaux"
        Me.cbTrousseaux.Size = New System.Drawing.Size(316, 35)
        Me.cbTrousseaux.TabIndex = 4
        Me.cbTrousseaux.UseTallSize = False
        '
        'frmTrousseauCreerOuRemplir
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 161)
        Me.Controls.Add(Me.cbTrousseaux)
        Me.Controls.Add(Me.txtNomTrousseau)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.chkCreer)
        Me.Controls.Add(Me.chkAjouter)
        Me.Name = "frmTrousseauCreerOuRemplir"
        Me.Text = "Trousseau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkAjouter As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents chkCreer As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtNomTrousseau As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbTrousseaux As MaterialSkin.Controls.MaterialComboBox
End Class
