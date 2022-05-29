Imports System.Text
Public Class Form1
    Dim str As String

    Private Const UpperCaseKeys As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Const LowerCaseKeys As String = "abcdefghijklmnopqrstuvwxyz"
    Private Function genMask(ByVal Mask As String) As String
        Dim Output As New StringBuilder
        Dim Random As New Random()
        For C As Integer = 0 To Mask.Length - 1
            If (Mask(C) = "@") Then
                Output.Append(Random.Next(0, 9))
            ElseIf (Mask(C) = "$") Then
                Output.Append(UpperCaseKeys(Random.Next(0, UpperCaseKeys.Length())))
            ElseIf (Mask(C) = "#") Then
                Output.Append(LowerCaseKeys(Random.Next(0, LowerCaseKeys.Length())))
            Else
                Output.Append(Mask(C))
            End If
        Next
        Return Output.ToString
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = genMask("@##$-$#$#-$##$-@#$#")
        TextBox1.Text = str
    End Sub

    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.did_you_love_me, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("keygen by cvrsed" & vbCrLf & "music by dj floppar" & vbCrLf & "art from white clarity" & vbCrLf & "^_____^", "hi!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://cvrsed.neocities.org/")

    End Sub
End Class
