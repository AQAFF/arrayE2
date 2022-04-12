Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intBall As Integer
        Dim n As Integer
        Dim m As Integer
        Dim intBalls() As Integer = {0, 0, 0, 0, 0, 0}
        Dim same As Boolean
        Dim rand1 As New System.Random
        lblBalls.Text = ""
        'get numbers
        For n = 0 To 5
            Do
                same = False
                intBalls(n) = rand1.Next(49) + 1
                For m = 0 To (n - 1)
                    If (intBalls(n) = intBalls(m)) Then
                        same = True
                    End If
                Next m
            Loop Until same = False
        Next n
        'display results
        For n = 0 To 5
            intBall = intBalls(n)
            lblBalls.Text = lblBalls.Text & "  " & intBall
        Next n
    End Sub
End Class
