using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syntax_Analyzer;
using Core.Library;
using TokenLibrary.TokenLibrary;
using System.IO;
using Semantics_Analyzer;

namespace Code_Translation
{

    public class CodeTranslator : SyntaxAnalyzer
    {
        public CodeTranslator()
    : this(new List<Tokens>(), new Semantics_Analyzer.SemanticsInitializer()) { }
        public Boolean runtime_error = false;
        private List<Tokens> tokens;
        private List<SemanticsConstants.Arrays> arrays;
        private List<SemanticsConstants.Identifiers> identifiers;
        private List<SemanticsConstants.Index> index;
        private List<SemanticsConstants.Objects> objects;
        private List<SemanticsConstants.Task> task;
        private string currscope = "Mane";
        
        public CodeTranslator(List<Tokens> tokens, SemanticsInitializer semantics)
        {
            this.tokens = tokens;
            this.arrays = semantics.arrays;
            this.identifiers = semantics.identifiers;
            this.index = semantics.indexes;
            this.objects = semantics.objects;
            this.task = semantics.tasks;
        }

        public class Tokens : TokenClass
        {
            public List<string> attribute = new List<string>();

            public string datatype;

            public int code;

            public void addAttribute(string attribute)
            {
                this.attribute.Add(attribute);
            }

            public List<string> getAttribute()
            {
                return this.attribute;
            }

            public void setDatatype(string datatype)
            {
                this.datatype = datatype;
            }

            public string getDatatype()
            {
                return this.datatype;
            }

            public void setCode(int code)
            {
                this.code = code;
            }

            public int getCode()
            {
                return this.code;
            }
        }


        public string error = "";
        public string code = "using System; \nnamespace Zootopia\n{\n public class Compiler\n{\n";
        private bool isRead = false;
        private bool isSay = false;
        private bool isSwitch = false;
        private bool isCase = false;
        private bool isDo = false;
        private bool isArray = false;
        private bool isFor = false;
        private bool isOutput = false;
        private bool isAt = false;
        private bool isAdd;
        private string input_datatype;
        private bool isDec;
        private bool isMultiOutput;
        private bool isGlobal;
        private bool isIdentVar = false;
        private string varid;
        private string vardtype;
        private bool isFunct = false;
        private bool hasDeclared = false;
        private bool isFirstDec = false;
        private bool isArrayDec = false;
        private string arrval;
        private bool isFunctVar = false;
        private bool isFunctArgs = false;
        private bool isSemiDone;
        private int size;
        private bool hasArrDec = false;
        private bool hasMultiArrDec;
        private string multarrval;
        private bool isNextID;
        private bool isArrDec;

        public string Start()
        {
            string tokenstream = "";
            string result = "Code Generation Failed...\n";
            int line = 1;
            int linejump = 0;

            foreach (var t in tokens)
            {
                if (t.getLines() != line)
                {
                    linejump = t.getLines() - line;
                    line = t.getLines();
                    for (int i = 0; i < linejump; i++)
                    {
                        tokenstream += "\n";
                    }
                }
                tokenstream += t.getTokens() + " ";
            }
            tokenstream = tokenstream.TrimEnd();

            Parser p;
            p = CreateParser(tokenstream);

            try
            {
                p.Parse();
                if (error == "")
                    result = "Code Generation Succeeded...";
            }
            catch (ParserCreationException)
            {
                result = "Code Generation Halted due to Runtime Error...";
            }
            catch (ParserLogException)
            {
                result = "Code Generation Halted due to Runtime Log Error...";
            }
            return result;
        }



        private Parser CreateParser(string input)
        {
            SyntaxParser parser = null;
            try
            {
                parser = new SyntaxParser(new StringReader(input), this);
                parser.Prepare();
            }
            catch (ParserCreationException e)
            {
                throw new Exception(e.Message);
            }
            return parser;
        }

        public Tokens GetTokens(int line, int column)
        {
            List<Tokens> t = new List<Tokens>();
            Tokens token = new Tokens();
            int endline = 0;
            foreach (var item in tokens)
            {
                if (item.getLines() == line)
                    t.Add(item);
            }
            foreach (var item in t)
            {
                endline += item.getTokens().Length + 1;
                if (column <= endline)
                {
                    token = item;
                    break;
                }
            }
            return token;
        }



