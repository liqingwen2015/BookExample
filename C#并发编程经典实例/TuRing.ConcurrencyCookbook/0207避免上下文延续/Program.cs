﻿using System;
using System.Threading.Tasks;

namespace _0207避免上下文延续
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private async Task ResumeOnContextAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            //这个方法在同一个上下文中恢复运行。
        }

        private async Task ResumeWithoutContextAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

            //这个方法在恢复运行时，会丢弃上下文
        }
    }
}