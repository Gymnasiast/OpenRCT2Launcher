﻿Imports Launcher.My.Resources

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLauncher
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrCheckIfDone = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdLaunchGame = New System.Windows.Forms.Button()
        Me.cmdForceUpdate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkVerbose = New System.Windows.Forms.CheckBox()
        Me.cmdExtras = New System.Windows.Forms.Button()
        Me.chkLogToFile = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCheckIfDone
        '
        Me.tmrCheckIfDone.Enabled = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(158, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = frmLauncher_updateStatus_baseText
        '
        'cmdLaunchGame
        '
        Me.cmdLaunchGame.Enabled = False
        Me.cmdLaunchGame.Location = New System.Drawing.Point(345, 212)
        Me.cmdLaunchGame.Name = "cmdLaunchGame"
        Me.cmdLaunchGame.Size = New System.Drawing.Size(127, 37)
        Me.cmdLaunchGame.TabIndex = 1
        Me.cmdLaunchGame.Text = frmLauncher_launchGameButton_text
        Me.cmdLaunchGame.UseVisualStyleBackColor = True
        '
        'cmdForceUpdate
        '
        Me.cmdForceUpdate.Enabled = False
        Me.cmdForceUpdate.Location = New System.Drawing.Point(246, 212)
        Me.cmdForceUpdate.Name = "cmdForceUpdate"
        Me.cmdForceUpdate.Size = New System.Drawing.Size(93, 37)
        Me.cmdForceUpdate.TabIndex = 2
        Me.cmdForceUpdate.Text = frmLauncher_forceUpdateButton_text
        Me.cmdForceUpdate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'chkVerbose
        '
        Me.chkVerbose.AutoSize = True
        Me.chkVerbose.Location = New System.Drawing.Point(12, 212)
        Me.chkVerbose.Name = "chkVerbose"
        Me.chkVerbose.Size = New System.Drawing.Size(100, 17)
        Me.chkVerbose.TabIndex = 4
        Me.chkVerbose.Text = frmLauncher_verboseOutputButton_text
        Me.chkVerbose.UseVisualStyleBackColor = True
        '
        'cmdExtras
        '
        Me.cmdExtras.Location = New System.Drawing.Point(147, 212)
        Me.cmdExtras.Name = "cmdExtras"
        Me.cmdExtras.Size = New System.Drawing.Size(93, 37)
        Me.cmdExtras.TabIndex = 5
        Me.cmdExtras.Text = frmLauncher_extrasButton_text
        Me.cmdExtras.UseVisualStyleBackColor = True
        '
        'chkLogToFile
        '
        Me.chkLogToFile.AutoSize = True
        Me.chkLogToFile.Location = New System.Drawing.Point(12, 235)
        Me.chkLogToFile.Name = "chkLogToFile"
        Me.chkLogToFile.Size = New System.Drawing.Size(110, 17)
        Me.chkLogToFile.TabIndex = 6
        Me.chkLogToFile.Text = frmLauncher_logButton_text
        Me.chkLogToFile.UseVisualStyleBackColor = True
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.chkLogToFile)
        Me.Controls.Add(Me.cmdExtras)
        Me.Controls.Add(Me.chkVerbose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdForceUpdate)
        Me.Controls.Add(Me.cmdLaunchGame)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "frmLauncher"
        Me.Text = frmLauncher_title
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrCheckIfDone As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdLaunchGame As System.Windows.Forms.Button
    Friend WithEvents cmdForceUpdate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents cmdExtras As System.Windows.Forms.Button
    Friend WithEvents chkLogToFile As System.Windows.Forms.CheckBox

End Class
