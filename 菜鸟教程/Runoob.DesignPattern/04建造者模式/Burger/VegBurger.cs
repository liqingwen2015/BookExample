namespace _04建造者模式.Burger
{
    internal class VegBurger : BaseBurger
    {
        public override string Name { get; } = $"{nameof(VegBurger)}";


        public override float Price { get; } = 50.5f;
    }
}