Imports MySql.Data.MySqlClient
Public Class frmTrousseauxAjout

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub Valider()
        If txtName.Text <> "" And txtName.Text <> "Aucun" Then
            Try
                Dim insert_command As New MySqlCommand("INSERT INTO `Trousseau`(`TNom`) VALUES (@name)", connecter())
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text
                insert_command.ExecuteNonQuery()
                connecter().Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If

        If frmTrousseauxGestion.IsHandleCreated Then
            frmTrousseauxGestion.RefreshTrousseau(txtName.Text)
        End If
        If frmClefsAjout.IsHandleCreated Then
            frmClefsAjout.RefreshTrousseau(txtName.Text)
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

    Private Sub frmCreerTrousseau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
    End Sub
End Class