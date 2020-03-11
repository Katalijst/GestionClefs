Imports MySql.Data.MySqlClient

Public Class frmServicesAjouter
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmServicesAjouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
    End Sub

    Private Sub Valider()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtCount As New DataTable
        Dim sql As String
        cmd.Parameters.Add("@Service", MySqlDbType.VarChar)

        If txtName.Text.Replace(" ", "") <> "" And txtName.Text.Replace(" ", "") <> "Aucun" Then
            Try
                sql = "SELECT COUNT(SNom) FROM Services WHERE SNom=@Service;"
                With cmd
                    .Parameters("@Service").Value = txtName.Text
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dtCount)
                If dtCount.Rows(0).Item(0) <> 0 Then
                    MsgBox("Un service porte déjà ce nom !", MsgBoxStyle.Critical, "Service existant")
                    Exit Sub
                Else
                    'Insert le servive
                    sql = "INSERT INTO `Services` (`SID`, `SNom`, `STableau`) VALUES (NULL, @Service, 'Aucun');"
                    With cmd
                        .Parameters("@Service").Value = txtName.Text
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With
                End If
            Catch ex As MySqlException
                MsgBox(ex.Number & " - " & ex.Message)
                connecter().Close()
            End Try
        Else
            MsgBox("Le nom du service entré n'est pas valide, veuillez le changer.", MsgBoxStyle.Critical, "Nom de service incorrect")
            Exit Sub
        End If

        If frmServicesGestion.IsHandleCreated Then
            frmServicesGestion.LoadServices(txtName.Text)
        End If
        If frmServicesGestion.IsHandleCreated Then
            frmUtilisateursAjouter.LoadServices(txtName.Text)
        End If
        Me.Close()
    End Sub
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Valider()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Valider()
        End If
    End Sub

End Class