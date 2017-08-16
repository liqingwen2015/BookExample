namespace _23策略模式.Strategy
{
    internal class OperationAdd : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}