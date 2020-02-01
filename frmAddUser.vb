Imports MySql.Data.MySqlClient
Public Class frmAddUser
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.SetWaterMark("Nom")
        txtID.SetWaterMark("Identifiant")
        txtPassword.SetWaterMark("Mot de passe")
        txtPasswordConfirm.SetWaterMark("Confimer le nouveau mot de passe")
        If userID = "" Then
            cbUserType.Text = "Administrateur"
            cbUserType.Enabled = False
        Else
            cbUserType.SelectedIndex = 1
            cbUserType.Enabled = True
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtPassword.Text <> txtPasswordConfirm.Text Then
            MsgBox("Les mots de passes saisis ne correspondent pas !")
            Exit Sub
        ElseIf txtPassword.Text.Length < 6 Then
            MsgBox("Le mot de passe doit être composé d'au moins 6 caractères !")
            Exit Sub
        Else
            Try
                Dim stgID As String = txtID.Text
                Dim stgPassword As String = txtPassword.Text
                Dim stgUsername As String = txtUsername.Text
                Dim wrapper As New Simple3Des(stgPassword)
                Dim cipherText As String = wrapper.EncryptData(stgID)

                Dim insert_command As New MySqlCommand("INSERT INTO `Login`(`LCipher`,`LUserType`,`LUserName`) VALUES (@cipher,@UserType,@username)", connecter())
                insert_command.Parameters.Add("@cipher", MySqlDbType.VarChar).Value = cipherText
                insert_command.Parameters.Add("@UserType", MySqlDbType.VarChar).Value = cbUserType.Text
                insert_command.Parameters.Add("@username", MySqlDbType.VarChar).Value = stgUsername
                insert_command.ExecuteNonQuery()
                connecter().Close()
                MsgBox("Compte " & stgUsername & " avec l'ID " & stgID & " créé avec succès !")
                txtUsername.Text = String.Empty
                txtID.Text = String.Empty
                txtPassword.Text = String.Empty
                txtPasswordConfirm.Text = String.Empty
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class