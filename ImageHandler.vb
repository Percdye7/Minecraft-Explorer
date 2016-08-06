Imports Minecraft_Explorer.Globals
Imports System.Net
Imports System.IO
Public Class ImageHandler

#Region "All Tool Images"
    'Wooden Tools
    Public Shared Icon_WoodenPickaxe As String
    Public Shared Icon_WoodenAxe As String
    Public Shared Icon_WoodenShovel As String
    Public Shared Icon_WoodenHoe As String
    'Stone Tools
    Public Shared Icon_StonePickaxe As String
    Public Shared Icon_StoneAxe As String
    Public Shared Icon_StoneShovel As String
    Public Shared Icon_StoneHoe As String
    'Iron Tools
    Public Shared Icon_IronPickaxe As String
    Public Shared Icon_IronAxe As String
    Public Shared Icon_IronShovel As String
    Public Shared Icon_IronHoe As String
    'Gold Tools
    Public Shared Icon_GoldPickaxe As String
    Public Shared Icon_GoldAxe As String
    Public Shared Icon_GoldShovel As String
    Public Shared Icon_GoldHoe As String
    'Diamond Tools
    Public Shared Icon_DiamondPickaxe As String
    Public Shared Icon_DiamondAxe As String
    Public Shared Icon_DiamondShovel As String
    Public Shared Icon_DiamondHoe As String
    'Other Tools
    Public Shared Icon_othersFishingRod As String
    Public Shared Icon_othersFlintAndSteel As String
    Public Shared Icon_othersShears As String
    Public Shared Icon_othersShield As String
#End Region

#Region "All Crafting Images"
    Public Shared Crafting_WoodenPickaxe As String
#End Region

    Public Shared Sub initImgs()
#Region "Register All Tool Images"
        Icon_WoodenPickaxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_WoodenPickaxe.png"
        Icon_WoodenAxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_WoodenAxe.png"
        Icon_WoodenShovel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_WoodenShovel.png"
        Icon_WoodenHoe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_WoodenHoe.png"

        Icon_StonePickaxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_StonePickaxe.png"
        Icon_StoneAxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_StoneAxe.png"
        Icon_StoneShovel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_StoneShovel.png"
        Icon_StoneHoe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_StoneHoe.png"

        Icon_IronPickaxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_IronPickaxe.png"
        Icon_IronAxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_IronAxe.png"
        Icon_IronShovel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_IronShovel.png"
        Icon_IronHoe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_IronHoe.png"

        Icon_GoldPickaxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_GoldPickaxe.png"
        Icon_GoldAxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_GoldAxe.png"
        Icon_GoldShovel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_GoldShovel.png"
        Icon_GoldHoe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_GoldHoe.png"

        Icon_DiamondPickaxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_DiamondPickaxe.png"
        Icon_DiamondAxe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_DiamondAxe.png"
        Icon_DiamondShovel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_DiamondShovel.png"
        Icon_DiamondHoe = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_DiamondHoe.png"

        Icon_othersFishingRod = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_OthersFishingRod.png"
        Icon_othersFlintAndSteel = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_OthersFlintAndSteel.png"
        Icon_othersShears = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_OthersShears.png"
        Icon_othersShield = "http://mcsl.bplaced.net/mce/resources/toolIcons/icon_OthersShield.png"
#End Region

#Region "Register All Crafting Images"
        Crafting_WoodenPickaxe = "http://mcsl.bplaced.net/mce/resources/craftingImages/Crafting_WoodenPickaxe.png"
#End Region
    End Sub

End Class
