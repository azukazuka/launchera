Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola1", True)

        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola1
        Form5.BackgroundImage = My.Resources.ola1
        My.Computer.FileSystem.DeleteFile("themes.cfg")
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola1", True)
        My.Computer.Audio.Play(My.Resources.baba, AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola2", True)
        My.Computer.FileSystem.DeleteFile("themes.cfg")
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola2", True)
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola2
        Form5.BackgroundImage = My.Resources.ola2
        My.Computer.Audio.Play(My.Resources.olaaa, AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola3", True)
        My.Computer.FileSystem.DeleteFile("themes.cfg")
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola3", True)
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola3
        Form5.BackgroundImage = My.Resources.ola3
        My.Computer.Audio.Play(My.Resources.ola22, AudioPlayMode.BackgroundLoop)

        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola4
        Form5.BackgroundImage = My.Resources.ola4
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola5", True)
        My.Computer.FileSystem.DeleteFile("themes.cfg")
        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola5", True)
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola5
        Form5.BackgroundImage = My.Resources.ola5
        My.Computer.Audio.Play(My.Resources.olb, AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola6
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola7", True)
        My.Computer.FileSystem.DeleteFile("themes.cfg")

        My.Computer.FileSystem.WriteAllText("themes.cfg", "ola7", True)
        GHOSTLAUNCHER1.BackgroundImage = My.Resources.ola7
        Form5.BackgroundImage = My.Resources.ola1
        My.Computer.Audio.Play(My.Resources._23, AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class