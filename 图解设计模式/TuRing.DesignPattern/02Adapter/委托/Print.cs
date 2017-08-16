using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Adapter.委托
{
    abstract class Print
    {
        public abstract void PrintWeak();

        public abstract void PrintStrong();
    }
}
