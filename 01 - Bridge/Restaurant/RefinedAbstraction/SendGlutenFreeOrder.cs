using _01___Bridge.Restaurant.Abstraction;

namespace _01___Bridge.Restaurant.RefinedAbstraction
{
    class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}
