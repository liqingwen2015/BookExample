#region

using System;
using _10装饰器模式.Shape;

#endregion

namespace _10装饰器模式
{
    internal class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            DecoratedShape.Draw();
            SetRedBorder(DecoratedShape);
        }

        private static void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("[RedBorder]");
        }
    }
}