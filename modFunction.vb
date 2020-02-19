Imports MySql.Data.MySqlClient
'Imports utilisés pour la création de watermarks dans les textbox :
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Imports System.Drawing.Imaging

Module modFunction
    'Fonction de connection à la BDD
    Public Function connecter()
        'Création du string de connexion
        'Voir pour ajouter port éventuellement
        Dim myConnectionString As String = "Server=" & My.Settings.MySQL_Serveur & ";Port=3308" & ";Database=" & My.Settings.MySQL_Database & ";Uid=" & My.Settings.MySQL_ID & ";Pwd=" & My.Settings.MySQL_Password
        Dim con As MySqlConnection = New MySqlConnection With {
            .ConnectionString = myConnectionString
        }

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

    Public Function DoesTableExist(ByVal TableName As String)
        'Permet de vérifier qu'une table existe
        Dim DoesTheTableExist As Boolean = False
        Try
            connecter.Open()

            Dim restrictions(3) As String
            restrictions(2) = TableName
            Dim dbTbl As DataTable = connecter.GetSchema("Tables", restrictions)

            If dbTbl.Rows.Count = 0 Then
                'Table does not exist
                DoesTheTableExist = False
            Else
                'Table exists
                DoesTheTableExist = True
            End If

            dbTbl.Dispose()
            connecter.Close()
            connecter.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
        End Try
        Return DoesTheTableExist
    End Function

    Public Function CreateTableID()
        'Permet la création d'une table, une fonction par table
        Dim sql As String
        Dim Success As Boolean = True
        Try
            connecter.Open()
            'Parties à éditer pour la création de la table
            Dim TableName As String = "NomDeLaTable"
            sql = "CREATE TABLE " & TableName & " (id INT(6) NOT NULL AUTO_INCREMENT,otherField TEXT NOT NULL,PRIMARY KEY (id));"
            Dim cmd As New MySqlCommand(sql, connecter)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.Number & " - " & ex.Message)
            Success = False
        Finally
            connecter.Close()
        End Try
        Return Success
    End Function

    Public Function TintBitmap(b As Bitmap, color As Color, intensity As Single) As Bitmap
        Dim b2 As New Bitmap(b.Width, b.Height)

        Dim ia As New ImageAttributes

        Dim m As ColorMatrix
        m = New ColorMatrix(New Single()() _
            {New Single() {1, 0, 0, 0, 0},
             New Single() {0, 1, 0, 0, 0},
             New Single() {0, 0, 1, 0, 0},
             New Single() {0, 0, 0, 1, 0},
             New Single() {color.R / 255 * intensity, color.G / 255 * intensity, color.B / 255 * intensity, 0, 1}})

        ia.SetColorMatrix(m)
        Dim g As Graphics = Graphics.FromImage(b2)
        g.DrawImage(b, New Rectangle(0, 0, b.Width, b.Height), 0, 0, b.Width, b.Height, GraphicsUnit.Pixel, ia)
        Return b2

    End Function

    Public Function InvertColors(bmp As Bitmap) As Bitmap
        Dim width As Integer = bmp.Width
        Dim height As Integer = bmp.Height

        For y As Integer = 0 To height - 1

            For x As Integer = 0 To width - 1
                Dim p As Color = bmp.GetPixel(x, y)
                Dim a As Integer = p.A
                Dim r As Integer = p.R
                Dim g As Integer = p.G
                Dim b As Integer = p.B
                r = 255 - r
                g = 255 - g
                b = 255 - b
                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b))
            Next
        Next
        Return bmp
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

    <Extension()>
    Public Iterator Function GetAllChildren(ByVal root As Control) As IEnumerable(Of Control)
        Dim stack = New Stack(Of Control)()
        stack.Push(root)

        While stack.Any()
            Dim [next] = stack.Pop()

            For Each child As Control In [next].Controls
                stack.Push(child)
            Next

            Yield [next]
        End While
    End Function

End Module