#region

using System;

#endregion

namespace _14责任链模式.Logger
{
    internal class FileLogger : AbstractLogger
    {
        public FileLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"{nameof(FileLogger)}: {message}");
        }
    }
}