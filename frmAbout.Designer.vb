<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFreepik = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlaticon1 = New System.Windows.Forms.LinkLabel()
        Me.lblFlaticon2 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPixel = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Icon made by"
        '
        'lblFreepik
        '
        Me.lblFreepik.AutoSize = True
        Me.lblFreepik.Location = New System.Drawing.Point(80, 9)
        Me.lblFreepik.Name = "lblFreepik"
        Me.lblFreepik.Size = New System.Drawing.Size(42, 13)
        Me.lblFreepik.TabIndex = 4
        Me.lblFreepik.TabStop = True
        Me.lblFreepik.Text = "Freepik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "from"
        '
        'lblFlaticon1
        '
        Me.lblFlaticon1.AutoSize = True
        Me.lblFlaticon1.Location = New System.Drawing.Point(143, 9)
        Me.lblFlaticon1.Name = "lblFlaticon1"
        Me.lblFlaticon1.Size = New System.Drawing.Size(91, 13)
        Me.lblFlaticon1.TabIndex = 6
        Me.lblFlaticon1.TabStop = True
        Me.lblFlaticon1.Text = "www.flaticon.com"
        '
        'lblFlaticon2
        '
        Me.lblFlaticon2.AutoSize = True
        Me.lblFlaticon2.Location = New System.Drawing.Point(166, 25)
        Me.lblFlaticon2.Name = "lblFlaticon2"
        Me.lblFlaticon2.Size = New System.Drawing.Size(91, 13)
        Me.lblFlaticon2.TabIndex = 10
        Me.lblFlaticon2.TabStop = True
        Me.lblFlaticon2.Text = "www.flaticon.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "from"
        '
        'lblPixel
        '
        Me.lblPixel.AutoSize = True
        Me.lblPixel.Location = New System.Drawing.Point(80, 25)
        Me.lblPixel.Name = "lblPixel"
        Me.lblPixel.Size = New System.Drawing.Size(65, 13)
        Me.lblPixel.TabIndex = 8
        Me.lblPixel.TabStop = True
        Me.lblPixel.Text = "Pixel perfect"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Icon made by"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(80, 41)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(41, 13)
        Me.LinkLabel2.TabIndex = 12
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Google"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Icon made by"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "(Material Design Icon Pack, CC BY 3.0)"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 304)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFlaticon2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPixel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFlaticon1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFreepik)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "A propos de GestionClefs..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFreepik As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFlaticon1 As LinkLabel
    Friend WithEvents lblFlaticon2 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPixel As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
