using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Library
{
    public class PredictSets
    {
        string program = "Let, Var, Task, Array, Object, Lead";
        string global = "Let, Var, Task, Array, Object, Lead";
        string global_choice = "Let, Var, Array, Task, Object";
        string dtype = "Int, Double, Char, String, Double";
        string OBJECT = "Object";
        string objdec_choice = "Object, Var, End";
        string var = "Var";
        string objvar = "Object";
        string varname = "id, ., ;, .";
        string task = "Task";
        string RETURN = "Null, Int, Double, Char, String, Boolean";
        string tparam = "(, .";
        string tparams = ";, )";
        string array = "Array";
        string size = "intlit";
        string sizes = "by, .";
        string varlet = "Let, Var";
        string vardec = "Int, Double, Char, String, Boolean";
        string varINT = "Int";
        string initINT = "is, .";
        string varDOUBLE = "Double";
        string initDOUBLE = "is, .";
        string varCHAR = "Char";
        string initCHAR = "is, .";
        string varSTRING = "String";
        string initSTRING = "is, .";
        string varBOOLEAN = "Boolean";
        string initBOOLEAN = "is, .";
        string ids1 = ";, .";
        string ids2 = ";, .";
        string ids3 = ";, .";
        string ids4 = ";, .";
        string ids5 = ";, .";
        string ids1_tail = "is";
        string ids2_tail = "is";
        string ids3_tail = "is";
        string ids4_tail = "is";
        string ids5_tail = "is";
        string value1 = "intlit, (";
        string value2 = "doublelit, (";
        string value3 = "charlit";
        string value4 = "stringlit";
        string value5 = "boollit";
        string numvalue = "intlit";
        string Operations1 = "+, -, *, /, %, ), ;, .";
        string OpInt = "intlit, (";
        string Op1 = "+, -, *, /, %, ), ;, .";
        string doublevalue = "doublelit";
        string Operations2 = "+, -, *, /, %, ), ;, .";
        string OpDouble = "doublelit, (";
        string Op2 = "+, -, *, /, %, ), ;, .";
        string mathOp = "+, - *, /, %";
        string incdec = "++, --";
        string relop1 = "==, !=, >, <, >=, <=";
        string logop1 = "&&, ||";
        string logop2 = "!, boollit, id, (";
        string body = "Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option";
        string statements = "Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, ., Stop, End";
        string functions = "Var, Int, Char, Boolean, Double, String, Array, Clear, id, ++, --, Read, Say, Object, If, Until, Do, For, Option";
        string id_choices = "[";
        string subelement_choice = "++, --, =, Int, Double, Char, String, Boolean";
        string varinitINT = "Int";
        string varinitDOUBLE = "Double";
        string varinitCHAR = "Char";
        string varinitSTRING = "String";
        string varinitBOOLEAN = "Boolean";
        string INT = "intlit, id, (, ++, --";
        string intchoices = "@, ++, --, (, .";
        string intchoice1 = "@, ++, --";
        string intchoice2 = "(";
        string incdec_null = "++, --, +, -, *, /, %, .";
        string DOUBLE = "double, id, (, ++, --";
        string doublechoices = "@, ++, --, (, .";
        string doublechoice1 = "@, ++, --";
        string doublechoice2 = "(";
        string CHAR = "charlit, id";
        string STRING = "stringlit, id";
        string BOOLEAN = "boollit, id";
        string task_id = "id";
        string param = "intlit, doublelit, charlit, stringlit, boollit, id, )";
        string PARAMS = ";, )";
        string value = "intlit, doublelit, charlit, stringlit, boollit, id";
        string io_statement = "Read, Say";
        string input = "Read";
        string output = "Say";
        string input_statement = "stringlit, id";
        string concat = ",, .";
        string concat_value = "stringlit, id";
        string incdecvar = "++, --, id";
        string subelement = "@, ++, --, @, Start, ,, ., &&, ||, >=, <=, <, >, ==, !=, ), ;";
        string input_id = "id";
        string multi = "[, =";
        string index = "intlit, id, ]";
        string IfOtherwise = "If";
        string or = "Or, intlit, doublelit, charlit, stringlit, !, id, boollit, (, Otherwise";
        string otherwise = "Otherwise, EndIf";
        string cond_loop = "Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, Loop, LoopIf, Skip, Stop, Or, intlit, doublelit, charlit, stringlit, !, id, boollit, (, ), EndIf, Otherwise";
        string control = "Skip, Stop, Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, Loop, LoopIf, Skip, Stop, Or, intlit, doublelit, charlit, stringlit, !, boollit, (, ), EndIf, Otherwise";
        string conditions = "intlit, doublelit, charlit, stringlit, !, id, boollit, (, id, !, boollit, !, (";
        string conditionschoice = "intlit, doublelit, charlit, stringlit, !, id, boollit, (";
        string multiconds = "(";
        string idschoice = "!, id, boollit, intlit, doublelit, charlit, stringlit";
        string idschoice1 = "id, boollit";
        string idsbody = "@, (, &&, ||, >=, <=, <, >, ==, !=, )";
        string condsTail = "&&, ||, >=, <=, <, >, ==, !=, )";
        string logOps = "&&, ||, )";
        string relOps = ">=, <=, <, >, ==, !=";
        string relopNum = ">=, <=, <, >";
        string relopText = "==, !=";
        string numval = "intlit, doublelit, id";
        string ids = "id, !, boollit, id";
        string ids_null = "boollit, id";
        string option = "Option";
        string optiontails = "intlit, charlit, stringlit";
        string optiontail1 = "intlit";
        string optiontail2 = "charlit";
        string optiontail3 = "stringlit";
        string state1 = "State, Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, Default";
        string state2 = "State, Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, Default";
        string state3 = "State, Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, Default";
        string DEFAULT = "Default, End";
        string loopstate = "Until, Do, For";
        string initialize = "id, ;";
        string cond = "id, ;";
        string taskdef = "Task, #";
        string returntype = "Int, Double, Char, String, Boolean, Null";
        string taskbody = "Start";
        string taskbodytail = "Var, Clear, id, Int, Char, Boolean, Double, String, ++, --, Object, Until, Do, For, Array, If, Read, Say, Option, .";
        string returnINT = "intlit, id";
        string returnDOUBLE = "doublelit, id";
        string returnCHAR = "charlit, id";
        string returnSTRING = "stringlit, id";
        string returnBOOLEAN = "boollit, id";
        string returntail = "(, @, .";
        string StartProgram = "Lead, Let, Var, Task, Array, Object";

        public string GetPredictSet(int code)
        {
            switch (code)
            {
        //             Prod_start_program = 2001,
        //Prod_program = 2002,
        //Prod_global = 2003,
        //Prod_global_choice = 2004,
        //Prod_dtype = 2005,
        //Prod_object = 2006,
        //Prod_objdec_choice = 2007,
        //Prod_var = 2008,
        //Prod_objvar = 2009,
        //Prod_varname = 2010,
        //Prod_varnames = 2011,
        //Prod_task = 2012,
        //Prod_return = 2013,
        //Prod_tparam = 2014,
        //Prod_tparams = 2015,
        //Prod_array = 2016,
        //Prod_size = 2017,
        //Prod_sizes = 2018,
        //Prod_varlet = 2019,
        //Prod_vardec = 2020,
        //Prod_var_int = 2021,
        //Prod_init_int = 2022,
        //Prod_var_double = 2023,
        //Prod_init_double = 2024,
        //Prod_var_char = 2025,
        //Prod_init_char = 2026,
        //Prod_var_string = 2027,
        //Prod_init_string = 2028,
        //Prod_var_boolean = 2029,
        //Prod_init_boolean = 2030,
        //Prod_ids1 = 2031,
        //Prod_ids2 = 2032,
        //Prod_ids3 = 2033,
        //Prod_ids4 = 2034,
        //Prod_ids5 = 2035,
        //Prod_ids1_tail = 2036,
        //Prod_ids2_tail = 2037,
        //Prod_ids3_tail = 2038,
        //Prod_ids4_tail = 2039,
        //Prod_ids5_tail = 2040,
        //Prod_value1 = 2041,
        //Prod_value2 = 2042,
        //Prod_value3 = 2043,
        //Prod_value4 = 2044,
        //Prod_value5 = 2045,
        //Prod_numvalue = 2046,
        //Prod_numelement = 2047,
        //Prod_operations1 = 2048,
        //Prod_op_int = 2049,
        //Prod_op1 = 2050,
        //Prod_doublevalue = 2051,
        //Prod_operations2 = 2052,
        //Prod_op_double = 2053,
        //Prod_op2 = 2054,
        //Prod_math_op = 2055,
        //Prod_incdec = 2056,
        //Prod_relop1 = 2057,
        //Prod_logop1 = 2058,
        //Prod_logop2 = 2059,
        //Prod_body = 2060,
        //Prod_statements = 2061,
        //Prod_functions = 2062,
        //Prod_id_choices = 2063,
        //Prod_subelement_choice = 2064,
        //Prod_varinit = 2065,
        //Prod_varinit_int = 2066,
        //Prod_varinit_double = 2067,
        //Prod_varinit_char = 2068,
        //Prod_varinit_string = 2069,
        //Prod_varinit_boolean = 2070,
        //Prod_int = 2071,
        //Prod_intchoices = 2072,
        //Prod_intchoice1 = 2073,
        //Prod_intchoice2 = 2074,
        //Prod_double = 2075,
        //Prod_doublechoices = 2076,
        //Prod_doublechoice1 = 2077,
        //Prod_doublechoice2 = 2078,
        //Prod_char = 2079,
        //Prod_string = 2080,
        //Prod_boolean = 2081,
        //Prod_task_id = 2082,
        //Prod_param = 2083,
        //Prod_params = 2084,
        //Prod_value = 2085,
        //Prod_io_statement = 2086,
        //Prod_input = 2087,
        //Prod_output = 2088,
        //Prod_input_statement = 2089,
        //Prod_concat = 2090,
        //Prod_concat_value = 2091,
        //Prod_subelement = 2092,
        //Prod_input_id = 2093,
        //Prod_multi = 2094,
        //Prod_index = 2095,
        //Prod_if_otherwise = 2096,
        //Prod_or = 2097,
        //Prod_otherwise = 2098,
        //Prod_cond_loop = 2099,
        //Prod_control = 2100,
        //Prod_conditions = 2101,
        //Prod_conditionschoice = 2102,
        //Prod_multiconds = 2103,
        //Prod_idschoice = 2104,
        //Prod_idschoice1 = 2105,
        //Prod_idsbody = 2106,
        //Prod_conds_tail = 2107,
        //Prod_log_ops = 2108,
        //Prod_rel_ops = 2109,
        //Prod_relop_num = 2110,
        //Prod_relop_text = 2111,
        //Prod_numval = 2112,
        //Prod_option = 2113,
        //Prod_optiontails = 2114,
        //Prod_optiontail1 = 2115,
        //Prod_optiontail2 = 2116,
        //Prod_optiontail3 = 2117,
        //Prod_state1 = 2118,
        //Prod_state2 = 2119,
        //Prod_state3 = 2120,
        //Prod_default = 2121,
        //Prod_incdecvar = 2122,
        //Prod_loopstate = 2123,
        //Prod_initialize = 2124,
        //Prod_cond = 2125,
        //Prod_taskdef = 2126,
        //Prod_returntype = 2127,
        //Prod_taskbody = 2128,
        //Prod_taskbodytail = 2129,
        //Prod_return_int = 2130,
        //Prod_return_double = 2131,
        //Prod_return_char = 2132,
        //Prod_return_string = 2133,
        //Prod_return_boolean = 2134,
        //Prod_returntail = 2135
            }
            return "";
        }
    }
    
}
