namespace _02抽象工厂模式
{
    internal class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factoryName)
        {
            switch (factoryName)
            {
                case "SHAPE":
                    return new ShapeFactory();
                case "COLOR":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}