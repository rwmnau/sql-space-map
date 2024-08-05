Imports System.Text
Imports System.Data.SqlClient

Public Class DBLogin

    Public ConnectionString As String
    Public Database As String

    Private Sub DatabaseAuthMethod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles rbSQLAuth.CheckedChanged, rbWindowsAuth.CheckedChanged

        Me.lblUsername.Enabled = Me.rbSQLAuth.Checked
        Me.lblPassword.Enabled = Me.rbSQLAuth.Checked
        Me.txtUsername.Enabled = Me.rbSQLAuth.Checked
        Me.txtPassword.Enabled = Me.rbSQLAuth.Checked
        Me.cboDatabases.Text = ""
        Me.cboDatabases.Items.Clear()

    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click

        If VerifyConnectionString() Then
            ConnectionString = BuildConnectionString()
            Me.Close()
        End If

    End Sub

    Private Sub txtServername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServername.TextChanged
        ClearDatabaseList()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        ClearDatabaseList()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        ClearDatabaseList()
    End Sub

    Private Sub ClearDatabaseList()

        If Me.cboDatabases.Text <> String.Empty Then
            Me.cboDatabases.Text = String.Empty
        End If

        If Me.cboDatabases.Items.Count > 0 Then
            Me.cboDatabases.Items.Clear()
        End If

    End Sub

    Private Function BuildConnectionString() As String

        BuildConnectionString = String.Empty

        If Me.txtServername.Text.Trim = String.Empty Then
            MessageBox.Show("Please enter a server name", "Validation", MessageBoxButtons.OK)
            Me.txtServername.Focus()
            Return String.Empty
        End If

        If Me.rbSQLAuth.Checked And Me.txtUsername.Text.Trim = String.Empty Then
            MessageBox.Show("Enter a username or change to Windows Authentication", "Error", MessageBoxButtons.OK)
            Me.txtUsername.Focus()
            Return String.Empty
        End If

        'If Me.cboDatabases.Text.Trim = String.Empty Then
        '    MessageBox.Show("Please select a database from the dropdown", "Error", MessageBoxButtons.OK)
        '    Me.cboDatabases.Focus()
        '    Return String.Empty
        'End If

        Dim CS As New StringBuilder
        CS.Append(String.Concat("Data Source=", Me.txtServername.Text, ";"))
        If Me.rbWindowsAuth.Checked Then
            CS.Append("Trusted_Connection=True;")
        Else
            CS.Append(String.Concat("User Id=", Me.txtUsername.Text, ";Password=", Me.txtPassword.Text, ";"))
        End If
        CS.Append(String.Concat("Initial Catalog=", Me.cboDatabases.Text, ";"))

        BuildConnectionString = CS.ToString
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ConnectionString = String.Empty
        Me.Close()
    End Sub

    Private Sub cboDatabases_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDatabases.GotFocus
        RefreshDatabases()
    End Sub

    Private Sub RefreshDatabases()

        If Not VerifyConnectionString() Then
            Exit Sub
        End If

        If Me.cboDatabases.Items.Count > 0 Then
            Exit Sub
        End If


        Dim CS As String = BuildConnectionString()

        If CS <> String.Empty Then

            Dim sc As New SqlConnection(CS)
            Dim sql As New SqlCommand("select name from master.sys.databases", sc)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(sql)

            da.Fill(ds)

            Me.cboDatabases.Items.Clear()

            For Each dr As DataRow In ds.Tables(0).Rows
                If Not Me.cboDatabases.Items.Contains(dr.Item(0)) Then
                    Me.cboDatabases.Items.Add(dr.Item(0))
                End If
            Next

            Me.cboDatabases.Text = Me.cboDatabases.Items(0)

        End If

    End Sub

    Private Function VerifyConnectionString() As Boolean

        Dim CS As String = BuildConnectionString
        If CS = String.Empty Then Return False

        Try
            Dim c As New SqlClient.SqlConnection(CS.ToString)
            c.Open()

            Return True

        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function


    Private Sub DBLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class