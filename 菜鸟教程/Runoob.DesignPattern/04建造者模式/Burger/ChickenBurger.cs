namespace _04建造者模式.Burger
{
    internal class ChickenBurger : BaseBurger
    {
        public override string Name { get; } = $"{nameof(ChickenBurger)}";


        public override float Price { get; } = 25.0f;
    }
}