using _01___Bridge.Restaurant.Implementor;
using System;

namespace _01___Bridge.Restaurant.ConcreteImplementor
{
    class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Diner.");
        }
    }
}