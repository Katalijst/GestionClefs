<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFonctionAjout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFonctionAjout))
        Me.lblGenre = New MaterialSkin.Controls.MaterialLabel()
        Me.txtType = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Depth = 0
        Me.lblGenre.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblGenre.Location = New System.Drawing.Point(12, 75)
        Me.lblGenre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(143, 19)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Ajout d'une fonction"
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtType.Depth = 0
        Me.txtType.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtType.Hint = "Fonction"
        Me.txtType.Location = New System.Drawing.Point(12, 97)
        Me.txtType.MaxLength = 255
        Me.txtType.MouseState = MaterialSkin.MouseState.OUT
        Me.txtType.Multiline = False
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(206, 36)
        Me.txtType.TabIndex = 7
        Me.txtType.Text = ""
        Me.txtType.UseTallSize = False
        '
        'btnValider
        '
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(75, 142)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(80, 36)
        Me.btnValider.TabIndex = 8
        Me.btnValider.Text = "Valider"
        Me.btnValider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnValider.UseAccentColor = False
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'frmFonctionAjout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 188)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lblGenre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFonctionAjout"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.Text = "Ajouter un type..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGenre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtType As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
End Class
