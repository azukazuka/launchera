Imports System.IO
Imports System.Net

Public Class Form2
    Dim version As Integer = 30
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GHOSTLAUNCHER1.Close()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Note:Only 1 player Name is valid")
        Form3.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And
         TextBox2.Text = My.Settings.Password Then
            Form5.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid login credentials")

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If My.Settings.Username = "" Then
        Else
            LinkLabel1.Text = ""
        End If
        If IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "GH[]$t LauncheR" Then

        Else
            MessageBox.Show("Nope! Renaming not allowed :\ ")
            GHOSTLAUNCHER1.Close()
            Me.Close()
        End If
        'Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\None"
        '   If Dir("image.dat") <> "" Then
        '  Else

        '  My.Computer.FileSystem.DeleteDirectory("C:\Users\" + Environment.UserName + "\AppData\Local\None", FileIO.DeleteDirectoryOption.DeleteAllContents)
        '  End If
        ' If Dir("music.dat") <> "" Then

        '  Else
        ' My.Computer.FileSystem.DeleteDirectory("C:\Users\" + Environment.UserName + "\AppData\Local\None", FileIO.DeleteDirectoryOption.DeleteAllContents)
        '  End If
        '  If Dir("theme.dat") <> "" Then

        '   Else
        '   My.Computer.FileSystem.DeleteDirectory("C:\Users\" + Environment.UserName + "\AppData\Local\None", FileIO.DeleteDirectoryOption.DeleteAllContents)

        '
        '  End If
        Try
            Dim fileReader221 As String
            fileReader221 = My.Computer.FileSystem.ReadAllText("theme.dat", System.Text.Encoding.UTF8)
            Dim cipherTex As String = fileReader221
            'Dim password As String = InputBox("Enter the password:")
            Dim password As String
            password = "xaxd"
            Dim wrapper As New Simple3Des(password)

            ' DecryptData throws if the wrong password is used.

            Dim wah As String = wrapper.DecryptData(cipherTex)
            My.Settings.Playername = wah
            Dim us As String
            us = Environment.UserName
            If us = "Harsh" Then
                GHOSTLAUNCHER1.Close()
                Me.Close()
            ElseIf us = "Sachin" Then
                GHOSTLAUNCHER1.Close()
                Me.Close()
            End If
            Dim fileReader2221 As String
            fileReader2221 = My.Computer.FileSystem.ReadAllText("image.dat", System.Text.Encoding.UTF8)
            Dim cipherTex2 As String = fileReader2221
            'Dim password As String = InputBox("Enter the password:")
            Dim password2 As String
            password2 = "atat"
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
            password22 = "atatat22"
            Dim wrapper22 As New Simple3Des(password22)

            ' DecryptData throws if the wrong password is used.

            Dim wah22 As String = wrapper22.DecryptData(cipherTex22)
            If wah22 = My.Settings.Password Then
            Else
                My.Settings.Password = wah22
            End If
        Catch dfa As Exception
        End Try

        TextBox1.Text = My.Settings.Username
        TextBox2.Text = My.Settings.Password
        Dim URL As String = "http://igi2.pro/version.txt"

        Dim xwr As WebRequest = HttpWebRequest.Create(URL)
        Dim ywr As WebResponse
        Dim serv As String
        ywr = xwr.GetResponse()
        Using kr As New StreamReader(ywr.GetResponseStream())
            serv = kr.ReadToEnd()
            ' Close and clean up the StreamReader
            kr.Close()
        End Using
        If serv = version Then
        Else
            Dim URL55 As String = "http://igi2.pro/msg.txt"

            Dim xwr55 As WebRequest = HttpWebRequest.Create(URL55)
            Dim ywr55 As WebResponse
            Dim serv55 As String
            ywr55 = xwr55.GetResponse()
            Using kr55 As New StreamReader(ywr55.GetResponseStream())
                serv55 = kr55.ReadToEnd()
                ' Close and clean up the StreamReader
                kr55.Close()
            End Using

            MessageBox.Show(serv55)

            Dim URL2 As String = "http://igi2.pro/upd.txt"

            Dim xwr2 As WebRequest = HttpWebRequest.Create(URL2)
            Dim ywr2 As WebResponse
            Dim ver As String
            ywr2 = xwr2.GetResponse()
            Using kr2 As New StreamReader(ywr2.GetResponseStream())
                ver = kr2.ReadToEnd()

                kr2.Close()
            End Using
            Process.Start(ver)
            Me.Close()
        End If
    End Sub
End Class