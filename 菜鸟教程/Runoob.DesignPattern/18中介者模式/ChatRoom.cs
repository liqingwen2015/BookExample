#region

using System;

#endregion

namespace _18中介者模式
{
    internal class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine($"[{DateTime.Now}] [{user.Name}]: {message}");
        }
    }
}