Imports Minecraft_Explorer.Globals

Public Class CheckMinecraftServerStatus

    Dim loc As Point
    Dim loc2 As Point

    Private Sub CheckMinecraftServerStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countonesec.Start()
    End Sub

    Private Sub countonesec_Tick(sender As Object, e As EventArgs) Handles countonesec.Tick
        CheckMinecraftServers()
        countonesec.Stop()
    End Sub

    Private Sub okay_Click(sender As Object, e As EventArgs) Handles okay.Click
        Me.Close()
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

End Class