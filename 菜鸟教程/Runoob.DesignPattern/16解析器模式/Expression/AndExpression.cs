namespace _16解析器模式.Expression
{
    internal class AndExpression : IExpression
    {
        private readonly IExpression _expression1;
        private readonly IExpression _expression2;

        public AndExpression(IExpression expression1, IExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }


        public bool Interpret(string value)
        {
            return _expression1.Interpret(value) &&
                   _expression2.Interpret(value);
        }
    }
}