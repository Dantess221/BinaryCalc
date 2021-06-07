using System;

namespace BinaryTree.Calc
{
    public class FunctionArgs : EventArgs
    {
        public FunctionArgs()
        {
        }

        private object result;

        public object Result
        {
            get => result;
            set => result = value;
        }

        private object[] parameters = new object[0];

        public object[] Parameters
        {
            get => parameters;
            set => parameters = value;
        }

    }
}
