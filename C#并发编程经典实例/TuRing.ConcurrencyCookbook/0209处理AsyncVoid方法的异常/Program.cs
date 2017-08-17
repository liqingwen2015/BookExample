//返回值不要用 void，改为 Task
//如果必须使用 async void 方法，可以考虑把所有代码放在 try 中，直接处理异常，另一种方法就是使用 SynchronizationContext（麻烦）。

using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _0209处理AsyncVoid方法的异常
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }

    sealed class MyAsyncCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        async void ICommand.Execute(object parameter)
        {
            await Execute(null);
        }

        public event EventHandler CanExecuteChanged;

        public async Task Execute(object parameter)
        {
            //这里实现异步操作
            await Task.Delay(0);
        }
    }
}
