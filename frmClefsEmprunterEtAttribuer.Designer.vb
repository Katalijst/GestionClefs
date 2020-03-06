<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClefsEmprunterEtAttribuer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClefsEmprunterEtAttribuer))
        Me.cbPersonnes = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnValider = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddUser = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtDebutGlobal = New System.Windows.Forms.DateTimePicker()
        Me.dtFinGlobal = New System.Windows.Forms.DateTimePicker()
        Me.swtReglageIndividuelle = New MaterialSkin.Controls.MaterialSwitch()
        Me.lblNumClefs = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateDebut = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDateFin = New MaterialSkin.Controls.MaterialLabel()
        Me.chkPrint = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialFloatingActionButton1 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.lblNombreDeClef = New MaterialSkin.Controls.MaterialLabel()
        Me.btnSearchPeople = New MaterialSkin.Controls.MaterialButton()
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
        Me.cbPersonnes.TabIndex = 1
        '
        'btnValider
        '
        Me.btnValider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnValider.Depth = 0
        Me.btnValider.DrawShadows = True
        Me.btnValider.HighEmphasis = True
        Me.btnValider.Icon = Nothing
        Me.btnValider.Location = New System.Drawing.Point(408, 515)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnValider.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(80, 36)
        Me.btnValider.TabIndex = 0
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
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(1, 164)
        Me.Panel1.MaximumSize = New System.Drawing.Size(483, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 268)
        Me.Panel1.TabIndex = 3
        '
        'dtDebutGlobal
        '
        Me.dtDebutGlobal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtDebutGlobal.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        Me.dtDebutGlobal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDebutGlobal.Location = New System.Drawing.Point(150, 461)
        Me.dtDebutGlobal.Name = "dtDebutGlobal"
        Me.dtDebutGlobal.Size = New System.Drawing.Size(127, 29)
        Me.dtDebutGlobal.TabIndex = 98
        '
        'dtFinGlobal
        '
        Me.dtFinGlobal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFinGlobal.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        Me.dtFinGlobal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinGlobal.Location = New System.Drawing.Point(283, 461)
        Me.dtFinGlobal.Name = "dtFinGlobal"
        Me.dtFinGlobal.Size = New System.Drawing.Size(127, 29)
        Me.dtFinGlobal.TabIndex = 99
        '
        'swtReglageIndividuelle
        '
        Me.swtReglageIndividuelle.AutoSize = True
        Me.swtReglageIndividuelle.Depth = 0
        Me.swtReglageIndividuelle.Location = New System.Drawing.Point(9, 457)
        Me.swtReglageIndividuelle.Margin = New System.Windows.Forms.Padding(0)
        Me.swtReglageIndividuelle.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtReglageIndividuelle.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtReglageIndividuelle.Name = "swtReglageIndividuelle"
        Me.swtReglageIndividuelle.Ripple = True
        Me.swtReglageIndividuelle.Size = New System.Drawing.Size(130, 37)
        Me.swtReglageIndividuelle.TabIndex = 3
        Me.swtReglageIndividuelle.Text = "Editer tout"
        Me.swtReglageIndividuelle.UseVisualStyleBackColor = True
        '
        'lblNumClefs
        '
        Me.lblNumClefs.AutoSize = True
        Me.lblNumClefs.Depth = 0
        Me.lblNumClefs.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNumClefs.Location = New System.Drawing.Point(35, 142)
        Me.lblNumClefs.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNumClefs.Name = "lblNumClefs"
        Me.lblNumClefs.Size = New System.Drawing.Size(86, 19)
        Me.lblNumClefs.TabIndex = 9
        Me.lblNumClefs.Text = "N° de la clef"
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Depth = 0
        Me.lblDateDebut.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateDebut.Location = New System.Drawing.Point(164, 142)
        Me.lblDateDebut.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(99, 19)
        Me.lblDateDebut.TabIndex = 10
        Me.lblDateDebut.Text = "Date de début"
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Depth = 0
        Me.lblDateFin.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblDateFin.Location = New System.Drawing.Point(307, 142)
        Me.lblDateFin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(78, 19)
        Me.lblDateFin.TabIndex = 11
        Me.lblDateFin.Text = "Date de fin"
        '
        'chkPrint
        '
        Me.chkPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Depth = 0
        Me.chkPrint.Location = New System.Drawing.Point(207, 516)
        Me.chkPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.chkPrint.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkPrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Ripple = True
        Me.chkPrint.Size = New System.Drawing.Size(187, 37)
        Me.chkPrint.TabIndex = 100
        Me.chkPrint.Text = "Attestation d'emprunt"
        Me.chkPrint.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(5, 442)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(491, 1)
        Me.MaterialDivider1.TabIndex = 13
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(5, 505)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(491, 1)
        Me.MaterialDivider2.TabIndex = 14
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialFloatingActionButton1
        '
        Me.MaterialFloatingActionButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFloatingActionButton1.AnimateShowHideButton = True
        Me.MaterialFloatingActionButton1.Depth = 0
        Me.MaterialFloatingActionButton1.DrawShadows = True
        Me.MaterialFloatingActionButton1.Icon = Global.GestionClefs.My.Resources.Resources.printer_printing_document
        Me.MaterialFloatingActionButton1.Location = New System.Drawing.Point(428, 79)
        Me.MaterialFloatingActionButton1.Mini = False
        Me.MaterialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton1.Name = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.Size = New System.Drawing.Size(56, 57)
        Me.MaterialFloatingActionButton1.TabIndex = 101
        Me.MaterialFloatingActionButton1.Text = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.UseVisualStyleBackColor = True
        Me.MaterialFloatingActionButton1.Visible = False
        '
        'lblNombreDeClef
        '
        Me.lblNombreDeClef.AutoSize = True
        Me.lblNombreDeClef.Depth = 0
        Me.lblNombreDeClef.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblNombreDeClef.Location = New System.Drawing.Point(10, 525)
        Me.lblNombreDeClef.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombreDeClef.Name = "lblNombreDeClef"
        Me.lblNombreDeClef.Size = New System.Drawing.Size(132, 19)
        Me.lblNombreDeClef.TabIndex = 102
        Me.lblNombreDeClef.Text = "0 clef sélectionnée"
        '
        'btnSearchPeople
        '
        Me.btnSearchPeople.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearchPeople.Depth = 0
        Me.btnSearchPeople.DrawShadows = True
        Me.btnSearchPeople.HighEmphasis = False
        Me.btnSearchPeople.Icon = Global.GestionClefs.My.Resources.Resources.searching_magnifying_glass
        Me.btnSearchPeople.Location = New System.Drawing.Point(383, 79)
        Me.btnSearchPeople.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSearchPeople.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSearchPeople.Name = "btnSearchPeople"
        Me.btnSearchPeople.Size = New System.Drawing.Size(44, 36)
        Me.btnSearchPeople.TabIndex = 103
        Me.btnSearchPeople.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnSearchPeople.UseAccentColor = False
        Me.btnSearchPeople.UseVisualStyleBackColor = True
        '
        'frmClefsEmprunterEtAttribuer
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 561)
        Me.Controls.Add(Me.btnSearchPeople)
        Me.Controls.Add(Me.lblNombreDeClef)
        Me.Controls.Add(Me.MaterialFloatingActionButton1)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.lblDateFin)
        Me.Controls.Add(Me.lblDateDebut)
        Me.Controls.Add(Me.lblNumClefs)
        Me.Controls.Add(Me.swtReglageIndividuelle)
        Me.Controls.Add(Me.dtFinGlobal)
        Me.Controls.Add(Me.dtDebutGlobal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.cbPersonnes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(501, 561)
        Me.MinimumSize = New System.Drawing.Size(501, 561)
        Me.Name = "frmClefsEmprunterEtAttribuer"
        Me.Sizable = False
        Me.Text = "Emprunter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPersonnes As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnValider As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnAddUser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtDebutGlobal As DateTimePicker
    Friend WithEvents dtFinGlobal As DateTimePicker
    Friend WithEvents swtReglageIndividuelle As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents lblNumClefs As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateDebut As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDateFin As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkPrint As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents MaterialFloatingActionButton1 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents lblNombreDeClef As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSearchPeople As MaterialSkin.Controls.MaterialButton
End Class
