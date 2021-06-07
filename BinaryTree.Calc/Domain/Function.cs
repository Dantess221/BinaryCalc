namespace BinaryTree.Calc.Domain
{
    public class Function : LogicalExpression
    {
        public Function(string identifier, LogicalExpression[] expressions)
        {
            this.identifier = identifier;
            this.expressions = expressions;
        }

        private string identifier;

        public string Identifier
        {
            get => identifier;
            set => identifier = value;
        }

        private LogicalExpression[] expressions;

        public LogicalExpression[] Expressions
        {
            get => expressions;
            set => expressions = value;
        }

        public override void Accept(LogicalExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
