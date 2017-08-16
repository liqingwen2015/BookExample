#region

using _07桥接模式.DrawApi;

#endregion

namespace _07桥接模式.Shape
{
    internal abstract class BaseShape
    {
        protected IDrawApi DrawApi;

        protected BaseShape(IDrawApi drawApi)
        {
            DrawApi = drawApi;
        }

        public abstract void Draw();
    }
}