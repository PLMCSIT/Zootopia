Imports System.IO

Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic

Imports PerCederberg.Grammatica.Runtime

Public Class Form1
    Public objList As ListViewItem
    Dim tokee(20000) As String '3
    Dim linee(20000) As String '1
    Dim setokee(20000) As String '3
    Dim selinee(20000) As String '1
    Dim isbody As Boolean = False
    Dim ismane As Boolean = False
    'Dim errorCtr As Integer = 0

    Dim tokenstream As New List(Of Tokens)
    Dim brccount As Integer
    Dim paracount As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
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

    Private Sub lexinew()
        tokenstream.Clear()
        Dim tokens As New Tokens
        dGridLexi.Items.Clear()
        dGridError.Items.Clear()
        dGridSemantic.Items.Clear()
        Dim sourcecode As String = rTBCode.Text + " "
        Dim sc() As Char = sourcecode.ToCharArray()
        Dim i As Integer = 0
        Dim line As Integer = 1

        Dim errorCtr As Integer = 0
        Dim symbolCtr As Integer = 0
        Dim idCtr As Integer = 0
        Dim idnum As Integer = 1

        Dim delimStr As String = "Invalid lexeme "
        Dim id As String = ""
        Dim identifier As String = ""
        Dim str As String = ""
        Dim comment As String = ""
        Dim num As String = ""

        Dim delimsymbol(95) As String
        delimsymbol(0) = "`"
        delimsymbol(1) = "~"
        delimsymbol(2) = "1"
        delimsymbol(3) = "!"
        delimsymbol(4) = "2"
        delimsymbol(5) = "@"
        delimsymbol(6) = "3"
        delimsymbol(7) = "#"
        delimsymbol(8) = "4"
        delimsymbol(9) = "$"
        delimsymbol(10) = "5"
        delimsymbol(11) = "%"
        delimsymbol(12) = "6"
        delimsymbol(13) = "^"
        delimsymbol(14) = "7"
        delimsymbol(15) = "&"
        delimsymbol(16) = "8"
        delimsymbol(17) = "*"
        delimsymbol(18) = "9"
        delimsymbol(19) = "("
        delimsymbol(20) = "0"
        delimsymbol(21) = ")"
        delimsymbol(22) = "-"
        delimsymbol(23) = "_"
        delimsymbol(24) = "="
        delimsymbol(25) = "+"
        delimsymbol(26) = "\"
        delimsymbol(27) = "|"
        delimsymbol(28) = "]"
        delimsymbol(29) = "}"
        delimsymbol(30) = "["
        delimsymbol(31) = "{"
        delimsymbol(32) = "'"
        delimsymbol(33) = """"
        delimsymbol(34) = ";"
        delimsymbol(35) = ":"
        delimsymbol(36) = "/"
        delimsymbol(37) = "?"
        delimsymbol(38) = "."
        delimsymbol(39) = ">"
        delimsymbol(40) = ","
        delimsymbol(41) = "<"
        delimsymbol(42) = " "
        delimsymbol(43) = "q"
        delimsymbol(44) = "w"
        delimsymbol(45) = "e"
        delimsymbol(46) = "r"
        delimsymbol(47) = "t"
        delimsymbol(48) = "y"
        delimsymbol(49) = "u"
        delimsymbol(50) = "i"
        delimsymbol(51) = "o"
        delimsymbol(52) = "p"
        delimsymbol(53) = "a"
        delimsymbol(54) = "s"
        delimsymbol(55) = "d"
        delimsymbol(56) = "f"
        delimsymbol(57) = "g"
        delimsymbol(58) = "h"
        delimsymbol(59) = "j"
        delimsymbol(60) = "k"
        delimsymbol(61) = "l"
        delimsymbol(62) = "z"
        delimsymbol(63) = "x"
        delimsymbol(64) = "c"
        delimsymbol(65) = "v"
        delimsymbol(66) = "b"
        delimsymbol(67) = "n"
        delimsymbol(68) = "m"
        delimsymbol(69) = "Q"
        delimsymbol(70) = "W"
        delimsymbol(71) = "E"
        delimsymbol(72) = "R"
        delimsymbol(73) = "T"
        delimsymbol(74) = "Y"
        delimsymbol(75) = "U"
        delimsymbol(76) = "I"
        delimsymbol(77) = "O"
        delimsymbol(78) = "P"
        delimsymbol(79) = "A"
        delimsymbol(80) = "S"
        delimsymbol(81) = "D"
        delimsymbol(82) = "F"
        delimsymbol(83) = "G"
        delimsymbol(84) = "H"
        delimsymbol(85) = "J"
        delimsymbol(86) = "K"
        delimsymbol(87) = "L"
        delimsymbol(88) = "Z"
        delimsymbol(89) = "X"
        delimsymbol(90) = "C"
        delimsymbol(91) = "V"
        delimsymbol(92) = "B"
        delimsymbol(93) = "N"
        delimsymbol(94) = "M"


        Dim neg As Boolean = False
        While i < sourcecode.Length
            Dim read As Boolean = False
            If sc(i) = "a" Then
                If sc(i + 1) = "t" Then
                    If sc(i + 2) = " " Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("at")
                        tokens.setLexeme("at")
                        tokens.setAttrib("at")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("at")
                        objList.SubItems.Add("at")
                        objList.SubItems.Add(" ")
                        read = True
                        i += 1
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'at'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'a'")
                    read = True
                End If


            ElseIf sc(i) = "b" Then
                If sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "l" Then
                        If sc(i + 1) = "u" And sc(i + 2) = "l" And sc(i + 3) = "l" Then
                            If sc(i + 4) = " " Or sc(i + 4) = "," Or sc(i + 4) = ")" Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("bull")
                                tokens.setLexeme("bull")
                                tokens.setAttrib("data type")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("bull")
                                objList.SubItems.Add("bull")
                                objList.SubItems.Add("bull")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList.SubItems.Add(line)
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(delimStr & "'bull'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'bul'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'bu'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'b'")
                    read = True
                End If

            ElseIf sc(i) = "c" Then
                If sc(i + 1) = "h" Then
                    If sc(i + 1) = "h" And sc(i + 2) = "a" Then
                        If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "m" Then
                            If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "m" And sc(i + 4) = "o" Then
                                If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "m" And sc(i + 4) = "o" And sc(i + 5) = "i" Then
                                    If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "m" And sc(i + 4) = "o" And sc(i + 5) = "i" And sc(i + 6) = "s" Then
                                        If sc(i + 7) = " " Then
                                            symbolCtr += 1
                                            tokens = New Tokens
                                            tokens.setToken("chamois")
                                            tokens.setLexeme("chamois")
                                            tokens.setAttrib("chamois")
                                            tokens.setLine(line)
                                            tokenstream.Add(tokens)
                                            objList = dGridLexi.Items.Add(symbolCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add("chamois")
                                            objList.SubItems.Add("chamois")
                                            objList.SubItems.Add("chamois")
                                            read = True
                                            i += 6
                                        Else
                                            errorCtr += 1
                                            objList = dGridError.Items.Add(errorCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add(delimStr & "'chamois'")
                                            read = True
                                            i += 6
                                        End If
                                    Else
                                        errorCtr += 1
                                        objList = dGridError.Items.Add(errorCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add(delimStr & "'chamoi'")
                                        read = True
                                        i += 5
                                    End If
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'chamo'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'cham'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'cha'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ch'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'c'")
                    read = True
                End If
            ElseIf sc(i) = "d" Then
                If sc(i + 1) = "o" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "<" Or sc(i + 2) = "'" Or sc(i + 2) = "newline" Or Not inArray(sc(i + 2), delimsymbol, 95) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("do")
                        tokens.setLexeme("do")
                        tokens.setAttrib("do")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("do")
                        objList.SubItems.Add("do")
                        objList.SubItems.Add("do")
                        read = True
                        i += 1
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'do'")
                        read = True
                        i += 1
                    End If
                ElseIf sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "c" Then
                        If sc(i + 1) = "u" And sc(i + 2) = "c" And sc(i + 3) = "k" Then
                            If sc(i + 4) = " " Or Not inArray(sc(i + 4), delimsymbol, 95) Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("duck")
                                tokens.setLexeme("duck")
                                tokens.setAttrib("data type")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("duck")
                                objList.SubItems.Add("duck")
                                objList.SubItems.Add("data type")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'duck'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'duc'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'du'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'d'")
                    read = True
                End If

            ElseIf sc(i) = "e" Then
                If sc(i + 1) = "e" Then
                    If sc(i + 1) = "e" And sc(i + 2) = "l" Then
                        If sc(i + 1) = "e" And sc(i + 2) = "l" And sc(i + 3) = "s" Then
                            If sc(i + 1) = "e" And sc(i + 2) = "l" And sc(i + 3) = "s" And sc(i + 4) = "i" Then
                                If sc(i + 1) = "e" And sc(i + 2) = "l" And sc(i + 3) = "s" And sc(i + 4) = "i" And sc(i + 5) = "f" Then
                                    If sc(i + 6) = "(" Then
                                        symbolCtr += 1
                                        tokens = New Tokens
                                        tokens.setToken("eelsif")
                                        tokens.setLexeme("eelsif")
                                        tokens.setAttrib("eelsif")
                                        tokens.setLine(line)
                                        tokenstream.Add(tokens)
                                        objList = dGridLexi.Items.Add(symbolCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add("eelsif")
                                        objList.SubItems.Add("eelsif")
                                        objList.SubItems.Add("eelsif")
                                        read = True
                                        i += 5
                                    Else
                                        errorCtr += 1
                                        objList = dGridError.Items.Add(errorCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add(delimStr & "'eelsif'")
                                        read = True
                                        i += 5
                                    End If
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'eelsi'")
                                    read = True
                                    i += 4
                                End If
                            ElseIf sc(i + 1) = "e" And sc(i + 2) = "l" And sc(i + 3) = "s" _
                             And (sc(i + 4) = " " Or sc(i + 4) = "'" Or sc(i + 4) = "(" Or sc(i + 4) = "newline" Or Not inArray(sc(i + 4), delimsymbol, 95)) Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("eels")
                                tokens.setLexeme("eels")
                                tokens.setAttrib("eels")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("eels")
                                objList.SubItems.Add("eels")
                                objList.SubItems.Add("eels")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'eels'")
                                read = True
                                i += 3
                            End If

                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'eel'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ee'")
                        read = True
                        i += 1
                    End If
                ElseIf sc(i + 1) = "n" Then
                    If sc(i + 1) = "n" And sc(i + 2) = "t" Then
                        If sc(i + 1) = "n" And sc(i + 2) = "t" And sc(i + 3) = "r" Then
                            If sc(i + 1) = "n" And sc(i + 2) = "t" And sc(i + 3) = "r" And sc(i + 4) = "a" Then
                                If sc(i + 1) = "n" And sc(i + 2) = "t" And sc(i + 3) = "r" And sc(i + 4) = "a" And sc(i + 5) = "n" Then
                                    If sc(i + 1) = "n" And sc(i + 2) = "t" And sc(i + 3) = "r" And sc(i + 4) = "a" And sc(i + 5) = "n" And sc(i + 6) = "c" Then
                                        If sc(i + 1) = "n" And sc(i + 2) = "t" And sc(i + 3) = "r" And sc(i + 4) = "a" And sc(i + 5) = "n" And sc(i + 6) = "c" And sc(i + 7) = "e" Then
                                            If sc(i + 8) = " " Or sc(i + 8) = "'" Or sc(i + 8) = "newline" Or Not inArray(sc(i + 8), delimsymbol, 95) Then
                                                symbolCtr += 1
                                                tokens = New Tokens
                                                tokens.setToken("entrance")
                                                tokens.setLexeme("entrance")
                                                tokens.setAttrib("entrance")
                                                tokens.setLine(line)
                                                tokenstream.Add(tokens)
                                                objList = dGridLexi.Items.Add(symbolCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add("entrance")
                                                objList.SubItems.Add("entrance")
                                                objList.SubItems.Add("entrance")
                                                read = True
                                                i += 7
                                            Else
                                                errorCtr += 1
                                                objList = dGridError.Items.Add(errorCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add(delimStr & "'entrance'")
                                                read = True
                                                i += 7
                                            End If
                                        Else
                                            errorCtr += 1
                                            objList = dGridError.Items.Add(errorCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add(delimStr & "'entranc'")
                                            read = True
                                            i += 6
                                        End If
                                    Else
                                        errorCtr += 1
                                        objList = dGridError.Items.Add(errorCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add(delimStr & "'entran'")
                                        read = True
                                        i += 5
                                    End If
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'entra'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'entr'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'ent'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'en'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "x" Then
                    If sc(i + 1) = "x" And sc(i + 2) = "i" Then
                        If sc(i + 1) = "x" And sc(i + 2) = "i" And sc(i + 3) = "t" Then
                            If sc(i + 4) = " " Or sc(i + 4) = "'" Or sc(i + 4) = "newline" Or Not inArray(sc(i + 4), delimsymbol, 95) Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("exit")
                                tokens.setLexeme("exit")
                                tokens.setAttrib("exit")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("exit")
                                objList.SubItems.Add("exit")
                                objList.SubItems.Add("exit")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'exit'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'exi'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ex'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'e'")
                    read = True
                End If


            ElseIf sc(i) = "f" Then
                If sc(i + 1) = "a" Then
                    If sc(i + 1) = "a" And sc(i + 2) = "l" Then
                        If sc(i + 1) = "a" And sc(i + 2) = "l" And sc(i + 3) = "s" Then
                            If sc(i + 1) = "a" And sc(i + 2) = "l" And sc(i + 3) = "s" And sc(i + 4) = "e" Then
                                If sc(i + 5) = " " Or sc(i + 5) = ":" Or sc(i + 5) = ")" Or sc(i + 5) = "," Or sc(i + 5) = "}" Or Not inArray(sc(i + 5), delimsymbol, 95) Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("false")
                                    tokens.setLexeme("bullLit")
                                    tokens.setAttrib("bullLit, false")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("false")
                                    objList.SubItems.Add("bullLit")
                                    objList.SubItems.Add("bullLit, false")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'false'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'fals'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'fal'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'fa'")
                        read = True
                        i += 1
                    End If


                ElseIf sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "r" Then
                        If sc(i + 3) = "(" Then
                            symbolCtr += 1
                            tokens = New Tokens
                            tokens.setToken("fur")
                            tokens.setLexeme("fur")
                            tokens.setAttrib("fur")
                            tokens.setLine(line)
                            tokenstream.Add(tokens)
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("fur")
                            objList.SubItems.Add("fur")
                            objList.SubItems.Add("fur")
                            read = True
                            i += 2
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'fur'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'fu'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'f'")
                    read = True
                End If

            ElseIf sc(i) = "h" Then
                If sc(i + 1) = "o" Then
                    If sc(i + 1) = "o" And sc(i + 2) = "p" Then
                        If sc(i + 3) = " " Then
                            symbolCtr += 1
                            tokens = New Tokens
                            tokens.setToken("hop")
                            tokens.setLexeme("hop")
                            tokens.setAttrib("hop")
                            tokens.setLine(line)
                            tokenstream.Add(tokens)
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("hop")
                            objList.SubItems.Add("hop")
                            objList.SubItems.Add("hop")
                            read = True
                            i += 2
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'hop'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ho'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'h'")
                    read = True
                End If

            ElseIf sc(i) = "i" Then
                If sc(i + 1) = "f" Then
                    If sc(i + 2) = "(" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("if")
                        tokens.setLexeme("if")
                        tokens.setAttrib("if")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("if")
                        objList.SubItems.Add("if")
                        objList.SubItems.Add("if")
                        read = True
                        i += 1
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(delimStr & "'if'")
                        objList.SubItems.Add(line)
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'i'")
                    read = True
                End If


            ElseIf sc(i) = "l" Then
                If sc(i + 1) = "e" Then
                    If sc(i + 1) = "e" And sc(i + 2) = "t" Then
                        If sc(i + 3) = " " Then
                            symbolCtr += 1
                            tokens = New Tokens
                            tokens.setToken("let")
                            tokens.setLexeme("let")
                            tokens.setAttrib("let")
                            tokens.setLine(line)
                            tokenstream.Add(tokens)
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("let")
                            objList.SubItems.Add("let")
                            objList.SubItems.Add("let")
                            read = True
                            i += 2
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'let'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'le'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'l'")
                    read = True
                End If
            ElseIf sc(i) = "m" Then
                If sc(i + 1) = "a" Then
                    If sc(i + 1) = "a" And sc(i + 2) = "n" Then
                        If sc(i + 1) = "a" And sc(i + 2) = "n" And sc(i + 3) = "e" Then
                            If sc(i + 4) = "(" Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("mane")
                                tokens.setLexeme("mane")
                                tokens.setAttrib("mane")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("mane")
                                objList.SubItems.Add("mane")
                                objList.SubItems.Add("mane")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'mane'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'man'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ma'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'m'")
                    read = True
                End If

            ElseIf sc(i) = "n" Then
                If sc(i + 1) = "e" Then
                    If sc(i + 1) = "e" And sc(i + 2) = "w" Then
                        If sc(i + 1) = "e" And sc(i + 2) = "w" And sc(i + 3) = "t" Then
                            If sc(i + 4) = " " Or sc(i + 4) = "," Or sc(i + 4) = ")" Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("newt")
                                tokens.setLexeme("newt")
                                tokens.setAttrib("data type")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("newt")
                                objList.SubItems.Add("newt")
                                objList.SubItems.Add("data type")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'newt'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'new'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'ne'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "l" Then
                        If sc(i + 1) = "u" And sc(i + 2) = "l" And sc(i + 3) = "l" Then
                            If sc(i + 4) = ")" Or sc(i + 4) = " " Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("")
                                tokens.setLexeme("")
                                tokens.setAttrib(" ")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("null")
                                objList.SubItems.Add("null")
                                objList.SubItems.Add(" ")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'null'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'nul'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'nu'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'n'")
                    read = True
                End If


            ElseIf sc(i) = "s" Then
                If sc(i + 1) = "t" Then
                    If sc(i + 1) = "t" And sc(i + 2) = "a" Then
                        If sc(i + 1) = "t" And sc(i + 2) = "a" And sc(i + 3) = "r" Then
                            If sc(i + 1) = "t" And sc(i + 2) = "a" And sc(i + 3) = "r" And sc(i + 4) = "l" Then
                                If sc(i + 1) = "t" And sc(i + 2) = "a" And sc(i + 3) = "r" And sc(i + 4) = "l" And sc(i + 5) = "i" Then
                                    If sc(i + 1) = "t" And sc(i + 2) = "a" And sc(i + 3) = "r" And sc(i + 4) = "l" And sc(i + 5) = "i" And sc(i + 6) = "n" Then
                                        If sc(i + 1) = "t" And sc(i + 2) = "a" And sc(i + 3) = "r" And sc(i + 4) = "l" And sc(i + 5) = "i" And sc(i + 6) = "n" And sc(i + 7) = "g" Then
                                            If sc(i + 8) = " " Or sc(i + 8) = "," Or sc(i + 8) = ")" Then
                                                symbolCtr += 1
                                                tokens = New Tokens
                                                tokens.setToken("starling")
                                                tokens.setLexeme("starling")
                                                tokens.setAttrib("data type")
                                                tokens.setLine(line)
                                                tokenstream.Add(tokens)
                                                objList = dGridLexi.Items.Add(symbolCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add("starling")
                                                objList.SubItems.Add("starling")
                                                objList.SubItems.Add("data type")
                                                read = True
                                                i += 7
                                            Else
                                                errorCtr += 1
                                                objList = dGridError.Items.Add(errorCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add(delimStr & "'starling'")
                                                read = True
                                                i += 7
                                            End If
                                        Else
                                            errorCtr += 1
                                            objList = dGridError.Items.Add(errorCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add(delimStr & "'starlin'")
                                            read = True
                                            i += 6
                                        End If
                                    Else
                                        errorCtr += 1
                                        objList = dGridError.Items.Add(errorCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add(delimStr & "'starli'")
                                        read = True
                                        i += 5
                                    End If
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'starl'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'star'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'sta'")
                            read = True
                            i += 2
                        End If


                    ElseIf sc(i + 1) = "t" And sc(i + 2) = "o" Then
                        If sc(i + 1) = "t" And sc(i + 2) = "o" And sc(i + 3) = "r" Then
                            If sc(i + 1) = "t" And sc(i + 2) = "o" And sc(i + 3) = "r" And sc(i + 4) = "k" Then
                                If sc(i + 5) = " " Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("stork")
                                    tokens.setLexeme("stork")
                                    tokens.setAttrib("stork")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("stork")
                                    objList.SubItems.Add("stork")
                                    objList.SubItems.Add("stork")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'stork'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'stor'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'sto'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'st'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "e" Then
                    If sc(i + 1) = "e" And sc(i + 2) = "a" Then
                        If sc(i + 1) = "e" And sc(i + 2) = "a" And sc(i + 3) = "l" Then
                            If sc(i + 4) = " " Or sc(i + 4) = ";" Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("seal")
                                tokens.setLexeme("seal")
                                tokens.setAttrib("seal")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("seal")
                                objList.SubItems.Add("seal")
                                objList.SubItems.Add("seal")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'seal'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'sea'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'se'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "w" Then
                    If sc(i + 1) = "w" And sc(i + 2) = "a" Then
                        If sc(i + 1) = "w" And sc(i + 2) = "a" And sc(i + 3) = "s" Then
                            If sc(i + 1) = "w" And sc(i + 2) = "a" And sc(i + 3) = "s" And sc(i + 4) = "p" Then
                                If sc(i + 5) = "(" Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("swasp")
                                    tokens.setLexeme("swasp")
                                    tokens.setAttrib("swasp")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("swasp")
                                    objList.SubItems.Add("swasp")
                                    objList.SubItems.Add("swasp")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'swasp'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'swas'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'swa'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'sw'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'s'")
                    read = True
                End If



            ElseIf sc(i) = "t" Then
                If sc(i + 1) = "e" Then
                    If sc(i + 1) = "e" And sc(i + 2) = "r" Then
                        If sc(i + 1) = "e" And sc(i + 2) = "r" And sc(i + 3) = "m" Then
                            If sc(i + 1) = "e" And sc(i + 2) = "r" And sc(i + 3) = "m" And sc(i + 4) = "i" Then
                                If sc(i + 1) = "e" And sc(i + 2) = "r" And sc(i + 3) = "m" And sc(i + 4) = "i" And sc(i + 5) = "t" Then
                                    If sc(i + 1) = "e" And sc(i + 2) = "r" And sc(i + 3) = "m" And sc(i + 4) = "i" And sc(i + 5) = "t" _
                                                            And sc(i + 6) = "e" Then
                                        If sc(i + 7) = " " Or sc(i + 7) = ":" Then
                                            symbolCtr += 1
                                            tokens = New Tokens
                                            tokens.setToken("termite")
                                            tokens.setLexeme("termite")
                                            tokens.setAttrib("termite")
                                            tokens.setLine(line)
                                            tokenstream.Add(tokens)
                                            objList = dGridLexi.Items.Add(symbolCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add("termite")
                                            objList.SubItems.Add("termite")
                                            objList.SubItems.Add("termite")
                                            read = True
                                            i += 6
                                        Else
                                            errorCtr += 1
                                            objList = dGridError.Items.Add(errorCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add(delimStr & "'termite'")
                                            read = True
                                            i += 6
                                        End If
                                    Else
                                        errorCtr += 1
                                        objList = dGridError.Items.Add(errorCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add(delimStr & "'termit'")
                                        read = True
                                        i += 5
                                    End If
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'termi'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'term'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'ter'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'te'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "r" Then
                    If sc(i + 1) = "r" And sc(i + 2) = "u" Then
                        If sc(i + 1) = "r" And sc(i + 2) = "u" And sc(i + 3) = "e" Then
                            If sc(i + 4) = " " Or sc(i + 4) = ":" Or sc(i + 4) = ")" Or sc(i + 4) = "," Or sc(i + 4) = "}" Or Not inArray(sc(i + 4), delimsymbol, 95) Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("true")
                                tokens.setLexeme("bullLit")
                                tokens.setAttrib("bullLit, true")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("true")
                                objList.SubItems.Add("bullLit")
                                objList.SubItems.Add("bullLite, true")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'true'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'tru'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'tr'")
                        read = True
                        i += 1
                    End If

                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'t'")
                    read = True
                End If

            ElseIf sc(i) = "v" Then
                If sc(i + 1) = "i" Then
                    If sc(i + 1) = "i" And sc(i + 2) = "p" Then
                        If sc(i + 1) = "i" And sc(i + 2) = "p" And sc(i + 3) = "e" Then
                            If sc(i + 1) = "i" And sc(i + 2) = "p" And sc(i + 3) = "e" And sc(i + 4) = "r" Then
                                If sc(i + 5) = " " Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("viper")
                                    tokens.setLexeme("viper")
                                    tokens.setAttrib("data type")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("viper")
                                    objList.SubItems.Add("viper")
                                    objList.SubItems.Add("data type")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'viper'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'vipe'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'vip'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'vi'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'v'")
                    read = True
                End If

            ElseIf sc(i) = "w" Then
                If sc(i + 1) = "h" Then
                    If sc(i + 1) = "h" And sc(i + 2) = "a" Then
                        If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "l" Then
                            If sc(i + 1) = "h" And sc(i + 2) = "a" And sc(i + 3) = "l" And sc(i + 4) = "e" Then
                                If sc(i + 5) = "(" Or sc(i + 5) = " " Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("whale")
                                    tokens.setLexeme("whale")
                                    tokens.setAttrib("whale")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("whale")
                                    objList.SubItems.Add("whale")
                                    objList.SubItems.Add("whale")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'whale'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'whal'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'wha'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'wh'")
                        read = True
                        i += 1
                    End If

                ElseIf sc(i + 1) = "i" Then
                    If sc(i + 1) = "i" And sc(i + 2) = "p" Then
                        If sc(i + 1) = "i" And sc(i + 2) = "p" And sc(i + 3) = "e" Then
                            If sc(i + 4) = " " Or sc(i + 4) = ":" Then
                                symbolCtr += 1
                                tokens = New Tokens
                                tokens.setToken("wipe")
                                tokens.setLexeme("wipe")
                                tokens.setAttrib("wipe")
                                tokens.setLine(line)
                                tokenstream.Add(tokens)
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("wipe")
                                objList.SubItems.Add("wipe")
                                objList.SubItems.Add("wipe")
                                read = True
                                i += 3
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'wipe'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'wip'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'wi'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'w'")
                    read = True
                End If

            ElseIf sc(i) = "z" Then
                If sc(i + 1) = "o" Then
                    If sc(i + 1) = "o" And sc(i + 2) = "o" Then
                        If sc(i + 1) = "o" And sc(i + 2) = "o" And sc(i + 3) = "u" Then
                            If sc(i + 1) = "o" And sc(i + 2) = "o" And sc(i + 3) = "u" And sc(i + 4) = "t" Then
                                If sc(i + 5) = "(" Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("zoout")
                                    tokens.setLexeme("zoout")
                                    tokens.setAttrib("zoout")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("zoout")
                                    objList.SubItems.Add("zoout")
                                    objList.SubItems.Add("zoout")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'zoout'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'zoou'")
                                read = True
                                i += 3
                            End If

                        ElseIf sc(i + 1) = "o" And sc(i + 2) = "o" And sc(i + 3) = "i" Then
                            If sc(i + 1) = "o" And sc(i + 2) = "o" And sc(i + 3) = "i" And sc(i + 4) = "n" Then
                                If sc(i + 5) = ")" Then
                                    symbolCtr += 1
                                    tokens = New Tokens
                                    tokens.setToken("zooin")
                                    tokens.setLexeme("zooin")
                                    tokens.setAttrib("zooin")
                                    tokens.setLine(line)
                                    tokenstream.Add(tokens)
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("zooin")
                                    objList.SubItems.Add("zooin")
                                    objList.SubItems.Add("zooin")
                                    read = True
                                    i += 4
                                Else
                                    errorCtr += 1
                                    objList = dGridError.Items.Add(errorCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add(delimStr & "'zooin'")
                                    read = True
                                    i += 4
                                End If
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'zooi'")
                                read = True
                                i += 3
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'zoo'")
                            read = True
                            i += 2
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'zo'")
                        read = True
                        i += 1
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'z'")
                    read = True
                End If
            End If
            '--------------------------------------------------------END NG Reserved wOrds

            'ElseIf sc(i) = "z" Then
            '    If sc(i + 1) = "t" Then
            '        If sc(i + 1) = "t" And sc(i + 2) = "r" Then
            '            If sc(i + 3) = " " Or sc(i + 3) = "(" Then
            '                symbolCtr += 1
            '                objList = dGridLexi.Items.Add(symbolCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add("ztr")
            '                objList.SubItems.Add("ztr")
            '                objList.SubItems.Add(" ")
            '                read = True
            '                i += 2
            '            Else
            '                errorCtr += 1
            '                objList = dGridError.Items.Add(errorCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add(delimStr & "'ztr'")
            '                read = True
            '                i += 2
            '            End If
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'zt'")
            '            read = True
            '            i += 1
            '        End If
            '    ElseIf sc(i + 1) = "r" And sc(i + 2) = "e" And sc(i + 3) = "v" Then
            '        If sc(i + 4) = " " Or sc(i + 4) = "(" Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("zrev")
            '            objList.SubItems.Add("zrev")
            '            objList.SubItems.Add(" ")
            '            read = True
            '            i += 3
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'zrev'")
            '            read = True
            '            i += 3
            '        End If
            '    ElseIf sc(i + 1) = "c" And sc(i + 2) = "a" And sc(i + 3) = "t" Then
            '        If sc(i + 4) = " " Or sc(i + 4) = "(" Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("zcat")
            '            objList.SubItems.Add("zcat")
            '            objList.SubItems.Add(" ")
            '            read = True
            '            i += 3
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'zcat'")
            '            read = True
            '            i += 3
            '        End If
            '    Else
            '        errorCtr += 1
            '        objList = dGridError.Items.Add(errorCtr)
            '        objList.SubItems.Add(line)
            '        objList.SubItems.Add(delimStr & "'z'")
            '        read = True
            '    End If
            'ElseIf sc(i) = "x" Then
            '    If sc(i + 1) = "l" Then
            '    If sc(i + 1) = "l" And sc(i + 2) = "e" And sc(i + 3) = "a" And sc(i + 4) = "r" Then
            '        If sc(i + 5) = "(" Or sc(i + 5) = " " Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("xlear")
            '            objList.SubItems.Add("xlear")
            '            objList.SubItems.Add(" ")
            '            read = True
            '            i += 4
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'xlear'")
            '            read = True
            '            i += 4
            '        End If
            '    End If
            'ElseIf sc(i + 1) = "n" Then
            '    If sc(i + 1) = "n" And sc(i + 2) = "o" And sc(i + 3) = "r" And sc(i + 4) = "e" Then
            '        If sc(i + 5) = "(" Or sc(i + 5) = " " Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("xnore")
            '            objList.SubItems.Add("xnore")
            '            objList.SubItems.Add(" ")
            '            read = True
            '            i += 4
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'xnore'")
            '            read = True
            '            i += 4
            '        End If
            '    End If
            'ElseIf sc(i + 1) = "f" Then
            '    If sc(i + 1) = "f" And sc(i + 2) = "a" And sc(i + 3) = "i" And sc(i + 4) = "l" Then
            '        If sc(i + 5) = "(" Or sc(i + 5) = " " Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("xfail")
            '            objList.SubItems.Add("xfail")
            '            objList.SubItems.Add(" ")
            '            read = True
            '            i += 4
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'xfail'")
            '            read = True
            '            i += 4
            '        End If
            'End If
            'End If


            '------------------------OPERATORS
            If sc(i) = "=" Then
                If sc(i + 1) = "=" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or sc(i + 2) = """" Or Char.IsDigit(sc(i + 2)) Or sc(i + 2) = "t" Or sc(i + 2) = "f" Or sc(i + 2) = "n" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("==")
                        tokens.setLexeme("relOp2")
                        tokens.setAttrib("relOp, ==")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("==")
                        objList.SubItems.Add("relOp2")
                        objList.SubItems.Add("relOp, ==")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'=='")
                        i += 1
                        read = True
                    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or sc(i + 1) = "{" Or sc(i + 1) = """" Or Char.IsDigit(sc(i + 1)) Or sc(i + 1) = "t" Or sc(i + 1) = "f" Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("=")
                    tokens.setLexeme("assgnOp")
                    tokens.setAttrib("assgnOp, =")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("=")
                    objList.SubItems.Add("assgnOp")
                    objList.SubItems.Add("assgnOp, =")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'='")
                    read = True
                End If
            End If
            'END NG =

            If sc(i) = "+" Then
                If sc(i + 1) = "+" Then
                    If sc(i + 2) = " " Or sc(i + 2) = """" Or sc(i + 2) = "$" Or sc(i + 2) = ":" Or sc(i + 2) = ")" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("++")
                        tokens.setLexeme("increOp")
                        tokens.setAttrib("increOp, ++")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("++")
                        objList.SubItems.Add("increOp")
                        objList.SubItems.Add("increOp, ++")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'++'")
                        i += 1
                        read = True
                    End If
                    'ElseIf sc(i + 1) = "=" Then
                    '    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                    '        symbolCtr += 1
                    '        objList = dGridLexi.Items.Add(symbolCtr)
                    '        objList.SubItems.Add(line)
                    '        objList.SubItems.Add("+=")
                    '        objList.SubItems.Add("assgnOp2")
                    '        objList.SubItems.Add("assgnOp, +=")
                    '        i += 1
                    '        read = True
                    '    Else
                    '        errorCtr += 1
                    '        objList = dGridError.Items.Add(errorCtr)
                    '        objList.SubItems.Add(line)
                    '        objList.SubItems.Add(delimStr & "'+='")
                    '        i += 1
                    '        read = True
                    '    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("+")
                    tokens.setLexeme("mathOp")
                    tokens.setAttrib("addOp, +")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("+")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("addOp, +")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'+'")
                    read = True
                End If
            End If
            'END NG +

            If sc(i) = "-" Then
                If sc(i + 1) = "-" Then
                    If sc(i + 2) = " " Or sc(i + 2) = """" Or sc(i + 2) = "$" Or sc(i + 2) = ":" Or sc(i + 2) = ")" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("--")
                        tokens.setLexeme("decreOp")
                        tokens.setAttrib("decreOp, --")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("--")
                        objList.SubItems.Add("decreOp")
                        objList.SubItems.Add("decreOp, --")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'--'")
                        i += 1
                        read = True
                    End If
                    'ElseIf sc(i + 1) = "=" Then
                    '    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                    '        symbolCtr += 1
                    '        objList = dGridLexi.Items.Add(symbolCtr)
                    '        objList.SubItems.Add(line)
                    '        objList.SubItems.Add("-=")
                    '        objList.SubItems.Add("assgnOp2")
                    '        objList.SubItems.Add("assgnOp, -=")
                    '        i += 1
                    '        read = True
                    '    Else
                    '        errorCtr += 1
                    '        objList = dGridError.Items.Add(errorCtr)
                    '        objList.SubItems.Add(line)
                    '        objList.SubItems.Add(delimStr & "'-='")
                    '        i += 1
                    '        read = True
                    '    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("-")
                    tokens.setLexeme("mathOp")
                    tokens.setAttrib("subOp, -")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("-")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("subOp, -")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'-'")
                    read = True
                End If
            End If
            'END NG -

            If sc(i) = "*" Then
                'If sc(i + 1) = "=" Then
                '    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                '        symbolCtr += 1
                '        objList = dGridLexi.Items.Add(symbolCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add("*=")
                '        objList.SubItems.Add("assgnOp2")
                '        objList.SubItems.Add("assgnOp, *=")
                '        i += 1
                '        read = True
                '    Else
                '        errorCtr += 1
                '        objList = dGridError.Items.Add(errorCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add(delimStr & "'*='")
                '        i += 1
                '        read = True
                '    End If
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("*")
                    tokens.setLexeme("mathOp")
                    tokens.setAttrib("mulOp, *")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("*")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("mulOp, *")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'*'")
                    read = True
                End If
            End If
            'END NG *

            If sc(i) = "/" Then
                'If sc(i + 1) = "=" Then
                '    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                '        symbolCtr += 1
                '        objList = dGridLexi.Items.Add(symbolCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add("/=")
                '        objList.SubItems.Add("assgnOp2")
                '        objList.SubItems.Add("assgnOp, /=")
                '        i += 1
                '        read = True
                '    Else
                '        errorCtr += 1
                '        objList = dGridError.Items.Add(errorCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add(delimStr & "'/='")
                '        i += 1
                '        read = True
                '    End If
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("/")
                    tokens.setLexeme("mathOp")
                    tokens.setAttrib("divOp, /")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("/")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("divOp, /") 'mulOp
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'/'")
                    read = True
                End If
            End If
            'END NG /

            If sc(i) = "%" Then
                'If sc(i + 1) = "=" Then
                '    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                '        symbolCtr += 1
                '        objList = dGridLexi.Items.Add(symbolCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add("%=")
                '        objList.SubItems.Add("assgnOp2")
                '        objList.SubItems.Add("assgnOp, %=")
                '        i += 1
                '        read = True
                '    Else
                '        errorCtr += 1
                '        objList = dGridError.Items.Add(errorCtr)
                '        objList.SubItems.Add(line)
                '        objList.SubItems.Add(delimStr & "'%='")
                '        i += 1
                '        read = True
                '    End If
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("%")
                    tokens.setLexeme("modOp")
                    tokens.setAttrib("modOp, %")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("%")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("modOp, %")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'%'")
                    read = True
                End If
            End If
            'END NG %

            If sc(i) = "?" Then
                If sc(i + 2) = " " Or sc(i + 2) = "$" Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("?")
                    tokens.setLexeme("?")
                    tokens.setAttrib("strOp, ?, binary")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("?")
                    objList.SubItems.Add("?")
                    objList.SubItems.Add("strOp, ?, binary")
                    i += 1
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'?'")
                    i += 1
                    read = True
                End If
            End If

            ' END NG ?

            If sc(i) = "!" Then
                If sc(i + 1) = "=" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or sc(i + 2) = """" Or sc(i + 2) = "f" Or sc(i + 2) = "t" Or sc(i + 2) = "n" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("!=")
                        tokens.setLexeme("relOp2")
                        tokens.setAttrib("relOp, !=")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("!=")
                        objList.SubItems.Add("relOp2")
                        objList.SubItems.Add("relOp, !=")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'!='")
                        i += 1
                        read = True
                    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "(" Or sc(i + 1) = "$" Or sc(i + 1) = "t" Or sc(i + 1) = "f" Or Not inArray(sc(i + 1), delimsymbol, 95) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("!")
                    tokens.setLexeme("!")
                    tokens.setAttrib("logOp, !")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("!")
                    objList.SubItems.Add("!")
                    objList.SubItems.Add("logOp, !")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'!'")
                    read = True
                End If
            End If
            'END NG !

            If sc(i) = "<" Then
                If sc(i + 1) = "=" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("<=")
                        tokens.setLexeme("relOp1")
                        tokens.setAttrib("relOp, <=")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("<=")
                        objList.SubItems.Add("relOp1")
                        objList.SubItems.Add("relOp, <=")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'<='")
                        i += 1
                        read = True
                    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("<")
                    tokens.setLexeme("relOp1")
                    tokens.setAttrib("relOp, <")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("<")
                    objList.SubItems.Add("relOp1")
                    objList.SubItems.Add("relOp, <")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'<'")
                    read = True
                End If
            End If
            'END NG <



            If sc(i) = ">" Then
                If sc(i + 1) = "=" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken(">=")
                        tokens.setLexeme("relOp1")
                        tokens.setAttrib("relOp, >=")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(">=")
                        objList.SubItems.Add("relOp1")
                        objList.SubItems.Add("relOp, >=")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'>='")
                        i += 1
                        read = True
                    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken(">")
                    tokens.setLexeme("relOp1")
                    tokens.setAttrib("relOp, >")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(">")
                    objList.SubItems.Add("relOp1")
                    objList.SubItems.Add("relOp, >")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'>'")
                    read = True
                End If
            End If
            'END NG >


            If sc(i) = "\" Then
                If sc(i + 1) = "n" Then
                    If sc(i + 2) = " " Or sc(i + 2) = ":" Or sc(i + 2) = "\" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("\n")
                        tokens.setLexeme("\n")
                        tokens.setAttrib("newline symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("\n")
                        objList.SubItems.Add("\n")
                        objList.SubItems.Add("newline symbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'\n'")
                        i += 1
                        read = True
                    End If

                ElseIf sc(i + 1) = "t" Then
                    If sc(i + 2) = " " Or sc(i + 2) = ":" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("\t")
                        tokens.setLexeme("\t")
                        tokens.setAttrib("tab symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("\t")
                        objList.SubItems.Add("\t")
                        objList.SubItems.Add("tab symbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'\t'")
                        i += 1
                        read = True
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'\'")
                    read = True
                End If
            End If
            'END NG \

            If sc(i) = "^" Then
                If sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("^")
                    tokens.setLexeme("mathop")
                    tokens.setAttrib("powerOp, ^")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("^")
                    objList.SubItems.Add("mathOp")
                    objList.SubItems.Add("powerOp, ^")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'^'")
                    read = True
                End If
            End If
            'END NG ^

            If sc(i) = "&" Then
                If sc(i + 1) = "&" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "(" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("&&")
                        tokens.setLexeme("&&")
                        tokens.setAttrib("logOp, &&")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("&&")
                        objList.SubItems.Add("&&")
                        objList.SubItems.Add("logOp, &&")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'&&'")
                        i += 1
                        read = True
                    End If
                End If
            End If
            'END NG &&

            If sc(i) = "|" Then
                If sc(i + 1) = "|" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "(" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("||")
                        tokens.setLexeme("||")
                        tokens.setAttrib("logOp, ||")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("||")
                        objList.SubItems.Add("||")
                        objList.SubItems.Add("logOp, ||")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'||'")
                        i += 1
                        read = True
                    End If
                End If
            End If

            'END NG ||



            If sc(i) = "(" Then
                If sc(i + 1) = "(" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" _
                             Or sc(i + 2) = """" Or Char.IsDigit(sc(i + 2)) Or Not inArray(sc(i + 1), delimsymbol, 95) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("((")
                        tokens.setLexeme("((")
                        tokens.setAttrib("output symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("((")
                        objList.SubItems.Add("((")
                        objList.SubItems.Add("output symbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'(('")
                        i += 1
                        read = True
                    End If

                ElseIf sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = ")" Or sc(i + 1) = "~" _
                                Or sc(i + 1) = "+" Or sc(i + 1) = "-" Or sc(i + 1) = "n" Or sc(i + 1) = "d" Or sc(i + 1) = "s" _
                                Or sc(i + 1) = "b" Or sc(i + 1) = """" Or sc(i + 1) = "!" Or sc(i + 1) = "'" Or Char.IsDigit(sc(i + 1)) _
                                Or Not inArray(sc(i + 1), delimsymbol, 95) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("(")
                    tokens.setLexeme("(")
                    tokens.setAttrib("oppar")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("(")
                    objList.SubItems.Add("oppar")
                    objList.SubItems.Add("oppar")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'('")
                    read = True
                End If
            End If
            'END NG (


            If sc(i) = ")" Then
                If sc(i + 1) = ")" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("))")
                        tokens.setLexeme("))")
                        tokens.setAttrib("input symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("))")
                        objList.SubItems.Add("))")
                        objList.SubItems.Add("input symbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'))'")
                        i += 1
                        read = True
                    End If

                ElseIf sc(i + 1) = " " Or sc(i + 1) = ")" Or sc(i + 1) = "," Or sc(i + 1) = ":" _
                     Or sc(i + 1) = "\" Or sc(i + 1) = "+" Or sc(i + 1) = "-" Or sc(i + 1) = "*" _
                     Or sc(i + 1) = "/" Or sc(i + 1) = "%" Or sc(i + 1) = "^" Or sc(i + 1) = "&" _
                     Or sc(i + 1) = "|" Or sc(i + 1) = "<" Or sc(i + 1) = ">" Or sc(i + 1) = "=" _
                     Or sc(i + 1) = "!" Or sc(i + 1) = " ' " Or sc(i + 1) = "}" Or sc(i + 1) = "newline" _
                     Or Not inArray(sc(i + 1), delimsymbol, 95) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken(")")
                    tokens.setLexeme("clpar")
                    tokens.setAttrib("clpar")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(")")
                    objList.SubItems.Add("clpar")
                    objList.SubItems.Add("clpar")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "')'")
                    read = True
                End If
            End If
            'END NG )

            If sc(i) = "[" Then
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "]" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("[")
                    tokens.setLexeme("opsquare")
                    tokens.setAttrib("opsquare")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("[")
                    objList.SubItems.Add("opsquare")
                    objList.SubItems.Add("opsquare")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'['")
                    read = True
                End If
            End If
            'END NG [

            If sc(i) = "]" Then
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "\" _
                Or sc(i + 1) = "," Or sc(i + 1) = ":" Or sc(i + 1) = "+" _
                Or sc(i + 1) = "-" Or sc(i + 1) = "*" Or sc(i + 1) = "/" _
                Or sc(i + 1) = "%" Or sc(i + 1) = "^" Or sc(i + 1) = "&" _
                Or sc(i + 1) = "|" Or sc(i + 1) = "<" Or sc(i + 1) = ">" _
                Or sc(i + 1) = "=" Or sc(i + 1) = "!" Or sc(i + 1) = "[" Or sc(i + 1) = ")" Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("]")
                    tokens.setLexeme("clsquare")
                    tokens.setAttrib("clsquare")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("]")
                    objList.SubItems.Add("clsquare")
                    objList.SubItems.Add("clsquare")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "']'")
                    read = True
                End If
            End If
            'END NG ]

            If sc(i) = "{" Then
                If sc(i + 1) = "{" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "'" Or sc(i + 2) = "$" Or sc(i + 2) = "~" Or sc(i + 2) = "(" Or sc(i + 2) = "w" Or sc(i + 2) = "t" Or sc(i + 2) = "f" Or sc(i + 2) = "c" Or sc(i + 2) = "r" Or sc(i + 2) = "d" Or sc(i + 2) = "newline" Or Not inArray(sc(i + 2), delimsymbol, 95) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("{{")
                        tokens.setLexeme("opsymbol")
                        tokens.setAttrib("opsymbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("{{")
                        objList.SubItems.Add("opsymbol")
                        objList.SubItems.Add("opsymbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'{{'")
                        i += 1
                        read = True
                    End If

                ElseIf sc(i + 1) = " " Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or sc(i + 1) = """" Or sc(i + 1) = "f" _
                    Or sc(i + 1) = "t" Or sc(i + 1) = "$" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("{")
                    tokens.setLexeme("opcurly")
                    tokens.setAttrib("opcurly")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("{")
                    objList.SubItems.Add("opcurly")
                    objList.SubItems.Add("opcurly")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'{'")
                    read = True
                End If

            End If
            'END NG {

            If sc(i) = "}" Then
                If sc(i + 1) = "}" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "'" Or sc(i + 2) = "$" Or sc(i + 2) = ":" Or sc(i + 2) = "d" Or sc(i + 2) = "newline" Or Not inArray(sc(i + 2), delimsymbol, 95) Then 'pending nl
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("}}")
                        tokens.setLexeme("clsymbol")
                        tokens.setAttrib("clsymbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("}}")
                        objList.SubItems.Add("clsymbol")
                        objList.SubItems.Add("clsymbol")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'}}'")
                        i += 1
                        read = True
                    End If

                ElseIf sc(i + 1) = " " Or sc(i + 1) = ":" Or sc(i + 1) = "," Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("}")
                    tokens.setLexeme("clcurly")
                    tokens.setAttrib("clcurly")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("}")
                    objList.SubItems.Add("clcurly")
                    objList.SubItems.Add("clcurly")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'}'")
                    read = True
                End If

            End If

            'END NG }

            If sc(i) = ";" Then
                If i + 1 < sourcecode.Length Then
                    If sc(i + 1) = " " Or sc(i + 1) = "<" Or sc(i + 1) = "'" Or sc(i + 1) = "t" Or sc(i + 1) = "newline" Or Not inArray(sc(i + 1), delimsymbol, 95) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken(";")
                        tokens.setLexeme(";")
                        tokens.setAttrib("switch terminal symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(";")
                        objList.SubItems.Add(";")
                        objList.SubItems.Add("switch terminal symbol")
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "';'")
                        read = True
                    End If
                End If
            End If
            'END NG ;

            'If sc(i) = "?" Then
            '    If i + 1 < sourcecode.Length Then
            '        If sc(i + 1) = " " Or sc(i + 1) = "$" Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("?")
            '            objList.SubItems.Add("?")
            '            objList.SubItems.Add("ternary operator")
            '            read = True
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'?'")
            '            read = True
            '        End If
            '    End If
            'End If
            'END NG ?

            'If sc(i) = "'" Then
            '    If sc(i + 1) = "\" Then
            '        If sc(i + 1) = "\" And sc(i + 2) = "0" Then
            '            If sc(i + 1) = "\" And sc(i + 2) = "0" And sc(i + 3) = "'" Then
            '                If sc(i + 4) = " " Or sc(i + 4) = ")" Then
            '                    symbolCtr += 1
            '                    objList = dGridLexi.Items.Add(symbolCtr)
            '                    objList.SubItems.Add(line)
            '                    objList.SubItems.Add("'\0'")
            '                    objList.SubItems.Add("'\0'")
            '                    objList.SubItems.Add("end of char")
            '                    i += 3
            '                    read = True
            '                Else
            '                    errorCtr += 1
            '                    objList = dGridError.Items.Add(errorCtr)
            '                    objList.SubItems.Add(line)
            '                    objList.SubItems.Add(delimStr & "'\0'")
            '                    i += 3
            '                    read = True
            '                End If
            '            Else
            '                errorCtr += 1
            '                objList = dGridError.Items.Add(errorCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add(delimStr & "'\0")
            '                i += 2
            '                read = True
            '            End If
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'\")
            '            i += 1
            '            read = True
            '        End If
            '    ElseIf sc(i + 1) = "'" Then
            '        If sc(i + 2) = " " Or sc(i + 2) = ")" Then
            '            symbolCtr += 1
            '            objList = dGridLexi.Items.Add(symbolCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add("''")
            '            objList.SubItems.Add("''")
            '            objList.SubItems.Add("empty char")
            '            i += 1
            '            read = True
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "''")
            '            i += 1
            '            read = True
            '        End If
            '    ElseIf sc(i + 1) = "*" Then
            '        If sc(i + 1) = "*" And sc(i + 2) = "'" Then
            '            If sc(i + 3) = " " Or sc(i + 3) = "\" Then
            '                symbolCtr += 1
            '                objList = dGridLexi.Items.Add(symbolCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add("'*'")
            '                objList.SubItems.Add("'*'")
            '                objList.SubItems.Add("char")
            '                i += 2
            '                read = True
            '            Else
            '                errorCtr += 1
            '                objList = dGridError.Items.Add(errorCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add(delimStr & "'*'")
            '                i += 2
            '                read = True
            '            End If
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'*")
            '            i += 1
            '            read = True
            '        End If
            '    ElseIf Char.IsLetterOrDigit(sc(i + 1)) Then
            '        If sc(i + 2) = "'" Then
            '            If sc(i + 3) = " " Then
            '                symbolCtr += 1
            '                objList = dGridLexi.Items.Add(symbolCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add("'" & sc(i + 1) & "'")
            '                objList.SubItems.Add("valuu")
            '                objList.SubItems.Add("char")
            '                i += 2
            '                read = True
            '            Else
            '                errorCtr += 1
            '                objList = dGridError.Items.Add(errorCtr)
            '                objList.SubItems.Add(line)
            '                objList.SubItems.Add(delimStr & "'val'")
            '                i += 2
            '                read = True
            '            End If
            '        Else
            '            errorCtr += 1
            '            objList = dGridError.Items.Add(errorCtr)
            '            objList.SubItems.Add(line)
            '            objList.SubItems.Add(delimStr & "'val'")
            '            i += 1
            '            read = True
            '        End If
            '    Else
            '        errorCtr += 1
            '        objList = dGridError.Items.Add(errorCtr)
            '        objList.SubItems.Add(line)
            '        objList.SubItems.Add(delimStr & "'")
            '        read = True
            '    End If
            'End If
            'END NG '

            If sc(i) = "'" Then
                comment = ""
                read = True
                Dim x As Integer = 1
                Dim start As Integer = x
                Dim point As Integer = line

                While i + x + 1 < sourcecode.Length
                    If Not (Microsoft.VisualBasic.AscW(sc(i + x)) = 10) Then
                        x += 1
                    Else
                        Exit While
                    End If
                End While

                While Not (start = x)
                    comment = comment & sc(i + start)
                    start += 1
                End While
                symbolCtr += 1
                'tokens = New Tokens
                'tokens.setToken("'")
                'tokens.setLexeme("comment")
                'tokens.setAttrib("comment")
                'tokens.setLine(line)
                'tokenstream.Add(tokens)
                objList = dGridLexi.Items.Add(symbolCtr)
                objList.SubItems.Add(line)
                objList.SubItems.Add("'" & comment)
                objList.SubItems.Add("comment")
                objList.SubItems.Add("comment")
                read = True
                i += x
            End If
            'END NG '

            If sc(i) = ":" Then
                If i + 1 < sourcecode.Length Then
                    If sc(i + 1) = " " Or sc(i + 1) = "'" Or sc(i + 1) = "(" Or sc(i + 1) = ">" Or sc(i + 1) = "$" _
                        Or sc(i + 1) = "newline" Or Not inArray(sc(i + 1), delimsymbol, 95) Then 'pending nl
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken(":")
                        tokens.setLexeme(":")
                        tokens.setAttrib("statement terminator")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(":")
                        objList.SubItems.Add(":")
                        objList.SubItems.Add("statement terminator")
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "':'")
                        read = True
                    End If
                End If
            End If
            'END NG \

            If sc(i) = "," Then
                If i + 1 < sourcecode.Length Then
                    If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = """" Or sc(i + 1) = "(" Or sc(i + 1) = "~" _
                        Or sc(i + 1) = "b" Or sc(i + 1) = "d" Or sc(i + 1) = "n" Or sc(i + 1) = "s" Or Char.IsDigit(sc(i + 1)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken(",")
                        tokens.setLexeme(",")
                        tokens.setAttrib("separator symbol")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(",")
                        objList.SubItems.Add(",")
                        objList.SubItems.Add("separator symbol")
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "','")
                        read = True
                    End If
                End If
            End If
            'END NG ,

            If sc(i) = "~" Then
                If i + 1 < sourcecode.Length Then
                    If sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = " " Or Char.IsDigit(sc(i + 1)) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("~")
                        tokens.setLexeme("~")
                        tokens.setAttrib("negOp, ~, unary")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("~")
                        objList.SubItems.Add("~")
                        objList.SubItems.Add("negOp, ~, unary")
                        read = True
                    ElseIf Char.IsDigit(sc(i + 1)) Then 'leading
                        neg = True
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'~'")
                        read = True
                    End If
                End If
            End If
            'END NG ~

            If sc(i) = "." Then
                If sc(i + 1) = "+" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken(".+")
                        tokens.setLexeme(".+")
                        tokens.setAttrib("structOp, .+")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(".+")
                        objList.SubItems.Add(".+")
                        objList.SubItems.Add("structOp, .+")
                        i += 1
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'.+'")
                        i += 1
                        read = True
                    End If
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "i" Or sc(i + 1) = "l" Or sc(i + 1) = "z" Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken(".")
                    tokens.setLexeme(".")
                    tokens.setAttrib(" ")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(".")
                    objList.SubItems.Add(".")
                    objList.SubItems.Add(" ")
                    read = True
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'.'")
                    read = True
                End If
            End If
            'END NG .

            '-----------------textlit
            If sc(i) = """" Then
                str = ""
                read = True
                Dim x As Integer = 1
                Dim start As Integer = x
                Dim point As Integer = line
                While Not (sc(i + x) = """" Or Not inArray(sc(i + x), delimsymbol, 95)) And i + x + 1 < sourcecode.Length
                    x += 1
                End While

                While Not (start = x)
                    str = str & sc(i + start)
                    start += 1
                End While

                If sc(i + x) = """" Then
                    If str.Length <= 500 Then
                        If sc(i + x + 1) = " " Or sc(i + x + 1) = ":" Or sc(i + x + 1) = ";" Or sc(i + x + 1) = ":" _
                        Or sc(i + x + 1) = ")" Or sc(i + x + 1) = "," Or sc(i + x + 1) = "}" Or sc(i + x + 1) = "!" Or Not inArray(sc(i + x + 1), delimsymbol, 95) Then
                            symbolCtr += 1
                            tokens = New Tokens
                            tokens.setToken("starling literals")
                            tokens.setLexeme("starlinglit")
                            tokens.setAttrib("starlinglit")
                            tokens.setLine(line)
                            tokenstream.Add(tokens)
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("""" & str & """")
                            objList.SubItems.Add("starlinglit")
                            objList.SubItems.Add("starlinglit, " & """" & str & """")
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & """" & str & """")
                        End If
                    Else
                        If sc(i + x + 1) = " " Or sc(i + x + 1) = ":" Or sc(i + x + 1) = ";" Or sc(i + x + 1) = ":" _
                        Or sc(i + x + 1) = ")" Or sc(i + x + 1) = "," Or sc(i + x + 1) = "}" Or sc(i + x + 1) = "!" Then
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("Invalid String literal. Exceed max. no of character in string")
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("Exceed max. no of character in string & Invalid lexeme")
                        End If
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("""" & str & " , Please Terminate the string")
                End If
                read = True
                i += x
            End If

            '-----------------NUMLIT
            If Char.IsDigit(sc(i)) Then
                Dim number As String = ""
                number = number + sc(i)
                Dim ctr1 As Integer = i + 1
                Dim length As Integer = 0
                While ctr1 < sourcecode.Length
                    If Char.IsDigit(sc(ctr1)) And length < 10 Then
                        number = number + sc(ctr1)
                        ctr1 += 1
                        length += 1
                    Else
                        Exit While
                    End If
                End While

                If sc(ctr1) = " " Or sc(ctr1) = "," Or sc(ctr1) = ":" _
                Or sc(ctr1) = "]" Or sc(ctr1) = "+" Or sc(ctr1) = "-" Or sc(ctr1) = "}" _
                Or sc(ctr1) = "*" Or sc(ctr1) = "/" Or sc(ctr1) = "%" Or sc(ctr1) = "^" _
                Or sc(ctr1) = "<" Or sc(ctr1) = ";" Or sc(ctr1) = ">" Or sc(ctr1) = "'" Or sc(ctr1) = "=" Or sc(ctr1) = ")" Or Not inArray(sc(ctr1), delimsymbol, 95) Then
                    symbolCtr += 1
                    tokens = New Tokens
                    tokens.setToken("newt literals")
                    tokens.setLexeme("newtlit")
                    tokens.setAttrib("newtlit")
                    tokens.setLine(line)
                    tokenstream.Add(tokens)
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    If neg = True Then
                        objList.SubItems.Add("~" & number)
                        objList.SubItems.Add("newtlit")
                        objList.SubItems.Add("newtlit, ~" & number)
                    Else
                        objList.SubItems.Add(number)
                        objList.SubItems.Add("newtlit")
                        objList.SubItems.Add("newtlit, " & number)
                    End If
                    read = True
                    i = ctr1 - 1
                    neg = False

                ElseIf sc(ctr1) = "." Then
                    number = number + sc(ctr1)
                    Dim ctr2 As Integer = ctr1 + 1
                    Dim length1 As Integer = 0
                    While ctr2 < sourcecode.Length
                        If Char.IsDigit(sc(ctr2)) And length1 < 4 Then
                            number = number + sc(ctr2)
                            ctr2 += 1
                            length1 += 1
                        Else
                            Exit While
                        End If
                    End While

                    If sc(ctr2) = " " Or sc(ctr2) = ":" _
                    Or sc(ctr2) = "]" Or sc(ctr2) = "+" Or sc(ctr2) = "-" _
                    Or sc(ctr2) = "*" Or sc(ctr2) = "/" Or sc(ctr2) = "%" Or sc(ctr2) = "^" _
                    Or sc(ctr2) = "<" Or sc(ctr2) = ";" Or sc(ctr2) = ">" Or sc(ctr2) = "'" Or sc(ctr2) = "=" Or sc(ctr2) = ")" Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("duck literals")
                        'tokens.setLexeme("ducklit")
                        'tokens.setAttrib("ducklit")
                        'tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        If neg = True Then
                            objList.SubItems.Add("~" & number)
                            objList.SubItems.Add("ducklit")
                            objList.SubItems.Add("ducklit, ~" & number)
                        Else
                            objList.SubItems.Add(number)
                            objList.SubItems.Add("ducklit")
                            objList.SubItems.Add("ducklit, " & number)
                        End If
                        read = True
                        i = ctr2 - 1
                        neg = False
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        If neg = True Then
                            objList.SubItems.Add(delimStr & "'~" & number & "'")
                        Else
                            objList.SubItems.Add(delimStr & "'" & number & "'")
                        End If
                        read = True
                        i = ctr2 - 1
                        neg = False
                    End If
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    If neg = True Then
                        objList.SubItems.Add(delimStr & "'~" & number & "'")
                    Else
                        objList.SubItems.Add(delimStr & "'" & number & "'")
                    End If
                    read = True
                    i = ctr1 - 1
                    neg = False
                End If
            End If
            'END NG digit

            '-----------------IDENTIFIER
            If sc(i) = "$" Then
                Dim ident As String = "$"
                If Char.IsLower(sc(i + 1)) Then
                    ident = ident + sc(i + 1)
                    Dim ctr1 As Integer = i + 2
                    Dim length As Integer = 1
                    While ctr1 < sourcecode.Length
                        If (Char.IsLower(sc(ctr1)) Or Char.IsDigit(sc(ctr1)) Or Char.IsUpper(sc(ctr1)) Or sc(ctr1) = "_") And length < 9 Then
                            ident = ident + sc(ctr1)
                            ctr1 += 1
                            length += 1
                        Else
                            Exit While
                        End If
                    End While



                    If sc(ctr1) = " " Or sc(ctr1) = "," Or sc(ctr1) = "\" _
                    Or sc(ctr1) = "]" Or sc(ctr1) = "[" Or sc(ctr1) = "+" Or sc(ctr1) = "-" Or sc(ctr1) = "^" _
                    Or sc(ctr1) = "*" Or sc(ctr1) = "/" Or sc(ctr1) = "%" Or sc(ctr1) = "(" _
                    Or sc(ctr1) = "<" Or sc(ctr1) = ")" Or sc(ctr1) = ">" Or sc(ctr1) = "=" Or sc(ctr1) = "!" Or sc(ctr1) = ":" Or Not inArray(sc(ctr1), delimsymbol, 95) Then
                        symbolCtr += 1
                        tokens = New Tokens
                        tokens.setToken("id")
                        tokens.setLexeme("identifier")
                        tokens.setAttrib("identifier")
                        tokens.setLine(line)
                        tokenstream.Add(tokens)
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(ident)
                        objList.SubItems.Add("identifier")
                        objList.SubItems.Add("identifier" & idnum)
                        idnum += 1
                        read = True
                        i = ctr1 - 1
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'" & ident & "'")
                        read = True
                        i = ctr1 - 1
                    End If
                Else
                    '$
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(delimStr & "'" & ident & "'")
                    read = True
                End If
            End If
            'END NG $

            If Microsoft.VisualBasic.AscW(sc(i)) = 10 Then
                symbolCtr += 1
                'tokens.Add("")
                objList = dGridLexi.Items.Add(symbolCtr)
                objList.SubItems.Add(line)
                objList.SubItems.Add("newline")
                objList.SubItems.Add("newline")
                objList.SubItems.Add("")
                line += 1
                read = True
            End If

            If Char.IsWhiteSpace(sc(i)) Then
                read = True
            End If

            If Not (read) Then
                If Char.IsLetter(sc(i)) Or sc(i) = "`" Or sc(i) = "$" Or sc(i) = "?" Then
                    Dim x As Integer = i
                    Dim unid As String = ""
                    While x < sourcecode.Length
                        If Char.IsLetter(sc(x)) Or sc(x) = "`" Or sc(x) = "$" Or sc(x) = "?" Then
                            unid = unid + sc(x)
                            x += 1
                        Else
                            Exit While
                        End If
                    End While

                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("Undefined lexeme -->" & unid)
                    i = x - 1
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("Undefined character -->" & sc(i))
                End If
            End If


            i += 1 'LAGING NAGMOMOVE NG 1 CHAR
            'MessageBox.Show("sc(i)= " & sc & " i= " & i)
        End While

        ' END NG LEXICAL
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAna.Click
        ErrorText.Clear()
        ErrorText.BackColor = Color.SteelBlue
        dGridError.BackColor = Color.SteelBlue
        dGridLexi.BackColor = Color.SteelBlue
        dGridSemantic.BackColor = Color.SteelBlue

        lexinew()
        'syntaxana()
        'identifierList()
        'semantic()
        'If dGridError.Items.Count = 0 Then
        '    translate()
        '    output()
        'End If
        If dGridError.Items.Count = 0 Then
            Dim ctr = dGridLexi.Items.Count - 1
            Dim result As String = ""
            'For i = 1 To ctr
            '    tokens += dGridLexi.SelectedItems(i).ToString
            'Next

            'For i As Integer = 0 To dGridLexi.Items.Count - 1
            '    tokens.Add(dGridLexi.Items.Item(i).Text())
            'Next


            Dim syntaxana As New SyntaxInitializer
            result = syntaxana.Start(tokenDump(tokenstream))
            'MessageBox.Show(result, "Result")

            ErrorText.Text = "Syntax Result: " & vbCrLf & result
            '    MessageBox.Show(result, "Result")

        End If


    End Sub
    Public Function tokenDump(ByVal token_stream As List(Of Tokens)) As List(Of SyntaxInitializer.Tokens)
        Dim tokenValues As New List(Of SyntaxInitializer.Tokens)
        Dim tokenValue As New SyntaxInitializer.Tokens
        For Each t As Tokens In token_stream
            tokenValue = New SyntaxInitializer.Tokens
            tokenValue.setToken(t.getToken)
            tokenValue.setLexeme(t.getLexeme)
            tokenValue.setAttrib(t.getAttrib)
            tokenValue.setLine(t.getLine)
            tokenValues.Add(tokenValue)
        Next
        Return tokenValues
    End Function

    Private Sub semantic()
        Dim dtype(4) As String
        dtype(0) = "newt"
        dtype(1) = "duck"
        dtype(2) = "bull"
        dtype(3) = "starling"

        Dim k As Integer = 0
        Dim isMane As Boolean = False
        Dim errCtr As Integer = 0
        Dim symbolCtr As Integer = 0
        Dim isStork As Boolean = False
        Dim isFunction As Boolean = False

        While k < dGridLexi.Items.Count
            If setokee(k) = "stork" Then
                isStork = True
            End If

            If setokee(k) = "mane" Then
                isStork = False
                isMane = True
            End If

            If setokee(k) = "opsymbol" Then
                symbolCtr += 1
            End If

            If setokee(k) = "clsymbol" Then
                symbolCtr -= 1
            End If

            If setokee(k) = "identifier" Then
                Dim kawntctr As Integer = 0
                Dim identifier As String = dGridLexi.Items.Item(k).SubItems(2).Text() 'name ng id sa lextable @zootopia
                Dim ctr As Integer = 0
                Dim curind As Integer

                If dGridIden.Items.Count > 1 Then
                    For index As Integer = 0 To dGridIden.Items.Count - 1
                        If dGridIden.Items.Item(index).SubItems(1).Text() = identifier Then 'kung nasa dGridIden yung @zootopia
                            curind = index
                            Exit For
                        End If
                    Next

                    For index As Integer = curind + 1 To dGridIden.Items.Count - 1
                        If identifier = dGridIden.Items.Item(index).SubItems(1).Text() Then 'kung nasa dGridIden yung @zootopia
                            ctr += 1
                        End If
                        If ctr >= 1 Then
                            Exit For
                        End If
                    Next

                    If ctr >= 1 Then
                        Dim x As Integer
                        x = k
                        While setokee(x) <> "newline"
                            x -= 1
                        End While

                        If setokee(x + 1) = "newt" Or setokee(x + 1) = "starling" Or setokee(x + 1) = "duck" Or setokee(x + 1) = "bull" Then
                            kawntctr += 1
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(identifier + " -Multiple declaration of variable")
                        End If
                    End If

                End If

                '========================================================================
                Dim identifier2 As String = dGridLexi.Items.Item(k).SubItems(2).Text() 'name ng id sa lextable @zootopia
                Dim ctr2 As Integer = 0
                For index As Integer = 0 To dGridIden.Items.Count - 1
                    If identifier2 = dGridIden.Items.Item(index).SubItems(1).Text Then 'kung nasa dGridIden yung @zootopia
                        ctr2 += 1
                    End If
                Next

                If dGridBoard.Items.Count > 0 Then
                    For index As Integer = 0 To dGridBoard.Items.Count - 1
                        If identifier2 = dGridBoard.Items.Item(index).SubItems(0).Text Then 'kung nasa dGridIden yung @zootopia
                            ctr2 += 1
                        End If
                    Next
                End If

                If ctr2 < 1 Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add(identifier2 + " -Undeclared variable or stork(structure)")
                End If
                'GoTo boarde
                '=========================================================================
                Dim identifier3 As String = dGridLexi.Items.Item(k).SubItems(2).Text() 'name ng id sa lextable @zootopia
                Dim ctr3 As Integer = 0
                Dim cur As Integer

                For index As Integer = 0 To dGridIden.Items.Count - 1
                    If identifier3 = dGridIden.Items.Item(index).SubItems(1).Text Then 'kung nasa dGridIden yung @zootopia
                        ctr3 += 1
                    End If
                Next

                For index As Integer = 0 To dGridIden.Items.Count - 1
                    If identifier3 = dGridIden.Items.Item(index).SubItems(1).Text Then 'kung nasa dGridIden yung @zootopia
                        cur = index
                    End If
                Next

                If ctr3 > 0 Then
                    Dim ctr4 As Integer = 0
                    For index As Integer = 0 To dGridLexi.Items.Count - 1
                        If identifier3 = dGridLexi.Items.Item(index).SubItems(2).Text Then 'kung nasa dGridIden yung @zootopia
                            ctr4 += 1
                        End If
                    Next

                    If dGridBoard.Items.Count > 0 Then
                        For index As Integer = 0 To dGridBoard.Items.Count - 1
                            If identifier3 = dGridBoard.Items.Item(index).SubItems(0).Text Then 'kung nasa dGridIden yung @zootopia
                                ctr4 += 2
                            End If
                        Next
                    End If

                    If ctr4 < 2 And dGridIden.Items.Item(cur).SubItems(9).Text <> "stork" Then
                        errCtr += 1
                        objList = dGridSemantic.Items.Add(errCtr)
                        objList.SubItems.Add(selinee(k))
                        objList.SubItems.Add(identifier3 + " -Unused variable")
                    End If
                End If
                '==============================================================================
                Dim identifier4 As String = dGridLexi.Items.Item(k).SubItems(2).Text() 'name ng id sa lextable @zootopia

                Dim declCount As Integer = 0
                Dim declCtr As Integer = k
                While Not (setokee(declCtr) = ":" Or setokee(declCtr) = "newline" Or inArray(setokee(k), dtype, 4))
                    If setokee(declCtr) = "at" Then
                        declCount += 1
                    End If
                    declCtr -= 1
                End While

                If declCount > 0 Then   'if declaration
                    Dim c As Integer
                    For index As Integer = 0 To dGridIden.Items.Count - 1
                        If dGridIden.Items.Item(index).SubItems(1).Text() = identifier4 Then
                            c = index
                        End If
                    Next

                    Dim curType = dGridIden.Items.Item(c).SubItems(5).Text()
                    If setokee(k + 1) = "assgnOp" Then  'para sa variable
                        Dim datatype As String = dGridIden.Items.Item(c).SubItems(2).Text()
                        Dim val_data As String = dGridIden.Items.Item(c).SubItems(4).Text()
                        Dim value As String = dGridIden.Items.Item(c).SubItems(3).Text()
                        If datatype = "newt" Then
                            If Not (val_data = "newtlit" Or val_data = "null") Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(value + " -Invalid value for data type " + datatype)
                            End If
                        ElseIf datatype = "starling" Then
                            If Not (val_data = "starlinglit" Or val_data = "null") Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(value + " -Invalid value for data type " + datatype)
                            End If
                        ElseIf datatype = "bull" Then
                            If Not (val_data = "bullLit" Or val_data = "null") Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(value + " -Invalid value for data type " + datatype)
                            End If
                        ElseIf datatype = "duck" Then
                            If Not (val_data = "ducklit" Or val_data = "newtlit" Or val_data = "null") Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(value + " -Invalid value for data type " + datatype)
                            End If
                        End If
                    ElseIf setokee(k + 1) = "oppar" Then    'para sa function
                        'MessageBox.Show("line= " & selinee(k))
                        Dim kawnt As Integer = k + 1
                        While setokee(kawnt) <> "newline"
                            If setokee(kawnt) = "clpar" Then
                                Exit While
                            End If
                            kawnt += 1
                        End While

                        If setokee(kawnt + 1) = ":" Then
                            Dim datatype2 As String = dGridIden.Items.Item(c).SubItems(2).Text()
                            Dim count As Integer = k + 1
                            Dim counter As Integer = 0
                            While Not setokee(count) = ":"
                                If Not (setokee(count) = datatype2 Or setokee(count) = "," Or setokee(count) = "oppar" Or setokee(count) = "clpar") Then
                                    counter += 1
                                End If
                                count += 1
                            End While
                            If counter >= 1 Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Data Type of parameter must be same with the data type of the function used.")
                            End If
                        Else 'PANG FUNCTION DEFINITION
                            Dim datatype2 As String = dGridIden.Items.Item(c).SubItems(2).Text()
                            'MessageBox.Show(datatype2 & "Sa Else")
                            Dim count As Integer = k + 1
                            Dim counter As Integer = 0
                            Dim counter2 As Integer = 0
                            While Not setokee(count) = "clpar"
                                'MessageBox.Show(setokee(count))
                                If Not (setokee(count) = datatype2 Or setokee(count) = "," Or setokee(count) = "at" Or setokee(count) = "identifier" Or setokee(count) = "opsquare" Or setokee(count) = "clsquare" Or setokee(count) = "oppar" Or setokee(count) = "clpar") Then
                                    counter += 1
                                End If
                                count += 1
                            End While
                            If counter >= 1 Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Data Type of parameter must be the same with the function content.")
                            End If

                            count = k + 1
                            If setokee(k + 2) <> "clpar" Then
                                While setokee(count) <> "clpar"
                                    If setokee(count) = "," Then
                                        counter2 += 1
                                    End If
                                    count += 1
                                End While

                                counter2 += 1
                                'MessageBox.Show(cou)
                                If dGridIden.Items.Count > 0 Then
                                    Dim param As String = dGridIden.Items.Item(c).SubItems(8).Text()
                                    If Int(param) <> counter2 Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("No. of parameter in written function is not equal with function declaration.")
                                    End If
                                End If
                            End If
                        End If

                    ElseIf setokee(k + 1) = "opsquare" Then
                        Dim currType As String = dGridIden.Items.Item(c).SubItems(5).Text() 'array1/array2
                        If currType = "array1" Then
                            Dim arrSize As String = dGridIden.Items.Item(c).SubItems(7).Text
                            If Char.IsDigit(arrSize) Then
                                If Int(arrSize) < 1 Or Int(arrSize) > 10 Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Size should be greater than 0 or less than 100")
                                End If
                            Else
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Size must be a newtlit or identifier with data type of 'newt'")
                            End If
                        ElseIf currType = "array2" Then
                            Dim arrSize As String = dGridIden.Items.Item(c).SubItems(7).Text
                            Dim arrSize2 As String = dGridIden.Items.Item(c).SubItems(10).Text
                            If Char.IsDigit(arrSize) Then
                                If Int(arrSize) < 1 Or Int(arrSize) > 10 Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Size must be greater than 0 or less than 10")
                                End If
                            Else
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Size must be a newtlit or identifier with data type of 'newt'")
                            End If

                            If Char.IsDigit(arrSize2) Then
                                If Int(arrSize2) < 1 Or Int(arrSize2) > 10 Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Size must be greater than 0 or less than 10")
                                End If
                            Else
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Size must be a newtlit or identifier with data type of 'newt'")
                            End If
                        End If



                        If setokee(k + 3) = "assgnOp" Or setokee(k + 4) = "assgnOp" Or setokee(k + 5) = "assgnOp" Or setokee(k + 6) = "assgnOp" Or setokee(k + 7) = "assgnOp" Then
                            Dim arrdtype As String = dGridIden.Items.Item(c).SubItems(4).Text()
                            Dim arrType As String = dGridIden.Items.Item(c).SubItems(5).Text()
                            Dim arrcount As Integer = k
                            Dim arrctr As Integer = 0
                            Dim elemCtr As Integer = k + 4
                            Dim commaCtr As Integer = 0
                            Dim parCtr As Integer = 0

                            While setokee(arrcount) <> "assgnOp"
                                arrcount += 1
                            End While

                            While Not (setokee(arrcount) = ":" Or setokee(arrcount) = "clcurly")
                                If Not (setokee(arrcount) = "assgnOp" Or setokee(arrcount) = "opcurly" Or setokee(arrcount) = "clcurly" Or setokee(arrcount) = "oppar" _
                                    Or setokee(arrcount) = "," Or setokee(arrcount) = "clpar" Or setokee(arrcount) = arrdtype) Then
                                    arrctr += 1
                                End If
                                arrcount += 1
                            End While

                            If arrctr > 0 Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Data Type of an element should be the same with the array content.")
                            End If

                            If arrType = "array1" Then
                                While Not (setokee(elemCtr) = ":" Or setokee(elemCtr) = "clcurly")
                                    If setokee(elemCtr) = "," Then
                                        commaCtr += 1
                                    End If
                                    elemCtr += 1
                                End While

                                Dim arrSize1 As String = ""
                                If Not dGridIden.Items.Item(c).SubItems(7).Text() = "null" Then
                                    arrSize1 = dGridIden.Items.Item(c).SubItems(7).Text()
                                End If

                                If commaCtr >= Int(arrSize1) Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("#no. of elem(s) is not within the size of an array.")
                                End If

                            ElseIf arrType = "array2" Then
                                While Not (setokee(elemCtr) = ":" Or setokee(elemCtr) = "clcurly")
                                    If setokee(elemCtr) = "," Then
                                        commaCtr += 1
                                    ElseIf setokee(elemCtr) = "oppar" Then
                                        parCtr += 1
                                    End If
                                    elemCtr += 1
                                End While

                                Dim arrSize1 As String = dGridIden.Items.Item(c).SubItems(7).Text()
                                Dim arrSize2 As String = dGridIden.Items.Item(c).SubItems(10).Text()
                                Dim totalSize As String = Int(arrSize1) * Int(arrSize2)

                                If commaCtr >= totalSize Or commaCtr > 100 Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("#no. of column(s) is not within the size of an array.")
                                End If

                                If parCtr > arrSize1 Or parCtr > 10 Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("#no. of row(s) is not around the size of an array.")
                                End If

                            End If

                        End If
                    End If

                ElseIf declCount = 0 Then   'di declaration

                    If setokee(k) = "identifier" Then
                        'INDEX  out of bounds
                        If dGridIden.Items.Count > 0 Then
                            Dim setID As String = dGridLexi.Items.Item(k).SubItems(2).Text()
                            Dim d1 As Integer
                            For index As Integer = 0 To dGridIden.Items.Count - 1
                                If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then
                                    d1 = index
                                End If
                            Next

                            Dim setType As String = dGridIden.Items.Item(d1).SubItems(5).Text
                            If setType = "array1" Then
                                Dim getSize As String = dGridIden.Items.Item(d1).SubItems(7).Text
                                If setokee(k + 1) = "newtlit" Then
                                    Dim curIndex As String = dGridLexi.Items.Item(k).SubItems(2).Text
                                    ' MessageBox.Show(curIndex & " " & getSize)
                                    If curIndex >= getSize Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Index is out of bounds")
                                    End If
                                End If
                                '-------------------------------------------------------------------
                                'No. of parameter
                            ElseIf setType = "function" Then
                                Dim getParam As String = dGridIden.Items.Item(d1).SubItems(8).Text
                                Dim getDtype As String = dGridIden.Items.Item(d1).SubItems(2).Text
                                Dim counta As Integer = k + 1
                                Dim paramCtr As Integer = 0

                                If setokee(k + 1) = "oppar" Then
                                    While Not setokee(counta) = "clpar"
                                        If setokee(counta) = "," Then
                                            paramCtr += 1
                                        End If
                                        counta += 1
                                    End While

                                    paramCtr += 1

                                    If getDtype <> "viper" Then
                                        If paramCtr < Int(getParam) Or paramCtr > Int(getParam) Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("No. of param is not equal to the declared param")
                                        End If
                                    End If

                                    'MessageBox.Show("paramCtr= " & paramCtr)
                                    '------------------------------------------------------------------
                                    Dim counta2 As Integer = k + 1

                                    While Not setokee(counta2) = "clpar"
                                        If getDtype = "newt" Then
                                            If setokee(counta2) = "identifier" Then
                                                Dim currID As String = dGridLexi.Items.Item(counta2).SubItems(2).Text() 'c
                                                Dim counta3 As Integer 'c
                                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                                    If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                                        counta3 = index 'c
                                                    End If
                                                Next

                                                Dim currDType As String = dGridIden.Items.Item(counta3).SubItems(2).Text() 'c
                                                If currDType = "duck" Or currDType = "bull" Or currDType = "starling" Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                                End If
                                            ElseIf setokee(counta2) = "ducklit" Or setokee(counta2) = "bullLit" Or setokee(counta2) = "starlinglit" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                            End If

                                        ElseIf getDtype = "duck" Then
                                            If setokee(counta2) = "identifier" Then
                                                Dim currID As String = dGridLexi.Items.Item(counta2).SubItems(2).Text() 'c
                                                Dim counta3 As Integer 'c
                                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                                    If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                                        counta3 = index 'c
                                                    End If
                                                Next

                                                Dim currDType As String = dGridIden.Items.Item(counta3).SubItems(2).Text() 'c
                                                If currDType = "newt" Or currDType = "bull" Or currDType = "starling" Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                                End If
                                            ElseIf setokee(counta2) = "newtlit" Or setokee(counta2) = "bullLit" Or setokee(counta2) = "starlinglit" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                            End If

                                        ElseIf getDtype = "bull" Then
                                            If setokee(counta2) = "identifier" Then
                                                Dim currID As String = dGridLexi.Items.Item(counta2).SubItems(2).Text() 'c
                                                Dim counta3 As Integer 'c
                                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                                    If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                                        counta3 = index 'c
                                                    End If
                                                Next

                                                Dim currDType As String = dGridIden.Items.Item(counta3).SubItems(2).Text() 'c
                                                If currDType = "duck" Or currDType = "newt" Or currDType = "starling" Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                                End If
                                            ElseIf setokee(counta2) = "ducklit" Or setokee(counta2) = "newtlit" Or setokee(counta2) = "starlinglit" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                            End If
                                        ElseIf getDtype = "starling" Then
                                            If setokee(counta2) = "identifier" Then
                                                Dim currID As String = dGridLexi.Items.Item(counta2).SubItems(2).Text() 'c
                                                Dim counta3 As Integer 'c
                                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                                    If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                                        counta3 = index 'c
                                                    End If
                                                Next

                                                Dim currDType As String = dGridIden.Items.Item(counta3).SubItems(2).Text() 'c
                                                If currDType = "duck" Or currDType = "bull" Or currDType = "newt" Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                                End If
                                            ElseIf setokee(counta2) = "ducklit" Or setokee(counta2) = "bullLit" Or setokee(counta2) = "newtlit" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(dGridLexi.Items.Item(counta2).SubItems(2).Text() & " - Invalid data type for param")
                                            End If
                                        End If
                                        counta2 += 1
                                    End While
                                Else
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add(setID & " - is used not as a function")

                                    Dim x As Integer = k + 1
                                    While setokee(x) <> "newline"
                                        x += 1
                                    End While
                                    k = x
                                End If

                                'wawalain yung to
                                '------------------------------------------------------------------
                            ElseIf setokee(k + 1) = "at" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim boaId As String = dGridLexi.Items.Item(k).SubItems(2).Text()
                                    Dim match As Integer
                                    Dim isMember As Boolean = False
                                    Dim isStor As Boolean = False
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = boaId Then 'c
                                            match = index 'c
                                        End If
                                    Next

                                    Dim typee As String = dGridIden.Items.Item(match).SubItems(5).Text

                                    If typee <> "stork" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(boaId & " - is not stork_name")
                                    Else
                                        isStor = True
                                    End If

                                    If isStor = True Then
                                        Dim boaObj As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text()
                                        For index As Integer = 0 To dGridBoard.Items.Count - 1
                                            If dGridBoard.Items.Item(index).SubItems(0).Text() = boaObj Then 'c
                                                isMember = True
                                            End If
                                        Next

                                        If isMember = True Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add(boaObj & " - identifier is already used a stork_name")
                                        Else
                                            objList = dGridBoard.Items.Add(boaObj)
                                            objList.SubItems.Add(boaId)
                                        End If
                                    End If


                                End If

                            End If
                            'END SA IF-FUNCTION
                        End If
                        'END IF MAY LAMAN YUNG dGridIden
                    End If
                    'END IF ID YUNG SETOKEE(K) PARA SA DECLARATION
                    Dim identifier5 As String = dGridLexi.Items.Item(k).SubItems(2).Text()

                    Dim d As Integer
                    For index As Integer = 0 To dGridIden.Items.Count - 1
                        If dGridIden.Items.Item(index).SubItems(1).Text() = identifier5 Then
                            d = index
                        End If
                    Next

                    Dim curIDType As String = dGridIden.Items.Item(d).SubItems(5).Text()

                    If setokee(k + 1) = "assgnOp" And (setokee(k + 3) = "," Or setokee(k + 3) = ":") Then      'para sa variable
                        If Not curIDType = "constant" Then
                            Dim idDType As String = ""
                            Dim idType As String = ""
                            Dim curID As String = ""

                            If setokee(k + 2) = "identifier" Then
                                curID = dGridLexi.Items.Item(k + 2).SubItems(2).Text()  '@zootopia
                                Dim e As Integer
                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                    If dGridIden.Items.Item(index).SubItems(1).Text() = curID Then
                                        e = index
                                    End If
                                Next
                                If dGridIden.Items.Item(e).SubItems(4).Text() = "null" Then
                                    idDType = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If idDType = "newt" Then
                                        idType = "newtlit"
                                    ElseIf idDType = "bull" Then
                                        idType = "bullLit"
                                    ElseIf idDType = "duck" Then
                                        idType = "ducklit"
                                    ElseIf idDType = "starling" Then
                                        idType = "starlinglit"
                                    End If
                                Else
                                    idType = dGridIden.Items.Item(e).SubItems(4).Text()
                                End If
                            Else
                                idType = dGridLexi.Items.Item(k + 2).SubItems(3).Text()
                            End If

                            Dim curDType As String = ""
                            Dim curType As String = ""
                            If dGridIden.Items.Item(d).SubItems(4).Text() = "null" Then
                                curDType = dGridIden.Items.Item(d).SubItems(2).Text()
                                If curDType = "newt" Then
                                    curType = "newtlit"
                                ElseIf curDType = "bull" Then
                                    curType = "bullLit"
                                ElseIf curDType = "duck" Then
                                    curType = "ducklit"
                                ElseIf curDType = "starling" Then
                                    curType = "starlinglit"
                                End If
                            Else
                                curType = dGridIden.Items.Item(d).SubItems(4).Text()
                            End If
                            '-------------------------------------
                            'TYPE MISMATCH SA ASSIGNMENT NG VALUE SA VARIABLE
                            If Not curType = idType Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add("Type mismatch.") 'assigning ng value sa var
                            End If

                            If setokee(k + 2) = "identifier" Then
                                Dim se1Type As String = dGridIden.Items.Item(d).SubItems(5).Text 'if variable talaga yung 1st
                                Dim fDType As String = dGridIden.Items.Item(d).SubItems(2).Text
                                Dim sID As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text()  '@zootopia
                                Dim sDType As String = ""
                                Dim f As Integer
                                For index As Integer = 0 To dGridIden.Items.Count - 1
                                    If dGridIden.Items.Item(index).SubItems(1).Text() = sID Then
                                        f = index
                                    End If
                                Next
                                Dim se2Type As String = dGridIden.Items.Item(f).SubItems(5).Text 'if variable talaga yung 2nd
                                sDType = dGridIden.Items.Item(f).SubItems(2).Text

                                'MessageBox.Show("Type1= " & se1Type & " ,Type2= " & se2Type)

                                If se1Type <> "variable" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add(se1Type & " " & dGridIden.Items.Item(d).SubItems(1).Text & " is used as a variable")
                                End If

                                If se2Type <> "variable" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add(se2Type & " " & dGridIden.Items.Item(f).SubItems(1).Text & " is used as a variable")
                                End If
                            End If


                            '--------------------------------------------------------------------
                        Else
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add("Cannot change value for set")
                        End If
                    ElseIf setokee(k + 1) = "assgnOp" And setokee(k + 2) = "identifier" Then
                        'MessageBox.Show("assign tayo")
                        Dim fDType As String = dGridIden.Items.Item(d).SubItems(2).Text
                        Dim sID As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text()  '@zootopia
                        Dim sDType As String = ""
                        Dim f As Integer
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = sID Then
                                f = index
                            End If
                        Next
                        sDType = dGridIden.Items.Item(f).SubItems(2).Text

                        'MessageBox.Show("Type1= " & se1Type & " ,Type2= " & se2Type)
                        If fDType <> sDType Then
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                        End If
                        '------------

                        '-----------------------------------------------------------------
                        'MATH EXP SA TEXT OR FLAG
                    ElseIf setokee(k + 2) = "increOp" Or setokee(k + 2) = "decreOp" Or setokee(k + 3) = "mathOp" _
                         Or setokee(k + 3) = "decreOp" Or setokee(k + 3) = "increOp" Then

                        Dim curDType = dGridIden.Items.Item(d).SubItems(2).Text()
                        If curDType = "starling" Or curDType = "bull" Then
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add("Type mismatch. Cannot assign math Op to the variable with '" & curDType & "' data type.")
                        End If
                        '--------------------------------------------------------------------
                        'PARA SA ARRAY
                    ElseIf curIDType = "array1" Then
                        If setokee(k + 2) = "newtlit" Or setokee(k + 2) = "identifier" Then
                            Dim setID As String = dGridLexi.Items.Item(k).SubItems(2).Text()
                            Dim d1 As Integer
                            For index As Integer = 0 To dGridIden.Items.Count - 1
                                If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then
                                    d1 = index
                                End If
                            Next
                            'INDEX OUT OF BOUNDS
                            If dGridIden.Items.Count > 0 Then
                                Dim setType As String = dGridIden.Items.Item(d1).SubItems(5).Text
                                Dim getSize As String = dGridIden.Items.Item(d1).SubItems(7).Text
                                If setType = "array1" Then
                                    If setokee(k + 2) = "newtlit" Then
                                        Dim curIndex As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text
                                        If Int(curIndex) >= Int(getSize) Or Int(curIndex) < 0 Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("Index is out of bounds ")
                                        End If
                                    ElseIf setokee(k + 2) = "identifier" Then
                                        Dim sizeID As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text()
                                        Dim d2 As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text() = sizeID Then
                                                d2 = index
                                            End If
                                        Next

                                        Dim sizeDType As String = dGridIden.Items.Item(d2).SubItems(2).Text
                                        If Not sizeDType = "newt" Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("Can't assign variable " & sizeID & " as size of an array")
                                        Else
                                            Dim sizeVal As String = dGridIden.Items.Item(d2).SubItems(3).Text
                                            If sizeVal = "null" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(sizeID & " - No value is assigned before using as size of an array")
                                            Else
                                                If Int(sizeVal) >= Int(getSize) Or Int(sizeVal) < 0 Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add("Index is out of bounds.")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            'END IF MAY LAMAN YUNG dGridIden
                        End If

                        If setokee(k + 4) = "assgnOp" Then
                            Dim daType As String = dGridIden.Items.Item(d).SubItems(2).Text
                            If daType = "newt" Then
                                If setokee(k + 5) = "ducklit" Or setokee(k + 5) = "bullLit" Or setokee(k + 5) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 5) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 5).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "duck" Then
                                If setokee(k + 5) = "newtlit" Or setokee(k + 5) = "bullLit" Or setokee(k + 5) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 5) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 5).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "bull" Then
                                If setokee(k + 5) = "ducklit" Or setokee(k + 5) = "newtlit" Or setokee(k + 5) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 5) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 5).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "starling" Then
                                If setokee(k + 5) = "ducklit" Or setokee(k + 5) = "bullLit" Or setokee(k + 5) = "newtlit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 5) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 5).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            End If
                        End If
                    ElseIf curIDType = "array2" Then
                        If setokee(k + 2) = "newtlit" Or setokee(k + 2) = "identifier" Then
                            Dim setID As String = dGridLexi.Items.Item(k).SubItems(2).Text()
                            Dim d1 As Integer
                            For index As Integer = 0 To dGridIden.Items.Count - 1
                                If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then
                                    d1 = index
                                End If
                            Next
                            'INDEX OUT OF BOUNDS
                            If dGridIden.Items.Count > 0 Then
                                Dim setType As String = dGridIden.Items.Item(d1).SubItems(5).Text
                                Dim getSize1 As String = dGridIden.Items.Item(d1).SubItems(7).Text
                                Dim getSize2 As String = dGridIden.Items.Item(d1).SubItems(10).Text
                                If setType = "array2" Then
                                    If setokee(k + 2) = "newtlit" Then
                                        Dim curIndex As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text
                                        If Int(curIndex) >= Int(getSize1) Or Int(curIndex) < 0 Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("1st Index is out of bounds")
                                        End If
                                    ElseIf setokee(k + 2) = "identifier" Then
                                        Dim sizeID As String = dGridLexi.Items.Item(k + 2).SubItems(2).Text()
                                        Dim d2 As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text() = sizeID Then
                                                d2 = index
                                            End If
                                        Next

                                        Dim sizeDType As String = dGridIden.Items.Item(d2).SubItems(2).Text
                                        If Not sizeDType = "newt" Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("Can't assign variable " & sizeID & " as 1st index of array")
                                        Else
                                            Dim sizeVal As String = dGridIden.Items.Item(d2).SubItems(3).Text
                                            If sizeVal = "null" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(sizeID & " - No value is assigned before using as 1st index of array")
                                            Else
                                                If Int(sizeVal) >= Int(getSize1) Or Int(sizeVal) < 0 Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add("1st Index is out of bounds.")
                                                End If
                                            End If
                                        End If
                                    End If

                                    If setokee(k + 5) = "newtlit" Then
                                        Dim curIndex As String = dGridLexi.Items.Item(k + 5).SubItems(2).Text
                                        If Int(curIndex) >= Int(getSize2) Or Int(curIndex) < 0 Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("2nd Index is out of bounds ")
                                        End If
                                    ElseIf setokee(k + 5) = "identifier" Then
                                        Dim sizeID As String = dGridLexi.Items.Item(k + 5).SubItems(2).Text()
                                        Dim d2 As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text() = sizeID Then
                                                d2 = index
                                            End If
                                        Next

                                        Dim sizeDType As String = dGridIden.Items.Item(d2).SubItems(2).Text
                                        If Not sizeDType = "newt" Then
                                            errCtr += 1
                                            objList = dGridSemantic.Items.Add(errCtr)
                                            objList.SubItems.Add(selinee(k))
                                            objList.SubItems.Add("Can't assign var " & sizeID & " as 2nd index of array")
                                        Else
                                            Dim sizeVal As String = dGridIden.Items.Item(d2).SubItems(3).Text
                                            If sizeVal = "null" Then
                                                errCtr += 1
                                                objList = dGridSemantic.Items.Add(errCtr)
                                                objList.SubItems.Add(selinee(k))
                                                objList.SubItems.Add(sizeID & " - No value is assigned before using as 2nd index of array")
                                            Else
                                                If Int(sizeVal) >= Int(getSize2) Or Int(sizeVal) < 0 Then
                                                    errCtr += 1
                                                    objList = dGridSemantic.Items.Add(errCtr)
                                                    objList.SubItems.Add(selinee(k))
                                                    objList.SubItems.Add(" 2nd Index is out of bounds.")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            'END IF MAY LAMAN YUNG identlist/table
                        End If

                        If setokee(k + 7) = "assgnOp" Then
                            Dim daType As String = dGridIden.Items.Item(d).SubItems(2).Text
                            If daType = "newt" Then
                                If setokee(k + 8) = "ducklit" Or setokee(k + 8) = "bullLit" Or setokee(k + 8) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 8) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 8).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "duck" Then
                                If setokee(k + 8) = "newtlit" Or setokee(k + 8) = "bullLit" Or setokee(k + 8) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 8) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 8).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "bull" Then
                                If setokee(k + 8) = "ducklit" Or setokee(k + 8) = "newtlit" Or setokee(k + 8) = "starlinglit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 8) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 8).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            ElseIf daType = "starling" Then
                                If setokee(k + 8) = "ducklit" Or setokee(k + 8) = "bullLit" Or setokee(k + 8) = "newtlit" Then
                                    errCtr += 1
                                    objList = dGridSemantic.Items.Add(errCtr)
                                    objList.SubItems.Add(selinee(k))
                                    objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                ElseIf setokee(k + 8) = "identifier" Then
                                    Dim cureID = dGridLexi.Items.Item(k + 8).SubItems(2).Text()  '@zootopia
                                    Dim e As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = cureID Then
                                            e = index
                                        End If
                                    Next

                                    Dim getDT As String = dGridIden.Items.Item(e).SubItems(2).Text()
                                    If getDT <> daType Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add("Type mismatch for assigning value to " & dGridIden.Items.Item(d).SubItems(1).Text)
                                    End If
                                End If
                            End If
                        End If

                    End If
                End If
            End If
            If setokee(k) = "mathOp" Then
                If setokee(k - 1) = "identifier" Then 'c
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 1).SubItems(2).Text() 'c
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next

                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'c
                        If currDType = "starling" Or currDType = "bull" Then 'c
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - Invalid for math expression") 'c
                        ElseIf currDType = "newt" Or currDType = "duck" Then
                            Dim currVal As String = dGridIden.Items.Item(counta).SubItems(3).Text()
                            If currVal = "null" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - No value is assigned before using in math expression")
                            End If

                        End If
                    End If
                ElseIf setokee(k - 1) = "starlinglit" Or setokee(k - 1) = "bullLit" Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - Invalid for math expression") 'c
                End If

                If setokee(k + 1) = "identifier" Then 'c
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text() 'c
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next

                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'c
                        If currDType = "starling" Or currDType = "bull" Then 'c
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Invalid for math expression") 'c
                        ElseIf currDType = "newt" Or currDType = "duck" Then
                            Dim currVal As String = dGridIden.Items.Item(counta).SubItems(3).Text()
                            If currVal = "null" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - No value is assigned before using in math expression")
                            End If
                        End If
                    End If
                ElseIf setokee(k + 1) = "starlinglit" Or setokee(k + 1) = "bullLit" Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Invalid for math expression") 'c
                End If
            End If

            If setokee(k) = "increOp" Or setokee(k) = "decreOp" Then
                If setokee(k - 1) = "identifier" Then 'c
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 1).SubItems(2).Text() 'c
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next

                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'c
                        If currDType = "starling" Or currDType = "bull" Or currDType = "duck" Then 'c
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " (" & currDType & ") - Invalid for increment/ decrement operation") 'c
                        ElseIf currDType = "newt" Then
                            Dim currVal As String = dGridIden.Items.Item(counta).SubItems(3).Text()
                            If currVal = "null" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - No value is assigned before using in increment/decrement operation")
                            End If
                        End If
                    End If
                ElseIf setokee(k - 1) = "starlinglit" Or setokee(k - 1) = "bullLit" Or setokee(k - 1) = "ducklit" Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - Invalid for increment/ decrement operation") 'c
                End If

                If setokee(k + 1) = "identifier" Then 'c
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text() 'c
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next

                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'c
                        If currDType = "starling" Or currDType = "bull" Or currDType = "duck" Then 'c
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " (" & currDType & ") - Invalid for increment/ decrement operation") 'c
                        ElseIf currDType = "newt" Then
                            Dim currVal As String = dGridIden.Items.Item(counta).SubItems(3).Text()
                            If currVal = "null" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k - 1).SubItems(2).Text() & " - No value is assigned before using in increment/decrement operation")
                            End If
                        End If
                    End If
                ElseIf setokee(k + 1) = "starlinglit" Or setokee(k + 1) = "bullLit" Or setokee(k - 1) = "ducklit" Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Invalid for increment/ decrement operation") 'c
                End If
            End If
            If setokee(k) = ".+" Then
                If dGridIden.Items.Count > 1 Then
                    Dim fId As String = dGridLexi.Items.Item(k - 1).SubItems(2).Text
                    Dim sId As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text
                    Dim fDtype As String = ""
                    Dim sDtype As String = ""
                    Dim cF, cS As Integer

                    For index As Integer = 0 To dGridIden.Items.Count - 1
                        If dGridIden.Items.Item(index).SubItems(1).Text() = fId Then 'c
                            cF = index 'c
                        End If
                    Next

                    For index As Integer = 0 To dGridIden.Items.Count - 1
                        If dGridIden.Items.Item(index).SubItems(1).Text() = sId Then 'c
                            cS = index 'c
                        End If
                    Next

                    fDtype = dGridIden.Items.Item(cF).SubItems(2).Text
                    If fDtype <> "starling" Then
                        errCtr += 1
                        objList = dGridSemantic.Items.Add(errCtr)
                        objList.SubItems.Add(selinee(k))
                        objList.SubItems.Add("Data type of " & fId & " should be 'starling(string)' for string operator")
                    End If

                    sDtype = dGridIden.Items.Item(cS).SubItems(2).Text
                    If sDtype <> "starling" Then
                        errCtr += 1
                        objList = dGridSemantic.Items.Add(errCtr)
                        objList.SubItems.Add(selinee(k))
                        objList.SubItems.Add("Data type of " & sId & " should be 'starling(string)' for string operator")
                    End If
                End If
                'end ng if may laman yung dGridIden
            End If
            If setokee(k) = "relOp2" Then
                If setokee(k - 1) = "identifier" Then 'VARIABLE
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 1).SubItems(2).Text() 'CHANGE
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'datatype ng k-?
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "newt" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "newtlit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "bull" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "newt" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "newtlit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "starling" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "newt" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "newtlit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        End If

                    End If
                ElseIf setokee(k - 1) = "clsquare" And setokee(k - 4) = "identifier" Then
                    '1d array
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 4).SubItems(2).Text() 'CHANGE
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'datatype ng k-?
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "newt" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "newtlit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "bull" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "newt" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "newtlit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "starling" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "newt" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "newtlit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        End If

                    End If
                ElseIf setokee(k - 1) = "clsquare" And setokee(k - 4) = "clsquare" And setokee(k - 7) = "identifier" Then
                    '2d array
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 7).SubItems(2).Text() 'CHANGE
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text() 'datatype ng k-?
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "newt" Or setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "newtlit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "bull" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "newt" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "newtlit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        ElseIf currDType = "starling" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "duck" Or setDType = "bull" Or setDType = "newt" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "ducklit" Or setokee(k + 1) = "bullLit" Or setokee(k + 1) = "newtlit" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for arguements should be the same for condition")
                            End If
                        End If

                    End If
                End If
            End If
            If setokee(k) = "relOp1" Then
                If setokee(k - 1) = "identifier" Then 'VARIABLE
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 1).SubItems(2).Text() 'CHANGE
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text()
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "bull" Or currDType = "starling" Then
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridIden.Items.Item(counta).SubItems(1).Text() & " - Data type for relational operation is invalid")
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If

                        End If

                    End If
                ElseIf setokee(k - 1) = "clsquare" And setokee(k - 4) = "identifier" Then
                    '1d array
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 4).SubItems(2).Text() 'CHANGE
                        Dim counta As Integer 'c
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text()
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "bull" Or currDType = "starling" Then
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridIden.Items.Item(counta).SubItems(1).Text() & " - Data type for relational operation is invalid")
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        End If
                    End If
                ElseIf setokee(k - 1) = "clsquare" And setokee(k - 4) = "clsquare" And setokee(k - 7) = "identifier" Then
                    '2dimen arr
                    If dGridIden.Items.Count > 0 Then
                        Dim currID As String = dGridLexi.Items.Item(k - 7).SubItems(2).Text()
                        Dim counta As Integer
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = currID Then 'c
                                counta = index 'c
                            End If
                        Next
                        Dim currDType As String = dGridIden.Items.Item(counta).SubItems(2).Text()
                        'MessageBox.Show(currDType)

                        If currDType = "newt" Then 'newt==
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "duck" Then
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then 'CHANGE
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                            End If
                        ElseIf currDType = "bull" Or currDType = "starling" Then
                            errCtr += 1
                            objList = dGridSemantic.Items.Add(errCtr)
                            objList.SubItems.Add(selinee(k))
                            objList.SubItems.Add(dGridIden.Items.Item(counta).SubItems(1).Text() & " - Data type for relational operation is invalid")
                            If setokee(k + 1) = "identifier" Then
                                If dGridIden.Items.Count > 0 Then
                                    Dim setID As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text()
                                    Dim setCtr As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text() = setID Then 'c
                                            setCtr = index 'c
                                        End If
                                    Next

                                    Dim setDType As String = dGridIden.Items.Item(setCtr).SubItems(2).Text()
                                    If setDType = "bull" Or setDType = "starling" Then
                                        errCtr += 1
                                        objList = dGridSemantic.Items.Add(errCtr)
                                        objList.SubItems.Add(selinee(k))
                                        objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid")
                                    End If
                                End If
                            ElseIf setokee(k + 1) = "bullLit" Or setokee(k + 1) = "starlinglit" Then
                                errCtr += 1
                                objList = dGridSemantic.Items.Add(errCtr)
                                objList.SubItems.Add(selinee(k))
                                objList.SubItems.Add(dGridLexi.Items.Item(k + 1).SubItems(2).Text() & " - Data type for relational operation is invalid.")
                            End If
                        End If

                    End If
                End If
            End If

            If setokee(k) = "hop" Then
                'MessageBox.Show("deport")
                Dim depDtype As String = ""
                Dim funcDtype As String = ""
                If setokee(k + 1) = "identifier" Then
                    Dim seId As String = dGridLexi.Items.Item(k + 1).SubItems(2).Text
                    Dim getID As Integer

                    If dGridIden.Items.Count > 0 Then
                        For index As Integer = 0 To dGridIden.Items.Count - 1
                            If dGridIden.Items.Item(index).SubItems(1).Text() = seId Then
                                getID = index
                            End If
                        Next
                    End If

                    depDtype = dGridIden.Items.Item(getID).SubItems(2).Text
                ElseIf setokee(k + 1) = "newtlit" Then
                    depDtype = "newt"
                ElseIf setokee(k + 1) = "ducklit" Then
                    depDtype = "duck"
                ElseIf setokee(k + 1) = "bullLit" Then
                    depDtype = "bull"
                ElseIf setokee(k + 1) = "starlinglit" Then
                    depDtype = "starling"
                End If

                'MessageBox.Show(depDtype)
                Dim dep As Integer = k
                While dep >= 0
                    If setokee(dep) = "clpar" And setokee(dep + 1) = "newline" Then
                        Exit While
                    Else
                        dep -= 1
                    End If
                End While

                Dim les As Integer = dep
                'MessageBox.Show(dep)
                While setokee(les) <> "oppar"
                    If setokee(les) = "newt" Or setokee(les) = "duck" Or setokee(les) = "bull" Or setokee(les) = "starling" Then
                        funcDtype = setokee(les)
                        Exit While
                    Else
                        les -= 1
                    End If
                End While

                'MessageBox.Show(funcDtype)

                If depDtype <> funcDtype Then
                    errCtr += 1
                    objList = dGridSemantic.Items.Add(errCtr)
                    objList.SubItems.Add(selinee(k))
                    objList.SubItems.Add("Data type of hop(return) value is not match.")
                End If
            End If



            k += 1
        End While

        'para sa errors
        Dim err As String = ""
        Dim err1 As String = ""
        Dim err2 As String = ""
        Dim err21 As String = ""
        Dim er1 As ListViewItem
        Dim er2 As ListViewItem
        If dGridSemantic.Items.Count > 1 Then
            For i As Integer = 0 To dGridSemantic.Items.Count - 1
                er1 = dGridSemantic.Items(i)
                err = dGridSemantic.Items.Item(i).SubItems(1).Text()
                err1 = dGridSemantic.Items.Item(i).SubItems(2).Text()

                For j As Integer = i + 1 To dGridSemantic.Items.Count - 1
                    er2 = dGridSemantic.Items(j)
                    err2 = dGridSemantic.Items.Item(j).SubItems(1).Text()
                    err21 = dGridSemantic.Items.Item(j).SubItems(2).Text()

                    If err = err2 And err1 = err21 Then
                        dGridSemantic.Items.Remove(er2)
                    End If
                Next
            Next
        End If

    End Sub


    Private Sub identifierList()
        Dim x As Integer = 0
        Dim isMane As Boolean = False
        Dim isStork As Boolean = False
        Dim isFunction As Boolean = False
        Dim Ctr As Integer = 0
        Dim bCtr As Integer = 0
        Dim erCtr As Integer = 0
        Dim valDType As String = ""
        Dim value As String = ""
        Dim curDtype As String = ""
        Dim type As String = ""
        Dim used As String = "No"
        Dim arraySize As String = ""
        Dim arraySize2 As String = ""
        Dim parameter As String = ""
        Dim constAns As String = ""

        Dim dtype(4) As String
        dtype(0) = "newt"
        dtype(1) = "duck"
        dtype(2) = "bull"
        dtype(3) = "starling"

        For i As Integer = 0 To dGridLexi.Items.Count - 1
            selinee(i) = dGridLexi.Items.Item(i).SubItems(1).Text() 'LINE
        Next

        For i As Integer = 0 To dGridLexi.Items.Count - 1
            setokee(i) = dGridLexi.Items.Item(i).SubItems(3).Text() 'TOKEN
        Next

        While x < dGridLexi.Items.Count
            If setokee(x) = "mane" Then
                isStork = False
                isMane = True
            End If

            If setokee(x) = "stork" Then
                isStork = True
                'MessageBox.Show(isStork)
                Ctr += 1
                objList = dGridIden.Items.Add(Ctr)
                objList.SubItems.Add(dGridLexi.Items.Item(x + 2).SubItems(2).Text())
                objList.SubItems.Add("-")
                objList.SubItems.Add("-")
                objList.SubItems.Add("-")
                objList.SubItems.Add("stork")
                objList.SubItems.Add("-")
                objList.SubItems.Add("-")
                objList.SubItems.Add("-")
                objList.SubItems.Add("stork/global")
                objList.SubItems.Add("-")
            End If

            If setokee(x) = "clsymbol" Then
                Dim termi As Integer = x
                Dim termi2 As Integer = x
                Dim iden As String = ""
                If setokee(x + 1) = "identifier" Then
                    While termi2 >= 0
                        If setokee(termi2) = "stork" Then
                            Exit While
                        End If
                        termi2 -= 1
                    End While

                    iden = dGridLexi.Items.Item(x).SubItems(2).Text
                    While setokee(termi) <> ":"
                        If setokee(termi) = "identifier" Then
                            bCtr += 1
                            objList = dGridBoard.Items.Add(dGridLexi.Items.Item(termi).SubItems(2).Text())
                            objList.SubItems.Add(dGridLexi.Items.Item(termi2 + 2).SubItems(2).Text())
                        End If
                        termi += 1
                    End While
                    isStork = False
                ElseIf setokee(x + 1) = ":" Then
                    isStork = False
                End If
            End If

            If setokee(x) = "viper" Then
                Dim kawnter As Integer = x
                While setokee(kawnter) <> "clpar"
                    kawnter += 1
                End While

                If setokee(kawnter + 1) = ":" Then
                    Ctr += 1
                    objList = dGridIden.Items.Add(Ctr)
                    objList.SubItems.Add(dGridLexi.Items.Item(x + 2).SubItems(2).Text())
                    objList.SubItems.Add(setokee(x))
                    objList.SubItems.Add("-")
                    objList.SubItems.Add("-")
                    objList.SubItems.Add("function")
                    objList.SubItems.Add("No")
                    objList.SubItems.Add("-")
                    objList.SubItems.Add("0")
                    objList.SubItems.Add("global")
                    objList.SubItems.Add("-")
                End If
            End If

            If inArray(setokee(x), dtype, 4) Then
                Dim kownt As Integer = x
                While setokee(kownt) <> "newline"
                    If setokee(kownt) = "newline" Then
                        Exit While
                    End If
                    kownt += 1
                End While

                If setokee(kownt - 1) = "clpar" Or setokee(kownt - 1) = "opsymbol" Then
                    isMane = False
                    isStork = False
                    isFunction = True
                End If

            End If

            If inArray(setokee(x), dtype, 4) Then
                curDtype = setokee(x)

                Dim declCount As Integer = 0
                Dim declCtr As Integer = x
                While Not (setokee(declCtr) = ":" Or setokee(declCtr) = "newline")
                    If setokee(declCtr) = "at" Then
                        declCount += 1
                    End If
                    declCtr += 1
                End While

                If declCount = 1 Then
                    While Not (setokee(x) = ":" Or setokee(x) = "newline")

                        'MessageBox.Show("x= " & x & ", " & setokee(x) & ", " & setokee(x + 1) & ", " & setokee(x + 2) & ", " & setokee(x + 3))

                        If setokee(x) = "identifier" And setokee(x + 1) <> "clsquare" And Not (setokee(x) = "identifier" And setokee(x + 1) = "oppar" And setokee(x + 2) = "clpar" And (setokee(x + 3) = "newline" Or setokee(x + 3) = "opsymbol")) Then
                            If setokee(x + 1) = "assgnOp" Then
                                valDType = setokee(x + 2).ToString
                                value = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                If setokee(x - 3) = "let" Then
                                    type = "constant"
                                Else
                                    type = "variable"
                                End If

                            ElseIf setokee(x + 1) = "opsquare" Then
                                value = "-"
                                If curDtype = "newt" Then
                                    valDType = "newtlit"
                                ElseIf curDtype = "duck" Then
                                    valDType = "ducklit"
                                ElseIf curDtype = "bull" Then
                                    valDType = "bullLit"
                                ElseIf curDtype = "starling" Then
                                    valDType = "starlinglit"
                                End If
                                If setokee(x + 3) = "opsquare" Or setokee(x + 4) = "opsquare" Then
                                    type = "array2"
                                Else
                                    type = "array1"
                                End If
                            ElseIf setokee(x + 1) = "oppar" Then
                                Dim lol As Integer = x + 1
                                While setokee(lol) <> "newline"
                                    If setokee(lol) = ":" Then
                                        Exit While
                                    End If
                                    lol += 1
                                End While

                                If Not (setokee(x + 1) = "oppar" And setokee(x + 2) = "clpar" And (setokee(x + 3) = "newline" Or setokee(x + 3) = "opsymbol")) Then
                                    value = "-"
                                    If curDtype = "newt" Then
                                        valDType = "newtlit"
                                    ElseIf curDtype = "duck" Then
                                        valDType = "ducklit"
                                    ElseIf curDtype = "bull" Then
                                        valDType = "bullLit"
                                    ElseIf curDtype = "starling" Then
                                        valDType = "starlinglit"
                                    End If
                                    type = "function"
                                End If
                            Else
                                If Not (setokee(x) = "identifier" And setokee(x + 1) = "oppar" And setokee(x + 2) = "clpar" And (setokee(x + 3) = "newline" Or setokee(x + 3) = "opsymbol")) Then
                                    If curDtype = "newt" Then
                                        value = "0"
                                        valDType = "newtlit"
                                    ElseIf curDtype = "duck" Then
                                        value = "true"
                                        valDType = "bullLit"
                                    ElseIf curDtype = "duck" Then
                                        value = "0.0"
                                        valDType = "ducklit"
                                    ElseIf curDtype = "starling" Then
                                        value = ""
                                        valDType = "starlinglit"
                                    End If
                                    type = "variable"
                                End If
                            End If

                            Ctr += 1
                            objList = dGridIden.Items.Add(Ctr)
                            objList.SubItems.Add(dGridLexi.Items.Item(x).SubItems(2).Text())
                            objList.SubItems.Add(curDtype)
                            objList.SubItems.Add(value)
                            objList.SubItems.Add(valDType)
                            objList.SubItems.Add(type)
                            objList.SubItems.Add(used)

                            If dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "array1" Then
                                If setokee(x + 2) = "newtlit" Then
                                    arraySize = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                    arraySize2 = "-"
                                ElseIf setokee(x + 2) = "identifier" Then
                                    Dim arrID As String = dGridLexi.Items.Item(x + 2).SubItems(2).Text
                                    Dim a As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text = arrID Then
                                            a = index
                                        End If
                                    Next

                                    Dim val As String = dGridIden.Items.Item(a).SubItems(3).Text
                                    arraySize = val
                                    arraySize2 = "-"
                                ElseIf setokee(x + 2) = "clsquare" Then
                                    arraySize = "100"
                                    arraySize2 = "-"
                                End If
                            ElseIf dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "array2" Then
                                If setokee(x + 2) = "newtlit" Then
                                    arraySize = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                    If setokee(x + 5) = "newtlit" Then
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 5).SubItems(2).Text()
                                    ElseIf setokee(x + 5) = "identifier" Then
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 5).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 5) = "clsquare" Then
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If
                                ElseIf setokee(x + 2) = "identifier" Then
                                    Dim arrID As String = dGridLexi.Items.Item(x + 2).SubItems(2).Text
                                    Dim a As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text = arrID Then
                                            a = index
                                        End If
                                    Next

                                    Dim val As String = dGridIden.Items.Item(a).SubItems(3).Text
                                    arraySize = val

                                    If setokee(x + 5) = "newtlit" Then '[@s][2]
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 5).SubItems(2).Text()
                                    ElseIf setokee(x + 5) = "identifier" Then '[@s][@a]
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 5).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 5) = "clsquare" Then '[@s][]
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If

                                ElseIf setokee(x + 2) = "clsquare" Then
                                    arraySize = "10"
                                    If setokee(x + 4) = "newtlit" Then
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 4).SubItems(2).Text()
                                    ElseIf setokee(x + 4) = "identifier" Then
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 4).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 4) = "clsquare" Then
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If
                                End If
                            Else
                                arraySize = "-"
                                arraySize2 = "-"
                            End If

                            objList.SubItems.Add(arraySize)


                            If dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "function" Then
                                Dim paramCtr As Integer = x
                                Dim paramCount As Integer = 0
                                While Not setokee(paramCtr) = "clpar"
                                    If inArray(setokee(paramCtr), dtype, 4) Then
                                        paramCount += 1
                                    End If
                                    paramCtr += 1
                                End While
                                parameter = paramCount.ToString
                            Else
                                parameter = "-"
                            End If

                            objList.SubItems.Add(parameter)

                            If isMane = True Then
                                objList.SubItems.Add("mane")
                            ElseIf isStork = True Then
                                Dim kaw As Integer = x
                                While kaw >= 0
                                    If setokee(kaw) = "opsymbol" Then
                                        Exit While
                                    Else
                                        kaw -= 1
                                    End If
                                End While
                                If setokee(kaw - 1) = "newline" Then
                                    objList.SubItems.Add(dGridLexi.Items.Item(kaw - 2).SubItems(2).Text)
                                Else
                                    objList.SubItems.Add(dGridLexi.Items.Item(kaw - 1).SubItems(2).Text)
                                End If
                            ElseIf isFunction = True Then
                                objList.SubItems.Add("subfunction")
                            Else
                                objList.SubItems.Add("global")
                            End If

                            objList.SubItems.Add(arraySize2)
                        End If
                        x += 1
                    End While
                ElseIf declCount >= 1 Then
                    Dim kawnt As Integer = x
                    While setokee(kawnt) <> "newline"
                        If setokee(kawnt) = "newline" Then
                            Exit While
                        End If
                        kawnt += 1
                    End While

                    While setokee(x) <> ","
                        If setokee(x) = "identifier" And setokee(x + 1) <> "clsquare" And Not (setokee(x) = "identifier" And setokee(x + 1) = "oppar" And (setokee(kawnt - 1) = "clpar" Or setokee(kawnt - 1) = "opsymbol")) Then
                            If setokee(x + 1) = "assgnOp" Then
                                valDType = setokee(x + 2).ToString
                                value = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                If setokee(x - 3) = "let" Then
                                    type = "constant"
                                Else
                                    type = "variable"
                                End If

                            ElseIf setokee(x + 1) = "opsquare" Then
                                value = "-"
                                If curDtype = "newt" Then
                                    valDType = "newtlit"
                                ElseIf curDtype = "duck" Then
                                    valDType = "ducklit"
                                ElseIf curDtype = "bull" Then
                                    valDType = "bullLit"
                                ElseIf curDtype = "starling" Then
                                    valDType = "starlinglit"
                                End If
                                If setokee(x + 3) = "opsquare" Or setokee(x + 4) = "opsquare" Then
                                    type = "array2"
                                Else
                                    type = "array1"
                                End If
                            ElseIf setokee(x + 1) = "oppar" Then
                                Dim lol As Integer = x + 1
                                While setokee(lol) <> "newline"
                                    If setokee(lol) = ":" Then
                                        Exit While
                                    End If
                                    lol += 1
                                End While

                                If Not (setokee(x + 1) = "oppar" And setokee(x + 2) = "clpar" And (setokee(x + 3) = "newline" Or setokee(x + 3) = "opsymbol")) Then
                                    value = "-"
                                    If curDtype = "newt" Then
                                        valDType = "newtlit"
                                    ElseIf curDtype = "duck" Then
                                        valDType = "ducklit"
                                    ElseIf curDtype = "bull" Then
                                        valDType = "bullLit"
                                    ElseIf curDtype = "starling" Then
                                        valDType = "starlinglit"
                                    End If
                                    type = "function"
                                End If
                            Else
                                If Not (setokee(x) = "identifier" And setokee(x + 1) = "oppar" And setokee(x + 2) = "clpar" And (setokee(x + 3) = "newline" Or setokee(x + 3) = "opsymbol")) Then
                                    If curDtype = "newt" Then
                                        value = "0"
                                        valDType = "newtlit"
                                    ElseIf curDtype = "bull" Then
                                        value = "true"
                                        valDType = "bullLit"
                                    ElseIf curDtype = "duck" Then
                                        value = "0.0"
                                        valDType = "ducklit"
                                    ElseIf curDtype = "starling" Then
                                        value = ""
                                        valDType = "starlinglit"
                                    End If
                                    type = "variable"
                                End If
                            End If

                            Ctr += 1
                            objList = dGridIden.Items.Add(Ctr)
                            objList.SubItems.Add(dGridLexi.Items.Item(x).SubItems(2).Text())
                            objList.SubItems.Add(curDtype)
                            objList.SubItems.Add(value)
                            objList.SubItems.Add(valDType)
                            objList.SubItems.Add(type)
                            objList.SubItems.Add(used)

                            If dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "array1" Then     'size ng array
                                If setokee(x + 2) = "newtlit" Then
                                    arraySize = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                    arraySize2 = "-"
                                ElseIf setokee(x + 2) = "identifier" Then
                                    Dim arrID As String = dGridLexi.Items.Item(x + 2).SubItems(2).Text
                                    Dim a As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text = arrID Then
                                            a = index
                                        End If
                                    Next

                                    Dim val As String = dGridIden.Items.Item(a).SubItems(3).Text
                                    arraySize = val
                                    arraySize2 = "-"
                                ElseIf setokee(x + 2) = "clsquare" Then
                                    arraySize = "100"
                                    arraySize2 = "-"
                                End If
                            ElseIf dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "array2" Then
                                If setokee(x + 2) = "newtlit" Then
                                    arraySize = dGridLexi.Items.Item(x + 2).SubItems(2).Text()
                                    If setokee(x + 5) = "newtlit" Then
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 5).SubItems(2).Text()
                                    ElseIf setokee(x + 5) = "identifier" Then
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 5).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 5) = "clsquare" Then
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If
                                ElseIf setokee(x + 2) = "identifier" Then
                                    Dim arrID As String = dGridLexi.Items.Item(x + 2).SubItems(2).Text
                                    Dim a As Integer
                                    For index As Integer = 0 To dGridIden.Items.Count - 1
                                        If dGridIden.Items.Item(index).SubItems(1).Text = arrID Then
                                            a = index
                                        End If
                                    Next

                                    Dim val As String = dGridIden.Items.Item(a).SubItems(3).Text
                                    arraySize = val

                                    If setokee(x + 5) = "newtlit" Then
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 5).SubItems(2).Text()
                                    ElseIf setokee(x + 5) = "identifier" Then
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 5).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 5) = "clsquare" Then
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If

                                ElseIf setokee(x + 2) = "clsquare" Then
                                    arraySize = "10"
                                    If setokee(x + 4) = "newtlit" Then
                                        arraySize = arraySize
                                        arraySize2 = dGridLexi.Items.Item(x + 4).SubItems(2).Text()
                                    ElseIf setokee(x + 4) = "identifier" Then
                                        Dim arrayID As String = dGridLexi.Items.Item(x + 4).SubItems(2).Text
                                        Dim b As Integer
                                        For index As Integer = 0 To dGridIden.Items.Count - 1
                                            If dGridIden.Items.Item(index).SubItems(1).Text = arrayID Then
                                                b = index
                                            End If
                                        Next
                                        Dim value1 As String = dGridIden.Items.Item(b).SubItems(3).Text
                                        arraySize = arraySize
                                        arraySize2 = value1
                                    ElseIf setokee(x + 4) = "clsquare" Then
                                        arraySize = arraySize
                                        arraySize2 = "10"
                                    End If
                                End If
                            Else
                                arraySize = "-"
                                arraySize2 = "-"
                            End If

                            objList.SubItems.Add(arraySize)

                            If dGridIden.Items.Item(Ctr - 1).SubItems(5).Text() = "function" Then
                                Dim paramCtr As Integer = x
                                Dim paramCount As Integer = 0
                                While Not setokee(paramCtr) = "clpar"
                                    If inArray(setokee(paramCtr), dtype, 4) Then
                                        paramCount += 1
                                    End If
                                    paramCtr += 1
                                End While
                                parameter = paramCount.ToString
                            Else
                                parameter = "-"
                            End If

                            objList.SubItems.Add(parameter)

                            If isMane = True Then
                                objList.SubItems.Add("mane")
                            ElseIf isStork = True Then
                                Dim kaw As Integer = x
                                While kaw >= 0
                                    If setokee(kaw) = "opsymbol" Then
                                        Exit While
                                    Else
                                        kaw -= 1
                                    End If
                                End While
                                If setokee(kaw - 1) = "newline" Then
                                    objList.SubItems.Add(dGridLexi.Items.Item(kaw - 2).SubItems(2).Text)
                                Else
                                    objList.SubItems.Add(dGridLexi.Items.Item(kaw - 1).SubItems(2).Text)
                                End If

                            ElseIf isFunction = True Then
                                objList.SubItems.Add("subfunction")
                            Else
                                objList.SubItems.Add("global")
                            End If

                            objList.SubItems.Add(arraySize2)

                        End If
                        x += 1
                    End While
                End If
            End If


            x += 1
        End While
    End Sub





    Public Sub RowCol()

        Dim index As Integer
        Dim line As Integer
        Dim col As Integer
        Dim pt As Point

        ' get the current line 
        index = Me.rTBCode.SelectionStart
        line = Me.rTBCode.GetLineFromCharIndex(index) + 1
        ' get the caret position in pixel coordinates 
        pt = Me.rTBCode.GetPositionFromCharIndex(index)
        ' now get the character index at the start of the line, and subtract from the current index to get the column 
        pt.X = 0
        col = index - Me.rTBCode.GetCharIndexFromPosition(pt) + 1

        ' finally, update the display in the status bar, incrementing the line and column values so that the first line & first character position is shown as "1, 1" 
        'Me.ToolStripStatusLabel1.Text = "Ln " + (++line).ToString() + ", Col " + (++col).ToString()

    End Sub

    Private Sub rTBCode_SelectionChanged(sender As Object, e As EventArgs) Handles rTBCode.SelectionChanged
        RowCol()
    End Sub

    Public Function inArray(ByVal input As String, ByVal array() As String, ByVal lim As Integer)
        Dim bool As Boolean = True
        For x As Integer = 0 To lim
            If input = array(x) Then
                bool = True
                Exit For
            Else
                bool = False
            End If
        Next
        Return bool
    End Function

    Private Sub DrawRichTextBoxLineNumbers(ByRef g As Graphics)
        'Calculate font heigth as the difference in Y coordinate 
        'between line 2 and line 1
        'Note that the RichTextBox text must have at least two lines. 
        '  So the initial Text property of the RichTextBox 
        '  should not be an empty string. It could be something 
        '  like vbcrlf & vbcrlf & vbcrlf 
        With rTBCode
            Dim font_height As Single
            font_height = .GetPositionFromCharIndex(.GetFirstCharIndexFromLine(2)).Y _
                  - .GetPositionFromCharIndex(.GetFirstCharIndexFromLine(1)).Y
            If font_height = 0 Then Exit Sub

            'Get the first line index and location
            Dim first_index As Integer
            Dim first_line As Integer
            Dim first_line_y As Integer
            first_index = .GetCharIndexFromPosition(New _
                  Point(0, g.VisibleClipBounds.Y + font_height / 3))
            first_line = .GetLineFromCharIndex(first_index)
            first_line_y = .GetPositionFromCharIndex(first_index).Y

            'Print on the PictureBox the visible line numbers of the RichTextBox
            'g.Clear(Control.DefaultBackColor)
            Dim i As Integer = first_line
            Dim y As Single
            Do While y < g.VisibleClipBounds.Y + g.VisibleClipBounds.Height
                y = first_line_y + 2 + font_height * (i - first_line - 1)
                g.DrawString((i).ToString, .Font, Brushes.Black, lineNum.Width _
                      - g.MeasureString((i).ToString, .Font).Width, y)
                i += 1
            Loop
            'Debug.WriteLine("Finished: " & firstLine + 1 & " " & i - 1)
        End With
    End Sub

    Private Sub r_Resize(ByVal sender As Object, ByVal e As System.EventArgs) _
     Handles rTBCode.Resize
        lineNum.Invalidate()
    End Sub

    Private Sub r_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rTBCode.VScroll
        lineNum.Invalidate()
    End Sub

    Private Sub p_Paint(ByVal sender As Object,
            ByVal e As System.Windows.Forms.PaintEventArgs) _
            Handles lineNum.Paint
        DrawRichTextBoxLineNumbers(e.Graphics)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles MyBase.Load
        rTBCode.Text = vbCrLf & vbCrLf & vbCrLf
    End Sub

    Private Sub rTBCode_TextChanged(sender As Object, e As EventArgs) Handles rTBCode.TextChanged

    End Sub

    Private Sub dGridIden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dGridIden.SelectedIndexChanged

    End Sub

    Private Sub dGridError_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dGridError.SelectedIndexChanged

    End Sub
End Class


