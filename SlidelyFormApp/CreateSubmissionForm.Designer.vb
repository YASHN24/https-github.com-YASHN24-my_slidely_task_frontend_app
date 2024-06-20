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
        components = New ComponentModel.Container()
        txtEmail = New TextBox()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnStopwatch = New Button()
        btnSubmit = New Button()
        timerStopwatch = New Timer(components)
        txtStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(100, 113)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(262, 23)
        txtEmail.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(101, 72)
        txtName.Name = "txtName"
        txtName.Size = New Size(262, 23)
        txtName.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(100, 156)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(262, 23)
        txtPhone.TabIndex = 1
        ' 
        ' txtGithub
        ' 
        txtGithub.BorderStyle = BorderStyle.FixedSingle
        txtGithub.Location = New Point(100, 201)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(262, 23)
        txtGithub.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 4
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 5
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 30)
        Label4.TabIndex = 6
        Label4.Text = "GitHub Link" & vbCrLf & "For Task 2"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(253, 15)
        Label5.TabIndex = 7
        Label5.Text = "Yash Nigam, Slidely Task 2 - Create Submission"
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(237), CByte(152))
        btnStopwatch.FlatStyle = FlatStyle.Popup
        btnStopwatch.Location = New Point(12, 254)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(196, 31)
        btnStopwatch.TabIndex = 8
        btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T )"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Location = New Point(26, 318)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(336, 37)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' timerStopwatch
        ' 
        timerStopwatch.Interval = 1000
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtStopwatch.BorderStyle = BorderStyle.FixedSingle
        txtStopwatch.Location = New Point(230, 258)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(132, 23)
        txtStopwatch.TabIndex = 11
        txtStopwatch.Text = "00:00:00"
        txtStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(375, 390)
        Controls.Add(txtStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents txtStopwatch As TextBox
End Class
