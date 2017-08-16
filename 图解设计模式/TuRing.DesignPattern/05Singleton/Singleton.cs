using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Singleton
{
    class Singleton
    {
        private static readonly Singleton SingletonObjct = new Singleton();

        private Singleton()
        {
            Console.WriteLine("生成一个实例");
        }

        public static Singleton GetSingleton()
        {
            return SingletonObjct;
        }
    }
}
