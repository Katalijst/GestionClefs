﻿Imports MySql.Data.MySqlClient

Public Class frmGenreAjout
    Private Sub valider()
        If txtType.Text <> "" Then
            Try
                Dim insert_command As New MySqlCommand("INSERT INTO `Genre`(`GGenre`) VALUES (@name)", connecter())
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtType.Text
                insert_command.ExecuteNonQuery()
                connecter().Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If

        If frmPersonnesGestion.IsHandleCreated Then
            frmPersonnesGestion.RefreshGenre()
        End If
        If frmPersonnesEditer.IsHandleCreated Then
            frmPersonnesEditer.RefreshGenre()
        End If
    End Sub
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        valider()
    End Sub

    Private Sub txtType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtType.KeyDown
        If e.KeyCode = Keys.Enter Then
            valider()
        End If
    End Sub

    Private Sub frmAjouterGenre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ajouter une " & strTitleGGenre & "..."
        lblGenre.Text = strTitleGGenre & " :"
    End Sub
End Class