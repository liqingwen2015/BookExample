using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            var careTaker = new CareTaker();

            originator.SetState("State #1");
            originator.SetState("State #2");
            careTaker.Add(originator.SaveStateToMemento());
            originator.SetState("State #3");
            careTaker.Add(originator.SaveStateToMemento());
            originator.SetState("State #4");

            Console.WriteLine("Current State: " + originator.GetState());
            originator.GetStateFromMemento(careTaker.Get(0));

            Console.WriteLine("First saved State: " + originator.GetState());
            originator.GetStateFromMemento(careTaker.Get(1));

            Console.WriteLine("Second saved State: " + originator.GetState());

            Console.Read();
        }
    }
}
