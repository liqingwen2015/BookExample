#region

using System.Collections.Generic;
using _20观察者模式.Observer;

#endregion

namespace _20观察者模式
{
    internal class Subject
    {
        private readonly IList<BaseObserver> _observers = new List<BaseObserver>();
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
            NotifyAllObservers();
        }

        public void Attach(BaseObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
                observer.Update(_state);
        }
    }
}