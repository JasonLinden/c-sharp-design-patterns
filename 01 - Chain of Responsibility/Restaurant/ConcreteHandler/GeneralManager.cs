using _01___Chain_of_Responsibility.Restaurant.Handler;
using System;

namespace _01___Chain_of_Responsibility.Restaurant.ConcreteHandler
{
    class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else
            {
                Console.WriteLine(
                    "Purchase request #{0} requires an executive meeting!",
                    purchase.RequestNumber);
            }
        }
    }
}
