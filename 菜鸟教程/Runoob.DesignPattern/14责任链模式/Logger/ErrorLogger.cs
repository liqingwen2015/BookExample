#region

using System;

#endregion

namespace _14责任链模式.Logger
{
    internal class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"{nameof(ErrorLogger)}: {message}");
        }
    }
}