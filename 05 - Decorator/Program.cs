using _05___Decorator.Pizza.ConcreteComponent;
using _05___Decorator.Pizza.ConcreteDecorator;
using _05___Decorator.Sandwich.ComponentBase;
using _05___Decorator.Sandwich.ConcreteComponent;
using _05___Decorator.Sandwich.ConcreteDecorator;
using System;

namespace _05___Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sandwich

            SandwichBase mySandwich = new VeggieSandwich();

            Console.WriteLine(mySandwich.GetPrice());
            Console.WriteLine(mySandwich.GetDescription());

            mySandwich = new Cheese(mySandwich);
            Console.WriteLine(mySandwich.GetPrice());
            Console.WriteLine(mySandwich.GetDescription());

            mySandwich = new Olives(mySandwich);
            Console.WriteLine(mySandwich.GetPrice());
            Console.WriteLine(mySandwich.GetDescription());

            #endregion

            #region Pizza

            var pizza = new PizzaBase();

            pizza = new OlivesDecorator(pizza);
            pizza = new MushroomsDecorator(pizza);
            pizza = new PepperoniDecorator(pizza);
            pizza = new PineappleDecorator(pizza);

            Console.WriteLine($"Pizza Description: {pizza.Description}");

            #endregion
        }
    }
}
