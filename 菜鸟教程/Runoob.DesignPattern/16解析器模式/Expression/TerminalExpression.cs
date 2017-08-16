namespace _16解析器模式.Expression
{
    internal class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public bool Interpret(string value)
        {
            return value.Contains(_data);
        }
    }
}