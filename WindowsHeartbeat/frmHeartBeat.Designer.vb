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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.cboComPort.Location = New System.Drawing.Point(77, 34)
        Me.cboComPort.Name = "cboComPort"
        Me.cboComPort.Size = New System.Drawing.Size(180, 21)
        Me.cboComPort.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cboComPort, "Select the com port to send heartbeats to")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Com Port :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Speed :"
        '
        'cbPortSpeed
        '
        Me.cbPortSpeed.FormattingEnabled = True
        Me.cbPortSpeed.Location = New System.Drawing.Point(77, 62)
        Me.cbPortSpeed.Name = "cbPortSpeed"
        Me.cbPortSpeed.Size = New System.Drawing.Size(180, 21)
        Me.cbPortSpeed.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Parity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(16, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bits :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stop Bits :"
        '
        'cbParity
        '
        Me.cbParity.FormattingEnabled = True
        Me.cbParity.Location = New System.Drawing.Point(77, 116)
        Me.cbParity.Name = "cbParity"
        Me.cbParity.Size = New System.Drawing.Size(180, 21)
        Me.cbParity.TabIndex = 9
        '
        'cbBits
        '
        Me.cbBits.FormattingEnabled = True
        Me.cbBits.Location = New System.Drawing.Point(77, 89)
        Me.cbBits.Name = "cbBits"
        Me.cbBits.Size = New System.Drawing.Size(180, 21)
        Me.cbBits.TabIndex = 10
        '
        'cbStopBits
        '
        Me.cbStopBits.FormattingEnabled = True
        Me.cbStopBits.Location = New System.Drawing.Point(77, 143)
        Me.cbStopBits.Name = "cbStopBits"
        Me.cbStopBits.Size = New System.Drawing.Size(180, 21)
        Me.cbStopBits.TabIndex = 11
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
        Me.pnlSettings.Location = New System.Drawing.Point(24, 12)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(282, 372)
        Me.pnlSettings.TabIndex = 17
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Settings.Location = New System.Drawing.Point(17, 9)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(67, 17)
        Me.Settings.TabIndex = 34
        Me.Settings.Text = "Settings"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Acknowledgement from heartbeat server - blank to ignore")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(16, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Ack :"
        '
        'gpbSound
        '
        Me.gpbSound.Controls.Add(Me.rbnInterval)
        Me.gpbSound.Controls.Add(Me.rbn1Minute)
        Me.gpbSound.Controls.Add(Me.rbn1Second)
        Me.gpbSound.Controls.Add(Me.rbnNoBeep)
        Me.gpbSound.Location = New System.Drawing.Point(19, 256)
        Me.gpbSound.Name = "gpbSound"
        Me.gpbSound.Size = New System.Drawing.Size(238, 72)
        Me.gpbSound.TabIndex = 31
        Me.gpbSound.TabStop = False
        Me.gpbSound.Text = "Sound"
        '
        'rbnInterval
        '
        Me.rbnInterval.AutoSize = True
        Me.rbnInterval.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbnInterval.Location = New System.Drawing.Point(6, 43)
        Me.rbnInterval.Name = "rbnInterval"
        Me.rbnInterval.Size = New System.Drawing.Size(60, 17)
        Me.rbnInterval.TabIndex = 3
        Me.rbnInterval.TabStop = True
        Me.rbnInterval.Text = "Interval"
        Me.ToolTip1.SetToolTip(Me.rbnInterval, "Beep on completion of each interval")
        Me.rbnInterval.UseVisualStyleBackColor = True
        '
        'rbn1Minute
        '
        Me.rbn1Minute.AutoSize = True
        Me.rbn1Minute.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbn1Minute.Location = New System.Drawing.Point(141, 43)
        Me.rbn1Minute.Name = "rbn1Minute"
        Me.rbn1Minute.Size = New System.Drawing.Size(66, 17)
        Me.rbn1Minute.TabIndex = 2
        Me.rbn1Minute.TabStop = True
        Me.rbn1Minute.Text = "1 Minute"
        Me.ToolTip1.SetToolTip(Me.rbn1Minute, "Beep once per minute")
        Me.rbn1Minute.UseVisualStyleBackColor = True
        '
        'rbn1Second
        '
        Me.rbn1Second.AutoSize = True
        Me.rbn1Second.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbn1Second.Location = New System.Drawing.Point(141, 19)
        Me.rbn1Second.Name = "rbn1Second"
        Me.rbn1Second.Size = New System.Drawing.Size(71, 17)
        Me.rbn1Second.TabIndex = 1
        Me.rbn1Second.TabStop = True
        Me.rbn1Second.Text = "1 Second"
        Me.ToolTip1.SetToolTip(Me.rbn1Second, "Beep once per second")
        Me.rbn1Second.UseVisualStyleBackColor = True
        '
        'rbnNoBeep
        '
        Me.rbnNoBeep.AutoSize = True
        Me.rbnNoBeep.Checked = True
        Me.rbnNoBeep.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbnNoBeep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbnNoBeep.Location = New System.Drawing.Point(6, 19)
        Me.rbnNoBeep.Name = "rbnNoBeep"
        Me.rbnNoBeep.Size = New System.Drawing.Size(67, 17)
        Me.rbnNoBeep.TabIndex = 0
        Me.rbnNoBeep.TabStop = True
        Me.rbnNoBeep.Text = "No Beep"
        Me.ToolTip1.SetToolTip(Me.rbnNoBeep, "No beep - silent operation")
        Me.rbnNoBeep.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDefault.Location = New System.Drawing.Point(25, 334)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 30
        Me.btnDefault.Text = "Defaults"
        Me.ToolTip1.SetToolTip(Me.btnDefault, "Restore settings to the default values")
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(182, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save these settings")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'numInterval
        '
        Me.numInterval.Location = New System.Drawing.Point(77, 170)
        Me.numInterval.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(180, 20)
        Me.numInterval.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.numInterval, "Frequency of heartbeats in minutes")
        Me.numInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(16, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Heartbeat :"
        '
        'txtHeartBeat
        '
        Me.txtHeartBeat.Location = New System.Drawing.Point(78, 196)
        Me.txtHeartBeat.Name = "txtHeartBeat"
        Me.txtHeartBeat.Size = New System.Drawing.Size(120, 20)
        Me.txtHeartBeat.TabIndex = 22
        Me.txtHeartBeat.Text = "pc"
        Me.ToolTip1.SetToolTip(Me.txtHeartBeat, "text to send as part of the heartbeat")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(15, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Interval :"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
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
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(333, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 372)
        Me.Panel2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(225, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(77, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Label11"
        '
        'PictureBox2
        '
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(18, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 89)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblActivity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblActivity.Location = New System.Drawing.Point(15, 9)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(60, 17)
        Me.lblActivity.TabIndex = 35
        Me.lblActivity.Text = "Activity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(156, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Label10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(22, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Label8"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(17, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 124)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lblRemaining
        '
        Me.lblRemaining.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRemaining.Location = New System.Drawing.Point(22, 252)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(248, 18)
        Me.lblRemaining.TabIndex = 29
        Me.lblRemaining.Text = "Stopped"
        '
        'btnStop
        '
        Me.btnStop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStop.Location = New System.Drawing.Point(198, 334)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 28
        Me.btnStop.Text = "Stop"
        Me.ToolTip1.SetToolTip(Me.btnStop, "Stop the heartbeats")
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStart.Location = New System.Drawing.Point(25, 334)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 27
        Me.btnStart.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start the heartbeat wuth the current settins")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pgbRemaining
        '
        Me.pgbRemaining.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pgbRemaining.Location = New System.Drawing.Point(18, 273)
        Me.pgbRemaining.Name = "pgbRemaining"
        Me.pgbRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pgbRemaining.Size = New System.Drawing.Size(256, 19)
        Me.pgbRemaining.Step = 1
        Me.pgbRemaining.TabIndex = 20
        '
        'heartBeatTimer
        '
        '
        'SerialPort1
        '
        Me.SerialPort1.Parity = System.IO.Ports.Parity.Mark
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Running"
        Me.NotifyIcon1.BalloonTipTitle = "Windows Heartbeat"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Heartbeat"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRestore, Me.tsmHide, Me.ToolStripSeparator1, Me.tsmStart, Me.tsmStop, Me.ToolStripSeparator2, Me.tsmExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 126)
        Me.ContextMenuStrip1.Text = "Menu"
        '
        'tsmRestore
        '
        Me.tsmRestore.Checked = True
        Me.tsmRestore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmRestore.Name = "tsmRestore"
        Me.tsmRestore.Size = New System.Drawing.Size(148, 22)
        Me.tsmRestore.Text = "Show Settings"
        '
        'tsmHide
        '
        Me.tsmHide.Name = "tsmHide"
        Me.tsmHide.Size = New System.Drawing.Size(148, 22)
        Me.tsmHide.Text = "Hide Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'tsmStart
        '
        Me.tsmStart.Name = "tsmStart"
        Me.tsmStart.Size = New System.Drawing.Size(148, 22)
        Me.tsmStart.Text = "Start"
        '
        'tsmStop
        '
        Me.tsmStop.Checked = True
        Me.tsmStop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmStop.Enabled = False
        Me.tsmStop.Name = "tsmStop"
        Me.tsmStop.Size = New System.Drawing.Size(148, 22)
        Me.tsmStop.Text = "Stop"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(148, 22)
        Me.tsmExit.Text = "Exit"
        '
        'frmHeartBeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 398)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHeartBeat"
        Me.Text = "Com Beat"
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
    Friend WithEvents Button1 As Button
End Class
