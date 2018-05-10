namespace _07___Proxy.Waiter.Subject
{
    /// <summary>
    /// The Subject interface which both the RealSubject and Proxy will need to implement
    /// </summary>
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}
