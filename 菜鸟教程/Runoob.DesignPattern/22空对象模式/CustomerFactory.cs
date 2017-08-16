#region

using System.Linq;
using _22空对象模式.Customer;

#endregion

namespace _22空对象模式
{
    internal class CustomerFactory
    {
        private static readonly string[] Names = {"Rob", "Joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            var customerName = Names.FirstOrDefault(x => x == name);

            return customerName == null ? (AbstractCustomer) new NullCustomer() : new RealCustomer(name);
        }
    }
}