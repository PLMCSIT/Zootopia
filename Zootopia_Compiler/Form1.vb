Imports System.IO

Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic

Public Class Form1
    Public objList As ListViewItem
    Dim tokee(20000) As String '3
    Dim linee(20000) As String '1
    Dim setokee(20000) As String '3
    Dim selinee(20000) As String '1
    Dim isbody As Boolean = False
    Dim ismane As Boolean = False
    Dim errorCtr As Integer = 0

    Dim brccount As Integer
    Dim paracount As Integer


    Private Sub lexi()
        dGridLexi.Items.Clear()
        dGridError.Items.Clear()
        dGridIden.Items.Clear()
        'semant_table.Items.Clear()
        dGridBoard.Items.Clear()

        Dim sourcecode As String = rTBCode.Text + " "
        Dim sc() As Char = sourcecode.ToCharArray()
        Dim i As Integer = 0
        Dim line As Integer = 1

        Dim errorCtr As Integer = 0
        Dim symbolCtr As Integer = 0
        Dim idCtr As Integer = 0

        Dim delimStr As String = "Invalid lexeme "
        Dim id As String = ""
        Dim identifier As String = ""
        Dim str As String = ""
        Dim comment As String = ""
        Dim num As String = ""

        Dim allsym(95) As String
        allsym(0) = "`"
        allsym(1) = "~"
        allsym(2) = "1"
        allsym(3) = "!"
        allsym(4) = "2"
        allsym(5) = "$"
        allsym(6) = "3"
        allsym(7) = "//"
        allsym(8) = "4"
        allsym(9) = "$"
        allsym(10) = "5"
        allsym(11) = "%"
        allsym(12) = "6"
        allsym(13) = "^"
        allsym(14) = "7"
        allsym(15) = "&"
        allsym(16) = "8"
        allsym(17) = "*"
        allsym(18) = "9"
        allsym(19) = "("
        allsym(20) = "0"
        allsym(21) = ")"
        allsym(22) = "-"
        allsym(23) = "_"
        allsym(24) = "="
        allsym(25) = "+"
        allsym(26) = ":"
        allsym(27) = "|"
        allsym(28) = "]"
        allsym(29) = "}"
        allsym(30) = "["
        allsym(31) = "{"
        allsym(32) = "'"
        allsym(33) = """"
        allsym(34) = ";"
        allsym(35) = ":"
        allsym(36) = "/"
        allsym(37) = "?"
        allsym(38) = "."
        allsym(39) = ">"
        allsym(40) = ","
        allsym(41) = "<"
        allsym(42) = " "
        allsym(43) = "q"
        allsym(44) = "w"
        allsym(45) = "e"
        allsym(46) = "r"
        allsym(47) = "t"
        allsym(48) = "y"
        allsym(49) = "u"
        allsym(50) = "i"
        allsym(51) = "o"
        allsym(52) = "p"
        allsym(53) = "a"
        allsym(54) = "s"
        allsym(55) = "d"
        allsym(56) = "f"
        allsym(57) = "g"
        allsym(58) = "h"
        allsym(59) = "j"
        allsym(60) = "k"
        allsym(61) = "l"
        allsym(62) = "z"
        allsym(63) = "x"
        allsym(64) = "c"
        allsym(65) = "v"
        allsym(66) = "b"
        allsym(67) = "n"
        allsym(68) = "m"
        allsym(69) = "Q"
        allsym(70) = "W"
        allsym(71) = "E"
        allsym(72) = "R"
        allsym(73) = "T"
        allsym(74) = "Y"
        allsym(75) = "U"
        allsym(76) = "I"
        allsym(77) = "O"
        allsym(78) = "P"
        allsym(79) = "A"
        allsym(80) = "S"
        allsym(81) = "D"
        allsym(82) = "F"
        allsym(83) = "G"
        allsym(84) = "H"
        allsym(85) = "J"
        allsym(86) = "K"
        allsym(87) = "L"
        allsym(88) = "Z"
        allsym(89) = "X"
        allsym(90) = "C"
        allsym(91) = "V"
        allsym(92) = "B"
        allsym(93) = "N"
        allsym(94) = "M"


        Dim neg As Boolean = False
        While i < sourcecode.Length
            Dim read As Boolean = False
            If sc(i) = "b" Then
                If sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "l" Then
                        If sc(i + 1) = "u" And sc(i + 2) = "l" And sc(i + 3) = "l" Then
                            If sc(i + 4) = " " Or sc(i + 4) = "newline" Or Not inArray(sc(i + 4), allsym, 95) Then
                                symbolCtr += 1
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("bull")
                                objList.SubItems.Add("bull")
                                objList.SubItems.Add(" ")
                                read = True
                                i += 4
                            Else
                                errorCtr += 1
                                objList = dGridError.Items.Add(errorCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add(delimStr & "'bull'")
                                read = True
                                i += 4
                            End If
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & "'bul'")
                            read = True
                            i += 3
                        End If
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'bu'")
                        read = True
                        i += 2
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
                                        If sc(i + 7) = " " Or Not inArray(sc(i + 8), allsym, 95) Then
                                            symbolCtr += 1
                                            objList = dGridLexi.Items.Add(symbolCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add("chamois")
                                            objList.SubItems.Add("chamois")
                                            objList.SubItems.Add(" ")
                                            read = True
                                            i += 7
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
                    If sc(i + 2) = " " Or sc(i + 2) = "(" Or sc(i + 2) = "{" Or Not inArray(sc(i + 8), allsym, 95) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("do")
                        objList.SubItems.Add("do")
                        objList.SubItems.Add(" ")
                        read = True
                        i += 3
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'do'")
                        read = True
                        i += 2
                    End If
                ElseIf sc(i + 1) = "u" Then
                    If sc(i + 1) = "u" And sc(i + 2) = "c" Then
                        If sc(i + 1) = "u" And sc(i + 2) = "c" And sc(i + 3) = "k" Then
                            If sc(i + 4) = " " Or Not inArray(sc(i + 4), allsym, 95) Then
                                symbolCtr += 1
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("duck")
                                objList.SubItems.Add("duck")
                                objList.SubItems.Add(" ")
                                read = True
                                i += 4
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
                                    If sc(i + 6) = "(" Or sc(i + 6) = " " Then
                                        symbolCtr += 1
                                        objList = dGridLexi.Items.Add(symbolCtr)
                                        objList.SubItems.Add(line)
                                        objList.SubItems.Add("eelsif")
                                        objList.SubItems.Add("eelsif")
                                        objList.SubItems.Add(" ")
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
                                 And (sc(i + 4) = " " Or sc(i + 4) = "//" Or sc(i + 4) = "<" Or sc(i + 4) = "newline" Or Not inArray(sc(i + 4), allsym, 95)) Then
                                symbolCtr += 1
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("eels")
                                objList.SubItems.Add("eels")
                                objList.SubItems.Add(" ")
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
                                            If sc(i + 8) = " " Or sc(i + 8) = "(" Or sc(i + 8) = "newline" Or Not inArray(sc(i + 8), allsym, 95) Then
                                                symbolCtr += 1
                                                objList = dGridLexi.Items.Add(symbolCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add("entrance")
                                                objList.SubItems.Add("entrance")
                                                objList.SubItems.Add(" ")
                                                read = True
                                                i += 8
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
                            If sc(i + 4) = " " Or sc(i + 4) = "(" Or sc(i + 4) = "newline" Or Not inArray(sc(i + 4), allsym, 95) Then
                                symbolCtr += 1
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("exit")
                                objList.SubItems.Add("exit")
                                objList.SubItems.Add(" ")
                                read = True
                                i += 4
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
                                If sc(i + 5) = " " Or sc(i + 5) = ":" Or sc(i + 5) = ")" Or sc(i + 5) = "," Or sc(i + 5) = "}" Or Not inArray(sc(i + 5), allsym, 95) Then
                                    symbolCtr += 1
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("false")
                                    objList.SubItems.Add("Bull Literals")
                                    objList.SubItems.Add(" ")
                                    read = True
                                    i += 5
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
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("fur")
                            objList.SubItems.Add("fur")
                            objList.SubItems.Add(" ")
                            read = True
                            i += 3
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
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("hop")
                            objList.SubItems.Add("hop")
                            objList.SubItems.Add(" ")
                            read = True
                            i += 3
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
                    If sc(i + 2) = "(" Or sc(i + 2) = " " Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("if")
                        objList.SubItems.Add("if")
                        objList.SubItems.Add(" ")
                        read = True
                        i += 1
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'if'")
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
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("let")
                            objList.SubItems.Add("let")
                            objList.SubItems.Add(" ")
                            read = True
                            i += 2
                        Else
                            errorCtr += 1
                            objList = dGridLexi.Items.Add(errorCtr)
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
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("mane")
                                objList.SubItems.Add("mane")
                                objList.SubItems.Add(" ")
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
                                            If sc(i + 8) = " " Or sc(i + 8) = "," Then
                                                symbolCtr += 1
                                                objList = dGridLexi.Items.Add(symbolCtr)
                                                objList.SubItems.Add(line)
                                                objList.SubItems.Add("starling")
                                                objList.SubItems.Add("starling")
                                                objList.SubItems.Add(" ")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("stork")
                                    objList.SubItems.Add("stork")
                                    objList.SubItems.Add(" ")
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
                            If sc(i + 4) = " " Then
                                symbolCtr += 1
                                objList = dGridLexi.Items.Add(symbolCtr)
                                objList.SubItems.Add(line)
                                objList.SubItems.Add("seal")
                                objList.SubItems.Add("seal")
                                objList.SubItems.Add(" ")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("swasp")
                                    objList.SubItems.Add("swasp")
                                    objList.SubItems.Add(" ")
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
                                            objList = dGridLexi.Items.Add(symbolCtr)
                                            objList.SubItems.Add(line)
                                            objList.SubItems.Add("termite")
                                            objList.SubItems.Add("termite")
                                            objList.SubItems.Add(" ")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("viper")
                                    objList.SubItems.Add("viper")
                                    objList.SubItems.Add("Data Type")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("whale")
                                    objList.SubItems.Add("whale")
                                    objList.SubItems.Add(" ")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("wipe")
                                    objList.SubItems.Add("wipe")
                                    objList.SubItems.Add(" ")
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
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("zoout")
                                    objList.SubItems.Add("zoout")
                                    objList.SubItems.Add(" ")
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
                                If sc(i + 5) = ")" Or sc(i + 5) = " " Then
                                    symbolCtr += 1
                                    objList = dGridLexi.Items.Add(symbolCtr)
                                    objList.SubItems.Add(line)
                                    objList.SubItems.Add("zooin")
                                    objList.SubItems.Add("zooin")
                                    objList.SubItems.Add(" ")
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
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("==")
                        objList.SubItems.Add("relational Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("=")
                    objList.SubItems.Add("Assignment Operator")
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
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "~" Or sc(i + 2) = "\" Or sc(i + 2) = ")" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("++")
                        objList.SubItems.Add("increment Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("+")
                    objList.SubItems.Add("Math Operator")
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
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "~" Or sc(i + 2) = ":" Or sc(i + 2) = ")" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("--")
                        objList.SubItems.Add("decrement Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("-")
                    objList.SubItems.Add("Math Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("*")
                    objList.SubItems.Add("Math Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("/")
                    objList.SubItems.Add("Math Operator")
                    objList.SubItems.Add("mulOp, /")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("%")
                    objList.SubItems.Add("Math Operator")
                    objList.SubItems.Add("mulOp, %")
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

            If sc(i) = "." Then
                If sc(i + 1) = "+" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or Char.IsLetter(sc(1 + 2)) Then
                        symbolCtr += 1
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
                End If
            End If
            ' END NG .

            If sc(i) = "!" Then
                If sc(i + 1) = "=" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = "(" Or sc(i + 2) = "~" Or sc(i + 2) = """" Or sc(i + 2) = "f" Or sc(i + 2) = "t" Or sc(i + 2) = "n" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
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
                ElseIf sc(i + 1) = " " Or sc(i + 1) = "(" Or sc(i + 1) = "$" Or sc(i + 1) = "t" Or sc(i + 1) = "f" Then
                    symbolCtr += 1
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
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(">=")
                        objList.SubItems.Add("relational Operator")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(">")
                    objList.SubItems.Add("relational Operator")
                    objList.SubItems.Add("relOp, <")
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

            If sc(i) = ")" Then
                If sc(i + 1) = ")" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Then
                        symbolCtr += 1
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
                End If
            End If
            'End ng ))


            If sc(i) = "(" Then
                If sc(i + 1) = "(" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "$" Or sc(i + 2) = ":" _
                        Or sc(i + 2) = "(" Or sc(i + 2) = """" Or Char.IsDigit(sc(i + 2)) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("((")
                        objList.SubItems.Add("((")
                        objList.SubItems.Add("Output symbol")
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
                End If
            End If
            'END ng ((

            If sc(i) = "\" Then
                If sc(i + 1) = "n" Then
                    If sc(i + 2) = " " Or sc(i + 2) = ":" Then
                        symbolCtr += 1
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
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = "~" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("^")
                    objList.SubItems.Add("math Operator")
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
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("&&")
                        objList.SubItems.Add("logical Operator")
                        objList.SubItems.Add("logOp, &")
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'&&'")
                        read = True
                    End If
                End If
            End If
            'END NG &&

            If sc(i) = "|" Then
                If sc(i + 1) = "|" Then
                    If sc(i + 2) = " " Or sc(i + 2) = "(" Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("||")
                        objList.SubItems.Add("logical Operator")
                        objList.SubItems.Add("logOp, ||")
                        read = True
                    Else
                        errorCtr += 1
                        objList = dGridError.Items.Add(errorCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(delimStr & "'||'")
                        read = True
                    End If
                End If
            End If

            'END NG ||

            If sc(i) = "(" Then
                If sc(i + 1) = " " Or sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = ")" Or sc(i + 1) = "~" _
                        Or sc(i + 1) = "+" Or sc(i + 1) = "-" Or sc(i + 1) = "f" Or sc(i + 1) = "t" Or sc(i + 1) = "w" _
                        Or sc(i + 1) = """" Or sc(i + 1) = "!" Or sc(i + 1) = "'" Or Char.IsDigit(sc(i + 1)) Then
                    symbolCtr += 1
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("(")
                    objList.SubItems.Add("openpar")
                    objList.SubItems.Add("openpar")
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
                If sc(i + 1) = " " Or sc(i + 1) = ")" Or sc(i + 1) = "," Or sc(i + 1) = ":" _
                Or sc(i + 1) = "\" Or sc(i + 1) = "+" Or sc(i + 1) = "-" Or sc(i + 1) = "*" _
                Or sc(i + 1) = "/" Or sc(i + 1) = "%" Or sc(i + 1) = "^" Or sc(i + 1) = "&" _
                Or sc(i + 1) = "|" Or sc(i + 1) = "<" Or sc(i + 1) = ">" Or sc(i + 1) = "=" _
                Or sc(i + 1) = "!" Or sc(i + 1) = "//" Or sc(i + 1) = "}" Or sc(i + 1) = "newline" _
                Or Not inArray(sc(i + 1), allsym, 95) Then
                    symbolCtr += 1
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(")")
                    objList.SubItems.Add("closepar")
                    objList.SubItems.Add("closepar")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("[")
                    objList.SubItems.Add("openarray")
                    objList.SubItems.Add("openarray")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("]")
                    objList.SubItems.Add("closearray")
                    objList.SubItems.Add("closearray")
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
                    If sc(i + 2) = " " Or sc(i + 2) = "//" Or sc(i + 2) = "$" Or sc(i + 2) = "~" Or sc(i + 2) = "(" Or sc(i + 2) = "w" Or sc(i + 2) = "t" Or sc(i + 2) = "f" Or sc(i + 2) = "c" Or sc(i + 2) = "r" Or sc(i + 2) = "d" Or sc(i + 2) = "newline" Or Not inArray(sc(i + 2), allsym, 95) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("{{")
                        objList.SubItems.Add("Open Symbol")
                        objList.SubItems.Add("Open Symbol")
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
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add("{")
                    objList.SubItems.Add("openElem")
                    objList.SubItems.Add("openElem")
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
                    If sc(i + 2) = " " Or sc(i + 2) = "//" Or sc(i + 2) = "$" Or sc(i + 2) = ":" Or sc(i + 2) = "d" Or sc(i + 2) = "newline" Or Not inArray(sc(i + 2), allsym, 95) Then 'pending nl
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("}}")
                        objList.SubItems.Add("Close Symbol")
                        objList.SubItems.Add("Close Symbol")
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

                ElseIf sc(i + 1) = " " Or sc(i + 1) = "\" Or sc(i + 1) = "," Then
                    symbolCtr += 1
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
                    If sc(i + 1) = " " Or sc(i + 1) = "<" Or sc(i + 1) = "//" Or sc(i + 1) = "t" Or sc(i + 1) = "newline" Or Not inArray(sc(i + 1), allsym, 95) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(";")
                        objList.SubItems.Add(";")
                        objList.SubItems.Add("swasp terminal symbol")
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

            If sc(i) = "//" Then
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
                objList = dGridLexi.Items.Add(symbolCtr)
                objList.SubItems.Add(line)
                objList.SubItems.Add("//" & comment)
                objList.SubItems.Add("comment")
                objList.SubItems.Add("comment")
                read = True
                i += x
            End If
            'END NG //

            If sc(i) = ":" Then
                If i + 1 < sourcecode.Length Then
                    If sc(i + 1) = " " Or sc(i + 1) = "//" Or sc(i + 1) = "(" Or sc(i + 1) = ">" Or sc(i + 1) = "$" _
                        Or sc(i + 1) = "newline" Or Not inArray(sc(i + 1), allsym, 95) Then 'pending nl
                        symbolCtr += 1
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
                        Or sc(i + 1) = "f" Or sc(i + 1) = "t" Or sc(i + 1) = "w" Or Char.IsDigit(sc(i + 1)) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(",")
                        objList.SubItems.Add(",")
                        objList.SubItems.Add("separator")
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
                    If sc(i + 1) = "$" Or sc(i + 1) = "(" Or sc(i + 1) = " " Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add("~")
                        objList.SubItems.Add("~")
                        objList.SubItems.Add("negate, ~, unary")
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
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(".+")
                        objList.SubItems.Add(".+")
                        objList.SubItems.Add("strOp, .+, binary")
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
                While Not (sc(i + x) = """" Or Not inArray(sc(i + x), allsym, 95)) And i + x + 1 < sourcecode.Length 'outer "
                    x += 1
                End While

                While Not (start = x)
                    str = str & sc(i + start)
                    start += 1
                End While

                If sc(i + x) = """" Then
                    If str.Length <= 500 Then
                        If sc(i + x + 1) = " " Or sc(i + x + 1) = ":" Or sc(i + x + 1) = ";" Or sc(i + x + 1) = "\" _
                        Or sc(i + x + 1) = ")" Or sc(i + x + 1) = "," Or sc(i + x + 1) = "}" Or sc(i + x + 1) = "!" Then
                            symbolCtr += 1
                            objList = dGridLexi.Items.Add(symbolCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("""" & str & """")
                            objList.SubItems.Add("textlit")
                            objList.SubItems.Add("textlit, " & """" & str & """")
                        Else
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add(delimStr & """" & str & """")
                        End If
                    Else
                        If sc(i + x + 1) = " " Or sc(i + x + 1) = ":" Or sc(i + x + 1) = ";" Or sc(i + x + 1) = "\" _
                        Or sc(i + x + 1) = ")" Or sc(i + x + 1) = "," Or sc(i + x + 1) = "}" Or sc(i + x + 1) = "!" Then
                            errorCtr += 1
                            objList = dGridError.Items.Add(errorCtr)
                            objList.SubItems.Add(line)
                            objList.SubItems.Add("Invalid textlit. Exceed max. no of character in string")
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
                    objList.SubItems.Add("""" & str & " , Unterminated string")
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

                If sc(ctr1) = " " Or sc(ctr1) = "," Or sc(ctr1) = "\" _
                Or sc(ctr1) = "]" Or sc(ctr1) = "+" Or sc(ctr1) = "-" Or sc(ctr1) = "}" _
                Or sc(ctr1) = "*" Or sc(ctr1) = "/" Or sc(ctr1) = "%" Or sc(ctr1) = "^" _
                Or sc(ctr1) = "<" Or sc(ctr1) = ";" Or sc(ctr1) = ">" Or sc(ctr1) = "'" Or sc(ctr1) = "=" Or sc(ctr1) = ":" Or sc(ctr1) = ")" Then
                    symbolCtr += 1
                    objList = dGridLexi.Items.Add(symbolCtr)
                    objList.SubItems.Add(line)
                    If neg = True Then
                        objList.SubItems.Add("~" & number)
                        objList.SubItems.Add("wholelit")
                        objList.SubItems.Add("wholelit, ~" & number)
                    Else
                        objList.SubItems.Add(number)
                        objList.SubItems.Add("wholelit")
                        objList.SubItems.Add("wholelit, " & number)
                    End If
                    read = True
                    i = ctr1 - 1
                    neg = False

                ElseIf sc(ctr1) = "." Then
                    number = number + sc(ctr1)
                    Dim ctr2 As Integer = ctr1 + 1
                    Dim length1 As Integer = 0
                    While ctr2 < sourcecode.Length
                        If Char.IsDigit(sc(ctr2)) And length1 < 5 Then
                            number = number + sc(ctr2)
                            ctr2 += 1
                            length1 += 1
                        Else
                            Exit While
                        End If
                    End While

                    If sc(ctr2) = " " Or sc(ctr2) = "," Or sc(ctr2) = "\" _
                    Or sc(ctr2) = "]" Or sc(ctr2) = "+" Or sc(ctr2) = "-" Or sc(ctr2) = "}" _
                    Or sc(ctr2) = "*" Or sc(ctr2) = "/" Or sc(ctr2) = "%" Or sc(ctr2) = "^" _
                    Or sc(ctr2) = "<" Or sc(ctr2) = ";" Or sc(ctr2) = ">" Or sc(ctr2) = "'" Or sc(ctr2) = "=" Or sc(ctr2) = ":" Or sc(ctr2) = ")" Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        If neg = True Then
                            objList.SubItems.Add("~" & number)
                            objList.SubItems.Add("fraclit")
                            objList.SubItems.Add("fraclit, ~" & number)
                        Else
                            objList.SubItems.Add(number)
                            objList.SubItems.Add("wholelit")
                            objList.SubItems.Add("wholelit, " & number)
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
                        If (Char.IsLower(sc(ctr1)) Or Char.IsDigit(sc(ctr1)) Or sc(ctr1) = "_") And length < 9 Then
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
                    Or sc(ctr1) = "<" Or sc(ctr1) = ")" Or sc(ctr1) = ">" Or sc(ctr1) = "=" Or sc(ctr1) = "!" Or sc(ctr1) = ":" Or Not inArray(sc(ctr1), allsym, 95) Then
                        symbolCtr += 1
                        objList = dGridLexi.Items.Add(symbolCtr)
                        objList.SubItems.Add(line)
                        objList.SubItems.Add(ident)
                        objList.SubItems.Add("identifier")
                        objList.SubItems.Add("identifier")
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
                    objList.SubItems.Add(unid & " -- Unidentified lexeme")
                    i = x - 1
                Else
                    errorCtr += 1
                    objList = dGridError.Items.Add(errorCtr)
                    objList.SubItems.Add(line)
                    objList.SubItems.Add(sc(i) & " -- Unidentified character")
                End If
            End If

            i += 1 'LAGING NAGMOMOVE NG 1 CHAR
            'MessageBox.Show("sc(i)= " & sc & " i= " & i)
        End While

        ' END NG LEXICAL
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAna.Click
        dGridError.BackColor = Color.SaddleBrown
        dGridLexi.BackColor = Color.SaddleBrown
        'semant_table.BackColor = Color.SaddleBrown
        lexi()
        'syntaxana()
        'identifierList()
        'semantic()
        'If dGridError.Items.Count = 0 Then
        '    translate()
        '    output()
        'End If


    End Sub


    'Public Sub translate()
    '    'MessageBox.Show(dGridLexi.Items.Count)
    '    Dim s As Integer = 0
    '    Dim t As Integer = 0
    '    Dim str As String = ""
    '    RichTextBox1.Text = ""
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<iostream>" + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<stdio.h>" + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<conio.h>" + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<math.h>" + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<cstdlib>" + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "//include<cstring>" + vbNewLine + vbNewLine
    '    RichTextBox1.Text = RichTextBox1.Text + "using namespace std;" + vbNewLine + vbNewLine
    '    'RichTextBox1.Text = RichTextBox1.Text + "int main()"

    '    For i As Integer = 0 To dGridLexi.Items.Count - 1
    '        tokee(i) = dGridLexi.Items.Item(i).SubItems(3).Text() 'TOKEN
    '    Next

    '    While s < dGridLexi.Items.Count
    '        If tokee(s) = "newline" Then
    '            RichTextBox1.Text = RichTextBox1.Text + vbNewLine
    '        End If

    '        If tokee(s) = "valuu" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            RichTextBox1.Text = RichTextBox1.Text + str + " "
    '        End If

    '        If tokee(s) = "comment" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            str = str.Replace("//", "//")
    '            RichTextBox1.Text = RichTextBox1.Text + str
    '        End If

    '        If tokee(s) = "id" And tokee(s + 1) <> ".+" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            str = str.Replace("$", "")
    '            RichTextBox1.Text = RichTextBox1.Text + str
    '        End If

    '        If tokee(s) = "board" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "struct "
    '        End If

    '        If tokee(s) = "xlear" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "clear"
    '        End If

    '        If tokee(s) = "xnore" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "ignore"
    '        End If

    '        If tokee(s) = "xfail" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "fail"
    '        End If

    '        If tokee(s) = "vr" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "break"
    '        End If

    '        If tokee(s) = "ind" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "char "
    '        End If

    '        If tokee(s) = "indi" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "getch();"
    '        End If

    '        If tokee(s) = "'\0'" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "'\0'"
    '        End If

    '        If tokee(s) = "''" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "' '"
    '        End If

    '        If tokee(s) = "'*'" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "'*'"
    '        End If

    '        If tokee(s) = "deport" Then
    '            'str = dGridLexi.Items.Item(s + 1).SubItems(2).Text
    '            'If str <> "0" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "return "
    '            'Else
    '            '   RichTextBox1.Text = RichTextBox1.Text + "getch(); return "
    '            'End If
    '        End If

    '        If tokee(s) = "during" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "while "
    '        End If

    '        If tokee(s) = "gate" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "default "
    '        End If

    '        If tokee(s) = "halt" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "break"
    '        End If

    '        If tokee(s) = "mane" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "int main"
    '        End If

    '        If tokee(s) = "ztr" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "strlen"
    '        End If

    '        If tokee(s) = "zcat" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "strcat"
    '        End If

    '        If tokee(s) = "null" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "0"
    '        End If

    '        If tokee(s) = "otherwise" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "else "
    '        End If

    '        If tokee(s) = "otherwisewhen" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "else if "
    '        End If

    '        If tokee(s) = "run" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "do "
    '        End If

    '        If tokee(s) = "set" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "const "
    '        End If

    '        If tokee(s) = "terminal" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "case "
    '        End If

    '        If tokee(s) = "take" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "switch "
    '        End If

    '        If tokee(s) = "till" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "for"
    '        End If

    '        If tokee(s) = "vacant" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "void "
    '        End If

    '        If tokee(s) = "when" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "if "
    '        End If

    '        If tokee(s) = "checkin" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "cin"
    '        End If

    '        If tokee(s) = "checkout" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "cout"
    '        End If

    '        If tokee(s) = "clearfield" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "system(""cls"")"
    '        End If

    '        If tokee(s) = "assgnOp" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "="
    '        End If

    '        If tokee(s) = "\" Then
    '            RichTextBox1.Text = RichTextBox1.Text + ";"
    '        End If

    '        If tokee(s) = "opsymbol" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "{"
    '        End If

    '        If tokee(s) = "clsymbol" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "}"
    '        End If

    '        If tokee(s) = "oppar" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "("
    '        End If

    '        If tokee(s) = "clpar" Then
    '            RichTextBox1.Text = RichTextBox1.Text + ")"
    '        End If

    '        If tokee(s) = "opsquare" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "["
    '        End If

    '        If tokee(s) = "clsquare" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "]"
    '        End If

    '        If tokee(s) = "opcurly" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "{"
    '        End If

    '        If tokee(s) = "clcurly" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "}"
    '        End If

    '        If tokee(s) = "!+" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "."
    '        End If

    '        If tokee(s) = "!" Then
    '            RichTextBox1.Text = RichTextBox1.Text + " ! "
    '        End If

    '        If tokee(s) = ":<" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "<<"
    '        End If

    '        If tokee(s) = ":>" Then
    '            RichTextBox1.Text = RichTextBox1.Text + ">>"
    '        End If

    '        If tokee(s) = ":n" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "endl"
    '        End If

    '        If tokee(s) = ":t" Then
    '            RichTextBox1.Text = RichTextBox1.Text + """   """
    '        End If

    '        If tokee(s) = ";" Then
    '            RichTextBox1.Text = RichTextBox1.Text + ": "
    '        End If

    '        If tokee(s) = "," Then
    '            RichTextBox1.Text = RichTextBox1.Text + ", "
    '        End If

    '        If tokee(s) = "?" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "? "
    '        End If

    '        If tokee(s) = ".+" Then
    '            Dim id1 As String = dGridLexi.Items.Item(s - 1).SubItems(2).Text
    '            id1 = id1.Replace("$", " ")
    '            Dim id2 As String = dGridLexi.Items.Item(s + 1).SubItems(2).Text
    '            id2 = id2.Replace("$", " ")
    '            str = tokee(s - 1) + tokee(s) + tokee(s + 1)
    '            str = "strcat(" + id1 + "," + id2 + ")"
    '            RichTextBox1.Text = RichTextBox1.Text + str
    '            s += 1
    '        End If

    '        If tokee(s) = "increOp" Or tokee(s) = "decreOp" Or tokee(s) = "relOp2" Or tokee(s) = "relOp1" Or tokee(s) = "assgnOp2" _
    '            Or tokee(s) = "mathOp" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            RichTextBox1.Text = RichTextBox1.Text + str + " "
    '        End If

    '        If tokee(s) = "logOp" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            RichTextBox1.Text = RichTextBox1.Text + str + str
    '        End If

    '        If tokee(s) = "wholelit" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            If str.Contains("~") Then
    '                str = str.Replace("~", "-")
    '                RichTextBox1.Text = RichTextBox1.Text + " (" + str + ") "
    '            Else
    '                RichTextBox1.Text = RichTextBox1.Text + str
    '            End If
    '        End If

    '        If tokee(s) = "fraclit" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            If str.Contains("~") Then
    '                str = str.Replace("~", "-")
    '                RichTextBox1.Text = RichTextBox1.Text + " (" + str + ") "
    '            Else
    '                RichTextBox1.Text = RichTextBox1.Text + str + " "
    '            End If
    '        End If

    '        If tokee(s) = "flaglit" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            RichTextBox1.Text = RichTextBox1.Text + str + " "
    '        End If

    '        If tokee(s) = "textlit" Then
    '            str = dGridLexi.Items.Item(s).SubItems(2).Text
    '            RichTextBox1.Text = RichTextBox1.Text + str + " "
    '        End If

    '        If tokee(s) = "whole" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "int "
    '        End If

    '        If tokee(s) = "text" Then
    '            Dim strln As Integer
    '            If tokee(s + 3) = "opsquare" Then
    '                strln = dGridLexi.Items.Item(s + 8).SubItems(2).Text.Length
    '                If strln > 3 Then
    '                    RichTextBox1.Text = RichTextBox1.Text + "string "
    '                Else
    '                    RichTextBox1.Text = RichTextBox1.Text + "char "
    '                End If
    '            Else
    '                RichTextBox1.Text = RichTextBox1.Text + "string "
    '            End If
    '        End If

    '        If tokee(s) = "frac" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "float "
    '        End If

    '        If tokee(s) = "flag" Then
    '            RichTextBox1.Text = RichTextBox1.Text + "bool "
    '        End If
    '        s += 1
    '    End While
    'End Sub

    'Public Sub output()
    '    If Not My.Computer.FileSystem.DirectoryExists("C:\Users\sarah\Documents") Then
    '        My.Computer.FileSystem.CreateDirectory("C:\Users\sarah\Documents")
    '    End If
    '    '<><>CHECK FOR OLD FILES<><>
    '    If My.Computer.FileSystem.FileExists("C:\Users\sarah\Documents\compiler.cpp") Then
    '        My.Computer.FileSystem.DeleteFile("C:\Users\sarah\Documents\compiler.cpp")
    '    End If
    '    If My.Computer.FileSystem.FileExists("C:\Users\sarah\Documents\compiler.exe") Then
    '        My.Computer.FileSystem.DeleteFile("C:\Users\sarah\Documents\compiler.exe")
    '    End If
    '    '<><>WRITING<><>
    '    Using sw As New System.IO.StreamWriter("C:\Users\sarah\Documents\compiler.cpp")
    '        sw.WriteLine(RichTextBox1.Text)
    '        sw.Close()
    '    End Using
    '    '<><>COMPILING<><>
    '    Dim CPath As String = "C:\MinGW\bin"
    '    Process.Start("cmd", "/c g++ C:\Users\sarah\Documents\compiler.cpp -o C:\Users\sarah\Documents\compiler.exe").WaitForExit()
    '    If Not My.Computer.FileSystem.FileExists("C:\Users\sarah\Documents\compiler.exe") Then
    '        MsgBox("Unsuccessful Build. Please check your code.")
    '    Else
    '        Process.Start("C:\Users\sarah\Documents\compiler").WaitForExit()
    '    End If
    'End Sub

    'Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
    '    Clipboard.SetDataObject(rTBCode.SelectedText)
    '    Dim S As String = rTBCode.Text
    '    Dim SelStart As Integer = rTBCode.SelectionStart
    '    Dim SelLen As Integer = rTBCode.SelectionLength

    '    S = S.Remove(SelStart, SelLen)

    '    rTBCode.Text = S

    '    rTBCode.Focus()
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
    '    Clipboard.SetDataObject(rTBCode.SelectedText)
    '    rTBCode.Focus()
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
    '    Dim oDataObject As IDataObject
    '    oDataObject = Clipboard.GetDataObject()
    '    If oDataObject.GetDataPresent(DataFormats.Text) Then
    '        rTBCode.SelectedText = CType(oDataObject.GetData(DataFormats.Text), String)
    '    End If
    '    rTBCode.Focus()
    'End Sub

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

    'Private Sub open_but_Click(sender As Object, e As EventArgs) Handles open_but.Click
    '    OpenFileDialog1.Filter = "(*.txt) | *.txt"
    '    If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
    '        rTBCode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    '    End If

    'End Sub

    'Private Sub save_but_Click(sender As Object, e As EventArgs) Handles save_but.Click
    '    SaveFileDialog1.Title = "Save File As..."
    '    SaveFileDialog1.Filter = "(*.txt) | *.txt"
    '    If (SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
    '        rTBCode.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
    '    End If
    'End Sub

    'Private Sub close_but_Click(sender As Object, e As EventArgs) Handles close_but.Click
    '    Me.Close()
    'End Sub

    'Private Sub min_but_Click(sender As Object, e As EventArgs) Handles min_but.Click
    '    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    'End Sub

    'Private Sub new_but_Click(sender As Object, e As EventArgs) Handles new_but.Click
    '    rTBCode.Clear()
    '    dGridLexi.Items.Clear()
    '    dGridError.Items.Clear()
    '    dGridIden.Items.Clear()
    '    semant_table.Items.Clear()
    '    dGridBoard.Items.Clear()
    'End Sub

    Private Sub lineNum_Click(sender As Object, e As EventArgs) Handles lineNum.Click

    End Sub

    Private Sub rTBCode_TextChanged(sender As Object, e As EventArgs) Handles rTBCode.TextChanged

    End Sub

    Private Sub dGridLexi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dGridLexi.SelectedIndexChanged

    End Sub
End Class
