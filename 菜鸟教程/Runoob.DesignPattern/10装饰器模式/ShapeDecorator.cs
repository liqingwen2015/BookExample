#region

using _10装饰器模式.Shape;

#endregion

namespace _10装饰器模式
{
    internal abstract class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape;

        protected ShapeDecorator(IShape decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            DecoratedShape.Draw();
        }
    }
}