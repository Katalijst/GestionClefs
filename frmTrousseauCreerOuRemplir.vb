Imports MySql.Data.MySqlClient

Public Class frmTrousseauCreerOuRemplir

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmTrousseauCreerOuRemplir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        RefreshTrousseau()
    End Sub

    Private Sub frmTrousseauCreerOuRemplir_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Public Sub RefreshTrousseau(ByVal Optional selected As String = "Empty")
        Dim dtTrousseaux As New DataTable
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim CmdSql As String = "Select TNom From Trousseau where TNom <> 'Aucun' order by TNom ASC"
        Try
            With cmd
                .Connection = connecter()
                .CommandText = CmdSql
            End With
            da.SelectCommand = cmd
            da.Fill(dtTrousseaux)

            Dim srcTrousseaux As String() = New String(dtTrousseaux.Rows.Count) {}
            Dim i As Integer = 0
            For Each r As DataRow In dtTrousseaux.Rows
                srcTrousseaux(i) = r.Item(0).ToString
                i += 1
            Next
            cbTrousseaux.DataSource = srcTrousseaux
            If selected <> "Empty" Then
                cbTrousseaux.Text = selected
            End If
            connecter().Close()
        Catch ex As MySqlException
            MsgBox(ex.Code & " - " & ex.Message)
        End Try

    End Sub

    Private Sub CreerOuSelectionner()
        If chkAjouter.Checked = True Then
            cbTrousseaux.Visible = True
            txtNomTrousseau.Visible = False
        ElseIf chkCreer.Checked = True Then
            cbTrousseaux.Visible = False
            txtNomTrousseau.Visible = True
        End If
    End Sub


    Private Sub ValiderAjoutOuCreation()
        If chkAjouter.Checked = True Then
            If cbTrousseaux.SelectedIndex < 0 Then Exit Sub Else Ajouter()
        ElseIf chkCreer.Checked = True Then
            If txtNomTrousseau.Text.Replace(" ", "") <> "" Then CreerTrousseau() Else Exit Sub
        End If
    End Sub
    Private Sub Ajouter()
        Dim blnClefDejaDansTrousseau As Boolean = False
        If frmMain.dgvPanier.SelectedRows.Count > 0 Then
            Dim cmdUpdateClef As New MySqlCommand
            cmdUpdateClef.CommandType = CommandType.Text
            With cmdUpdateClef
                .Parameters.Add("@IDClef", MySqlDbType.String)
                .Parameters.Add("@Nom", MySqlDbType.VarChar)
                .Parameters.Add("@Tableau", MySqlDbType.VarChar)
                .Parameters.Add("@Status", MySqlDbType.VarChar)
                .Parameters.Add("@Trousseau", MySqlDbType.VarChar)
                .Parameters.Add("@OldTrousseauxClef", MySqlDbType.VarChar)
            End With
            Try
                For Each r As DataGridViewRow In frmMain.dgvPanier.Rows.OfType(Of DataGridViewRow)().ToArray()
                    If r.Cells(strTitleCTrousseau).Value = "Aucun" Then
                        With cmdUpdateClef
                            .Parameters("@IDClef").Value = r.Cells(0).Value & "-%"
                            .Parameters("@Nom").Value = r.Cells(1).Value
                            .Parameters("@Tableau").Value = r.Cells(2).Value
                            .Parameters("@Status").Value = r.Cells(3).Value
                            'CHANGER CETTE VALEUR
                            If chkAjouter.Checked = True Then
                                .Parameters("@Trousseau").Value = cbTrousseaux.Text
                            ElseIf chkCreer.Checked = True Then
                                .Parameters("@Trousseau").Value = txtNomTrousseau.Text
                            End If
                            .Parameters("@OldTrousseauxClef").Value = r.Cells(strTitleCTrousseau).Value
                            .Connection = connecter()
                            .CommandText = "UPDATE Clefs SET CTrousseau=@Trousseau WHERE CID=(SELECT * FROM (SELECT CID FROM Clefs where CNom=@Nom AND CStatus=@Status AND CPosition=@Tableau AND CTrousseau=@OldTrousseauxClef AND CID LIKE @IDClef LIMIT 1) TempTable);"
                            .ExecuteNonQuery()
                        End With
                    Else
                        blnClefDejaDansTrousseau = True
                    End If
                Next
            Catch ex As MySqlException
                MsgBox(ex.Code & " - " & ex.Message)
            End Try
            frmMain.FillDataSource()
        End If
        If blnClefDejaDansTrousseau = True Then
            'Pop-up (message box):
            ' Initializes variables to pass to the MessageBox.Show method.
            Dim Message As String = "Une ou plusieurs clefs faisaient déjà partie d'un trousseau et n'ont pas été prise en compte."
            Dim Caption As String = "Attention !"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning
            Dim Result As DialogResult
            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)
        End If
        Me.Close()
    End Sub

    Private Sub CreerTrousseau()
        If txtNomTrousseau.Text.Replace(" ", "") <> "" And txtNomTrousseau.Text.Replace(" ", "") <> "Aucun" Then
            Try
                Dim insert_command As New MySqlCommand("INSERT INTO `Trousseau`(`TNom`) VALUES (@name)", connecter())
                insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtNomTrousseau.Text
                insert_command.ExecuteNonQuery()
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MsgBox("Un trousseau existe déjà avec ce nom.", MsgBoxStyle.Critical, "Trousseau existant")
                Else
                    MsgBox(ex.Number & " - " & ex.Message)
                    Exit Sub
                End If
            Finally
                connecter().Close()
            End Try
        Else
            MsgBox("Le nom du trousseau entré n'est pas valide, veuillez le changer.", MsgBoxStyle.Critical, "Nom de trousseau incorrect")
            Exit Sub
        End If

        If frmTrousseauxGestion.IsHandleCreated Then
            frmTrousseauxGestion.RefreshTrousseau(txtNomTrousseau.Text)
        End If
        If frmClefsAjout.IsHandleCreated Then
            frmClefsAjout.RefreshTrousseau(txtNomTrousseau.Text)
        End If

        Ajouter()
    End Sub

    Private Sub chkAjouter_CheckedChanged(sender As Object, e As EventArgs) Handles chkAjouter.CheckedChanged
        CreerOuSelectionner()
    End Sub

    Private Sub chkCreer_CheckedChanged(sender As Object, e As EventArgs) Handles chkCreer.CheckedChanged
        CreerOuSelectionner()
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        ValiderAjoutOuCreation()
    End Sub
End Class