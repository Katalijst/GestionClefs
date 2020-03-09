Imports MySql.Data.MySqlClient
Public Class frmPersonnesEditer
    Shared stgPersonne As String

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmEditerPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        lblType.Text = strTitleNGenre & " :"
        lblNom.Text = strTitleNNom & " :"
        lblTelephone.Text = strTitleNTelephone & " :"
        lblAutre.Text = strTitleNAutre & " :"

        cbType.Hint = strTitleNGenre
        txtNom.Hint = strTitleNNom
        txtTel.Hint = strTitleNTelephone
        txtAutre.Hint = strTitleNAutre

        Dim intIndexNom As Integer = frmPersonnesGestion.dgvListPersonne.Columns(strTitleNNom).Index
        stgPersonne = frmPersonnesGestion.dgvListPersonne.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        txtNom.Text = stgPersonne
        RefreshGenre()

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim tel As String = ""
        Try
            dt.Reset()
            sql = "Select NTelephone FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For Each s As String In dt.Rows(0)(0).ToString.SplitBy(2)
                tel = tel & s & " "
            Next
            txtTel.Text = tel

            dt.Reset()
            sql = "Select NAutre FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtAutre.Text = dt.Rows(0)(0).ToString
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshGenre()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim dt1 As New DataTable
        Dim da1 As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Genre"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cbType.DataSource = dt
            cbType.ValueMember = "GGenre"
            cbType.DisplayMember = "GGenre"
            If cbType.Items.Count > 0 Then
                cbType.SelectedIndex = 0
            End If

            sql = "Select NGenre FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da1.SelectCommand = cmd
            da1.Fill(dt1)

            Dim stgType As String = dt1.Rows(0)(0)
            For i As Integer = 0 To (cbType.Items.Count - 1)
                If cbType.GetItemText(cbType.Items(i)) = stgType Then
                    cbType.SelectedIndex = i
                End If
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        frmFonctionAjout.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String

        Try
            If txtNom.Text <> "" And txtTel.Text <> "" Then
                sql = "UPDATE NomPersonne SET NNom = '" & txtNom.Text & "', NGenre = '" & cbType.Text & "', NTelephone = '" & txtTel.Text & "', NAutre = '" & txtAutre.Text & "' WHERE NNom = '" & stgPersonne & "'"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                connecter().Close()
                frmMain.FillDataSource()
                Me.Close()
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If frmPersonnesGestion.IsHandleCreated Then
            frmPersonnesGestion.RefreshList()
        End If
        If frmTableauxGestion.IsHandleCreated Then
            frmTableauxGestion.RefreshResponsable(txtNom.Text)
        End If
        If frmTableauxEditer.IsHandleCreated Then
            frmTableauxEditer.RefreshResponsable(txtNom.Text)
        End If
    End Sub
End Class