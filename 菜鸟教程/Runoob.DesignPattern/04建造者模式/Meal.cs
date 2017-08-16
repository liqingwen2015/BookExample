#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace _04建造者模式
{
    internal class Meal
    {
        private readonly IList<IItem> _items = new List<IItem>();

        public string Name { get; set; }

        public float Cost
        {
            get { return _items.Select(x => x.Price).Sum(); }
        }

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine($"名称:{item.Name}");
                Console.WriteLine($"打包:{item.Packing().Pack()}");
                Console.WriteLine($"价格:{item.Price}");
                Console.WriteLine();
            }
        }
    }
}