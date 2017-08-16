namespace _22空对象模式.Customer
{
    internal class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            Name = name;
        }

        public override bool IsNull()
        {
            return false;
        }

        public override string GetName()
        {
            return Name;
        }
    }
}