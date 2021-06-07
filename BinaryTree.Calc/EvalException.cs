using System;

namespace BinaryTree.Calc
{
    public class EvalException : ApplicationException
    {
        public EvalException(string message)
            : base(message)
        {
        }

        public EvalException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
