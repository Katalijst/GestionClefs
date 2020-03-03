Imports MySql.Data.MySqlClient

Public Class frmBatimentsEditer
    Shared stgBatID
    Private Sub frmEditerBatiment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = strTitleBNum & " :"
        lblAdresse.Text = strTitleBAdresse & " :"
        lblFonction.Text = strTitleBFonction & " :"
        lblNom.Text = strTitleBNom & " :"

        stgBatID = frmBatimentsAjoutGestion.dgvListBatiment.SelectedRows(0).Cells(strTitleBNum).Value.ToString()
        txtID.Text = stgBatID

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try
            dt.Reset()
            sql = "Select BNom FROM Batiment WHERE BNum=""" & stgBatID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtNom.Text = dt.Rows(0)(0).ToString

            dt.Reset()
            sql = "Select BAdresse FROM Batiment WHERE BNum=""" & stgBatID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtAdresse.Text = dt.Rows(0)(0).ToString
            connecter().Close()

            dt.Reset()
            sql = "Select BFonction FROM Batiment WHERE BNum=""" & stgBatID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtFonction.Text = dt.Rows(0)(0).ToString
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String

        Try
            If txtID.Text <> "" And txtNom.Text <> "" And txtAdresse.Text <> "" And txtFonction.Text <> "" Then
                sql = "UPDATE Batiment SET BNum = '" & txtID.Text & "', BNom = '" & txtNom.Text & "', BAdresse = '" & txtAdresse.Text & "', BFonction = '" & txtFonction.Text & "' WHERE BNum = '" & stgBatID & "'"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                connecter().Close()
                If frmBatimentsAjoutGestion.IsHandleCreated Then
                    frmBatimentsAjoutGestion.RefreshList()
                End If
                Me.Close()
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If frmPersonnesGestion.IsHandleCreated Then
            frmPersonnesGestion.RefreshList()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class