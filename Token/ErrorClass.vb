Namespace TokenLibrary

    Public Class ErrorClass
        Dim lines As Integer
        Dim column As Integer
        Dim type As String
        Dim ErrorMessage As String

        Public Sub setErrorMessage(ErrorMessage)
            Me.ErrorMessage = ErrorMessage
        End Sub
        Public Function getErrorMessage() As String
            Return Me.ErrorMessage
        End Function
        Public Sub setLines(line)

            Me.lines = line
        End Sub
        Public Function getLines()
            Return Me.lines
        End Function
        Public Sub setColumn(column)
            Me.column = column
        End Sub
        Public Function getColumn() As String

            Return Me.column

        End Function
        Public Sub setType(type)

            Me.type = type
        End Sub
        Public Function gitType() As String
            Return Me.type
        End Function
    End Class

End Namespace