using _01___Bridge.Restaurant.Abstraction;

namespace _01___Bridge.Restaurant.RefinedAbstraction
{
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }
}
