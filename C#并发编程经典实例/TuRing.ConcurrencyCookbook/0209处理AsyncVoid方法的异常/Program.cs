using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _0209处理AsyncVoid方法的异常
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    internal sealed class MyAsyncCommand : ICommand
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