Imports MySql.Data.MySqlClient
Public Class frmEditerClef
    Shared stgKeyId As String

    Public Sub RefreshTrousseau()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim dt1 As New DataTable
        Dim da1 As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Trousseau"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbTrousseauListe.DataSource = dt
            cmbTrousseauListe.ValueMember = "TNom"
            cmbTrousseauListe.DisplayMember = "TNom"
            If cmbTrousseauListe.Items.Count > 0 Then
                cmbTrousseauListe.SelectedIndex = 0
            End If

            sql = "Select CTrousseau FROM Clefs WHERE CID=""" & stgKeyId & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da1.SelectCommand = cmd
            da1.Fill(dt1)

            Dim stgTrousseau As String = dt1.Rows(0)(0)
            For i As Integer = 0 To (cmbTrousseauListe.Items.Count - 1)
                If cmbTrousseauListe.GetItemText(cmbTrousseauListe.Items(i)) = stgTrousseau Then
                    cmbTrousseauListe.SelectedIndex = i
                End If
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshPosition()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim dt1 As New DataTable
        Dim da1 As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Position"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            cmbLoc.DataSource = dt
            cmbLoc.ValueMember = "PNom"
            cmbLoc.DisplayMember = "PNom"
            If cmbLoc.Items.Count > 0 Then
                cmbLoc.SelectedIndex = 0
            End If

            sql = "Select CPosition FROM Clefs WHERE CID=""" & stgKeyId & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da1.SelectCommand = cmd
            da1.Fill(dt1)

            Dim stgLoc As String = dt1.Rows(0)(0)
            For i As Integer = 0 To (cmbLoc.Items.Count - 1)
                If cmbLoc.GetItemText(cmbLoc.Items(i)) = stgLoc Then
                    cmbLoc.SelectedIndex = i
                End If
            Next
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAndRefresh()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Dim intIndexID As Integer = frmMain.dgvResultats.Columns(strTitleCID).Index
        stgKeyId = frmMain.dgvResultats.SelectedRows(0).Cells(intIndexID).Value.ToString()
        txtID.Text = stgKeyId

        RefreshTrousseau()
        RefreshPosition()

        Try
            dt.Reset()
            sql = "Select CNom FROM Clefs WHERE CID=""" & stgKeyId & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtNom.Text = dt.Rows(0)(0)

            dt.Reset()
            sql = "Select CDate FROM Clefs WHERE CID=""" & stgKeyId & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Dim stgDate As String = dt.Rows(0)(0)
            Dim newDate As DateTime = Convert.ToDateTime(stgDate)
            dtpDate.Value = newDate
            connecter().Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmEditKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCID.Text = strTitleCID & " :"
        lblCNom.Text = strTitleCNom & " :"
        lblCPosition.Text = strTitleCPosition & " :"
        lblCStatus.Text = strTitleCStatus & " :"
        lblCTrousseau.Text = strTitleCTrousseau & " :"
        lblCDate.Text = strTitleCDate & " :"
        LoadAndRefresh()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String

        Try
            sql = "UPDATE Clefs SET CID = '" & txtID.Text & "', CNom = '" & txtNom.Text & "', CPosition = '" & cmbLoc.Text & "', CDate = '" & dtpDate.Value.ToString("yyyy-MM-dd") & "', CTrousseau = '" & cmbTrousseauListe.Text & "' WHERE CID = '" & stgKeyId & "'"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            connecter().Close()
            frmMain.FillDataSource()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNewTrousseau_Click(sender As Object, e As EventArgs) Handles btnNewTrousseau.Click
        frmCreerTrousseau.ShowDialog()
    End Sub

    Private Sub btnNewLoc_Click(sender As Object, e As EventArgs) Handles btnNewLoc.Click
        frmGestionPosition.ShowDialog()
    End Sub
End Class