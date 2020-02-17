Imports MySql.Data.MySqlClient

Public Class frmPrincipale
    Dim srcKeyList As New BindingSource()
    Dim srcOwner As New BindingSource()

    Private Sub frmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDataSource()
    End Sub

    Public Sub FillDataSource()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtKeyList As DataTable = New DataTable()
        Dim dtOwner As DataTable = New DataTable()
        Dim sql As String

        Try

            sql = "Select CID, CNom, CPosition, CStatus, CTrousseau, CBatiment from Clefs Where CID <> ""0"""

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtKeyList)
            For i As Integer = 0 To dtKeyList.Columns.Count - 1
                dtKeyList.Columns(i).ColumnName = dtKeyList.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            srcKeyList.DataSource = dtKeyList

            dgvResultats.DataSource = srcKeyList

            dgvResultats.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvResultats.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each column In dgvResultats.Columns
                column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            sql = "SELECT CTrousseau, CID, CNom, CPosition, CStatus, ENomPersonne, EDateDebut, EDateFin FROM Clefs, Emprunts WHERE Clefs.CID = Emprunts.EIDClef AND CStatus like ""%"" and CID <> ""0"""
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtOwner)
            For i As Integer = 0 To dtOwner.Columns.Count - 1
                dtOwner.Columns(i).ColumnName = dtOwner.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            srcOwner.DataSource = dtOwner

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Filter()
        Dim chkNumber As Integer = 0
        'Création de tout les cas possible de filtre pour les cases à cochées
        '(utilisation d'une sorte de "table de Karnaugh")
        If chkDisponibles.Checked = True Then
            chkNumber += 4
        End If
        If chkEmpruntees.Checked = True Then
            chkNumber += 2
        End If
        If chkAttribuees.Checked = True Then
            chkNumber += 1
        End If
        If cbRechercher.Text <> "Emprunteur" Then
            Select Case chkNumber
                Case 1
                    srcKeyList.Filter = "Status='Attribuée'"
                Case 2
                    srcKeyList.Filter = "Status='Empruntée'"
                Case 3
                    srcKeyList.Filter = "Status='Attribuée' OR Status= 'Empruntée'"
                Case 4
                    srcKeyList.Filter = "Status='Disponible'"
                Case 5
                    srcKeyList.Filter = "Status='Attribuée' OR Status= 'Disponible'"
                Case 6
                    srcKeyList.Filter = "Status='Disponible' OR Status= 'Empruntée'"
                Case Else
                    srcKeyList.Filter = ""
            End Select
        Else
            Select Case chkNumber
                Case 1
                    srcOwner.Filter = "Status='Attribuée'"
                Case 2
                    srcOwner.Filter = "Status='Empruntée'"
                Case 3
                    srcOwner.Filter = "Status='Attribuée' OR Status= 'Empruntée'"
                Case 4
                    srcOwner.Filter = "Status='Disponible'"
                Case 5
                    srcOwner.Filter = "Status='Attribuée' OR Status= 'Disponible'"
                Case 6
                    srcOwner.Filter = "Status='Disponible' OR Status= 'Empruntée'"
                Case Else
                    srcOwner.Filter = ""
            End Select
        End If
    End Sub

    Private Sub chkDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisponibles.CheckedChanged
        Filter()
    End Sub

    Private Sub chkEmpruntees_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmpruntees.CheckedChanged
        Filter()
    End Sub

    Private Sub chkAttribuees_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttribuees.CheckedChanged
        Filter()
    End Sub

    Private Sub cbRechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRechercher.SelectedIndexChanged
        'Filtres du type de recherche
        If cbRechercher.Text = "ID" Then
            dgvResultats.DataSource = srcKeyList
            'intColumnNb = dgvResultats.Columns("ID").Index
        ElseIf cbRechercher.Text = "Nom" Then
            dgvResultats.DataSource = srcKeyList
            'intColumnNb = dgvResultats.Columns("Nom").Index
        ElseIf cbRechercher.Text = "Emprunteur" Then
            dgvResultats.DataSource = srcOwner
            'intColumnNb = dgvResultats.Columns("NomPersonne").Index
        ElseIf cbRechercher.Text = "Lieu" Then
            dgvResultats.DataSource = srcKeyList
            'intColumnNb = dgvResultats.Columns("Position").Index
        End If
    End Sub

End Class