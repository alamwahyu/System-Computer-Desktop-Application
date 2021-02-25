Imports System
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net
Imports System.IO
Imports System.Threading

Public Class FormInfoSistem


    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000
    Const SND_ALIAS As Integer = &H10000
    Const SND_SYNC As Integer = &H0
    Declare Auto Function waveOutGetNumDevs Lib "winmm.dll" Alias "waveOutGetNumDevs" () As Int32
    Declare Auto Function sndPlaySound Lib "WINMM.DLL" (ByVal FileName As String,
ByVal Options As Int32) As Int32
    Private Const SND_MEMORY As Integer = &H4
    Private Const SND_ASYNC As Integer = &H1
    Private Const PROCESS_DOMAIN As String = ""
    Const SND_SYNC1 = &H0
    Const SND_ASYNC1 = &H1
    Const SND_NODEFAULT = &H2
    Const SND_LOOP = &H8
    Const SND_NOSTOP = &H10



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "PROCESSOR" Then
            Dim m_LM As RegistryKey
            Dim m_HW As RegistryKey
            Dim m_Des As RegistryKey
            Dim m_System As RegistryKey
            Dim m_CPU As RegistryKey
            Dim m_Info As RegistryKey
            m_LM = Registry.LocalMachine
            m_HW = m_LM.OpenSubKey("HARDWARE")
            m_Des = m_HW.OpenSubKey("DESCRIPTION")
            m_System = m_Des.OpenSubKey("SYSTEM")
            m_CPU = m_System.OpenSubKey("CentralProcessor")
            m_Info = m_CPU.OpenSubKey("0")

            ListBox1.Items.Add("Prosesor =" + m_Info.GetValue("VendorIdentifier"))
            ListBox1.Items.Add("Prosesor Name =" + m_Info.GetValue("ProcessorNameString"))
            ListBox1.Items.Add("Identifier    = " + m_Info.GetValue("Identifier"))
            ListBox1.Items.Add(m_Info.GetValue("~Mhz") & "MHz")

        ElseIf ComboBox1.SelectedItem = "BIOS" Then
            Dim m_LM As RegistryKey
            Dim m_HW As RegistryKey
            Dim m_Des As RegistryKey
            Dim m_System As RegistryKey
            Dim m_CPU As RegistryKey

            m_LM = Registry.LocalMachine
            m_HW = m_LM.OpenSubKey("HARDWARE")
            m_Des = m_HW.OpenSubKey("DESCRIPTION")
            m_System = m_Des.OpenSubKey("SYSTEM")
            m_CPU = m_System.OpenSubKey("BIOS")
            '  m_Info = m_CPU.OpenSubKey("0") 

            ListBox1.Items.Add("Manufaktur  =" + m_CPU.GetValue("BaseBoardManufacturer"))
            ListBox1.Items.Add("Product  =" + m_CPU.GetValue("BaseBoardProduct"))
            ListBox1.Items.Add("Vendor    = " + m_CPU.GetValue("BIOSVendor"))

        ElseIf ComboBox1.SelectedItem = "RESOLUSI LAYAR" Then
            Dim bnds As Rectangle = My.Computer.Screen.Bounds
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Resolusi Layar: " & bnds.Width & " by " & bnds.Height)

        ElseIf ComboBox1.SelectedItem = "SOUND" Then
            Dim i As Integer
            i = waveOutGetNumDevs()
            ListBox1.Items.Clear()
            If i > 0 Then
                ListBox1.Items.Add("Can play wav file")
            Else
                ListBox1.Items.Add("cannot play wav file")
            End If

        ElseIf ComboBox1.SelectedItem = "CEK ALOKASI MEMORY" Then
            Dim i As Integer
            i = waveOutGetNumDevs()
            ListBox1.Items.Clear()
            ListBox1.Items.Add("baru : alokasi memory " & GC.GetTotalMemory(i))

        ElseIf ComboBox1.SelectedItem = "CEK USERNAME DAN LAIN-LAIN" Then
            Dim i As Integer
            i = waveOutGetNumDevs()
            ListBox1.Items.Clear()
            ListBox1.Items.Add("baru :UserName:           " & System.Environment.UserName)
            ListBox1.Items.Add("baru :nama domain          " &
    System.Environment.UserDomainName)
            ListBox1.Items.Add("baru :Current Directory         " &
    System.Environment.CurrentDirectory)
            ListBox1.Items.Add("baru :OS 64 bit?           " &
    System.Environment.Is64BitOperatingSystem)
            ListBox1.Items.Add("baru :Prosesor 64 bit?           " &
    System.Environment.Is64BitProcess)
            ListBox1.Items.Add("baru :nama mesin   " & System.Environment.MachineName)
            ListBox1.Items.Add("baru :tamggal sekarang          " & System.DateTime.Now)
            ListBox1.Items.Add("baru :system direktori           " &
    System.Environment.SystemDirectory)

        ElseIf ComboBox1.SelectedItem = "PROSES YANG BERJALAN" Then

            Dim ProcessList As System.Diagnostics.Process()
            ProcessList = System.Diagnostics.Process.GetProcesses()
            Dim Proc As System.Diagnostics.Process
            ListBox1.Items.Clear()
            ListBox1.Items.Add("PROSES YANG BERJALAN")
            For Each Proc In ProcessList
                ListBox1.Items.Add(Proc.ProcessName)
            Next

        ElseIf ComboBox1.SelectedItem = "WAKTU" Then
            Dim localZone As TimeZoneInfo = TimeZoneInfo.Local
            Dim a As String
            a = "Local Time Zone ID: " + localZone.Id
            ListBox1.Items.Add(a)
            a = "Display Name is: ." + localZone.DisplayName
            ListBox1.Items.Add(a)
            a = "Standard name is: {0}." + localZone.StandardName
            ListBox1.Items.Add(a)
            a = "Daylight saving name is: {0}." + localZone.DaylightName
            ListBox1.Items.Add(a)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class