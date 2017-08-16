#region

using System;

#endregion

namespace _20观察者模式.Observer
{
    internal class OctalObserver : BaseObserver
    {
        //public OctalObserver(Subject subject) : base(subject)
        //{
        //    Subject.Attach(this);
        //}

        public override void Update(int state)
        {
            Console.WriteLine($"{nameof(OctalObserver)}: {state}");
        }
    }
}