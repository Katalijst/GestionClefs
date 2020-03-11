<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtilisateurChangerService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateurChangerService))
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.cbServices = New MaterialSkin.Controls.MaterialComboBox()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(295, 72)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(41, 36)
        Me.btnValider.TabIndex = 7
        Me.btnValider.Text = "OK"
        Me.btnValider.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnValider.UseAccentColor = False
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'cbServices
        '
        Me.cbServices.AutoResize = False
        Me.cbServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbServices.Depth = 0
        Me.cbServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbServices.DropDownHeight = 118
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.DropDownWidth = 121
        Me.cbServices.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Hint = "Services"
        Me.cbServices.IntegralHeight = False
        Me.cbServices.ItemHeight = 29
        Me.cbServices.Location = New System.Drawing.Point(12, 73)
        Me.cbServices.MaxDropDownItems = 4
        Me.cbServices.MouseState = MaterialSkin.MouseState.OUT
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(276, 35)
        Me.cbServices.TabIndex = 8
        Me.cbServices.UseTallSize = False
        '
        'frmUtilisateurChangerService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 116)
        Me.Controls.Add(Me.cbServices)
        Me.Controls.Add(Me.btnValider)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtilisateurChangerService"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Changer de service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbServices As MaterialSkin.Controls.MaterialComboBox
End Class
