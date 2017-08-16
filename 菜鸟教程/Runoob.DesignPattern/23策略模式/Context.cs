#region

using _23策略模式.Strategy;

#endregion

namespace _23策略模式
{
    internal class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int m, int n)
        {
            return _strategy.DoOperation(m, n);
        }
    }
}