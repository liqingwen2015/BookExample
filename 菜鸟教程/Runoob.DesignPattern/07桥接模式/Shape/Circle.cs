#region

using _07桥接模式.DrawApi;

#endregion

namespace _07桥接模式.Shape
{
    internal class Circle : BaseShape
    {
        private readonly int _x, _y, _radius;

        public Circle(int radius, int x, int y, IDrawApi drawApi) : base(drawApi)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            DrawApi.DrawCircle(_radius, _x, _y);
        }
    }
}