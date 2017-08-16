#region

using System;

#endregion

namespace _20观察者模式.Observer
{
    internal class HexaObserver : BaseObserver
    {
        //public HexaObserver(Subject subject) : base(subject)
        //{
        //    Subject = subject;
        //}

        public override void Update(int state)
        {
            Console.WriteLine($"{nameof(HexaObserver)}: {state}");
        }
    }
}