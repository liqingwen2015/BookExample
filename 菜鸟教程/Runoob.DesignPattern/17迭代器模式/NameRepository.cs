using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17迭代器模式
{
    class NameRepository : IContainer
    {
        private readonly string[] _names= { "Robert", "John", "Julie", "Lora" };


        public IIterator GetIterator()
        {
            return new NameIterator(_names);
        }
    }
}
