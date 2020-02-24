Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class frmEditerClef
    Shared stgKeyId As String
    Private Sub frmEditKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBatiment.Visible = False
        btnGrpBatiment.Visible = False
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        lblCID.Text = strTitleCID & " :"
        lblCNom.Text = strTitleCNom & " :"
        lblCPosition.Text = strTitleCPosition & " :"
        lblCStatus.Text = strTitleCStatus & " :"
        lblCTrousseau.Text = strTitleCTrousseau & " :"
        lblCDate.Text = strTitleCDate & " :"
        txtID.Hint = strTitleCID
        txtNom.Hint = strTitleCNom
        cmbLoc.Hint = strTitleCPosition
        'txtStatus.Hint = strTitleCStatus
        cmbTrousseauListe.Hint = strTitleCTrousseau
        LoadAndRefresh()
    End Sub

    Public Sub RefreshTrousseau()
        cmbTrousseauListe.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Trousseau where TNom <> 'Aucun';"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim newRow As DataRow = dt.NewRow()
            newRow(0) = "Aucun"
            dt.Rows.InsertAt(newRow, 0)
            For Each r As DataRow In dt.Rows
                cmbTrousseauListe.Items.Add(r.Item(0).ToString)
            Next

            'cmbTrousseauListe.DataSource = dt
            'cmbTrousseauListe.ValueMember = dt.Columns(0).ToString
            'cmbTrousseauListe.DisplayMember = strTitleTNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RefreshPosition()
        cmbLoc.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Try
            sql = "Select * from Position;"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                cmbLoc.Items.Add(r.Item(0).ToString)
            Next

            'cmbLoc.DataSource = dt
            'cmbLoc.ValueMember = dt.Columns(0).ToString
            'cmbLoc.DisplayMember = strTitlePNom

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAndRefresh()
        Dim blnOption As Boolean = False

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text
        'Dim intIndexID As Integer = frmMain.dgvResultats.Columns(strTitleCID).Index
        'stgKeyId = frmMain.dgvResultats.SelectedRows(stgKeyId).Cells(intIndexID).Value.ToString() & "-%"
        txtID.Text = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCID).Value

        Dim IDToLookFor As String = txtID.Text & "-%"

        RefreshTrousseau()
        RefreshPosition()


        cmbStatus.Items.Add(frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCStatus).Value)
        cmbStatus.Items.Add("Perdue")
        cmbStatus.SelectedIndex() = 0
        cmbLoc.SelectedItem = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCPosition).Value
        cmbTrousseauListe.SelectedItem = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCTrousseau).Value
        txtQuantity.Text = frmMain.dgvResultats.SelectedRows(0).Cells("Quantité").Value

        With cmd
            .Parameters.Add("@IDClef", MySqlDbType.String)
            .Parameters.Add("@StatutClef", MySqlDbType.VarChar)
            .Parameters.Add("@TableauClef", MySqlDbType.VarChar)
            .Parameters.Add("@TrousseauxClef", MySqlDbType.VarChar)
        End With

        Try
            dt.Reset()
            sql = "SELECT CID FROM Clefs WHERE CID LIKE @IDClef AND CStatus=@StatutClef AND CPosition=@TableauClef AND CTrousseau=@TrousseauxClef LIMIT 1;"
            With cmd
                .Parameters("@IDClef").Value = IDToLookFor
                .Parameters("@StatutClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCStatus).Value
                .Parameters("@TableauClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCPosition).Value
                .Parameters("@TrousseauxClef").Value = frmMain.dgvResultats.SelectedRows(0).Cells(strTitleCTrousseau).Value
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            stgKeyId = dt.Rows(0)(0)

            dt.Reset()
            sql = "Select CNom, CDate, CBatiment FROM Clefs WHERE CID like @IDClef;"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .Parameters("@IDClef").Value = stgKeyId
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            txtNom.Text = dt.Rows(0).Item(0)
            Dim stgDate As String = dt.Rows(0).Item(1)
            Dim newDate As DateTime = Convert.ToDateTime(stgDate)
            Dim batiment As String = dt.Rows(0).Item(2)

            If batiment = "Groupe de Batiments" Then
                lblBatiment.Visible = False
                btnGrpBatiment.Visible = True
                btnGrpBatiment.Enabled = True
            Else
                lblBatiment.Visible = True
                lblBatiment.Text = batiment
                btnGrpBatiment.Visible = False
                btnGrpBatiment.Enabled = False
            End If

            dt.Reset()
            sql = "Select RefOrg, CanonInte, CanonExte, CanonOpt FROM infostechniques WHERE IDClef like @IDClef;"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .Parameters("@IDClef").Value = txtID.Text
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                blnOption = True
                txtRefOrg.Text = dt.Rows(0).Item(0)
                txtCnInt.Text = dt.Rows(0).Item(1)
                txtCnExt.Text = dt.Rows(0).Item(2)
                txtCnOpt.Text = dt.Rows(0).Item(3)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connecter().Close()
        End Try

    End Sub

    Private Sub frmEditKey_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Dim sql As String
        Try
            sql = "UPDATE Clefs SET CID = @IDClef, CNom = @Nom, CPosition = @Tableau, CDate = @Date, CTrousseau = @Trousseau WHERE CID =  @IDClef"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .Parameters.Add("@IDClef", MySqlDbType.VarChar).Value = txtID.Text
                .Parameters.Add("@Nom", MySqlDbType.VarChar).Value = txtNom.Text
                .Parameters.Add("@Tableau", MySqlDbType.VarChar).Value = cmbLoc.Text
                .Parameters.Add("@Date", MySqlDbType.Date).Value = dtpDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                .Parameters.Add("@Trousseau", MySqlDbType.VarChar).Value = cmbTrousseauListe.Text
                .ExecuteNonQuery()
            End With
            connecter().Close()
            frmMain.FillDataSource()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnNewTrousseau_Click(sender As Object, e As EventArgs) Handles btnNewTrousseau.Click
        frmCreerTrousseau.ShowDialog()
    End Sub

    Private Sub btnNewLoc_Click(sender As Object, e As EventArgs) Handles btnNewLoc.Click
        frmGestionPosition.ShowDialog()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class