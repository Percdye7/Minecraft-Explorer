<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.formBorderPanel = New System.Windows.Forms.Panel()
        Me.endapp_picturebox = New System.Windows.Forms.PictureBox()
        Me.formTitle = New System.Windows.Forms.Label()
        Me.openSettings = New System.Windows.Forms.Button()
        Me.buttonMobs = New System.Windows.Forms.Button()
        Me.picturebox_creeperface = New System.Windows.Forms.PictureBox()
        Me.picturebox_settings = New System.Windows.Forms.PictureBox()
        Me.picturebox_blocks = New System.Windows.Forms.PictureBox()
        Me.buttonBlocks = New System.Windows.Forms.Button()
        Me.formBorderPanel.SuspendLayout()
        CType(Me.endapp_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_creeperface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_blocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'formBorderPanel
        '
        Me.formBorderPanel.BackColor = System.Drawing.Color.Teal
        Me.formBorderPanel.Controls.Add(Me.endapp_picturebox)
        Me.formBorderPanel.Controls.Add(Me.formTitle)
        Me.formBorderPanel.Location = New System.Drawing.Point(0, 0)
        Me.formBorderPanel.Name = "formBorderPanel"
        Me.formBorderPanel.Size = New System.Drawing.Size(282, 27)
        Me.formBorderPanel.TabIndex = 0
        '
        'endapp_picturebox
        '
        Me.endapp_picturebox.Location = New System.Drawing.Point(259, 5)
        Me.endapp_picturebox.Name = "endapp_picturebox"
        Me.endapp_picturebox.Size = New System.Drawing.Size(16, 16)
        Me.endapp_picturebox.TabIndex = 1
        Me.endapp_picturebox.TabStop = False
        '
        'formTitle
        '
        Me.formTitle.AutoSize = True
        Me.formTitle.Font = New System.Drawing.Font("Minecraftia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTitle.ForeColor = System.Drawing.Color.White
        Me.formTitle.Location = New System.Drawing.Point(11, 5)
        Me.formTitle.Name = "formTitle"
        Me.formTitle.Size = New System.Drawing.Size(173, 18)
        Me.formTitle.TabIndex = 0
        Me.formTitle.Text = "Minecraft Explorer"
        '
        'openSettings
        '
        Me.openSettings.BackColor = System.Drawing.Color.Red
        Me.openSettings.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.openSettings.FlatAppearance.BorderSize = 0
        Me.openSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openSettings.ForeColor = System.Drawing.Color.White
        Me.openSettings.Location = New System.Drawing.Point(52, 320)
        Me.openSettings.Name = "openSettings"
        Me.openSettings.Size = New System.Drawing.Size(75, 23)
        Me.openSettings.TabIndex = 1
        Me.openSettings.Text = "Settings"
        Me.openSettings.UseVisualStyleBackColor = False
        '
        'buttonMobs
        '
        Me.buttonMobs.BackColor = System.Drawing.Color.Red
        Me.buttonMobs.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.buttonMobs.FlatAppearance.BorderSize = 0
        Me.buttonMobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonMobs.ForeColor = System.Drawing.Color.White
        Me.buttonMobs.Location = New System.Drawing.Point(52, 267)
        Me.buttonMobs.Name = "buttonMobs"
        Me.buttonMobs.Size = New System.Drawing.Size(75, 23)
        Me.buttonMobs.TabIndex = 2
        Me.buttonMobs.Text = "All Mobs"
        Me.buttonMobs.UseVisualStyleBackColor = False
        '
        'picturebox_creeperface
        '
        Me.picturebox_creeperface.Location = New System.Drawing.Point(14, 263)
        Me.picturebox_creeperface.Name = "picturebox_creeperface"
        Me.picturebox_creeperface.Size = New System.Drawing.Size(32, 32)
        Me.picturebox_creeperface.TabIndex = 3
        Me.picturebox_creeperface.TabStop = False
        '
        'picturebox_settings
        '
        Me.picturebox_settings.Location = New System.Drawing.Point(14, 315)
        Me.picturebox_settings.Name = "picturebox_settings"
        Me.picturebox_settings.Size = New System.Drawing.Size(32, 32)
        Me.picturebox_settings.TabIndex = 4
        Me.picturebox_settings.TabStop = False
        '
        'picturebox_blocks
        '
        Me.picturebox_blocks.Location = New System.Drawing.Point(14, 210)
        Me.picturebox_blocks.Name = "picturebox_blocks"
        Me.picturebox_blocks.Size = New System.Drawing.Size(32, 32)
        Me.picturebox_blocks.TabIndex = 6
        Me.picturebox_blocks.TabStop = False
        '
        'buttonBlocks
        '
        Me.buttonBlocks.BackColor = System.Drawing.Color.Red
        Me.buttonBlocks.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.buttonBlocks.FlatAppearance.BorderSize = 0
        Me.buttonBlocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBlocks.ForeColor = System.Drawing.Color.White
        Me.buttonBlocks.Location = New System.Drawing.Point(52, 214)
        Me.buttonBlocks.Name = "buttonBlocks"
        Me.buttonBlocks.Size = New System.Drawing.Size(75, 23)
        Me.buttonBlocks.TabIndex = 5
        Me.buttonBlocks.Text = "All Blocks"
        Me.buttonBlocks.UseVisualStyleBackColor = False
        '
        'startupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(282, 359)
        Me.Controls.Add(Me.picturebox_blocks)
        Me.Controls.Add(Me.buttonBlocks)
        Me.Controls.Add(Me.picturebox_settings)
        Me.Controls.Add(Me.picturebox_creeperface)
        Me.Controls.Add(Me.buttonMobs)
        Me.Controls.Add(Me.openSettings)
        Me.Controls.Add(Me.formBorderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "startupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minecraft Explorer"
        Me.formBorderPanel.ResumeLayout(False)
        Me.formBorderPanel.PerformLayout()
        CType(Me.endapp_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_creeperface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_blocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formBorderPanel As Panel
    Friend WithEvents formTitle As Label
    Friend WithEvents endapp_picturebox As PictureBox
    Friend WithEvents openSettings As Button
    Friend WithEvents buttonMobs As Button
    Friend WithEvents picturebox_creeperface As PictureBox
    Friend WithEvents picturebox_settings As PictureBox
    Friend WithEvents picturebox_blocks As PictureBox
    Friend WithEvents buttonBlocks As Button
End Class
