namespace BinaryTree.Calc.Domain
{
    public class Parameter : LogicalExpression
    {
        public Parameter(string name)
        {
            this.name = name;
        }

        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }


        public override void Accept(LogicalExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
