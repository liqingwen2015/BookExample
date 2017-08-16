namespace _04建造者模式.Packing
{
    internal class Bottle : IPacking
    {
        public string Pack()
        {
            return $"{nameof(Bottle)}";
        }
    }
}