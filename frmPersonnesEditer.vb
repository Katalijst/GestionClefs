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

        stgPersonne = frmPersonnesGestion.dgvListPersonne.SelectedRows(0).Cells(strTitleNNom).Value.ToString()
        txtNom.Text = stgPersonne

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

            dt.Reset()
            sql = "Select NGenre FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            RefreshGenre(dt.Rows(0).Item(0).ToString)

            connecter().Close()

        Catch ex As MySqlException
            MsgBox(ex.ErrorCode & " - " & ex.Message)
        End Try
    End Sub
    Public Sub RefreshGenre(ByVal Optional name As String = "Empty")
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Genre"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim strCmbType(dt.Rows.Count) As String
            Dim index As Integer = 0
            For Each r As DataRow In dt.Rows
                strCmbType(index) = r.Item(0)
                index += 1
            Next
            cbType.DataSource = strCmbType

            If name <> "Empty" Then
                cbType.Text = name
            End If

            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.ErrorCode & " - " & ex.Message)
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
        Catch ex As MySqlException
            MsgBox(ex.ErrorCode & " - " & ex.Message)
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