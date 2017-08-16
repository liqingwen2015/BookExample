#region

using System;

#endregion

namespace _09组合模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ceo = new Employee("John", "CEO", 30000);
            var headSales = new Employee("Robert", "Head Sales", 20000);
            var headMarketing = new Employee("Michel", "Head Marketing", 20000);
            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);
            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            foreach (var ceoSubordinate in ceo.Subordinates)
            {
                Console.WriteLine(ceoSubordinate);
                foreach (var ceoSubordinateSubordinate in ceoSubordinate.Subordinates)
                    Console.WriteLine(ceoSubordinateSubordinate);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}