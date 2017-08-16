using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17迭代器模式
{
    class NameIterator:IIterator
    {
        private readonly string[] _names;
        private int _index;

        public NameIterator(string[] names)
        {
            _names = names;
            _index = -1;
        }

        public bool HasNext()
        {
            return _index + 1 < _names.Length;
        }

        public object Next()
        {
            return HasNext() ? _names[++_index] : null;
        }
    }
}
