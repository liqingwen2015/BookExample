using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer nameRepository = new NameRepository();

            var iterator = nameRepository.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine((string)iterator.Next());
            }


            Console.Read();
        }
    }
}
