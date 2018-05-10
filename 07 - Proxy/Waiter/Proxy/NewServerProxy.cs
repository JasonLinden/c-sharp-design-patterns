﻿using _07___Proxy.Waiter.RealSubject;
using _07___Proxy.Waiter.Subject;
using System;

namespace _07___Proxy.Waiter.Proxy
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    class NewServerProxy : IServer
    {
        private string OrderStr;
        private Server _server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            OrderStr = order;
        }

        public string DeliverOrder()
        {
            return OrderStr;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
