using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IdCardFactory();

            var card1 = factory.Create("小明");
            var card2 = factory.Create("小红");
            var card3 = factory.Create("小刚");

            card1.Use();
            card2.Use();
            card3.Use();

            Console.ReadLine();
        }
    }
}
