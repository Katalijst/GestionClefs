Imports System.Runtime.CompilerServices

Module EnumerableEx
    <Extension()>
    Iterator Function SplitBy(ByVal str As String, ByVal chunkLength As Integer) As IEnumerable(Of String)
        If String.IsNullOrEmpty(str) Then Throw New ArgumentException()
        If chunkLength < 1 Then Throw New ArgumentException()
        Dim i As Integer = 0

        While i < str.Length
            If chunkLength + i > str.Length Then chunkLength = str.Length - i
            Yield str.Substring(i, chunkLength)
            i += chunkLength
        End While
    End Function
End Module
