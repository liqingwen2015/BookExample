#region

using _21状态模式.State;

#endregion

namespace _21状态模式
{
    internal class Context
    {
        public IState State { get; set; }
    }
}