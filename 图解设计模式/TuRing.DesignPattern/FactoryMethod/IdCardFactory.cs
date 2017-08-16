using System.Collections.Generic;

namespace FactoryMethod
{
    class IdCardFactory : Factory
    {
        private IList<string> _owners = new List<string>();

        protected override Product CreateProduct(string owner)
        {
            return new IdCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add(((IdCard)product).GetOwner());
        }

        public IList<string> GetOwners()
        {
            return _owners;
        }
    }
}
