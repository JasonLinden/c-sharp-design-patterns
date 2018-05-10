using System.Collections.Generic;

namespace _07___Proxy.Order.Subject
{
    public abstract class OrderRepositoryBase
    {
        public abstract OrderObject GetOrder(int id);

        public abstract IEnumerable<OrderDetail> GetOrderDetails(int orderId);

        public abstract Customer GetOrderCustomer(int orderId);
    }
}
