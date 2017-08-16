#region

using _04建造者模式.Packing;

#endregion

namespace _04建造者模式
{
    internal interface IItem
    {
        string Name { get; }

        float Price { get; }

        IPacking Packing();
    }
}