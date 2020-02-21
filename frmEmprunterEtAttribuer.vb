Imports MySql.Data.MySqlClient

Public Class frmEmprunterEtAttribuer

    'Public cbEmprunterAttribuer() As MaterialSkin.Controls.MaterialComboBox
    'Public txtKeyID() As MaterialSkin.Controls.MaterialTextBox
    'Public dtFin() As System.Windows.Forms.DateTimePicker
    'Public dtDebut() As System.Windows.Forms.DateTimePicker
    'Public btnDelete() As MaterialSkin.Controls.MaterialButton

    Private Sub frmEmprunterEtAttribuer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinManager.AddFormToManage(Me)
        CreateKeyControls()
        LoadPersonnes()
    End Sub

    Public Sub CreateKeyControls()
        Dim dt As DataTable = frmMain.dtPanier

        Dim cbEmprunterAttribuer As New MaterialSkin.Controls.MaterialComboBox()
        Dim txtKeyID As New MaterialSkin.Controls.MaterialTextBox()
        Dim dtFin As New System.Windows.Forms.DateTimePicker()
        Dim dtDebut As New System.Windows.Forms.DateTimePicker()
        Dim btnDelete As New MaterialSkin.Controls.MaterialButton()

        Dim i As Integer = 0
        For Each r As DataRow In dt.Rows
            Dim intY As Integer = (29 + 8) * i

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
            cbEmprunterAttribuer.Items.AddRange(New Object() {"Emprunt", "Attribution"})
            cbEmprunterAttribuer.Location = New System.Drawing.Point(13, (4 + intY))
            cbEmprunterAttribuer.MaxDropDownItems = 4
            cbEmprunterAttribuer.MouseState = MaterialSkin.MouseState.OUT
            cbEmprunterAttribuer.Name = "cbEmprunterAttribuer-" & i
            cbEmprunterAttribuer.Size = New System.Drawing.Size(146, 35)
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
            txtKeyID.Location = New System.Drawing.Point(165, (3 + intY))
            txtKeyID.MaxLength = 50
            txtKeyID.MouseState = MaterialSkin.MouseState.OUT
            txtKeyID.Multiline = False
            txtKeyID.Name = "txtKeyID-" & i
            txtKeyID.Size = New System.Drawing.Size(131, 36)
            txtKeyID.TabIndex = 1
            txtKeyID.UseTallSize = False
            '
            'dtFin
            '
            dtFin.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtFin.Location = New System.Drawing.Point(435, (7 + intY))
            dtFin.Name = "dtFin-" & i
            dtFin.Size = New System.Drawing.Size(127, 29)
            dtFin.TabIndex = 2
            '
            'dtDebut
            '
            dtDebut.Font = New System.Drawing.Font("Noto Sans", 12.0!)
            dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            dtDebut.Location = New System.Drawing.Point(302, (7 + intY))
            dtDebut.Name = "dtDebut-" & i
            dtDebut.Size = New System.Drawing.Size(127, 29)
            dtDebut.TabIndex = 3
            '
            'btnDelete
            '
            btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            btnDelete.Depth = 0
            btnDelete.DrawShadows = True
            btnDelete.HighEmphasis = False
            btnDelete.Icon = Global.GestionClefs.My.Resources.Resources.rubbish_bin_delete_button
            btnDelete.Location = New System.Drawing.Point(569, (3 + intY))
            btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER
            btnDelete.Name = "btnDelete-" & i
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

            AddHandler btnDelete.Click, AddressOf btnDelete_click
            AddHandler cbEmprunterAttribuer.SelectedIndexChanged, AddressOf cbEmprunterAttribuer_SelectedIndexChanged

            If frmMain.blnEmprunt = True Then
                cbEmprunterAttribuer.SelectedIndex = 0
            Else
                cbEmprunterAttribuer.SelectedIndex = 1
            End If

            txtKeyID.Text = r.Item(strTitleCID)

            If cbEmprunterAttribuer.SelectedIndex = 0 Then
                dtFin.Enabled = True
                dtFin.Visible = True
            Else
                dtFin.Enabled = False
                dtFin.Visible = False
            End If

            i += 1
        Next
    End Sub

    Public Sub RefreshControls()
        ' NOTE: The code below uses the instance of   
        ' the button (NewPanelButton) from the previous example.    
        'For i = 0 To frmMain.dtPanier.Rows.Count + 1
        '    If Panel1.Controls.Contains(cbEmprunterAttribuer(i)) Then
        '        RemoveHandler cbEmprunterAttribuer(i).SelectedIndexChanged, AddressOf cbEmprunterAttribuer_SelectedIndexChanged
        '        Panel1.Controls.Remove(cbEmprunterAttribuer(i))
        '        cbEmprunterAttribuer(i).Dispose()
        '    End If
        '    If Panel1.Controls.Contains(btnDelete(i)) Then
        '        RemoveHandler btnDelete(i).Click, AddressOf btnDelete_click
        '        Panel1.Controls.Remove(btnDelete(i))
        '        btnDelete(i).Dispose()
        '    End If
        '    If Panel1.Controls.Contains(txtKeyID(i)) Then
        '        Panel1.Controls.Remove(txtKeyID(i))
        '        txtKeyID(i).Dispose()
        '    End If
        '    If Panel1.Controls.Contains(dtFin(i)) Then
        '        Panel1.Controls.Remove(dtFin(i))
        '        dtFin(i).Dispose()
        '    End If
        '    If Panel1.Controls.Contains(dtDebut(i)) Then
        '        Panel1.Controls.Remove(dtDebut(i))
        '        dtDebut(i).Dispose()
        '    End If
        'Next

        'For Each c As Control In Panel1.GetAllChildren
        '    If c.Name.Contains("btnDelete") Then
        '        RemoveHandler c.Click, AddressOf btnDelete_click
        '    ElseIf c.Name.Contains("cbEmprunterAttribuer") Then
        '        Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = TryCast(c, MaterialSkin.Controls.MaterialComboBox)
        '        RemoveHandler cbEmprunterAttribuer.SelectedIndexChanged, AddressOf cbEmprunterAttribuer_SelectedIndexChanged
        '    End If
        '    c.Dispose()
        'Next
        'System.Threading.Thread.Sleep(50)
        'CreateKeyControls()
    End Sub

    Private Sub btnDelete_click(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControle As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControle = stgNomControle.Substring((index + 1))
        End If

        Dim strTxtKeyID As String = "txtKeyID-" & intIndexControle
        Dim controls0 As Control() = Me.Controls.Find(strTxtKeyID, True)
        If controls0.Length = 1 Then
            Dim txtKeyID As MaterialSkin.Controls.MaterialTextBox = TryCast(controls0(0), MaterialSkin.Controls.MaterialTextBox)
            If txtKeyID IsNot Nothing Then
                frmMain.dtKeyList.ImportRow(frmMain.dtPanier.Rows(intIndexControle))
                frmMain.dtKeyList.AcceptChanges()
                frmMain.dtKeyList.DefaultView.Sort = frmMain.dtKeyList.Columns(0).ColumnName & " ASC"
                frmMain.dtPanier.Rows.Remove(frmMain.dtPanier.Rows(intIndexControle))
                frmMain.dtPanier.AcceptChanges()
                frmMain.dgvPanier.DataSource = frmMain.srcPanier
                frmMain.dgvResultats.DataSource = frmMain.srcKeyList
                RefreshControls()
            End If
        End If
    End Sub

    Private Sub cbEmprunterAttribuer_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim stgNomControle As String = sender.name
        Dim intIndexControle As Integer
        Dim index As Integer = CInt(stgNomControle.LastIndexOf("-"))
        If index > 0 Then
            intIndexControle = stgNomControle.Substring((index + 1))
        End If

        Dim strCbEmprunterName As String = "cbEmprunterAttribuer-" & intIndexControle
        Dim controls0 As Control() = Me.Controls.Find(strCbEmprunterName, True)
        If controls0.Length = 1 Then
            Dim cbEmprunterAttribuer As MaterialSkin.Controls.MaterialComboBox = TryCast(controls0(0), MaterialSkin.Controls.MaterialComboBox)
            If cbEmprunterAttribuer IsNot Nothing Then
                Dim controls1 As Control() = Me.Controls.Find("dtFin-" & intIndexControle, True)
                If controls1.Length = 1 Then
                    Dim dtFin As DateTimePicker = TryCast(controls1(0), DateTimePicker)
                    If dtFin IsNot Nothing Then
                        If cbEmprunterAttribuer.Text = "Emprunt" Then
                            dtFin.Enabled = True
                            dtFin.Visible = True
                        Else
                            dtFin.Enabled = False
                            dtFin.Visible = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub LoadPersonnes()
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