using _05___Decorator.Pizza.ComponentBase;
using _05___Decorator.Pizza.ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Decorator.Pizza.DecoratorBase
{
    /// <summary>
    /// The base decorator on which others will be based.
    /// Ensures that all decorators can use and accept the IPizza interface.
    /// This is where logic used to *combine* decorator functionality takes place.
    /// </summary>
    public abstract class PizzaDecorator : PizzaBase
    {
        // Base interface component which is used to modify properties elsewhere.
        private IPizza _pizza;

        // Protected flag ensures the value can be modified in inherited decorators.
        protected decimal _cost;
        protected List<string> _toppings = new List<string>();

        // Constructor must set the private interface component to match the passed one, 
        // allowing future propert modifications to continue along the chain.
        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        // Cost if current instance added to passed instance cost.
        public override decimal Cost
        {
            get
            {
                return _cost + _pizza.Cost;
            }
        }

        // Combine current instance toppings with passed instance toppings.
        public override List<string> Toppings
        {
            get
            {
                return _pizza.Toppings.Concat(_toppings).ToList();
            }
        }
    }
}
