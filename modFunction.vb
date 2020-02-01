Imports MySql.Data.MySqlClient
'Imports utilisés pour la création de watermarks dans les textbox :
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

Module modFunction
    'Fonction de connection à la BDD
    Public Function connecter()
        'Création du string de connexion
        Dim myConnectionString As String = "Server=" & My.Settings.MySQL_Serveur & ";Database=" & My.Settings.MySQL_Database & ";Uid=" & My.Settings.MySQL_ID & ";Pwd=" & My.Settings.MySQL_Password
        Dim con As MySqlConnection = New MySqlConnection
        con.ConnectionString = myConnectionString
        Try
            con.Open()
        Catch ex As MySqlException
            'Retour d'une erreur my MySQL si connection impossible
            MsgBox(ex.Number & " - " & ex.Message)
            Using FormShow As New Form
                frmSetDataBase.ShowDialog()
            End Using
        End Try
        Return con
    End Function
End Module
Public Module TextBoxExtensions
    'Module pour les watermarks dans les textbox

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Function SendMessageW(hWnd As IntPtr, Msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As IntPtr
    End Function

    <Extension()>
    Public Sub SetWaterMark(tb As TextBox, watermark As String)
        SendMessageW(tb.Handle, EM_SETCUEBANNER, 1, watermark)
    End Sub

End Module