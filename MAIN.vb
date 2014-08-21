Imports System
Imports System.IO
Imports System.Text
Public Class MAIN


    Dim loginSDownloaded As Boolean
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub champ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles champ.SelectedIndexChanged

    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Label3.Visible = True
        ' This is to prevent bugs
        If champ.Text = "" Then Me.Close()
        ' Checks if the swf is downloaded
        If IO.File.Exists("C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\login.swf") Then loginSDownloaded = True
        If loginSDownloaded = False Then
            IO.Directory.CreateDirectory("C:\Riot Games\Titan_Bullet\SWF\" & champ.Text)
            My.Computer.Network.DownloadFile(
    "http://lollsp.rh9.com/swf/" & champ.Text & "/login.swf",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\login.swf")
            My.Computer.Network.DownloadFile(
    "http://lollsp.rh9.com/swf/" & champ.Text & "/LoginScreenIntro.mp3",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\loginScreenIntro.mp3")
            My.Computer.Network.DownloadFile(
    "http://lollsp.rh9.com/swf/" & champ.Text & "/LoginScreenLoop.mp3",
    "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text & "\loginScreenLoop.mp3")
        End If

        ' Declarings!
        Dim LoginS As String = "C:\Riot Games\Titan_Bullet\SWF\" & champ.Text
        Dim themepath As String = "C:\Riot Games\League of Legends\RADS\projects\lol_air_client\releases\0.0.1.104\deploy\mod\lgn\themes\"
        Dim MusicPath As String = themepath & "LoginGnar\music"

        ' Deletes any previous Backup
    'Delete all files from the Directory
        For Each filepath As String In Directory.GetFiles(themepath & "loginGnar")
            File.Delete(filepath)
        Next
        For Each filepath As String In Directory.GetFiles(MusicPath)
            File.Delete(filepath)
        Next
        'Delete a Directory
        Directory.Delete(MusicPath)
        Directory.Delete(themepath & "loginGnar")
        IO.Directory.CreateDirectory(themepath & "LoginGnar")
        IO.Directory.CreateDirectory(MusicPath)
        
        My.Computer.FileSystem.CopyFile(LoginS & "\login.swf",
    themepath & "LoginGnar\cs_bg_champions.png",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        My.Computer.FileSystem.CopyFile(LoginS & "\LoginScreenLoop.mp3",
    themepath & "LoginGnar\music\LoginScreenLoop.mp3",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        My.Computer.FileSystem.CopyFile(LoginS & "\LoginScreenIntro.mp3",
    themepath & "LoginGnar\music\LoginScreenintro.mp3",
    FileIO.UIOption.OnlyErrorDialogs,
    FileIO.UICancelOption.ThrowException)
        MsgBox("Enjoy! lolLSP will now close.")
        Me.Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("I am just a 14 year old wannabe programmer who likes to help. Nothing more! I live in greece with plans to move in New york. You can contact me through reddit (/u/titan_bullet) or email (titanbullet12@gmail.com)")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Custom login screens are still in beta. CL creators,pls PM titan_bullet on reddit,with the login screen you have made and proof that you actually made it,along with a zip containing the login.swf,loginscreenintro.mp3 and loginscreenloop.mp3 and i will make it available here (with the proper credits of course.)")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        donations.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class