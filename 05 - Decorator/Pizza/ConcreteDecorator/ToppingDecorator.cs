using _05___Decorator.Pizza.ComponentBase;
using _05___Decorator.Pizza.DecoratorBase;

namespace _05___Decorator.Pizza.ConcreteDecorator
{
    class ToppingDecorator : PizzaDecorator
    {
        protected ToppingDecorator(IPizza pizza) : base(pizza)
        {
            // Get the name of the current class type while removing "Decorator"
            // and then adding that to the list of current toppings.
            _toppings.Add(GetType().Name.Replace("Decorator", null));
        }
    }
}
