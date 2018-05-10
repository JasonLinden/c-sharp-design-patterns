using _06___Flyweight.Restaurant.Flyweight;
using System;

namespace _06___Flyweight.Restaurant.ConcreteFlyweight
{
    public class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
