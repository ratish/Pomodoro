<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPomodoro
    Inherits System.Windows.Forms.Form
    Public timerTime As Integer, workOrBreak As Integer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPomodoro))
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.colon = New System.Windows.Forms.Label()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.lblWorkCount = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ntfyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cntxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.Location = New System.Drawing.Point(82, 17)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(114, 79)
        Me.lblMinute.TabIndex = 0
        Me.lblMinute.Text = "00"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(228, 17)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(114, 79)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = "00"
        '
        'colon
        '
        Me.colon.AutoSize = True
        Me.colon.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colon.Location = New System.Drawing.Point(190, 16)
        Me.colon.Name = "colon"
        Me.colon.Size = New System.Drawing.Size(48, 69)
        Me.colon.TabIndex = 2
        Me.colon.Text = ":"
        '
        'btnWork
        '
        Me.btnWork.BackColor = System.Drawing.Color.ForestGreen
        Me.btnWork.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnWork.ForeColor = System.Drawing.Color.White
        Me.btnWork.Location = New System.Drawing.Point(16, 117)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(117, 58)
        Me.btnWork.TabIndex = 4
        Me.btnWork.Text = "Work"
        Me.btnWork.UseVisualStyleBackColor = False
        '
        'btnBreak
        '
        Me.btnBreak.BackColor = System.Drawing.Color.Crimson
        Me.btnBreak.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnBreak.ForeColor = System.Drawing.Color.White
        Me.btnBreak.Location = New System.Drawing.Point(172, 117)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(117, 58)
        Me.btnBreak.TabIndex = 5
        Me.btnBreak.Text = "Break"
        Me.btnBreak.UseVisualStyleBackColor = False
        '
        'lblWorkCount
        '
        Me.lblWorkCount.AutoSize = True
        Me.lblWorkCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWorkCount.Location = New System.Drawing.Point(419, 9)
        Me.lblWorkCount.Name = "lblWorkCount"
        Me.lblWorkCount.Size = New System.Drawing.Size(23, 25)
        Me.lblWorkCount.TabIndex = 8
        Me.lblWorkCount.Text = "0"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(327, 117)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 58)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(355, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Work : "
        '
        'ntfyIcon
        '
        Me.ntfyIcon.ContextMenuStrip = Me.cntxMenu
        Me.ntfyIcon.Icon = CType(resources.GetObject("ntfyIcon.Icon"), System.Drawing.Icon)
        Me.ntfyIcon.Text = "NotifyTimeOver"
        Me.ntfyIcon.Visible = True
        '
        'cntxMenu
        '
        Me.cntxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cntxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.AboutToolStripMenuItem, Me.menuItemExit})
        Me.cntxMenu.Name = "ContextMenuStrip1"
        Me.cntxMenu.Size = New System.Drawing.Size(176, 104)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ShowToolStripMenuItem.Text = "Show Form"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'menuItemExit
        '
        Me.menuItemExit.Name = "menuItemExit"
        Me.menuItemExit.Size = New System.Drawing.Size(175, 24)
        Me.menuItemExit.Text = "Exit"
        '
        'frmPomodoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 182)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblWorkCount)
        Me.Controls.Add(Me.btnBreak)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.colon)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPomodoro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomodoro"
        Me.cntxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim sec As String = Val(lblSecond.Text.ToString)
        Dim min As String = Val(lblMinute.Text.ToString)
        Dim workCount As Integer
        If min = 0 And sec = 0 Then
            resetForm()
            If timerTime = 25 Then
                ntfyIcon.BalloonTipText = "Time to take a break"
                workCount = Val(lblWorkCount.Text.ToString)
                lblWorkCount.Text = workCount + 1
            Else
                ntfyIcon.BalloonTipText = "Time to start work"
            End If
            ntfyIcon.Visible = True
            ntfyIcon.ShowBalloonTip(5000)
            'FlashWindow(Me.Handle, 1)
            lblMinute.Text = 0 & 0
            lblSecond.Text = 0 & 0

            Return
        End If
        If sec > 0 Then
            lblSecond.Text = sec - 1
            If lblSecond.Text.Length = 1 Then
                lblSecond.Text = 0 & lblSecond.Text
            End If
        Else
            lblSecond.Text = 59
            If min > 0 Then
                lblMinute.Text = min - 1
            End If
            If lblMinute.Text.Length = 1 Then
                lblMinute.Text = 0 & lblMinute.Text
            End If
        End If
    End Sub
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents colon As System.Windows.Forms.Label
    Friend WithEvents btnWork As System.Windows.Forms.Button

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        timerTime = 25
        btnWork.Enabled = False
        btnBreak.Enabled = True
        makeLabelVisible()
        lblMinute.Text = 25
        lblSecond.Text = 0 & 0
        timer.Start()
    End Sub
    Friend WithEvents btnBreak As System.Windows.Forms.Button

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        timerTime = 5
        btnBreak.Enabled = False
        btnWork.Enabled = True
        makeLabelVisible()
        lblMinute.Text = 0 & 5
        lblSecond.Text = 0 & 0
        timer.Start()
    End Sub

    Friend WithEvents lblWorkCount As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
        lblMinute.Text = 0 & 0
        lblSecond.Text = 0 & 0
        lblWorkCount.Text = 0
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Sub resetForm()
        timer.Stop()
        makeLabelVisible()
        btnWork.Enabled = True
        btnBreak.Enabled = True
    End Sub

    Sub makeLabelVisible()
        lblMinute.Visible = True
        lblSecond.Visible = True
        colon.Visible = True
    End Sub

    Sub InitialiseBalloonTip()
        ntfyIcon.BalloonTipTitle = "Pomodoro"
        ntfyIcon.BalloonTipIcon = ToolTipIcon.Info
    End Sub
    Friend WithEvents ntfyIcon As System.Windows.Forms.NotifyIcon

    Private Sub frmPomodoro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
    End Sub

    Private Sub frmPomodoro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseBalloonTip()
    End Sub
    Friend WithEvents cntxMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuItemExit As System.Windows.Forms.ToolStripMenuItem

    Private Sub menuItemExit_Click(sender As Object, e As EventArgs) Handles menuItemExit.Click
        End 'Close()
    End Sub

    Private Sub frmPomodoro_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
        Else
            ShowInTaskbar = True
        End If
    End Sub

    Private Sub ntfyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ntfyIcon.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class
