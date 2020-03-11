Imports MySql.Data.MySqlClient
Public Class frmUtilisateurSetPassword
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmUtilisateurSetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        lblUserName.Text = GlobalUserName
    End Sub

    Private Sub frmUtilisateurSetPassword_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtPassword.Text <> txtPasswordConfirm.Text Then
            MsgBox("Les mots de passes saisis ne correspondent pas !")
            Exit Sub
        ElseIf txtPassword.Text.Length < 6 Then
            MsgBox("Le mot de passe doit être composé d'au moins 6 caractères !")
            Exit Sub
        Else
            If GlobalUserName <> "" Then
                Dim stgID As String = lblUserName.Text
                Dim stgPassword As String = txtPassword.Text
                Try
                    Dim wrapper As New Simple3Des(stgPassword)
                    Dim cipherText As String = wrapper.EncryptData(GetHash(stgID))

                    Dim insert_command As New MySqlCommand("Update Login SET LCipher = @cipher WHERE LUserName = @UserName", connecter())
                    insert_command.Parameters.Add("@cipher", MySqlDbType.VarChar).Value = cipherText
                    insert_command.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = stgID
                    insert_command.ExecuteNonQuery()

                Catch ex As MySqlException
                    MsgBox(ex.Number & " - " & ex.Message)
                    connecter().Close()
                    Exit Sub
                Finally
                    connecter().Close()
                    frmMain.Show()
                    Me.Hide()
                End Try
            Else
                MsgBox("Veuillez remplir tout les champs.", MsgBoxStyle.Critical, "Erreur")
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class