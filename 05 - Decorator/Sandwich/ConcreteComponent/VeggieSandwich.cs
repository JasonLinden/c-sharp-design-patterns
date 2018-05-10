using _05___Decorator.Sandwich.ComponentBase;

namespace _05___Decorator.Sandwich.ConcreteComponent
{
    public class VeggieSandwich : SandwichBase
    {
        public VeggieSandwich()
        {
            Description = "Veggie sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return 3.45;
        }
    }
}
