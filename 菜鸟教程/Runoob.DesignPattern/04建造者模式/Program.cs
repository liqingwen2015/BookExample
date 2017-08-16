#region

using System;

#endregion

namespace _04建造者模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new MealBuilder();
            var vegMeal = builder.PrepareVegMeal();

            Console.WriteLine($"vegMeal: {vegMeal.Cost}");
            vegMeal.ShowItems();

            var nonVegMeal = builder.PrepareNonVegMeal();

            Console.WriteLine($"nonVegMeal: {nonVegMeal.Cost}");
            vegMeal.ShowItems();

            Console.Read();
        }
    }
}