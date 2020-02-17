Imports MySql.Data.MySqlClient

'Formulaire de connexion, peut être optimisé
Public Class frmConnexion
    Private Sub frmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFondu.Enabled = True
        txtID.SetWaterMark("Identifiant")
        txtPassword.SetWaterMark("Mot de passe")
        lblVersion.Text = "Version " & My.Application.Info.Version.ToString
        txtID.Focus()
        checkTableAndAccount()
    End Sub

    Private Sub tmrFondu_Tick(sender As Object, e As EventArgs) Handles tmrFondu.Tick
        If Me.Opacity < 0.9 Then
            Me.Opacity += 0.01
        Else
            tmrFondu.Enabled = False
        End If
    End Sub

    Public Sub checkTableAndAccount()
        'Vérifier si compte admin existe
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            dt.Reset()
            sql = "Select LCipher FROM Login"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count < 1 Then
                MsgBox("Aucun utilisateur enregistré ! Veuillez choisir un nom d'utilisateur et un mot de passe.")
                frmAddUser.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Valider()
        Dim stgID As String = txtID.Text
        Dim stgPassword As String = txtPassword.Text

        'Vérifier si compte admin existe
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            dt.Reset()
            sql = "Select LCipher FROM Login"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count < 1 Then
                MsgBox("Aucun utilisateur enregistré ! Veuillez choisir un nom d'utilisateur et un mot de passe.")
                frmAddUser.ShowDialog()
            Else
                Cursor = Cursors.WaitCursor
                Application.DoEvents()
                Dim wrapper As New Simple3Des(stgPassword)
                Dim cipherText As String = wrapper.EncryptData(stgID)
                dt.Reset()
                sql = "Select LCipher FROM Login WHERE LCipher=""" & cipherText & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("Nom d'utilisateur ou mot de passe invalide !")
                    connecter().Close()
                    Cursor = Cursors.Default
                Else
                    dt.Reset()
                    sql = "Select LUserType FROM Login WHERE LCipher=""" & cipherText & """"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                    End With
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        userType = dt.Rows(0)(0).ToString
                    End If
                    dt.Reset()
                    sql = "Select LUserName FROM Login WHERE LCipher=""" & cipherText & """"
                    With cmd
                        .Connection = connecter()
                        .CommandText = sql
                    End With
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        userName = dt.Rows(0)(0).ToString
                    End If
                    userID = txtID.Text
                    frmMain.Show()
                    connecter().Close()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Valider()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
        End
    End Sub
End Class