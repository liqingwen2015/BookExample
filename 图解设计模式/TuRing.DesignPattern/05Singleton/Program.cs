using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetSingleton();
            var singleton2 = Singleton.GetSingleton();

            if (singleton2 == singleton1)
            {
                Console.WriteLine(true);
            }

            Console.Read();
        }
    }
}
