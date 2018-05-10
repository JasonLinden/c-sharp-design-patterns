using _07___Proxy.ATM.Proxy;
using _07___Proxy.Order;
using _07___Proxy.Order.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyOrderRepository repository = new ProxyOrderRepository();

            OrderObject order = repository.GetOrder(1);

            Console.WriteLine("Order Id: {0}", order.Id);
            Console.WriteLine("Date: {0}", order.OrderDate);
            Console.WriteLine("Customer: {0}, {1}", order.Customer.LastName, order.Customer.FirstName);
            Console.WriteLine("# of items: {0}", order.Details.Count());

            AccountChargeTests();
            OverchargeTests();
        }

        #region ATM
        internal static void AccountChargeTests()
        {
            // Create new debit card proxy instance.
            var debitCard = new DebitCard();
            // Attempt two successful charges.
            debitCard.ChargeAccount(125.50M);
            debitCard.ChargeAccount(500);
            // Attempt overcharge.
            debitCard.ChargeAccount(432.10M);
        }

        internal static void OverchargeTests()
        {
            // Create new credit card proxy instance and allow overcharges.
            var creditCard = new CreditCard();
            // Attempt two successful charges.
            creditCard.ChargeAccount(125.50M);
            creditCard.ChargeAccount(500);
            // Attempt overcharge.
            creditCard.ChargeAccount(432.10M);
        } 
        #endregion
    }
}
