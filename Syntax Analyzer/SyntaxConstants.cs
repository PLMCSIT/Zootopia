/*
 * SyntaxConstants.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

/**
 * <remarks>An enumeration with token and production node
 * constants.</remarks>
 */
public enum SyntaxConstants {
    ENTRANCE = 1001,
    EXIT = 1002,
    MANE = 1003,
    LET = 1004,
    WIPE = 1005,
    ZOOIN = 1006,
    ZOOUT = 1007,
    IF = 1008,
    EELSIF = 1009,
    EELS = 1010,
    CHAMOIS = 1011,
    TERMITE = 1012,
    SEAL = 1013,
    WHALE = 1014,
    DO = 1015,
    FUR = 1016,
    HOP = 1017,
    SWASP = 1018,
    STORK = 1019,
    AT = 1020,
    NULL = 1021,
    COMSYM = 1022,
    TERMI = 1023,
    SC = 1024,
    COMMA = 1025,
    EQUAL = 1026,
    OB = 1027,
    CB = 1028,
    OC = 1029,
    CC = 1030,
    OP = 1031,
    CP = 1032,
    ODC = 1033,
    CDC = 1034,
    CONC = 1035,
    CON = 1036,
    ODA = 1037,
    CDA = 1038,
    NEG = 1039,
    ADD = 1040,
    SUB = 1041,
    MUL = 1042,
    DIV = 1043,
    MOD = 1044,
    EXP = 1045,
    OA = 1046,
    CA = 1047,
    OAE = 1048,
    CAE = 1049,
    EE = 1050,
    DE = 1051,
    EXC = 1052,
    DAND = 1053,
    DOR = 1054,
    INCRE = 1055,
    DECRE = 1056,
    NEWT = 1057,
    DUCK = 1058,
    BULL = 1059,
    STARLING = 1060,
    VIPER = 1061,
    NEWTLIT = 1062,
    DUCKLIT = 1063,
    STARLIT = 1064,
    TRUE = 1065,
    FALSE = 1066,
    ID = 1067,
    COMMENT = 1068,
    WHITESPACE = 1069,
    PROD_PROGRAM = 2001,
    PROD_COMMENT = 2002,
    PROD_GLOBAL_DEC = 2003,
    PROD_VAR_DEC = 2004,
    PROD_FUNC_VAR = 2005,
    PROD_IDENT_VAR = 2006,
    PROD_DTYPE = 2007,
    PROD_NEXT2VAR = 2008,
    PROD_IDCHOICE = 2009,
    PROD_NEXT2VAR_TAIL = 2010,
    PROD_VAL = 2011,
    PROD_VAL1 = 2012,
    PROD_VAL2 = 2013,
    PROD_BUL_LIT = 2014,
    PROD_ARRAY1D = 2015,
    PROD_ELEM1D_NEXT = 2016,
    PROD_1D_INITIAL = 2017,
    PROD_ELEM1D_LIST = 2018,
    PROD_ELEMLIST1D_TAIL = 2019,
    PROD_ELEM2D_NEXT = 2020,
    PROD_2D_INITIAL = 2021,
    PROD_ELEM2D_LIST = 2022,
    PROD_ELEM2D_LIST_TAIL = 2023,
    PROD_SIZE = 2024,
    PROD_CONST_DEC = 2025,
    PROD_CONST_NEXT = 2026,
    PROD_FUNC_NAME = 2027,
    PROD_PARAM = 2028,
    PROD_PARAM2 = 2029,
    PROD_STORK_DEC = 2030,
    PROD_STORK_ELEM = 2031,
    PROD_MULTI_VARDEC = 2032,
    PROD_MULTISTORK_ELEM = 2033,
    PROD_OBJ_DEC = 2034,
    PROD_MANE = 2035,
    PROD_LOCAL_DEC = 2036,
    PROD_STATEMENT = 2037,
    PROD_STATE_NEXT = 2038,
    PROD_ASSIGN1 = 2039,
    PROD_ASSIGN_TAIL = 2040,
    PROD_ASSIGN_CHOICE = 2041,
    PROD_NEXT_FIG = 2042,
    PROD_MATH_EQTAIL1 = 2043,
    PROD_MATH_EQTAIL2 = 2044,
    PROD_MATHEQ = 2045,
    PROD_CONCAT = 2046,
    PROD_MATH_TAIL = 2047,
    PROD_MATH_OP = 2048,
    PROD_MATH_FIG1 = 2049,
    PROD_FUNCTION_CALL = 2050,
    PROD_ARGS1 = 2051,
    PROD_ARGS_TAIL = 2052,
    PROD_ARG_IN = 2053,
    PROD_CLRSCR = 2054,
    PROD_RETURN = 2055,
    PROD_INPUT = 2056,
    PROD_SCAN_FIG = 2057,
    PROD_MULTI_INPUT = 2058,
    PROD_ARR1D = 2059,
    PROD_ARR2D = 2060,
    PROD_STORK_ACCESS1 = 2061,
    PROD_OUTPUT = 2062,
    PROD_OUT = 2063,
    PROD_MULTI_OUTPUT = 2064,
    PROD_CONDITIONAL = 2065,
    PROD_CONDI = 2066,
    PROD_NOT_FIG = 2067,
    PROD_COND_EXPR = 2068,
    PROD_REL_EXPR = 2069,
    PROD_RELEX_TAIL = 2070,
    PROD_EXPRESSION = 2071,
    PROD_REL_OP1 = 2072,
    PROD_REL_OP2 = 2073,
    PROD_REL_FIG = 2074,
    PROD_LOG_EXPR = 2075,
    PROD_LOG_EXPR_NEXT = 2076,
    PROD_LOG_OP = 2077,
    PROD_COND_EELSIF = 2078,
    PROD_COND_EELS = 2079,
    PROD_SWASP_CASE = 2080,
    PROD_SWASP_CASE1 = 2081,
    PROD_TERM_EXPR = 2082,
    PROD_DEFAULT = 2083,
    PROD_ITERATIVE = 2084,
    PROD_LOOP_FIG1 = 2085,
    PROD_REL_EXPR1 = 2086,
    PROD_LOOP_FIG2 = 2087,
    PROD_INCREM_DECREM = 2088,
    PROD_UNARY_OP = 2089,
    PROD_SUB_FUNCTION = 2090,
    PROD_FUNC_INSIDE = 2091,
    PROD_FUNC_ARGS = 2092,
    PROD_MULTIFUNC_ARGS = 2093,
    PROD_RESULT = 2094,
    PROD_RESULT_MATH = 2095,
    PROD_FIG_TAIL = 2096,
    PROD_RESULT_TAIL = 2097
}
