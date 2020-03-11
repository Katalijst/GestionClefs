﻿Imports MySql.Data.MySqlClient
Imports MaterialSkin

'Formulaire de connexion, peut être optimisé
Public Class frmConnexion
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BrightOrDarkMode()
        Me.MinimumSize = New Size(Width, Height)
        Me.MaximumSize = Me.MinimumSize
        tmrFondu.Enabled = True
        'lblVersion.Text = "Version " & My.Application.Info.Version.ToString
        checkTableAndAccount()
    End Sub

    Private Sub tmrFondu_Tick(sender As Object, e As EventArgs) Handles tmrFondu.Tick
        If Me.Opacity < 1 Then
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
                frmUtilisateursAjouter.ShowDialog()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Valider()
        Dim stgID As String = mtxtID.Text
        Dim stgPassword As String = mtxtPassword.Text

        'Vérifier si compte admin existe
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        cmd.Parameters.Add("@UserName", MySqlDbType.VarChar)
        cmd.Parameters.Add("@Cipher", MySqlDbType.VarChar)

        Try
            dt.Reset()
            sql = "Select COUNT(LUserName) FROM Login"
            With cmd
                .Parameters("@UserName").Value = stgID
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows(0).Item(0) < 1 Then
                MsgBox("Aucun utilisateur enregistré ! Veuillez choisir un nom d'utilisateur et un mot de passe.")
                frmUtilisateursAjouter.ShowDialog()
            Else
                Cursor = Cursors.WaitCursor
                Application.DoEvents()
                dt.Reset()
                sql = "Select LUserName, LCipher, LUserType, LServices FROM Login WHERE LUserName = @UserName"
                With cmd
                    .Parameters("@UserName").Value = stgID
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    If IsDBNull(dt.Rows(0).Item(1)) Then
                        MsgBox("Mot de passe réinitialisé, veuillez choisir un nouveau mot de passe.", MsgBoxStyle.Critical)
                        GlobalUserName = dt.Rows(0).Item(0)
                        GlobalUserType = dt.Rows(0).Item(2)
                        GlobalServices = dt.Rows(0).Item(3)
                        frmUtilisateurSetPassword.Show()
                        Me.Hide()
                        Exit Sub
                    End If
                Else
                    MsgBox("Nom d'utilisateur ou mot de passe invalide !", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Dim wrapper As New Simple3Des(stgPassword)
                Dim cipherText As String = wrapper.EncryptData(GetHash(stgID))
                dt.Reset()
                sql = "Select LCipher FROM Login WHERE LCipher=@Cipher"
                With cmd
                    .Parameters("@Cipher").Value = cipherText
                    .Connection = connecter()
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("Nom d'utilisateur ou mot de passe invalide !", MsgBoxStyle.Critical)
                    connecter().Close()
                    Cursor = Cursors.Default
                Else
                    dt.Reset()
                    sql = "Select LUserType,LUserName,LServices FROM Login WHERE LCipher=@Cipher"
                    With cmd
                        .Parameters("@Cipher").Value = cipherText
                        .Connection = connecter()
                        .CommandText = sql
                    End With
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        GlobalUserType = dt.Rows(0).Item(0).ToString
                        GlobalUserName = dt.Rows(0).Item(1).ToString
                        GlobalServices = dt.Rows(0).Item(2).ToString
                    End If
                    connecter().Close()
                    Me.Hide()
                    frmMain.Show()
                End If
            End If
        Catch ex As MySqlException
            Me.Show()
            MsgBox(ex.Number & " - " & ex.Message)
        End Try

    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Valider()
    End Sub

    Private Sub btnQuitter_Click_1(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
        End
    End Sub

    Public Sub BrightOrDarkMode()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkMode = True Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.DeepOrange400, TextShade.WHITE)
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE)
        End If

    End Sub

End Class