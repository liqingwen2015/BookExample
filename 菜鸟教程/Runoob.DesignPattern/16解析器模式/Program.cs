#region

using System;
using _16解析器模式.Expression;

#endregion

namespace _16解析器模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var isMale = GetMaleExpression();
            var isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie"));

            Console.Read();
        }

        private static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");

            return new OrExpression(robert, john);
        }

        private static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");

            return new AndExpression(julie, married);
        }
    }
}