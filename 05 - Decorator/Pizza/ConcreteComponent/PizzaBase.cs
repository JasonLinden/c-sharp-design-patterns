using _03___Builder;
using _05___Decorator.Pizza.ComponentBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05___Decorator.Pizza.ConcreteComponent
{
    /// <summary>
    /// Acts as a concrete component upon which all decorators will rely.
    /// Defines default values and logic for most properties.
    /// </summary>
    public class PizzaBase : IPizza
    {
        // Set default cost to $7.50.
        private decimal _cost = 7.5M;
        private List<string> _toppings = new List<string>();

        public Cheese Cheese { get; } = Cheese.Mozzarella;

        public virtual decimal Cost { get { return _cost; } }

        // Set description to include cost, size, cheese, topping count, and topping list, as applicable.
        public string Description
        {
            get
            {
                // Get list of toppings as formatted string.
                var toppingsList = Toppings.Any() ? 
                    $" with {Toppings.Aggregate((index, topping) => { return index + ", " + topping; })}" : 
                    "";
                return $"A {Size.ToString()}, " + 
                       $"{Toppings.Count()}-topping {Cheese.ToString()} " +
                       $"pizza{toppingsList} for {String.Format("{0:C2}", Cost)}!";
            }
        }
        // Set default size to Large.
        public Size Size { get; } = Size.Large;
        // Allow Toppings property to be overriden.
        public virtual List<string> Toppings { get { return _toppings; } }
    }
}
