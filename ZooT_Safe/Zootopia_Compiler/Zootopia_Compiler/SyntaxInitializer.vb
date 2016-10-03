Imports System
Imports System.IO
Imports PerCederberg.Grammatica.Runtime

Public Class SyntaxInitializer

    Public Class Tokens
        Dim line As Integer
        Dim token As String
        Dim lexeme As String
        Dim attribute As String
        Public Sub setLine(ByVal line As Integer)
            Me.line = line
        End Sub
        Public Sub setToken(ByVal token As String)
            Me.token = token
        End Sub
        Public Sub setLexeme(ByVal lexeme As String)
            Me.lexeme = lexeme
        End Sub
        Public Sub setAttrib(ByVal attribute As String)
            Me.attribute = attribute
        End Sub
        Public Function getLine() As Integer
            Return Me.line
        End Function
        Public Function getToken() As String
            Return Me.token
        End Function
        Public Function getLexeme() As String
            Return Me.lexeme
        End Function
        Public Function getAttrib() As String
            Return Me.attribute
        End Function
    End Class

    Public Function Start(ByVal tokens As List(Of Tokens)) As String
        Dim tokenstream = ""
        Dim result As String
        Dim line As Integer = 1
        For Each t In tokens
            If (t.getLine <> line) Then
                line = t.getLine

                tokenstream += vbCrLf + t.getToken + " "
            Else
                tokenstream += t.getToken + " "
            End If
        Next

        tokenstream = tokenstream.TrimEnd()

        Dim p As Parser
        p = CreateParser(tokenstream)

        Try
            p.Parse()
            result = "Syntax Analyzer Run Successfully"
        Catch e As ParserCreationException

            result = e.Message

        Catch e As ParserLogException
            result = e.Message

        End Try

        Return result
    End Function

    Private Function CreateParser(ByVal input As String) As Parser
        Dim parser As Parser

        Try
            parser = New SyntaxParser(New StringReader(input))
            parser.Prepare()

        Catch e As ParserCreationException
            Fail(e.Message)

        End Try

        Return parser
    End Function

    Protected Sub Fail(ByVal message As String)
        If (message = "parsing succeeded") Then
            Throw New Exception(message)
        End If
    End Sub

End Class