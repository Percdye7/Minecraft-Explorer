Imports System.Net
Imports System.Drawing
Imports Minecraft_Explorer.startupForm
Imports Minecraft_Explorer.Updater
Imports Minecraft_Explorer.allMobs
Imports Minecraft_Explorer.allBlocks
Imports Minecraft_Explorer.Settings

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

    ' Application Colors
    Public Shared GlobalAppColorStyleFormBackground As Color
    Public Shared GlobalAppColorStyleFormPanel As Color

    Public Shared ButtonColorStyleofMainButtons As Color


    ' in der .initGlobals() Klasse koennen auch andere Sachen,
    ' ausser Variablen gesetzt werden.
    Public Shared Sub initGlobals() ' Initialize the Variables

#Region "Application Icons"
        Dim close_icon As Image = My.Resources.icon_close ' Icon size = 16 x 16
        startupForm.endapp_picturebox.Image = close_icon ' Set Image for Close_Operation Picturebox

        Dim app_icon As Icon = My.Resources.app_icon ' Icon size 48 x 48
        startupForm.Icon = app_icon ' Set Icon for form 'startupForm'
#End Region

#Region "startupForm Button Icons"
        blockStoneBricks = My.Resources.icon_blockStoneBricks
        startupForm.picturebox_blocks.Image = blockStoneBricks

        CreeperFace = My.Resources.icon_creeper
        startupForm.picturebox_creeperface.Image = CreeperFace

        SettingsWrench = My.Resources.icon_settingsWrench
        startupForm.picturebox_settings.Image = SettingsWrench
#End Region

#Region "Block Config / Colors"
        ' Button Colors of startupForm
        Dim ButtonColorStyleofMainButtons = ColorTranslator.FromWin32(RGB(26, 137, 31))
        'Blocks Button
        startupForm.buttonBlocks.BackColor = ButtonColorStyleofMainButtons
        startupForm.buttonBlocks.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Mobs Button
        startupForm.buttonMobs.BackColor = ButtonColorStyleofMainButtons
        startupForm.buttonMobs.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
        'Settings Button
        startupForm.openSettings.BackColor = ButtonColorStyleofMainButtons
        startupForm.openSettings.FlatAppearance.BorderColor = ButtonColorStyleofMainButtons
#End Region

        ' All Forms Must be registered Here

#Region "startupForm"
        Dim GlobalAppColorStyleFormPanel As Color = ColorTranslator.FromWin32(RGB(71, 142, 78)) ' Basic Style = Teal
        Dim GlobalAppColorStyleFormBackground As Color = ColorTranslator.FromWin32(RGB(54, 188, 72)) ' Basic Style = LightSeaGreen

        startupForm.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        startupForm.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region ' Colors of startupForm

#Region "Updater"
        Updater.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        Updater.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region ' Colors of Updater

#Region "allMobs"
        allMobs.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel ' Panel Back Color
        allMobs.BackColor = GlobalAppColorStyleFormBackground ' Form Back-Color
#End Region

#Region "allBlocks"
        allBlocks.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        allBlocks.BackColor = GlobalAppColorStyleFormBackground
#End Region

#Region "Settings"
        Settings.formBorderPanel.BackColor = GlobalAppColorStyleFormPanel
        Settings.BackColor = GlobalAppColorStyleFormBackground
#End Region

        ' End of all forms

    End Sub
    Public Shared Sub Update() ' Update Function for the Program

    End Sub
End Class
