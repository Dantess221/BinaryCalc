namespace BinaryTree.Calc.Domain
{
    public class Value : LogicalExpression
    {
        public Value(string text, ValueType type)
        {
            this.text = text;
            this.type = type;
        }

        private string text;

        public string Text
        {
            get => text;
            set => text = value;
        }

        private ValueType type;

        public ValueType Type
        {
            get => type;
            set => type = value;
        }

        public override void Accept(LogicalExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public enum ValueType
    {
        Integer,
        String,
        DateTime,
        Float,
        Boolean
    }
}
