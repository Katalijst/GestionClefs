Imports MaterialSkin

Public Class frmParametres
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmParametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalUserType <> "Administrateur" Then
            btnGestionUtilisateurs.Enabled = False
            btnMySQL.Enabled = False
            btnServices.Enabled = False
        End If
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SkinManager.AddFormToManage(Me)
        swtDarkMode.Checked = Not (My.Settings.DarkMode)
        swtAlertPopUp.Checked = My.Settings.ShowAlert
    End Sub

    Private Sub frmParametres_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Private Sub btnChangerMotDePasse_Click(sender As Object, e As EventArgs) Handles btnChangerMotDePasse.Click
        frmUtilisateursPassword.ShowDialog()
    End Sub

    Private Sub btnGestionUtilisateurs_Click(sender As Object, e As EventArgs) Handles btnGestionUtilisateurs.Click
        frmUtilisateursGestion.ShowDialog()
    End Sub

    Private Sub btnMySQL_Click(sender As Object, e As EventArgs) Handles btnMySQL.Click
        frmParametresBDD.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub swtDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles swtDarkMode.CheckedChanged
        If swtDarkMode.Checked = False Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.DeepOrange400, TextShade.WHITE)
            My.Settings.DarkMode = True
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE)
            My.Settings.DarkMode = False
        End If
        If frmMain.IsHandleCreated Then
            frmMain.BrightOrDarkMode()
        End If
        My.Settings.Save()
    End Sub

    Private Sub swtAlertPopUp_CheckedChanged(sender As Object, e As EventArgs) Handles swtAlertPopUp.CheckedChanged
        If swtAlertPopUp.Checked = True Then
            My.Settings.ShowAlert = True
        Else
            My.Settings.ShowAlert = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        frmServicesGestion.ShowDialog()
    End Sub
End Class