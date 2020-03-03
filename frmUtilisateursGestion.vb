Imports MySql.Data.MySqlClient

Public Class frmUtilisateursGestion
    Private Sub frmGestionUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        txtRechercher.SetWaterMark("Rechercher...")
        dgvListUser.Focus()
        RefreshList()
    End Sub

    Public Sub RefreshList()
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dtUser As New DataTable
        Dim sql As String

        Try

            sql = "Select LUserName, LUserType From Login where LUserName<>""" & userName & """ order by LUserName ASC"

            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dtUser)

            For i As Integer = 0 To dtUser.Columns.Count - 1
                dtUser.Columns(i).ColumnName = dtUser.Columns(i).ColumnName.ToString().Remove(0, 1)
            Next
            dgvListUser.DataSource = dtUser

            For i = 0 To dgvListUser.ColumnCount - 2
                dgvListUser.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            dgvListUser.Columns(dgvListUser.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        Dim searchValue As String = txtRechercher.Text
        Dim intIndexNom As Integer = dgvListUser.Columns("UserName").Index

        Try
            For i = 0 To dgvListUser.RowCount - 1
                If dgvListUser.Rows(i).Cells(intIndexNom).Value.ToString.IndexOf(searchValue, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                    dgvListUser.Rows(i).Selected = True
                    dgvListUser.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvListUser_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListUser.CellMouseDown
        If e.RowIndex <> -1 AndAlso e.ColumnIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                Dim clickedRow As DataGridViewRow = (TryCast(sender, DataGridView)).Rows(e.RowIndex)
                If Not clickedRow.Selected Then dgvListUser.CurrentCell = clickedRow.Cells(e.ColumnIndex)
                Dim mousePosition = dgvListUser.PointToClient(Cursor.Position)
                MenuListe.Show(dgvListUser, mousePosition)
            End If
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        DeleteRow(dgvListUser.SelectedRows(0).Cells(0).Value.ToString())
    End Sub

    Public Sub DeleteRow(stgUsername As String)
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim Message As String = "Voulez vous vraiment supprimer l'utilisateur sélectionnée ?"
        Dim Caption As String = "Supprimer un utilisateur"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

        Dim Result As DialogResult

        'Displays the MessageBox
        Result = MessageBox.Show(Message, Caption, Buttons, Icon)

        ' Gets the result of the MessageBox display.
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Dim cmd As New MySqlCommand
            Dim da As New MySqlDataAdapter

            Dim sql As String

            Try
                sql = "DELETE FROM Login WHERE LUserName=""" & stgUsername & """"
                With cmd
                    .Connection = connecter()
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                da.SelectCommand = cmd
                connecter().Close()
                RefreshList()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ChangerLeTypeDutilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerLeTypeDutilisateurToolStripMenuItem.Click
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim sql As String

        Dim UserToSwitch As String = dgvListUser.SelectedRows(0).Cells(0).Value.ToString()
        Dim UserToSwitchType As String = dgvListUser.SelectedRows(0).Cells(1).Value.ToString()
        Dim NewType As String
        If UserToSwitchType = "Administrateur" Then
            NewType = "Utilisateur"
        Else
            NewType = "Administrateur"
        End If

        Try
            sql = "UPDATE Login SET LUserType=""" & NewType & """ WHERE LUserName=""" & UserToSwitch & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da.SelectCommand = cmd
            connecter().Close()
            RefreshList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class