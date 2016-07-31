Imports Minecraft_Explorer.Globals
Imports System.IO
Imports System.Net

Public Class Updater
    Dim loc As Point
    Dim loc2 As Point

    Dim FullPath As String = "C:/Users/" + UserName + "/Downloads/Minecraft Explorer.exe"
    Dim Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Dim DesktopEXEPath = Desktop + "/Minecraft Explorer.exe"
    Dim NewestVersion As String
    Dim Changelog As String

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim webclient2 = New WebClient()
            NewestVersion = webclient2.DownloadString("http://mcsl.bplaced.net/mce/version.txt")
            webclient2.Dispose()


            Dim WebCl = New WebClient()
            Changelog = WebCl.DownloadString("http://mcsl.bplaced.net/mce/changelogs/changelog_" + NewestVersion + ".txt")
            WebCl.Dispose()

            richtextbox_Changelog.Text = richtextbox_Changelog.Text & Changelog
        Catch ex As Exception

        End Try
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

#Region "Exit"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
#End Region

#Region "Call Update function from Globals.vb"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If File.Exists(FullPath) Then ' If file exists Delete and download new.
            File.Delete(FullPath)

            Globals.Update("http://mcsl.bplaced.net/mce/Minecraft%20Explorer.exe", FullPath, Desktop, "", "", True, 150, True)
            File.Move(FullPath, DesktopEXEPath)

            If File.Exists(DesktopEXEPath) Then
                updateNotification.Show()
            Else
                MsgBox("Something gone wrong with the Update.")
            End If

        Else ' if file doesn't exist
                Globals.Update("http://mcsl.bplaced.net/mce/Minecraft%20Explorer.exe", FullPath, Desktop, "", "", True, 150, True)
            File.Move(FullPath, DesktopEXEPath)

            If File.Exists(DesktopEXEPath) Then
                updateNotification.Show()
            Else
                MsgBox("Something gone wrong with the Update.")
            End If
        End If
    End Sub
#End Region
End Class
