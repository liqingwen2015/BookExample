using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02Adapter.委托;

namespace _02Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new PrintBanner("Hello");

            print.PrintWeak();
            print.PrintStrong();

            Console.Read();
        }
    }
}
