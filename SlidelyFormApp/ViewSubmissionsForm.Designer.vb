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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        Label6 = New Label()
        txtStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSearch = New Button()
        txtSearchEmail = New TextBox()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(249, 15)
        Label5.TabIndex = 16
        Label5.Text = "Yash Nigam, Slidely Task 2 - View Submissions"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 30)
        Label4.TabIndex = 15
        Label4.Text = "GitHub Link" & vbCrLf & "For Task 2"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 14
        Label3.Text = "Phone Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 13
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 12
        Label1.Text = "Name"
        ' 
        ' txtGithub
        ' 
        txtGithub.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtGithub.BorderStyle = BorderStyle.FixedSingle
        txtGithub.Location = New Point(100, 265)
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(262, 23)
        txtGithub.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(100, 220)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(262, 23)
        txtPhone.TabIndex = 10
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(100, 136)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(262, 23)
        txtName.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(100, 177)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(262, 23)
        txtEmail.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 30)
        Label6.TabIndex = 17
        Label6.Text = "Stopwatch" & vbCrLf & "Time"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = Color.FromArgb(CByte(233), CByte(237), CByte(238))
        txtStopwatch.BorderStyle = BorderStyle.FixedSingle
        txtStopwatch.Location = New Point(100, 310)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(262, 23)
        txtStopwatch.TabIndex = 18
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(237), CByte(152))
        btnPrevious.FlatAppearance.BorderSize = 2
        btnPrevious.FlatStyle = FlatStyle.Popup
        btnPrevious.Location = New Point(14, 367)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(158, 31)
        btnPrevious.TabIndex = 19
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnNext.FlatAppearance.BorderSize = 2
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.Location = New Point(198, 367)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(158, 31)
        btnNext.TabIndex = 20
        btnNext.Text = "NEXT(CTRL +N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(240), CByte(71), CByte(60))
        btnDelete.FlatAppearance.BorderSize = 2
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Location = New Point(13, 413)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(158, 31)
        btnDelete.TabIndex = 21
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(8), CByte(165), CByte(47))
        btnEdit.FlatAppearance.BorderSize = 2
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Location = New Point(198, 413)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(158, 31)
        btnEdit.TabIndex = 22
        btnEdit.Text = "EDIT(CTRL +E)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(33))
        btnSearch.FlatAppearance.BorderSize = 2
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.ForeColor = SystemColors.ButtonHighlight
        btnSearch.Location = New Point(12, 53)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(136, 31)
        btnSearch.TabIndex = 23
        btnSearch.Text = "SEARCH (CTRL +M)"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearchEmail
        ' 
        txtSearchEmail.BackColor = Color.White
        txtSearchEmail.BorderStyle = BorderStyle.FixedSingle
        txtSearchEmail.Location = New Point(12, 90)
        txtSearchEmail.Name = "txtSearchEmail"
        txtSearchEmail.PlaceholderText = "Search By Email"
        txtSearchEmail.Size = New Size(190, 23)
        txtSearchEmail.TabIndex = 24
        txtSearchEmail.Tag = ""
        txtSearchEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(238), CByte(160), CByte(10))
        btnReset.FlatAppearance.BorderSize = 2
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.ForeColor = SystemColors.ButtonHighlight
        btnReset.Location = New Point(220, 84)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 31)
        btnReset.TabIndex = 25
        btnReset.Text = "RESET (CTRL + R)"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(375, 501)
        Controls.Add(btnReset)
        Controls.Add(txtSearchEmail)
        Controls.Add(btnSearch)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(Label6)
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
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents btnReset As Button
End Class
