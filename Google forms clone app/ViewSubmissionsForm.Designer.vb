<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnNext = New Button()
        btnPrevious = New Button()
        lblGitHub = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblName = New Label()
        Label1 = New Label()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label2 = New Label()
        txtStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(224, 398)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(199, 29)
        btnNext.TabIndex = 24
        btnNext.Text = "NEXT (CTRL + O)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(36, 398)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(160, 29)
        btnPrevious.TabIndex = 23
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' lblGitHub
        ' 
        lblGitHub.Location = New Point(68, 256)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(87, 43)
        lblGitHub.TabIndex = 21
        lblGitHub.Text = "GitHub Link For Task 2"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(68, 205)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 20
        lblPhone.Text = "Phone"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(68, 145)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 19
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(68, 93)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 18
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 20)
        Label1.TabIndex = 17
        Label1.Text = "Arnev Garg, Slidely Task 2 - View Submissions"
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(185, 253)
        txtGithub.Multiline = True
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(196, 46)
        txtGithub.TabIndex = 16
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(185, 202)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(196, 27)
        txtPhone.TabIndex = 15
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(185, 142)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(196, 27)
        txtEmail.TabIndex = 14
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(185, 90)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(196, 27)
        txtName.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(68, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 40)
        Label2.TabIndex = 26
        Label2.Text = "Stopwatch time"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(185, 329)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(196, 27)
        txtStopwatch.TabIndex = 25
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 450)
        Controls.Add(Label2)
        Controls.Add(txtStopwatch)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblGitHub As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStopwatch As TextBox
End Class
