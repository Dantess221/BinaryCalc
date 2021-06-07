using Antlr.Runtime;



public class ECalcLexer : Lexer
{
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
    public const int Tokens = 36;
    public const int EOF = -1;
    public const int HexDigit = 29;
    public const int BOOLEAN = 25;
    public const int WS = 30;
    public const int POW = 20;
    public const int UnicodeEscape = 28;
    public const int OR = 7;
    public const int GT = 13;
    public const int IDENT = 26;
    public const int PLUS = 15;
    public const int DIV = 18;
    public const int T34 = 34;
    public const int T33 = 33;
    public const int T35 = 35;
    public const int EscapeSequence = 27;
    public const int T32 = 32;
    public const int STRING = 6;
    public const int T31 = 31;

    public ECalcLexer()
    {
        InitializeCyclicDFAs();
    }
    public ECalcLexer(ICharStream input)
        : base(input)
    {
        InitializeCyclicDFAs();
    }



    public void mT31()
    {
        try
        {
            int _type = T31;

            {
                Match('(');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mT32()
    {
        try
        {
            int _type = T32;

            {
                Match(')');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mT33()
    {
        try
        {
            int _type = T33;

            {
                Match('[');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mT34()
    {
        try
        {
            int _type = T34;


            {
                Match(']');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mT35()
    {
        try
        {
            int _type = T35;


            {
                Match(',');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mOR()
    {
        try
        {
            int _type = OR;
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ((LA1_0 == '|'))
            {
                alt1 = 1;
            }
            else if ((LA1_0 == 'o'))
            {
                alt1 = 2;
            }
            else
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("44:1: OR : ( '||' | 'or' );", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1)
            {
                case 1:
                    {
                        Match("||");


                    }
                    break;
                case 2:
                    {
                        Match("or");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mAND()
    {
        try
        {
            int _type = AND;
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ((LA2_0 == '&'))
            {
                alt2 = 1;
            }
            else if ((LA2_0 == 'a'))
            {
                alt2 = 2;
            }
            else
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("50:1: AND : ( '&&' | 'and' );", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2)
            {
                case 1:
                    {
                        Match("&&");


                    }
                    break;
                case 2:
                    {
                        Match("and");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mEQUALS()
    {
        try
        {
            int _type = EQUALS;
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ((LA3_0 == '='))
            {
                int LA3_1 = input.LA(2);

                if ((LA3_1 == '='))
                {
                    alt3 = 2;
                }
                else
                {
                    alt3 = 1;
                }
            }
            else
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("56:1: EQUALS : ( '=' | '==' );", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3)
            {
                case 1:
                    {
                        Match('=');

                    }
                    break;
                case 2:
                    {
                        Match("==");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mNOTEQUALS()
    {
        try
        {
            int _type = NOTEQUALS;
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ((LA4_0 == '!'))
            {
                alt4 = 1;
            }
            else if ((LA4_0 == '<'))
            {
                alt4 = 2;
            }
            else
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("58:1: NOTEQUALS : ( '!=' | '<>' );", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4)
            {
                case 1:
                    {
                        Match("!=");


                    }
                    break;
                case 2:
                    {
                        Match("<>");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mLT()
    {
        try
        {
            int _type = LT;
            {
                Match('<');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mLTEQ()
    {
        try
        {
            int _type = LTEQ;
            {
                Match("<=");


            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mGT()
    {
        try
        {
            int _type = GT;
            {
                Match('>');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mGTEQ()
    {
        try
        {
            int _type = GTEQ;
            {
                Match(">=");


            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mPLUS()
    {
        try
        {
            int _type = PLUS;
            {
                Match('+');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mMINUS()
    {
        try
        {
            int _type = MINUS;
            {
                Match('-');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mMULT()
    {
        try
        {
            int _type = MULT;
            {
                Match('*');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mDIV()
    {
        try
        {
            int _type = DIV;
            {
                Match('/');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mMOD()
    {
        try
        {
            int _type = MOD;
            {
                Match('%');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mPOW()
    {
        try
        {
            int _type = POW;
            {
                Match('^');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mNOT()
    {
        try
        {
            int _type = NOT;
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ((LA5_0 == '!'))
            {
                alt5 = 1;
            }
            else if ((LA5_0 == 'n'))
            {
                alt5 = 2;
            }
            else
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("97:1: NOT : ( '!' | 'not' );", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5)
            {
                case 1:
                    {
                        Match('!');

                    }
                    break;
                case 2:
                    {
                        Match("not");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mSTRING()
    {
        try
        {
            int _type = STRING;
            {
                Match('\'');
                do
                {
                    int alt6 = 3;
                    int LA6_0 = input.LA(1);

                    if ((LA6_0 == '\\'))
                    {
                        alt6 = 1;
                    }
                    else if (((LA6_0 >= ' ' && LA6_0 <= '&') || (LA6_0 >= '(' && LA6_0 <= '[') || (LA6_0 >= ']' && LA6_0 <= '\uFFFE')))
                    {
                        alt6 = 2;
                    }


                    switch (alt6)
                    {
                        case 1:
                            {
                                mEscapeSequence();

                            }
                            break;
                        case 2:
                            {
                                {
                                    if ((input.LA(1) >= ' ' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE'))
                                    {
                                        input.Consume();

                                    }
                                    else
                                    {
                                        MismatchedSetException mse =
                                            new MismatchedSetException(null, input);
                                        Recover(mse); throw mse;
                                    }


                                }


                            }
                            break;

                        default:
                            goto loop6;
                    }
                } while (true);

                loop6:
                ;
                Match('\'');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mINTEGER()
    {
        try
        {
            int _type = INTEGER;
            {
                int cnt7 = 0;
                do
                {
                    int alt7 = 2;
                    int LA7_0 = input.LA(1);

                    if (((LA7_0 >= '0' && LA7_0 <= '9')))
                    {
                        alt7 = 1;
                    }


                    switch (alt7)
                    {
                        case 1:
                            {
                                MatchRange('0', '9');

                            }
                            break;

                        default:
                            if (cnt7 >= 1)
                            {
                                goto loop7;
                            }

                            EarlyExitException eee =
                                new EarlyExitException(7, input);
                            throw eee;
                    }
                    cnt7++;
                } while (true);

                loop7:
                ;

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mFLOAT()
    {
        try
        {
            int _type = FLOAT;
            {
                do
                {
                    int alt8 = 2;
                    int LA8_0 = input.LA(1);

                    if (((LA8_0 >= '0' && LA8_0 <= '9')))
                    {
                        alt8 = 1;
                    }


                    switch (alt8)
                    {
                        case 1:
                            {
                                MatchRange('0', '9');

                            }
                            break;

                        default:
                            goto loop8;
                    }
                } while (true);

                loop8:
                ;
                Match('.');
                int cnt9 = 0;
                do
                {
                    int alt9 = 2;
                    int LA9_0 = input.LA(1);

                    if (((LA9_0 >= '0' && LA9_0 <= '9')))
                    {
                        alt9 = 1;
                    }


                    switch (alt9)
                    {
                        case 1:
                            {
                                MatchRange('0', '9');

                            }
                            break;

                        default:
                            if (cnt9 >= 1)
                            {
                                goto loop9;
                            }

                            EarlyExitException eee =
                                new EarlyExitException(9, input);
                            throw eee;
                    }
                    cnt9++;
                } while (true);

                loop9:
                ;

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mDATETIME()
    {
        try
        {
            int _type = DATETIME;
            {
                Match('#');
                do
                {
                    int alt10 = 2;
                    int LA10_0 = input.LA(1);

                    if (((LA10_0 >= '\u0000' && LA10_0 <= '\"') || (LA10_0 >= '$' && LA10_0 <= '\uFFFE')))
                    {
                        alt10 = 1;
                    }


                    switch (alt10)
                    {
                        case 1:
                            {
                                if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\"') || (input.LA(1) >= '$' && input.LA(1) <= '\uFFFE'))
                                {
                                    input.Consume();

                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    Recover(mse); throw mse;
                                }


                            }
                            break;

                        default:
                            goto loop10;
                    }
                } while (true);

                loop10:
                ;
                Match('#');

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mBOOLEAN()
    {
        try
        {
            int _type = BOOLEAN;
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ((LA11_0 == 't'))
            {
                alt11 = 1;
            }
            else if ((LA11_0 == 'f'))
            {
                alt11 = 2;
            }
            else
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("134:1: BOOLEAN : ( 'true' | 'false' );", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11)
            {
                case 1:
                    {
                        Match("true");


                    }
                    break;
                case 2:
                    {
                        Match("false");


                    }
                    break;

            }
            type = _type;
        }
        finally
        {
        }
    }

    public void mIDENT()
    {
        try
        {
            int _type = IDENT;
            {
                if ((input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z'))
                {
                    input.Consume();

                }
                else
                {
                    MismatchedSetException mse =
                        new MismatchedSetException(null, input);
                    Recover(mse); throw mse;
                }

                do
                {
                    int alt12 = 2;
                    int LA12_0 = input.LA(1);

                    if (((LA12_0 >= '0' && LA12_0 <= '9') || (LA12_0 >= 'A' && LA12_0 <= 'Z') || LA12_0 == '_' || (LA12_0 >= 'a' && LA12_0 <= 'z')))
                    {
                        alt12 = 1;
                    }


                    switch (alt12)
                    {
                        case 1:
                            {
                                if ((input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z'))
                                {
                                    input.Consume();

                                }
                                else
                                {
                                    MismatchedSetException mse =
                                        new MismatchedSetException(null, input);
                                    Recover(mse); throw mse;
                                }


                            }
                            break;

                        default:
                            goto loop12;
                    }
                } while (true);

                loop12:
                ;

            }

            type = _type;
        }
        finally
        {
        }
    }

    public void mEscapeSequence()
    {
        try
        {
            {
                Match('\\');
                int alt13 = 6;
                switch (input.LA(1))
                {
                    case 'n':
                        {
                            alt13 = 1;
                        }
                        break;
                    case 'r':
                        {
                            alt13 = 2;
                        }
                        break;
                    case 't':
                        {
                            alt13 = 3;
                        }
                        break;
                    case '\'':
                        {
                            alt13 = 4;
                        }
                        break;
                    case '\\':
                        {
                            alt13 = 5;
                        }
                        break;
                    case 'u':
                        {
                            alt13 = 6;
                        }
                        break;
                    default:
                        NoViableAltException nvae_d13s0 =
                            new NoViableAltException("150:4: ( 'n' | 'r' | 't' | '\\'' | '\\\\' | UnicodeEscape )", 13, 0, input);

                        throw nvae_d13s0;
                }

                switch (alt13)
                {
                    case 1:
                        {
                            Match('n');

                        }
                        break;
                    case 2:
                        {
                            Match('r');

                        }
                        break;
                    case 3:
                        {
                            Match('t');

                        }
                        break;
                    case 4:
                        {
                            Match('\'');

                        }
                        break;
                    case 5:
                        {
                            Match('\\');

                        }
                        break;
                    case 6:
                        {
                            mUnicodeEscape();

                        }
                        break;

                }


            }

        }
        finally
        {
        }
    }

    public void mUnicodeEscape()
    {
        try
        {
            {
                Match('u');
                mHexDigit();
                mHexDigit();
                mHexDigit();
                mHexDigit();

            }

        }
        finally
        {
        }
    }

    public void mHexDigit()
    {
        try
        {
            {
                if ((input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f'))
                {
                    input.Consume();

                }
                else
                {
                    MismatchedSetException mse =
                        new MismatchedSetException(null, input);
                    Recover(mse); throw mse;
                }


            }

        }
        finally
        {
        }
    }

    public void mWS()
    {
        try
        {
            int _type = WS;
            {
                if ((input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ')
                {
                    input.Consume();

                }
                else
                {
                    MismatchedSetException mse =
                        new MismatchedSetException(null, input);
                    Recover(mse); throw mse;
                }

                channel = HIDDEN;

            }

            type = _type;
        }
        finally
        {
        }
    }

    public override void mTokens()
    {
        int alt14 = 27;
        alt14 = dfa14.Predict(input);
        switch (alt14)
        {
            case 1:
                {
                    mT31();

                }
                break;
            case 2:
                {
                    mT32();

                }
                break;
            case 3:
                {
                    mT33();

                }
                break;
            case 4:
                {
                    mT34();

                }
                break;
            case 5:
                {
                    mT35();

                }
                break;
            case 6:
                {
                    mOR();

                }
                break;
            case 7:
                {
                    mAND();

                }
                break;
            case 8:
                {
                    mEQUALS();

                }
                break;
            case 9:
                {
                    mNOTEQUALS();

                }
                break;
            case 10:
                {
                    mLT();

                }
                break;
            case 11:
                {
                    mLTEQ();

                }
                break;
            case 12:
                {
                    mGT();

                }
                break;
            case 13:
                {
                    mGTEQ();

                }
                break;
            case 14:
                {
                    mPLUS();

                }
                break;
            case 15:
                {
                    mMINUS();

                }
                break;
            case 16:
                {
                    mMULT();

                }
                break;
            case 17:
                {
                    mDIV();

                }
                break;
            case 18:
                {
                    mMOD();

                }
                break;
            case 19:
                {
                    mPOW();

                }
                break;
            case 20:
                {
                    mNOT();

                }
                break;
            case 21:
                {
                    mSTRING();

                }
                break;
            case 22:
                {
                    mINTEGER();

                }
                break;
            case 23:
                {
                    mFLOAT();

                }
                break;
            case 24:
                {
                    mDATETIME();

                }
                break;
            case 25:
                {
                    mBOOLEAN();

                }
                break;
            case 26:
                {
                    mIDENT();

                }
                break;
            case 27:
                {
                    mWS();

                }
                break;

        }

    }


    protected DFA14 dfa14;
    private void InitializeCyclicDFAs()
    {
        dfa14 = new DFA14(this);
    }

    private static readonly short[] DFA14_eot = {
        -1, -1, -1, -1, -1, -1, -1, 27, -1, 27, -1, 32, 34, 36, -1, -1,
        -1, -1, -1, -1, 27, -1, 38, -1, -1, 27, 27, -1, -1, 6, 27, -1, -1,
        -1, -1, -1, -1, 27, -1, 27, 27, 8, 32, 27, 27, 47, 27, -1, 47
        };
    private static readonly short[] DFA14_eof = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1
        };
    private static readonly int[] DFA14_min = {
        9, 0, 0, 0, 0, 0, 0, 114, 0, 110, 0, 61, 61, 61, 0, 0, 0, 0, 0,
        0, 111, 0, 46, 0, 0, 114, 97, 0, 0, 48, 100, 0, 0, 0, 0, 0, 0, 116,
        0, 117, 108, 48, 48, 101, 115, 48, 101, 0, 48
        };
    private static readonly int[] DFA14_max = {
        124, 0, 0, 0, 0, 0, 0, 114, 0, 110, 0, 61, 62, 61, 0, 0, 0, 0, 0,
        0, 111, 0, 57, 0, 0, 114, 97, 0, 0, 122, 100, 0, 0, 0, 0, 0, 0,
        116, 0, 117, 108, 122, 122, 101, 115, 122, 101, 0, 122
        };
    private static readonly short[] DFA14_accept = {
        -1, 1, 2, 3, 4, 5, 6, -1, 7, -1, 8, -1, -1, -1, 14, 15, 16, 17,
        18, 19, -1, 21, -1, 23, 24, -1, -1, 26, 27, -1, -1, 9, 20, 11, 10,
        13, 12, -1, 22, -1, -1, -1, -1, -1, -1, -1, -1, 25, -1
        };
    private static readonly short[] DFA14_special = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1
        };
    private static readonly short[] dfa14_transition_null = null;
    private static readonly short[] dfa14_transition0 = {
        43
        };
    private static readonly short[] dfa14_transition1 = {
        45
        };
    private static readonly short[] dfa14_transition2 = {
        33, 31
        };
    private static readonly short[] dfa14_transition3 = {
        27, 27, 27, 27, 27, 27, 27, 27, 27, 27, -1, -1, -1, -1, -1, -1, -1,
            27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
            27, 27, 27, 27, 27, 27, 27, 27, 27, 27, -1, -1, -1, -1, 27, -1,
            27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
            27, 27, 27, 27, 27, 27, 27, 27, 27, 27
        };
    private static readonly short[] dfa14_transition4 = {
        46
        };
    private static readonly short[] dfa14_transition5 = {
        44
        };
    private static readonly short[] dfa14_transition6 = {
        48
        };
    private static readonly short[] dfa14_transition7 = {
        28, 28, -1, 28, 28, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, 28, 11, -1, 24, -1, 18, 8, 21, 1, 2, 16,
            14, 5, 15, 23, 17, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, -1,
            -1, 12, 10, 13, -1, -1, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
            27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
            3, -1, 4, 19, 27, -1, 9, 27, 27, 27, 27, 26, 27, 27, 27, 27, 27,
            27, 27, 20, 7, 27, 27, 27, 27, 25, 27, 27, 27, 27, 27, 27, -1,
            6
        };
    private static readonly short[] dfa14_transition8 = {
        31
        };
    private static readonly short[] dfa14_transition9 = {
        42
        };
    private static readonly short[] dfa14_transition10 = {
        39
        };
    private static readonly short[] dfa14_transition11 = {
        40
        };
    private static readonly short[] dfa14_transition12 = {
        37
        };
    private static readonly short[] dfa14_transition13 = {
        35
        };
    private static readonly short[] dfa14_transition14 = {
        41
        };
    private static readonly short[] dfa14_transition15 = {
        23, -1, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22
        };
    private static readonly short[] dfa14_transition16 = {
        29
        };
    private static readonly short[] dfa14_transition17 = {
        30
        };
    private static readonly short[][] DFA14_transition = {
        dfa14_transition7,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition16,
        dfa14_transition_null,
        dfa14_transition17,
        dfa14_transition_null,
        dfa14_transition8,
        dfa14_transition2,
        dfa14_transition13,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition12,
        dfa14_transition_null,
        dfa14_transition15,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition10,
        dfa14_transition11,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition3,
        dfa14_transition14,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition_null,
        dfa14_transition9,
        dfa14_transition_null,
        dfa14_transition0,
        dfa14_transition5,
        dfa14_transition3,
        dfa14_transition3,
        dfa14_transition1,
        dfa14_transition4,
        dfa14_transition3,
        dfa14_transition6,
        dfa14_transition_null,
        dfa14_transition3
        };

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            decisionNumber = 14;
            eot = DFA14_eot;
            eof = DFA14_eof;
            min = DFA14_min;
            max = DFA14_max;
            accept = DFA14_accept;
            special = DFA14_special;
            transition = DFA14_transition;
        }

        public override string Description => "1:1: Tokens : ( T31 | T32 | T33 | T34 | T35 | OR | AND | EQUALS | NOTEQUALS | LT | LTEQ | GT | GTEQ | PLUS | MINUS | MULT | DIV | MOD | POW | NOT | STRING | INTEGER | FLOAT | DATETIME | BOOLEAN | IDENT | WS );";

    }



}
