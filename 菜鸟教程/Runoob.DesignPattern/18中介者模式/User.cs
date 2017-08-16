namespace _18中介者模式
{
    internal class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}