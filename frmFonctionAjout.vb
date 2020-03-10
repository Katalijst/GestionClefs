Imports MySql.Data.MySqlClient

Public Class frmFonctionAjout

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub valider()
        If txtType.Text.Replace(" ", "") <> "" Then
            Try
                Dim insert_command As New MySqlCommand("INSERT INTO `Genre`(`GGenre`) VALUES (@name)", connecter())
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtType.Text
                insert_command.ExecuteNonQuery()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MsgBox("Une fonction avec ce nom existe déjà.", MsgBoxStyle.Critical, "Fonction existante")
                Else
                    MsgBox(ex.Number & " - " & ex.Message)
                End If
                connecter().Close()
                Exit Sub
            Finally
                connecter().Close()
            End Try
        Else
            MsgBox("Le nom de la fonction n'est pas correct.", MsgBoxStyle.Critical, "Nom de fonction incorrect")
            Exit Sub
        End If

        If frmPersonnesGestion.IsHandleCreated Then
            frmPersonnesGestion.RefreshFonction(txtType.Text)
        End If
        If frmPersonnesEditer.IsHandleCreated Then
            frmPersonnesEditer.RefreshGenre()
        End If

        Me.Close()
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
    End Sub
End Class