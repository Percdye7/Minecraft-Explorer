Public Class Settings
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

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub CheckNet_Click(sender As Object, e As EventArgs) Handles CheckNet.Click
        If CheckNetworkConnection() = 1 Then
            MsgBox("Your Network works Fine :^)", MsgBoxStyle.Information, "Network Connection")
        Else
            If CheckNetworkConnection() = 0 Then
                MsgBox("You are not Connected with the Internet, please check your connection.", MsgBoxStyle.Critical, "Error: No Network Connection!")
                Application.Exit()
            End If
        End If
    End Sub

End Class
