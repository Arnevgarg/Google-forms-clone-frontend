<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHub = New Label()
        lblStopwatch = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(195, 82)
        txtName.Name = "txtName"
        txtName.Size = New Size(196, 27)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(195, 134)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(196, 27)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(195, 194)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(196, 27)
        txtPhone.TabIndex = 3
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(195, 245)
        txtGithub.Multiline = True
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(196, 46)
        txtGithub.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 20)
        Label1.TabIndex = 5
        Label1.Text = "Arnev Garg, Slidely Task 2 - Create Submission"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(78, 85)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 6
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(78, 137)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(78, 197)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 8
        lblPhone.Text = "Phone"
        ' 
        ' lblGitHub
        ' 
        lblGitHub.Location = New Point(78, 248)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(87, 43)
        lblGitHub.TabIndex = 9
        lblGitHub.Text = "GitHub Link For Task 2"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(328, 322)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(78, 318)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(224, 29)
        btnToggleStopwatch.TabIndex = 11
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(119, 375)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(227, 29)
        btnSubmit.TabIndex = 12
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(481, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHub As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
End Class
