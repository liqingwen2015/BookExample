using System;

namespace FactoryMethod
{
    class IdCard : Product
    {
        private string _owner;

        public IdCard(string owner)
        {
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"这是 {_owner} 的卡");
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}
