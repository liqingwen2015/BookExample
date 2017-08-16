using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19备忘录模式
{
    class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento() { State = _state };
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.State;
        }
    }
}
