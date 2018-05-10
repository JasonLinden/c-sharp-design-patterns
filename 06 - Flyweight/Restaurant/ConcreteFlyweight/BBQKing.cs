using _06___Flyweight.Restaurant.Flyweight;
using System;

namespace _06___Flyweight.Restaurant.ConcreteFlyweight
{
    class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
