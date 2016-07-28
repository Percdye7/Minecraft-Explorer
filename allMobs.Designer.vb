<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allMobs
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
        Me.formTitle = New System.Windows.Forms.Label()
        Me.formBorderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'formBorderPanel
        '
        Me.formBorderPanel.BackColor = System.Drawing.Color.Teal
        Me.formBorderPanel.Controls.Add(Me.formTitle)
        Me.formBorderPanel.Location = New System.Drawing.Point(0, 0)
        Me.formBorderPanel.Name = "formBorderPanel"
        Me.formBorderPanel.Size = New System.Drawing.Size(284, 27)
        Me.formBorderPanel.TabIndex = 0
        '
        'formTitle
        '
        Me.formTitle.AutoSize = True
        Me.formTitle.Font = New System.Drawing.Font("Minecraftia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTitle.ForeColor = System.Drawing.Color.White
        Me.formTitle.Location = New System.Drawing.Point(94, 4)
        Me.formTitle.Name = "formTitle"
        Me.formTitle.Size = New System.Drawing.Size(79, 18)
        Me.formTitle.TabIndex = 2
        Me.formTitle.Text = "All Mobs"
        '
        'allMobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.formBorderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "allMobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "allMobs"
        Me.formBorderPanel.ResumeLayout(False)
        Me.formBorderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formBorderPanel As Panel
    Friend WithEvents formTitle As Label
End Class
