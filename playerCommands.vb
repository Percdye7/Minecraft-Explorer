Imports Minecraft_Explorer.Globals
Imports System.Net

Public Class playerCommands


    Dim loc As Point
    Dim loc2 As Point

    Dim NewestVersion = My.Settings.ApplicationV
    Dim Changelog As String


    Private Sub playerCommands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim WebCl = New WebClient()
        Changelog = WebCl.DownloadString("http://mcsl.bplaced.net/mce/playerCommands.txt")
        WebCl.Dispose()

        RichTextBox1.Text = RichTextBox1.Text & Changelog
    End Sub

#Region "Mouse Handle"
    Private Sub formBorderPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles formBorderPanel.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub formBorderPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles formBorderPanel.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub formTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles formTitle.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            loc2 = e.Location
        End If
    End Sub

    Private Sub formTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles formTitle.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc2
        End If
    End Sub
#End Region ' Giving the Form the ability to get Moveable by the Mouse

    Private Sub commands_Click(sender As Object, e As EventArgs) Handles commands.Click
        Me.Close()
    End Sub

End Class