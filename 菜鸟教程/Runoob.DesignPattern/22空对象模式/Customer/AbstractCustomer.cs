namespace _22空对象模式.Customer
{
    internal abstract class AbstractCustomer
    {
        protected string Name;

        public abstract bool IsNull();

        public abstract string GetName();
    }
}