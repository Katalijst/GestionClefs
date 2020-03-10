Imports MySql.Data.MySqlClient

Public Class frmUtilisateursPassword

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub btnMySQL_Click(sender As Object, e As EventArgs)
        frmParametresBDD.ShowDialog()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        txtID.Text = userID
        txtOldPassword.SetWaterMark("Mot de passe actuel")
        txtNewPassword.SetWaterMark("Nouveau mot de passe")
        txtNewPasswordConfirm.SetWaterMark("Confimer le nouveau mot de passe")
        If userType <> "Administrateur" Then
            btnAddUser.Enabled = False
            btnUserManager.Enabled = False
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtNewPassword.Text <> txtNewPasswordConfirm.Text Then
            MsgBox("Les mots de passes saisis ne correspondent pas !")
            Exit Sub
        ElseIf txtNewPassword.Text.Length < 6 Then
            MsgBox("Le mot de passe doit être composé d'au moins 6 caractères !")
            Exit Sub
        Else
            Try
                Dim stgID As String = txtID.Text
                Dim stgOldPassword As String = txtOldPassword.Text
                Dim oldWrapper As New Simple3Des(stgOldPassword)
                Dim oldCipherText As String = oldWrapper.EncryptData(stgID)

                'Vérifier le mot de passe
                Dim cmd As New MySqlCommand
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter
                Dim sql As String

                sql = "Select LCipher FROM Login WHERE LCipher=@cipher"
                With cmd
                    .Parameters.Add("@cipher", MySqlDbType.VarChar).Value = oldCipherText
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("Le mot de passe actuel saisi est invalide !")
                    connecter().Close()
                Else
                    'Encryption avec nouveaux mot de passe
                    Dim stgNewPassword As String = txtNewPassword.Text
                    Dim newWrapper As New Simple3Des(stgNewPassword)
                    Dim newCipherText As String = newWrapper.EncryptData(stgID)

                    dt.Reset()
                    sql = "DELETE FROM Login WHERE LCipher=@cipher"
                    With cmd
                        .Parameters.Add("@cipher", MySqlDbType.VarChar).Value = oldCipherText
                        .Connection = connecter()
                        .CommandText = sql
                        .ExecuteNonQuery()
                    End With

                    Dim insert_command As New MySqlCommand("INSERT INTO `Login`(`LCipher`,`LUserType`) VALUES (@cipher,@UserType)", connecter())
                    insert_command.Parameters.Add("@cipher", MySqlDbType.VarChar).Value = newCipherText
                    insert_command.Parameters.Add("@UserType", MySqlDbType.VarChar).Value = userType
                    insert_command.ExecuteNonQuery()
                    connecter().Close()

                    MsgBox("Mot de passe changé avec succès !")
                    txtOldPassword.Text = String.Empty
                    txtNewPassword.Text = String.Empty
                    txtNewPasswordConfirm.Text = String.Empty
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmUtilisateursAjouter.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnUserManager_Click(sender As Object, e As EventArgs) Handles btnUserManager.Click
        frmUtilisateursGestion.ShowDialog()
    End Sub
End Class