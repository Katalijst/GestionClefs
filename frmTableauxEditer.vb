Imports MySql.Data.MySqlClient

Public Class frmTableauxEditer
    Shared stgPosID

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmEditerPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)

        lblPNom.Text = "Nom du tableau :"
        lblPBatiment.Text = strTitlePBatiment & " :"
        lblPResponsable.Text = strTitlePResponsable & " :"

        cbResponsable.Hint = strTitlePResponsable
        txtNom.Hint = "Nom du tableau"
        cbBatiments.Hint = strTitlePBatiment

        RefreshResponsable()
        RefreshBatiment()
        RemplissageAuto()
    End Sub
    Public Sub RemplissageAuto()
        Dim intIndexNom As Integer = frmTableauxGestion.dgvListTableau.Columns("Nom").Index
        stgPosID = frmTableauxGestion.dgvListTableau.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        txtNom.Text = stgPosID

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        cmd.Parameters.Add("@Tableau", MySqlDbType.VarChar)
        Try
            dt.Reset()
            sql = "Select PResponsable FROM Position WHERE PNom=@Tableau"
            With cmd
                .Parameters("@Tableau").Value = stgPosID
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Dim stgType As String = dt.Rows(0)(0)
            For i As Integer = 0 To (cbResponsable.Items.Count - 1)
                If cbResponsable.GetItemText(cbResponsable.Items(i)) = stgType Then
                    cbResponsable.SelectedIndex = i
                End If
            Next
            connecter().Close()

            dt.Reset()
            sql = "Select PBatiment FROM Position WHERE PNom=@Tableau"
            With cmd
                .Parameters("@Tableau").Value = stgPosID
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cbBatiments.Text = dt.Rows(0).Item(0)
            End If
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshResponsable(ByVal Optional name As String = "Empty")
        Dim dtNom As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select NNom from NomPersonne where NNom <> 'Personne'"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtNom)

            Dim strCbPersonne As String() = New String(dtNom.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtNom.Rows
                strCbPersonne(i) = r.Item(0).ToString
                i += 1
            Next
            cbResponsable.DataSource = strCbPersonne
            If name <> "Empty" Then
                cbResponsable.Text = name
            End If
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RefreshBatiment(ByVal Optional selected As String = "Empty")
        Dim dtBatiments As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select BNom From Batiment where BNum <> '0' order by BNom ASC"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtBatiments)

            Dim strCbBatiments As String() = New String(dtBatiments.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtBatiments.Rows
                strCbBatiments(i) = r.Item(0).ToString
                i += 1
            Next
            cbBatiments.DataSource = strCbBatiments
            If selected <> "Empty" Then
                cbBatiments.Text = selected
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Code & " - " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddPersonne_Click(sender As Object, e As EventArgs) Handles btnAddPersonne.Click
        frmPersonnesEditer.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim stgBatNom As String = cbBatiments.Text

        cmd.Parameters.Add("@OldTableau", MySqlDbType.VarChar)
        cmd.Parameters.Add("@Tableau", MySqlDbType.VarChar)
        cmd.Parameters.Add("@Responsable", MySqlDbType.VarChar)
        cmd.Parameters.Add("@Batiment", MySqlDbType.VarChar)

        Try
            If txtNom.Text.Replace(" ", "") <> "" Then
                sql = "UPDATE Position SET PNom=@Tableau, PResponsable=@Responsable, PBatiment=@Batiment WHERE PNom=@OldTableau"
                With cmd
                    .Parameters("@Tableau").Value = txtNom.Text
                    .Parameters("@Responsable").Value = cbResponsable.Text
                    .Parameters("@Batiment").Value = stgBatNom
                    .Parameters("@OldTableau").Value = stgPosID
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Un tableau existe déjà avec cette dénomination.", MsgBoxStyle.Critical, "Tableau existant")
            Else
                MsgBox(ex.Number & " - " & ex.Message)
            End If
            connecter().Close()
            Exit Sub
        Finally
            connecter().Close()
        End Try

        If frmClefsAjout.IsHandleCreated Then
            frmClefsAjout.RefreshTableau()
        End If
        If frmTableauxGestion.IsHandleCreated Then
            frmTableauxGestion.RefreshList()
        End If
        If frmMain.IsHandleCreated Then
            frmMain.FillDataSource()
        End If
        Me.Close()
    End Sub

End Class