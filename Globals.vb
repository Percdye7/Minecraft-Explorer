Imports System.Net
Imports System.Drawing
Imports System.IO
Imports Minecraft_Explorer.startupForm
Imports Minecraft_Explorer.Updater
Imports Minecraft_Explorer.allMobs
Imports Minecraft_Explorer.allBlocks
Imports Minecraft_Explorer.allItmes
Imports Minecraft_Explorer.allRedstoneCommands
Imports Minecraft_Explorer.playerCommands
Imports Minecraft_Explorer.updateNotification
Imports Minecraft_Explorer.allStructures
Imports Minecraft_Explorer.Settings
Imports Minecraft_Explorer.authorAndThanks
Imports Minecraft_Explorer.browseWiki
Imports Minecraft_Explorer.allCommands

Public Class Globals
    ' Global Variables of the Minecraft Explorer
    ' Summary <Public Shared VARNAME as DATATYPE>
    ' or optional Summary <Public Shared VARNAME as DATATYPE = "">
    ' Strings MUST be <Public Shared> To be readable by other Forms.

    ' Die Variablen welche bei einem Control zb. Picturebox gesetzt werden Muessen,
    ' denen muss (zb. in dem fall mit der Picturebox) das Bild in dem .initGlobals() Sub 
    ' Bereits Gesetzt werden, und NICHT in der Form selber,
    ' Die Betroffene Form welche das Ziel-Control besitzt muss Importiert werden.
    ' Summary <Imports Minecraft_Explorer.Zielform>

    ' Application Icons
    Public Shared close_icon As Image
    Public Shared app_icon As Icon
    ' Application Images
    Public Shared CreeperFace As Image
    Public Shared SettingsWrench As Image
    Public Shared blockStoneBricks As Image
    Public Shared iconIngot As Image
    Public Shared MyProfilePicture As Image
    Public Shared RedstoneIcon As Image
    Public Shared blockStructureBlock As Image
    Public Shared iconCommandBlock As Image
    ' Application Colors
    Public Shared GlobalAppColorStyleFormBackground As Color
    Public Shared GlobalAppColorStyleFormPanel As Color

    Public Shared ButtonColorStyleofMainButtons As Color
    ' Variables and Stuff.
    Public Shared UserName = Environment.UserName

    Public Shared Minecraft_Explorer_Process As Process()


    ' in der .initGlobals() Klasse koennen auch andere Sachen,
    ' ausser Variablen gesetzt werden.
    Public Shared Sub initGlobals() ' Initialize the Variables

        Dim DownloadPath = "C:/Users/" + UserName + "/Downloads"
        Minecraft_Explorer_Process = Process.GetProcessesByName("Minecraft Explorer")


#Region "Application Icons"
        Dim close_icon As Image = My.Resources.icon_close ' Icon size = 16 x 16
        startupForm.endapp_picturebox.Image = close_icon ' Set Image for Close_Operation Picturebox

        Dim app_icon As Icon = My.Resources.app_icon ' Icon size 48 x 48
        startupForm.Icon = app_icon ' Set Icon for form 'startupForm'
#End Region

#Region "startupForm Button Icons"

        iconCommandBlock = My.Resources.icon_commandBlock
        startupForm.picturebox_commands.Image = iconCommandBlock

        blockStructureBlock = My.Resources.icon_StructureBlock
        startupForm.picturebox_structures.Image = blockStructureBlock

        RedstoneIcon = My.Resources.icon_redstone
        startupForm.picturebox_redstoneCommands.Image = RedstoneIcon

        iconIngot = My.Resources.icon_ingot
        startupForm.picturebox_items.Image = iconIngot

        blockStoneBricks = My.Resources.icon_blockStoneBricks
        startupForm.picturebox_blocks.Image = blockStoneBricks

        CreeperFace = My.Resources.icon_creeper
        startupForm.picturebox_creeperface.Image = CreeperFace

        SettingsWrench = My.Resources.icon_settingsWrench
        startupForm.picturebox_settings.Image = SettingsWrench
#End Region

#Region "Profile Pictures"
        Dim MyProfilePicture As Image = My.Resources.icon_me
        authorAndThanks.picturebox_iconme.Image = MyProfilePicture
#End Region

