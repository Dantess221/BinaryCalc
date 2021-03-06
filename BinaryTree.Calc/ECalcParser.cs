using Antlr.Runtime;
using Antlr.Runtime.Tree;
using ArrayList = System.Collections.ArrayList;

public class ECalcParser : Parser
{
    public static readonly string[] tokenNames = new string[]
    {
        "<invalid>",
        "<EOR>",
        "<DOWN>",
        "<UP>",
        "PARAM",
        "NEGATE",
        "STRING",
        "OR",
        "AND",
        "EQUALS",
        "NOTEQUALS",
        "LT",
        "LTEQ",
        "GT",
        "GTEQ",
        "PLUS",
        "MINUS",
        "MULT",
        "DIV",
        "MOD",
        "POW",
        "NOT",
        "INTEGER",
        "FLOAT",
        "DATETIME",
        "BOOLEAN",
        "IDENT",
        "EscapeSequence",
        "UnicodeEscape",
        "HexDigit",
        "WS",
        "'('",
        "')'",
        "'['",
        "']'",
        "','"
    };

    public const int INTEGER = 22;
    public const int LT = 11;
    public const int MOD = 19;
    public const int DATETIME = 24;
    public const int LTEQ = 12;
    public const int NEGATE = 5;
    public const int NOTEQUALS = 10;
    public const int PARAM = 4;
    public const int FLOAT = 23;
    public const int EQUALS = 9;
    public const int NOT = 21;
    public const int GTEQ = 14;
    public const int MINUS = 16;
    public const int MULT = 17;
    public const int AND = 8;
    public const int EOF = -1;
    public const int HexDigit = 29;
    public const int WS = 30;
    public const int BOOLEAN = 25;
    public const int POW = 20;
    public const int UnicodeEscape = 28;
    public const int OR = 7;
    public const int IDENT = 26;
    public const int GT = 13;
    public const int PLUS = 15;
    public const int DIV = 18;
    public const int EscapeSequence = 27;
    public const int STRING = 6;


