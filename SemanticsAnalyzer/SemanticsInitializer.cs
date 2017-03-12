using System;
using System.Collections.Generic;
using Syntax_Analyzer;
using TokenLibrary.TokenLibrary;
using Core.Library;
using System.IO;

namespace Semantics_Analyzer
{
    public class SemanticsInitializer : SyntaxAnalyzer
    {
        public class Tokens : TokenClass
        {
            public List<string> attribute = new List<string>();

            public void addAttribute(string attribute)
            {
                this.attribute.Add(attribute);
            }

            public List<string> getAttribute()
            {
                return this.attribute;
            }
        }

        public string error = "";
        public List<Tokens> tokens;
        //public List<Tokens> ID = new List<Tokens>();
        private List<Tokens> globalID = new List<Tokens>();

        //List of Identifiers
        public List<SemanticsConstants.Identifiers> identifiers = new List<SemanticsConstants.Identifiers>();
        public List<SemanticsConstants.Arrays> arrays = new List<SemanticsConstants.Arrays>();
        public List<SemanticsConstants.Index> indexes = new List<SemanticsConstants.Index>();
        public List<SemanticsConstants.Objects> objects = new List<SemanticsConstants.Objects>();
        public List<SemanticsConstants.Task> tasks = new List<SemanticsConstants.Task>();
        private string currscope = "Mane";
        private bool noArrType;

        public List<SemanticsConstants.Identifiers> Identifiers
        {
            get
            {
                return identifiers;
            }

            set
            {
                identifiers = value;
            }
        }

        public List<SemanticsConstants.Arrays> Arrays
        {
            get
            {
                return arrays;
            }

            set
            {
                arrays = value;
            }
        }

        public List<SemanticsConstants.Index> Indexes
        {
            get
            {
                return indexes;
            }

            set
            {
                indexes = value;
            }
        }

        public List<SemanticsConstants.Objects> Objects
        {
            get
            {
                return objects;
            }

            set
            {
                objects = value;
            }
        }

