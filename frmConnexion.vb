Imports MySql.Data.MySqlClient
Imports MaterialSkin

'Formulaire de connexion, peut être optimisé
Public Class frmConnexion
    Private Sub frmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(Width, Height)
        Me.MaximumSize = Me.MinimumSize
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

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
                frmAddUser.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
                    userID = mtxtID.Text
                    connecter().Close()
                    Me.Hide()
                    frmMain.Show()
                End If
            End If
        Catch ex As Exception
            Me.Show()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Valider()
    End Sub

    Private Sub btnQuitter_Click_1(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
        End
    End Sub

End Class