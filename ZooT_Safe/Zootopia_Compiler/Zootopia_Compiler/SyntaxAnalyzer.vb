' SyntaxAnalyzer.vb
'
' THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!

Imports PerCederberg.Grammatica.Runtime

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

        Case SyntaxConstants.ODP
            EnterOdp(CType(node,Token))

        Case SyntaxConstants.CDP
            EnterCdp(CType(node,Token))

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

        Case SyntaxConstants.AND
            EnterAnd(CType(node,Token))

        Case SyntaxConstants.OR
            EnterOr(CType(node,Token))

        Case SyntaxConstants.QM
            EnterQm(CType(node,Token))

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

        Case SyntaxConstants.PROGRAM
            EnterProgram(CType(node,Production))

        Case SyntaxConstants.PROD_COMMENT
            EnterProdComment(CType(node,Production))

        Case SyntaxConstants.GLOBAL_DEC
            EnterGlobalDec(CType(node,Production))

        Case SyntaxConstants.GLOBAL_FUNCDEC
            EnterGlobalFuncdec(CType(node,Production))

        Case SyntaxConstants.VAR_DEC
            EnterVarDec(CType(node,Production))

        Case SyntaxConstants.IDENT_VAR
            EnterIdentVar(CType(node,Production))

        Case SyntaxConstants.DTYPE
            EnterDtype(CType(node,Production))

        Case SyntaxConstants.NEXT2_VAR
            EnterNext2Var(CType(node,Production))

        Case SyntaxConstants.NEXT2VAR_TAIL
            EnterNext2varTail(CType(node,Production))

        Case SyntaxConstants.VAL
            EnterVal(CType(node,Production))

        Case SyntaxConstants.BUL_LIT
            EnterBulLit(CType(node,Production))

        Case SyntaxConstants.ARRAY1D
            EnterArray1d(CType(node,Production))

        Case SyntaxConstants.ELEM1D_NEXT
            EnterElem1dNext(CType(node,Production))

        Case SyntaxConstants.ELEM1D_LIST
            EnterElem1dList(CType(node,Production))

        Case SyntaxConstants.ELEMLIST1D_TAIL
            EnterElemlist1dTail(CType(node,Production))

        Case SyntaxConstants.ARRAY2D
            EnterArray2d(CType(node,Production))

        Case SyntaxConstants.ELEM2D_NEXT
            EnterElem2dNext(CType(node,Production))

        Case SyntaxConstants.ELEM2D_LIST
            EnterElem2dList(CType(node,Production))

        Case SyntaxConstants.SIZE
            EnterSize(CType(node,Production))

        Case SyntaxConstants.CONST_DEC
            EnterConstDec(CType(node,Production))

        Case SyntaxConstants.CONST_NEXT
            EnterConstNext(CType(node,Production))

        Case SyntaxConstants.FUNC_DEC
            EnterFuncDec(CType(node,Production))

        Case SyntaxConstants.DTYPE1
            EnterDtype1(CType(node,Production))

        Case SyntaxConstants.PARAM
            EnterParam(CType(node,Production))

        Case SyntaxConstants.MULTI_PARAM
            EnterMultiParam(CType(node,Production))

        Case SyntaxConstants.STORK_DEC
            EnterStorkDec(CType(node,Production))

        Case SyntaxConstants.STORK_ELEM
            EnterStorkElem(CType(node,Production))

        Case SyntaxConstants.MULTI_VARDEC
            EnterMultiVardec(CType(node,Production))

        Case SyntaxConstants.MULTISTORK_ELEM
            EnterMultistorkElem(CType(node,Production))

        Case SyntaxConstants.OBJ_DEC
            EnterObjDec(CType(node,Production))

        Case SyntaxConstants.PROD_MANE
            EnterProdMane(CType(node,Production))

        Case SyntaxConstants.LOCAL_DEC
            EnterLocalDec(CType(node,Production))

        Case SyntaxConstants.STATEMENT
            EnterStatement(CType(node,Production))

        Case SyntaxConstants.CLRSCR
            EnterClrscr(CType(node,Production))

        Case SyntaxConstants.STATEMENT1
            EnterStatement1(CType(node,Production))

        Case SyntaxConstants.STATEMENT_TAIL
            EnterStatementTail(CType(node,Production))

        Case SyntaxConstants.INPUT
            EnterInput(CType(node,Production))

        Case SyntaxConstants.SCAN_FIG
            EnterScanFig(CType(node,Production))

        Case SyntaxConstants.MULTI_INPUT
            EnterMultiInput(CType(node,Production))

        Case SyntaxConstants.ARR1D
            EnterArr1d(CType(node,Production))

        Case SyntaxConstants.ARR2D
            EnterArr2d(CType(node,Production))

        Case SyntaxConstants.STORK_ACCESS1
            EnterStorkAccess1(CType(node,Production))

        Case SyntaxConstants.OUTPUT
            EnterOutput(CType(node,Production))

        Case SyntaxConstants.OUTPUT_NEXT
            EnterOutputNext(CType(node,Production))

        Case SyntaxConstants.MULTI_OUTPUT
            EnterMultiOutput(CType(node,Production))

        Case SyntaxConstants.SCAN_FIG1
            EnterScanFig1(CType(node,Production))

        Case SyntaxConstants.MATH_EQ
            EnterMathEq(CType(node,Production))

        Case SyntaxConstants.MATH_EQTAIL
            EnterMathEqtail(CType(node,Production))

        Case SyntaxConstants.MATH_TAIL
            EnterMathTail(CType(node,Production))

        Case SyntaxConstants.MATH_OP
            EnterMathOp(CType(node,Production))

        Case SyntaxConstants.MATH_ID
            EnterMathId(CType(node,Production))

        Case SyntaxConstants.NEGATE
            EnterNegate(CType(node,Production))

        Case SyntaxConstants.MATHEQ_NEXT
            EnterMatheqNext(CType(node,Production))

        Case SyntaxConstants.CONDITIONAL
            EnterConditional(CType(node,Production))

        Case SyntaxConstants.COND_EXPR
            EnterCondExpr(CType(node,Production))

        Case SyntaxConstants.REL_EXPR1
            EnterRelExpr1(CType(node,Production))

        Case SyntaxConstants.RELEX_TAIL
            EnterRelexTail(CType(node,Production))

        Case SyntaxConstants.ARITHMETIC
            EnterArithmetic(CType(node,Production))

        Case SyntaxConstants.ARITHMETIC_TAIL
            EnterArithmeticTail(CType(node,Production))

        Case SyntaxConstants.EXPRESSION
            EnterExpression(CType(node,Production))

        Case SyntaxConstants.EXPR_NEXT
            EnterExprNext(CType(node,Production))

        Case SyntaxConstants.REL_OP1
            EnterRelOp1(CType(node,Production))

        Case SyntaxConstants.REL_OP2
            EnterRelOp2(CType(node,Production))

        Case SyntaxConstants.REL_FIG
            EnterRelFig(CType(node,Production))

        Case SyntaxConstants.LOG_EXPR
            EnterLogExpr(CType(node,Production))

        Case SyntaxConstants.NOT_FIG
            EnterNotFig(CType(node,Production))

        Case SyntaxConstants.LOG_EXPR_NEXT
            EnterLogExprNext(CType(node,Production))

        Case SyntaxConstants.LOG_OP
            EnterLogOp(CType(node,Production))

        Case SyntaxConstants.COND_EELSIF
            EnterCondEelsif(CType(node,Production))

        Case SyntaxConstants.COND_EELS
            EnterCondEels(CType(node,Production))

        Case SyntaxConstants.SWASP_CASE
            EnterSwaspCase(CType(node,Production))

        Case SyntaxConstants.SWASP_CASE1
            EnterSwaspCase1(CType(node,Production))

        Case SyntaxConstants.TERM_EXPR
            EnterTermExpr(CType(node,Production))

        Case SyntaxConstants.DEFAULT
            EnterDefault(CType(node,Production))

        Case SyntaxConstants.ITERATIVE
            EnterIterative(CType(node,Production))

        Case SyntaxConstants.LOOP_FIG1
            EnterLoopFig1(CType(node,Production))

        Case SyntaxConstants.LOOP_FIG2
            EnterLoopFig2(CType(node,Production))

        Case SyntaxConstants.INCREM_DECREM
            EnterIncremDecrem(CType(node,Production))

        Case SyntaxConstants.UNARY_OP
            EnterUnaryOp(CType(node,Production))

        Case SyntaxConstants.FUNCTION_CALL
            EnterFunctionCall(CType(node,Production))

        Case SyntaxConstants.ARGS1
            EnterArgs1(CType(node,Production))

        Case SyntaxConstants.ARGS2
            EnterArgs2(CType(node,Production))

        Case SyntaxConstants.ARGS_TAIL
            EnterArgsTail(CType(node,Production))

        Case SyntaxConstants.MULTI_ARGS
            EnterMultiArgs(CType(node,Production))

        Case SyntaxConstants.SUB_FUNCTION
            EnterSubFunction(CType(node,Production))

        Case SyntaxConstants.FUNC_ARGS
            EnterFuncArgs(CType(node,Production))

        Case SyntaxConstants.FUNC_TAIL
            EnterFuncTail(CType(node,Production))

        Case SyntaxConstants.ONE_ARRAY
            EnterOneArray(CType(node,Production))

        Case SyntaxConstants.TWO_ARRAY
            EnterTwoArray(CType(node,Production))

        Case SyntaxConstants.MULTIFUNC_ARGS
            EnterMultifuncArgs(CType(node,Production))

        Case SyntaxConstants.RETURN
            EnterReturn(CType(node,Production))

        Case SyntaxConstants.RESULT
            EnterResult(CType(node,Production))

        Case SyntaxConstants.RESULT_TAIL
            EnterResultTail(CType(node,Production))

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

        Case SyntaxConstants.ODP
            return ExitOdp(CType(node,Token))

        Case SyntaxConstants.CDP
            return ExitCdp(CType(node,Token))

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

        Case SyntaxConstants.AND
            return ExitAnd(CType(node,Token))

        Case SyntaxConstants.OR
            return ExitOr(CType(node,Token))

        Case SyntaxConstants.QM
            return ExitQm(CType(node,Token))

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

        Case SyntaxConstants.PROGRAM
            return ExitProgram(CType(node,Production))

        Case SyntaxConstants.PROD_COMMENT
            return ExitProdComment(CType(node,Production))

        Case SyntaxConstants.GLOBAL_DEC
            return ExitGlobalDec(CType(node,Production))

        Case SyntaxConstants.GLOBAL_FUNCDEC
            return ExitGlobalFuncdec(CType(node,Production))

        Case SyntaxConstants.VAR_DEC
            return ExitVarDec(CType(node,Production))

        Case SyntaxConstants.IDENT_VAR
            return ExitIdentVar(CType(node,Production))

        Case SyntaxConstants.DTYPE
            return ExitDtype(CType(node,Production))

        Case SyntaxConstants.NEXT2_VAR
            return ExitNext2Var(CType(node,Production))

        Case SyntaxConstants.NEXT2VAR_TAIL
            return ExitNext2varTail(CType(node,Production))

        Case SyntaxConstants.VAL
            return ExitVal(CType(node,Production))

        Case SyntaxConstants.BUL_LIT
            return ExitBulLit(CType(node,Production))

        Case SyntaxConstants.ARRAY1D
            return ExitArray1d(CType(node,Production))

        Case SyntaxConstants.ELEM1D_NEXT
            return ExitElem1dNext(CType(node,Production))

        Case SyntaxConstants.ELEM1D_LIST
            return ExitElem1dList(CType(node,Production))

        Case SyntaxConstants.ELEMLIST1D_TAIL
            return ExitElemlist1dTail(CType(node,Production))

        Case SyntaxConstants.ARRAY2D
            return ExitArray2d(CType(node,Production))

        Case SyntaxConstants.ELEM2D_NEXT
            return ExitElem2dNext(CType(node,Production))

        Case SyntaxConstants.ELEM2D_LIST
            return ExitElem2dList(CType(node,Production))

        Case SyntaxConstants.SIZE
            return ExitSize(CType(node,Production))

        Case SyntaxConstants.CONST_DEC
            return ExitConstDec(CType(node,Production))

        Case SyntaxConstants.CONST_NEXT
            return ExitConstNext(CType(node,Production))

        Case SyntaxConstants.FUNC_DEC
            return ExitFuncDec(CType(node,Production))

        Case SyntaxConstants.DTYPE1
            return ExitDtype1(CType(node,Production))

        Case SyntaxConstants.PARAM
            return ExitParam(CType(node,Production))

        Case SyntaxConstants.MULTI_PARAM
            return ExitMultiParam(CType(node,Production))

        Case SyntaxConstants.STORK_DEC
            return ExitStorkDec(CType(node,Production))

        Case SyntaxConstants.STORK_ELEM
            return ExitStorkElem(CType(node,Production))

        Case SyntaxConstants.MULTI_VARDEC
            return ExitMultiVardec(CType(node,Production))

        Case SyntaxConstants.MULTISTORK_ELEM
            return ExitMultistorkElem(CType(node,Production))

        Case SyntaxConstants.OBJ_DEC
            return ExitObjDec(CType(node,Production))

        Case SyntaxConstants.PROD_MANE
            return ExitProdMane(CType(node,Production))

        Case SyntaxConstants.LOCAL_DEC
            return ExitLocalDec(CType(node,Production))

        Case SyntaxConstants.STATEMENT
            return ExitStatement(CType(node,Production))

        Case SyntaxConstants.CLRSCR
            return ExitClrscr(CType(node,Production))

        Case SyntaxConstants.STATEMENT1
            return ExitStatement1(CType(node,Production))

        Case SyntaxConstants.STATEMENT_TAIL
            return ExitStatementTail(CType(node,Production))

        Case SyntaxConstants.INPUT
            return ExitInput(CType(node,Production))

        Case SyntaxConstants.SCAN_FIG
            return ExitScanFig(CType(node,Production))

        Case SyntaxConstants.MULTI_INPUT
            return ExitMultiInput(CType(node,Production))

        Case SyntaxConstants.ARR1D
            return ExitArr1d(CType(node,Production))

        Case SyntaxConstants.ARR2D
            return ExitArr2d(CType(node,Production))

        Case SyntaxConstants.STORK_ACCESS1
            return ExitStorkAccess1(CType(node,Production))

        Case SyntaxConstants.OUTPUT
            return ExitOutput(CType(node,Production))

        Case SyntaxConstants.OUTPUT_NEXT
            return ExitOutputNext(CType(node,Production))

        Case SyntaxConstants.MULTI_OUTPUT
            return ExitMultiOutput(CType(node,Production))

        Case SyntaxConstants.SCAN_FIG1
            return ExitScanFig1(CType(node,Production))

        Case SyntaxConstants.MATH_EQ
            return ExitMathEq(CType(node,Production))

        Case SyntaxConstants.MATH_EQTAIL
            return ExitMathEqtail(CType(node,Production))

        Case SyntaxConstants.MATH_TAIL
            return ExitMathTail(CType(node,Production))

        Case SyntaxConstants.MATH_OP
            return ExitMathOp(CType(node,Production))

        Case SyntaxConstants.MATH_ID
            return ExitMathId(CType(node,Production))

        Case SyntaxConstants.NEGATE
            return ExitNegate(CType(node,Production))

        Case SyntaxConstants.MATHEQ_NEXT
            return ExitMatheqNext(CType(node,Production))

        Case SyntaxConstants.CONDITIONAL
            return ExitConditional(CType(node,Production))

        Case SyntaxConstants.COND_EXPR
            return ExitCondExpr(CType(node,Production))

        Case SyntaxConstants.REL_EXPR1
            return ExitRelExpr1(CType(node,Production))

        Case SyntaxConstants.RELEX_TAIL
            return ExitRelexTail(CType(node,Production))

        Case SyntaxConstants.ARITHMETIC
            return ExitArithmetic(CType(node,Production))

        Case SyntaxConstants.ARITHMETIC_TAIL
            return ExitArithmeticTail(CType(node,Production))

        Case SyntaxConstants.EXPRESSION
            return ExitExpression(CType(node,Production))

        Case SyntaxConstants.EXPR_NEXT
            return ExitExprNext(CType(node,Production))

        Case SyntaxConstants.REL_OP1
            return ExitRelOp1(CType(node,Production))

        Case SyntaxConstants.REL_OP2
            return ExitRelOp2(CType(node,Production))

        Case SyntaxConstants.REL_FIG
            return ExitRelFig(CType(node,Production))

        Case SyntaxConstants.LOG_EXPR
            return ExitLogExpr(CType(node,Production))

        Case SyntaxConstants.NOT_FIG
            return ExitNotFig(CType(node,Production))

        Case SyntaxConstants.LOG_EXPR_NEXT
            return ExitLogExprNext(CType(node,Production))

        Case SyntaxConstants.LOG_OP
            return ExitLogOp(CType(node,Production))

        Case SyntaxConstants.COND_EELSIF
            return ExitCondEelsif(CType(node,Production))

        Case SyntaxConstants.COND_EELS
            return ExitCondEels(CType(node,Production))

        Case SyntaxConstants.SWASP_CASE
            return ExitSwaspCase(CType(node,Production))

        Case SyntaxConstants.SWASP_CASE1
            return ExitSwaspCase1(CType(node,Production))

        Case SyntaxConstants.TERM_EXPR
            return ExitTermExpr(CType(node,Production))

        Case SyntaxConstants.DEFAULT
            return ExitDefault(CType(node,Production))

        Case SyntaxConstants.ITERATIVE
            return ExitIterative(CType(node,Production))

        Case SyntaxConstants.LOOP_FIG1
            return ExitLoopFig1(CType(node,Production))

        Case SyntaxConstants.LOOP_FIG2
            return ExitLoopFig2(CType(node,Production))

        Case SyntaxConstants.INCREM_DECREM
            return ExitIncremDecrem(CType(node,Production))

        Case SyntaxConstants.UNARY_OP
            return ExitUnaryOp(CType(node,Production))

        Case SyntaxConstants.FUNCTION_CALL
            return ExitFunctionCall(CType(node,Production))

        Case SyntaxConstants.ARGS1
            return ExitArgs1(CType(node,Production))

        Case SyntaxConstants.ARGS2
            return ExitArgs2(CType(node,Production))

        Case SyntaxConstants.ARGS_TAIL
            return ExitArgsTail(CType(node,Production))

        Case SyntaxConstants.MULTI_ARGS
            return ExitMultiArgs(CType(node,Production))

        Case SyntaxConstants.SUB_FUNCTION
            return ExitSubFunction(CType(node,Production))

        Case SyntaxConstants.FUNC_ARGS
            return ExitFuncArgs(CType(node,Production))

        Case SyntaxConstants.FUNC_TAIL
            return ExitFuncTail(CType(node,Production))

        Case SyntaxConstants.ONE_ARRAY
            return ExitOneArray(CType(node,Production))

        Case SyntaxConstants.TWO_ARRAY
            return ExitTwoArray(CType(node,Production))

        Case SyntaxConstants.MULTIFUNC_ARGS
            return ExitMultifuncArgs(CType(node,Production))

        Case SyntaxConstants.RETURN
            return ExitReturn(CType(node,Production))

        Case SyntaxConstants.RESULT
            return ExitResult(CType(node,Production))

        Case SyntaxConstants.RESULT_TAIL
            return ExitResultTail(CType(node,Production))

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
        Case SyntaxConstants.PROGRAM
            ChildProgram(node, child)

        Case SyntaxConstants.PROD_COMMENT
            ChildProdComment(node, child)

        Case SyntaxConstants.GLOBAL_DEC
            ChildGlobalDec(node, child)

        Case SyntaxConstants.GLOBAL_FUNCDEC
            ChildGlobalFuncdec(node, child)

        Case SyntaxConstants.VAR_DEC
            ChildVarDec(node, child)

        Case SyntaxConstants.IDENT_VAR
            ChildIdentVar(node, child)

        Case SyntaxConstants.DTYPE
            ChildDtype(node, child)

        Case SyntaxConstants.NEXT2_VAR
            ChildNext2Var(node, child)

        Case SyntaxConstants.NEXT2VAR_TAIL
            ChildNext2varTail(node, child)

        Case SyntaxConstants.VAL
            ChildVal(node, child)

        Case SyntaxConstants.BUL_LIT
            ChildBulLit(node, child)

        Case SyntaxConstants.ARRAY1D
            ChildArray1d(node, child)

        Case SyntaxConstants.ELEM1D_NEXT
            ChildElem1dNext(node, child)

        Case SyntaxConstants.ELEM1D_LIST
            ChildElem1dList(node, child)

        Case SyntaxConstants.ELEMLIST1D_TAIL
            ChildElemlist1dTail(node, child)

        Case SyntaxConstants.ARRAY2D
            ChildArray2d(node, child)

        Case SyntaxConstants.ELEM2D_NEXT
            ChildElem2dNext(node, child)

        Case SyntaxConstants.ELEM2D_LIST
            ChildElem2dList(node, child)

        Case SyntaxConstants.SIZE
            ChildSize(node, child)

        Case SyntaxConstants.CONST_DEC
            ChildConstDec(node, child)

        Case SyntaxConstants.CONST_NEXT
            ChildConstNext(node, child)

        Case SyntaxConstants.FUNC_DEC
            ChildFuncDec(node, child)

        Case SyntaxConstants.DTYPE1
            ChildDtype1(node, child)

        Case SyntaxConstants.PARAM
            ChildParam(node, child)

        Case SyntaxConstants.MULTI_PARAM
            ChildMultiParam(node, child)

        Case SyntaxConstants.STORK_DEC
            ChildStorkDec(node, child)

        Case SyntaxConstants.STORK_ELEM
            ChildStorkElem(node, child)

        Case SyntaxConstants.MULTI_VARDEC
            ChildMultiVardec(node, child)

        Case SyntaxConstants.MULTISTORK_ELEM
            ChildMultistorkElem(node, child)

        Case SyntaxConstants.OBJ_DEC
            ChildObjDec(node, child)

        Case SyntaxConstants.PROD_MANE
            ChildProdMane(node, child)

        Case SyntaxConstants.LOCAL_DEC
            ChildLocalDec(node, child)

        Case SyntaxConstants.STATEMENT
            ChildStatement(node, child)

        Case SyntaxConstants.CLRSCR
            ChildClrscr(node, child)

        Case SyntaxConstants.STATEMENT1
            ChildStatement1(node, child)

        Case SyntaxConstants.STATEMENT_TAIL
            ChildStatementTail(node, child)

        Case SyntaxConstants.INPUT
            ChildInput(node, child)

        Case SyntaxConstants.SCAN_FIG
            ChildScanFig(node, child)

        Case SyntaxConstants.MULTI_INPUT
            ChildMultiInput(node, child)

        Case SyntaxConstants.ARR1D
            ChildArr1d(node, child)

        Case SyntaxConstants.ARR2D
            ChildArr2d(node, child)

        Case SyntaxConstants.STORK_ACCESS1
            ChildStorkAccess1(node, child)

        Case SyntaxConstants.OUTPUT
            ChildOutput(node, child)

        Case SyntaxConstants.OUTPUT_NEXT
            ChildOutputNext(node, child)

        Case SyntaxConstants.MULTI_OUTPUT
            ChildMultiOutput(node, child)

        Case SyntaxConstants.SCAN_FIG1
            ChildScanFig1(node, child)

        Case SyntaxConstants.MATH_EQ
            ChildMathEq(node, child)

        Case SyntaxConstants.MATH_EQTAIL
            ChildMathEqtail(node, child)

        Case SyntaxConstants.MATH_TAIL
            ChildMathTail(node, child)

        Case SyntaxConstants.MATH_OP
            ChildMathOp(node, child)

        Case SyntaxConstants.MATH_ID
            ChildMathId(node, child)

        Case SyntaxConstants.NEGATE
            ChildNegate(node, child)

        Case SyntaxConstants.MATHEQ_NEXT
            ChildMatheqNext(node, child)

        Case SyntaxConstants.CONDITIONAL
            ChildConditional(node, child)

        Case SyntaxConstants.COND_EXPR
            ChildCondExpr(node, child)

        Case SyntaxConstants.REL_EXPR1
            ChildRelExpr1(node, child)

        Case SyntaxConstants.RELEX_TAIL
            ChildRelexTail(node, child)

        Case SyntaxConstants.ARITHMETIC
            ChildArithmetic(node, child)

        Case SyntaxConstants.ARITHMETIC_TAIL
            ChildArithmeticTail(node, child)

        Case SyntaxConstants.EXPRESSION
            ChildExpression(node, child)

        Case SyntaxConstants.EXPR_NEXT
            ChildExprNext(node, child)

        Case SyntaxConstants.REL_OP1
            ChildRelOp1(node, child)

        Case SyntaxConstants.REL_OP2
            ChildRelOp2(node, child)

        Case SyntaxConstants.REL_FIG
            ChildRelFig(node, child)

        Case SyntaxConstants.LOG_EXPR
            ChildLogExpr(node, child)

        Case SyntaxConstants.NOT_FIG
            ChildNotFig(node, child)

        Case SyntaxConstants.LOG_EXPR_NEXT
            ChildLogExprNext(node, child)

        Case SyntaxConstants.LOG_OP
            ChildLogOp(node, child)

        Case SyntaxConstants.COND_EELSIF
            ChildCondEelsif(node, child)

        Case SyntaxConstants.COND_EELS
            ChildCondEels(node, child)

        Case SyntaxConstants.SWASP_CASE
            ChildSwaspCase(node, child)

        Case SyntaxConstants.SWASP_CASE1
            ChildSwaspCase1(node, child)

        Case SyntaxConstants.TERM_EXPR
            ChildTermExpr(node, child)

        Case SyntaxConstants.DEFAULT
            ChildDefault(node, child)

        Case SyntaxConstants.ITERATIVE
            ChildIterative(node, child)

        Case SyntaxConstants.LOOP_FIG1
            ChildLoopFig1(node, child)

        Case SyntaxConstants.LOOP_FIG2
            ChildLoopFig2(node, child)

        Case SyntaxConstants.INCREM_DECREM
            ChildIncremDecrem(node, child)

        Case SyntaxConstants.UNARY_OP
            ChildUnaryOp(node, child)

        Case SyntaxConstants.FUNCTION_CALL
            ChildFunctionCall(node, child)

        Case SyntaxConstants.ARGS1
            ChildArgs1(node, child)

        Case SyntaxConstants.ARGS2
            ChildArgs2(node, child)

        Case SyntaxConstants.ARGS_TAIL
            ChildArgsTail(node, child)

        Case SyntaxConstants.MULTI_ARGS
            ChildMultiArgs(node, child)

        Case SyntaxConstants.SUB_FUNCTION
            ChildSubFunction(node, child)

        Case SyntaxConstants.FUNC_ARGS
            ChildFuncArgs(node, child)

        Case SyntaxConstants.FUNC_TAIL
            ChildFuncTail(node, child)

        Case SyntaxConstants.ONE_ARRAY
            ChildOneArray(node, child)

        Case SyntaxConstants.TWO_ARRAY
            ChildTwoArray(node, child)

        Case SyntaxConstants.MULTIFUNC_ARGS
            ChildMultifuncArgs(node, child)

        Case SyntaxConstants.RETURN
            ChildReturn(node, child)

        Case SyntaxConstants.RESULT
            ChildResult(node, child)

        Case SyntaxConstants.RESULT_TAIL
            ChildResultTail(node, child)

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
    Public Overridable Sub EnterOdp(ByVal node As Token)
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
    Public Overridable Function ExitOdp(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCdp(ByVal node As Token)
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
    Public Overridable Function ExitCdp(ByVal node As Token) As Node
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
    Public Overridable Sub EnterAnd(ByVal node As Token)
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
    Public Overridable Function ExitAnd(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOr(ByVal node As Token)
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
    Public Overridable Function ExitOr(ByVal node As Token) As Node
        Return node
    End Function

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterQm(ByVal node As Token)
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
    Public Overridable Function ExitQm(ByVal node As Token) As Node
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
    Public Overridable Sub EnterProgram(ByVal node As Production)
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
    Public Overridable Function ExitProgram(ByVal node As Production) As Node
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
    Public Overridable Sub ChildProgram(ByVal node As Production, ByVal child As Node)
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
    Public Overridable Sub EnterGlobalDec(ByVal node As Production)
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
    Public Overridable Function ExitGlobalDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildGlobalDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterGlobalFuncdec(ByVal node As Production)
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
    Public Overridable Function ExitGlobalFuncdec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildGlobalFuncdec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterVarDec(ByVal node As Production)
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
    Public Overridable Function ExitVarDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildVarDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterIdentVar(ByVal node As Production)
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
    Public Overridable Function ExitIdentVar(ByVal node As Production) As Node
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
    Public Overridable Sub ChildIdentVar(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDtype(ByVal node As Production)
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
    Public Overridable Function ExitDtype(ByVal node As Production) As Node
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
    Public Overridable Sub ChildDtype(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNext2Var(ByVal node As Production)
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
    Public Overridable Function ExitNext2Var(ByVal node As Production) As Node
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
    Public Overridable Sub ChildNext2Var(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNext2varTail(ByVal node As Production)
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
    Public Overridable Function ExitNext2varTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildNext2varTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterVal(ByVal node As Production)
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
    Public Overridable Function ExitVal(ByVal node As Production) As Node
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
    Public Overridable Sub ChildVal(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterBulLit(ByVal node As Production)
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
    Public Overridable Function ExitBulLit(ByVal node As Production) As Node
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
    Public Overridable Sub ChildBulLit(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArray1d(ByVal node As Production)
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
    Public Overridable Function ExitArray1d(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArray1d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterElem1dNext(ByVal node As Production)
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
    Public Overridable Function ExitElem1dNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildElem1dNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterElem1dList(ByVal node As Production)
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
    Public Overridable Function ExitElem1dList(ByVal node As Production) As Node
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
    Public Overridable Sub ChildElem1dList(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterElemlist1dTail(ByVal node As Production)
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
    Public Overridable Function ExitElemlist1dTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildElemlist1dTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArray2d(ByVal node As Production)
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
    Public Overridable Function ExitArray2d(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArray2d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterElem2dNext(ByVal node As Production)
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
    Public Overridable Function ExitElem2dNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildElem2dNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterElem2dList(ByVal node As Production)
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
    Public Overridable Function ExitElem2dList(ByVal node As Production) As Node
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
    Public Overridable Sub ChildElem2dList(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSize(ByVal node As Production)
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
    Public Overridable Function ExitSize(ByVal node As Production) As Node
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
    Public Overridable Sub ChildSize(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterConstDec(ByVal node As Production)
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
    Public Overridable Function ExitConstDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildConstDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterConstNext(ByVal node As Production)
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
    Public Overridable Function ExitConstNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildConstNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFuncDec(ByVal node As Production)
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
    Public Overridable Function ExitFuncDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildFuncDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDtype1(ByVal node As Production)
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
    Public Overridable Function ExitDtype1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildDtype1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterParam(ByVal node As Production)
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
    Public Overridable Function ExitParam(ByVal node As Production) As Node
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
    Public Overridable Sub ChildParam(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultiParam(ByVal node As Production)
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
    Public Overridable Function ExitMultiParam(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultiParam(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStorkDec(ByVal node As Production)
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
    Public Overridable Function ExitStorkDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStorkDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStorkElem(ByVal node As Production)
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
    Public Overridable Function ExitStorkElem(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStorkElem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultiVardec(ByVal node As Production)
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
    Public Overridable Function ExitMultiVardec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultiVardec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultistorkElem(ByVal node As Production)
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
    Public Overridable Function ExitMultistorkElem(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultistorkElem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterObjDec(ByVal node As Production)
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
    Public Overridable Function ExitObjDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildObjDec(ByVal node As Production, ByVal child As Node)
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
    Public Overridable Sub EnterLocalDec(ByVal node As Production)
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
    Public Overridable Function ExitLocalDec(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLocalDec(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStatement(ByVal node As Production)
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
    Public Overridable Function ExitStatement(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStatement(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterClrscr(ByVal node As Production)
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
    Public Overridable Function ExitClrscr(ByVal node As Production) As Node
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
    Public Overridable Sub ChildClrscr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStatement1(ByVal node As Production)
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
    Public Overridable Function ExitStatement1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStatement1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStatementTail(ByVal node As Production)
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
    Public Overridable Function ExitStatementTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStatementTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterInput(ByVal node As Production)
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
    Public Overridable Function ExitInput(ByVal node As Production) As Node
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
    Public Overridable Sub ChildInput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterScanFig(ByVal node As Production)
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
    Public Overridable Function ExitScanFig(ByVal node As Production) As Node
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
    Public Overridable Sub ChildScanFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultiInput(ByVal node As Production)
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
    Public Overridable Function ExitMultiInput(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultiInput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArr1d(ByVal node As Production)
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
    Public Overridable Function ExitArr1d(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArr1d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArr2d(ByVal node As Production)
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
    Public Overridable Function ExitArr2d(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArr2d(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterStorkAccess1(ByVal node As Production)
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
    Public Overridable Function ExitStorkAccess1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildStorkAccess1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOutput(ByVal node As Production)
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
    Public Overridable Function ExitOutput(ByVal node As Production) As Node
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
    Public Overridable Sub ChildOutput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOutputNext(ByVal node As Production)
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
    Public Overridable Function ExitOutputNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildOutputNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultiOutput(ByVal node As Production)
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
    Public Overridable Function ExitMultiOutput(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultiOutput(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterScanFig1(ByVal node As Production)
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
    Public Overridable Function ExitScanFig1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildScanFig1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMathEq(ByVal node As Production)
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
    Public Overridable Function ExitMathEq(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMathEq(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMathEqtail(ByVal node As Production)
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
    Public Overridable Function ExitMathEqtail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMathEqtail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMathTail(ByVal node As Production)
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
    Public Overridable Function ExitMathTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMathTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMathOp(ByVal node As Production)
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
    Public Overridable Function ExitMathOp(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMathOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMathId(ByVal node As Production)
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
    Public Overridable Function ExitMathId(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMathId(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNegate(ByVal node As Production)
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
    Public Overridable Function ExitNegate(ByVal node As Production) As Node
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
    Public Overridable Sub ChildNegate(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMatheqNext(ByVal node As Production)
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
    Public Overridable Function ExitMatheqNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMatheqNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterConditional(ByVal node As Production)
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
    Public Overridable Function ExitConditional(ByVal node As Production) As Node
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
    Public Overridable Sub ChildConditional(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCondExpr(ByVal node As Production)
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
    Public Overridable Function ExitCondExpr(ByVal node As Production) As Node
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
    Public Overridable Sub ChildCondExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterRelExpr1(ByVal node As Production)
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
    Public Overridable Function ExitRelExpr1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildRelExpr1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterRelexTail(ByVal node As Production)
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
    Public Overridable Function ExitRelexTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildRelexTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArithmetic(ByVal node As Production)
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
    Public Overridable Function ExitArithmetic(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArithmetic(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArithmeticTail(ByVal node As Production)
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
    Public Overridable Function ExitArithmeticTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArithmeticTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterExpression(ByVal node As Production)
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
    Public Overridable Function ExitExpression(ByVal node As Production) As Node
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
    Public Overridable Sub ChildExpression(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterExprNext(ByVal node As Production)
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
    Public Overridable Function ExitExprNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildExprNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterRelOp1(ByVal node As Production)
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
    Public Overridable Function ExitRelOp1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildRelOp1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterRelOp2(ByVal node As Production)
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
    Public Overridable Function ExitRelOp2(ByVal node As Production) As Node
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
    Public Overridable Sub ChildRelOp2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterRelFig(ByVal node As Production)
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
    Public Overridable Function ExitRelFig(ByVal node As Production) As Node
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
    Public Overridable Sub ChildRelFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLogExpr(ByVal node As Production)
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
    Public Overridable Function ExitLogExpr(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLogExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterNotFig(ByVal node As Production)
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
    Public Overridable Function ExitNotFig(ByVal node As Production) As Node
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
    Public Overridable Sub ChildNotFig(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLogExprNext(ByVal node As Production)
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
    Public Overridable Function ExitLogExprNext(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLogExprNext(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLogOp(ByVal node As Production)
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
    Public Overridable Function ExitLogOp(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLogOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCondEelsif(ByVal node As Production)
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
    Public Overridable Function ExitCondEelsif(ByVal node As Production) As Node
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
    Public Overridable Sub ChildCondEelsif(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterCondEels(ByVal node As Production)
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
    Public Overridable Function ExitCondEels(ByVal node As Production) As Node
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
    Public Overridable Sub ChildCondEels(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSwaspCase(ByVal node As Production)
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
    Public Overridable Function ExitSwaspCase(ByVal node As Production) As Node
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
    Public Overridable Sub ChildSwaspCase(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSwaspCase1(ByVal node As Production)
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
    Public Overridable Function ExitSwaspCase1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildSwaspCase1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterTermExpr(ByVal node As Production)
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
    Public Overridable Function ExitTermExpr(ByVal node As Production) As Node
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
    Public Overridable Sub ChildTermExpr(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterDefault(ByVal node As Production)
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
    Public Overridable Function ExitDefault(ByVal node As Production) As Node
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
    Public Overridable Sub ChildDefault(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterIterative(ByVal node As Production)
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
    Public Overridable Function ExitIterative(ByVal node As Production) As Node
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
    Public Overridable Sub ChildIterative(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLoopFig1(ByVal node As Production)
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
    Public Overridable Function ExitLoopFig1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLoopFig1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterLoopFig2(ByVal node As Production)
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
    Public Overridable Function ExitLoopFig2(ByVal node As Production) As Node
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
    Public Overridable Sub ChildLoopFig2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterIncremDecrem(ByVal node As Production)
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
    Public Overridable Function ExitIncremDecrem(ByVal node As Production) As Node
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
    Public Overridable Sub ChildIncremDecrem(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterUnaryOp(ByVal node As Production)
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
    Public Overridable Function ExitUnaryOp(ByVal node As Production) As Node
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
    Public Overridable Sub ChildUnaryOp(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFunctionCall(ByVal node As Production)
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
    Public Overridable Function ExitFunctionCall(ByVal node As Production) As Node
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
    Public Overridable Sub ChildFunctionCall(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArgs1(ByVal node As Production)
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
    Public Overridable Function ExitArgs1(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArgs1(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArgs2(ByVal node As Production)
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
    Public Overridable Function ExitArgs2(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArgs2(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterArgsTail(ByVal node As Production)
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
    Public Overridable Function ExitArgsTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildArgsTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultiArgs(ByVal node As Production)
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
    Public Overridable Function ExitMultiArgs(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultiArgs(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterSubFunction(ByVal node As Production)
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
    Public Overridable Function ExitSubFunction(ByVal node As Production) As Node
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
    Public Overridable Sub ChildSubFunction(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFuncArgs(ByVal node As Production)
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
    Public Overridable Function ExitFuncArgs(ByVal node As Production) As Node
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
    Public Overridable Sub ChildFuncArgs(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterFuncTail(ByVal node As Production)
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
    Public Overridable Function ExitFuncTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildFuncTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterOneArray(ByVal node As Production)
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
    Public Overridable Function ExitOneArray(ByVal node As Production) As Node
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
    Public Overridable Sub ChildOneArray(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterTwoArray(ByVal node As Production)
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
    Public Overridable Function ExitTwoArray(ByVal node As Production) As Node
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
    Public Overridable Sub ChildTwoArray(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterMultifuncArgs(ByVal node As Production)
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
    Public Overridable Function ExitMultifuncArgs(ByVal node As Production) As Node
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
    Public Overridable Sub ChildMultifuncArgs(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterReturn(ByVal node As Production)
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
    Public Overridable Function ExitReturn(ByVal node As Production) As Node
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
    Public Overridable Sub ChildReturn(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterResult(ByVal node As Production)
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
    Public Overridable Function ExitResult(ByVal node As Production) As Node
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
    Public Overridable Sub ChildResult(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub

    '''<summary>Called when entering a parse tree node.</summary>
    '''
    '''<param name='node'>the node being entered</param>
    '''
    '''<exception cref='ParseException'>if the node analysis
    '''discovered errors</exception>
    Public Overridable Sub EnterResultTail(ByVal node As Production)
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
    Public Overridable Function ExitResultTail(ByVal node As Production) As Node
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
    Public Overridable Sub ChildResultTail(ByVal node As Production, ByVal child As Node)
        node.AddChild(child)
    End Sub
End Class
