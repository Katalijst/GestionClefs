Imports MySql.Data.MySqlClient

Public Class frmEmprunterEtAttribuer
    Private Sub frmEmprunterEtAttribuer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPersonnes()
    End Sub

    Public Sub CreateKeyControls()
        For i = 1 To 10
            Dim cbEmprunterAttribuer = New MaterialSkin.Controls.MaterialComboBox()
            Dim txtKeyID = New MaterialSkin.Controls.MaterialTextBox()
            Dim dtFin = New System.Windows.Forms.DateTimePicker()
            Dim dtDebut = New System.Windows.Forms.DateTimePicker()
            Dim btnDelete = New MaterialSkin.Controls.MaterialButton()

            Dim intY As Integer = (cbEmprunterAttribuer0.Size.Height + cbEmprunterAttribuer0.Margin.Top) * i

            '
            'cbEmprunterAttribuer
            '
            cbEmprunterAttribuer.AutoResize = False
            cbEmprunterAttribuer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            cbEmprunterAttribuer.Depth = 0
            cbEmprunterAttribuer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            cbEmprunterAttribuer.DropDownHeight = 118
            cbEmprunterAttribuer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cbEmprunterAttribuer.DropDownWidth = 121
            cbEmprunterAttribuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            cbEmprunterAttribuer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            cbEmprunterAttribuer.FormattingEnabled = True
            cbEmprunterAttribuer.Hint = "Emprunt"
            cbEmprunterAttribuer.IntegralHeight = False
            cbEmprunterAttribuer.ItemHeight = 29
            cbEmprunterAttribuer.Location = New System.Drawing.Point(13, (4 + intY))
            cbEmprunterAttribuer.MaxDropDownItems = 4
            cbEmprunterAttribuer.MouseState = MaterialSkin.MouseState.OUT
            cbEmprunterAttribuer.Name = "cbEmprunterAttribuer" & i
            cbEmprunterAttribuer.Size = New System.Drawing.Size(121, 35)
            cbEmprunterAttribuer.TabIndex = 0
            cbEmprunterAttribuer.UseAccent = False
            cbEmprunterAttribuer.UseTallSize = False
            '
            'txtKeyID
            '
            txtKeyID.BorderStyle = System.Windows.Forms.BorderStyle.None
            txtKeyID.Depth = 0
            txtKeyID.Enabled = False
            txtKeyID.Font = New System.Drawing.Font("Roboto", 12.0!)
            txtKeyID.Location = New System.Drawing.Point(140, (3 + intY))
            txtKeyID.MaxLength = 50
            txtKeyID.MouseState = MaterialSkin.MouseState.OUT
            txtKeyID.Multiline = False
            txtKeyID.Name = "txtKeyID" & i
            txtKeyID.Size = New System.Drawing.Size(126, 36)
            txtKeyID.TabIndex = 1
            txtKeyID.Text = "KeyID"
            txtKeyID.UseTallSize = False
            '
            'dtFin
            '
            dtFin.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtFin.Location = New System.Drawing.Point(417, (7 + intY))
            dtFin.Name = "dtFin" & i
            dtFin.Size = New System.Drawing.Size(139, 29)
            dtFin.TabIndex = 2
            '
            'dtDebut
            '
            dtDebut.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtDebut.Location = New System.Drawing.Point(272, (7 + intY))
            dtDebut.Name = "dtDebut" & i
            dtDebut.Size = New System.Drawing.Size(139, 29)
            dtDebut.TabIndex = 3
            '
            'btnDelete
            '
            btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            btnDelete.Depth = 0
            btnDelete.DrawShadows = True
            btnDelete.HighEmphasis = False
            btnDelete.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
            btnDelete.Location = New System.Drawing.Point(563, (3 + intY))
            btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER
            btnDelete.Name = "btnDelete" & i
            btnDelete.Size = New System.Drawing.Size(44, 36)
            btnDelete.TabIndex = 4
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
            btnDelete.UseAccentColor = False
            btnDelete.UseVisualStyleBackColor = True

            Panel1.Controls.Add(cbEmprunterAttribuer)
            Panel1.Controls.Add(txtKeyID)
            Panel1.Controls.Add(dtFin)
            Panel1.Controls.Add(dtDebut)
            Panel1.Controls.Add(btnDelete)

        Next
    End Sub

    Public Sub LoadPersonnes()
        CreateKeyControls()

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim dtPredict As New DataTable
        Dim daPredict As New MySqlDataAdapter

        Dim sql As String = "Select * from NomPersonne"
        Dim stgPredict As String = "Select * from NomPersonne"


        'sql = "Select NomPersonne from NomPersonne Where NNom like ""%" & txtRechercher.Text & "%"""
        stgPredict = "Select NNom from NomPersonne"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            dt.Columns("NNom").ColumnName = strTitleNNom

            Dim strCbPersonne As String() = New String(dt.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dt.Rows
                strCbPersonne(i) = r.Item(0).ToString
                i += 1
            Next
            cbPersonnes.DataSource = strCbPersonne

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class