        public List<SemanticsConstants.Task> Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
            }
        }

        public List<Tokens> GlobalID
        {
            get
            {
                return globalID;
            }

            set
            {
                globalID = value;
            }
        }

        public SemanticsInitializer()
            : this(new List<Tokens>()) { }

        public SemanticsInitializer(List<Tokens> tokens)
        {
            this.tokens = tokens;  
        }

        public string Start()
        {
           
            string tokenstream = "";
            string result = " ";
            //string result = "Semantics\n Analyzer Failed...\n";
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
                    result = "Semantics Analyzer Succeeded...";
            }
            catch (ParserCreationException)
            {
                result = "Semantics Analyzer Halted due to Syntax Analyzer Error...";
            }
            catch (ParserLogException)
            {
                result = "Semantics Analyzer Halted due to Syntax Log Error...";
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


        private bool checkIdentifier(SemanticsConstants.Identifiers id)
        {
            bool isvalid = true;
            if(Identifiers.Count != 0)
            {
                foreach (var item in Identifiers)
                {
                    if (item.getScope() == "Global" || item.getScope() == currscope)
                    {
                        if (item.getId() == id.getId())
                        {
                            if (item.getScope() == id.getScope() || item.getScope() == "Global")
                            {
                                //error += "\nSemantics Error (Ln" + id.getLines() + "): " + id.getId() + " is already declared.\n";
                                isvalid = false;
                                break;
                            }
                        }
                    }
                }
            }
            
            if(isvalid)
            {
                    Identifiers.Add(id);
            }

            return isvalid;
        }

        private void hasMULTIID(Node node, string datatype, string scope, string attrib, string default_value)
        {
            SemanticsConstants.Identifiers id = new SemanticsConstants.Identifiers();
            int idline = node.GetChildAt(1).GetStartLine();
            int idcol = node.GetChildAt(1).GetStartColumn();
            Tokens token = GetTokens(idline, idcol);
            string identifier = token.getLexemes();
            id = setIdentifier(identifier, attrib, datatype, scope, default_value, idline, token.getLexemes());
            checkIdentifier(id);

            if (node.GetChildCount() > 2)
            {
                //If no initialization but has vartail
                if (node.GetChildCount() == 2 && node.GetChildAt(0).GetName() == "COMMA")
                {
                    hasMULTIID(node.GetChildAt(2), datatype, scope, attrib, default_value);
                }
                //If has initialization and vartail
                else if (node.GetChildCount() == 2)
                {
                    hasMULTIID(node.GetChildAt(3), datatype, scope, attrib, default_value);
                }
            }
        }

        private string getDtype(string dtype)
        {
            switch (dtype)
            {
                case "NEWT":
                    dtype = "Newt";
                    break;
                case "DUCK":
                    dtype = "Duck";
                    break;
                case "STARLING":
                    dtype = "Starling";
                    break;
                case "BULL":
                    dtype = "Bull";
                    break;
                case "NULL":
                    dtype = "Null";
                    break;

            }
            return dtype;
        }

        private void populateArray(string id, string datatype, Boolean isMulti, int size_1, int size_2)
        {
            string value = "";
            switch (datatype)
            {
                case "Newt":
                    datatype = "Newt";
                    value = "0"; break;
                case "Duck":
                    datatype = "Duck";
                    value = "0.00"; break;
                case "Starling":
                    datatype = "Starling";
                    value = "\"\""; break;
                case "Bull":
                    datatype = "Bull";
                    value = "Yes"; break;
            }
            if(isMulti)
            {
                for (int i = 0; i < size_1; i++)
                {
                    for (int j = 0; j < size_2; j++)
                    {
                        SemanticsConstants.Index index = new SemanticsConstants.Index();
                        index = setIndex(id, datatype, i, j, value);
                        Indexes.Add(index);
                    }
                }
            }
            else
            {
                for (int k = 0; k < size_1; k++)
                {
                    SemanticsConstants.Index index = new SemanticsConstants.Index();
                    index = setIndex(id, datatype, k, 0, value);
                    Indexes.Add(index);
                }
            }
        }

        private SemanticsConstants.Identifiers setIdentifier
        (string identifier, string attrib, string dtype, string scope, string value, int lines, string token)
        {
            SemanticsConstants.Identifiers ID = new SemanticsConstants.Identifiers();
            ID.setAttrib(attrib);
            ID.setDtype(dtype);
            ID.setId(identifier);
            ID.setLines(lines);
            ID.setScope(scope);
            ID.setTokens(token);
            ID.setValue(value);
            return ID;
        }

        private SemanticsConstants.Arrays setArray
        (string identifier, string dtype, bool isMulti, int size_1, int size_2)
        {
            SemanticsConstants.Arrays Array = new SemanticsConstants.Arrays();
            Array.setDtype(dtype);
            Array.setId(identifier);
            Array.setIsMulti(isMulti);
            Array.setSize_1(size_1);
            Array.setSize_2(size_2);
            return Array;
        }

        private SemanticsConstants.Objects setObject
        (string identifier, string dtype)
        {
            SemanticsConstants.Objects Object = new SemanticsConstants.Objects();
            Object.setDtype(dtype);
            Object.setId(identifier);
            return Object;
        }

        private SemanticsConstants.Task setTask
        (string identifier, string dtype, int parameters)
        {
            SemanticsConstants.Task Task = new SemanticsConstants.Task();
            Task.setDtype(dtype);
            Task.setId(identifier);
            Task.setParameters(parameters);
            return Task;
        }

        private SemanticsConstants.Index setIndex
        (string identifier, string datatype, int index_1, int index_2, string value)
        {
            SemanticsConstants.Index Index = new SemanticsConstants.Index();
            Index.setId(identifier);
            Index.setDatatype(identifier + "." + datatype);
            Index.setIndex_1(index_1);
            Index.setIndex_2(index_2);
            Index.setValue(value);
            return Index;
        }
         
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
            currscope = "Global";
        }

         
        public override Node ExitProdGlobalDec(Production node)
        {
            currscope = "Mane";
            //SemanticsConstants.Identifiers id = new SemanticsConstants.Identifiers();
            //Node GlobalChoice = node;

            //if (GlobalChoice.GetChildAt(0).GetName() == "Prod_vardec")
            //{
            //    Node vardtype = GlobalChoice.GetChildAt(0).GetChildAt(1);
            //    int idline = vardtype.GetChildAt(1).GetStartLine();
            //    int idcol = vardtype.GetChildAt(1).GetStartColumn();
            //    Tokens token = GetTokens(idline, idcol);
            //    string identifier = token.getLexemes();
            //    string datatype = vardtype.GetChildAt(0).GetName();
            //    string scope = "Global", value = "", attrib = "Variable";
            //    datatype = getDtype(datatype);

            //    switch (datatype)
            //    {
            //        case "Int":
            //            value = "0"; break;
            //        case "Double":
            //            value = "0.0"; break;
            //        case "String":
            //            value = "\"\""; break;
            //        case "Char":
            //            value = "''"; break;
            //        case "Boolean":
            //            value = "Yes"; break;
            //    }

            //    id = setIdentifier(identifier, attrib, datatype, scope, value, idline, token.getLexemes());
            //    isDeclaredID(id);
            //    if (vardtype.GetChildCount() > 2)
            //    {
            //        //If no initialization but has vartail
            //        if (vardtype.GetChildAt(2).GetName() == ("Prod_vartail" + datatype.ToUpper()))
            //        {
            //            hasMULTIID(vardtype.GetChildAt(2), datatype, scope, attrib, value);
            //        }
            //        //If has initialization and vartail
            //        else if (vardtype.GetChildCount() == 4)
            //        {
            //            hasMULTIID(vardtype.GetChildAt(3), datatype, scope, attrib, value);
            //        }
            //    }
            //}
            return node;
        }

         
        public override void ChildProdGlobalDec(Production node, Node child)
        {
            node.AddChild(child);
        }

         
        public override void EnterProdVarDec(Production node)
        {
        }

         
        public override Node ExitProdVarDec(Production node)
        {
            string dtype = "", scope = currscope, id = "";
            Node ident_var = node.GetChildAt(0);
            Node datatype = ident_var.GetChildAt(0).GetChildAt(0);
            dtype = getDtype(datatype.GetName());
            bool isFunct = false;
            bool isArray = false;
            bool isSaved = false;
            int idline, idcol;
            idline = ident_var.GetChildAt(2).GetStartLine();
            idcol = ident_var.GetChildAt(2).GetStartColumn();
            Tokens token = new Tokens();
            token = GetTokens(idline,idcol);
            id = token.getLexemes();
            SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
            identifier = setIdentifier(id,"",dtype,scope,"",idline,token.getTokens());
            isSaved = checkIdentifier(identifier);
            if (node.GetChildCount() > 2)
            {
                if(node.GetChildAt(1).GetName() == "prod_func_var")
                {
                    Node func_var = node.GetChildAt(1);
                    if(func_var.GetChildAt(0).GetName() == "prod_next2var")
                    {
                        Node next2var = node.GetChildAt(1);
                        //int idcount = 2;
                        if (next2var.GetChildAt(0).GetName() == "prod_array1D")
                        {
                            Node array1D = node.GetChildAt(1);
                            isArray = true;
                        }
                        else if (next2var.GetChildAt(0).GetName() == "=")
                        {
                           
                        }
                        else
                        {
                            //if (idcount == 1)
                            //{

                            //}
                            //else
                            //{
                            //    Node multiID = node.GetChildAt(1);
                            //    idcount++;
                                
                            //}

                        }
                    }
                    else
                    {
                        isFunct = true;
                    }
                }
                else
                {
                   
                }
            }

                return node;
        }

         
        public override void ChildProdVarDec(Production node, Node child)
        {
            node.AddChild(child);
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
            node.AddChild(child);
        }

         
        public override void EnterProdIdentVar(Production node)
        {
        }

         
        public override Node ExitProdIdentVar(Production node)
        {
           return node;
        }

         
        public override void ChildProdIdentVar(Production node, Node child)
        {
            node.AddChild(child);
            //if (child.GetName() == "ID")
            //{
            //    int idline = child.GetStartLine();
            //    int idcol = child.GetStartColumn();
            //    Tokens token = GetTokens(idline, idcol);
            //    currscope = token.getLexemes();
            //}
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
        }

        public override void EnterProdIdchoice(Production node)
        {
        }

        public override Node ExitProdIdchoice(Production node)
        {
            return node;
        }

        public override void ChildProdIdchoice(Production node, Node child)
        {
            node.AddChild(child);
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
        }

         
        public override Node ExitProdArray1d(Production node)
        {
            return node;
        }

         
        public override void ChildProdArray1d(Production node, Node child)
        {
            node.AddChild(child);
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
            node.AddChild(child);
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
            string dtype = "", scope = currscope, id = "";
            Node ident_var = node.GetChildAt(1);
            Node datatype = ident_var.GetChildAt(0).GetChildAt(0);
            dtype = getDtype(datatype.GetName());
            bool isFunct = false;
            bool isArray = false;
            bool isSaved = false;
            int idline, idcol;
            idline = ident_var.GetChildAt(2).GetStartLine();
            idcol = ident_var.GetChildAt(2).GetStartColumn();
            Tokens token = new Tokens();
            token = GetTokens(idline, idcol);
            id = token.getLexemes();
            SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
            identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
            isSaved = checkIdentifier(identifier);
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

        public override void EnterProdStorkName(Production node)
        {
        }


        public override Node ExitProdStorkName(Production node)
        {
            return node;
        }


        public override void ChildProdStorkName(Production node, Node child)
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
            return node;
        }

         
        public override void ChildProdMane(Production node, Node child)
        {
            node.AddChild(child);
        }

        public override void EnterProdLocalDec(Production node)
        {
            currscope = "Mane";
        }

         
        public override Node ExitProdLocalDec(Production node)
        {
            string dtype = "", scope = currscope, id = "";
            Node ident_var = node.GetChildAt(0);
            if(ident_var.GetName() == "prod_ident_var")
            {
                Node datatype = ident_var.GetChildAt(0).GetChildAt(0);
                dtype = getDtype(datatype.GetName());
                bool isFunct = false;
                bool isArray = false;
                bool isSaved = false;
                int idline, idcol;
                idline = ident_var.GetChildAt(2).GetStartLine();
                idcol = ident_var.GetChildAt(2).GetStartColumn();
                Tokens token = new Tokens();
                token = GetTokens(idline, idcol);
                id = token.getLexemes();
                SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
                identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
                isSaved = checkIdentifier(identifier);


                if (node.GetChildCount() > 2)
                {
                    Node next2var = node.GetChildAt(1);
                    if (next2var.GetName() == "prod_next2var")
                    {
                        if (next2var.GetChildAt(0).GetName() == "EQUAL")
                        {
                            if (next2var.GetChildCount() > 2)
                            {
                                next2var = next2var.GetChildAt(2);
                                saveVariables(next2var, dtype, scope);
                            }
                        }
                        else
                        {
                            saveVariables(next2var, dtype, scope);
                        }
                    }
                }
            }
            else if (ident_var.GetName() == "prod_stork_name")
            {
                bool isSaved = false;
                int idline, idcol;
                idline = ident_var.GetStartLine();
                idcol = ident_var.GetStartColumn();
                Tokens token = new Tokens();
                token = GetTokens(idline, idcol);
                id = token.getLexemes();
                SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
                identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
                isSaved = checkIdentifier(identifier);
            }
            
            return node;
        }

        private void saveVariables(Node node, string dtype, string scope)
        {
            int idline, idcol;
            string id = "";
            bool isSaved = false;
            if(node.GetChildCount() == 1)
            {
                idline = node.GetChildAt(0).GetStartLine();
                idcol = node.GetChildAt(0).GetStartColumn();
                Tokens token = new Tokens();
                token = GetTokens(idline, idcol);
                id = token.getLexemes();
                SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
                identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
                isSaved = checkIdentifier(identifier);
                
            }
            else
            {
                idline = node.GetChildAt(1).GetStartLine();
                idcol = node.GetChildAt(1).GetStartColumn();
                Tokens token = new Tokens();
                token = GetTokens(idline, idcol);
                id = token.getLexemes();
                SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
                identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
                isSaved = checkIdentifier(identifier);
                if (node.GetChildCount() > 2)
                {
                    Node next2var = node.GetChildAt(2);
                    if (next2var.GetName() == "prod_next2var")
                    {
                        saveVariables(next2var, dtype, scope);
                    }
                }
            }
            
           
        }

         
        public override void ChildProdLocalDec(Production node, Node child)
        {
            node.AddChild(child);
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
            Node arrdec = node.GetChildAt(0);
            if (arrdec.GetName() == "OB")
            {
                
            }
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
            node.AddChild(child);
        }

         
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
        }

         
        public override void ChildProdInput(Production node, Node child)
        {
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
        }

         
        public override Node ExitProdMultiInput(Production node)
        {
            return node;
        }

         
        public override void ChildProdMultiInput(Production node, Node child)
        {
            node.AddChild(child);
        }

         
        public override void EnterProdArr1d(Production node)
        {
        }

         
        public override Node ExitProdArr1d(Production node)
        {
            string dtype = "", scope = currscope, id = "";
            Node ident_var = node.GetChildAt(0);
            if (ident_var.GetName() == "prod_ident_var")
            {
                Node datatype = ident_var.GetChildAt(0).GetChildAt(0);
                dtype = getDtype(datatype.GetName());
                bool isFunct = false;
                bool isSaved = false;
                int idline, idcol;
                idline = ident_var.GetChildAt(2).GetStartLine();
                idcol = ident_var.GetChildAt(2).GetStartColumn();
                Tokens token = new Tokens();
                token = GetTokens(idline, idcol);
                id = token.getLexemes();
                SemanticsConstants.Identifiers identifier = new SemanticsConstants.Identifiers();
                identifier = setIdentifier(id, "", dtype, scope, "", idline, token.getTokens());
                isSaved = checkIdentifier(identifier);


                if (node.GetChildCount() > 2)
                {
                    Node next2var = node.GetChildAt(1);
                    if (next2var.GetName() == "prod_next2var")
                    {
                        saveVariables(next2var, dtype, scope);
                    }
                }
            }                

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
            node.AddChild(child);
        }
        
         
        public override void EnterProdMultiOutput(Production node)
        {
        }

         
        public override Node ExitProdMultiOutput(Production node)
        {
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
        }

         
        public override Node ExitProdSubFunction(Production node)
        {
            SemanticsConstants.Identifiers id = new SemanticsConstants.Identifiers();
            if (node.GetChildCount() > 7 && node.GetName() == "Prod_sub_function")
            {
                Node vardtype = node.GetChildAt(0);
                int idline = vardtype.GetStartLine();
                int idcol = vardtype.GetStartColumn();
                Tokens token = GetTokens(idline, idcol);
                string identifier = token.getLexemes();
                string datatype = vardtype.GetChildAt(0).GetName();
                string scope = currscope, value = "", attrib = "Variable";
                datatype = getDtype(datatype);

                switch (datatype)
                {
                    case "Int":
                        value = "0"; break;
                    case "Double":
                        value = "0.0"; break;
                    case "String":
                        value = "\"\""; break;
                    case "Boolean":
                        value = "Yes"; break;
                }

                id = setIdentifier(identifier, attrib, datatype, scope, value, idline, token.getLexemes());
                checkIdentifier(id);
                if (vardtype.GetChildCount() > 2)
                {
                    //If no initialization but has vartail
                    if (node.GetChildAt(2).GetName() == ("Prod_next2var" + datatype))
                    {
                        if(node.GetChildAt(0).GetName() == "COMMA")
                            hasMULTIID(vardtype.GetChildAt(2), datatype, scope, attrib, value);
                        if(node.GetChildAt(0).GetName() == "EQUAL")
                            hasMULTIID(vardtype.GetChildAt(2), datatype, scope, attrib, value);
                    }
                    ////If has initialization and vartail
                    //else if (vardtype.GetChildCount() == 4)
                    //{
                    //    hasMULTIID(vardtype.GetChildAt(3), datatype, scope, attrib, value);
                    //}
                }
            }
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
        }

         
        public override void EnterProdFuncArgs(Production node)
        {
        }

         
        public override Node ExitProdFuncArgs(Production node)
        {
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
