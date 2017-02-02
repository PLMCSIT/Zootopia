Imports System
Imports System.IO
Imports TokenLibrary.TokenLibrary
Imports Core.Library



Public Class SyntaxInitializer
    Inherits SyntaxAnalyzer

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


    Public production As String = ""
    Public recursiveprod As String = ""
    Dim currparent As Node
    Dim prevparent As New List(Of Node)()

    Public Overrides Sub Enter(ByVal node As Node)
        Dim name As String = node.GetName
        If (name.Contains("prod_")) Then

            node.SetParent(currparent)
            name = name.Substring(5)

            If (IsNothing(currparent) <> True) Then

                production += "Enter: <" + name + "> Parent: " + currparent.GetName() + vbNewLine

            Else

                production += "Enter: <" + name + vbNewLine

                prevparent.Add(currparent)
                currparent = node
            End If

        Else

            node.SetParent(currparent)
            production += "Enter: " + name + " Parent: " + currparent.GetName() + vbNewLine
        End If



    End Sub

    Public Overrides Function [Exit](ByVal node As Node) As Node
        If (currparent.Equals(node)) Then
            currparent = prevparent(prevparent.Count - 1)
            prevparent.RemoveAt(prevparent.Count - 1)
        End If
        Return node
    End Function

    Public errors As ErrorClass = New ErrorClass()
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
            Fail("Parsing succeeded")
            result = "Syntax Analyzer Run Successfully"
        Catch e As ParserCreationException
            Fail(e.Message)
            result = e.Message

        Catch e As ParserLogException
            Dim Message As String = "Expected: "
            errors.setColumn(e.GetError(0).Column)
            errors.setLines(e.GetError(0).Line)
            If (p.GetLastProductionState() = "NULL") Then

                Dim ps As New PredictSet()
                Dim code = p.GetLastProductionCode()
                Message += ps.GetPredictSet(code)

            Else
                For Each item As String In e.GetError(0).Details
                    Message += item + ", "
                Next
            End If
            Message += "on line: " + errors.getLines().ToString() + "."
            result = Message
        End Try
        recursiveprod = p.GetRecursiveProduction()
        Return result
    End Function

    Private Function CreateParser(ByVal input As String) As Parser
        Dim parser As Parser

        Try
            parser = New SyntaxParser(New StringReader(input), Me)
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