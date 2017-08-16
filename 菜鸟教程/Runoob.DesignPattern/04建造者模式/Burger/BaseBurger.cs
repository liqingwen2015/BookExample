#region

using _04建造者模式.Packing;

#endregion

namespace _04建造者模式.Burger
{
    internal abstract class BaseBurger : IItem
    {
        public abstract string Name { get; }

        public abstract float Price { get; }

        public IPacking Packing()
        {
            return new Wrapper();
        }
    }
}