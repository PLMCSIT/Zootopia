/*
 * SyntaxParser.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using Core.Library;

/**
 * <remarks>A token stream parser.</remarks>
 */
public class SyntaxParser : RecursiveDescentParser {

    /**
     * <summary>An enumeration with the generated production node
     * identity constants.</summary>
     */
    private enum SynteticPatterns {
    }

    /**
     * <summary>Creates a new parser with a default analyzer.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public SyntaxParser(TextReader input)
        : base(input) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new parser.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <param name='analyzer'>the analyzer to parse with</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public SyntaxParser(TextReader input, SyntaxAnalyzer analyzer)
        : base(input, analyzer) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new tokenizer for this parser. Can be overridden
     * by a subclass to provide a custom implementation.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <returns>the tokenizer created</returns>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    protected override Tokenizer NewTokenizer(TextReader input) {
        return new SyntaxTokenizer(input);
    }

    /**
     * <summary>Initializes the parser by creating all the production
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        ProductionPattern             pattern;
        ProductionPatternAlternative  alt;

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_PROGRAM,
                                        "prod_program");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ENTRANCE, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL_DEC, 0, 1);
        alt.AddToken((int) SyntaxConstants.MANE, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MANE, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SUB_FUNCTION, 0, 1);
        alt.AddToken((int) SyntaxConstants.EXIT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_COMMENT,
                                        "prod_comment");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMSYM, 1, 1);
        alt.AddToken((int) SyntaxConstants.COMMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_GLOBAL_DEC,
                                        "prod_global_dec");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_DEC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL_DEC, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_CONST_DEC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL_DEC, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAR_DEC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL_DEC, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.VIPER, 1, 1);
        alt.AddToken((int) SyntaxConstants.AT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_NAME, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_VAR_DEC,
                                        "prod_var_dec");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_IDENT_VAR, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_VAR, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNC_VAR,
                                        "prod_func_var");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDENT_VAR,
                                        "prod_ident_var");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
        alt.AddToken((int) SyntaxConstants.AT, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_DTYPE,
                                        "prod_dtype");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DUCK, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.STARLING, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.BULL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_NEXT2VAR,
                                        "prod_next2var");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_IDCHOICE, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ARRAY1D, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDCHOICE,
                                        "prod_idchoice");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_NEXT2VAR_TAIL,
                                        "prod_next2var_tail");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_VAL,
                                        "prod_val");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL1, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL2, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_VAL1,
                                        "prod_val1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWTLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DUCKLIT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_VAL2,
                                        "prod_val2");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.STARLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_BUL_LIT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_BUL_LIT,
                                        "prod_bulLit");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.TRUE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.FALSE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRAY1D,
                                        "prod_array1D");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SIZE, 1, 1);
        alt.AddToken((int) SyntaxConstants.CB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM1D_NEXT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM1D_NEXT,
                                        "prod_elem1D_next");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_1D_INITIAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SIZE, 1, 1);
        alt.AddToken((int) SyntaxConstants.CB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM2D_NEXT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_1D_INITIAL,
                                        "prod_1D_initial");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM1D_LIST, 1, 1);
        alt.AddToken((int) SyntaxConstants.CC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM1D_LIST,
                                        "prod_elem1D_list");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEMLIST1D_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEMLIST1D_TAIL,
                                        "prod_elemlist1D_tail");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEMLIST1D_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM2D_NEXT,
                                        "prod_elem2D_next");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_2D_INITIAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_2D_INITIAL,
                                        "prod_2D_initial");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM2D_LIST, 1, 1);
        alt.AddToken((int) SyntaxConstants.CC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM2D_LIST,
                                        "prod_elem2D_list");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM1D_LIST, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM2D_LIST_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM2D_LIST_TAIL,
                                        "prod_elem2D_list_tail");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ELEM1D_LIST, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_SIZE,
                                        "prod_size");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWTLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATHEQ, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONST_DEC,
                                        "prod_const_dec");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.LET, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_IDENT_VAR, 1, 1);
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONST_NEXT, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONST_NEXT,
                                        "prod_const_next");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONST_NEXT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNC_NAME,
                                        "prod_func_name");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAM,
                                        "prod_param");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_PARAM2, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAM2,
                                        "prod_param2");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_PARAM2, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STORK_DEC,
                                        "prod_stork_dec");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.STORK, 1, 1);
        alt.AddToken((int) SyntaxConstants.AT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_NAME, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_ELEM, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTISTORK_ELEM, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_OBJ_DEC, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STORK_NAME,
                                        "prod_stork_name");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STORK_ELEM,
                                        "prod_stork_elem");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_IDENT_VAR, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_VARDEC, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTISTORK_ELEM, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MULTI_VARDEC,
                                        "prod_multi_vardec");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_VARDEC, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MULTISTORK_ELEM,
                                        "prod_multistork_elem");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_ELEM, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_OBJ_DEC,
                                        "prod_obj_dec");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_VARDEC, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MANE,
                                        "prod_mane");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_LOCAL_DEC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STORK_ACC,
                                        "prod_stork_acc");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_NAME, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOCAL_DEC,
                                        "prod_local_dec");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_IDENT_VAR, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT2VAR, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOCAL_DEC, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_ACC, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOCAL_DEC, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENT,
                                        "prod_statement");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_INPUT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_OUTPUT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_CONDITIONAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ITERATIVE, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATE_NEXT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddToken((int) SyntaxConstants.CON, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_CLRSCR, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_RETURN, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONTBREAK,
                                        "prod_contbreak");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.TERMITE, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.GALLOP, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATE_NEXT,
                                        "prod_state_next");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN1, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_FUNCTION_CALL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN1,
                                        "prod_assign1");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 0, 1);
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT_FIG, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN_TAIL,
                                        "prod_assign_tail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_SCAN_FIG, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN_CHOICE,
                                        "prod_assign_choice");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARGS1, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_NEXT_FIG,
                                        "prod_next_fig");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_EQTAIL2, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_EQTAIL1,
                                        "prod_math_eqtail1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_EQTAIL2,
                                        "prod_math_eqtail2");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATHEQ, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATHEQ,
                                        "prod_matheq");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CON, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONCAT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONCAT,
                                        "prod_concat");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CON, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONCAT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_TAIL,
                                        "prod_math_tail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_OP,
                                        "prod_math_op");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ADD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.SUB, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.MUL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DIV, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.MOD, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_FIG1,
                                        "prod_math_fig1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_CHOICE, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_EQTAIL1, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCTION_CALL,
                                        "prod_function_call");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARGS1, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARGS1,
                                        "prod_args1");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ARG_IN, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARGS_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARGS_TAIL,
                                        "prod_args_tail");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARG_IN, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARGS_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARG_IN,
                                        "prod_arg_in");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARR1D, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CLRSCR,
                                        "prod_clrscr");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.WIPE, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN,
                                        "prod_return");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.HOP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_RESULT, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_INPUT,
                                        "prod_input");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ZOOIN, 1, 1);
        alt.AddToken((int) SyntaxConstants.CDA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_INPUT, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_SCAN_FIG,
                                        "prod_scan_fig");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ARR1D, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STORK_ACCESS1, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MULTI_INPUT,
                                        "prod_multi_input");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CDA, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_INPUT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARR1D,
                                        "prod_arr1D");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SIZE, 1, 1);
        alt.AddToken((int) SyntaxConstants.CB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARR2D, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARR2D,
                                        "prod_arr2D");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OB, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SIZE, 1, 1);
        alt.AddToken((int) SyntaxConstants.CB, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_STORK_ACCESS1,
                                        "prod_stork_access1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CONC, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_OUTPUT,
                                        "prod_output");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ZOOUT, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_OUT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_OUTPUT, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_OUT,
                                        "prod_out");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.STARLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MULTI_OUTPUT,
                                        "prod_multi_output");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ODA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_OUT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTI_OUTPUT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDITIONAL,
                                        "prod_conditional");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.IF, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONDI, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONTBREAK, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EELSIF, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EELS, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.SWASP, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SWASP_CASE, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 1, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDI,
                                        "prod_condi");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_EXPR, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EXC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NOT_FIG, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_NOT_FIG,
                                        "prod_not_fig");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_BUL_LIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_EXPR, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_COND_EXPR,
                                        "prod_cond_expr");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_REL_EXPR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_EXPR,
                                        "prod_rel_expr");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_EXPRESSION, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_RELEX_TAIL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_RELEX_TAIL,
                                        "prod_relex_tail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_REL_OP1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_REL_OP2, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_REL_FIG, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXPRESSION,
                                        "prod_expression");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL1, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONDI_CHOICE, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDI_CHOICE,
                                        "prod_condi_choice");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_OP1,
                                        "prod_rel_op1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OA, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CA, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OAE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CAE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_OP2,
                                        "prod_rel_op2");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_FIG,
                                        "prod_rel_fig");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NULL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOG_EXPR,
                                        "prod_log_expr");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_REL_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_EXPR_NEXT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOG_EXPR_NEXT,
                                        "prod_log_expr_next");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_REL_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOG_EXPR_NEXT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOG_OP,
                                        "prod_log_op");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DAND, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DOR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_COND_EELSIF,
                                        "prod_cond_eelsif");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EELSIF, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONDI, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONTBREAK, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EELSIF, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_COND_EELS,
                                        "prod_cond_eels");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EELS, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_SWASP_CASE,
                                        "prod_swasp_case");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.CHAMOIS, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_TERM_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.SC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        alt.AddToken((int) SyntaxConstants.TERMITE, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SWASP_CASE1, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_SWASP_CASE1,
                                        "prod_swasp_case1");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_SWASP_CASE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_TERM_EXPR,
                                        "prod_term_expr");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWTLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.STARLIT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_DEFAULT,
                                        "prod_default");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.SEAL, 1, 1);
        alt.AddToken((int) SyntaxConstants.SC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_ITERATIVE,
                                        "prod_iterative");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.WHALE, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONDI, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG2, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DO, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG2, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddToken((int) SyntaxConstants.WHALE, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_CONDI, 1, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.FUR, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COND_EXPR, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_INCREM_DECREM, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOOP_FIG1,
                                        "prod_loop_fig1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWTLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_EXPR1,
                                        "prod_rel_expr1");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_REL_OP1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARG_IN, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOOP_FIG2,
                                        "prod_loop_fig2");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_INCREM_DECREM, 1, 1);
        alt.AddToken((int) SyntaxConstants.TERMI, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_INCREM_DECREM,
                                        "prod_increm_decrem");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_UNARY_OP, 0, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_COMP_INCDEC, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_UNARY_OP,
                                        "prod_unary_op");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.INCRE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DECRE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_COMP_INCDEC,
                                        "prod_comp_incdec");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.EQUAL, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_NEXT_FIG, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_SUB_FUNCTION,
                                        "prod_sub_function");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
        alt.AddToken((int) SyntaxConstants.AT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_NAME, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_ARGS, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_INSIDE, 1, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SUB_FUNCTION, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.VIPER, 1, 1);
        alt.AddToken((int) SyntaxConstants.AT, 1, 1);
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_ARGS, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        alt.AddToken((int) SyntaxConstants.ODC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_INSIDE, 0, 1);
        alt.AddToken((int) SyntaxConstants.CDC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_SUB_FUNCTION, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNC_INSIDE,
                                        "prod_func_inside");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_LOCAL_DEC, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNC_ARGS,
                                        "prod_func_args");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_IDENT_VAR, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_MULTIFUNC_ARGS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_MULTIFUNC_ARGS,
                                        "prod_multifunc_args");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FUNC_ARGS, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_RESULT,
                                        "prod_result");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_VAL2, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.ID, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_RESULT_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.DUCKLIT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.NEWTLIT, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FIG_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_RESULT_MATH,
                                        "prod_result_math");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FIG_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_FIG_TAIL,
                                        "prod_fig_tail");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FIG_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SyntaxConstants.PROD_RESULT_TAIL,
                                        "prod_result_tail");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) SyntaxConstants.OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_ARGS1, 0, 1);
        alt.AddToken((int) SyntaxConstants.CP, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_MATH_OP, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_LOOP_FIG1, 1, 1);
        alt.AddProduction((int) SyntaxConstants.PROD_FIG_TAIL, 0, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SyntaxConstants.PROD_ARR1D, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);
    }
}
