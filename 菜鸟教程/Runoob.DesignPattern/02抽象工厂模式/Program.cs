#region

using System;

#endregion

namespace _02抽象工厂模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");

            var circle = shapeFactory.GetShape("CIRCLE");
            circle.Draw();

            var colorFactory = FactoryProducer.GetFactory("COLOR");

            var red = colorFactory.GetColor("RED");
            red.Fill();

            Console.Read();
        }
    }
}