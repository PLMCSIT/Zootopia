Namespace TokenLibrary
    Public Class TokenClass
        Dim lines As Integer
        Dim tokens As String
        Dim lexemes As String
        Dim attributes As String

        Sub setTokens(ByVal token As String)
            Me.tokens = token
        End Sub

        Sub setLexemes(ByVal lexemes As String)
            Me.lexemes = lexemes
        End Sub
        Sub setLines(ByVal lines As Integer)
            Me.lines = lines
        End Sub
        Sub setAttributes(ByVal attributes As String)
            Me.attributes = attributes
        End Sub

        Function getTokens() As String
            Return Me.tokens
        End Function
        Function getLexemes() As String
            Return Me.lexemes
        End Function
        Function getLines() As Integer
            Return Me.lines
        End Function
        Function getAttributes() As String
            Return Me.attributes
        End Function


    End Class
End Namespace
