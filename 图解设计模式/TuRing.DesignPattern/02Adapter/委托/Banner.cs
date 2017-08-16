using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Adapter.委托
{
    class Banner
    {
        private readonly string _msg;

        public Banner(string msg)
        {
            _msg = msg;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({_msg})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{_msg}*");
        }
    }
}
