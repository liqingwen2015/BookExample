namespace _22空对象模式.Customer
{
    internal class NullCustomer : AbstractCustomer
    {
        public override bool IsNull()
        {
            return true;
        }

        public override string GetName()
        {
            return "Not Available in Customer Database.";
        }
    }
}