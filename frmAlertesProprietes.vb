Imports MySql.Data.MySqlClient

Public Class frmAlertesProprietes
    Dim stgKeyID As String

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmPropAlertes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        lblCID.Text = strTitleCID & " :"
        lblCNom.Text = strTitleCNom & " :"
        lblCPosition.Text = strTitleCPosition & " :"
        lblCStatus.Text = strTitleCStatus & " :"
        lblCTrousseau.Text = strTitleCTrousseau & " :"
        lblCDate.Text = strTitleCDate & " :"
        lblENomPersonne.Text = strTitleENomPersonne & " :"
        lblNTelephone.Text = strTitleNTelephone & " :"
        'lblNAutre.Text = strTitleNAutre & " :"

        Dim cmd As New MySqlCommand
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Dim sql As String
        If frmClefsEmpruntsEtAlertes.TabCtrlAlertesPerduesEmprunts.SelectedTab Is frmClefsEmpruntsEtAlertes.tabEnCours Then
            stgKeyID = frmClefsEmpruntsEtAlertes.dgvEmpruntsEnCours.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & frmClefsEmpruntsEtAlertes.dgvEmpruntsEnCours.SelectedRows(0).Cells("ID").Value.ToString()
        ElseIf frmClefsEmpruntsEtAlertes.TabCtrlAlertesPerduesEmprunts.SelectedTab Is frmClefsEmpruntsEtAlertes.tabPerdues Then
            stgKeyID = frmClefsEmpruntsEtAlertes.dgvClefsPerdues.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & frmClefsEmpruntsEtAlertes.dgvClefsPerdues.SelectedRows(0).Cells("ID").Value.ToString()
        Else
            stgKeyID = frmClefsEmpruntsEtAlertes.dgvAlertes.SelectedRows(0).Cells(strTitleCID).Value.ToString() & "-" & frmClefsEmpruntsEtAlertes.dgvAlertes.SelectedRows(0).Cells("ID").Value.ToString()
        End If

        Dim input As String = stgKeyID
        Dim index As Integer = input.LastIndexOf("-")
        If index > 0 Then
            lblID.Text = input.Substring(0, index)
        End If

        Try
            dt.Reset()
            sql = "Select CStatus FROM Clefs WHERE CID=""" & stgKeyID & """"
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lblStatus.Text = dt.Rows(0)(0).ToString
            End If

            dt.Reset()
            If lblStatus.Text <> "Disponible" Then
                sql = "Select CNom, CPosition, CDate, CTrousseau, CBatiment, EIDGenre, ENomPersonne, EDateDebut, EDateFin, NTelephone, NAutre FROM Clefs, Emprunts, NomPersonne WHERE CID=""" & stgKeyID & """ And EIDClef=CID And NNom=ENomPersonne And NGenre=EIDGenre"
            Else
                sql = "Select CNom, CPosition, CDate, CTrousseau, CBatiment FROM Clefs WHERE CID=""" & stgKeyID & """"
            End If
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                lblNom.Text = dt.Rows(0)(0).ToString
                Me.Text = "Propriétés de : " & dt.Rows(0)(0).ToString
                lblLoc.Text = dt.Rows(0)(1).ToString
                Dim DateAjout As Date = dt.Rows(0)(2)
                lblDateAjout.Text = DateAjout.ToString("dd/MM/yyyy")
                lblTrousseau.Text = dt.Rows(0)(3).ToString
                If dt.Rows(0)(4).ToString <> "Groupe de Batiments" Then
                    btnGrpBatiment.Enabled = False
                    btnGrpBatiment.Visible = False
                    lblBatiment.Visible = True
                    lblBatiment.Text = dt.Rows(0)(4).ToString
                Else
                    btnGrpBatiment.Enabled = True
                    btnGrpBatiment.Visible = True
                    lblBatiment.Visible = False
                End If
                If lblStatus.Text <> "Disponible" Then
                    lblGenre.Text = dt.Rows(0)(5).ToString
                    lblPersonne.Text = dt.Rows(0)(6).ToString
                    'gbEmprunt.Enabled = True
                    Dim DateDebut As Date = dt.Rows(0)(7)
                    lblDateDebut.Text = DateDebut.ToString("dd/MM/yyyy")
                    If lblStatus.Text = "Attribuée" Then
                        lblTitleDateDebut.Text = "Date d'attribution :"
                        lblTitleDateFin.Visible = False
                        lblDateDebut.Visible = True
                        lblDateFin.Visible = False
                    ElseIf lblStatus.Text = "Empruntée" Then
                        Dim DateFin As Date = dt.Rows(0)(8)
                        lblDateFin.Text = DateFin.ToString("dd/MM/yyyy")
                        lblTitleDateDebut.Text = "Date d'emprunt :"
                        lblTitleDateFin.Visible = True
                        lblDateDebut.Visible = True
                        lblDateFin.Visible = True
                    End If
                    lblTel.Text = dt.Rows(0)(9).ToString
                    txtAutres.Text = dt.Rows(0)(10).ToString
                Else
                    lblTitleDateDebut.Visible = False
                    lblTitleDateFin.Visible = False
                    lblDateDebut.Visible = False
                    lblDateFin.Visible = False
                    'gbEmprunt.Enabled = False
                    lblGenre.Text = String.Empty
                    lblPersonne.Text = String.Empty
                    lblTel.Text = String.Empty
                    txtAutres.Text = String.Empty
                End If
            End If

            Dim stgNameOfKey As String = stgKeyID.Remove(stgKeyID.LastIndexOf("-"))
            Dim nomClef As String = stgNameOfKey
            Dim intClefDispo As Integer
            Dim intTotalClef As Integer
            dt.Reset()
            sql = "Select CID FROM Clefs WHERE CID like """ & nomClef & "-%"""
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            intTotalClef = dt.Rows.Count
            dt.Reset()
            sql = "Select CID FROM Clefs WHERE CStatus=""Disponible"" AND CID like """ & nomClef & "-%"""
            With cmd
                .Connection = connecter()
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            intClefDispo = dt.Rows.Count

            lblNbClef.Text = intClefDispo & " clefs disponible" & Environment.NewLine & (intTotalClef - intClefDispo) & " clefs empruntées" & Environment.NewLine & "Total : " & intTotalClef

            connecter().Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnGrpBatiment_Click(sender As Object, e As EventArgs) Handles btnGrpBatiment.Click
        frmClefsEditerEtProprietesGroupeBat.ShowDialog()
    End Sub

    Private Sub txtAutres_TextChanged(sender As Object, e As EventArgs) Handles txtAutres.TextChanged

    End Sub
End Class