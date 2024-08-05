Public Class DatabaseTable

    Public Sub New(ByVal NewName As String, ByVal NewSize As Integer)
        MyBase.New()

        Name = NewName
        DataSize = NewSize

    End Sub

    Public Name As String
    Public DataSize As Integer

    Public ReadOnly Property TotalSize As Integer
        Get
            Return DataSize + IndexSize
        End Get
    End Property

    Public ReadOnly Property IndexSize As Integer
        Get
            Dim size As Integer
            For Each i As IndexDetails In Indexes.Values
                size += i.Size
            Next

            Return size

        End Get
    End Property

    Public Indexes As New Dictionary(Of String, IndexDetails)

End Class

Public Class IndexDetails
    Public Name As String
    Public Size As Integer

    Public Sub New(ByVal NewName As String, ByVal NewSize As Integer)
        MyBase.New()

        Name = NewName
        Size = NewSize

    End Sub

End Class
