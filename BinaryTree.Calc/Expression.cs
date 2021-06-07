using Antlr.Runtime;
using Antlr.Runtime.Tree;
using BinaryTree.Calc.Domain;
using System;
using System.Collections;

namespace BinaryTree.Calc
{
    public class Expression
    {
        protected string expression;

        public Expression(string expression)
        {
            if (expression == null || expression == string.Empty)
            {
                throw new
                    ArgumentException("Expression can't be empty", "expression");
            }

            this.expression = expression;
        }

        protected CommonTree Parse(string expression)
        {
            ECalcLexer lexer = new ECalcLexer(new ANTLRStringStream(expression));
            ECalcParser parser = new ECalcParser(new CommonTokenStream(lexer));

            try
            {
                RuleReturnScope rule = parser.expression();
                if (parser.HasError)
                {
                    throw new EvalException(parser.ErrorMessage + " " + parser.ErrorPosition);
                }

                return rule.Tree as CommonTree;
            }
            catch (EvalException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new EvalException(e.Message, e);
            }
        }

        public object Evaluate()
        {
            EvalVisitor visitor = new EvalVisitor();
            visitor.EvaluateFunction += EvaluateFunction;
            visitor.EvaluateParameter += EvaluateParameter;
            visitor.Parameters = parameters;

            LogicalExpression.Create(Parse(expression)).Accept(visitor);
            return visitor.Result;
        }

        public event EvaluateFunctionHandler EvaluateFunction;
        public event EvaluateParameterHandler EvaluateParameter;

        private Hashtable parameters = new Hashtable();

        public Hashtable Parameters
        {
            get => parameters;
            set => parameters = value;
        }

    }
}
