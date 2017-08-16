#region

using System.Collections.Generic;
using _05原型模式.Shape;

#endregion

namespace _05原型模式
{
    internal class ShapeCache
    {
        private readonly Dictionary<int, BaseShape> _shapeDictionary = new Dictionary<int, BaseShape>();

        public ShapeCache()
        {
            Load();
        }

        public BaseShape GetShape(int shapeId)
        {
            return (BaseShape) _shapeDictionary[shapeId].Clone();
        }

        public void Load()
        {
            _shapeDictionary.Add(1, new Circle());
            _shapeDictionary.Add(2, new Circle());
        }
    }
}