
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Media
Imports System.Text.Encoding
Imports System.Net.Sockets
Imports System.Security.Cryptography

Public Class GHOSTLAUNCHER1
    Dim X, Y As Integer
    Dim refresher As Integer = 0
    Dim newpoint As New System.Drawing.Point
    Dim publisher As New Sockets.UdpClient(7856)
    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Opacity += 0.03
        If Opacity = 100 Then
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Opacity -= 0.03
        If Opacity = 0 Then
            Me.Close()
        End If
    End Sub


    Private Sub Savefromresource(ByVal filepath As String, ByVal file As Object)
        Dim fbyte() As Byte = file
        My.Computer.FileSystem.WriteAllBytes(filepath, fbyte, True)
    End Sub
    Private Sub GHOSTLAUNCHER1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        publisher.Client.ReceiveTimeout = 100
        publisher.Client.Blocking = False
        refresher = 7856
        Try
            Dim fileReader221 As String
            fileReader221 = My.Computer.FileSystem.ReadAllText("theme.dat", System.Text.Encoding.UTF8)
            Dim cipherTex As String = fileReader221
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "dcona"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim wah As String = wrapper.DecryptData(cipherTex)
            If wah = My.Settings.Playername Then
            Else
                My.Settings.Playername = wah
            End If
            Dim fileReader2221 As String
            fileReader2221 = My.Computer.FileSystem.ReadAllText("image.dat", System.Text.Encoding.UTF8)
            Dim cipherTex2 As String = fileReader2221
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ticona2"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim wah2 As String = wrapper2.DecryptData(cipherTex2)
            If wah2 = My.Settings.Username Then
            Else
                My.Settings.Username = wah2
            End If

            Dim fileReader22221 As String
            fileReader22221 = My.Computer.FileSystem.ReadAllText("music.dat", System.Text.Encoding.UTF8)
            Dim cipherTex22 As String = fileReader22221
            'Dim password As String = InputBox("Enter the password:")
            Dim password22 As String
            password22 = "djsjaksx"
            Dim wrapper22 As New Simple3Des(password22)

            ' DecryptData throws if the wrong password is used.

            Dim wah22 As String = wrapper22.DecryptData(cipherTex22)
            If wah22 = My.Settings.Password Then
            Else
                My.Settings.Password = wah22
            End If
        Catch gfgfgf As Exception
            MessageBox.Show("You are just a little noob :)")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
        Try
            Dim fileReader22 As String
            fileReader22 = My.Computer.FileSystem.ReadAllText("themes.cfg", System.Text.Encoding.UTF8)
            If fileReader22 = "ola1" Then
                BackgroundImage = My.Resources.ola1
                ' My.Computer.Audio.Play(My.Resources.baba, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola2" Then

                BackgroundImage = My.Resources.ola2
            ElseIf fileReader22 = "ola3" Then
                BackgroundImage = My.Resources.ola3
                '   My.Computer.Audio.Play(My.Resources.ola22, AudioPlayMode.BackgroundLoop)

            ElseIf fileReader22 = "ola5" Then
                BackgroundImage = My.Resources.ola5
                '   My.Computer.Audio.Play(My.Resources.ola, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola7" Then
                BackgroundImage = My.Resources.ola7
                '  My.Computer.Audio.Play(My.Resources._23, AudioPlayMode.BackgroundLoop)
            End If
        Catch fff As Exception
            '    My.Computer.Audio.Play(My.Resources._23, AudioPlayMode.BackgroundLoop)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myprocess() As Process = System.Diagnostics.Process.GetProcessesByName("igi2")
        For Each mykill As Process In myprocess
            mykill.Kill()
        Next
        Form2.Close()
        Form3.Close()
        Me.Close()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim URL As String = "http://igi2.pro/message1.txt"

        Dim xwr As WebRequest = HttpWebRequest.Create(URL)
        Dim ywr As WebResponse
        Dim serv As String
        ywr = xwr.GetResponse()
        Using kr As New StreamReader(ywr.GetResponseStream())
            serv = kr.ReadToEnd()
            ' Close and clean up the StreamReader
            kr.Close()
        End Using

        MessageBox.Show(serv)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        Dim myprocess() As Process = System.Diagnostics.Process.GetProcessesByName("Wireshark")
        For Each mykill As Process In myprocess
            mykill.Kill()
        Next
    End Sub
    Private Sub Timer9_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer9.Tick
        If refresher = 7856 Then
            Try
                Dim URL4 As String = "http://igi2.pro/ipa.txt"

                Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
                Dim ywr4 As WebResponse
                Dim gg As String
                ywr4 = xwr4.GetResponse()
                Using kr4 As New StreamReader(ywr4.GetResponseStream())
                    gg = kr4.ReadToEnd()
                    kr4.Close()
                End Using
                Dim cipherText3 As String = gg
                'Dim password As String = InputBox("Enter the password:")
                Dim password3 As String
                password3 = "ghostxaxa"
                Dim wrapper3 As New Simple3Des(password3)

                ' DecryptData throws if the wrong password is used.

                Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
                Dim ggggg As String
                ggggg = plainText3
                Dim URL5 As String = "http://igi2.pro/porta.txt"

                Dim xwr5 As WebRequest = HttpWebRequest.Create(URL5)
                Dim ywr5 As WebResponse
                Dim p5 As String
                ywr5 = xwr5.GetResponse()
                Using kr5 As New StreamReader(ywr5.GetResponseStream())
                    p5 = kr5.ReadToEnd()
                    kr5.Close()
                End Using
                Dim cipherText1 As String = p5
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText55 As String = wrapper.DecryptData(cipherText1)
                Dim s22 As String
                s22 = plainText55

                publisher.Connect(ggggg, s22)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a As String = ASCII.GetString(rcvbytes)
                Dim bas As String = a
                Dim cas As String = a
                Dim das As String = a
                Dim eas As String = a
                Dim ss As Integer = a.IndexOf("numplayers") + 11
                Dim ch As Char = a(ss)
                Dim chss As Char = a(ss + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If chss = "\" Then
                    ' MessageBox.Show(ch)
                    TextBox12.Text = ch
                Else
                    TextBox12.Text = ch + chss
                End If
                Dim bob As Integer = eas.IndexOf("hostname") + 9
                Dim cha1 As Char = eas(bob)
                Dim chb1 As Char = eas(bob + 1)
                Dim chc1 As Char = eas(bob + 2)
                Dim chd1 As Char = eas(bob + 3)
                Dim che1 As Char = eas(bob + 4)
                Dim chf1 As Char = eas(bob + 5)
                Dim chg1 As Char = eas(bob + 6)
                Dim chh1 As Char = eas(bob + 7)
                Dim chi1 As Char = eas(bob + 8)
                If chi1 = "\" Then
                    chi1 = ""
                    GoTo Good2
                End If
                Dim chj1 As Char = eas(bob + 9)
                If chj1 = "\" Then
                    chj1 = ""
                    GoTo good2
                End If
                Dim chk1 As Char = eas(bob + 10)
                If chk1 = "\" Then
                    chk1 = ""
                    GoTo good2
                End If
                Dim chl1 As Char = eas(bob + 11)
                If chl1 = "\" Then
                    chl1 = ""
                    GoTo good2
                End If
                Dim chm1 As Char = eas(bob + 12)
                If chm1 = "\" Then
                    chm1 = ""
                    GoTo good2
                End If
                Dim chn1 As Char = eas(bob + 12)
                If chn1 = "\" Then
                    chn1 = ""
                    GoTo good2
                End If
                Dim cho1 As Char = eas(bob + 13)
                If cho1 = "\" Then
                    cho1 = ""
                    GoTo good2
                End If
                Dim chp1 As Char = eas(bob + 14)
                If chp1 = "\" Then
                    chp1 = ""
                    GoTo good2
                End If
                Dim chq1 As Char = eas(bob + 15)
                If chq1 = "\" Then
                    chq1 = ""
                    GoTo good2
                End If
                Dim chr1 As Char = eas(bob + 16)
                If chr1 = "\" Then
                    chr1 = ""
                    GoTo good2
                End If
                Dim chs1 As Char = eas(bob + 17)
                If chs1 = "\" Then
                    chs1 = ""
                    GoTo good2
                End If
                Dim cht1 As Char = eas(bob + 18)
                If cht1 = "\" Then
                    cht1 = ""
                    GoTo good2
                End If
                Dim chu1 As Char = eas(bob + 19)
                If chu1 = "\" Then
                    chu1 = ""
                    GoTo good2
                End If
                Dim chv1 As Char = eas(bob + 20)
                If chv1 = "\" Then
                    chv1 = ""
                End If
Good2:
                Dim bla1 As String = cha1 + chb1 + chc1 + chd1 + che1 + chf1 + chg1 + chh1 + chi1 + chj1 + chk1 + chl1 + chm1 + chn1 + cho1 + chp1 + chq1 + chr1 + chs1 + cht1 + chu1 + chv1
                Button8.Text = bla1















                Dim as5 As Integer = bas.IndexOf("mapname") + 8
                Dim cha As Char = bas(as5)
                Dim chb As Char = bas(as5 + 1)
                Dim chc As Char = bas(as5 + 2)
                Dim chd As Char = bas(as5 + 3)
                Dim che As Char = bas(as5 + 4)
                Dim chf As Char = bas(as5 + 5)
                Dim chg As Char = bas(as5 + 6)
                Dim chh As Char = bas(as5 + 7)
                If chh = "\" Then
                    chh = ""
                End If
                Dim chi As Char = bas(as5 + 8)
                If chi = "\" Then
                    chi = ""
                End If
                Dim chj As Char = bas(as5 + 9)
                If chj = "\" Then
                    chj = ""
                End If
                Dim chk As Char = bas(as5 + 10)
                If chk = "\" Then
                    chk = ""
                End If
                Dim chl As Char = bas(as5 + 11)
                If chl = "\" Then
                    chl = ""
                End If
                Dim chm As Char = bas(as5 + 12)
                If chm = "\" Then
                    chm = ""
                End If
                Dim chn As Char = bas(as5 + 13)
                If chn = "\" Then
                    chn = ""
                End If
                Dim cho As Char = bas(as5 + 14)
                If cho = "\" Then
                    cho = ""
                End If
                Dim chp As Char = bas(as5 + 15)
                If chp = "\" Then
                    chp = ""
                End If
                Dim chq As Char = bas(as5 + 16)
                If chq = "\" Then
                    chq = ""
                End If
                Dim chr As Char = bas(as5 + 17)
                If chr = "\" Then
                    chr = ""
                End If
                Dim chs As Char = bas(as5 + 18)
                If chs = "\" Then
                    chs = ""
                End If
                Dim cht As Char = bas(as5 + 19)
                If cht = "\" Then
                    cht = ""
                End If
                Dim chu As Char = bas(as5 + 20)
                If chu = "\" Then
                    chu = ""
                End If
                Dim chv As Char = bas(as5 + 21)
                If chv = "\" Then
                    chv = ""
                End If
                Dim chw As Char = bas(as5 + 22)
                If chw = "\" Then
                    chw = ""
                End If
                Dim chx As Char = bas(as5 + 23)
                If chx = "\" Then
                    chx = ""
                End If
                Dim chy As Char = bas(as5 + 24)
                If chy = "\" Then
                    chy = ""
                End If
                Dim chz As Char = bas(as5 + 25)
                If chz = "\" Then
                    chz = ""
                End If
                Dim mapa As String
                mapa = cha + chb + chc + chd + che + chf + chg + chh + chi + chj + chk + chl + chm + chn + cho + chp + chq + chr + chs + cht + chu + chv + chw + chx + chy + chz
                TextBox11.Text = mapa
            Catch ex3 As Exception

            End Try
            ProgressBar1.PerformStep()
            Try
                Dim URL9 As String = "http://igi2.pro/ipb.txt"

                Dim xwr9 As WebRequest = HttpWebRequest.Create(URL9)
                Dim ywr9 As WebResponse
                Dim gg9 As String
                ywr9 = xwr9.GetResponse()
                Using kr9 As New StreamReader(ywr9.GetResponseStream())
                    gg9 = kr9.ReadToEnd()
                    kr9.Close()
                End Using
                Dim cipherText7 As String = gg9
                'Dim password As String = InputBox("Enter the password:")
                Dim password3 As String
                password3 = "ghostxaxa"
                Dim wrapper7 As New Simple3Des(password3)

                ' DecryptData throws if the wrong password is used.

                Dim plainText33 As String = wrapper7.DecryptData(cipherText7)
                Dim ggggg9 As String
                ggggg9 = plainText33
                Dim URL45 As String = "http://igi2.pro/portb.txt"

                Dim xwr45 As WebRequest = HttpWebRequest.Create(URL45)
                Dim ywr45 As WebResponse
                Dim p45 As String
                ywr45 = xwr45.GetResponse()
                Using kr45 As New StreamReader(ywr45.GetResponseStream())
                    p45 = kr45.ReadToEnd()
                    kr45.Close()
                End Using
                Dim cipherText45 As String = p45
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper88 As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText12 As String = wrapper88.DecryptData(cipherText45)
                Dim s4 As String
                s4 = plainText12

                publisher.Connect(ggggg9, s4)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a1 As String = ASCII.GetString(rcvbytes)
                Dim bbas As String = a1
                Dim s1s As Integer = a1.IndexOf("numplayers") + 11
                Dim ch1 As Char = a1(s1s)
                Dim chss1 As Char = a1(s1s + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If chss1 = "\" Then
                    ' MessageBox.Show(ch)
                    TextBox1.Text = ch1
                Else
                    TextBox1.Text = ch1 + chss1
                End If
                Dim ddas As String = a1
                Dim bob1 As Integer = ddas.IndexOf("hostname") + 9

                Dim cha2 As Char = ddas(bob1)
                Dim chb2 As Char = ddas(bob1 + 1)
                Dim chc2 As Char = ddas(bob1 + 2)
                Dim chd2 As Char = ddas(bob1 + 3)
                Dim che2 As Char = ddas(bob1 + 4)
                Dim chf2 As Char = ddas(bob1 + 5)
                Dim chg2 As Char = ddas(bob1 + 6)
                Dim chh2 As Char = ddas(bob1 + 7)
                Dim chi2 As Char = ddas(bob1 + 8)
                If chi2 = "\" Then
                    chi2 = ""
                    GoTo Good
                End If
                Dim chj2 As Char = ddas(bob1 + 9)
                If chj2 = "\" Then
                    chj2 = ""
                    GoTo Good
                End If
                Dim chk2 As Char = ddas(bob1 + 10)
                If chk2 = "\" Then
                    chk2 = ""
                    GoTo Good

                End If
                Dim chl2 As Char = ddas(bob1 + 11)
                If chl2 = "\" Then
                    chl2 = ""
                    GoTo Good
                End If
                Dim chm2 As Char = ddas(bob1 + 12)
                If chm2 = "\" Then
                    chm2 = ""
                    GoTo Good
                End If
                Dim chn2 As Char = ddas(bob1 + 12)
                If chn2 = "\" Then
                    chn2 = ""
                    GoTo Good
                End If
                Dim cho2 As Char = ddas(bob1 + 13)
                If cho2 = "\" Then
                    cho2 = ""
                    GoTo Good
                End If
                Dim chp2 As Char = ddas(bob1 + 14)
                If chp2 = "\" Then
                    chp2 = ""
                    GoTo Good
                    '  Dim chq2 As Char = ddas(bob1 + 15)
                    '  chq2 = ""
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    ' chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chq2 As Char = ddas(bob1 + 15)
                If chq2 = "\" Then
                    chq2 = ""
                    GoTo Good
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    '  chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chr2 As Char = ddas(bob1 + 16)
                If chr2 = "\" Then
                    chr2 = ""
                    GoTo Good
                    ' Dim chs2 As Char = ddas(bob1 + 17)
                    ' chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    '  Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                End If
                Dim chs2 As Char = ddas(bob1 + 17)
                If chs2 = "\" Then
                    chs2 = ""
                    GoTo Good
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim cht2 As Char = ddas(bob1 + 18)
                If cht2 = "\" Then
                    cht2 = ""
                    GoTo Good
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chu2 As Char = ddas(bob1 + 19)
                If chu2 = "\" Then
                    chu2 = ""
                    GoTo Good
                    'Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chv2 As Char = ddas(bob1 + 20)
                If chv2 = "\" Then
                    chv2 = ""
                    GoTo Good
                End If
Good:
                Dim bla2 As String = cha2 + chb2 + chc2 + chd2 + che2 + chf2 + chg2 + chh2 + chi2 + chj2 + chk2 + chl2 + chm2 + chn2 + cho2 + chp2 + chq2 + chr2 + chs2 + cht2 + chu2 + chv2
                Button2.Text = bla2
                Dim as7 As Integer = bbas.IndexOf("mapname") + 8
                Dim cha1 As Char = bbas(as7)
                Dim chb1 As Char = bbas(as7 + 1)
                Dim chc1 As Char = bbas(as7 + 2)
                Dim chd1 As Char = bbas(as7 + 3)
                Dim che1 As Char = bbas(as7 + 4)
                Dim chf1 As Char = bbas(as7 + 5)
                Dim chg1 As Char = bbas(as7 + 6)
                Dim chh1 As Char = bbas(as7 + 7)
                If chh1 = "\" Then
                    chh1 = ""
                End If
                Dim chi1 As Char = bbas(as7 + 8)
                If chi1 = "\" Then
                    chi1 = ""
                End If
                Dim chj1 As Char = bbas(as7 + 9)
                If chj1 = "\" Then
                    chj1 = ""
                End If
                Dim chk1 As Char = bbas(as7 + 10)
                If chk1 = "\" Then
                    chk1 = ""
                End If
                Dim chl1 As Char = bbas(as7 + 11)
                If chl1 = "\" Then
                    chl1 = ""
                End If
                Dim chm1 As Char = bbas(as7 + 12)
                If chm1 = "\" Then
                    chm1 = ""
                End If
                Dim chn1 As Char = bbas(as7 + 13)
                If chn1 = "\" Then
                    chn1 = ""
                End If
                Dim cho1 As Char = bbas(as7 + 14)
                If cho1 = "\" Then
                    cho1 = ""
                End If
                Dim chp1 As Char = bbas(as7 + 15)
                If chp1 = "\" Then
                    chp1 = ""
                End If
                Dim chq1 As Char = bbas(as7 + 16)
                If chq1 = "\" Then
                    chq1 = ""
                End If
                Dim chr1 As Char = bbas(as7 + 17)
                If chr1 = "\" Then
                    chr1 = ""
                End If
                Dim chs1 As Char = bbas(as7 + 18)
                If chs1 = "\" Then
                    chs1 = ""
                End If
                Dim cht1 As Char = bbas(as7 + 19)
                If cht1 = "\" Then
                    cht1 = ""
                End If
                Dim chu1 As Char = bbas(as7 + 20)
                If chu1 = "\" Then
                    chu1 = ""
                End If
                Dim chv1 As Char = bbas(as7 + 21)
                If chv1 = "\" Then
                    chv1 = ""
                End If
                Dim chw1 As Char = bbas(as7 + 22)
                If chw1 = "\" Then
                    chw1 = ""
                End If
                Dim chx1 As Char = bbas(as7 + 23)
                If chx1 = "\" Then
                    chx1 = ""
                End If
                Dim chy1 As Char = bbas(as7 + 24)
                If chy1 = "\" Then
                    chy1 = ""
                End If
                Dim chz1 As Char = bbas(as7 + 25)
                If chz1 = "\" Then
                    chz1 = ""
                End If
                Dim mapb As String
                mapb = cha1 + chb1 + chc1 + chd1 + che1 + chf1 + chg1 + chh1 + chi1 + chj1 + chk1 + chl1 + chm1 + chn1 + cho1 + chp1 + chq1 + chr1 + chs1 + cht1 + chu1 + chv1 + chw1 + chx1 + chy1 + chz1
                TextBox5.Text = mapb
            Catch ex2 As Exception
            End Try
            ProgressBar1.PerformStep()
            Try
                Dim URL41 As String = "http://igi2.pro/ipc.txt"

                Dim xwr41 As WebRequest = HttpWebRequest.Create(URL41)
                Dim ywr41 As WebResponse
                Dim gg12 As String
                ywr41 = xwr41.GetResponse()
                Using kr41 As New StreamReader(ywr41.GetResponseStream())
                    gg12 = kr41.ReadToEnd()
                    kr41.Close()
                End Using
                Dim cipherText30 As String = gg12
                'Dim password As String = InputBox("Enter the password:")
                Dim password30 As String
                password30 = "ghostxaxa"
                Dim wrapper3 As New Simple3Des(password30)

                ' DecryptData throws if the wrong password is used.

                Dim plainText30 As String = wrapper3.DecryptData(cipherText30)
                Dim ggggg0 As String
                ggggg0 = plainText30
                Dim URL51 As String = "http://igi2.pro/portc.txt"

                Dim xwr51 As WebRequest = HttpWebRequest.Create(URL51)
                Dim ywr51 As WebResponse
                Dim p51 As String
                ywr51 = xwr51.GetResponse()
                Using kr51 As New StreamReader(ywr51.GetResponseStream())
                    p51 = kr51.ReadToEnd()
                    kr51.Close()
                End Using
                Dim cipherText4 As String = p51
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper4 As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText12 As String = wrapper4.DecryptData(cipherText4)
                Dim s30 As String
                s30 = plainText12
                publisher.Connect(ggggg0, s30)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a2 As String = ASCII.GetString(rcvbytes)
                Dim ccas As String = a2
                Dim ss4 As Integer = a2.IndexOf("numplayers") + 11
                Dim ch4 As Char = a2(ss4)
                Dim ssl As String = a2
                Dim xaxz As Char = a2(ss4 + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If xaxz = "\" Then
                    TextBox2.Text = ch4
                Else
                    TextBox2.Text = ch4 + xaxz
                End If
                ' MessageBox.Show(ch)



                Dim bob1 As Integer = a2.IndexOf("hostname") + 9
                Dim ddas As String = a2
                Dim cha2 As Char = ddas(bob1)
                Dim chb2 As Char = ddas(bob1 + 1)
                Dim chc2 As Char = ddas(bob1 + 2)
                Dim chd2 As Char = ddas(bob1 + 3)
                Dim che2 As Char = ddas(bob1 + 4)
                Dim chf2 As Char = ddas(bob1 + 5)
                Dim chg2 As Char = ddas(bob1 + 6)
                Dim chh2 As Char = ddas(bob1 + 7)
                Dim chi2 As Char = ddas(bob1 + 8)
                If chi2 = "\" Then
                    chi2 = ""
                    GoTo Good12
                End If
                Dim chj2 As Char = ddas(bob1 + 9)
                If chj2 = "\" Then
                    chj2 = ""
                    GoTo Good12
                End If
                Dim chk2 As Char = ddas(bob1 + 10)
                If chk2 = "\" Then
                    chk2 = ""
                    GoTo Good12

                End If
                Dim chl2 As Char = ddas(bob1 + 11)
                If chl2 = "\" Then
                    chl2 = ""
                    GoTo Good12
                End If
                Dim chm2 As Char = ddas(bob1 + 12)
                If chm2 = "\" Then
                    chm2 = ""
                    GoTo Good12
                End If
                Dim chn2 As Char = ddas(bob1 + 13)
                If chn2 = "\" Then
                    chn2 = ""
                    GoTo Good12
                End If
                Dim cho2 As Char = ddas(bob1 + 14)
                If cho2 = "\" Then
                    cho2 = ""
                    GoTo Good12
                End If
                Dim chp2 As Char = ddas(bob1 + 15)
                If chp2 = "\" Then
                    chp2 = ""
                    GoTo Good12
                    '  Dim chq2 As Char = ddas(bob1 + 15)
                    '  chq2 = ""
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    ' chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chq2 As Char = ddas(bob1 + 16)
                If chq2 = "\" Then
                    chq2 = ""
                    GoTo Good12
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    '  chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chr2 As Char = ddas(bob1 + 17)
                If chr2 = "\" Then
                    chr2 = ""
                    GoTo Good12
                    ' Dim chs2 As Char = ddas(bob1 + 17)
                    ' chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    '  Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                End If
                Dim chs2 As Char = ddas(bob1 + 18)
                If chs2 = "\" Then
                    chs2 = ""
                    GoTo Good12
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim cht2 As Char = ddas(bob1 + 19)
                If cht2 = "\" Then
                    cht2 = ""
                    GoTo Good12
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chu2 As Char = ddas(bob1 + 20)
                If chu2 = "\" Then
                    chu2 = ""
                    GoTo Good12
                    'Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chv2 As Char = ddas(bob1 + 21)
                If chv2 = "\" Then
                    chv2 = ""

                End If
Good12:
                Dim bla2 As String = cha2 + chb2 + chc2 + chd2 + che2 + chf2 + chg2 + chh2 + chi2 + chj2 + chk2 + chl2 + chm2 + chn2 + cho2 + chp2 + chq2 + chr2 + chs2 + cht2 + chu2 + chv2
                Button4.Text = bla2
                Dim as111 As Integer = ccas.IndexOf("mapname") + 8
                Dim cha12 As Char = ccas(as111)
                Dim chb12 As Char = ccas(as111 + 1)
                Dim chc12 As Char = ccas(as111 + 2)
                Dim chd12 As Char = ccas(as111 + 3)
                Dim che12 As Char = ccas(as111 + 4)
                Dim chf12 As Char = ccas(as111 + 5)
                Dim chg12 As Char = ccas(as111 + 6)
                Dim chh12 As Char = ccas(as111 + 7)
                If chh12 = "\" Then
                    chh12 = ""
                End If
                Dim chi12 As Char = ccas(as111 + 8)
                If chi12 = "\" Then
                    chi12 = ""
                End If
                Dim chj12 As Char = ccas(as111 + 9)
                If chj12 = "\" Then
                    chj12 = ""
                End If
                Dim chk12 As Char = ccas(as111 + 10)
                If chk12 = "\" Then
                    chk12 = ""
                End If
                Dim chl12 As Char = ccas(as111 + 11)
                If chl12 = "\" Then
                    chl12 = ""
                End If
                Dim chm12 As Char = ccas(as111 + 12)
                If chm12 = "\" Then
                    chm12 = ""
                End If
                Dim chn12 As Char = ccas(as111 + 13)
                If chn12 = "\" Then
                    chn12 = ""
                End If
                Dim cho12 As Char = ccas(as111 + 14)
                If cho12 = "\" Then
                    cho12 = ""
                End If
                Dim chp12 As Char = ccas(as111 + 15)
                If chp12 = "\" Then
                    chp12 = ""
                End If
                Dim chq12 As Char = ccas(as111 + 16)
                If chq12 = "\" Then
                    chq12 = ""
                End If
                Dim chr12 As Char = ccas(as111 + 17)
                If chr12 = "\" Then
                    chr12 = ""
                End If
                Dim chs12 As Char = ccas(as111 + 18)
                If chs12 = "\" Then
                    chs12 = ""
                End If
                Dim cht12 As Char = ccas(as111 + 19)
                If cht12 = "\" Then
                    cht12 = ""
                End If
                Dim chu12 As Char = ccas(as111 + 20)
                If chu12 = "\" Then
                    chu12 = ""
                End If
                Dim chv12 As Char = ccas(as111 + 21)
                If chv12 = "\" Then
                    chv12 = ""
                End If
                Dim chw12 As Char = ccas(as111 + 22)
                If chw12 = "\" Then
                    chw12 = ""
                End If
                Dim chx12 As Char = ccas(as111 + 23)
                If chx12 = "\" Then
                    chx12 = ""
                End If
                Dim chy12 As Char = ccas(as111 + 24)
                If chy12 = "\" Then
                    chy12 = ""
                End If
                Dim chz12 As Char = ccas(as111 + 25)
                If chz12 = "\" Then
                    chz12 = ""
                End If
                Dim mapc As String
                mapc = cha12 + chb12 + chc12 + chd12 + che12 + chf12 + chg12 + chh12 + chi12 + chj12 + chk12 + chl12 + chm12 + chn12 + cho12 + chp12 + chq12 + chr12 + chs12 + cht12 + chu12 + chv12 + chw12 + chx12 + chy12 + chz12
                TextBox6.Text = mapc
            Catch ex2 As Exception
            End Try
            ProgressBar1.PerformStep()
            Try
                Dim URL41 As String = "http://igi2.pro/ipd.txt"

                Dim xwr41 As WebRequest = HttpWebRequest.Create(URL41)
                Dim ywr41 As WebResponse
                Dim gg12 As String
                ywr41 = xwr41.GetResponse()
                Using kr41 As New StreamReader(ywr41.GetResponseStream())
                    gg12 = kr41.ReadToEnd()
                    kr41.Close()
                End Using
                Dim cipherText30 As String = gg12
                'Dim password As String = InputBox("Enter the password:")
                Dim password30 As String
                password30 = "ghostxaxa"
                Dim wrapper3 As New Simple3Des(password30)

                ' DecryptData throws if the wrong password is used.

                Dim plainText30 As String = wrapper3.DecryptData(cipherText30)
                Dim ggggg0 As String
                ggggg0 = plainText30
                Dim URL51 As String = "http://igi2.pro/portd.txt"

                Dim xwr51 As WebRequest = HttpWebRequest.Create(URL51)
                Dim ywr51 As WebResponse
                Dim p51 As String
                ywr51 = xwr51.GetResponse()
                Using kr51 As New StreamReader(ywr51.GetResponseStream())
                    p51 = kr51.ReadToEnd()
                    kr51.Close()
                End Using
                Dim cipherText4 As String = p51
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper4 As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText12 As String = wrapper4.DecryptData(cipherText4)
                Dim s30 As String
                s30 = plainText12
                publisher.Connect(ggggg0, s30)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a2 As String = ASCII.GetString(rcvbytes)
                Dim ccas As String = a2
                Dim ss4 As Integer = a2.IndexOf("numplayers") + 11
                Dim ch4 As Char = a2(ss4)
                Dim ssl As String = a2
                Dim xaxz As Char = a2(ss4 + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If xaxz = "\" Then
                    TextBox3.Text = ch4
                Else
                    TextBox3.Text = ch4 + xaxz
                End If
                ' MessageBox.Show(ch)



                Dim bob1 As Integer = a2.IndexOf("hostname") + 9
                Dim ddas As String = a2
                Dim cha2 As Char = ddas(bob1)
                Dim chb2 As Char = ddas(bob1 + 1)
                Dim chc2 As Char = ddas(bob1 + 2)
                Dim chd2 As Char = ddas(bob1 + 3)
                Dim che2 As Char = ddas(bob1 + 4)
                Dim chf2 As Char = ddas(bob1 + 5)
                Dim chg2 As Char = ddas(bob1 + 6)
                Dim chh2 As Char = ddas(bob1 + 7)
                Dim chi2 As Char = ddas(bob1 + 8)
                If chi2 = "\" Then
                    chi2 = ""
                    GoTo Good111
                End If
                Dim chj2 As Char = ddas(bob1 + 9)
                If chj2 = "\" Then
                    chj2 = ""
                    GoTo Good111
                End If
                Dim chk2 As Char = ddas(bob1 + 10)
                If chk2 = "\" Then
                    chk2 = ""
                    GoTo Good111

                End If
                Dim chl2 As Char = ddas(bob1 + 11)
                If chl2 = "\" Then
                    chl2 = ""
                    GoTo Good111
                End If
                Dim chm2 As Char = ddas(bob1 + 12)
                If chm2 = "\" Then
                    chm2 = ""
                    GoTo Good111
                End If
                Dim chn2 As Char = ddas(bob1 + 13)
                If chn2 = "\" Then
                    chn2 = ""
                    GoTo Good111
                End If
                Dim cho2 As Char = ddas(bob1 + 14)
                If cho2 = "\" Then
                    cho2 = ""
                    GoTo Good111
                End If
                Dim chp2 As Char = ddas(bob1 + 15)
                If chp2 = "\" Then
                    chp2 = ""
                    GoTo Good111
                    '  Dim chq2 As Char = ddas(bob1 + 15)
                    '  chq2 = ""
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    ' chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chq2 As Char = ddas(bob1 + 16)
                If chq2 = "\" Then
                    chq2 = ""
                    GoTo Good111
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    '  chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chr2 As Char = ddas(bob1 + 17)
                If chr2 = "\" Then
                    chr2 = ""
                    GoTo Good111
                    ' Dim chs2 As Char = ddas(bob1 + 17)
                    ' chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    '  Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                End If
                Dim chs2 As Char = ddas(bob1 + 18)
                If chs2 = "\" Then
                    chs2 = ""
                    GoTo Good111
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim cht2 As Char = ddas(bob1 + 19)
                If cht2 = "\" Then
                    cht2 = ""
                    GoTo Good111
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chu2 As Char = ddas(bob1 + 20)
                If chu2 = "\" Then
                    chu2 = ""
                    GoTo Good111
                    'Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chv2 As Char = ddas(bob1 + 21)
                If chv2 = "\" Then
                    chv2 = ""

                End If
Good111:
                Dim bla2 As String = cha2 + chb2 + chc2 + chd2 + che2 + chf2 + chg2 + chh2 + chi2 + chj2 + chk2 + chl2 + chm2 + chn2 + cho2 + chp2 + chq2 + chr2 + chs2 + cht2 + chu2 + chv2
                Button3.Text = bla2
                Dim as111 As Integer = ccas.IndexOf("mapname") + 8
                Dim cha12 As Char = ccas(as111)
                Dim chb12 As Char = ccas(as111 + 1)
                Dim chc12 As Char = ccas(as111 + 2)
                Dim chd12 As Char = ccas(as111 + 3)
                Dim che12 As Char = ccas(as111 + 4)
                Dim chf12 As Char = ccas(as111 + 5)
                Dim chg12 As Char = ccas(as111 + 6)
                Dim chh12 As Char = ccas(as111 + 7)
                If chh12 = "\" Then
                    chh12 = ""
                End If
                Dim chi12 As Char = ccas(as111 + 8)
                If chi12 = "\" Then
                    chi12 = ""
                End If
                Dim chj12 As Char = ccas(as111 + 9)
                If chj12 = "\" Then
                    chj12 = ""
                End If
                Dim chk12 As Char = ccas(as111 + 10)
                If chk12 = "\" Then
                    chk12 = ""
                End If
                Dim chl12 As Char = ccas(as111 + 11)
                If chl12 = "\" Then
                    chl12 = ""
                End If
                Dim chm12 As Char = ccas(as111 + 12)
                If chm12 = "\" Then
                    chm12 = ""
                End If
                Dim chn12 As Char = ccas(as111 + 13)
                If chn12 = "\" Then
                    chn12 = ""
                End If
                Dim cho12 As Char = ccas(as111 + 14)
                If cho12 = "\" Then
                    cho12 = ""
                End If
                Dim chp12 As Char = ccas(as111 + 15)
                If chp12 = "\" Then
                    chp12 = ""
                End If
                Dim chq12 As Char = ccas(as111 + 16)
                If chq12 = "\" Then
                    chq12 = ""
                End If
                Dim chr12 As Char = ccas(as111 + 17)
                If chr12 = "\" Then
                    chr12 = ""
                End If
                Dim chs12 As Char = ccas(as111 + 18)
                If chs12 = "\" Then
                    chs12 = ""
                End If
                Dim cht12 As Char = ccas(as111 + 19)
                If cht12 = "\" Then
                    cht12 = ""
                End If
                Dim chu12 As Char = ccas(as111 + 20)
                If chu12 = "\" Then
                    chu12 = ""
                End If
                Dim chv12 As Char = ccas(as111 + 21)
                If chv12 = "\" Then
                    chv12 = ""
                End If
                Dim chw12 As Char = ccas(as111 + 22)
                If chw12 = "\" Then
                    chw12 = ""
                End If
                Dim chx12 As Char = ccas(as111 + 23)
                If chx12 = "\" Then
                    chx12 = ""
                End If
                Dim chy12 As Char = ccas(as111 + 24)
                If chy12 = "\" Then
                    chy12 = ""
                End If
                Dim chz12 As Char = ccas(as111 + 25)
                If chz12 = "\" Then
                    chz12 = ""
                End If
                Dim mapc As String
                mapc = cha12 + chb12 + chc12 + chd12 + che12 + chf12 + chg12 + chh12 + chi12 + chj12 + chk12 + chl12 + chm12 + chn12 + cho12 + chp12 + chq12 + chr12 + chs12 + cht12 + chu12 + chv12 + chw12 + chx12 + chy12 + chz12
                TextBox4.Text = mapc
            Catch ex2 As Exception
            End Try
            ProgressBar1.PerformStep()
            Try
                Dim URL41 As String = "http://igi2.pro/ipe.txt"

                Dim xwr41 As WebRequest = HttpWebRequest.Create(URL41)
                Dim ywr41 As WebResponse
                Dim gg12 As String
                ywr41 = xwr41.GetResponse()
                Using kr41 As New StreamReader(ywr41.GetResponseStream())
                    gg12 = kr41.ReadToEnd()
                    kr41.Close()
                End Using
                Dim cipherText30 As String = gg12
                'Dim password As String = InputBox("Enter the password:")
                Dim password30 As String
                password30 = "ghostxaxa"
                Dim wrapper3 As New Simple3Des(password30)

                ' DecryptData throws if the wrong password is used.

                Dim plainText30 As String = wrapper3.DecryptData(cipherText30)
                Dim ggggg0 As String
                ggggg0 = plainText30
                Dim URL51 As String = "http://igi2.pro/porte.txt"

                Dim xwr51 As WebRequest = HttpWebRequest.Create(URL51)
                Dim ywr51 As WebResponse
                Dim p51 As String
                ywr51 = xwr51.GetResponse()
                Using kr51 As New StreamReader(ywr51.GetResponseStream())
                    p51 = kr51.ReadToEnd()
                    kr51.Close()
                End Using
                Dim cipherText4 As String = p51
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper4 As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText12 As String = wrapper4.DecryptData(cipherText4)
                Dim s30 As String
                s30 = plainText12
                publisher.Connect(ggggg0, s30)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a2 As String = ASCII.GetString(rcvbytes)
                Dim ccas As String = a2
                Dim ss4 As Integer = a2.IndexOf("numplayers") + 11
                Dim ch4 As Char = a2(ss4)
                Dim ssl As String = a2
                Dim xaxz As Char = a2(ss4 + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If xaxz = "\" Then
                    TextBox8.Text = ch4
                Else
                    TextBox8.Text = ch4 + xaxz
                End If
                ' MessageBox.Show(ch)



                Dim bob1 As Integer = a2.IndexOf("hostname") + 9
                Dim ddas As String = a2
                Dim cha2 As Char = ddas(bob1)
                Dim chb2 As Char = ddas(bob1 + 1)
                Dim chc2 As Char = ddas(bob1 + 2)
                Dim chd2 As Char = ddas(bob1 + 3)
                Dim che2 As Char = ddas(bob1 + 4)
                Dim chf2 As Char = ddas(bob1 + 5)
                Dim chg2 As Char = ddas(bob1 + 6)
                Dim chh2 As Char = ddas(bob1 + 7)
                Dim chi2 As Char = ddas(bob1 + 8)
                If chi2 = "\" Then
                    chi2 = ""
                    GoTo Good112
                End If
                Dim chj2 As Char = ddas(bob1 + 9)
                If chj2 = "\" Then
                    chj2 = ""
                    GoTo Good112
                End If
                Dim chk2 As Char = ddas(bob1 + 10)
                If chk2 = "\" Then
                    chk2 = ""
                    GoTo Good112

                End If
                Dim chl2 As Char = ddas(bob1 + 11)
                If chl2 = "\" Then
                    chl2 = ""
                    GoTo Good112
                End If
                Dim chm2 As Char = ddas(bob1 + 12)
                If chm2 = "\" Then
                    chm2 = ""
                    GoTo Good112
                End If
                Dim chn2 As Char = ddas(bob1 + 13)
                If chn2 = "\" Then
                    chn2 = ""
                    GoTo Good112
                End If
                Dim cho2 As Char = ddas(bob1 + 14)
                If cho2 = "\" Then
                    cho2 = ""
                    GoTo Good112
                End If
                Dim chp2 As Char = ddas(bob1 + 15)
                If chp2 = "\" Then
                    chp2 = ""
                    GoTo Good112
                    '  Dim chq2 As Char = ddas(bob1 + 15)
                    '  chq2 = ""
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    ' chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chq2 As Char = ddas(bob1 + 16)
                If chq2 = "\" Then
                    chq2 = ""
                    GoTo Good112
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    '  chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chr2 As Char = ddas(bob1 + 17)
                If chr2 = "\" Then
                    chr2 = ""
                    GoTo Good112
                    ' Dim chs2 As Char = ddas(bob1 + 17)
                    ' chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    '  Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                End If
                Dim chs2 As Char = ddas(bob1 + 18)
                If chs2 = "\" Then
                    chs2 = ""
                    GoTo Good112
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim cht2 As Char = ddas(bob1 + 19)
                If cht2 = "\" Then
                    cht2 = ""
                    GoTo Good112
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chu2 As Char = ddas(bob1 + 20)
                If chu2 = "\" Then
                    chu2 = ""
                    GoTo Good112
                    'Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chv2 As Char = ddas(bob1 + 21)
                If chv2 = "\" Then
                    chv2 = ""

                End If
Good112:
                Dim bla2 As String = cha2 + chb2 + chc2 + chd2 + che2 + chf2 + chg2 + chh2 + chi2 + chj2 + chk2 + chl2 + chm2 + chn2 + cho2 + chp2 + chq2 + chr2 + chs2 + cht2 + chu2 + chv2
                Button6.Text = bla2
                Dim as111 As Integer = ccas.IndexOf("mapname") + 8
                Dim cha12 As Char = ccas(as111)
                Dim chb12 As Char = ccas(as111 + 1)
                Dim chc12 As Char = ccas(as111 + 2)
                Dim chd12 As Char = ccas(as111 + 3)
                Dim che12 As Char = ccas(as111 + 4)
                Dim chf12 As Char = ccas(as111 + 5)
                Dim chg12 As Char = ccas(as111 + 6)
                Dim chh12 As Char = ccas(as111 + 7)
                If chh12 = "\" Then
                    chh12 = ""
                End If
                Dim chi12 As Char = ccas(as111 + 8)
                If chi12 = "\" Then
                    chi12 = ""
                End If
                Dim chj12 As Char = ccas(as111 + 9)
                If chj12 = "\" Then
                    chj12 = ""
                End If
                Dim chk12 As Char = ccas(as111 + 10)
                If chk12 = "\" Then
                    chk12 = ""
                End If
                Dim chl12 As Char = ccas(as111 + 11)
                If chl12 = "\" Then
                    chl12 = ""
                End If
                Dim chm12 As Char = ccas(as111 + 12)
                If chm12 = "\" Then
                    chm12 = ""
                End If
                Dim chn12 As Char = ccas(as111 + 13)
                If chn12 = "\" Then
                    chn12 = ""
                End If
                Dim cho12 As Char = ccas(as111 + 14)
                If cho12 = "\" Then
                    cho12 = ""
                End If
                Dim chp12 As Char = ccas(as111 + 15)
                If chp12 = "\" Then
                    chp12 = ""
                End If
                Dim chq12 As Char = ccas(as111 + 16)
                If chq12 = "\" Then
                    chq12 = ""
                End If
                Dim chr12 As Char = ccas(as111 + 17)
                If chr12 = "\" Then
                    chr12 = ""
                End If
                Dim chs12 As Char = ccas(as111 + 18)
                If chs12 = "\" Then
                    chs12 = ""
                End If
                Dim cht12 As Char = ccas(as111 + 19)
                If cht12 = "\" Then
                    cht12 = ""
                End If
                Dim chu12 As Char = ccas(as111 + 20)
                If chu12 = "\" Then
                    chu12 = ""
                End If
                Dim chv12 As Char = ccas(as111 + 21)
                If chv12 = "\" Then
                    chv12 = ""
                End If
                Dim chw12 As Char = ccas(as111 + 22)
                If chw12 = "\" Then
                    chw12 = ""
                End If
                Dim chx12 As Char = ccas(as111 + 23)
                If chx12 = "\" Then
                    chx12 = ""
                End If
                Dim chy12 As Char = ccas(as111 + 24)
                If chy12 = "\" Then
                    chy12 = ""
                End If
                Dim chz12 As Char = ccas(as111 + 25)
                If chz12 = "\" Then
                    chz12 = ""
                End If
                Dim mapc As String
                mapc = cha12 + chb12 + chc12 + chd12 + che12 + chf12 + chg12 + chh12 + chi12 + chj12 + chk12 + chl12 + chm12 + chn12 + cho12 + chp12 + chq12 + chr12 + chs12 + cht12 + chu12 + chv12 + chw12 + chx12 + chy12 + chz12
                TextBox7.Text = mapc
            Catch ex2 As Exception
            End Try
            ProgressBar1.PerformStep()
            Try
                Dim URL41 As String = "http://igi2.pro/ipf.txt"

                Dim xwr41 As WebRequest = HttpWebRequest.Create(URL41)
                Dim ywr41 As WebResponse
                Dim gg12 As String
                ywr41 = xwr41.GetResponse()
                Using kr41 As New StreamReader(ywr41.GetResponseStream())
                    gg12 = kr41.ReadToEnd()
                    kr41.Close()
                End Using
                Dim cipherText30 As String = gg12
                'Dim password As String = InputBox("Enter the password:")
                Dim password30 As String
                password30 = "ghostxaxa"
                Dim wrapper3 As New Simple3Des(password30)

                ' DecryptData throws if the wrong password is used.

                Dim plainText30 As String = wrapper3.DecryptData(cipherText30)
                Dim ggggg0 As String
                ggggg0 = plainText30
                Dim URL51 As String = "http://igi2.pro/portf.txt"

                Dim xwr51 As WebRequest = HttpWebRequest.Create(URL51)
                Dim ywr51 As WebResponse
                Dim p51 As String
                ywr51 = xwr51.GetResponse()
                Using kr51 As New StreamReader(ywr51.GetResponseStream())
                    p51 = kr51.ReadToEnd()
                    kr51.Close()
                End Using
                Dim cipherText4 As String = p51
                'Dim password As String = InputBox("Enter the password:")
                Dim password As String
                password = "ghostxaxa"
                Dim wrapper4 As New Simple3Des(password)

                ' DecryptData throws if the wrong password is used.

                Dim plainText12 As String = wrapper4.DecryptData(cipherText4)
                Dim s30 As String
                s30 = plainText12
                publisher.Connect(ggggg0, s30)
                Dim sendbytes() As Byte = ASCII.GetBytes("\status\")
                publisher.Send(sendbytes, sendbytes.Length)
                Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
                Dim rcvbytes() As Byte = publisher.Receive(ep)
                Dim a2 As String = ASCII.GetString(rcvbytes)
                Dim ccas As String = a2
                Dim ss4 As Integer = a2.IndexOf("numplayers") + 11
                Dim ch4 As Char = a2(ss4)
                Dim ssl As String = a2
                Dim xaxz As Char = a2(ss4 + 1)
                ' MsgBox(InStr(a, "numplayers"))
                If xaxz = "\" Then
                    TextBox10.Text = ch4
                Else
                    TextBox10.Text = ch4 + xaxz
                End If
                ' MessageBox.Show(ch)



                Dim bob1 As Integer = a2.IndexOf("hostname") + 9
                Dim ddas As String = a2
                Dim cha2 As Char = ddas(bob1)
                Dim chb2 As Char = ddas(bob1 + 1)
                Dim chc2 As Char = ddas(bob1 + 2)
                Dim chd2 As Char = ddas(bob1 + 3)
                Dim che2 As Char = ddas(bob1 + 4)
                Dim chf2 As Char = ddas(bob1 + 5)
                Dim chg2 As Char = ddas(bob1 + 6)
                Dim chh2 As Char = ddas(bob1 + 7)
                Dim chi2 As Char = ddas(bob1 + 8)
                If chi2 = "\" Then
                    chi2 = ""
                    GoTo Good1120
                End If
                Dim chj2 As Char = ddas(bob1 + 9)
                If chj2 = "\" Then
                    chj2 = ""
                    GoTo Good1120
                End If
                Dim chk2 As Char = ddas(bob1 + 10)
                If chk2 = "\" Then
                    chk2 = ""
                    GoTo Good1120

                End If
                Dim chl2 As Char = ddas(bob1 + 11)
                If chl2 = "\" Then
                    chl2 = ""
                    GoTo Good1120
                End If
                Dim chm2 As Char = ddas(bob1 + 12)
                If chm2 = "\" Then
                    chm2 = ""
                    GoTo Good1120
                End If
                Dim chn2 As Char = ddas(bob1 + 13)
                If chn2 = "\" Then
                    chn2 = ""
                    GoTo Good1120
                End If
                Dim cho2 As Char = ddas(bob1 + 14)
                If cho2 = "\" Then
                    cho2 = ""
                    GoTo Good1120
                End If
                Dim chp2 As Char = ddas(bob1 + 15)
                If chp2 = "\" Then
                    chp2 = ""
                    GoTo Good1120
                    '  Dim chq2 As Char = ddas(bob1 + 15)
                    '  chq2 = ""
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    ' chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chq2 As Char = ddas(bob1 + 16)
                If chq2 = "\" Then
                    chq2 = ""
                    GoTo Good1120
                    '  Dim chr2 As Char = ddas(bob1 + 16)
                    '  chr2 = ""
                    '  Dim chs2 As Char = ddas(bob1 + 17)
                    '  chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chr2 As Char = ddas(bob1 + 17)
                If chr2 = "\" Then
                    chr2 = ""
                    GoTo Good1120
                    ' Dim chs2 As Char = ddas(bob1 + 17)
                    ' chs2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                    '  Dim cht2 As Char = ddas(bob1 + 18)
                    '  cht2 = ""
                    '  Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    '  Dim chv2 As Char = ddas(bob1 + 20)
                    '  chv2 = ""
                End If
                Dim chs2 As Char = ddas(bob1 + 18)
                If chs2 = "\" Then
                    chs2 = ""
                    GoTo Good1120
                    ' Dim cht2 As Char = ddas(bob1 + 18)
                    ' cht2 = ""
                    'Dim chu2 As Char = ddas(bob1 + 19)
                    ' chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim cht2 As Char = ddas(bob1 + 19)
                If cht2 = "\" Then
                    cht2 = ""
                    GoTo Good1120
                    ' Dim chu2 As Char = ddas(bob1 + 19)
                    '  chu2 = ""
                    ' Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chu2 As Char = ddas(bob1 + 20)
                If chu2 = "\" Then
                    chu2 = ""
                    GoTo Good1120
                    'Dim chv2 As Char = ddas(bob1 + 20)
                    ' chv2 = ""
                End If
                Dim chv2 As Char = ddas(bob1 + 21)
                If chv2 = "\" Then
                    chv2 = ""

                End If
Good1120:
                Dim bla2 As String = cha2 + chb2 + chc2 + chd2 + che2 + chf2 + chg2 + chh2 + chi2 + chj2 + chk2 + chl2 + chm2 + chn2 + cho2 + chp2 + chq2 + chr2 + chs2 + cht2 + chu2 + chv2
                Button7.Text = bla2
                Dim as111 As Integer = ccas.IndexOf("mapname") + 8
                Dim cha12 As Char = ccas(as111)
                Dim chb12 As Char = ccas(as111 + 1)
                Dim chc12 As Char = ccas(as111 + 2)
                Dim chd12 As Char = ccas(as111 + 3)
                Dim che12 As Char = ccas(as111 + 4)
                Dim chf12 As Char = ccas(as111 + 5)
                Dim chg12 As Char = ccas(as111 + 6)
                Dim chh12 As Char = ccas(as111 + 7)
                If chh12 = "\" Then
                    chh12 = ""
                End If
                Dim chi12 As Char = ccas(as111 + 8)
                If chi12 = "\" Then
                    chi12 = ""
                End If
                Dim chj12 As Char = ccas(as111 + 9)
                If chj12 = "\" Then
                    chj12 = ""
                End If
                Dim chk12 As Char = ccas(as111 + 10)
                If chk12 = "\" Then
                    chk12 = ""
                End If
                Dim chl12 As Char = ccas(as111 + 11)
                If chl12 = "\" Then
                    chl12 = ""
                End If
                Dim chm12 As Char = ccas(as111 + 12)
                If chm12 = "\" Then
                    chm12 = ""
                End If
                Dim chn12 As Char = ccas(as111 + 13)
                If chn12 = "\" Then
                    chn12 = ""
                End If
                Dim cho12 As Char = ccas(as111 + 14)
                If cho12 = "\" Then
                    cho12 = ""
                End If
                Dim chp12 As Char = ccas(as111 + 15)
                If chp12 = "\" Then
                    chp12 = ""
                End If
                Dim chq12 As Char = ccas(as111 + 16)
                If chq12 = "\" Then
                    chq12 = ""
                End If
                Dim chr12 As Char = ccas(as111 + 17)
                If chr12 = "\" Then
                    chr12 = ""
                End If
                Dim chs12 As Char = ccas(as111 + 18)
                If chs12 = "\" Then
                    chs12 = ""
                End If
                Dim cht12 As Char = ccas(as111 + 19)
                If cht12 = "\" Then
                    cht12 = ""
                End If
                Dim chu12 As Char = ccas(as111 + 20)
                If chu12 = "\" Then
                    chu12 = ""
                End If
                Dim chv12 As Char = ccas(as111 + 21)
                If chv12 = "\" Then
                    chv12 = ""
                End If
                Dim chw12 As Char = ccas(as111 + 22)
                If chw12 = "\" Then
                    chw12 = ""
                End If
                Dim chx12 As Char = ccas(as111 + 23)
                If chx12 = "\" Then
                    chx12 = ""
                End If
                Dim chy12 As Char = ccas(as111 + 24)
                If chy12 = "\" Then
                    chy12 = ""
                End If
                Dim chz12 As Char = ccas(as111 + 25)
                If chz12 = "\" Then
                    chz12 = ""
                End If
                Dim mapc As String
                mapc = cha12 + chb12 + chc12 + chd12 + che12 + chf12 + chg12 + chh12 + chi12 + chj12 + chk12 + chl12 + chm12 + chn12 + cho12 + chp12 + chq12 + chr12 + chs12 + cht12 + chu12 + chv12 + chw12 + chx12 + chy12 + chz12
                TextBox9.Text = mapc

            Catch ex2 As Exception
            End Try
            ProgressBar1.PerformStep()
            ProgressBar1.Value = ProgressBar1.Maximum
            System.Threading.Thread.Sleep(100)
            ProgressBar1.Value = ProgressBar1.Minimum
            Timer9.Stop()
        End If
    End Sub
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
       
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
      
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    End Sub


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub GHOSTLAUNCHER1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint
        End If
    End Sub


    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Timer9.Start()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Try
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)


            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/porta.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim s As String
            s = plainText

            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passa.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText2 As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper2.DecryptData(cipherText2)
            Dim rqq As String
            rqq = plainText2
            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rqq

            Dim URL4 As String = "http://igi2.pro/ipa.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText3 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
            Dim gggg As String
            gggg = plainText3

            command = "ip" + gggg + " port" + s + serd
            Process.Start("igi2.exe", command)
        Catch ex2 As Exception
            MessageBox.Show("Stop launcher and IGI2 from task manager and Restart Them")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Try


            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/portb.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim s As String
            s = plainText
            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passb.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText3 As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper.DecryptData(cipherText3)
            Dim rq2 As String
            rq2 = plainText3

            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rq2

            Dim URL4 As String = "http://igi2.pro/ipb.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText2 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper.DecryptData(cipherText2)
            Dim rq As String
            rq = plainText2


            command = "ip" + rq + " port" + s + serd
            Process.Start("igi2.exe", command)
        Catch fdfdf As Exception
            MessageBox.Show("Kill launcher and igi2 from task manager and Restart launcher")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Try

            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/portc.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText2 As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper2.DecryptData(cipherText2)
            Dim rq As String
            rq = plainText2
            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passc.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim rq2 As String
            rq2 = plainText
            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rq2

            Dim URL4 As String = "http://igi2.pro/ipc.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText3 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
            Dim rq3 As String
            rq3 = plainText3

            command = "ip" + rq3 + " port" + rq + serd
            Process.Start("igi2.exe", command)
        Catch afjdif As Exception
            MessageBox.Show("Kill launcher and igi2 from task manager and Restart launcher")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Try
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)


            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/portd.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim s As String
            s = plainText

            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passd.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText2 As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper2.DecryptData(cipherText2)
            Dim rqq As String
            rqq = plainText2
            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rqq

            Dim URL4 As String = "http://igi2.pro/ipd.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText3 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
            Dim gggg As String
            gggg = plainText3

            command = "ip" + gggg + " port" + s + serd
            Process.Start("igi2.exe", command)
        Catch ex2 As Exception
            MessageBox.Show("Stop launcher and IGI2 from task manager and Restart Them")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Try
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)


            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/porte.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim s As String
            s = plainText

            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passe.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText2 As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper2.DecryptData(cipherText2)
            Dim rqq As String
            rqq = plainText2
            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rqq

            Dim URL4 As String = "http://igi2.pro/ipe.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText3 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
            Dim gggg As String
            gggg = plainText3

            command = "ip" + gggg + " port" + s + serd
            Process.Start("igi2.exe", command)
        Catch ex2 As Exception
            MessageBox.Show("Stop launcher and IGI2 from task manager and Restart Them")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Try
            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            My.Computer.FileSystem.DeleteFile("WEAPONS\weapon.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm")
            My.Computer.FileSystem.DeleteFile("HUMANPLAYER\humanplayer.qvm")
            My.Computer.FileSystem.DeleteFile("MISSIONS\multiplayer\sandstorm\objects.qvm")
            Savefromresource("igi2.exe", My.Resources.igi2)
            My.Computer.FileSystem.DeleteFile("igi2.exe")
            Savefromresource("igi2.exe", My.Resources.igi2)


            Savefromresource("HUMANPLAYER\humanplayer.qvm", My.Resources.humanplayer)
            Savefromresource("WEAPONS\weapon.qvm", My.Resources.weapon)
            Savefromresource("MISSIONS\multiplayer\mplocation2\LEVEL3\objects.qvm", My.Resources.objects)
            Savefromresource("MISSIONS\multiplayer\sandstorm\objects.qvm", My.Resources.objects2)
            Dim URL As String = "http://igi2.pro/portf.txt"

            Dim xwr As WebRequest = HttpWebRequest.Create(URL)
            Dim ywr As WebResponse
            Dim p As String
            ywr = xwr.GetResponse()
            Using kr As New StreamReader(ywr.GetResponseStream())
                p = kr.ReadToEnd()
                kr.Close()
            End Using
            Dim cipherText As String = p
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "ghostxaxa"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim plainText As String = wrapper.DecryptData(cipherText)
            Dim s As String
            s = plainText

            Dim command As String

            Dim a As String
            a = " player" + My.Settings.Playername + """"
            Dim URL3 As String = "http://igi2.pro/passf.txt"

            Dim xwr3 As WebRequest = HttpWebRequest.Create(URL3)
            Dim ywr3 As WebResponse
            Dim rr As String
            ywr3 = xwr3.GetResponse()
            Using kr3 As New StreamReader(ywr3.GetResponseStream())
                rr = kr3.ReadToEnd()
                kr3.Close()
            End Using
            Dim cipherText2 As String = rr
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "ghostxaxa"
            Dim wrapper2 As New Simple3Des(password2)

            ' DecryptData throws if the wrong password is used.

            Dim plainText2 As String = wrapper2.DecryptData(cipherText2)
            Dim rqq As String
            rqq = plainText2
            Dim qqq As String
            qqq = " password" + rr
            Dim serd As String
            serd = " player""" + My.Settings.Playername + " " + """" + " password" + rqq

            Dim URL4 As String = "http://igi2.pro/ipf.txt"

            Dim xwr4 As WebRequest = HttpWebRequest.Create(URL4)
            Dim ywr4 As WebResponse
            Dim gg As String
            ywr4 = xwr4.GetResponse()
            Using kr4 As New StreamReader(ywr4.GetResponseStream())
                gg = kr4.ReadToEnd()
                kr4.Close()
            End Using
            Dim cipherText3 As String = gg
            'Dim password As String = InputBox("Enter the password:")
            Dim password3 As String
            password3 = "ghostxaxa"
            Dim wrapper3 As New Simple3Des(password3)

            ' DecryptData throws if the wrong password is used.

            Dim plainText3 As String = wrapper3.DecryptData(cipherText3)
            Dim gggg As String
            gggg = plainText3

            command = "ip" + gggg + " port" + s + serd
            Process.Start("igi2.exe", command)
        Catch ex2 As Exception
            MessageBox.Show("Stop launcher and IGI2 from task manager and Restart Them")
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        Process.Start("www.shooter.unaux.com")
    End Sub
End Class
Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(
ByVal key As String,
ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    Public Function EncryptData(
ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return System.Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function DecryptData(
ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = System.Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class
