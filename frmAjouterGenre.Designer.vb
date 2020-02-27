<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjouterGenre
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
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGenre
        '
        Me.lblGenre.Location = New System.Drawing.Point(12, 9)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(160, 13)
        Me.lblGenre.TabIndex = 5
        Me.lblGenre.Text = "Type de personne"
        Me.lblGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(12, 51)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(160, 23)
        Me.btnValider.TabIndex = 4
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(12, 25)
        Me.txtType.MaxLength = 255
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(160, 20)
        Me.txtType.TabIndex = 3
        '
        'frmAjouterGenre
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 81)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjouterGenre"
        Me.ShowIcon = False
        Me.Text = "Ajouter un type..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGenre As Label
    Friend WithEvents btnValider As Button
    Friend WithEvents txtType As TextBox
End Class
