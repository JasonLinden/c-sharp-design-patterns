using _07___Proxy.Order.RealSubject;
using _07___Proxy.Order.Subject;
using System.Collections.Generic;

namespace _07___Proxy.Order.Proxy
{
    public class ProxyOrderRepository : OrderRepositoryBase
    {
        private RealOrderRepository _repository;

        public ProxyOrderRepository()
        {
            _repository = new RealOrderRepository();
        }

        public override OrderObject GetOrder(int id)
        {
            var order = _repository.GetOrder(id);
            order.Customer = GetOrderCustomer(order.Id);
            order.Details = GetOrderDetails(order.Id);
            return order;
        }

        public override IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            return _repository.GetOrderDetails(orderId);
        }

        public override Customer GetOrderCustomer(int orderId)
        {
            return _repository.GetOrderCustomer(orderId);
        }
    }
}
