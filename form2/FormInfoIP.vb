Imports System
Imports System.Data
Imports System.Net
Imports System.Net.Sockets


Public Class FormInfoIP
    Private Sub Btn_cek_Click(sender As Object, e As EventArgs) Handles btn_cek.Click
        Dim CpIP As IPHostEntry
        Dim a As String

        CpIP = Dns.GetHostByAddress(tb_ip.Text)

        a = "IP  :" + tb_ip.Text + " Nama hostnya :" + CpIP.HostName

        ListBox1.Items.Add(a)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb_ip.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ipAddr As System.Net.IPAddress
        Dim ipEndPoint As System.Net.IPEndPoint
        Dim socketAddr As System.Net.SocketAddress


        Try
            ipAddr = IPAddress.Parse(tb_ip.Text)
            ipEndPoint = New System.Net.IPEndPoint(ipAddr, 12345)
            socketAddr = ipEndPoint.Serialize()

            ListBox1.Items.Add("===================================================")
            ListBox1.Items.Add("Untuk IP" & tb_ip.Text)
            ListBox1.Items.Add("Address Family :" & ipEndPoint.AddressFamily.ToString)
            ListBox1.Items.Add("IP:Port: " & ipEndPoint.Address.ToString & ":" & ipEndPoint.Port.ToString)
            ListBox1.Items.Add("Socket Address :" & socketAddr.ToString())
            ListBox1.Items.Add("===================================================")
        Catch ex As Exception
            ListBox1.Items.Add(ex.StackTrace.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim curAdd As IPAddress
        Dim hostname As IPHostEntry = Dns.GetHostEntry(System.Environment.MachineName)

        For Each curAdd In hostname.AddressList

            If curAdd.AddressFamily = AddressFamily.InterNetwork Then
                tb_ip.Text = curAdd.ToString()
            End If
        Next curAdd
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim curAdd As IPAddress
        Dim hostname As IPHostEntry = Dns.GetHostEntry(System.Environment.MachineName)

        For Each curAdd In hostname.AddressList

            If curAdd.AddressFamily = AddressFamily.InterNetworkV6 Then
                tb_ip.Text = curAdd.ToString()
            End If
        Next curAdd
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim hostname2 As IPHostEntry = Dns.GetHostByName(tb_ip.Text)
        Dim ip2 As IPAddress() = hostname2.AddressList
        ListBox1.Items.Add(ip2(0).ToString())
    End Sub

    Private Sub btn_self_Click(sender As Object, e As EventArgs) Handles btn_self.Click
        Dim hostname As IPHostEntry = Dns.GetHostEntry(System.Environment.MachineName)
        Dim ip As IPAddress() = hostname.AddressList
        Dim i As Integer
        i = ip.Length
        For j As Integer = 0 To i - 1
            ListBox1.Items.Add(ip(j))
        Next
    End Sub

    Private Sub btn_cekinternet_Click(sender As Object, e As EventArgs) Handles btn_cekinternet.Click
        If My.Computer.Network.IsAvailable Then
            ListBox1.Items.Add("Komp Terhubung Jaringan")
        Else
            ListBox1.Items.Add("Komp Tidak Terhubung Jaringan")
        End If
    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        Dim a As String
        Dim b As Integer
        a = My.Computer.Screen.ToString
        ListBox1.Items.Add("properti screen layar: " & a)
        a = My.Computer.Info.AvailablePhysicalMemory
        b = a / 1000000
        ListBox1.Items.Add("total Availabel Memory  " & b & " Mb")
        a = My.Computer.Info.OSFullName
        ListBox1.Items.Add(" Nama Sistem Operasi " & a)
        a = My.Computer.Info.OSPlatform
        ListBox1.Items.Add(" Os Platform " & a)
        a = My.Computer.Info.OSVersion
        ListBox1.Items.Add(" OS version " & a)
        a = My.Computer.Info.TotalPhysicalMemory
        b = a / 1000000000
        ListBox1.Items.Add("Total Fisikal Memory " & b & " Gb")
        a = My.Computer.Info.AvailableVirtualMemory
        b = a / 1000000
        ListBox1.Items.Add("Avail virtual memory" & b & " Mb")
        a = My.Computer.Info.TotalVirtualMemory
        b = a / 1000000000
        ListBox1.Items.Add("Total Virtual Memory " & b & " Gb")
        a = My.Computer.Keyboard.CapsLock
        ListBox1.Items.Add("Capslok Aktif =" & a)
        a = My.Computer.Keyboard.NumLock
        ListBox1.Items.Add("Numlock Aktif " & a)
    End Sub

    Private Sub btn_url_Click(sender As Object, e As EventArgs) Handles btn_url.Click
        Dim a, b As String

        b = "http://" & tb_ip.Text
        Dim aUri As New Uri(b)
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Absolute Url : " +
aUri.AbsoluteUri)
        ListBox1.Items.Add("Host : " + aUri.Host)
        ListBox1.Items.Add("Scheme : " + aUri.Scheme)
        ListBox1.Items.Add("Port : " + aUri.Port.ToString)
        ListBox1.Items.Add("Absolute Path : " +
aUri.AbsolutePath)
        ListBox1.Items.Add("Query : " + aUri.Query)
        ListBox1.Items.Add("User Infor : " + aUri.UserInfo)

        a = b
        Select Case aUri.CheckHostName(a)
            Case UriHostNameType.Basic
                ListBox1.Items.Add("Hostname: Basic")
            Case UriHostNameType.Dns
                ListBox1.Items.Add("Hostname: Dns")
            Case UriHostNameType.IPv4
                ListBox1.Items.Add("Hostname : IPv4")
            Case UriHostNameType.IPv6
                ListBox1.Items.Add("Hostname : IPv6")
            Case UriHostNameType.Unknown
                ListBox1.Items.Add("Hostname : Unknown")
        End Select
    End Sub
End Class