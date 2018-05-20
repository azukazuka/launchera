Public Class Form3


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim null As String = Nothing

        If My.Settings.Username = null Then

            My.Settings.Username = TextBox1.Text
            My.Settings.Password = TextBox2.Text
            My.Settings.Playername = TextBox3.Text
            My.Settings.Save()
            Dim plainText As String = My.Settings.Playername
            Dim password As String = "xuaj"

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(plainText)


            My.Computer.FileSystem.WriteAllText("theme.dat", cipherText, False)
            Dim plainText2 As String = My.Settings.Username
            Dim password2 As String = "parkour"

            Dim wrapper2 As New Simple3Des(password2)
            Dim cipherText2 As String = wrapper2.EncryptData(plainText2)
            My.Computer.FileSystem.WriteAllText("image.dat", cipherText2, False)


            Dim plainText22 As String = My.Settings.Password
            Dim password22 As String = "arcon"

            Dim wrapper22 As New Simple3Des(password22)
            Dim cipherText22 As String = wrapper22.EncryptData(plainText22)
            My.Computer.FileSystem.WriteAllText("music.dat", cipherText22, False)

            Form2.Show()
            Me.Close()
        Else
            MessageBox.Show("!You already created an account!")
            GHOSTLAUNCHER1.Close()
            Form2.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Close()
        GHOSTLAUNCHER1.Close()
        Me.Close()
    End Sub
End Class