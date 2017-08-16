#region

using _04建造者模式.Packing;

#endregion

namespace _04建造者模式.ColdDrink
{
    internal abstract class BaseColdDrink : IItem
    {
        public abstract string Name { get; }

        public abstract float Price { get; }

        public IPacking Packing()
        {
            return new Bottle();
        }
    }
}