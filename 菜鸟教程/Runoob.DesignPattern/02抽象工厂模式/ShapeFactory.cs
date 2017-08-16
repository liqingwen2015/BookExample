#region

using _02抽象工厂模式.Shape;

#endregion

namespace _02抽象工厂模式
{
    internal class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "CIRCLE":
                    return new Circle();
                case "SQUARE":
                    return new Square();
                case "RECTANGLE":
                    return new Rectangle();
                default:
                    return null;
            }
        }

        public override IColor GetColor(string colorName)
        {
            return null;
        }
    }
}