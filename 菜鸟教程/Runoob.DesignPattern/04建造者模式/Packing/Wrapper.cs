namespace _04建造者模式.Packing
{
    internal class Wrapper : IPacking
    {
        public string Pack()
        {
            return $"{nameof(Wrapper)}";
        }
    }
}