#Region "Block Config / Colors"
        ' Button Colors of startupForm
        Dim ButtonColorStyleofMainButtons = ColorTranslator.FromWin32(RGB(26, 137, 31))
        'Commands Button
        startupForm.commands.BackColor = ButtonColorStyleofMainButtons
        startupForm.commands.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'All Structures Button
        startupForm.openStructures.BackColor = ButtonColorStyleofMainButtons
        startupForm.openStructures.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Redstone Commands Button
        startupForm.openRedstoneCommands.BackColor = ButtonColorStyleofMainButtons
        startupForm.openRedstoneCommands.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Ingot Button
        startupForm.buttonItems.BackColor = ButtonColorStyleofMainButtons
        startupForm.buttonItems.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Blocks Button
        startupForm.buttonBlocks.BackColor = ButtonColorStyleofMainButtons
        startupForm.buttonBlocks.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Mobs Button
        startupForm.buttonMobs.BackColor = ButtonColorStyleofMainButtons
        startupForm.buttonMobs.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Settings Button
        startupForm.openSettings.BackColor = ButtonColorStyleofMainButtons
        startupForm.openSettings.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'About Button
        startupForm.openAbout.BackColor = ButtonColorStyleofMainButtons
        startupForm.openAbout.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Browse in Wiki Button
        startupForm.openWikibrowse.BackColor = ButtonColorStyleofMainButtons
        startupForm.openWikibrowse.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
#End Region

        ' All Forms Must be registered Here

#Region "startupForm"
        Dim GlobalAppColorStyleFormPanel As Color = ColorTranslator.FromWin32(RGB(71, 142, 78)) ' Basic Style = Dark Green
        Dim GlobalAppColorStyleFormBackground As Color = ColorTranslator.FromWin32(RGB(54, 188, 72)) ' Basic Style = Light Green

        startupForm.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        startupForm.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region ' Colors of startupForm


#Region "authorAndThanks"
        authorAndThanks.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        authorAndThanks.BackColor = GlobalAppColorStyleFormBackground

        authorAndThanks.ScienceGuy.ForeColor = ColorTranslator.FromWin32(RGB(100, 65, 164))

        authorAndThanks.exitAbout.BackColor = ButtonColorStyleofMainButtons
        authorAndThanks.exitAbout.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
#End Region

#Region "Updater"
        Updater.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        Updater.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region ' Colors of Updater

#Region "allMobs"
        allMobs.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        allMobs.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region ' Colors of allMobs

#Region "allBlocks"
        allBlocks.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allBlocks.BackColor = GlobalAppColorStyleFormBackground
#End Region ' Colors of allBlocks

#Region "Settings"
        Settings.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        Settings.BackColor = GlobalAppColorStyleFormBackground
#End Region ' Colors of Settings

#Region "allItems"
        allItmes.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allItmes.BackColor = GlobalAppColorStyleFormBackground
#End Region ' Colors of allItems

#Region "allRedstoneCommands"
        allRedstoneCommands.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allRedstoneCommands.BackColor = GlobalAppColorStyleFormBackground
#End Region ' Colors of allRedstoneCommands

#Region "allStructures"
        allStructures.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allStructures.BackColor = GlobalAppColorStyleFormBackground
#End Region ' Colors of allStructures

#Region "browseWiki"
        browseWiki.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        browseWiki.BackColor = GlobalAppColorStyleFormBackground

        browseWiki.browse.BackColor = ButtonColorStyleofMainButtons ' Browse Button
        browseWiki.browse.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons

        browseWiki.exitForm.BackColor = ButtonColorStyleofMainButtons
        browseWiki.exitForm.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
#End Region

#Region "allCommands"
        allCommands.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allCommands.BackColor = GlobalAppColorStyleFormBackground

        allCommands.PictureBox1.Image = close_icon
#End Region

#Region "updateNotification"
        updateNotification.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        updateNotification.BackColor = GlobalAppColorStyleFormBackground

        updateNotification.okay.BackColor = ButtonColorStyleofMainButtons
        updateNotification.okay.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
#End Region

#Region "playerCommands"
        playerCommands.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        playerCommands.BackColor = GlobalAppColorStyleFormBackground
#End Region

        ' End of all forms

    End Sub
    Public Shared Sub Update(ServerURL As String, FolderPath As String, DesktopEXE As String, CredentialsUsername As String, CredentialsPassword As String,
                             showUI As Boolean, timeout As Integer, overwrite As Boolean) ' Update Function for the Program
        Try
            My.Computer.Network.DownloadFile(ServerURL, FolderPath, CredentialsUsername, CredentialsPassword, showUI, timeout, overwrite)

            If File.Exists(FolderPath) Then
                File.Move(FolderPath, DesktopEXE)
            End If

        Catch ex As Exception
            ' Ignore error, works fine...
        End Try




    End Sub
End Class
