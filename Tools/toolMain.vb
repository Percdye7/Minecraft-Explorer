Imports System.ComponentModel
Imports Minecraft_Explorer.ImageHandler

Public Class toolMain

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

    Private Sub toolMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckNetworkConnection() = 1 Then
            Try
                ' Wooden Tools
                icon_woodenPickaxe.ImageLocation = ImageHandler.Icon_WoodenPickaxe
                icon_woodenAxe.ImageLocation = ImageHandler.Icon_WoodenAxe
                icon_woodenShovel.ImageLocation = ImageHandler.Icon_WoodenShovel
                icon_woodenHoe.ImageLocation = ImageHandler.Icon_WoodenHoe
                ' Stone Tools
                icon_stonePickaxe.ImageLocation = ImageHandler.Icon_StonePickaxe
                icon_stoneAxe.ImageLocation = ImageHandler.Icon_StoneAxe
                icon_stoneShovel.ImageLocation = ImageHandler.Icon_StoneShovel
                icon_stoneHoe.ImageLocation = ImageHandler.Icon_StoneHoe
                ' Iron Tools
                icon_ironPickaxe.ImageLocation = ImageHandler.Icon_IronPickaxe
                icon_ironAxe.ImageLocation = ImageHandler.Icon_IronAxe
                icon_ironShovel.ImageLocation = ImageHandler.Icon_IronShovel
                icon_ironHoe.ImageLocation = ImageHandler.Icon_IronHoe
                ' Gold Tools
                icon_goldPickaxe.ImageLocation = ImageHandler.Icon_GoldPickaxe
                icon_goldAxe.ImageLocation = ImageHandler.Icon_GoldAxe
                icon_goldShovel.ImageLocation = ImageHandler.Icon_GoldShovel
                icon_goldHoe.ImageLocation = ImageHandler.Icon_GoldHoe
                ' Diamond Tools
                icon_diamondPickaxe.ImageLocation = ImageHandler.Icon_DiamondPickaxe
                icon_diamondAxe.ImageLocation = ImageHandler.Icon_DiamondAxe
                icon_diamondShovel.ImageLocation = ImageHandler.Icon_DiamondShovel
                icon_diamondHoe.ImageLocation = ImageHandler.Icon_DiamondHoe
                ' Other Tools
                icon_othersFishingRod.ImageLocation = ImageHandler.Icon_othersFishingRod
                icon_othersFlintandSteel.ImageLocation = ImageHandler.Icon_othersFlintAndSteel
                icon_othersShears.ImageLocation = ImageHandler.Icon_othersShears
                icon_othersShield.ImageLocation = ImageHandler.Icon_othersShield

                icon_woodenPickaxe.WaitOnLoad = True
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try
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

#Region "openWoodenPickaxe"
    Private Sub btn_WoodenPickaxe_Click(sender As Object, e As EventArgs) Handles btn_WoodenPickaxe.Click
        WoodenPickaxe.Show()
    End Sub
#End Region
End Class