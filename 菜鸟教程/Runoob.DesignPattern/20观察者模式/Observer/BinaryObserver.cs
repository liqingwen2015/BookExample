#region

using System;

#endregion

namespace _20观察者模式.Observer
{
    internal class BinaryObserver : BaseObserver
    {
        //public BinaryObserver(Subject subject) : base(subject)
        //{
        //}

        public override void Update(int state)
        {
            Console.WriteLine($"{nameof(BinaryObserver)}: {state}");
        }
    }
}