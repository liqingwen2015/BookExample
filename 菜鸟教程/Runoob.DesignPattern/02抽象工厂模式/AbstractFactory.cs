namespace _02抽象工厂模式
{
    internal abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);

        public abstract IColor GetColor(string colorName);
    }
}