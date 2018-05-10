using _01___Bridge.Restaurant.Implementor;

namespace _01___Bridge.Restaurant.Abstraction
{
    public abstract class SendOrder
    {
        //Reference to the Implementor
        internal IOrderingSystem _restaurant;

        public abstract void Send();
    }
}
