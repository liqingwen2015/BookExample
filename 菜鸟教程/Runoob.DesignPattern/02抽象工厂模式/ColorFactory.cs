#region

using _02抽象工厂模式.Color;

#endregion

namespace _02抽象工厂模式
{
    internal class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return null;
        }

        public override IColor GetColor(string colorName)
        {
            switch (colorName)
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
                default:
                    return null;
            }
        }
    }
}