    public ECalcParser(ITokenStream input)
        : base(input)
    {
        InitializeCyclicDFAs();
    }

    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get => adaptor;
        set => adaptor = value;
    }

    public override string[] TokenNames => tokenNames;

    private readonly ArrayList exceptions = new ArrayList();

    public override void ReportError(RecognitionException e)
    {
        exceptions.Add(e);
    }

    public bool HasError => exceptions.Count > 0;

    public string ErrorMessage => GetErrorMessage(exceptions[0] as RecognitionException, TokenNames);

    public string ErrorPosition => GetErrorHeader(exceptions[0] as RecognitionException);

    public class expression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public expression_return expression()
    {
        expression_return retval = new expression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken EOF2 = null;
        logicalExpression_return logicalExpression1 = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_logicalExpression_in_expression64);
                logicalExpression1 = logicalExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, logicalExpression1.Tree);
                EOF2 = input.LT(1);
                Match(input, EOF, FOLLOW_EOF_in_expression66);

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class logicalExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public logicalExpression_return logicalExpression()
    {
        logicalExpression_return retval = new logicalExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken OR4 = null;
        booleanAndExpression_return booleanAndExpression3 = null;

        booleanAndExpression_return booleanAndExpression5 = null;


        CommonTree OR4_tree = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_booleanAndExpression_in_logicalExpression80);
                booleanAndExpression3 = booleanAndExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, booleanAndExpression3.Tree);
                do
                {
                    int alt1 = 2;
                    int LA1_0 = input.LA(1);

                    if ((LA1_0 == OR))
                    {
                        alt1 = 1;
                    }


                    switch (alt1)
                    {
                        case 1:
                            {
                                OR4 = input.LT(1);
                                Match(input, OR, FOLLOW_OR_in_logicalExpression83);
                                OR4_tree = (CommonTree)adaptor.Create(OR4);
                                root_0 = (CommonTree)adaptor.BecomeRoot(OR4_tree, root_0);

                                PushFollow(FOLLOW_booleanAndExpression_in_logicalExpression86);
                                booleanAndExpression5 = booleanAndExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, booleanAndExpression5.Tree);

                            }
                            break;

                        default:
                            goto loop1;
                    }
                } while (true);

                loop1:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class booleanAndExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public booleanAndExpression_return booleanAndExpression()
    {
        booleanAndExpression_return retval = new booleanAndExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken AND7 = null;
        equalityExpression_return equalityExpression6 = null;

        equalityExpression_return equalityExpression8 = null;


        CommonTree AND7_tree = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_equalityExpression_in_booleanAndExpression116);
                equalityExpression6 = equalityExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, equalityExpression6.Tree);
                do
                {
                    int alt2 = 2;
                    int LA2_0 = input.LA(1);

                    if ((LA2_0 == AND))
                    {
                        alt2 = 1;
                    }


                    switch (alt2)
                    {
                        case 1:
                            {
                                AND7 = input.LT(1);
                                Match(input, AND, FOLLOW_AND_in_booleanAndExpression119);
                                AND7_tree = (CommonTree)adaptor.Create(AND7);
                                root_0 = (CommonTree)adaptor.BecomeRoot(AND7_tree, root_0);

                                PushFollow(FOLLOW_equalityExpression_in_booleanAndExpression122);
                                equalityExpression8 = equalityExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, equalityExpression8.Tree);

                            }
                            break;

                        default:
                            goto loop2;
                    }
                } while (true);

                loop2:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class equalityExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public equalityExpression_return equalityExpression()
    {
        equalityExpression_return retval = new equalityExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken set10 = null;
        relationalExpression_return relationalExpression9 = null;

        relationalExpression_return relationalExpression11 = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_relationalExpression_in_equalityExpression150);
                relationalExpression9 = relationalExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, relationalExpression9.Tree);
                do
                {
                    int alt3 = 2;
                    int LA3_0 = input.LA(1);

                    if (((LA3_0 >= EQUALS && LA3_0 <= NOTEQUALS)))
                    {
                        alt3 = 1;
                    }


                    switch (alt3)
                    {
                        case 1:
                            {
                                set10 = input.LT(1);
                                if ((input.LA(1) >= EQUALS && input.LA(1) <= NOTEQUALS))
                                {
                                    input.Consume();
                                    root_0 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(set10), root_0);
                                    errorRecovery = false;
                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    RecoverFromMismatchedSet(input, mse, FOLLOW_set_in_equalityExpression153); throw mse;
                                }

                                PushFollow(FOLLOW_relationalExpression_in_equalityExpression160);
                                relationalExpression11 = relationalExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, relationalExpression11.Tree);

                            }
                            break;

                        default:
                            goto loop3;
                    }
                } while (true);

                loop3:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class relationalExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public relationalExpression_return relationalExpression()
    {
        relationalExpression_return retval = new relationalExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken set13 = null;
        additiveExpression_return additiveExpression12 = null;

        additiveExpression_return additiveExpression14 = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_additiveExpression_in_relationalExpression200);
                additiveExpression12 = additiveExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, additiveExpression12.Tree);
                do
                {
                    int alt4 = 2;
                    int LA4_0 = input.LA(1);

                    if (((LA4_0 >= LT && LA4_0 <= GTEQ)))
                    {
                        alt4 = 1;
                    }


                    switch (alt4)
                    {
                        case 1:
                            {
                                set13 = input.LT(1);
                                if ((input.LA(1) >= LT && input.LA(1) <= GTEQ))
                                {
                                    input.Consume();
                                    root_0 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(set13), root_0);
                                    errorRecovery = false;
                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    RecoverFromMismatchedSet(input, mse, FOLLOW_set_in_relationalExpression204); throw mse;
                                }

                                PushFollow(FOLLOW_additiveExpression_in_relationalExpression215);
                                additiveExpression14 = additiveExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, additiveExpression14.Tree);

                            }
                            break;

                        default:
                            goto loop4;
                    }
                } while (true);

                loop4:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class additiveExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public additiveExpression_return additiveExpression()
    {
        additiveExpression_return retval = new additiveExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken set16 = null;
        multiplicativeExpression_return multiplicativeExpression15 = null;

        multiplicativeExpression_return multiplicativeExpression17 = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression258);
                multiplicativeExpression15 = multiplicativeExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, multiplicativeExpression15.Tree);
                do
                {
                    int alt5 = 2;
                    int LA5_0 = input.LA(1);

                    if (((LA5_0 >= PLUS && LA5_0 <= MINUS)))
                    {
                        alt5 = 1;
                    }


                    switch (alt5)
                    {
                        case 1:
                            {
                                set16 = input.LT(1);
                                if ((input.LA(1) >= PLUS && input.LA(1) <= MINUS))
                                {
                                    input.Consume();
                                    root_0 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(set16), root_0);
                                    errorRecovery = false;
                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    RecoverFromMismatchedSet(input, mse, FOLLOW_set_in_additiveExpression262); throw mse;
                                }

                                PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression269);
                                multiplicativeExpression17 = multiplicativeExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, multiplicativeExpression17.Tree);

                            }
                            break;

                        default:
                            goto loop5;
                    }
                } while (true);

                loop5:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public multiplicativeExpression_return multiplicativeExpression()
    {
        multiplicativeExpression_return retval = new multiplicativeExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken set19 = null;
        powerExpression_return powerExpression18 = null;

        powerExpression_return powerExpression20 = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_powerExpression_in_multiplicativeExpression299);
                powerExpression18 = powerExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, powerExpression18.Tree);
                do
                {
                    int alt6 = 2;
                    int LA6_0 = input.LA(1);

                    if (((LA6_0 >= MULT && LA6_0 <= MOD)))
                    {
                        alt6 = 1;
                    }


                    switch (alt6)
                    {
                        case 1:
                            {
                                set19 = input.LT(1);
                                if ((input.LA(1) >= MULT && input.LA(1) <= MOD))
                                {
                                    input.Consume();
                                    root_0 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(set19), root_0);
                                    errorRecovery = false;
                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    RecoverFromMismatchedSet(input, mse, FOLLOW_set_in_multiplicativeExpression303); throw mse;
                                }

                                PushFollow(FOLLOW_powerExpression_in_multiplicativeExpression312);
                                powerExpression20 = powerExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, powerExpression20.Tree);

                            }
                            break;

                        default:
                            goto loop6;
                    }
                } while (true);

                loop6:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class powerExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public powerExpression_return powerExpression()
    {
        powerExpression_return retval = new powerExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken POW22 = null;
        unaryExpression_return unaryExpression21 = null;

        unaryExpression_return unaryExpression23 = null;


        CommonTree POW22_tree = null;

        try
        {
            {
                root_0 = (CommonTree)adaptor.GetNilNode();

                PushFollow(FOLLOW_unaryExpression_in_powerExpression350);
                unaryExpression21 = unaryExpression();
                followingStackPointer_--;

                adaptor.AddChild(root_0, unaryExpression21.Tree);
                do
                {
                    int alt7 = 2;
                    int LA7_0 = input.LA(1);

                    if ((LA7_0 == POW))
                    {
                        alt7 = 1;
                    }


                    switch (alt7)
                    {
                        case 1:
                            {
                                POW22 = input.LT(1);
                                Match(input, POW, FOLLOW_POW_in_powerExpression354);
                                POW22_tree = (CommonTree)adaptor.Create(POW22);
                                root_0 = (CommonTree)adaptor.BecomeRoot(POW22_tree, root_0);

                                PushFollow(FOLLOW_unaryExpression_in_powerExpression357);
                                unaryExpression23 = unaryExpression();
                                followingStackPointer_--;

                                adaptor.AddChild(root_0, unaryExpression23.Tree);

                            }
                            break;

                        default:
                            goto loop7;
                    }
                } while (true);

                loop7:
                ;

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class unaryExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public unaryExpression_return unaryExpression()
    {
        unaryExpression_return retval = new unaryExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken NOT25 = null;
        IToken MINUS27 = null;
        primaryExpression_return primaryExpression24 = null;

        primaryExpression_return primaryExpression26 = null;

        primaryExpression_return primaryExpression28 = null;


        CommonTree NOT25_tree = null;
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor, "token MINUS");
        RewriteRuleSubtreeStream stream_primaryExpression = new RewriteRuleSubtreeStream(adaptor, "rule primaryExpression");
        try
        {
            int alt8 = 3;
            switch (input.LA(1))
            {
                case STRING:
                case INTEGER:
                case FLOAT:
                case DATETIME:
                case BOOLEAN:
                case IDENT:
                case 31:
                case 33:
                    {
                        alt8 = 1;
                    }
                    break;
                case NOT:
                    {
                        alt8 = 2;
                    }
                    break;
                case MINUS:
                    {
                        alt8 = 3;
                    }
                    break;
                default:
                    NoViableAltException nvae_d8s0 =
                        new NoViableAltException("91:1: unaryExpression : ( primaryExpression | NOT primaryExpression | MINUS primaryExpression -> ^( NEGATE primaryExpression ) );", 8, 0, input);

                    throw nvae_d8s0;
            }

            switch (alt8)
            {
                case 1:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        PushFollow(FOLLOW_primaryExpression_in_unaryExpression380);
                        primaryExpression24 = primaryExpression();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, primaryExpression24.Tree);

                    }
                    break;
                case 2:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        NOT25 = input.LT(1);
                        Match(input, NOT, FOLLOW_NOT_in_unaryExpression389);
                        NOT25_tree = (CommonTree)adaptor.Create(NOT25);
                        root_0 = (CommonTree)adaptor.BecomeRoot(NOT25_tree, root_0);

                        PushFollow(FOLLOW_primaryExpression_in_unaryExpression392);
                        primaryExpression26 = primaryExpression();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, primaryExpression26.Tree);

                    }
                    break;
                case 3:
                    {
                        MINUS27 = input.LT(1);
                        Match(input, MINUS, FOLLOW_MINUS_in_unaryExpression401);
                        stream_MINUS.Add(MINUS27);

                        PushFollow(FOLLOW_primaryExpression_in_unaryExpression403);
                        primaryExpression28 = primaryExpression();
                        followingStackPointer_--;

                        stream_primaryExpression.Add(primaryExpression28.Tree);

                        retval.tree = root_0;
                        RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval != null ? retval.Tree : null));

                        root_0 = (CommonTree)adaptor.GetNilNode();
                        {
                            {
                                CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                                root_1 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(NEGATE, "NEGATE"), root_1);

                                adaptor.AddChild(root_1, stream_primaryExpression.Next());

                                adaptor.AddChild(root_0, root_1);
                            }

                        }



                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class primaryExpression_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public primaryExpression_return primaryExpression()
    {
        primaryExpression_return retval = new primaryExpression_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken char_literal29 = null;
        IToken char_literal31 = null;
        logicalExpression_return logicalExpression30 = null;

        value_return value32 = null;

        try
        {
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ((LA9_0 == 31))
            {
                alt9 = 1;
            }
            else if ((LA9_0 == STRING || (LA9_0 >= INTEGER && LA9_0 <= IDENT) || LA9_0 == 33))
            {
                alt9 = 2;
            }
            else
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("99:1: primaryExpression : ( '(' logicalExpression ')' | value );", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9)
            {
                case 1:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        char_literal29 = input.LT(1);
                        Match(input, 31, FOLLOW_31_in_primaryExpression439);
                        PushFollow(FOLLOW_logicalExpression_in_primaryExpression442);
                        logicalExpression30 = logicalExpression();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, logicalExpression30.Tree);
                        char_literal31 = input.LT(1);
                        Match(input, 32, FOLLOW_32_in_primaryExpression444);

                    }
                    break;
                case 2:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        PushFollow(FOLLOW_value_in_primaryExpression450);
                        value32 = value();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, value32.Tree);

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class value_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public value_return value()
    {
        value_return retval = new value_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken INTEGER33 = null;
        IToken FLOAT34 = null;
        IToken DATETIME35 = null;
        IToken BOOLEAN36 = null;
        IToken STRING37 = null;
        function_return function38 = null;

        parameter_return parameter39 = null;


        CommonTree INTEGER33_tree = null;
        CommonTree FLOAT34_tree = null;
        CommonTree DATETIME35_tree = null;
        CommonTree BOOLEAN36_tree = null;
        CommonTree STRING37_tree = null;

        try
        {
            int alt10 = 7;
            switch (input.LA(1))
            {
                case INTEGER:
                    {
                        alt10 = 1;
                    }
                    break;
                case FLOAT:
                    {
                        alt10 = 2;
                    }
                    break;
                case DATETIME:
                    {
                        alt10 = 3;
                    }
                    break;
                case BOOLEAN:
                    {
                        alt10 = 4;
                    }
                    break;
                case STRING:
                    {
                        alt10 = 5;
                    }
                    break;
                case IDENT:
                    {
                        alt10 = 6;
                    }
                    break;
                case 33:
                    {
                        alt10 = 7;
                    }
                    break;
                default:
                    NoViableAltException nvae_d10s0 =
                        new NoViableAltException("104:1: value : ( INTEGER | FLOAT | DATETIME | BOOLEAN | STRING | function | parameter );", 10, 0, input);

                    throw nvae_d10s0;
            }

            switch (alt10)
            {
                case 1:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        INTEGER33 = input.LT(1);
                        Match(input, INTEGER, FOLLOW_INTEGER_in_value464);
                        INTEGER33_tree = (CommonTree)adaptor.Create(INTEGER33);
                        adaptor.AddChild(root_0, INTEGER33_tree);


                    }
                    break;
                case 2:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        FLOAT34 = input.LT(1);
                        Match(input, FLOAT, FOLLOW_FLOAT_in_value469);
                        FLOAT34_tree = (CommonTree)adaptor.Create(FLOAT34);
                        adaptor.AddChild(root_0, FLOAT34_tree);


                    }
                    break;
                case 3:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        DATETIME35 = input.LT(1);
                        Match(input, DATETIME, FOLLOW_DATETIME_in_value475);
                        DATETIME35_tree = (CommonTree)adaptor.Create(DATETIME35);
                        adaptor.AddChild(root_0, DATETIME35_tree);


                    }
                    break;
                case 4:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        BOOLEAN36 = input.LT(1);
                        Match(input, BOOLEAN, FOLLOW_BOOLEAN_in_value480);
                        BOOLEAN36_tree = (CommonTree)adaptor.Create(BOOLEAN36);
                        adaptor.AddChild(root_0, BOOLEAN36_tree);


                    }
                    break;
                case 5:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        STRING37 = input.LT(1);
                        Match(input, STRING, FOLLOW_STRING_in_value485);
                        STRING37_tree = (CommonTree)adaptor.Create(STRING37);
                        adaptor.AddChild(root_0, STRING37_tree);


                    }
                    break;
                case 6:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        PushFollow(FOLLOW_function_in_value490);
                        function38 = function();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, function38.Tree);

                    }
                    break;
                case 7:
                    {
                        root_0 = (CommonTree)adaptor.GetNilNode();

                        PushFollow(FOLLOW_parameter_in_value495);
                        parameter39 = parameter();
                        followingStackPointer_--;

                        adaptor.AddChild(root_0, parameter39.Tree);

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class parameter_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public parameter_return parameter()
    {
        parameter_return retval = new parameter_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken char_literal40 = null;
        IToken IDENT41 = null;
        IToken INTEGER42 = null;
        IToken char_literal43 = null;
        RewriteRuleTokenStream stream_INTEGER = new RewriteRuleTokenStream(adaptor, "token INTEGER");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor, "token IDENT");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor, "token 33");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor, "token 34");

        try
        {
            {
                char_literal40 = input.LT(1);
                Match(input, 33, FOLLOW_33_in_parameter506);
                stream_33.Add(char_literal40);

                int alt11 = 2;
                int LA11_0 = input.LA(1);

                if ((LA11_0 == IDENT))
                {
                    alt11 = 1;
                }
                else if ((LA11_0 == INTEGER))
                {
                    alt11 = 2;
                }
                else
                {
                    NoViableAltException nvae_d11s0 =
                        new NoViableAltException("115:8: ( IDENT | INTEGER )", 11, 0, input);

                    throw nvae_d11s0;
                }
                switch (alt11)
                {
                    case 1:
                        {
                            IDENT41 = input.LT(1);
                            Match(input, IDENT, FOLLOW_IDENT_in_parameter509);
                            stream_IDENT.Add(IDENT41);


                        }
                        break;
                    case 2:
                        {
                            INTEGER42 = input.LT(1);
                            Match(input, INTEGER, FOLLOW_INTEGER_in_parameter511);
                            stream_INTEGER.Add(INTEGER42);


                        }
                        break;

                }

                char_literal43 = input.LT(1);
                Match(input, 34, FOLLOW_34_in_parameter514);
                stream_34.Add(char_literal43);


                retval.tree = root_0;
                RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval != null ? retval.Tree : null));

                root_0 = (CommonTree)adaptor.GetNilNode();
                {
                    {
                        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                        root_1 = (CommonTree)adaptor.BecomeRoot(adaptor.Create(PARAM, "PARAM"), root_1);

                        if (stream_IDENT.HasNext())
                        {
                            adaptor.AddChild(root_1, stream_IDENT.Next());

                        }
                        stream_IDENT.Reset();
                        if (stream_INTEGER.HasNext())
                        {
                            adaptor.AddChild(root_1, stream_INTEGER.Next());

                        }
                        stream_INTEGER.Reset();

                        adaptor.AddChild(root_0, root_1);
                    }

                }



            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }

    public class function_return : ParserRuleReturnScope
    {
        internal CommonTree tree;
        public override object Tree => tree;
    };

    public function_return function()
    {
        function_return retval = new function_return
        {
            start = input.LT(1)
        };

        CommonTree root_0 = null;

        IToken IDENT44 = null;
        IToken char_literal45 = null;
        IToken char_literal47 = null;
        IToken char_literal49 = null;
        logicalExpression_return logicalExpression46 = null;

        logicalExpression_return logicalExpression48 = null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor, "token IDENT");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor, "token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor, "token 31");
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor, "token 35");
        RewriteRuleSubtreeStream stream_logicalExpression = new RewriteRuleSubtreeStream(adaptor, "rule logicalExpression");
        try
        {
            {
                IDENT44 = input.LT(1);
                Match(input, IDENT, FOLLOW_IDENT_in_function685);
                stream_IDENT.Add(IDENT44);

                char_literal45 = input.LT(1);
                Match(input, 31, FOLLOW_31_in_function687);
                stream_31.Add(char_literal45);

                int alt13 = 2;
                int LA13_0 = input.LA(1);

                if ((LA13_0 == STRING || LA13_0 == MINUS || (LA13_0 >= NOT && LA13_0 <= IDENT) || LA13_0 == 31 || LA13_0 == 33))
                {
                    alt13 = 1;
                }
                switch (alt13)
                {
                    case 1:
                        {
                            PushFollow(FOLLOW_logicalExpression_in_function691);
                            logicalExpression46 = logicalExpression();
                            followingStackPointer_--;

                            stream_logicalExpression.Add(logicalExpression46.Tree);
                            do
                            {
                                int alt12 = 2;
                                int LA12_0 = input.LA(1);

                                if ((LA12_0 == 35))
                                {
                                    alt12 = 1;
                                }


                                switch (alt12)
                                {
                                    case 1:
                                        {
                                            char_literal47 = input.LT(1);
                                            Match(input, 35, FOLLOW_35_in_function694);
                                            stream_35.Add(char_literal47);

                                            PushFollow(FOLLOW_logicalExpression_in_function696);
                                            logicalExpression48 = logicalExpression();
                                            followingStackPointer_--;

                                            stream_logicalExpression.Add(logicalExpression48.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop12;
                                }
                            } while (true);

                            loop12:
                            ;

                        }
                        break;

                }

                char_literal49 = input.LT(1);
                Match(input, 32, FOLLOW_32_in_function703);
                stream_32.Add(char_literal49);


                retval.tree = root_0;
                RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval != null ? retval.Tree : null));

                root_0 = (CommonTree)adaptor.GetNilNode();
                {
                    {
                        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                        root_1 = (CommonTree)adaptor.BecomeRoot(stream_IDENT.Next(), root_1);

                        while (stream_logicalExpression.HasNext())
                        {
                            adaptor.AddChild(root_1, stream_logicalExpression.Next());

                        }
                        stream_logicalExpression.Reset();

                        adaptor.AddChild(root_0, root_1);
                    }

                }



            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            adaptor.SetTokenBoundaries(retval.Tree, retval.start, retval.stop);

        }
        catch (RecognitionException re)
        {
            ReportError(re);
            Recover(input, re);
        }
        finally
        {
        }
        return retval;
    }


    private void InitializeCyclicDFAs()
    {
    }



    public static readonly BitSet FOLLOW_logicalExpression_in_expression64 = new BitSet(new ulong[] { 0x0000000000000000UL });
    public static readonly BitSet FOLLOW_EOF_in_expression66 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_booleanAndExpression_in_logicalExpression80 = new BitSet(new ulong[] { 0x0000000000000082UL });
    public static readonly BitSet FOLLOW_OR_in_logicalExpression83 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_booleanAndExpression_in_logicalExpression86 = new BitSet(new ulong[] { 0x0000000000000082UL });
    public static readonly BitSet FOLLOW_equalityExpression_in_booleanAndExpression116 = new BitSet(new ulong[] { 0x0000000000000102UL });
    public static readonly BitSet FOLLOW_AND_in_booleanAndExpression119 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_equalityExpression_in_booleanAndExpression122 = new BitSet(new ulong[] { 0x0000000000000102UL });
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression150 = new BitSet(new ulong[] { 0x0000000000000602UL });
    public static readonly BitSet FOLLOW_set_in_equalityExpression153 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression160 = new BitSet(new ulong[] { 0x0000000000000602UL });
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression200 = new BitSet(new ulong[] { 0x0000000000007802UL });
    public static readonly BitSet FOLLOW_set_in_relationalExpression204 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression215 = new BitSet(new ulong[] { 0x0000000000007802UL });
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression258 = new BitSet(new ulong[] { 0x0000000000018002UL });
    public static readonly BitSet FOLLOW_set_in_additiveExpression262 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression269 = new BitSet(new ulong[] { 0x0000000000018002UL });
    public static readonly BitSet FOLLOW_powerExpression_in_multiplicativeExpression299 = new BitSet(new ulong[] { 0x00000000000E0002UL });
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression303 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_powerExpression_in_multiplicativeExpression312 = new BitSet(new ulong[] { 0x00000000000E0002UL });
    public static readonly BitSet FOLLOW_unaryExpression_in_powerExpression350 = new BitSet(new ulong[] { 0x0000000000100002UL });
    public static readonly BitSet FOLLOW_POW_in_powerExpression354 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_unaryExpression_in_powerExpression357 = new BitSet(new ulong[] { 0x0000000000100002UL });
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression380 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_NOT_in_unaryExpression389 = new BitSet(new ulong[] { 0x0000000287C00040UL });
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression392 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_MINUS_in_unaryExpression401 = new BitSet(new ulong[] { 0x0000000287C00040UL });
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression403 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_31_in_primaryExpression439 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_logicalExpression_in_primaryExpression442 = new BitSet(new ulong[] { 0x0000000100000000UL });
    public static readonly BitSet FOLLOW_32_in_primaryExpression444 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_value_in_primaryExpression450 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_INTEGER_in_value464 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_FLOAT_in_value469 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_DATETIME_in_value475 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_BOOLEAN_in_value480 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_STRING_in_value485 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_function_in_value490 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_parameter_in_value495 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_33_in_parameter506 = new BitSet(new ulong[] { 0x0000000004400000UL });
    public static readonly BitSet FOLLOW_IDENT_in_parameter509 = new BitSet(new ulong[] { 0x0000000400000000UL });
    public static readonly BitSet FOLLOW_INTEGER_in_parameter511 = new BitSet(new ulong[] { 0x0000000400000000UL });
    public static readonly BitSet FOLLOW_34_in_parameter514 = new BitSet(new ulong[] { 0x0000000000000002UL });
    public static readonly BitSet FOLLOW_IDENT_in_function685 = new BitSet(new ulong[] { 0x0000000080000000UL });
    public static readonly BitSet FOLLOW_31_in_function687 = new BitSet(new ulong[] { 0x0000000387E10040UL });
    public static readonly BitSet FOLLOW_logicalExpression_in_function691 = new BitSet(new ulong[] { 0x0000000900000000UL });
    public static readonly BitSet FOLLOW_35_in_function694 = new BitSet(new ulong[] { 0x0000000287E10040UL });
    public static readonly BitSet FOLLOW_logicalExpression_in_function696 = new BitSet(new ulong[] { 0x0000000900000000UL });
    public static readonly BitSet FOLLOW_32_in_function703 = new BitSet(new ulong[] { 0x0000000000000002UL });

}
