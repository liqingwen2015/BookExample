//默认情况，一个 async 方法在被 await 调用后恢复运行时，会在原来的上下文运行。如果是 UI 上下文，并且有大量的 async 方法在 UI 上下文中恢复，就会引起性能上的问题。
//对于每一个 async 方法，如果他没有必要恢复到原来的上下文，就应该使用 ConfiguraAwait。
//通常一个 async 方法要么需要上下文（处理 UI 元素或 ASP.NET 请求/响应），要么需要摆脱上下文（执行后台指令）。

using System;
using System.Threading.Tasks;

namespace _0207避免上下文延续
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        async Task ResumeOnContextAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //这个方法在同一个上下文中恢复运行。
        }

        async Task ResumeWithoutContextAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

            //这个方法在恢复运行时，会丢弃上下文
        }
    }
}
