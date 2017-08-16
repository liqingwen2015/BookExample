#region

using System;

#endregion

namespace _05原型模式.Shape
{
    internal abstract class BaseShape : ICloneable
    {
        public abstract string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Draw()
        {
            Console.WriteLine(Name);
        }
    }
}