Public Class browseWiki

    Dim loc As Point
    Dim loc2 As Point

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

    Private Sub browseWiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckNetworkConnection() = 1 Then
            'nothing
        Else
            If CheckNetworkConnection() = 0 Then
                MsgBox("You are not Connected with the Internet, please check your connection.", MsgBoxStyle.Critical, "Error: No Network Connection!")
                Application.Exit()
            End If
        End If
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

    Private Sub exitForm_Click(sender As Object, e As EventArgs) Handles exitForm.Click
        Me.Close()
    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        If browseURL.Text = "" Then
            MsgBox("Please type something in.")
        Else
            If germwiki.Checked = True Then
                Process.Start("http://minecraft-de.gamepedia.com/index.php?search=" + browseURL.Text)
            Else
                If engwiki.Checked = True Then
                    Process.Start("http://minecraft.gamepedia.com/index.php?search=" + browseURL.Text)
                End If
            End If
        End If
    End Sub
End Class