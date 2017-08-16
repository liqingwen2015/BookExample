namespace _04建造者模式.ColdDrink
{
    internal class Pepsi : BaseColdDrink
    {
        public override string Name { get; } = $"{nameof(Pepsi)}";


        public override float Price { get; } = 35.0f;
    }
}