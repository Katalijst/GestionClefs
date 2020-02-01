Imports MySql.Data.MySqlClient
Public Class frmCreerTrousseau
    Private Sub Valider()
        If txtName.Text <> "" And txtName.Text <> "Aucun" Then
            Try
                Dim insert_command As New MySqlCommand("INSERT INTO `Trousseau`(`TNom`,`TPersonne`) VALUES (@name,@personne)", connecter())
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text
                insert_command.Parameters.Add("@personne", MySqlDbType.VarChar).Value = DBNull.Value
                insert_command.ExecuteNonQuery()
                connecter().Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If

        If frmGestionTrousseau.IsHandleCreated Then
            frmGestionTrousseau.RefreshTrousseau()
        End If
        If frmAjouterClef.IsHandleCreated Then
            frmAjouterClef.RefreshTrousseau()
        End If
        If frmEditerClef.IsHandleCreated Then
            frmEditerClef.RefreshTrousseau()
        End If
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