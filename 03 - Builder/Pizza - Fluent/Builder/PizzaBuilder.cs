using _03___Builder.Pizza___Fluent.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Builder.Pizza___Fluent.Builder
{
    class PizzaBuilder
    {
        public Size Size { get; set; }
        public Cheese Cheese { get; set; }
        public bool Sauce { get; set; }
        public bool Pepperoni { get; set; }
        public bool Ham { get; set; }
        public bool Olives { get; set; }
        public bool Mushrooms { get; set; }

        public Pizza Build()
        {
            return new Pizza(this);
        }

        public PizzaBuilder(Size size = Size.Large)
        {
            Size = size;
        }

        public PizzaBuilder AddCheese(Cheese cheese = Cheese.Mozzarella)
        {
            Cheese = cheese;
            return this;
        }

        public PizzaBuilder AddSauce()
        {
            Sauce = true;
            return this;
        }

        public PizzaBuilder AddPepperoni()
        {
            Pepperoni = true;
            return this;
        }

        public PizzaBuilder AddHam()
        {
            Ham = true;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            Olives = true;
            return this;
        }

        public PizzaBuilder AddMushrooms()
        {
            Mushrooms = true;
            return this;
        }
    }
}
