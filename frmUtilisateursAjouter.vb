Imports MySql.Data.MySqlClient
Public Class frmUtilisateursAjouter

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        LoadServices()
    End Sub

    Private Sub frmAddUser_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Public Sub LoadServices(ByVal Optional name As String = "Empty")
        cbServices.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select DISTINCT SNom from Services where SNom <> 'Global'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                cbServices.Items.Add(r.Item(0).ToString)
            Next
            If name <> "Empty" Then
                cbServices.Text = name
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            connecter().Close()
        End Try
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If txtPassword.Text <> txtPasswordConfirm.Text Then
            MsgBox("Les mots de passes saisis ne correspondent pas !")
            Exit Sub
        ElseIf txtPassword.Text.Length < 6 Then
            MsgBox("Le mot de passe doit être composé d'au moins 6 caractères !")
            Exit Sub
        ElseIf cbServices.SelectedIndex <> -1 Then
            If txtID.Text.Replace(" ", "") <> "" Then
                Dim stgID As String = txtID.Text
                Dim stgPassword As String = txtPassword.Text
                Try
                    Dim wrapper As New Simple3Des(stgPassword)
                    Dim cipherText As String = wrapper.EncryptData(GetHash(stgID))

                    Dim insert_command As New MySqlCommand("INSERT INTO `Login`(`LCipher`,`LUserType`,`LUserName`,`LServices`) VALUES (@cipher,@UserType,@username,@service)", connecter())
                    insert_command.Parameters.Add("@cipher", MySqlDbType.VarChar).Value = cipherText
                    insert_command.Parameters.Add("@UserType", MySqlDbType.VarChar).Value = cbUserType.Text
                    insert_command.Parameters.Add("@username", MySqlDbType.VarChar).Value = stgID
                    insert_command.Parameters.Add("@service", MySqlDbType.VarChar).Value = cbServices.Text
                    insert_command.ExecuteNonQuery()

                Catch ex As MySqlException
                    If ex.Number = 1062 Then
                        MsgBox("Cette utilisateur existe déjà.", MsgBoxStyle.Critical, "Utilisateur existant")
                    Else
                        MsgBox(ex.Number & " - " & ex.Message)
                    End If
                    connecter().Close()
                    Exit Sub
                Finally
                    connecter().Close()
                    MsgBox("Compte " & stgID & " créé avec succès !")
                    txtID.Text = String.Empty
                    txtPassword.Text = String.Empty
                    txtPasswordConfirm.Text = String.Empty
                    If frmUtilisateursGestion.IsHandleCreated Then
                        frmUtilisateursGestion.RefreshList()
                    End If
                    Me.Close()
                End Try
            Else
                MsgBox("Veuillez remplir tout les champs.", MsgBoxStyle.Critical, "Erreur")
            End If
        Else
            MsgBox("Veuillez choisir un service !", MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub
End Class