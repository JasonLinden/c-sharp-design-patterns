﻿using _01___Chain_of_Responsibility.Restaurant.Handler;
using System;

namespace _01___Chain_of_Responsibility.Restaurant.ConcreteHandler
{
    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(purchase);
            }
        }
    }
}