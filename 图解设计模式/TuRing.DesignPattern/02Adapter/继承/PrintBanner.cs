using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Adapter.继承
{
    class PrintBanner:Banner,IPrint
    {
        public PrintBanner(string msg) : base(msg)
        {
            
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}
