' SyntaxAnalyzer.vb
'
' THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!

Imports Core.Library

'''<remarks>A class providing callback methods for the
'''parser.</remarks>
Public MustInherit Class SyntaxAnalyzer
    Inherits Analyzer

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overrides Sub Enter(ByVal node As Node)
        Select Case node.Id
        Case SyntaxConstants.ENTRANCE
            EnterEntrance(CType(node,Token))

        Case SyntaxConstants.EXIT
            EnterExit(CType(node,Token))

        Case SyntaxConstants.MANE
            EnterMane(CType(node,Token))

        Case SyntaxConstants.LET
            EnterLet(CType(node,Token))

        Case SyntaxConstants.WIPE
            EnterWipe(CType(node,Token))

        Case SyntaxConstants.ZOOIN
            EnterZooin(CType(node,Token))

        Case SyntaxConstants.ZOOUT
            EnterZoout(CType(node,Token))

        Case SyntaxConstants.IF
            EnterIf(CType(node,Token))

        Case SyntaxConstants.EELSIF
            EnterEelsif(CType(node,Token))

        Case SyntaxConstants.EELS
            EnterEels(CType(node,Token))

        Case SyntaxConstants.CHAMOIS
            EnterChamois(CType(node,Token))

        Case SyntaxConstants.TERMITE
            EnterTermite(CType(node,Token))

        Case SyntaxConstants.SEAL
            EnterSeal(CType(node,Token))

        Case SyntaxConstants.WHALE
            EnterWhale(CType(node,Token))

        Case SyntaxConstants.DO
            EnterDo(CType(node,Token))

        Case SyntaxConstants.FUR
            EnterFur(CType(node,Token))

        Case SyntaxConstants.HOP
            EnterHop(CType(node,Token))

        Case SyntaxConstants.SWASP
            EnterSwasp(CType(node,Token))

        Case SyntaxConstants.STORK
            EnterStork(CType(node,Token))

        Case SyntaxConstants.AT
            EnterAt(CType(node,Token))

        Case SyntaxConstants.NULL
            EnterNull(CType(node,Token))

        Case SyntaxConstants.COMSYM
            EnterComsym(CType(node,Token))

        Case SyntaxConstants.TERMI
            EnterTermi(CType(node,Token))

        Case SyntaxConstants.SC
            EnterSc(CType(node,Token))

        Case SyntaxConstants.COMMA
            EnterComma(CType(node,Token))

        Case SyntaxConstants.EQUAL
            EnterEqual(CType(node,Token))

        Case SyntaxConstants.OB
            EnterOb(CType(node,Token))

        Case SyntaxConstants.CB
            EnterCb(CType(node,Token))

        Case SyntaxConstants.OC
            EnterOc(CType(node,Token))

        Case SyntaxConstants.CC
            EnterCc(CType(node,Token))

        Case SyntaxConstants.OP
            EnterOp(CType(node,Token))

        Case SyntaxConstants.CP
            EnterCp(CType(node,Token))

        Case SyntaxConstants.ODC
            EnterOdc(CType(node,Token))

        Case SyntaxConstants.CDC
            EnterCdc(CType(node,Token))

        Case SyntaxConstants.CONC
            EnterConc(CType(node,Token))

        Case SyntaxConstants.CON
            EnterCon(CType(node,Token))

        Case SyntaxConstants.ODA
            EnterOda(CType(node,Token))

        Case SyntaxConstants.CDA
            EnterCda(CType(node,Token))

        Case SyntaxConstants.NEG
            EnterNeg(CType(node,Token))

        Case SyntaxConstants.ADD
            EnterAdd(CType(node,Token))

        Case SyntaxConstants.SUB
            EnterSub(CType(node,Token))

        Case SyntaxConstants.MUL
            EnterMul(CType(node,Token))

        Case SyntaxConstants.DIV
            EnterDiv(CType(node,Token))

        Case SyntaxConstants.MOD
            EnterMod(CType(node,Token))

        Case SyntaxConstants.EXP
            EnterExp(CType(node,Token))

        Case SyntaxConstants.OA
            EnterOa(CType(node,Token))

        Case SyntaxConstants.CA
            EnterCa(CType(node,Token))

        Case SyntaxConstants.OAE
            EnterOae(CType(node,Token))

        Case SyntaxConstants.CAE
            EnterCae(CType(node,Token))

        Case SyntaxConstants.EE
            EnterEe(CType(node,Token))

        Case SyntaxConstants.DE
            EnterDe(CType(node,Token))

        Case SyntaxConstants.EXC
            EnterExc(CType(node,Token))

        Case SyntaxConstants.DAND
            EnterDand(CType(node,Token))

        Case SyntaxConstants.DOR
            EnterDor(CType(node,Token))

        Case SyntaxConstants.INCRE
            EnterIncre(CType(node,Token))

        Case SyntaxConstants.DECRE
            EnterDecre(CType(node,Token))

        Case SyntaxConstants.NEWT
            EnterNewt(CType(node,Token))

        Case SyntaxConstants.DUCK
            EnterDuck(CType(node,Token))

        Case SyntaxConstants.BULL
            EnterBull(CType(node,Token))

        Case SyntaxConstants.STARLING
            EnterStarling(CType(node,Token))

        Case SyntaxConstants.VIPER
            EnterViper(CType(node,Token))

        Case SyntaxConstants.NEWTLIT
            EnterNewtlit(CType(node,Token))

        Case SyntaxConstants.DUCKLIT
            EnterDucklit(CType(node,Token))

        Case SyntaxConstants.STARLIT
            EnterStarlit(CType(node,Token))

        Case SyntaxConstants.TRUE
            EnterTrue(CType(node,Token))

        Case SyntaxConstants.FALSE
            EnterFalse(CType(node,Token))

        Case SyntaxConstants.ID
            EnterId(CType(node,Token))

        Case SyntaxConstants.COMMENT
            EnterComment(CType(node,Token))

        Case SyntaxConstants.PROD_PROGRAM
            EnterProdProgram(CType(node,Production))

        Case SyntaxConstants.PROD_COMMENT
            EnterProdComment(CType(node,Production))

        Case SyntaxConstants.PROD_GLOBAL_DEC
            EnterProdGlobalDec(CType(node,Production))

        Case SyntaxConstants.PROD_VAR_DEC
            EnterProdVarDec(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_VAR
            EnterProdFuncVar(CType(node,Production))

        Case SyntaxConstants.PROD_IDENT_VAR
            EnterProdIdentVar(CType(node,Production))

        Case SyntaxConstants.PROD_DTYPE
            EnterProdDtype(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT2VAR
            EnterProdNext2var(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT2VAR_TAIL
            EnterProdNext2varTail(CType(node,Production))

        Case SyntaxConstants.PROD_VAL
            EnterProdVal(CType(node,Production))

        Case SyntaxConstants.PROD_VAL1
            EnterProdVal1(CType(node,Production))

        Case SyntaxConstants.PROD_VAL2
            EnterProdVal2(CType(node,Production))

        Case SyntaxConstants.PROD_BUL_LIT
            EnterProdBulLit(CType(node,Production))

        Case SyntaxConstants.PROD_ARRAY1D
            EnterProdArray1d(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM1D_NEXT
            EnterProdElem1dNext(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM1D_LIST
            EnterProdElem1dList(CType(node,Production))

        Case SyntaxConstants.PROD_ELEMLIST1D_TAIL
            EnterProdElemlist1dTail(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_NEXT
            EnterProdElem2dNext(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_LIST
            EnterProdElem2dList(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_LIST_TAIL
            EnterProdElem2dListTail(CType(node,Production))

        Case SyntaxConstants.PROD_SIZE
            EnterProdSize(CType(node,Production))

        Case SyntaxConstants.PROD_CONST_DEC
            EnterProdConstDec(CType(node,Production))

        Case SyntaxConstants.PROD_CONST_NEXT
            EnterProdConstNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_NAME
            EnterProdFuncName(CType(node,Production))

        Case SyntaxConstants.PROD_PARAM
            EnterProdParam(CType(node,Production))

        Case SyntaxConstants.PROD_PARAM2
            EnterProdParam2(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_DEC
            EnterProdStorkDec(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_ELEM
            EnterProdStorkElem(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_VARDEC
            EnterProdMultiVardec(CType(node,Production))

        Case SyntaxConstants.PROD_MULTISTORK_ELEM
            EnterProdMultistorkElem(CType(node,Production))

        Case SyntaxConstants.PROD_OBJ_DEC
            EnterProdObjDec(CType(node,Production))

        Case SyntaxConstants.PROD_MANE
            EnterProdMane(CType(node,Production))

        Case SyntaxConstants.PROD_LOCAL_DEC
            EnterProdLocalDec(CType(node,Production))

        Case SyntaxConstants.PROD_STATEMENT
            EnterProdStatement(CType(node,Production))

        Case SyntaxConstants.PROD_STATE_NEXT
            EnterProdStateNext(CType(node,Production))

        Case SyntaxConstants.PROD_ASSIGN1
            EnterProdAssign1(CType(node,Production))

        Case SyntaxConstants.PROD_ASSIGN_TAIL
            EnterProdAssignTail(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT_FIG
            EnterProdNextFig(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT
            EnterProdNext(CType(node,Production))

        Case SyntaxConstants.PROD_SCAN_NEXT
            EnterProdScanNext(CType(node,Production))

        Case SyntaxConstants.PROD_VALUE_DL
            EnterProdValueDl(CType(node,Production))

        Case SyntaxConstants.PROD_FIG
            EnterProdFig(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_CALL
            EnterProdFuncCall(CType(node,Production))

        Case SyntaxConstants.PROD_ARGS1
            EnterProdArgs1(CType(node,Production))

        Case SyntaxConstants.PROD_ARGS_TAIL
            EnterProdArgsTail(CType(node,Production))

        Case SyntaxConstants.PROD_ARG_IN
            EnterProdArgIn(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_NEXT
            EnterProdFuncNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC
            EnterProdFunc(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL
            EnterProdMathEqtail(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL1
            EnterProdMathEqtail1(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL2
            EnterProdMathEqtail2(CType(node,Production))

        Case SyntaxConstants.PROD_EXPONENT
            EnterProdExponent(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_TAIL
            EnterProdMathTail(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_OP
            EnterProdMathOp(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_FIG
            EnterProdMathFig(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_FIG1
            EnterProdMathFig1(CType(node,Production))

        Case SyntaxConstants.PROD_MATHEQ_NEXT
            EnterProdMatheqNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNCTION_CALL
            EnterProdFunctionCall(CType(node,Production))

        Case SyntaxConstants.PROD_CLRSCR
            EnterProdClrscr(CType(node,Production))

        Case SyntaxConstants.PROD_INPUT
            EnterProdInput(CType(node,Production))

        Case SyntaxConstants.PROD_SCAN_FIG
            EnterProdScanFig(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_INPUT
            EnterProdMultiInput(CType(node,Production))

        Case SyntaxConstants.PROD_ARR1D
            EnterProdArr1d(CType(node,Production))

        Case SyntaxConstants.PROD_ARR2D
            EnterProdArr2d(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_ACCESS1
            EnterProdStorkAccess1(CType(node,Production))

        Case SyntaxConstants.PROD_OUTPUT
            EnterProdOutput(CType(node,Production))

        Case SyntaxConstants.PROD_OUT
            EnterProdOut(CType(node,Production))

        Case SyntaxConstants.PROD_OUTPUT_NEXT
            EnterProdOutputNext(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_OUTPUT
            EnterProdMultiOutput(CType(node,Production))

        Case SyntaxConstants.PROD_CONDITIONAL
            EnterProdConditional(CType(node,Production))

        Case SyntaxConstants.PROD_CONDI
            EnterProdCondi(CType(node,Production))

        Case SyntaxConstants.PROD_NOT_FIG
            EnterProdNotFig(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EXPR
            EnterProdCondExpr(CType(node,Production))

        Case SyntaxConstants.PROD_COND_TAIL
            EnterProdCondTail(CType(node,Production))

        Case SyntaxConstants.PROD_REL_EXPR
            EnterProdRelExpr(CType(node,Production))

        Case SyntaxConstants.PROD_RELEX_TAIL
            EnterProdRelexTail(CType(node,Production))

        Case SyntaxConstants.PROD_EXPRESSION
            EnterProdExpression(CType(node,Production))

        Case SyntaxConstants.PROD_EXPR_NEXT
            EnterProdExprNext(CType(node,Production))

        Case SyntaxConstants.PROD_REL_OP1
            EnterProdRelOp1(CType(node,Production))

        Case SyntaxConstants.PROD_REL_OP2
            EnterProdRelOp2(CType(node,Production))

        Case SyntaxConstants.PROD_REL_FIG
            EnterProdRelFig(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_EXPR
            EnterProdLogExpr(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_EXPR_NEXT
            EnterProdLogExprNext(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_OP
            EnterProdLogOp(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EELSIF
            EnterProdCondEelsif(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EELS
            EnterProdCondEels(CType(node,Production))

        Case SyntaxConstants.PROD_SWASP_CASE
            EnterProdSwaspCase(CType(node,Production))

        Case SyntaxConstants.PROD_SWASP_CASE1
            EnterProdSwaspCase1(CType(node,Production))

        Case SyntaxConstants.PROD_TERM_EXPR
            EnterProdTermExpr(CType(node,Production))

        Case SyntaxConstants.PROD_DEFAULT
            EnterProdDefault(CType(node,Production))

        Case SyntaxConstants.PROD_ITERATIVE
            EnterProdIterative(CType(node,Production))

        Case SyntaxConstants.PROD_LOOP_FIG1
            EnterProdLoopFig1(CType(node,Production))

        Case SyntaxConstants.PROD_REL_EXPR1
            EnterProdRelExpr1(CType(node,Production))

        Case SyntaxConstants.PROD_LOOP_FIG2
            EnterProdLoopFig2(CType(node,Production))

        Case SyntaxConstants.PROD_INCREM_DECREM
            EnterProdIncremDecrem(CType(node,Production))

        Case SyntaxConstants.PROD_VAR
            EnterProdVar(CType(node,Production))

        Case SyntaxConstants.PROD_UNARY_OP
            EnterProdUnaryOp(CType(node,Production))

        Case SyntaxConstants.PROD_SUB_FUNCTION
            EnterProdSubFunction(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_INSIDE
            EnterProdFuncInside(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_ARGS
            EnterProdFuncArgs(CType(node,Production))

        Case SyntaxConstants.PROD_MULTIFUNC_ARGS
            EnterProdMultifuncArgs(CType(node,Production))

        Case SyntaxConstants.PROD_RESULT
            EnterProdResult(CType(node,Production))

        Case SyntaxConstants.PROD_FIG_TAIL
            EnterProdFigTail(CType(node,Production))

        Case SyntaxConstants.PROD_RESULT_TAIL
            EnterProdResultTail(CType(node,Production))

        End Select
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overrides Function [Exit](ByVal node As Node) As Node
        Select Case node.Id
        Case SyntaxConstants.ENTRANCE
            return ExitEntrance(CType(node,Token))

        Case SyntaxConstants.EXIT
            return ExitExit(CType(node,Token))

        Case SyntaxConstants.MANE
            return ExitMane(CType(node,Token))

        Case SyntaxConstants.LET
            return ExitLet(CType(node,Token))

        Case SyntaxConstants.WIPE
            return ExitWipe(CType(node,Token))

        Case SyntaxConstants.ZOOIN
            return ExitZooin(CType(node,Token))

        Case SyntaxConstants.ZOOUT
            return ExitZoout(CType(node,Token))

        Case SyntaxConstants.IF
            return ExitIf(CType(node,Token))

        Case SyntaxConstants.EELSIF
            return ExitEelsif(CType(node,Token))

        Case SyntaxConstants.EELS
            return ExitEels(CType(node,Token))

        Case SyntaxConstants.CHAMOIS
            return ExitChamois(CType(node,Token))

        Case SyntaxConstants.TERMITE
            return ExitTermite(CType(node,Token))

        Case SyntaxConstants.SEAL
            return ExitSeal(CType(node,Token))

        Case SyntaxConstants.WHALE
            return ExitWhale(CType(node,Token))

        Case SyntaxConstants.DO
            return ExitDo(CType(node,Token))

        Case SyntaxConstants.FUR
            return ExitFur(CType(node,Token))

        Case SyntaxConstants.HOP
            return ExitHop(CType(node,Token))

        Case SyntaxConstants.SWASP
            return ExitSwasp(CType(node,Token))

        Case SyntaxConstants.STORK
            return ExitStork(CType(node,Token))

        Case SyntaxConstants.AT
            return ExitAt(CType(node,Token))

        Case SyntaxConstants.NULL
            return ExitNull(CType(node,Token))

        Case SyntaxConstants.COMSYM
            return ExitComsym(CType(node,Token))

        Case SyntaxConstants.TERMI
            return ExitTermi(CType(node,Token))

        Case SyntaxConstants.SC
            return ExitSc(CType(node,Token))

        Case SyntaxConstants.COMMA
            return ExitComma(CType(node,Token))

        Case SyntaxConstants.EQUAL
            return ExitEqual(CType(node,Token))

        Case SyntaxConstants.OB
            return ExitOb(CType(node,Token))

        Case SyntaxConstants.CB
            return ExitCb(CType(node,Token))

        Case SyntaxConstants.OC
            return ExitOc(CType(node,Token))

        Case SyntaxConstants.CC
            return ExitCc(CType(node,Token))

        Case SyntaxConstants.OP
            return ExitOp(CType(node,Token))

        Case SyntaxConstants.CP
            return ExitCp(CType(node,Token))

        Case SyntaxConstants.ODC
            return ExitOdc(CType(node,Token))

        Case SyntaxConstants.CDC
            return ExitCdc(CType(node,Token))

        Case SyntaxConstants.CONC
            return ExitConc(CType(node,Token))

        Case SyntaxConstants.CON
            return ExitCon(CType(node,Token))

        Case SyntaxConstants.ODA
            return ExitOda(CType(node,Token))

        Case SyntaxConstants.CDA
            return ExitCda(CType(node,Token))

        Case SyntaxConstants.NEG
            return ExitNeg(CType(node,Token))

        Case SyntaxConstants.ADD
            return ExitAdd(CType(node,Token))

        Case SyntaxConstants.SUB
            return ExitSub(CType(node,Token))

        Case SyntaxConstants.MUL
            return ExitMul(CType(node,Token))

        Case SyntaxConstants.DIV
            return ExitDiv(CType(node,Token))

        Case SyntaxConstants.MOD
            return ExitMod(CType(node,Token))

        Case SyntaxConstants.EXP
            return ExitExp(CType(node,Token))

        Case SyntaxConstants.OA
            return ExitOa(CType(node,Token))

        Case SyntaxConstants.CA
            return ExitCa(CType(node,Token))

        Case SyntaxConstants.OAE
            return ExitOae(CType(node,Token))

        Case SyntaxConstants.CAE
            return ExitCae(CType(node,Token))

        Case SyntaxConstants.EE
            return ExitEe(CType(node,Token))

        Case SyntaxConstants.DE
            return ExitDe(CType(node,Token))

        Case SyntaxConstants.EXC
            return ExitExc(CType(node,Token))

        Case SyntaxConstants.DAND
            return ExitDand(CType(node,Token))

        Case SyntaxConstants.DOR
            return ExitDor(CType(node,Token))

        Case SyntaxConstants.INCRE
            return ExitIncre(CType(node,Token))

        Case SyntaxConstants.DECRE
            return ExitDecre(CType(node,Token))

        Case SyntaxConstants.NEWT
            return ExitNewt(CType(node,Token))

        Case SyntaxConstants.DUCK
            return ExitDuck(CType(node,Token))

        Case SyntaxConstants.BULL
            return ExitBull(CType(node,Token))

        Case SyntaxConstants.STARLING
            return ExitStarling(CType(node,Token))

        Case SyntaxConstants.VIPER
            return ExitViper(CType(node,Token))

        Case SyntaxConstants.NEWTLIT
            return ExitNewtlit(CType(node,Token))

        Case SyntaxConstants.DUCKLIT
            return ExitDucklit(CType(node,Token))

        Case SyntaxConstants.STARLIT
            return ExitStarlit(CType(node,Token))

        Case SyntaxConstants.TRUE
            return ExitTrue(CType(node,Token))

        Case SyntaxConstants.FALSE
            return ExitFalse(CType(node,Token))

        Case SyntaxConstants.ID
            return ExitId(CType(node,Token))

        Case SyntaxConstants.COMMENT
            return ExitComment(CType(node,Token))

        Case SyntaxConstants.PROD_PROGRAM
            return ExitProdProgram(CType(node,Production))

        Case SyntaxConstants.PROD_COMMENT
            return ExitProdComment(CType(node,Production))

        Case SyntaxConstants.PROD_GLOBAL_DEC
            return ExitProdGlobalDec(CType(node,Production))

        Case SyntaxConstants.PROD_VAR_DEC
            return ExitProdVarDec(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_VAR
            return ExitProdFuncVar(CType(node,Production))

        Case SyntaxConstants.PROD_IDENT_VAR
            return ExitProdIdentVar(CType(node,Production))

        Case SyntaxConstants.PROD_DTYPE
            return ExitProdDtype(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT2VAR
            return ExitProdNext2var(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT2VAR_TAIL
            return ExitProdNext2varTail(CType(node,Production))

        Case SyntaxConstants.PROD_VAL
            return ExitProdVal(CType(node,Production))

        Case SyntaxConstants.PROD_VAL1
            return ExitProdVal1(CType(node,Production))

        Case SyntaxConstants.PROD_VAL2
            return ExitProdVal2(CType(node,Production))

        Case SyntaxConstants.PROD_BUL_LIT
            return ExitProdBulLit(CType(node,Production))

        Case SyntaxConstants.PROD_ARRAY1D
            return ExitProdArray1d(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM1D_NEXT
            return ExitProdElem1dNext(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM1D_LIST
            return ExitProdElem1dList(CType(node,Production))

        Case SyntaxConstants.PROD_ELEMLIST1D_TAIL
            return ExitProdElemlist1dTail(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_NEXT
            return ExitProdElem2dNext(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_LIST
            return ExitProdElem2dList(CType(node,Production))

        Case SyntaxConstants.PROD_ELEM2D_LIST_TAIL
            return ExitProdElem2dListTail(CType(node,Production))

        Case SyntaxConstants.PROD_SIZE
            return ExitProdSize(CType(node,Production))

        Case SyntaxConstants.PROD_CONST_DEC
            return ExitProdConstDec(CType(node,Production))

        Case SyntaxConstants.PROD_CONST_NEXT
            return ExitProdConstNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_NAME
            return ExitProdFuncName(CType(node,Production))

        Case SyntaxConstants.PROD_PARAM
            return ExitProdParam(CType(node,Production))

        Case SyntaxConstants.PROD_PARAM2
            return ExitProdParam2(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_DEC
            return ExitProdStorkDec(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_ELEM
            return ExitProdStorkElem(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_VARDEC
            return ExitProdMultiVardec(CType(node,Production))

        Case SyntaxConstants.PROD_MULTISTORK_ELEM
            return ExitProdMultistorkElem(CType(node,Production))

        Case SyntaxConstants.PROD_OBJ_DEC
            return ExitProdObjDec(CType(node,Production))

        Case SyntaxConstants.PROD_MANE
            return ExitProdMane(CType(node,Production))

        Case SyntaxConstants.PROD_LOCAL_DEC
            return ExitProdLocalDec(CType(node,Production))

        Case SyntaxConstants.PROD_STATEMENT
            return ExitProdStatement(CType(node,Production))

        Case SyntaxConstants.PROD_STATE_NEXT
            return ExitProdStateNext(CType(node,Production))

        Case SyntaxConstants.PROD_ASSIGN1
            return ExitProdAssign1(CType(node,Production))

        Case SyntaxConstants.PROD_ASSIGN_TAIL
            return ExitProdAssignTail(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT_FIG
            return ExitProdNextFig(CType(node,Production))

        Case SyntaxConstants.PROD_NEXT
            return ExitProdNext(CType(node,Production))

        Case SyntaxConstants.PROD_SCAN_NEXT
            return ExitProdScanNext(CType(node,Production))

        Case SyntaxConstants.PROD_VALUE_DL
            return ExitProdValueDl(CType(node,Production))

        Case SyntaxConstants.PROD_FIG
            return ExitProdFig(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_CALL
            return ExitProdFuncCall(CType(node,Production))

        Case SyntaxConstants.PROD_ARGS1
            return ExitProdArgs1(CType(node,Production))

        Case SyntaxConstants.PROD_ARGS_TAIL
            return ExitProdArgsTail(CType(node,Production))

        Case SyntaxConstants.PROD_ARG_IN
            return ExitProdArgIn(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_NEXT
            return ExitProdFuncNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC
            return ExitProdFunc(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL
            return ExitProdMathEqtail(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL1
            return ExitProdMathEqtail1(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_EQTAIL2
            return ExitProdMathEqtail2(CType(node,Production))

        Case SyntaxConstants.PROD_EXPONENT
            return ExitProdExponent(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_TAIL
            return ExitProdMathTail(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_OP
            return ExitProdMathOp(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_FIG
            return ExitProdMathFig(CType(node,Production))

        Case SyntaxConstants.PROD_MATH_FIG1
            return ExitProdMathFig1(CType(node,Production))

        Case SyntaxConstants.PROD_MATHEQ_NEXT
            return ExitProdMatheqNext(CType(node,Production))

        Case SyntaxConstants.PROD_FUNCTION_CALL
            return ExitProdFunctionCall(CType(node,Production))

        Case SyntaxConstants.PROD_CLRSCR
            return ExitProdClrscr(CType(node,Production))

        Case SyntaxConstants.PROD_INPUT
            return ExitProdInput(CType(node,Production))

        Case SyntaxConstants.PROD_SCAN_FIG
            return ExitProdScanFig(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_INPUT
            return ExitProdMultiInput(CType(node,Production))

        Case SyntaxConstants.PROD_ARR1D
            return ExitProdArr1d(CType(node,Production))

        Case SyntaxConstants.PROD_ARR2D
            return ExitProdArr2d(CType(node,Production))

        Case SyntaxConstants.PROD_STORK_ACCESS1
            return ExitProdStorkAccess1(CType(node,Production))

        Case SyntaxConstants.PROD_OUTPUT
            return ExitProdOutput(CType(node,Production))

        Case SyntaxConstants.PROD_OUT
            return ExitProdOut(CType(node,Production))

        Case SyntaxConstants.PROD_OUTPUT_NEXT
            return ExitProdOutputNext(CType(node,Production))

        Case SyntaxConstants.PROD_MULTI_OUTPUT
            return ExitProdMultiOutput(CType(node,Production))

        Case SyntaxConstants.PROD_CONDITIONAL
            return ExitProdConditional(CType(node,Production))

        Case SyntaxConstants.PROD_CONDI
            return ExitProdCondi(CType(node,Production))

        Case SyntaxConstants.PROD_NOT_FIG
            return ExitProdNotFig(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EXPR
            return ExitProdCondExpr(CType(node,Production))

        Case SyntaxConstants.PROD_COND_TAIL
            return ExitProdCondTail(CType(node,Production))

        Case SyntaxConstants.PROD_REL_EXPR
            return ExitProdRelExpr(CType(node,Production))

        Case SyntaxConstants.PROD_RELEX_TAIL
            return ExitProdRelexTail(CType(node,Production))

        Case SyntaxConstants.PROD_EXPRESSION
            return ExitProdExpression(CType(node,Production))

        Case SyntaxConstants.PROD_EXPR_NEXT
            return ExitProdExprNext(CType(node,Production))

        Case SyntaxConstants.PROD_REL_OP1
            return ExitProdRelOp1(CType(node,Production))

        Case SyntaxConstants.PROD_REL_OP2
            return ExitProdRelOp2(CType(node,Production))

        Case SyntaxConstants.PROD_REL_FIG
            return ExitProdRelFig(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_EXPR
            return ExitProdLogExpr(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_EXPR_NEXT
            return ExitProdLogExprNext(CType(node,Production))

        Case SyntaxConstants.PROD_LOG_OP
            return ExitProdLogOp(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EELSIF
            return ExitProdCondEelsif(CType(node,Production))

        Case SyntaxConstants.PROD_COND_EELS
            return ExitProdCondEels(CType(node,Production))

        Case SyntaxConstants.PROD_SWASP_CASE
            return ExitProdSwaspCase(CType(node,Production))

        Case SyntaxConstants.PROD_SWASP_CASE1
            return ExitProdSwaspCase1(CType(node,Production))

        Case SyntaxConstants.PROD_TERM_EXPR
            return ExitProdTermExpr(CType(node,Production))

        Case SyntaxConstants.PROD_DEFAULT
            return ExitProdDefault(CType(node,Production))

        Case SyntaxConstants.PROD_ITERATIVE
            return ExitProdIterative(CType(node,Production))

        Case SyntaxConstants.PROD_LOOP_FIG1
            return ExitProdLoopFig1(CType(node,Production))

        Case SyntaxConstants.PROD_REL_EXPR1
            return ExitProdRelExpr1(CType(node,Production))

        Case SyntaxConstants.PROD_LOOP_FIG2
            return ExitProdLoopFig2(CType(node,Production))

        Case SyntaxConstants.PROD_INCREM_DECREM
            return ExitProdIncremDecrem(CType(node,Production))

        Case SyntaxConstants.PROD_VAR
            return ExitProdVar(CType(node,Production))

        Case SyntaxConstants.PROD_UNARY_OP
            return ExitProdUnaryOp(CType(node,Production))

        Case SyntaxConstants.PROD_SUB_FUNCTION
            return ExitProdSubFunction(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_INSIDE
            return ExitProdFuncInside(CType(node,Production))

        Case SyntaxConstants.PROD_FUNC_ARGS
            return ExitProdFuncArgs(CType(node,Production))

        Case SyntaxConstants.PROD_MULTIFUNC_ARGS
            return ExitProdMultifuncArgs(CType(node,Production))

        Case SyntaxConstants.PROD_RESULT
            return ExitProdResult(CType(node,Production))

        Case SyntaxConstants.PROD_FIG_TAIL
            return ExitProdFigTail(CType(node,Production))

        Case SyntaxConstants.PROD_RESULT_TAIL
            return ExitProdResultTail(CType(node,Production))

        End Select
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overrides Sub Child(ByVal node As Production, ByVal child As Node)
        Select Case node.Id
        Case SyntaxConstants.PROD_PROGRAM
            ChildProdProgram(node, child)

        Case SyntaxConstants.PROD_COMMENT
            ChildProdComment(node, child)

        Case SyntaxConstants.PROD_GLOBAL_DEC
            ChildProdGlobalDec(node, child)

        Case SyntaxConstants.PROD_VAR_DEC
            ChildProdVarDec(node, child)

        Case SyntaxConstants.PROD_FUNC_VAR
            ChildProdFuncVar(node, child)

        Case SyntaxConstants.PROD_IDENT_VAR
            ChildProdIdentVar(node, child)

        Case SyntaxConstants.PROD_DTYPE
            ChildProdDtype(node, child)

        Case SyntaxConstants.PROD_NEXT2VAR
            ChildProdNext2var(node, child)

        Case SyntaxConstants.PROD_NEXT2VAR_TAIL
            ChildProdNext2varTail(node, child)

        Case SyntaxConstants.PROD_VAL
            ChildProdVal(node, child)

        Case SyntaxConstants.PROD_VAL1
            ChildProdVal1(node, child)

        Case SyntaxConstants.PROD_VAL2
            ChildProdVal2(node, child)

        Case SyntaxConstants.PROD_BUL_LIT
            ChildProdBulLit(node, child)

        Case SyntaxConstants.PROD_ARRAY1D
            ChildProdArray1d(node, child)

        Case SyntaxConstants.PROD_ELEM1D_NEXT
            ChildProdElem1dNext(node, child)

        Case SyntaxConstants.PROD_ELEM1D_LIST
            ChildProdElem1dList(node, child)

        Case SyntaxConstants.PROD_ELEMLIST1D_TAIL
            ChildProdElemlist1dTail(node, child)

        Case SyntaxConstants.PROD_ELEM2D_NEXT
            ChildProdElem2dNext(node, child)

        Case SyntaxConstants.PROD_ELEM2D_LIST
            ChildProdElem2dList(node, child)

        Case SyntaxConstants.PROD_ELEM2D_LIST_TAIL
            ChildProdElem2dListTail(node, child)

        Case SyntaxConstants.PROD_SIZE
            ChildProdSize(node, child)

        Case SyntaxConstants.PROD_CONST_DEC
            ChildProdConstDec(node, child)

        Case SyntaxConstants.PROD_CONST_NEXT
            ChildProdConstNext(node, child)

        Case SyntaxConstants.PROD_FUNC_NAME
            ChildProdFuncName(node, child)

        Case SyntaxConstants.PROD_PARAM
            ChildProdParam(node, child)

        Case SyntaxConstants.PROD_PARAM2
            ChildProdParam2(node, child)

        Case SyntaxConstants.PROD_STORK_DEC
            ChildProdStorkDec(node, child)

        Case SyntaxConstants.PROD_STORK_ELEM
            ChildProdStorkElem(node, child)

        Case SyntaxConstants.PROD_MULTI_VARDEC
            ChildProdMultiVardec(node, child)

        Case SyntaxConstants.PROD_MULTISTORK_ELEM
            ChildProdMultistorkElem(node, child)

        Case SyntaxConstants.PROD_OBJ_DEC
            ChildProdObjDec(node, child)

        Case SyntaxConstants.PROD_MANE
            ChildProdMane(node, child)

        Case SyntaxConstants.PROD_LOCAL_DEC
            ChildProdLocalDec(node, child)

        Case SyntaxConstants.PROD_STATEMENT
            ChildProdStatement(node, child)

        Case SyntaxConstants.PROD_STATE_NEXT
            ChildProdStateNext(node, child)

        Case SyntaxConstants.PROD_ASSIGN1
            ChildProdAssign1(node, child)

        Case SyntaxConstants.PROD_ASSIGN_TAIL
            ChildProdAssignTail(node, child)

        Case SyntaxConstants.PROD_NEXT_FIG
            ChildProdNextFig(node, child)

        Case SyntaxConstants.PROD_NEXT
            ChildProdNext(node, child)

        Case SyntaxConstants.PROD_SCAN_NEXT
            ChildProdScanNext(node, child)

        Case SyntaxConstants.PROD_VALUE_DL
            ChildProdValueDl(node, child)

        Case SyntaxConstants.PROD_FIG
            ChildProdFig(node, child)

        Case SyntaxConstants.PROD_FUNC_CALL
            ChildProdFuncCall(node, child)

        Case SyntaxConstants.PROD_ARGS1
            ChildProdArgs1(node, child)

        Case SyntaxConstants.PROD_ARGS_TAIL
            ChildProdArgsTail(node, child)

        Case SyntaxConstants.PROD_ARG_IN
            ChildProdArgIn(node, child)

        Case SyntaxConstants.PROD_FUNC_NEXT
            ChildProdFuncNext(node, child)

        Case SyntaxConstants.PROD_FUNC
            ChildProdFunc(node, child)

        Case SyntaxConstants.PROD_MATH_EQTAIL
            ChildProdMathEqtail(node, child)

        Case SyntaxConstants.PROD_MATH_EQTAIL1
            ChildProdMathEqtail1(node, child)

        Case SyntaxConstants.PROD_MATH_EQTAIL2
            ChildProdMathEqtail2(node, child)

        Case SyntaxConstants.PROD_EXPONENT
            ChildProdExponent(node, child)

        Case SyntaxConstants.PROD_MATH_TAIL
            ChildProdMathTail(node, child)

        Case SyntaxConstants.PROD_MATH_OP
            ChildProdMathOp(node, child)

        Case SyntaxConstants.PROD_MATH_FIG
            ChildProdMathFig(node, child)

        Case SyntaxConstants.PROD_MATH_FIG1
            ChildProdMathFig1(node, child)

        Case SyntaxConstants.PROD_MATHEQ_NEXT
            ChildProdMatheqNext(node, child)

        Case SyntaxConstants.PROD_FUNCTION_CALL
            ChildProdFunctionCall(node, child)

        Case SyntaxConstants.PROD_CLRSCR
            ChildProdClrscr(node, child)

        Case SyntaxConstants.PROD_INPUT
            ChildProdInput(node, child)

        Case SyntaxConstants.PROD_SCAN_FIG
            ChildProdScanFig(node, child)

        Case SyntaxConstants.PROD_MULTI_INPUT
            ChildProdMultiInput(node, child)

        Case SyntaxConstants.PROD_ARR1D
            ChildProdArr1d(node, child)

        Case SyntaxConstants.PROD_ARR2D
            ChildProdArr2d(node, child)

        Case SyntaxConstants.PROD_STORK_ACCESS1
            ChildProdStorkAccess1(node, child)

        Case SyntaxConstants.PROD_OUTPUT
            ChildProdOutput(node, child)

        Case SyntaxConstants.PROD_OUT
            ChildProdOut(node, child)

        Case SyntaxConstants.PROD_OUTPUT_NEXT
            ChildProdOutputNext(node, child)

        Case SyntaxConstants.PROD_MULTI_OUTPUT
            ChildProdMultiOutput(node, child)

        Case SyntaxConstants.PROD_CONDITIONAL
            ChildProdConditional(node, child)

        Case SyntaxConstants.PROD_CONDI
            ChildProdCondi(node, child)

        Case SyntaxConstants.PROD_NOT_FIG
            ChildProdNotFig(node, child)

        Case SyntaxConstants.PROD_COND_EXPR
            ChildProdCondExpr(node, child)

        Case SyntaxConstants.PROD_COND_TAIL
            ChildProdCondTail(node, child)

        Case SyntaxConstants.PROD_REL_EXPR
            ChildProdRelExpr(node, child)

        Case SyntaxConstants.PROD_RELEX_TAIL
            ChildProdRelexTail(node, child)

        Case SyntaxConstants.PROD_EXPRESSION
            ChildProdExpression(node, child)

        Case SyntaxConstants.PROD_EXPR_NEXT
            ChildProdExprNext(node, child)

        Case SyntaxConstants.PROD_REL_OP1
            ChildProdRelOp1(node, child)

        Case SyntaxConstants.PROD_REL_OP2
            ChildProdRelOp2(node, child)

        Case SyntaxConstants.PROD_REL_FIG
            ChildProdRelFig(node, child)

        Case SyntaxConstants.PROD_LOG_EXPR
            ChildProdLogExpr(node, child)

        Case SyntaxConstants.PROD_LOG_EXPR_NEXT
            ChildProdLogExprNext(node, child)

        Case SyntaxConstants.PROD_LOG_OP
            ChildProdLogOp(node, child)

        Case SyntaxConstants.PROD_COND_EELSIF
            ChildProdCondEelsif(node, child)

        Case SyntaxConstants.PROD_COND_EELS
            ChildProdCondEels(node, child)

        Case SyntaxConstants.PROD_SWASP_CASE
            ChildProdSwaspCase(node, child)

        Case SyntaxConstants.PROD_SWASP_CASE1
            ChildProdSwaspCase1(node, child)

        Case SyntaxConstants.PROD_TERM_EXPR
            ChildProdTermExpr(node, child)

        Case SyntaxConstants.PROD_DEFAULT
            ChildProdDefault(node, child)

        Case SyntaxConstants.PROD_ITERATIVE
            ChildProdIterative(node, child)

        Case SyntaxConstants.PROD_LOOP_FIG1
            ChildProdLoopFig1(node, child)

        Case SyntaxConstants.PROD_REL_EXPR1
            ChildProdRelExpr1(node, child)

        Case SyntaxConstants.PROD_LOOP_FIG2
            ChildProdLoopFig2(node, child)

        Case SyntaxConstants.PROD_INCREM_DECREM
            ChildProdIncremDecrem(node, child)

        Case SyntaxConstants.PROD_VAR
            ChildProdVar(node, child)

        Case SyntaxConstants.PROD_UNARY_OP
            ChildProdUnaryOp(node, child)

        Case SyntaxConstants.PROD_SUB_FUNCTION
            ChildProdSubFunction(node, child)

        Case SyntaxConstants.PROD_FUNC_INSIDE
            ChildProdFuncInside(node, child)

        Case SyntaxConstants.PROD_FUNC_ARGS
            ChildProdFuncArgs(node, child)

        Case SyntaxConstants.PROD_MULTIFUNC_ARGS
            ChildProdMultifuncArgs(node, child)

        Case SyntaxConstants.PROD_RESULT
            ChildProdResult(node, child)

        Case SyntaxConstants.PROD_FIG_TAIL
            ChildProdFigTail(node, child)

        Case SyntaxConstants.PROD_RESULT_TAIL
            ChildProdResultTail(node, child)

        End Select
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterEntrance(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitEntrance(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterExit(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitExit(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMane(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitMane(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLet(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitLet(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterWipe(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitWipe(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterZooin(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitZooin(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterZoout(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitZoout(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterIf(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitIf(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterEelsif(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitEelsif(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterEels(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitEels(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterChamois(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitChamois(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterTermite(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitTermite(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSeal(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitSeal(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterWhale(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitWhale(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDo(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDo(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFur(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitFur(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterHop(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitHop(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSwasp(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitSwasp(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStork(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitStork(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterAt(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitAt(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNull(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitNull(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterComsym(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitComsym(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterTermi(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitTermi(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitSc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterComma(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitComma(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterEqual(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitEqual(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOb(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOb(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCb(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCb(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOp(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOp(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCp(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCp(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOdc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOdc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCdc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCdc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterConc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitConc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCon(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCon(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOda(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOda(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCda(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCda(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNeg(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitNeg(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterAdd(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitAdd(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSub(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitSub(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMul(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitMul(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDiv(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDiv(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMod(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitMod(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterExp(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitExp(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOa(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOa(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCa(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCa(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOae(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitOae(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCae(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitCae(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterEe(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitEe(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDe(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDe(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterExc(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitExc(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDand(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDand(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDor(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDor(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterIncre(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitIncre(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDecre(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDecre(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNewt(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitNewt(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDuck(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDuck(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterBull(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitBull(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStarling(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitStarling(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterViper(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitViper(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNewtlit(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitNewtlit(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDucklit(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitDucklit(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStarlit(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitStarlit(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterTrue(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitTrue(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFalse(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitFalse(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterId(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitId(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterComment(ByVal node As Token)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitComment(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdProgram(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdProgram(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdProgram(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdComment(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdComment(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdComment(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdGlobalDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdGlobalDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdGlobalDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdVarDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdVarDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdVarDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncVar(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncVar(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncVar(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdIdentVar(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdIdentVar(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdIdentVar(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdDtype(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdDtype(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdDtype(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdNext2var(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdNext2var(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdNext2var(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdNext2varTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdNext2varTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdNext2varTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdVal(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdVal(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdVal(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdVal1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdVal1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdVal1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdVal2(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdVal2(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdVal2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdBulLit(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdBulLit(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdBulLit(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArray1d(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArray1d(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArray1d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElem1dNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElem1dNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElem1dNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElem1dList(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElem1dList(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElem1dList(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElemlist1dTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElemlist1dTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElemlist1dTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElem2dNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElem2dNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElem2dNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElem2dList(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElem2dList(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElem2dList(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdElem2dListTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdElem2dListTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdElem2dListTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdSize(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdSize(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdSize(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdConstDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdConstDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdConstDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdConstNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdConstNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdConstNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncName(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncName(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncName(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdParam(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdParam(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdParam(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdParam2(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdParam2(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdParam2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdStorkDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdStorkDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdStorkDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdStorkElem(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdStorkElem(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdStorkElem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMultiVardec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMultiVardec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMultiVardec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMultistorkElem(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMultistorkElem(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMultistorkElem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdObjDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdObjDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdObjDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMane(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMane(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMane(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLocalDec(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLocalDec(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLocalDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdStatement(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdStatement(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdStatement(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdStateNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdStateNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdStateNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdAssign1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdAssign1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdAssign1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdAssignTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdAssignTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdAssignTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdNextFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdNextFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdNextFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdScanNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdScanNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdScanNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdValueDl(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdValueDl(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdValueDl(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncCall(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncCall(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncCall(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArgs1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArgs1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArgs1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArgsTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArgsTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArgsTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArgIn(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArgIn(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArgIn(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFunc(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFunc(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFunc(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathEqtail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathEqtail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathEqtail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathEqtail1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathEqtail1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathEqtail1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathEqtail2(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathEqtail2(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathEqtail2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdExponent(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdExponent(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdExponent(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathOp(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathOp(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMathFig1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMathFig1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMathFig1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMatheqNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMatheqNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMatheqNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFunctionCall(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFunctionCall(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFunctionCall(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdClrscr(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdClrscr(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdClrscr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdInput(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdInput(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdInput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdScanFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdScanFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdScanFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMultiInput(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMultiInput(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMultiInput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArr1d(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArr1d(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArr1d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdArr2d(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdArr2d(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdArr2d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdStorkAccess1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdStorkAccess1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdStorkAccess1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdOutput(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdOutput(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdOutput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdOut(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdOut(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdOut(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdOutputNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdOutputNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdOutputNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMultiOutput(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMultiOutput(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMultiOutput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdConditional(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdConditional(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdConditional(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdCondi(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdCondi(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdCondi(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdNotFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdNotFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdNotFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdCondExpr(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdCondExpr(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdCondExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdCondTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdCondTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdCondTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelExpr(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelExpr(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelexTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelexTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelexTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdExpression(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdExpression(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdExpression(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdExprNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdExprNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdExprNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelOp1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelOp1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelOp1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelOp2(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelOp2(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelOp2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelFig(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelFig(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLogExpr(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLogExpr(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLogExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLogExprNext(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLogExprNext(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLogExprNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLogOp(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLogOp(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLogOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdCondEelsif(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdCondEelsif(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdCondEelsif(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdCondEels(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdCondEels(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdCondEels(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdSwaspCase(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdSwaspCase(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdSwaspCase(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdSwaspCase1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdSwaspCase1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdSwaspCase1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdTermExpr(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdTermExpr(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdTermExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdDefault(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdDefault(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdDefault(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdIterative(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdIterative(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdIterative(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLoopFig1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLoopFig1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLoopFig1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdRelExpr1(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdRelExpr1(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdRelExpr1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdLoopFig2(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdLoopFig2(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdLoopFig2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdIncremDecrem(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdIncremDecrem(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdIncremDecrem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdVar(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdVar(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdVar(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdUnaryOp(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdUnaryOp(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdUnaryOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdSubFunction(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdSubFunction(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdSubFunction(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncInside(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncInside(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncInside(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFuncArgs(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFuncArgs(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFuncArgs(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdMultifuncArgs(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdMultifuncArgs(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdMultifuncArgs(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdResult(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdResult(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdResult(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdFigTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdFigTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdFigTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterProdResultTail(ByVal node As Production)
    End Sub

    '''<summary>Called when exiting a parse tree node.</summary>
    '''
    '''<param name='node'>the node being exited</param>
    '''
    '''<returns>the node to add to the parse tree, or
    '''         null if no parse tree should be created</returns>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Function ExitProdResultTail(ByVal node As Production) As Node
        Return node
    End Function

    '''<summary>Called when adding a child to a parse tree
    '''node.</summary>
    '''
    '''<param name='node'>the parent node</param>
    '''<param name='child'>the child node, or null</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub ChildProdResultTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub
End Class
