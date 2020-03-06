Imports System.Reflection

Public Class frmAbout

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "A propos de " & My.Application.Info.Title.ToString & "..."
        lblVersion.Text = My.Application.Info.Version.ToString
        lblDate.Text = "2020 - " & My.Application.Info.CompanyName
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub lblFreepik_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFreepik.LinkClicked
        Process.Start("https://www.flaticon.com/authors/freepik")
    End Sub

    Private Sub lblPixel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPixel.LinkClicked
        Process.Start("https://www.flaticon.com/authors/pixel-perfect")
    End Sub

    Private Sub lblFlaticon1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFlaticon1.LinkClicked
        Process.Start("https://www.flaticon.com/")
    End Sub

    Private Sub lblFlaticon2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFlaticon2.LinkClicked
        Process.Start("https://www.flaticon.com/")
    End Sub
End Class