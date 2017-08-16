#region

using System;
using _14责任链模式.Logger;

#endregion

namespace _14责任链模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logger = GetLogger();

            logger.LogMessage(AbstractLogger.Info, "This is an information.");
            logger.LogMessage(AbstractLogger.Debug, "This is an debug level information.");
            logger.LogMessage(AbstractLogger.Error, "This is an error information.");

            Console.Read();
        }

        private static AbstractLogger GetLogger()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.Error);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.Debug);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.Info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}