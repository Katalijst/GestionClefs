Imports MySql.Data.MySqlClient
Public Class frmEditerPersonne
    Shared stgPersonne As String

    Private Sub frmEditerPersonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intIndexNom As Integer = frmGestionPersonnes.dgvListPersonne.Columns("Nom").Index
        stgPersonne = frmGestionPersonnes.dgvListPersonne.SelectedRows(0).Cells(intIndexNom).Value.ToString()
        txtNom.Text = stgPersonne
        RefreshGenre()

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim tel As String = ""
        Try
            dt.Reset()
            sql = "Select NTelephone FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For Each s As String In dt.Rows(0)(0).ToString.SplitBy(2)
                tel = tel & s & " "
            Next
            mtxtTel.Text = tel

            dt.Reset()
            sql = "Select NAutre FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtAutre.Text = dt.Rows(0)(0).ToString
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshGenre()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim dt1 As New DataTable
        Dim da1 As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Genre"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbType.DataSource = dt
            cmbType.ValueMember = "GGenre"
            cmbType.DisplayMember = "GGenre"
            If cmbType.Items.Count > 0 Then
                cmbType.SelectedIndex = 0
            End If

            sql = "Select NGenre FROM NomPersonne WHERE NNom=""" & stgPersonne & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da1.SelectCommand = cmd
            da1.Fill(dt1)

            Dim stgType As String = dt1.Rows(0)(0)
            For i As Integer = 0 To (cmbType.Items.Count - 1)
                If cmbType.GetItemText(cmbType.Items(i)) = stgType Then
                    cmbType.SelectedIndex = i
                End If
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        frmAjouterGenre.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String

        Try
            If txtNom.Text <> "" And mtxtTel.Text <> "" Then
                sql = "UPDATE NomPersonne SET NNom = '" & txtNom.Text & "', NGenre = '" & cmbType.Text & "', NTelephone = '" & mtxtTel.Text & "', NAutre = '" & txtAutre.Text & "' WHERE NNom = '" & stgPersonne & "'"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                connecter().Close()
                frmMain.FillDataSource()
                Me.Close()
            Else
                MsgBox("Veuillez remplir tout les champs !")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If frmGestionPersonnes.IsHandleCreated Then
            frmGestionPersonnes.RefreshList()
        End If
        If frmGestionPosition.IsHandleCreated Then
            frmGestionPosition.RefreshResponsable()
        End If
    End Sub
End Class