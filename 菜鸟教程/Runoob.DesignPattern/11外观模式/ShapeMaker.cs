#region

using _11外观模式.Shape;

#endregion

namespace _11外观模式
{
    internal class ShapeMaker
    {
        private readonly IShape _circle;

        private readonly IShape _rectangle;

        private readonly IShape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }
    }
}