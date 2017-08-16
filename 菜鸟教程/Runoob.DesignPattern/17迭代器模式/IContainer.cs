using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17迭代器模式
{
    interface IContainer
    {
        IIterator GetIterator();
    }
}
