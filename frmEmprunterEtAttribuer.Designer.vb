<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmprunterEtAttribuer
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
        Me.cbPersonnes = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddUser = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'cbPersonnes
        '
        Me.cbPersonnes.AutoResize = False
        Me.cbPersonnes.BackColor = System.Drawing.Color.Black
        Me.cbPersonnes.Depth = 0
        Me.cbPersonnes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbPersonnes.DropDownHeight = 174
        Me.cbPersonnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPersonnes.DropDownWidth = 121
        Me.cbPersonnes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbPersonnes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbPersonnes.FormattingEnabled = True
        Me.cbPersonnes.Hint = "Personne"
        Me.cbPersonnes.IntegralHeight = False
        Me.cbPersonnes.ItemHeight = 43
        Me.cbPersonnes.Location = New System.Drawing.Point(12, 73)
        Me.cbPersonnes.MaxDropDownItems = 4
        Me.cbPersonnes.MouseState = MaterialSkin.MouseState.OUT
        Me.cbPersonnes.Name = "cbPersonnes"
        Me.cbPersonnes.Size = New System.Drawing.Size(315, 49)
        Me.cbPersonnes.TabIndex = 0
        Me.cbPersonnes.UseAccent = False
        '
        'btnValider
        '
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(560, 399)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(80, 36)
        Me.btnValider.TabIndex = 1
        Me.btnValider.Text = "Valider"
        Me.btnValider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnValider.UseAccentColor = False
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddUser.Depth = 0
        Me.btnAddUser.DrawShadows = True
        Me.btnAddUser.HighEmphasis = False
        Me.btnAddUser.Icon = Global.GestionClefs.My.Resources.Resources.add_user_button
        Me.btnAddUser.Location = New System.Drawing.Point(334, 79)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(44, 36)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddUser.UseAccentColor = False
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(-1, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 266)
        Me.Panel1.TabIndex = 3
        '
        'frmEmprunterEtAttribuer
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.cbPersonnes)
        Me.Name = "frmEmprunterEtAttribuer"
        Me.Text = "Emprunter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPersonnes As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
End Class
