Imports System.IO.Ports
Imports System.Configuration 'Need to add project reference as well




Public Class frmHeartBeat
    Private mySerialPort As New SerialPort
    Private registryObj = New G4HDURegistry
    Private trayIcons As Icon()
    Private comPort As String = "None"
    Private portSpeed As String = "9600"
    Private portParity As String = "None"
    Private portBits As String = "8"
    Private portStopBits As String = "One"
    Private heartBeat As String
    Private beepOp As Integer = 1
    Private heartInterval As Integer = 1
    Private start_time As DateTime = Now
    Private noOfSeconds As Integer
    Private selfDebug As Boolean = False
    Enum buttonAction
        setStart
        setStop
        setDefault
        setSave
        setBegin
        setChange
    End Enum
    '********************************************************************************************
    '*
    '*  When form is shown 
    '*      open registry
    '*      populate the combo boxes then
    '*      read in the settings - if no settings set the default settings
    '*      set up all the settings fields
    '*
    '********************************************************************************************
    Private Sub frmHeartBeat_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        registryObj.openRegistryKey("HeartBeat", "1.0")
        setComboBoxes()
        loadSettings() ' read from registry and set current values into fields
        setButtons(buttonAction.setBegin)
    End Sub
    '********************************************************************************************
    '*
    '*  setButtons 
    '*
    '********************************************************************************************
    Private Sub setButtons(ByVal buttonAction As buttonAction)
        Select Case buttonAction
            Case buttonAction.setBegin 'begin 
                btnStop.Enabled = False
                btnStart.Enabled = True

                tsmStop.Enabled = False
                tsmStop.Checked = True

                tsmStart.Enabled = True
                tsmStart.Checked = False

                pnlSettings.Enabled = True

                btnDefault.Enabled = True
                btnSave.Enabled = False
            Case buttonAction.setStart 'start 
                btnStop.Enabled = True
                btnStart.Enabled = False

                tsmStop.Enabled = True
                tsmStop.Checked = False

                tsmStart.Enabled = False
                tsmStart.Checked = True

                pnlSettings.Enabled = False

                btnDefault.Enabled = False
                btnSave.Enabled = False

            Case buttonAction.setStop ' stop
                btnStop.Enabled = False
                btnStart.Enabled = True

                tsmStop.Enabled = False
                tsmStop.Checked = True

                tsmStart.Enabled = True
                tsmStart.Checked = False

                pnlSettings.Enabled = True

                btnDefault.Enabled = True
                btnSave.Enabled = False
            Case buttonAction.setDefault ' default
                btnStop.Enabled = False
                btnStart.Enabled = False

                tsmStop.Enabled = False
                tsmStop.Checked = True

                tsmStart.Enabled = False
                tsmStart.Checked = False

                pnlSettings.Enabled = True

                btnDefault.Enabled = True
                btnSave.Enabled = True
            Case buttonAction.setSave ' save
                btnStop.Enabled = False
                btnStart.Enabled = True

                tsmStop.Enabled = False
                tsmStop.Checked = True

                tsmStart.Enabled = True
                tsmStart.Checked = False

                pnlSettings.Enabled = True

                btnDefault.Enabled = True
                btnSave.Enabled = False
            Case buttonAction.setChange ' change
                btnStop.Enabled = False
                btnStart.Enabled = False

                tsmStop.Enabled = False
                tsmStop.Checked = True

                tsmStart.Enabled = False
                tsmStart.Checked = False

                btnDefault.Enabled = True
                btnSave.Enabled = True
            Case Else
        End Select

    End Sub
    '********************************************************************************************
    '*
    '*  When save button is clicked save settings 
    '*
    '********************************************************************************************
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveSettings()
    End Sub
    '********************************************************************************************
    '*
    '*  When start button clicked start the timer 
    '*
    '********************************************************************************************
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        loadSettings() ' make sure using latest settings
        startTimer()
    End Sub
    '********************************************************************************************
    '*
    '*  startTimer 
    '*     Enable / disable buttons and tray menu items
    '*     Enable the timer
    '*     Display animated heartbeat
    '*     set the progress bar initial values
    '*     change the systray icon
    '*
    '********************************************************************************************
    Private Function startTimer() As Boolean
        If selfDebug Then
            Console.WriteLine("starting")
        End If

        setButtons(buttonAction.setStart)

        startTimer = True
        heartBeatTimer.Interval = 1000
        heartBeatTimer.Enabled = True

        PictureBox1.Image = WindowsHeartbeat.My.Resources.Resources.HeartBeat
        PictureBox1.Refresh()
        If selfDebug Then
            Console.WriteLine("started")
        End If
        start_time = Now
        pgbRemaining.Value = 0
        pgbRemaining.Maximum = heartInterval * 60
        NotifyIcon1.Icon = My.Resources.Resources.trayHeartRed
        serialInit()
    End Function
    '********************************************************************************************
    '*
    '*  setDefaults 
    '*     set default values for all setting
    '*
    '********************************************************************************************
    Private Sub setDefaults()
        If selfDebug Then
            Console.WriteLine("Setting defaults")
        End If
        comPort = "None"
        portSpeed = "9600"
        portParity = "None"
        portBits = "8"
        portStopBits = "One"
        heartBeat = "pc"
        beepOp = 1
        heartInterval = 1
        cboComPort.SelectedItem = comPort
        cbPortSpeed.SelectedItem = portSpeed
        cbParity.SelectedItem = portParity
        cbBits.SelectedItem = portBits
        cbStopBits.SelectedItem = portStopBits
        numInterval.Value = heartInterval
        txtHeartBeat.Text = heartBeat
        setButtons(buttonAction.setDefault)
    End Sub
    '********************************************************************************************
    '*
    '*  saveSettings
    '*      save all field values in registry
    '*
    '********************************************************************************************
    Private Sub saveSettings()
        If selfDebug Then
            Console.WriteLine("Saving Settings")
        End If
        setButtons(buttonAction.setSave)
        registryObj.setKeyValue("comPort", cboComPort.SelectedItem)
        registryObj.setKeyValue("portSpeed", cbPortSpeed.SelectedItem)
        registryObj.setKeyValue("portParity", cbParity.SelectedItem)
        registryObj.setKeyValue("portBits", cbBits.SelectedItem)
        registryObj.setKeyValue("portStopBits", cbStopBits.SelectedItem)
        registryObj.setKeyValue("comPort", cboComPort.SelectedItem)

        registryObj.setKeyValue("heartInterval", numInterval.Value)
        beepOp = 1
        If rbn1Minute.Checked Then
            beepOp = 4
        ElseIf rbn1Second.Checked Then
            beepOp = 3
        ElseIf rbnInterval.Checked Then
            beepOp = 2
        Else
            beepOp = 1
        End If
        registryObj.setKeyValue("beepOp", beepOp)
        registryObj.setKeyValue("heartBeat", txtHeartBeat.Text)
    End Sub
    '********************************************************************************************
    '*
    '*  setComboBoxes
    '*      populate all the comboboxes
    '*
    '********************************************************************************************
    Private Sub setComboBoxes()
        Dim myPortNames() As String
        myPortNames = SerialPort.GetPortNames
        cboComPort.Items.Add("None")
        For Each column As String In myPortNames
            cboComPort.Items.Add(column)
        Next

        Dim myPortSpeeds = {"300", "600", "1200", "2400", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"}
        For Each column As String In myPortSpeeds
            cbPortSpeed.Items.Add(column)
        Next

        Dim myPortParities = {"None", "Odd", "Even", "Mark", "Space"}
        For Each column As String In myPortParities
            cbParity.Items.Add(column)
        Next

        Dim myPortBits = {"7", "8"}
        For Each column As String In myPortBits
            cbBits.Items.Add(column)
        Next

        Dim myPortStopBits = {"One", "Two", "OnePointFive"}
        For Each column As String In myPortStopBits
            cbStopBits.Items.Add(column)
        Next

    End Sub
    '********************************************************************************************
    '*
    '*  loadSettings 
    '*      open registry
    '*      get all settings
    '*      set values into the fields
    '*
    '********************************************************************************************
    Private Sub loadSettings()

        comPort = registryObj.getKeyValue("comPort")

        If IsNothing(comPort) Then
            comPort = "None"
        End If
        cboComPort.SelectedItem = comPort


        portSpeed = registryObj.getKeyValue("portSpeed")
        cbPortSpeed.SelectedItem = portSpeed


        portParity = registryObj.getKeyValue("portParity")
        cbParity.SelectedItem = portParity

        portBits = registryObj.getKeyValue("portBits")
        cbBits.SelectedItem = portBits

        portStopBits = registryObj.getKeyValue("portStopBits")
        cbStopBits.SelectedItem = portStopBits

        heartInterval = Int(registryObj.getKeyValue("heartInterval"))
        numInterval.Value = heartInterval
        rbnNoBeep.Checked = False ' ensure all radio buttons disabled
        rbnInterval.Checked = False
        rbn1Second.Checked = False
        rbn1Minute.Checked = False
        Select Case Int(registryObj.getKeyValue("beepOp"))
            Case 2
                rbnInterval.Checked = True
            Case 3
                rbn1Second.Checked = True
            Case 4
                rbn1Minute.Checked = True
            Case Else
                rbnNoBeep.Checked = True
        End Select
        txtHeartBeat.Text = registryObj.getKeyValue("heartBeat")
    End Sub
    '********************************************************************************************
    '*
    '*  When default button clicked 
    '*      set defaults
    '*
    '********************************************************************************************
    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        setDefaults()
    End Sub
    '********************************************************************************************
    '*
    '*  heartbeatTimer Tick 
    '*      tick activities done once per second
    '*
    '********************************************************************************************
    Private Sub heartBeatTimer_Tick(sender As Object, e As EventArgs) Handles heartBeatTimer.Tick
        timeElapse()
    End Sub
    '********************************************************************************************
    '*
    '*  doBeep 
    '*      play heartbeat if enabled and due
    '*
    '********************************************************************************************
    Private Sub doBeep(ByVal shortBeep As Boolean, ByVal elapsedTime As Integer)
        If Not shortBeep And beepOp <> 1 Then ' if we are doing beeps and it is the long beep
            My.Computer.Audio.Play(My.Resources.flatline, AudioPlayMode.Background)
            Return
        End If
        If shortBeep And beepOp = 3 Then ' seconds
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If
        If shortBeep And beepOp = 2 And elapsedTime <= 0 Then ' interval
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If
        If shortBeep And beepOp = 4 And elapsedTime Mod 60 = 0 Then ' 1 minute
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
        End If
        If selfDebug Then
            Console.WriteLine("Time" & elapsedTime)
        End If
    End Sub
    '********************************************************************************************
    '*
    '*  stopTimer
    '*      play flatline if beep enabledy
    '*      set buttons and menu option
    '*      change gif to flatline jpg
    '*      set icon to stopped - green
    '*
    '********************************************************************************************
    Private Function stopTimer() As Boolean
        stopTimer = True
        doBeep(False, 0)
        setButtons(buttonAction.setStop)

        heartBeatTimer.Enabled = False
        PictureBox1.Image = WindowsHeartbeat.My.Resources.Resources.HeartBeatflat
        PictureBox1.Refresh()
        pnlSettings.Enabled = True
        lblRemaining.Text = "Stopped"
        pgbRemaining.Value = 0
        NotifyIcon1.Icon = My.Resources.Resources.trayHeartGreen

    End Function
    '********************************************************************************************
    '*
    '*  stop button clicked 
    '*      stop the timer
    '*
    '********************************************************************************************
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopTimer()
    End Sub
    '********************************************************************************************
    '*
    '*  timeElapse 
    '*      
    '*      
    '*      
    '*      
    '*
    '********************************************************************************************
    Private Function timeElapse() As String
        Dim heartIntervalSeconds As Integer = (heartInterval * 60)

        Static stop_time As DateTime
        Dim elapsed_time As TimeSpan
        Dim timeRemaining As Integer
        timeElapse = False ' function return
        If selfDebug Then
            Console.WriteLine("Tock")
        End If
        stop_time = Now
        elapsed_time = stop_time.Subtract(start_time)
        timeRemaining = elapsed_time.TotalSeconds
        If selfDebug Then
            Console.Write(timeRemaining)
            Console.WriteLine(My.Computer.Audio.ToString())
            Console.WriteLine(timeRemaining)
        End If
        pgbRemaining.Value = timeRemaining
        timeElapse = (heartIntervalSeconds - elapsed_time.TotalSeconds).ToString("0")
        lblRemaining.Text = "Time to next heartbeat : " & timeElapse & " seconds"
        If timeElapse <= 0 Then
            start_time = Now ' restart countdown
        End If
        doBeep(True, timeElapse)
    End Function
    '********************************************************************************************
    '*
    '*  When fields change 
    '*      enable the save button
    '*      disable defaults and start buttons
    '*
    '********************************************************************************************
    Private Sub cboComPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComPort.SelectedIndexChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub cbBits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBits.SelectedIndexChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub cbParity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbParity.SelectedIndexChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub cbPortSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPortSpeed.SelectedIndexChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub cbStopBits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStopBits.SelectedIndexChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub cbxSound_CheckStateChanged(sender As Object, e As EventArgs)
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub rbnNoBeep_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNoBeep.CheckedChanged
        beepOp = 1
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub rbnInterval_CheckedChanged(sender As Object, e As EventArgs) Handles rbnInterval.CheckedChanged
        beepOp = 2
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub rbn1Second_CheckedChanged(sender As Object, e As EventArgs) Handles rbn1Second.CheckedChanged
        beepOp = 3
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub rbn1Minute_CheckedChanged(sender As Object, e As EventArgs) Handles rbn1Minute.CheckedChanged
        beepOp = 4
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub txtHeartBeat_TextChanged(sender As Object, e As EventArgs) Handles txtHeartBeat.TextChanged
        setButtons(buttonAction.setChange)
    End Sub

    Private Sub numInterval_ValueChanged(sender As Object, e As EventArgs) Handles numInterval.ValueChanged
        setButtons(buttonAction.setChange)
    End Sub
    Private Sub serialInit()
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If
        SerialPort1.PortName = comPort
        SerialPort1.DataBits = Int(portBits)
        Select Case portParity  ' portParity 0=NONE 1=ODD 2=EVEN 3=mark 4=space
            Case "None"
                SerialPort1.Parity = 0
            Case "Odd"
                SerialPort1.Parity = 1
            Case "Even"
                SerialPort1.Parity = 2
            Case "Mark"
                SerialPort1.Parity = 3
            Case "Space"
                SerialPort1.Parity = 4
        End Select
        Select Case portStopBits  ' portStopBits 1=one 2=two 3=onePointFive there is no none
            Case "One"
                SerialPort1.Parity = 1
            Case "Two"
                SerialPort1.Parity = 2
            Case "OnePointFive"
                SerialPort1.Parity = 3
        End Select
        SerialPort1.BaudRate = Int(portSpeed)
        Console.WriteLine(portStopBits & "stop " & SerialPort1.StopBits.ToString)


        Try
            SerialPort1.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '********************************************************************************************
    '*
    '*  notifyicon restore option clicked 
    '*      show form
    '*      set enable / disable menu
    '*
    '********************************************************************************************
    Private Sub tsmRestore_Click(sender As Object, e As EventArgs) Handles tsmRestore.Click
        Me.Visible = True
        tsmRestore.Enabled = False
        tsmHide.Enabled = True
        tsmRestore.Checked = True
        tsmHide.Checked = False
    End Sub
    '********************************************************************************************
    '*
    '*  notifyicon hide 
    '*      hide form
    '*      set enable / disable menu settings
    '*
    '********************************************************************************************
    Private Sub tsmHide_Click(sender As Object, e As EventArgs) Handles tsmHide.Click
        Me.Visible = False
        tsmRestore.Enabled = True
        tsmHide.Enabled = False
        tsmRestore.Checked = False
        tsmHide.Checked = True
    End Sub
    '********************************************************************************************
    '*
    '*  notifyicon exit 
    '*     close the form
    '*
    '********************************************************************************************
    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub
    '********************************************************************************************
    '*
    '*  notifyicon stop
    '*      stop the timer
    '*
    '********************************************************************************************
    Private Sub tsmStop_Click(sender As Object, e As EventArgs) Handles tsmStop.Click
        stopTimer()
    End Sub
    '********************************************************************************************
    '*
    '*  notifyicon start
    '*      start the timer
    '*
    '********************************************************************************************
    Private Sub tsmStart_Click(sender As Object, e As EventArgs) Handles tsmStart.Click
        startTimer()
    End Sub

    Private Sub frmHeartBeat_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


End Class

