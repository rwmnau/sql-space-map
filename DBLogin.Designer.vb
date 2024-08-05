<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtServername = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.rbWindowsAuth = New System.Windows.Forms.RadioButton()
        Me.rbSQLAuth = New System.Windows.Forms.RadioButton()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cboDatabases = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Enabled = False
        Me.lblPassword.Location = New System.Drawing.Point(28, 118)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'txtServername
        '
        Me.txtServername.Location = New System.Drawing.Point(90, 17)
        Me.txtServername.Name = "txtServername"
        Me.txtServername.Size = New System.Drawing.Size(160, 20)
        Me.txtServername.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(90, 89)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(160, 20)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(90, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(160, 20)
        Me.txtPassword.TabIndex = 4
        '
        'rbWindowsAuth
        '
        Me.rbWindowsAuth.AutoSize = True
        Me.rbWindowsAuth.Checked = True
        Me.rbWindowsAuth.Location = New System.Drawing.Point(17, 43)
        Me.rbWindowsAuth.Name = "rbWindowsAuth"
        Me.rbWindowsAuth.Size = New System.Drawing.Size(140, 17)
        Me.rbWindowsAuth.TabIndex = 5
        Me.rbWindowsAuth.TabStop = True
        Me.rbWindowsAuth.Text = "Windows Authentication"
        Me.rbWindowsAuth.UseVisualStyleBackColor = True
        '
        'rbSQLAuth
        '
        Me.rbSQLAuth.AutoSize = True
        Me.rbSQLAuth.Location = New System.Drawing.Point(17, 66)
        Me.rbSQLAuth.Name = "rbSQLAuth"
        Me.rbSQLAuth.Size = New System.Drawing.Size(151, 17)
        Me.rbSQLAuth.TabIndex = 6
        Me.rbSQLAuth.Text = "SQL Server Authentication"
        Me.rbSQLAuth.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Enabled = False
        Me.lblUsername.Location = New System.Drawing.Point(28, 92)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 13)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "User name:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Location = New System.Drawing.Point(9, 222)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdAccept
        '
        Me.cmdAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAccept.Location = New System.Drawing.Point(197, 222)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(75, 23)
        Me.cmdAccept.TabIndex = 9
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'cboDatabases
        '
        Me.cboDatabases.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDatabases.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDatabases.FormattingEnabled = True
        Me.cboDatabases.Location = New System.Drawing.Point(90, 171)
        Me.cboDatabases.Name = "cboDatabases"
        Me.cboDatabases.Size = New System.Drawing.Size(160, 21)
        Me.cboDatabases.Sorted = True
        Me.cboDatabases.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Database:"
        '
        'DBLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 257)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDatabases)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.rbSQLAuth)
        Me.Controls.Add(Me.rbWindowsAuth)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtServername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DBLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Connect to database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtServername As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents rbWindowsAuth As System.Windows.Forms.RadioButton
    Friend WithEvents rbSQLAuth As System.Windows.Forms.RadioButton
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cboDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
