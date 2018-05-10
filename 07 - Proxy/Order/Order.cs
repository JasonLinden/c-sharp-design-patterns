using System;
using System.Collections.Generic;

namespace _07___Proxy.Order
{
    public class OrderObject
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
    }
}
