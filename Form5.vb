Public Class Form5
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim fileReader22 As String
            fileReader22 = My.Computer.FileSystem.ReadAllText("themes.cfg", System.Text.Encoding.UTF8)
            If fileReader22 = "ola1" Then
                BackgroundImage = My.Resources.ola1
                My.Computer.Audio.Play(My.Resources.baba, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola2" Then
                BackgroundImage = My.Resources.ola2
                My.Computer.Audio.Play(My.Resources.olaaa, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola3" Then
                BackgroundImage = My.Resources.ola3
                My.Computer.Audio.Play(My.Resources.ola22, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola5" Then
                BackgroundImage = My.Resources.ola5
                My.Computer.Audio.Play(My.Resources.olb, AudioPlayMode.BackgroundLoop)
            ElseIf fileReader22 = "ola7" Then
                BackgroundImage = My.Resources.ola7
                My.Computer.Audio.Play(My.Resources._23, AudioPlayMode.BackgroundLoop)
            End If
        Catch fff As Exception
            BackgroundImage = My.Resources.ola7
            My.Computer.Audio.Play(My.Resources._23, AudioPlayMode.BackgroundLoop)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Close()
        GHOSTLAUNCHER1.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GHOSTLAUNCHER1.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint
        End If
    End Sub
    Private Sub Form5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("This Launcher is brought to you by <{GH[*]$t}> in Association with IGI2 HOMECOMING. Care has been taken to ensure that no copyright is infringed but if somehow it is missed, inform to the owner. Thanks for using! |Launcher by : <{GH[*]$t}>|   |www.igi2.pro|  |www.igi2.in|", "   Disclaimer")
    End Sub
End Class