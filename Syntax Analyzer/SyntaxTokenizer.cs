/*
 * SyntaxTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using Core.Library;

/**
 * <remarks>A character stream tokenizer.</remarks>
 */
public class SyntaxTokenizer : Tokenizer {

    /**
     * <summary>Creates a new tokenizer for the specified input
     * stream.</summary>
     *
     * <param name='input'>the input stream to read</param>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    public SyntaxTokenizer(TextReader input)
        : base(input, false) {

        CreatePatterns();
    }

    /**
     * <summary>Initializes the tokenizer by creating all the token
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        TokenPattern  pattern;

        pattern = new TokenPattern((int) SyntaxConstants.ENTRANCE,
                                   "ENTRANCE",
                                   TokenPattern.PatternType.STRING,
                                   "entrance");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EXIT,
                                   "EXIT",
                                   TokenPattern.PatternType.STRING,
                                   "exit");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.MANE,
                                   "MANE",
                                   TokenPattern.PatternType.STRING,
                                   "mane");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.LET,
                                   "LET",
                                   TokenPattern.PatternType.STRING,
                                   "let");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.WIPE,
                                   "WIPE",
                                   TokenPattern.PatternType.STRING,
                                   "wipe");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ZOOIN,
                                   "ZOOIN",
                                   TokenPattern.PatternType.STRING,
                                   "zooin");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ZOOUT,
                                   "ZOOUT",
                                   TokenPattern.PatternType.STRING,
                                   "zoout");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.IF,
                                   "IF",
                                   TokenPattern.PatternType.STRING,
                                   "if");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EELSIF,
                                   "EELSIF",
                                   TokenPattern.PatternType.STRING,
                                   "eelsif");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EELS,
                                   "EELS",
                                   TokenPattern.PatternType.STRING,
                                   "eels");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CHAMOIS,
                                   "CHAMOIS",
                                   TokenPattern.PatternType.STRING,
                                   "chamois");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.TERMITE,
                                   "TERMITE",
                                   TokenPattern.PatternType.STRING,
                                   "termite");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.SEAL,
                                   "SEAL",
                                   TokenPattern.PatternType.STRING,
                                   "seal");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.WHALE,
                                   "WHALE",
                                   TokenPattern.PatternType.STRING,
                                   "whale");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DO,
                                   "DO",
                                   TokenPattern.PatternType.STRING,
                                   "do");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.FUR,
                                   "FUR",
                                   TokenPattern.PatternType.STRING,
                                   "fur");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.HOP,
                                   "HOP",
                                   TokenPattern.PatternType.STRING,
                                   "hop");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.SWASP,
                                   "SWASP",
                                   TokenPattern.PatternType.STRING,
                                   "swasp");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.STORK,
                                   "STORK",
                                   TokenPattern.PatternType.STRING,
                                   "stork");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.AT,
                                   "AT",
                                   TokenPattern.PatternType.STRING,
                                   "at");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.NULL,
                                   "NULL",
                                   TokenPattern.PatternType.STRING,
                                   "null");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.COMSYM,
                                   "COMSYM",
                                   TokenPattern.PatternType.STRING,
                                   "'");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.TERMI,
                                   "TERMI",
                                   TokenPattern.PatternType.STRING,
                                   ":");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.SC,
                                   "SC",
                                   TokenPattern.PatternType.STRING,
                                   ";");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.COMMA,
                                   "COMMA",
                                   TokenPattern.PatternType.STRING,
                                   ",");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EQUAL,
                                   "EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.OB,
                                   "OB",
                                   TokenPattern.PatternType.STRING,
                                   "[");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CB,
                                   "CB",
                                   TokenPattern.PatternType.STRING,
                                   "]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.OC,
                                   "OC",
                                   TokenPattern.PatternType.STRING,
                                   "{");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CC,
                                   "CC",
                                   TokenPattern.PatternType.STRING,
                                   "}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.OP,
                                   "OP",
                                   TokenPattern.PatternType.STRING,
                                   "(");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CP,
                                   "CP",
                                   TokenPattern.PatternType.STRING,
                                   ")");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ODC,
                                   "ODC",
                                   TokenPattern.PatternType.STRING,
                                   "{{");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CDC,
                                   "CDC",
                                   TokenPattern.PatternType.STRING,
                                   "}}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CONC,
                                   "CONC",
                                   TokenPattern.PatternType.STRING,
                                   ".+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CON,
                                   "CON",
                                   TokenPattern.PatternType.STRING,
                                   "?");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ODA,
                                   "ODA",
                                   TokenPattern.PatternType.STRING,
                                   "<<");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CDA,
                                   "CDA",
                                   TokenPattern.PatternType.STRING,
                                   ">>");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.NEG,
                                   "NEG",
                                   TokenPattern.PatternType.STRING,
                                   "~");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ADD,
                                   "ADD",
                                   TokenPattern.PatternType.STRING,
                                   "+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.SUB,
                                   "SUB",
                                   TokenPattern.PatternType.STRING,
                                   "-");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.MUL,
                                   "MUL",
                                   TokenPattern.PatternType.STRING,
                                   "*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DIV,
                                   "DIV",
                                   TokenPattern.PatternType.STRING,
                                   "/");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.MOD,
                                   "MOD",
                                   TokenPattern.PatternType.STRING,
                                   "%");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EXP,
                                   "EXP",
                                   TokenPattern.PatternType.STRING,
                                   "^");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.OA,
                                   "OA",
                                   TokenPattern.PatternType.STRING,
                                   "<");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CA,
                                   "CA",
                                   TokenPattern.PatternType.STRING,
                                   ">");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.OAE,
                                   "OAE",
                                   TokenPattern.PatternType.STRING,
                                   "<=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.CAE,
                                   "CAE",
                                   TokenPattern.PatternType.STRING,
                                   ">=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EE,
                                   "EE",
                                   TokenPattern.PatternType.STRING,
                                   "!=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DE,
                                   "DE",
                                   TokenPattern.PatternType.STRING,
                                   "==");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.EXC,
                                   "EXC",
                                   TokenPattern.PatternType.STRING,
                                   "!");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DAND,
                                   "DAND",
                                   TokenPattern.PatternType.STRING,
                                   "&&");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DOR,
                                   "DOR",
                                   TokenPattern.PatternType.STRING,
                                   "||");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.INCRE,
                                   "INCRE",
                                   TokenPattern.PatternType.STRING,
                                   "++");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DECRE,
                                   "DECRE",
                                   TokenPattern.PatternType.STRING,
                                   "--");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.NEWT,
                                   "NEWT",
                                   TokenPattern.PatternType.STRING,
                                   "newt");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DUCK,
                                   "DUCK",
                                   TokenPattern.PatternType.STRING,
                                   "duck");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.BULL,
                                   "BULL",
                                   TokenPattern.PatternType.STRING,
                                   "bull");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.STARLING,
                                   "STARLING",
                                   TokenPattern.PatternType.STRING,
                                   "starling");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.VIPER,
                                   "VIPER",
                                   TokenPattern.PatternType.STRING,
                                   "viper");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.NEWTLIT,
                                   "NEWTLIT",
                                   TokenPattern.PatternType.STRING,
                                   "newt literals");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.DUCKLIT,
                                   "DUCKLIT",
                                   TokenPattern.PatternType.STRING,
                                   "duck literals");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.STARLIT,
                                   "STARLIT",
                                   TokenPattern.PatternType.STRING,
                                   "starling literals");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.TRUE,
                                   "TRUE",
                                   TokenPattern.PatternType.STRING,
                                   "true");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.FALSE,
                                   "FALSE",
                                   TokenPattern.PatternType.STRING,
                                   "false");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.ID,
                                   "ID",
                                   TokenPattern.PatternType.STRING,
                                   "id");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.COMMENT,
                                   "COMMENT",
                                   TokenPattern.PatternType.STRING,
                                   "comment");
        AddPattern(pattern);

        pattern = new TokenPattern((int) SyntaxConstants.WHITESPACE,
                                   "WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[ \\t\\n\\r\\s]+");
        pattern.Ignore = true;
        AddPattern(pattern);
    }
}
