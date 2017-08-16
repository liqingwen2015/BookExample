using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19备忘录模式
{
    class CareTaker
    {
        private readonly IList<Memento> _mementoes = new List<Memento>();

        public void Add(Memento state)
        {
            _mementoes.Add(state);
        }

        public Memento Get(int index)
        {
            return _mementoes[index];
        }
    }
}
