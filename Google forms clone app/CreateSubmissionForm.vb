Imports Newtonsoft.Json
Imports System.Net

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        timer.Interval = 1000
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New With {
            .name = lblName.Text,
            .email = lblEmail.Text,
            .phone = lblPhone.Text,
            .github_link = txtGithub.Text,
            .stopwatch_time = lblStopwatch.Text
        }
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim client As New WebClient()
        client.Headers.Add(HttpRequestHeader.ContentType, "application/json")
        client.UploadString("http://localhost:3000/forms/submit", "POST", json)
        MessageBox.Show("Submission Successful")
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub lblGitHub_Click(sender As Object, e As EventArgs) Handles lblGitHub.Click

    End Sub
End Class