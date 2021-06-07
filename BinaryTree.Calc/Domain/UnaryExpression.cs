namespace BinaryTree.Calc.Domain
{
    public class UnaryExpression : LogicalExpression
    {
        public UnaryExpression(UnaryExpressionType type, LogicalExpression expression)
        {
            this.type = type;
            this.expression = expression;
        }

        private LogicalExpression expression;
        public LogicalExpression Expression
        {
            get => expression;
            set => expression = value;
        }

        private UnaryExpressionType type;
        public UnaryExpressionType Type
        {
            get => type;
            set => type = value;
        }

        public override void Accept(LogicalExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public enum UnaryExpressionType
    {
        Not,
        Negate
    }
}
