using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay charDisplay = new CharDisplay('H');
            charDisplay.Display();

            AbstractDisplay stringDisplay=new StringDisplay("Hello World");
            stringDisplay.Display();

            Console.Read();
        }
    }
}
