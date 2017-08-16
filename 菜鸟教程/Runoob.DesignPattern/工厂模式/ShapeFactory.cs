namespace 工厂模式
{
    /// <summary>
    /// 形状工厂
    /// </summary>
    internal class ShapeFactory
    {
        /// <summary>
        /// 根据类型获取形状
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public static IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
                return null;

            if (shapeType == "circle")
                return new Circle();
            if (shapeType == "square")
                return new Square();
            if (shapeType == "rectangle")
                return new Rectangle();

            return null;
        }
    }
}