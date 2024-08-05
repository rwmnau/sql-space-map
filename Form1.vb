Imports Microsoft.Research.CommunityTechnologies
Imports System.Data.SqlClient

Public Class Form1

    Dim DBTablesDictionary As New Dictionary(Of String, DatabaseTable)
    Dim ConnectionString As String


    Private Sub BuildTreemap(ByVal tmcMap As Treemap.TreemapControl)

        tmcMap.Clear()

        For Each table In DBTablesDictionary.Values

            Dim CurrentTableData As Integer = table.DataSize

            Dim TableNode As New Treemap.Node(table.Name, table.TotalSize, 75)

            Dim DataNode As Treemap.Node = TableNode.Nodes.Add("Data", table.DataSize, 50)
            DataNode.ToolTip = String.Concat(CurrentTableData, " KB")

            Dim indexnode As New Treemap.Node("Indexes", table.IndexSize, 50)

            For Each i As IndexDetails In table.Indexes.Values

                Dim Index As New Treemap.Node(i.Name, i.Size, 25)
                'Index.ToolTip = String.Concat(Rows.Item(CurrentRow).Item("UsedKB"), " KB")
                IndexNode.Nodes.Add(Index)
            Next

            If table.Indexes.Count > 0 Then
                TableNode.Nodes.Add(indexnode)
            End If

            tmcMap.Nodes.Add(TableNode)

        Next

        ' Draw it
        Me.tmc1.Refresh()

    End Sub

    Private Sub RefreshDatabaseView()

        Dim sc As New SqlConnection(ConnectionString)
        sc.Open()

        Dim sql As New SqlCommand("select object_name(t.id) as TableName, t.id, t.dpages*8 as Pages  from sysindexes t  join sysobjects so    on t.id = so.id        where(t.id > 100)    and indid in (0,1)    and so.type = 'U' order by object_name(t.id);", sc)
        sql.CommandTimeout = 0
        sql.CommandType = CommandType.Text

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql)

        da.Fill(ds)

        Me.DBTablesDictionary.Clear()

        For Each dr As DataRow In ds.Tables(0).Rows

            Me.DBTablesDictionary.Add(dr.Item("TableName"), New DatabaseTable(dr.Item("TableName"), dr.Item("Pages")))

            Dim sql2 As New SqlCommand("select name, dpages*8 as Pages from sysindexes    where(id = @ID) and FirstIAM is not null  and indid not in (0,1)", sc)
            sql2.Parameters.AddWithValue("@ID", dr.Item("id"))

            Dim ds2 As New DataSet
            Dim da2 As New SqlDataAdapter(sql2)

            da2.Fill(ds2)

            For Each dr2 As DataRow In ds2.Tables(0).Rows
                Me.DBTablesDictionary.Item(dr.Item("TableName")).Indexes.Add(dr2.Item("name"), New IndexDetails(dr2.Item("name"), dr2.Item("pages")))
            Next
        Next

        BuildTreemap(tmc1)


    End Sub


    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        Using f As New DBLogin
            f.ShowDialog()
            ConnectionString = f.ConnectionString
        End Using

        If ConnectionString <> String.Empty Then
            RefreshDatabaseView()
        End If

    End Sub
End Class
