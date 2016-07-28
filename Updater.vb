Public Class Updater
    Dim loc As Point
    Dim loc2 As Point

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Update()
    End Sub
#End Region
End Class