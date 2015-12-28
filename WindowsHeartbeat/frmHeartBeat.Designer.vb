<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHeartBeat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHeartBeat))
        Me.cboComPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPortSpeed = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbParity = New System.Windows.Forms.ComboBox()
        Me.cbBits = New System.Windows.Forms.ComboBox()
        Me.cbStopBits = New System.Windows.Forms.ComboBox()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.Settings = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpbSound = New System.Windows.Forms.GroupBox()
        Me.rbnInterval = New System.Windows.Forms.RadioButton()
        Me.rbn1Minute = New System.Windows.Forms.RadioButton()
        Me.rbn1Second = New System.Windows.Forms.RadioButton()
        Me.rbnNoBeep = New System.Windows.Forms.RadioButton()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHeartBeat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pgbRemaining = New System.Windows.Forms.ProgressBar()
        Me.heartBeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlSettings.SuspendLayout()
        Me.gpbSound.SuspendLayout()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboComPort
        '
        Me.cboComPort.FormattingEnabled = True
        resources.ApplyResources(Me.cboComPort, "cboComPort")
        Me.cboComPort.Name = "cboComPort"
        Me.ToolTip1.SetToolTip(Me.cboComPort, resources.GetString("cboComPort.ToolTip"))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cbPortSpeed
        '
        Me.cbPortSpeed.FormattingEnabled = True
        resources.ApplyResources(Me.cbPortSpeed, "cbPortSpeed")
        Me.cbPortSpeed.Name = "cbPortSpeed"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'cbParity
        '
        Me.cbParity.FormattingEnabled = True
        resources.ApplyResources(Me.cbParity, "cbParity")
        Me.cbParity.Name = "cbParity"
        '
        'cbBits
        '
        Me.cbBits.FormattingEnabled = True
        resources.ApplyResources(Me.cbBits, "cbBits")
        Me.cbBits.Name = "cbBits"
        '
        'cbStopBits
        '
        Me.cbStopBits.FormattingEnabled = True
        resources.ApplyResources(Me.cbStopBits, "cbStopBits")
        Me.cbStopBits.Name = "cbStopBits"
        '
        'pnlSettings
        '
        Me.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettings.Controls.Add(Me.Settings)
        Me.pnlSettings.Controls.Add(Me.TextBox1)
        Me.pnlSettings.Controls.Add(Me.Label9)
        Me.pnlSettings.Controls.Add(Me.gpbSound)
        Me.pnlSettings.Controls.Add(Me.btnDefault)
        Me.pnlSettings.Controls.Add(Me.Label1)
        Me.pnlSettings.Controls.Add(Me.btnSave)
        Me.pnlSettings.Controls.Add(Me.cboComPort)
        Me.pnlSettings.Controls.Add(Me.Label5)
        Me.pnlSettings.Controls.Add(Me.cbStopBits)
        Me.pnlSettings.Controls.Add(Me.Label2)
        Me.pnlSettings.Controls.Add(Me.cbPortSpeed)
        Me.pnlSettings.Controls.Add(Me.numInterval)
        Me.pnlSettings.Controls.Add(Me.Label7)
        Me.pnlSettings.Controls.Add(Me.txtHeartBeat)
        Me.pnlSettings.Controls.Add(Me.Label6)
        Me.pnlSettings.Controls.Add(Me.cbBits)
        Me.pnlSettings.Controls.Add(Me.Label4)
        Me.pnlSettings.Controls.Add(Me.cbParity)
        Me.pnlSettings.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.pnlSettings, "pnlSettings")
        Me.pnlSettings.Name = "pnlSettings"
        '
        'Settings
        '
        resources.ApplyResources(Me.Settings, "Settings")
        Me.Settings.Name = "Settings"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        Me.ToolTip1.SetToolTip(Me.TextBox1, resources.GetString("TextBox1.ToolTip"))
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'gpbSound
        '
        Me.gpbSound.Controls.Add(Me.rbnInterval)
        Me.gpbSound.Controls.Add(Me.rbn1Minute)
        Me.gpbSound.Controls.Add(Me.rbn1Second)
        Me.gpbSound.Controls.Add(Me.rbnNoBeep)
        resources.ApplyResources(Me.gpbSound, "gpbSound")
        Me.gpbSound.Name = "gpbSound"
        Me.gpbSound.TabStop = False
        '
        'rbnInterval
        '
        resources.ApplyResources(Me.rbnInterval, "rbnInterval")
        Me.rbnInterval.Name = "rbnInterval"
        Me.rbnInterval.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbnInterval, resources.GetString("rbnInterval.ToolTip"))
        Me.rbnInterval.UseVisualStyleBackColor = True
        '
        'rbn1Minute
        '
        resources.ApplyResources(Me.rbn1Minute, "rbn1Minute")
        Me.rbn1Minute.Name = "rbn1Minute"
        Me.rbn1Minute.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbn1Minute, resources.GetString("rbn1Minute.ToolTip"))
        Me.rbn1Minute.UseVisualStyleBackColor = True
        '
        'rbn1Second
        '
        resources.ApplyResources(Me.rbn1Second, "rbn1Second")
        Me.rbn1Second.Name = "rbn1Second"
        Me.rbn1Second.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbn1Second, resources.GetString("rbn1Second.ToolTip"))
        Me.rbn1Second.UseVisualStyleBackColor = True
        '
        'rbnNoBeep
        '
        resources.ApplyResources(Me.rbnNoBeep, "rbnNoBeep")
        Me.rbnNoBeep.Checked = True
        Me.rbnNoBeep.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbnNoBeep.Name = "rbnNoBeep"
        Me.rbnNoBeep.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbnNoBeep, resources.GetString("rbnNoBeep.ToolTip"))
        Me.rbnNoBeep.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        resources.ApplyResources(Me.btnDefault, "btnDefault")
        Me.btnDefault.Name = "btnDefault"
        Me.ToolTip1.SetToolTip(Me.btnDefault, resources.GetString("btnDefault.ToolTip"))
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.ToolTip1.SetToolTip(Me.btnSave, resources.GetString("btnSave.ToolTip"))
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'numInterval
        '
        resources.ApplyResources(Me.numInterval, "numInterval")
        Me.numInterval.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numInterval.Name = "numInterval"
        Me.ToolTip1.SetToolTip(Me.numInterval, resources.GetString("numInterval.ToolTip"))
        Me.numInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtHeartBeat
        '
        resources.ApplyResources(Me.txtHeartBeat, "txtHeartBeat")
        Me.txtHeartBeat.Name = "txtHeartBeat"
        Me.ToolTip1.SetToolTip(Me.txtHeartBeat, resources.GetString("txtHeartBeat.ToolTip"))
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lblActivity)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblRemaining)
        Me.Panel2.Controls.Add(Me.btnStop)
        Me.Panel2.Controls.Add(Me.btnStart)
        Me.Panel2.Controls.Add(Me.pgbRemaining)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsHeartbeat.My.Resources.Resources.redheart
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'lblActivity
        '
        resources.ApplyResources(Me.lblActivity, "lblActivity")
        Me.lblActivity.Name = "lblActivity"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsHeartbeat.My.Resources.Resources.HeartBeatflat
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lblRemaining
        '
        resources.ApplyResources(Me.lblRemaining, "lblRemaining")
        Me.lblRemaining.Name = "lblRemaining"
        '
        'btnStop
        '
        resources.ApplyResources(Me.btnStop, "btnStop")
        Me.btnStop.Name = "btnStop"
        Me.ToolTip1.SetToolTip(Me.btnStop, resources.GetString("btnStop.ToolTip"))
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.Name = "btnStart"
        Me.ToolTip1.SetToolTip(Me.btnStart, resources.GetString("btnStart.ToolTip"))
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pgbRemaining
        '
        resources.ApplyResources(Me.pgbRemaining, "pgbRemaining")
        Me.pgbRemaining.Name = "pgbRemaining"
        Me.pgbRemaining.Step = 1
        '
        'heartBeatTimer
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRestore, Me.tsmHide, Me.ToolStripSeparator1, Me.tsmStart, Me.tsmStop, Me.ToolStripSeparator2, Me.tsmExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'tsmRestore
        '
        Me.tsmRestore.Checked = True
        Me.tsmRestore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmRestore.Name = "tsmRestore"
        resources.ApplyResources(Me.tsmRestore, "tsmRestore")
        '
        'tsmHide
        '
        Me.tsmHide.Name = "tsmHide"
        resources.ApplyResources(Me.tsmHide, "tsmHide")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'tsmStart
        '
        Me.tsmStart.Name = "tsmStart"
        resources.ApplyResources(Me.tsmStart, "tsmStart")
        '
        'tsmStop
        '
        Me.tsmStop.Checked = True
        Me.tsmStop.CheckState = System.Windows.Forms.CheckState.Checked
        resources.ApplyResources(Me.tsmStop, "tsmStop")
        Me.tsmStop.Name = "tsmStop"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        resources.ApplyResources(Me.tsmExit, "tsmExit")
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'frmHeartBeat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHeartBeat"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.gpbSound.ResumeLayout(False)
        Me.gpbSound.PerformLayout()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboComPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPortSpeed As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbParity As ComboBox
    Friend WithEvents cbBits As ComboBox
    Friend WithEvents cbStopBits As ComboBox
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents heartBeatTimer As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pgbRemaining As ProgressBar
    Friend WithEvents btnDefault As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents numInterval As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHeartBeat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Settings As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gpbSound As GroupBox
    Friend WithEvents rbnInterval As RadioButton
    Friend WithEvents rbn1Minute As RadioButton
    Friend WithEvents rbn1Second As RadioButton
    Friend WithEvents rbnNoBeep As RadioButton
    Friend WithEvents lblActivity As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmRestore As ToolStripMenuItem
    Friend WithEvents tsmHide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmStart As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmStop As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
