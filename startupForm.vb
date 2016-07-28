Imports System.Net
Imports System.IO
Imports Minecraft_Explorer.Globals


' -------> GERMAN <-------
' Dies ist ein Komplett- Re-write des Minecraft Explorers
' Weil die Sehr Alte Version mittlerweile nicht mehr von VB unterstuezt wird, Nicht gut aussah und Viele Programmfehler
' gehabt hat.
'
' Danke an twitch.tv/TheNotSoScienceGuy fuer das Helfen des Designs und dem Farben

' -------> ENGLISH <-------
' This is a Full Re-write of the Minecraft Explorer
' It got re-writed by me because the Old one was not Supported Anymore/ Deprecated
' it didn't look well and got many Bugs and Issues
'
' Thanks to twitch.tv/TheNotSoScienceGuy for Helping me out with The Designs and Colors.

Public Class startupForm

#Region "Private Variables"
    Dim loc As Point
    Dim loc2 As Point

    Dim BlockClose As Boolean = False

    ' Important for Updates
    Dim ApplicationWebClient As New WebClient
    Dim ApplicationVersion As String = My.Settings.ApplicationV
    Dim AktuelleVersion As String = ApplicationWebClient.DownloadString("http://mcsl.bplaced.net/mce/version.txt") 'URL Muss zum Server & version.txt Fuehren!
#End Region ' startupForm Variables

#Region "Check Network Connection"
    Function CheckNetworkConnection()
        Try
            My.Computer.Network.Ping("www.google.de")
            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function
#End Region

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

#Region "Load Up the Program"
    Private Sub startupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check Network Connection
        If CheckNetworkConnection() = 1 Then
            initGlobals() ' Initializes all Command's sent by the 'Globals.vb'
        Else
            If CheckNetworkConnection() = 0 Then
                MsgBox("You are not Connected with the Internet, please check your connection.", MsgBoxStyle.Critical, "Error: No Network Connection!")
                Application.Exit()
            End If
        End If

        Try
            If ApplicationVersion = AktuelleVersion Then
                'Nothing
            Else
                If ApplicationVersion < AktuelleVersion Then
                    BlockClose = True
                    Updater.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("An Exception has occured: " + ex.GetType.Name + vbNewLine + "the reason if it is: " + vbNewLine + vbNewLine + ex.GetBaseException.ToString)
        End Try

    End Sub
#End Region ' Initialize all Commands while Starting

#Region "Close Operation for Program"
    Private Sub endapp_picturebox_Click(sender As Object, e As EventArgs) Handles endapp_picturebox.Click
        If BlockClose = False Then
            Application.Exit()
        Else
            If BlockClose = True Then
                'nothing
            End If
        End If
    End Sub
#End Region ' Close Icon in the top-right




#Region "Button Blocks"
    Private Sub buttonBlocks_Click(sender As Object, e As EventArgs) Handles buttonBlocks.Click
        allBlocks.Show()
    End Sub
#End Region

#Region "Button Mobs"
    Private Sub buttonMobs_Click(sender As Object, e As EventArgs) Handles buttonMobs.Click
        allMobs.Show()
    End Sub
#End Region

#Region "Button Settings"
    Private Sub openSettings_Click(sender As Object, e As EventArgs) Handles openSettings.Click
        Settings.Show()
    End Sub
#End Region



End Class
