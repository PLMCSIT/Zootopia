' SyntaxTokenizer.vb
'
' THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!

Imports System.IO

Imports PerCederberg.Grammatica.Runtime

'''<remarks>A character stream tokenizer.</remarks>
Public Class SyntaxTokenizer
    Inherits Tokenizer

    '''<summary>Creates a new tokenizer for the specified input
    '''stream.</summary>
    '''
    '''<param name='input'>the input stream to read</param>
    '''
    '''<exception cref='ParserCreationException'>if the tokenizer
    '''couldn't be initialized correctly</exception>
    Public Sub New(ByVal input As TextReader)
        MyBase.New(input, False)
        CreatePatterns()
    End Sub

    '''<summary>Initializes the tokenizer by creating all the token
    '''patterns.</summary>
    '''
    '''<exception cref='ParserCreationException'>if the tokenizer
    '''couldn't be initialized correctly</exception>
    Private Sub CreatePatterns()
        Dim pattern as TokenPattern

        pattern = New TokenPattern(CInt(SyntaxConstants.ENTRANCE), "ENTRANCE", TokenPattern.PatternType.STRING, "entrance")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EXIT), "EXIT", TokenPattern.PatternType.STRING, "exit")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.MANE), "MANE", TokenPattern.PatternType.STRING, "mane")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.LET), "LET", TokenPattern.PatternType.STRING, "let")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.WIPE), "WIPE", TokenPattern.PatternType.STRING, "wipe")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ZOOIN), "ZOOIN", TokenPattern.PatternType.STRING, "zooin")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ZOOUT), "ZOOUT", TokenPattern.PatternType.STRING, "zoout")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.IF), "IF", TokenPattern.PatternType.STRING, "if")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EELSIF), "EELSIF", TokenPattern.PatternType.STRING, "eelsif")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EELS), "EELS", TokenPattern.PatternType.STRING, "eels")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CHAMOIS), "CHAMOIS", TokenPattern.PatternType.STRING, "chamois")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.TERMITE), "TERMITE", TokenPattern.PatternType.STRING, "termite")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.SEAL), "SEAL", TokenPattern.PatternType.STRING, "seal")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.WHALE), "WHALE", TokenPattern.PatternType.STRING, "whale")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DO), "DO", TokenPattern.PatternType.STRING, "do")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.FUR), "FUR", TokenPattern.PatternType.STRING, "fur")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.HOP), "HOP", TokenPattern.PatternType.STRING, "hop")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.SWASP), "SWASP", TokenPattern.PatternType.STRING, "swasp")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.STORK), "STORK", TokenPattern.PatternType.STRING, "stork")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.AT), "AT", TokenPattern.PatternType.STRING, "at")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.COMSYM), "COMSYM", TokenPattern.PatternType.STRING, "'")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.TERMI), "TERMI", TokenPattern.PatternType.STRING, ":")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.SC), "SC", TokenPattern.PatternType.STRING, ";")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.COMMA), "COMMA", TokenPattern.PatternType.STRING, ",")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EQUAL), "EQUAL", TokenPattern.PatternType.STRING, "=")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OB), "OB", TokenPattern.PatternType.STRING, "[")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CB), "CB", TokenPattern.PatternType.STRING, "]")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OC), "OC", TokenPattern.PatternType.STRING, "{")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CC), "CC", TokenPattern.PatternType.STRING, "}")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OP), "OP", TokenPattern.PatternType.STRING, "(")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CP), "CP", TokenPattern.PatternType.STRING, ")")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ODC), "ODC", TokenPattern.PatternType.STRING, "{{")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CDC), "CDC", TokenPattern.PatternType.STRING, "}}")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CONC), "CONC", TokenPattern.PatternType.STRING, ".+")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CON), "CON", TokenPattern.PatternType.STRING, "?")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ODP), "ODP", TokenPattern.PatternType.STRING, "((")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CDP), "CDP", TokenPattern.PatternType.STRING, "))")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.NEG), "NEG", TokenPattern.PatternType.STRING, "~")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ADD), "ADD", TokenPattern.PatternType.STRING, "+")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.SUB), "SUB", TokenPattern.PatternType.STRING, "-")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.MUL), "MUL", TokenPattern.PatternType.STRING, "*")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DIV), "DIV", TokenPattern.PatternType.STRING, "/")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.MOD), "MOD", TokenPattern.PatternType.STRING, "%")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EXP), "EXP", TokenPattern.PatternType.STRING, "^")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OA), "OA", TokenPattern.PatternType.STRING, "<")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CA), "CA", TokenPattern.PatternType.STRING, ">")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OAE), "OAE", TokenPattern.PatternType.STRING, "<=")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.CAE), "CAE", TokenPattern.PatternType.STRING, ">=")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EE), "EE", TokenPattern.PatternType.STRING, "!=")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DE), "DE", TokenPattern.PatternType.STRING, "==")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.EXC), "EXC", TokenPattern.PatternType.STRING, "!")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DAND), "DAND", TokenPattern.PatternType.STRING, "&&")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DOR), "DOR", TokenPattern.PatternType.STRING, "||")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.INCRE), "INCRE", TokenPattern.PatternType.STRING, "++")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DECRE), "DECRE", TokenPattern.PatternType.STRING, "--")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.AND), "AND", TokenPattern.PatternType.STRING, "&&")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.OR), "OR", TokenPattern.PatternType.STRING, "||")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.QM), "QM", TokenPattern.PatternType.REGEXP, "[""]")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.NEWT), "NEWT", TokenPattern.PatternType.STRING, "newt")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DUCK), "DUCK", TokenPattern.PatternType.STRING, "duck")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.BULL), "BULL", TokenPattern.PatternType.STRING, "bull")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.STARLING), "STARLING", TokenPattern.PatternType.STRING, "starling")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.VIPER), "VIPER", TokenPattern.PatternType.STRING, "viper")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.NEWTLIT), "NEWTLIT", TokenPattern.PatternType.STRING, "newt literals")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.DUCKLIT), "DUCKLIT", TokenPattern.PatternType.STRING, "duck literals")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.STARLIT), "STARLIT", TokenPattern.PatternType.STRING, "starling literals")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.TRUE), "TRUE", TokenPattern.PatternType.STRING, "true")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.FALSE), "FALSE", TokenPattern.PatternType.STRING, "false")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.ID), "ID", TokenPattern.PatternType.STRING, "id")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.COMMENT), "COMMENT", TokenPattern.PatternType.STRING, "comment")
        AddPattern(pattern)

        pattern = New TokenPattern(CInt(SyntaxConstants.WHITESPACE), "WHITESPACE", TokenPattern.PatternType.REGEXP, "[ \t\n\r\s]+")
        pattern.Ignore = True
        AddPattern(pattern)
    End Sub
End Class
