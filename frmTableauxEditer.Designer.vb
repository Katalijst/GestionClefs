﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableauxEditer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableauxEditer))
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.btnAddPersonne = New MaterialSkin.Controls.MaterialButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.txtNom = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblPBatiment = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPNom = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPResponsable = New MaterialSkin.Controls.MaterialLabel()
        Me.cbResponsable = New MaterialSkin.Controls.MaterialComboBox()
        Me.cbBatiments = New MaterialSkin.Controls.MaterialComboBox()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 253)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(330, 1)
        Me.MaterialDivider1.TabIndex = 87
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'btnAddPersonne
        '
        Me.btnAddPersonne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddPersonne.Depth = 0
        Me.btnAddPersonne.DrawShadows = True
        Me.btnAddPersonne.HighEmphasis = True
        Me.btnAddPersonne.Icon = Global.GestionClefs.My.Resources.Resources.plus
        Me.btnAddPersonne.Location = New System.Drawing.Point(295, 90)
        Me.btnAddPersonne.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddPersonne.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddPersonne.Name = "btnAddPersonne"
        Me.btnAddPersonne.Size = New System.Drawing.Size(44, 36)
        Me.btnAddPersonne.TabIndex = 86
        Me.btnAddPersonne.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnAddPersonne.UseAccentColor = False
        Me.btnAddPersonne.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.DrawShadows = True
        Me.btnCancel.HighEmphasis = True
        Me.btnCancel.Icon = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(12, 263)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 85
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCancel.UseAccentColor = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.DrawShadows = True
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(225, 263)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 36)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Depth = 0
        Me.txtNom.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtNom.Location = New System.Drawing.Point(15, 151)
        Me.txtNom.MaxLength = 255
        Me.txtNom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNom.Multiline = False
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(324, 36)
        Me.txtNom.TabIndex = 82
        Me.txtNom.Text = ""
        Me.txtNom.UseTallSize = False
        '
        'lblPBatiment
        '
        Me.lblPBatiment.AutoSize = True
        Me.lblPBatiment.Depth = 0
        Me.lblPBatiment.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPBatiment.Location = New System.Drawing.Point(12, 190)
        Me.lblPBatiment.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPBatiment.Name = "lblPBatiment"
        Me.lblPBatiment.Size = New System.Drawing.Size(73, 19)
        Me.lblPBatiment.TabIndex = 79
        Me.lblPBatiment.Text = "Bâtiment :"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Depth = 0
        Me.lblPNom.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPNom.Location = New System.Drawing.Point(12, 129)
        Me.lblPNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(43, 19)
        Me.lblPNom.TabIndex = 78
        Me.lblPNom.Text = "Nom :"
        '
        'lblPResponsable
        '
        Me.lblPResponsable.AutoSize = True
        Me.lblPResponsable.Depth = 0
        Me.lblPResponsable.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPResponsable.Location = New System.Drawing.Point(12, 69)
        Me.lblPResponsable.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPResponsable.Name = "lblPResponsable"
        Me.lblPResponsable.Size = New System.Drawing.Size(100, 19)
        Me.lblPResponsable.TabIndex = 77
        Me.lblPResponsable.Text = "Responsable :"
        '
        'cbResponsable
        '
        Me.cbResponsable.AutoResize = False
        Me.cbResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbResponsable.Depth = 0
        Me.cbResponsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbResponsable.DropDownHeight = 118
        Me.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResponsable.DropDownWidth = 121
        Me.cbResponsable.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbResponsable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbResponsable.FormattingEnabled = True
        Me.cbResponsable.IntegralHeight = False
        Me.cbResponsable.ItemHeight = 29
        Me.cbResponsable.Location = New System.Drawing.Point(15, 91)
        Me.cbResponsable.MaxDropDownItems = 4
        Me.cbResponsable.MouseState = MaterialSkin.MouseState.OUT
        Me.cbResponsable.Name = "cbResponsable"
        Me.cbResponsable.Size = New System.Drawing.Size(273, 35)
        Me.cbResponsable.TabIndex = 76
        Me.cbResponsable.UseTallSize = False
        '
        'cbBatiments
        '
        Me.cbBatiments.AutoResize = False
        Me.cbBatiments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBatiments.Depth = 0
        Me.cbBatiments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbBatiments.DropDownHeight = 118
        Me.cbBatiments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBatiments.DropDownWidth = 121
        Me.cbBatiments.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbBatiments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbBatiments.FormattingEnabled = True
        Me.cbBatiments.IntegralHeight = False
        Me.cbBatiments.ItemHeight = 29
        Me.cbBatiments.Location = New System.Drawing.Point(15, 212)
        Me.cbBatiments.MaxDropDownItems = 4
        Me.cbBatiments.MouseState = MaterialSkin.MouseState.OUT
        Me.cbBatiments.Name = "cbBatiments"
        Me.cbBatiments.Size = New System.Drawing.Size(324, 35)
        Me.cbBatiments.TabIndex = 88
        Me.cbBatiments.UseTallSize = False
        '
        'frmTableauxEditer
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(354, 314)
        Me.Controls.Add(Me.cbBatiments)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.btnAddPersonne)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblPBatiment)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.lblPResponsable)
        Me.Controls.Add(Me.cbResponsable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableauxEditer"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.Text = "Editer un tableau..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnAddPersonne As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtNom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lblPBatiment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPNom As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPResponsable As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbResponsable As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cbBatiments As MaterialSkin.Controls.MaterialComboBox
End Class
