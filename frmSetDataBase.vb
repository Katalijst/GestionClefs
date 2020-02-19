Public Class frmSetDataBase
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pré remplissage avec anciennes valeurs
        txtServeur.Text = My.Settings.MySQL_Serveur
        txtDatabase.Text = My.Settings.MySQL_Database
        txtID.Text = My.Settings.MySQL_ID
        txtPassword.Text = My.Settings.MySQL_Password

        'Anciennes valeurs
        txtActServeur.Text = My.Settings.MySQL_Serveur
        txtActDatabase.Text = My.Settings.MySQL_Database
        txtActID.Text = My.Settings.MySQL_ID
        txtActPassword.Text = My.Settings.MySQL_Password

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim stgModif As String = ""
        ' Initializes variables to pass to the MessageBox.Show method.
        If My.Settings.MySQL_Serveur <> txtServeur.Text Then
            stgModif = stgModif & "Serveur : " & My.Settings.MySQL_Serveur & " --> " & txtServeur.Text & vbCrLf
        End If
        If My.Settings.MySQL_Database <> txtDatabase.Text Then
            stgModif = stgModif & "Base de donnée : " & My.Settings.MySQL_Database & " --> " & txtDatabase.Text & vbCrLf
        End If
        If My.Settings.MySQL_ID <> txtID.Text Then
            stgModif = stgModif & "Identifiant : " & My.Settings.MySQL_ID & " --> " & txtID.Text & vbCrLf
        End If
        If My.Settings.MySQL_Password <> txtPassword.Text Then
            stgModif &= "Mot de passe"
        End If

        If stgModif <> "" Then
            Dim Message As String = "Confirmez les changements :" & vbCrLf & vbCrLf _
            & stgModif

            Dim Caption As String = "Confirmez les changements"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

            Dim Result As DialogResult

            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)

            ' Gets the result of the MessageBox display.
            If Result = System.Windows.Forms.DialogResult.Yes Then

                My.Settings.MySQL_Serveur = txtServeur.Text
                My.Settings.MySQL_Database = txtDatabase.Text
                My.Settings.MySQL_ID = txtID.Text
                My.Settings.MySQL_Password = txtPassword.Text
                My.Settings.Save()
                If frmSettings.IsHandleCreated Then
                    frmSettings.RefreshMySQL()
                End If

                Me.Close()
            End If
        Else
            Dim Message As String = "Aucun changements effectué !"

            Dim Caption As String = "Attention !"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Icon As MessageBoxIcon = MessageBoxIcon.Warning

            Dim Result As DialogResult

            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons, Icon)
            Me.Close()
        End If
    End Sub

End Class