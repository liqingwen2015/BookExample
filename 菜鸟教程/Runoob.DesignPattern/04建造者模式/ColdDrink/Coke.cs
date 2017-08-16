namespace _04建造者模式.ColdDrink
{
    internal class Coke : BaseColdDrink
    {
        public override string Name { get; } = $"{nameof(Coke)}";

        public override float Price { get; } = 30.0f;
    }
}