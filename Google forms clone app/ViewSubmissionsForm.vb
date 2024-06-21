Imports Newtonsoft.Json
Imports System.Net

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmissions()
        DisplaySubmission(0)
    End Sub

    Private Sub LoadSubmissions()
        Dim client As New WebClient()
        Dim json As String = client.DownloadString("http://localhost:3000/forms/read")
        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            currentIndex = index
            txtName.Text = submissions(index).name
            txtEmail.Text = submissions(index).email
            txtPhone.Text = submissions(index).phone
            txtGitHub.Text = submissions(index).github_link
            txtStopwatch.Text = submissions(index).stopwatch_time
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            DisplaySubmission(currentIndex - 1)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            DisplaySubmission(currentIndex + 1)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.O Then
            btnNext.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class