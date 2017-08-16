#region

using System;

#endregion

namespace _21状态模式.State
{
    internal class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.State = this;
        }

        public override string ToString()
        {
            return nameof(StartState);
        }
    }
}