        //START TOKENS
        public override void EnterEntrance(Token node)
        {
            isAdd = true;
        }
        public override Node ExitEntrance(Token node)
        {
            if (isAdd)
            {
                //if (isGlobal)
                //{
                //    code += "static ";
                //    isAdd = false;
                //}
                //else
                //{
                //    isAdd = false;
                //}
                isAdd = false;
            }
            return node;
        }
        public override void EnterExit(Token node)
        {
            isAdd = true;
        }
        public override Node ExitExit(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
            string s = code;
        }
        public override void EnterMane(Token node)
        {
            isAdd = true;
        }
        public override Node ExitMane(Token node)
        {
            if (isAdd)
            {
                code += "public static void Main";
                isAdd = false;
            }
            return node;
        }
        public override void EnterLet(Token node)
        {
            isAdd = true;
        }
        public override Node ExitLet(Token node)
        {
            if (isAdd)
            {
                code += "const ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterWipe(Token node)
        {
            isAdd = true;
        }
        public override Node ExitWipe(Token node)
        {
            if (isAdd)
            {
                code += "Console.Clear()";
                isAdd = false;
            }
            return node;
        }
        public override void EnterZooin(Token node)
        {
            isAdd = true;
        }
        public override Node ExitZooin(Token node)
        {
            if (isAdd)
            {
                isRead = true;
                isAdd = false;
            }
            return node;
        }
        public override void EnterZoout(Token node)
        {
            isAdd = true;
        }
        public override Node ExitZoout(Token node)
        {
            if (isAdd)
            {
                code += "Console.Write";
                isSay = true;
                isAdd = false;
            }
            return node;
        }
        public override void EnterIf(Token node)
        {
            isAdd = true;
        }
        public override Node ExitIf(Token node)
        {
            if (isAdd)
            {
                code += "if ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterEelsif(Token node)
        {
            isAdd = true;
        }
        public override Node ExitEelsif(Token node)
        {
            if (isAdd)
            {
                code += "else if ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterEels(Token node)
        {
            isAdd = true;
        }
        public override Node ExitEels(Token node)
        {
            if (isAdd)
            {
                code += "else ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterChamois(Token node)
        {
            isAdd = true;
        }
        public override Node ExitChamois(Token node)
        {
            if (isAdd)
            {
                code += "case ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterTermite(Token node)
        {
            isAdd = true;
        }
        public override Node ExitTermite(Token node)
        {
            if (isAdd)
            {
                code += "break ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterSeal(Token node)
        {
            isAdd = true;
        }
        public override Node ExitSeal(Token node)
        {
            if (isAdd)
            {
                code += "default ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterWhale(Token node)
        {
            isAdd = true;
        }
        public override Node ExitWhale(Token node)
        {
            if (isAdd)
            {
                code += "while ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDo(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDo(Token node)
        {
            if (isAdd)
            {
                code += "do ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterFur(Token node)
        {
            isAdd = true;
        }
        public override Node ExitFur(Token node)
        {
            if (isAdd)
            {
                code += "for ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterHop(Token node)
        {
            isAdd = true;
        }
        public override Node ExitHop(Token node)
        {
            if (isAdd)
            {
                code += "return ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterSwasp(Token node)
        {
            isAdd = true;
        }
        public override Node ExitSwasp(Token node)
        {
            if (isAdd)
            {
                code += "switch ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterStork(Token node)
        {
            isAdd = true;
        }
        public override Node ExitStork(Token node)
        {
            if (isAdd)
            {
                code += "struct ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterAt(Token node)
        {
            isAdd = true;
        }
        public override Node ExitAt(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
        }
        public override void EnterNull(Token node)
        {
            isAdd = true;
        }
        public override Node ExitNull(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
        }
        public override void EnterComsym(Token node)
        {
            isAdd = true;
        }
        public override Node ExitComsym(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
        }
        public override void EnterTermi(Token node)
        {
            isAdd = true;
        }
        public override Node ExitTermi(Token node)
        {
            if (isAdd)
            {
                    if (!isFunct)
                    {
                        if (!isIdentVar)
                        {
                            if (!isFunctVar)
                            {
                                code += ";\n";
                            }
                        }
                    }
                    else
                        isFunct = false;
                    isAdd = false;
            }
            return node;
        }
        public override void EnterSc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitSc(Token node)
        {
            if (isAdd)
            {
                code += ":\n";
                isAdd = false;
            }
            return node;
        }
        public override void EnterComma(Token node)
        {
            isAdd = true;
        }
        public override Node ExitComma(Token node)
        {
            if (isAdd)
            {
                //if (hasMultiArrDec)
                //{
                    code += ", ";
                    isAdd = false;
                //}
            }
            return node;
        }
        public override void EnterEqual(Token node)
        {
            isAdd = true;
        }
        public override Node ExitEqual(Token node)
        {
            if (isAdd)
            {
                    code += " = ";
                    isAdd = false;
            }
            return node;
        }
        public override void EnterOb(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOb(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                    if(!isArrayDec)
                    code += "[";
                if (!isDec)
                    code += "[";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCb(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCb(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                    if (!isArrayDec)
                        code += "]";
                if (!isDec)
                    code += "]";
                isAdd = false;
            }
            return node;
        }
        public override void EnterOc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOc(Token node)
        {
            if (isAdd)
            {
                if (hasArrDec)
                {
                    code += "{";
                    isAdd = false;
                }
            }
            return node;
        }
        public override void EnterCc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCc(Token node)
        {
            if (isAdd)
            {
                if (hasArrDec)
                {
                    code += "}";
                    isAdd = false;
                }
           }
            return node;
        }
        public override void EnterOp(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOp(Token node)
        {
            if (isAdd)
            {
                code += "(";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCp(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCp(Token node)
        {
            if (isAdd)
            {
                if (!isFunct)
                {
                    code += ")";
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterOdc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOdc(Token node)
        {
            if (isAdd)
            {
                code += "\n{\n";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCdc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCdc(Token node)
        {
            if (isAdd)
            {
                code += "}\n";
                isAdd = false;
            }
            return node;
        }
        public override void EnterConc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitConc(Token node)
        {
            if (isAdd)
            {
                code += "+";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCon(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCon(Token node)
        {
            if (isAdd)
            {
                code += "?";
                isAdd = false;
            }
            return node;
        }
        public override void EnterOda(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOda(Token node)
        {
            if (isAdd)
            {
                if (isMultiOutput)
                {
                    code += " + ";
                }
                else
                {
                    code += "(";
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterCda(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCda(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
        }
        public override void EnterNeg(Token node)
        {
            isAdd = true;
        }
        public override Node ExitNeg(Token node)
        {
            if (isAdd)
            {
                code += "-";
                isAdd = false;
            }
            return node;
        }
        public override void EnterAdd(Token node)
        {
            isAdd = true;
        }
        public override Node ExitAdd(Token node)
        {
            if (isAdd)
            {
                code += " + ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterSub(Token node)
        {
            isAdd = true;
        }
        public override Node ExitSub(Token node)
        {
            if (isAdd)
            {
                code += " - ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterMul(Token node)
        {
            isAdd = true;
        }
        public override Node ExitMul(Token node)
        {
            if (isAdd)
            {
                code += " * ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDiv(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDiv(Token node)
        {
            if (isAdd)
            {
                code += " / ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterMod(Token node)
        {
            isAdd = true;
        }
        public override Node ExitMod(Token node)
        {
            if (isAdd)
            {
                code += " % ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterOa(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOa(Token node)
        {
            if (isAdd)
            {
                code += " < ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCa(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCa(Token node)
        {
            if (isAdd)
            {
                code += " > ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterOae(Token node)
        {
            isAdd = true;
        }
        public override Node ExitOae(Token node)
        {
            if (isAdd)
            {
                code += " <= ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterCae(Token node)
        {
            isAdd = true;
        }
        public override Node ExitCae(Token node)
        {
            if (isAdd)
            {
                code += " >= ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterEe(Token node)
        {
            isAdd = true;
        }
        public override Node ExitEe(Token node)
        {
            if (isAdd)
            {
                code += " != ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDe(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDe(Token node)
        {
            if (isAdd)
            {
                code += " == ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterExc(Token node)
        {
            isAdd = true;
        }
        public override Node ExitExc(Token node)
        {
            if (isAdd)
            {
                code += " ! ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDand(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDand(Token node)
        {
            if (isAdd)
            {
                code += " && ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDor(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDor(Token node)
        {
            if (isAdd)
            {
                code += " || ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterIncre(Token node)
        {
            isAdd = true;
        }
        public override Node ExitIncre(Token node)
        {
            if (isAdd)
            {
                code += "++";
                isAdd = false;
            }
            return node;
        }
        public override void EnterDecre(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDecre(Token node)
        {
            if (isAdd)
            {
                code += "--";
                isAdd = false;
            }
            return node;
        }
        public override void EnterNewt(Token node)
        {
            isAdd = true;
        }
        public override Node ExitNewt(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                {
                    if (!isIdentVar)
                    {
                        if (!isFunct)
                        {
                            input_datatype = "Int";
                            code += "int ";
                        }
                    }
                    
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterDuck(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDuck(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                {
                    if(!isIdentVar)
                    {
                        if (!isFunct)
                        {
                            input_datatype = "Double";
                            code += "double ";
                        }
                    }
                    
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterBull(Token node)
        {
            isAdd = true;
        }
        public override Node ExitBull(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                {
                    if (!isIdentVar)
                        if (!isFunct)
                            code += "bool ";
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterStarling(Token node)
        {
            isAdd = true;
        }
        public override Node ExitStarling(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                {
                    if(!isIdentVar)
                    {
                        if (!isFunct)
                        {
                            input_datatype = "String";
                            code += "string ";
                        }
                    }
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterViper(Token node)
        {
            isAdd = true;
        }
        public override Node ExitViper(Token node)
        {
            if (isAdd)
            {
                code += "void ";
                isAdd = false;
            }
            return node;
        }
        public override void EnterNewtlit(Token node)
        {
            isAdd = true;
        }
        public override Node ExitNewtlit(Token node)
        {
            if (isAdd)
            {
                if (!isArray)
                {
                    if (!isArrayDec)
                    {
                        Tokens t = new Tokens();
                        t = GetTokens(node.GetStartLine(), node.GetStartColumn());
                        code += t.getLexemes();
                    }
                }
                isAdd = false;
            }
            return node;
        }
        public override void EnterDucklit(Token node)
        {
            isAdd = true;
        }
        public override Node ExitDucklit(Token node)
        {
            if (isAdd)
            {
                Tokens t = new Tokens();
                t = GetTokens(node.GetStartLine(), node.GetStartColumn());
                code += t.getLexemes();
                isAdd = false;
            }
            return node;
        }
        public override void EnterStarlit(Token node)
        {
            isAdd = true;
        }
        public override Node ExitStarlit(Token node)
        {
            if (isAdd)
            {
                Tokens t = new Tokens();
                t = GetTokens(node.GetStartLine(), node.GetStartColumn());
                code += "\"" + t.getLexemes() + "\"";
                isAdd = false;
            }
            return node;
        }
        public override void EnterTrue(Token node)
        {
            isAdd = true;
        }
        public override Node ExitTrue(Token node)
        {
            if (isAdd)
            {
                code += "true";
                isAdd = false;
            }
            return node;
        }
        public override void EnterFalse(Token node)
        {
            isAdd = true;
        }
        public override Node ExitFalse(Token node)
        {
            if (isAdd)
            {
                code += "false";
                isAdd = false;
            }
            return node;
        }
        public override void EnterId(Token node)
        {
            isAdd = true;
        }
        public override Node ExitId(Token node)
        {
            if (isAdd)
            {
                    //if (!isArray)
                    //{
                        if (!isArrDec)
                        {
                            if (!isIdentVar)
                            {
                                Tokens t = new Tokens();
                                t = GetTokens(node.GetStartLine(), node.GetStartColumn());
                                code += " " + t.getLexemes().Remove(0, 1);
                                if (isDec)
                                {
                                    int codenum = t.getCode();
                                    tokens[codenum].setDatatype(input_datatype);
                                }
                            }
                        }
                    //}
                isAdd = false;
            }
            return node;
        }
        public override void EnterComment(Token node)
        {
            isAdd = true;
        }
        public override Node ExitComment(Token node)
        {
            if (isAdd)
            {
                isAdd = false;
            }
            return node;
        }


        //END TOKENS


        public override void EnterProdProgram(Production node)
        {

        }



        public override Node ExitProdProgram(Production node)
        {
            return node;
        }


        public override void ChildProdProgram(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdComment(Production node)
        {

        }


        public override Node ExitProdComment(Production node)
        {
            return node;
        }

        public override void ChildProdComment(Production node, Node child)
        {
            node.AddChild(child);
        }

        public override void EnterProdGlobalDec(Production node)
        {
            isGlobal = true;
            currscope = "Global";
        }

        public override Node ExitProdGlobalDec(Production node)
        {
            isGlobal = false;
            currscope = "Mane";
            return node;
        }

        public override void ChildProdGlobalDec(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdVarDec(Production node)
        {
            if (currscope == "Global")
            {
                code += "\n";
            }
            isDec = true;
        }


        public override Node ExitProdVarDec(Production node)
        {
            isIdentVar = false;
            return node;
        }


        public override void ChildProdVarDec(Production node, Node child)
        {
            
            node.AddChild(child);
            if(child.GetName() == "TERMI")
            {
                if(!hasDeclared)
                {
                    if (!isFirstDec)
                    {
                        if(!(code.ElementAt(code.Length - 1) == '\n' && code.ElementAt(code.Length - 2) == ';'))
                        code += ";\n";
                    }
                    code += "public static " + vardtype + " " + varid;
                }
                isIdentVar = true;

                if (!(code.ElementAt(code.Length - 1) == '\n' && code.ElementAt(code.Length - 2) == ';'))
                    code += ";\n";
            }
        }


        public override void EnterProdFuncVar(Production node)
        {
        }


        public override Node ExitProdFuncVar(Production node)
        {
            return node;
        }


        public override void ChildProdFuncVar(Production node, Node child)
        {
            if (child.GetName() == "OP" && isIdentVar)
            {

                code = code.Remove(code.Length - 16, 16);
                isFunct = true;
                isIdentVar = false;

            }
            node.AddChild(child);
        }


        public override void EnterProdIdentVar(Production node)
        {
            if (!isFunctArgs) {
                isSemiDone = false;
                isIdentVar = true;
            }
            isFirstDec = true;
            hasDeclared = false;
            isArray = false;
        }


        public override Node ExitProdIdentVar(Production node)
        {
            vardtype = " "; varid = " ";
            Tokens t = new Tokens();
            t = GetTokens(node.GetChildAt(0).GetStartLine(), node.GetChildAt(0).GetStartColumn());
            vardtype = t.getLexemes();
            t = GetTokens(node.GetChildAt(2).GetStartLine(), node.GetChildAt(2).GetStartColumn());
            varid = t.getLexemes();
            varid = varid.Remove(0, 1);

            switch (vardtype)
            {
                case "newt":
                    vardtype = "int";
                    break;
                case "duck":
                    vardtype = "double";
                    break;
                case "starling":
                    vardtype = "string";
                    break;
                case "bull":
                    vardtype = "bool";
                    break;
            }

            return node;
        }


        public override void ChildProdIdentVar(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdDtype(Production node)
        {
        }


        public override Node ExitProdDtype(Production node)
        {
            return node;
        }


        public override void ChildProdDtype(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdNext2var(Production node)
        {
            
        }


        public override Node ExitProdNext2var(Production node)
        {
            return node;
        }


        public override void ChildProdNext2var(Production node, Node child)
        {
            node.AddChild(child);
            Tokens st = new Tokens();
            st = GetTokens(child.GetStartLine(), child.GetStartColumn());
            string ss = st.getLexemes();
            if (node.GetChildCount() == 1 && child.GetName() == "prod_array1D")
            {
                string codes = code;
                if (!isFirstDec)
                    code += ";\n";
                else
                {
                    isFirstDec = false;
                }
                if (currscope == "Global")
                {
                    code += "public static ";
                }
                hasDeclared = false;
                isArray = false;
            }
            else if (node.GetChildCount() == 1 && child.GetName() == "EQUAL")
            {
                
                code = code.Remove(code.Length - 2, 2);
                
                if (!isFirstDec)
                    code += ";\n";
                else
                {
                    isFirstDec = false;
                }
                if (currscope == "Global")
                {
                    code += "public static ";
                }
                code += vardtype + " " + varid + " = ";
                hasDeclared = true;
                isArray = false;
            }
            else if (node.GetChildCount() == 2 && node.GetChildAt(0).GetName() == "COMMA")
            {
                code = code.Remove(code.Length - 2, 2);
                if (!hasDeclared)
                {
                    if (!isFirstDec)
                       code += ";\n";
                    else
                    {
                        isFirstDec = false;
                    }
                    if (currscope == "Global")
                    {
                        code += "public static ";
                    }
                    code += vardtype + " " + varid;
                }
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                varid = t.getLexemes();
                varid = varid.Remove(0, 1);
                hasDeclared = false;
                isArray = false;    
                
            }
            if (child.GetName() == "prod_next2var")
            {
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                if(t.getLexemes() == "," && !isSemiDone)
                {
                    code += ";\n";
                    isSemiDone = true;
                    hasDeclared = false;
                    isArray = false;
                }
            }
            
        }


        public override void EnterProdNext2varTail(Production node)
        {

        }

        public override Node ExitProdNext2varTail(Production node)
        {
            return node;
        }


        public override void ChildProdNext2varTail(Production node, Node child)
        {
            node.AddChild(child);
            if (node.GetChildCount() == 2 && node.GetChildAt(0).GetName() == "COMMA")
            {
                code = code.Remove(code.Length - 2, 2);
                if (!hasDeclared)
                {
                    if (!isFirstDec)
                        code += ";\n";
                    else
                    {
                        isFirstDec = false;
                    }
                    if (currscope == "Global")
                    {
                        code += "public static ";
                    }
                    code += vardtype + " " + varid;
                }
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                varid = t.getLexemes();
                varid = varid.Remove(0, 1);
                hasDeclared = false;
            }
            if (child.GetName() == "prod_next2var")
            {
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                if (t.getLexemes() == "," && !isSemiDone)
                {
                    code += ";\n";
                    isSemiDone = true;
                    hasDeclared = false;
                }
            }


            //if (node.GetChildCount() == 2 && node.GetChildAt(0).GetName() == "COMMA")
            //{
            //    code = code.Remove(code.Length - 2, 2);
            //    if (!hasDeclared)
            //    {
            //        if (!isFirstDec)
            //            code += ";\n";
            //        else
            //        {
            //            isFirstDec = false;
            //        }
            //        if(currscope == "Global")
            //        {
            //            code += "public static ";
            //        }
            //        code += vardtype + " " + varid;
            //    }
            //    Tokens t = new Tokens();
            //    t = GetTokens(child.GetStartLine(), child.GetStartColumn());
            //    varid = t.getLexemes();
            //    varid = varid.Remove(0, 1);
            //    hasDeclared = false;
            //    isFirstDec = false;
            //}
            //if(child.GetName() == "prod_next2var")
            //{
            //    Tokens t = new Tokens();
            //    t = GetTokens(child.GetChildAt(1).GetStartLine(), child.GetChildAt(1).GetStartColumn());
            //}
        }


        public override void EnterProdVal(Production node)
        {
        }


        public override Node ExitProdVal(Production node)
        {
            return node;
        }


        public override void ChildProdVal(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdVal1(Production node)
        {
        }


        public override Node ExitProdVal1(Production node)
        {
            return node;
        }


        public override void ChildProdVal1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdVal2(Production node)
        {
        }


        public override Node ExitProdVal2(Production node)
        {
            return node;
        }


        public override void ChildProdVal2(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdBulLit(Production node)
        {
        }


        public override Node ExitProdBulLit(Production node)
        {
            return node;
        }


        public override void ChildProdBulLit(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdArray1d(Production node)
        { 
            isAdd = true;
            isArrayDec = true;
            isArray = true;
        }


        public override Node ExitProdArray1d(Production node)
        {
            string dtype = "";
            string size1 = "";
            string size2 = "";
            string arrop = "";
            string arrval = "";
            bool isMultiD = false;
            Node arr1d = node.GetChildAt(3);
            if (node.GetChildCount() == 4 && arr1d.GetChildAt(0).GetName() == "EQUAL")
            {
                hasArrDec = true;
                code = code.Remove(code.Length - 3, 3);
            }
            else if (node.GetChildCount() == 4 && arr1d.GetChildAt(0).GetName() == "OB")
            {
                isMultiD = true;
                hasArrDec = false;
            }
            else
                hasArrDec = false;

            Node size_1 = node.GetChildAt(1);
            Tokens t = new Tokens();
            t = GetTokens(size_1.GetStartLine(), size_1.GetStartColumn());
            size1 = t.getLexemes();

            switch (dtype)
            {
                case "Int": dtype = "int"; break;
                case "Double": dtype = "double"; break;
                case "String": dtype = "string"; break;
                case "Char": dtype = "char"; break;
                case "Boolean": dtype = "bool"; break;
            }

            if (isMultiD)
            {
                Node multi = node.GetChildAt(3);
                code = code.Remove(code.Length - 4, 4);
                if (multi.GetName() == "prod_elem1D_next")
                {
                    Node size_2 = multi.GetChildAt(1);
                    t = GetTokens(size_2.GetStartLine(), size_2.GetStartColumn());
                    size2 = t.getLexemes();
                    code += vardtype + "[][] " + varid + " = new " + vardtype + "[" + size1 + "][];\n";
                    for (int i = 0; i < Int32.Parse(size1); i++)
                    {
                        code += varid + "[" + i + "] = new " + vardtype + "[" + size2 + "];\n";
                    }
                    code = code.Remove(code.Length - 2, 2);
                }
                isArrDec = false;
            }
            else if (hasArrDec)
            {
                Node arrset = node.GetChildAt(3);
                if (arrset.GetChildAt(1).GetChildAt(0).GetName() == "OC")
                {
                        Node arr_val = node.GetChildAt(3).GetChildAt(1).GetChildAt(1);
                        t = GetTokens(arr_val.GetStartLine(), arr_val.GetStartColumn());
                        arrval = t.getLexemes();
                        if (arr_val.GetChildCount() > 1 && arr_val.GetChildAt(1).GetChildAt(0).GetName() == "COMMA")
                        {
                            hasMultiArrDec = true;
                            Node multarr_val = arr_val.GetChildAt(1).GetChildAt(1);
                            t = GetTokens(multarr_val.GetStartLine(), multarr_val.GetStartColumn());
                            multarrval = t.getLexemes();
                            code += ", " + multarrval;
                            arrval += ", " + multarrval;
                            code = code.Remove(code.Length - 3, 3);
                        }
                        code = code.Remove(code.Length - 4, 4);
                        code += vardtype + "[]" + varid + " = " + "{ " + arrval + " };\n";
                }
                else
                {
                    Node arr_val = node.GetChildAt(3).GetChildAt(1).GetChildAt(0);
                    t = GetTokens(arr_val.GetStartLine(), arr_val.GetStartColumn());
                    arrval = t.getLexemes();
                    code += vardtype + "[]" + varid + " = " + arrval + ";\n";
                }
                isArrDec = true;
            }

            else
            {
                //Node arrop_check = node.GetChildAt(1);
                //if (arrop_check.GetChildAt(1).GetName() == "prod_matheq")
                //{
                //    isArray = true;
                //    Node arr_op = node.GetChildAt(1).GetChildAt(1).GetChildAt(0);
                //    //Node arr_op_val = arr_op.GetChildAt(1);
                //    t = GetTokens(arr_op.GetStartLine(), arr_op.GetStartColumn());
                //    arrop = t.getLexemes();
                //    code = code.Remove(code.Length - 3, 3);
                //    code += vardtype + "[] " + varid + "= new " + vardtype + "[" + size1 + "]";
                //}
                //else
                //{
                code = code.Remove(code.Length -2, 2);
                    code += vardtype + "[] " + varid + " = new " + vardtype + "[" + size1 + "]";
                //}
            }
            isArray = true;
            return node;
        }


        public override void ChildProdArray1d(Production node, Node child)
        {
            node.AddChild(child);
            //isArray = true;
            //if(hasArrDec)
            //{
            //    Tokens t = new Tokens();
            //    if (node.GetChildCount() == 4)
            //    {
            //        Node arrset = node.GetChildAt(3);
            //        if (arrset.GetChildAt(1).GetChildAt(0).GetName() == "OC")
            //        {
            //            Node arr_val = node.GetChildAt(3).GetChildAt(1).GetChildAt(1);
            //            t = GetTokens(arr_val.GetStartLine(), arr_val.GetStartColumn());
            //            arrval = t.getLexemes();
            //            if (arr_val.GetChildCount() > 1 && arr_val.GetChildAt(1).GetChildAt(0).GetName() == "COMMA")
            //            {
            //                hasMultiArrDec = true;
            //                Node multarr_val = arr_val.GetChildAt(1).GetChildAt(1);
            //                t = GetTokens(multarr_val.GetStartLine(), multarr_val.GetStartColumn());
            //                multarrval = t.getLexemes();
            //                code += ", " + multarrval;
            //                arrval += ", " + multarrval;
            //                code = code.Remove(code.Length - 3, 3);
            //            }
            //            code = code.Remove(code.Length - 4, 4);
            //            code += vardtype + "[]" + varid + " = " + "{ " + arrval + " };\n";

            //        }
            //        else
            //        {
            //            Node arr_val = node.GetChildAt(3).GetChildAt(1).GetChildAt(0);
            //            t = GetTokens(arr_val.GetStartLine(), arr_val.GetStartColumn());
            //            arrval = t.getLexemes();
            //            code += vardtype + "[]" + varid + " = " + arrval + ";\n";
            //        }
            //    }
            //    else
            //    {

            //    }
            //}
            
        }


        public override void EnterProdElem1dNext(Production node)
        {
        }


        public override Node ExitProdElem1dNext(Production node)
        {
            return node;
        }


        public override void ChildProdElem1dNext(Production node, Node child)
        {
            //if (node.GetChildCount() == 1 && child.GetName() == "EQUAL")
            //{
            //    if (node.GetChildAt(0).GetChildAt(0).GetName() == "OC")
            //    { }
            //    code = code.Remove(code.Length - 2, 2);

            //    if (!isFirstDec)
            //        code += ";\n";
            //    else
            //    {
            //        isFirstDec = false;
            //    }
            //    if (currscope == "Global")
            //    {
            //        code += "public static ";
            //    }
            //    code += vardtype + " " + varid + " = ";
            //    hasDeclared = true;
            //}
            node.AddChild(child);
            //if(node.GetChildCount() == 3 && node.GetChildAt(0).GetName() == "COMMA")
            //{
            //    Tokens t = new Tokens();
            //    hasMultiArrDec = true;
            //    Node multarr_val = node.GetChildAt(1).GetChildAt(1).GetChildAt(0);
            //    t = GetTokens(multarr_val.GetStartLine(), multarr_val.GetStartColumn());
            //    multarrval = t.getLexemes();
            //    code += ", " + multarrval;
            //    arrval += ", " + multarrval;
            //    code = code.Remove(code.Length - 3, 3);
            //}
        }


        public override void EnterProdElem1dList(Production node)
        {
        }


        public override Node ExitProdElem1dList(Production node)
        {
            return node;
        }


        public override void ChildProdElem1dList(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdElemlist1dTail(Production node)
        {
        }


        public override Node ExitProdElemlist1dTail(Production node)
        {
            return node;
        }


        public override void ChildProdElemlist1dTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdElem2dNext(Production node)
        {
        }


        public override Node ExitProdElem2dNext(Production node)
        {
            return node;
        }


        public override void ChildProdElem2dNext(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdElem2dList(Production node)
        {
        }


        public override Node ExitProdElem2dList(Production node)
        {
            return node;
        }


        public override void ChildProdElem2dList(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdElem2dListTail(Production node)
        {
        }


        public override Node ExitProdElem2dListTail(Production node)
        {
            return node;
        }


        public override void ChildProdElem2dListTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdSize(Production node)
        {
        }


        public override Node ExitProdSize(Production node)
        {
            return node;
        }


        public override void ChildProdSize(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdConstDec(Production node)
        {
        }


        public override Node ExitProdConstDec(Production node)
        {
            return node;
        }


        public override void ChildProdConstDec(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdConstNext(Production node)
        {
        }


        public override Node ExitProdConstNext(Production node)
        {
            return node;
        }


        public override void ChildProdConstNext(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdFuncName(Production node)
        {
        }


        public override Node ExitProdFuncName(Production node)
        {
            return node;
        }


        public override void ChildProdFuncName(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdParam(Production node)
        {
        }


        public override Node ExitProdParam(Production node)
        {
            return node;
        }


        public override void ChildProdParam(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdParam2(Production node)
        {
        }


        public override Node ExitProdParam2(Production node)
        {
            return node;
        }


        public override void ChildProdParam2(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdStorkDec(Production node)
        {
        }


        public override Node ExitProdStorkDec(Production node)
        {
            return node;
        }


        public override void ChildProdStorkDec(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdStorkElem(Production node)
        {
        }


        public override Node ExitProdStorkElem(Production node)
        {
            return node;
        }


        public override void ChildProdStorkElem(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMultiVardec(Production node)
        {
        }


        public override Node ExitProdMultiVardec(Production node)
        {
            return node;
        }


        public override void ChildProdMultiVardec(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMultistorkElem(Production node)
        {
        }


        public override Node ExitProdMultistorkElem(Production node)
        {
            return node;
        }


        public override void ChildProdMultistorkElem(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdObjDec(Production node)
        {
        }


        public override Node ExitProdObjDec(Production node)
        {
            return node;
        }


        public override void ChildProdObjDec(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMane(Production node)
        {
        }


        public override Node ExitProdMane(Production node)
        {
            code += "\nConsole.ReadKey();\n";
            return node;
        }


        public override void ChildProdMane(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdLocalDec(Production node)
        {
        }


        public override Node ExitProdLocalDec(Production node)
        {
            isIdentVar = false;
            return node;
        }


        public override void ChildProdLocalDec(Production node, Node child)
        {
            node.AddChild(child);

            if (child.GetName() == "TERMI")
            {
                //if (!isArray)
                //{
                    //if (!isArrDec)
                    //{
                        if (!hasDeclared)
                        {
                            if (!isFirstDec)
                            {
                                if (!(code.ElementAt(code.Length - 1) == '\n' && code.ElementAt(code.Length - 2) == ';'))
                                    code += ";\n";
                            }
                            code += vardtype + " " + varid;
                        }

                        isIdentVar = true;

                        if (!(code.ElementAt(code.Length - 1) == '\n' && code.ElementAt(code.Length - 2) == ';'))
                            code += ";\n";
                    //}
                //}
                //if (isArray)
                //{
                    //code += ";\n";
                //}
            }
        }


        public override void EnterProdStatement(Production node)
        {
        }


        public override Node ExitProdStatement(Production node)
        {

            return node;
        }


        public override void ChildProdStatement(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdStateNext(Production node)
        {
        }


        public override Node ExitProdStateNext(Production node)
        {
            return node;
        }


        public override void ChildProdStateNext(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdAssign1(Production node)
        {
        }


        public override Node ExitProdAssign1(Production node)
        {
            return node;
        }


        public override void ChildProdAssign1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdAssignTail(Production node)
        {
        }


        public override Node ExitProdAssignTail(Production node)
        {
            return node;
        }


        public override void ChildProdAssignTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdNextFig(Production node)
        {
        }


        public override Node ExitProdNextFig(Production node)
        {

            return node;
        }


        public override void ChildProdNextFig(Production node, Node child)
        {
            node.AddChild(child);
        }

        


        public override void EnterProdArgs1(Production node)
        {
        }


        public override Node ExitProdArgs1(Production node)
        {
            return node;
        }


        public override void ChildProdArgs1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdArgsTail(Production node)
        {
        }


        public override Node ExitProdArgsTail(Production node)
        {
            return node;
        }


        public override void ChildProdArgsTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdArgIn(Production node)
        {
        }


        public override Node ExitProdArgIn(Production node)
        {
            return node;
        }


        public override void ChildProdArgIn(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMathEqtail1(Production node)
        {
        }


        public override Node ExitProdMathEqtail1(Production node)
        {

            return node;
        }


        public override void ChildProdMathEqtail1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMathEqtail2(Production node)
        {
        }


        public override Node ExitProdMathEqtail2(Production node)
        {
            return node;
        }


        public override void ChildProdMathEqtail2(Production node, Node child)
        {
            node.AddChild(child);
        }








        public override void EnterProdMathTail(Production node)
        {
        }


        public override Node ExitProdMathTail(Production node)
        {
            return node;
        }


        public override void ChildProdMathTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMathOp(Production node)
        {
        }


        public override Node ExitProdMathOp(Production node)
        {
            return node;
        }


        public override void ChildProdMathOp(Production node, Node child)
        {
            //Node op = child.GetChildAt(0);
            //if (op.GetName() == "ADD")
            //{

            //}
            //else if (op.GetName() == "SUB")
            //{

            //}
            //else if (op.GetName() == "MUL")
            //{

            //}
            //else if (op.GetName() == "DIV")
            //{

            //}
            //else
            //{

            //}
            node.AddChild(child);
        }


        //public override void EnterProdMathFig(Production node)
        //{

        //}


        //public override Node ExitProdMathFig(Production node)
        //{
        //    return node;
        //}


        //public override void ChildProdMathFig(Production node, Node child)
        //{
        //    Node val = child.GetChildAt(0);

        //    node.AddChild(child);
        //}


        public override void EnterProdMathFig1(Production node)
        {
        }


        public override Node ExitProdMathFig1(Production node)
        {
            return node;
        }


        public override void ChildProdMathFig1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMatheq(Production node)
        {
        }


        public override Node ExitProdMatheq(Production node)
        {
            return node;
        }


        public override void ChildProdMatheq(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdFunctionCall(Production node)
        {
        }


        public override Node ExitProdFunctionCall(Production node)
        {
            return node;
        }


        public override void ChildProdFunctionCall(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdClrscr(Production node)
        {
        }


        public override Node ExitProdClrscr(Production node)
        {
            return node;
        }


        public override void ChildProdClrscr(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdInput(Production node)
        {
        }


        public override Node ExitProdInput(Production node)
        {

            return node;
            //if (!runtime_error)
            //{
            //    Node isRead = node.GetChildAt(0);
            //    if (isRead.GetName() == "READ")
            //    {
            //        Node id = node.GetChildAt(1);
            //        int idcol = id.GetStartColumn();
            //        int idline = id.GetStartLine();
            //        Tokens token = GetTokens(idline, idcol);
            //        foreach (var item in identifiers)
            //        {
            //            if (item.getId() == token.getLexemes())
            //            {
            //                var input = (String)Console.ReadLine();
            //                if(String.IsNullOrEmpty(input))
            //                {

            //                    input = Console.ReadLine();
            //                }
            //                string dtype = item.getDtype();
            //                bool isneg = false;
            //                switch (dtype)
            //                {
            //                    case "Int":
            //                        int input_int = 0;
            //                        if (input.Contains("~"))
            //                        {
            //                            isneg = true;
            //                            input = input.Remove(0, 1);
            //                        }
            //                        if (Int32.TryParse(input, out input_int))
            //                        {
            //                            if (isneg)
            //                            {
            //                                input_int *= -1;
            //                            }
            //                            item.setValue(input_int.ToString());
            //                        }
            //                        else
            //                        {
            //                            runtime_error = true;
            //                            Console.WriteLine("");
            //                            Console.WriteLine("Runtime error: Type mismatch!");

            //                        }
            //                        break;
            //                    case "Double":
            //                        double input_double = 0;
            //                        if (input.Contains("~"))
            //                        {
            //                            isneg = true;
            //                            input = input.Remove(0, 1);
            //                        }
            //                        if (Double.TryParse(input, out input_double))
            //                        {
            //                            if (isneg)
            //                            {
            //                                input_double *= -1;
            //                            }
            //                            item.setValue(input_double.ToString());
            //                        }
            //                        else
            //                        {
            //                            runtime_error = true;
            //                            Console.WriteLine("");
            //                            Console.WriteLine("Runtime error: Type mismatch!");
            //                        }

            //                        break;
            // 

        }


        public override void ChildProdInput(Production node, Node child)
        {
            if (child.GetName() == "ID")
            {
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                //t = tokens[t.getCode()];
                string input_datatype = "";

                foreach (var item in identifiers)
                {
                    if (item.getScope() == currscope)
                    {
                        if (item.getId() == t.getLexemes())
                        {
                            input_datatype = item.getDtype();
                        }
                    }
                }

                switch (input_datatype)
                {
                    case "Newt": code += " = Int32.Parse(Console.ReadLine())"; break;
                    case "Duck": code += " = Double.Parse(Console.ReadLine())"; break;
                    case "Char": code += " = Char.Parse(Console.ReadLine())"; break;
                    case "Starling": code += " = Console.ReadLine()"; break;
                    case "Bull": code += " = Boolean.Parse(Console.ReadLine())"; break;
                    default:
                        break;
                }

            }
            node.AddChild(child);
        }


        public override void EnterProdScanFig(Production node)
        {
        }


        public override Node ExitProdScanFig(Production node)
        {
            return node;
        }


        public override void ChildProdScanFig(Production node, Node child)
        {
            node.AddChild(child);
        }

        public override void EnterProdMultiInput(Production node)
        {
            code += ";\n";
        }


        public override Node ExitProdMultiInput(Production node)
        {
            return node;
        }


        public override void ChildProdMultiInput(Production node, Node child)
        {
            node.AddChild(child);
            if (child.GetName() == "ID")
            {
                Tokens t = new Tokens();
                t = GetTokens(child.GetStartLine(), child.GetStartColumn());
                //t = tokens[t.getCode()];
                string input_datatype = "";

                foreach (var item in identifiers)
                {
                    if (item.getScope() == currscope)
                    {
                        if (item.getId() == t.getLexemes())
                        {
                            input_datatype = item.getDtype();
                        }
                    }
                }

                switch (input_datatype)
                {
                    case "Newt": code += " = Int32.Parse(Console.ReadLine())"; break;
                    case "Duck": code += " = Double.Parse(Console.ReadLine())"; break;
                    case "Char": code += " = Char.Parse(Console.ReadLine())"; break;
                    case "Starling": code += " = Console.ReadLine()"; break;
                    case "Bull": code += " = Boolean.Parse(Console.ReadLine())"; break;
                    default:
                        break;
                }

            }
        }


        public override void EnterProdArr1d(Production node)
        {

        }


        public override Node ExitProdArr1d(Production node)
        {
            return node;
        }


        public override void ChildProdArr1d(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdArr2d(Production node)
        {
        }


        public override Node ExitProdArr2d(Production node)
        {
            return node;
        }


        public override void ChildProdArr2d(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdStorkAccess1(Production node)
        {
        }


        public override Node ExitProdStorkAccess1(Production node)
        {
            return node;
        }


        public override void ChildProdStorkAccess1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdOutput(Production node)
        {
        }


        public override Node ExitProdOutput(Production node)
        {
            return node;
        }


        public override void ChildProdOutput(Production node, Node child)
        {
            node.AddChild(child);
            if (child.GetName() == "TERMI")
            {
                code = code.Remove(code.Length - 2, 2);
                code += ");\n";
            }
        }


        public override void EnterProdOut(Production node)
        {
        }


        public override Node ExitProdOut(Production node)
        {

            return node;

        }


        public override void ChildProdOut(Production node, Node child)
        {
            ////Node output = node.GetChildAt(0);
            //Tokens token;
            //int count = node.GetChildCount();
            //if (child.GetName() == "STARLIT")
            //{
            //    int idline = child.GetStartLine();
            //    int idcol = child.GetStartColumn();
            //    token = GetTokens(idline, idcol);
            //    string outs = token.getLexemes();
            //    Console.Write(outs);
            //}
            //else
            //{
            //    int idline = child.GetStartLine();
            //    int idcol = child.GetStartColumn();
            //    token = GetTokens(idline, idcol);
            //    string outs = token.getLexemes();

            //    foreach (var item in identifiers)
            //    {
            //        if(item.getId() == token.getLexemes())
            //        {
            //            Console.Write(item.getValue().ToString());
            //        }
            //    }
            //}
            node.AddChild(child);
        }


        public override void EnterProdMultiOutput(Production node)
        {
            isMultiOutput = true;
        }


        public override Node ExitProdMultiOutput(Production node)
        {
            isMultiOutput = false;
            return node;
        }


        public override void ChildProdMultiOutput(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdConditional(Production node)
        {
        }


        public override Node ExitProdConditional(Production node)
        {
            return node;
        }


        public override void ChildProdConditional(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdCondi(Production node)
        {
        }


        public override Node ExitProdCondi(Production node)
        {
            return node;
        }


        public override void ChildProdCondi(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdNotFig(Production node)
        {
        }


        public override Node ExitProdNotFig(Production node)
        {
            return node;
        }


        public override void ChildProdNotFig(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdCondExpr(Production node)
        {
        }


        public override Node ExitProdCondExpr(Production node)
        {
            return node;
        }


        public override void ChildProdCondExpr(Production node, Node child)
        {
            node.AddChild(child);
        }



        public override void EnterProdRelExpr(Production node)
        {
        }


        public override Node ExitProdRelExpr(Production node)
        {
            return node;
        }


        public override void ChildProdRelExpr(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdRelexTail(Production node)
        {
        }


        public override Node ExitProdRelexTail(Production node)
        {
            return node;
        }


        public override void ChildProdRelexTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdExpression(Production node)
        {
        }


        public override Node ExitProdExpression(Production node)
        {
            return node;
        }


        public override void ChildProdExpression(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdRelOp1(Production node)
        {
        }


        public override Node ExitProdRelOp1(Production node)
        {
            return node;
        }


        public override void ChildProdRelOp1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdRelOp2(Production node)
        {
        }


        public override Node ExitProdRelOp2(Production node)
        {
            return node;
        }


        public override void ChildProdRelOp2(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdRelFig(Production node)
        {
        }


        public override Node ExitProdRelFig(Production node)
        {
            return node;
        }


        public override void ChildProdRelFig(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdLogExpr(Production node)
        {
        }


        public override Node ExitProdLogExpr(Production node)
        {
            return node;
        }


        public override void ChildProdLogExpr(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdLogExprNext(Production node)
        {
        }


        public override Node ExitProdLogExprNext(Production node)
        {
            return node;
        }


        public override void ChildProdLogExprNext(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdLogOp(Production node)
        {
        }


        public override Node ExitProdLogOp(Production node)
        {
            return node;
        }


        public override void ChildProdLogOp(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdCondEelsif(Production node)
        {
        }


        public override Node ExitProdCondEelsif(Production node)
        {
            return node;
        }


        public override void ChildProdCondEelsif(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdCondEels(Production node)
        {
        }


        public override Node ExitProdCondEels(Production node)
        {
            return node;
        }


        public override void ChildProdCondEels(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdSwaspCase(Production node)
        {
        }


        public override Node ExitProdSwaspCase(Production node)
        {
            return node;
        }


        public override void ChildProdSwaspCase(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdSwaspCase1(Production node)
        {
        }


        public override Node ExitProdSwaspCase1(Production node)
        {
            return node;
        }


        public override void ChildProdSwaspCase1(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdTermExpr(Production node)
        {
        }


        public override Node ExitProdTermExpr(Production node)
        {
            return node;
        }


        public override void ChildProdTermExpr(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdDefault(Production node)
        {
        }


        public override Node ExitProdDefault(Production node)
        {
            code += "break;\n";
            return node;
        }


        public override void ChildProdDefault(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdIterative(Production node)
        {
        }


        public override Node ExitProdIterative(Production node)
        {
            return node;
        }


        public override void ChildProdIterative(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdLoopFig1(Production node)
        {
        }


        public override Node ExitProdLoopFig1(Production node)
        {
            return node;
        }


        public override void ChildProdLoopFig1(Production node, Node child)
        {
            node.AddChild(child);
        }

        public override void EnterProdLoopFig2(Production node)
        {
        }


        public override Node ExitProdLoopFig2(Production node)
        {
            return node;
        }


        public override void ChildProdLoopFig2(Production node, Node child)
        {
            node.AddChild(child);
        }

        public override void EnterProdRelExpr1(Production node)
        {
        }


        public override Node ExitProdRelExpr1(Production node)
        {
            return node;
        }


        public override void ChildProdRelExpr1(Production node, Node child)
        {
            node.AddChild(child);
        }

        
        public override void EnterProdIncremDecrem(Production node)
        {
        }


        public override Node ExitProdIncremDecrem(Production node)
        {
            return node;
        }


        public override void ChildProdIncremDecrem(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdUnaryOp(Production node)
        {
        }


        public override Node ExitProdUnaryOp(Production node)
        {
            return node;
        }


        public override void ChildProdUnaryOp(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdSubFunction(Production node)
        {
            code += "\npublic static ";
        }


        public override Node ExitProdSubFunction(Production node)
        {
            return node;
        }


        public override void ChildProdSubFunction(Production node, Node child)
        {
            node.AddChild(child);
            
        }


        public override void EnterProdFuncInside(Production node)
        {
        }


        public override Node ExitProdFuncInside(Production node)
        {
            return node;
        }


        public override void ChildProdFuncInside(Production node, Node child)
        {
            node.AddChild(child);
            //if (child.GetName() == "TERMI")
            //{
            //    if (!hasDeclared)
            //    {
            //        code += vardtype + " " + varid;
            //    }
            //    isIdentVar = true;
            //    code += ";\n";
            //}
        }


        public override void EnterProdFuncArgs(Production node)
        {
            isFunctArgs = true;
        }


        public override Node ExitProdFuncArgs(Production node)
        {
            isFunctArgs = false;
            return node;
        }


        public override void ChildProdFuncArgs(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdMultifuncArgs(Production node)
        {
        }


        public override Node ExitProdMultifuncArgs(Production node)
        {
            return node;
        }


        public override void ChildProdMultifuncArgs(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdResult(Production node)
        {
        }


        public override Node ExitProdResult(Production node)
        {
            return node;
        }


        public override void ChildProdResult(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdFigTail(Production node)
        {
        }


        public override Node ExitProdFigTail(Production node)
        {
            return node;
        }


        public override void ChildProdFigTail(Production node, Node child)
        {
            node.AddChild(child);
        }


        public override void EnterProdResultTail(Production node)
        {
        }


        public override Node ExitProdResultTail(Production node)
        {
            return node;
        }


        public override void ChildProdResultTail(Production node, Node child)
        {
            node.AddChild(child);
        }
    }
}
