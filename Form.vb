Public Class Form

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click

        MsgBox("Helo World")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stFName As String
        Dim stLName As String

        stFName = "Carlos"
        stLName = "Cruz"

        MsgBox("Hi " & stFName & " " & stLName & " Welcome back")

    End Sub

End Class
