using _05___Decorator.Pizza.ComponentBase;

namespace _05___Decorator.Pizza.ConcreteDecorator
{
    class MushroomsDecorator : ToppingDecorator
    {
        public MushroomsDecorator(IPizza pizza) : base(pizza)
        {
            // Set the topping cost.
            _cost = 2;
        }
    }
}
