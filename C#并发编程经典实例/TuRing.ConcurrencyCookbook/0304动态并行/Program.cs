using System.Threading;
using System.Threading.Tasks;

namespace _0304动态并行
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private void Traverse(Node current)
        {
            if (current.Left != null)
            {
                Task.Factory.StartNew(() => Traverse(current.Left),
                    CancellationToken.None,
                    TaskCreationOptions.AttachedToParent,
                    TaskScheduler.Default);
            }

            if (current.Right != null)
            {
                Task.Factory.StartNew(() => Traverse(current.Right),
                    CancellationToken.None,
                    TaskCreationOptions.AttachedToParent,
                    TaskScheduler.Default);
            }
        }

        private void ProcessTree(Node root)
        {
            var task = Task.Factory.StartNew(() => Traverse(root),
                CancellationToken.None,
                TaskCreationOptions.AttachedToParent,
                TaskScheduler.Default);

            task.Wait();
        }
    }

    internal class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}