using _05___Decorator.Sandwich.ComponentBase;

namespace _05___Decorator.Sandwich.ConcreteComponent
{
    class TunaSandwich : SandwichBase
    {
        public TunaSandwich()
        {
            Description = "Tune Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return 4.10;
        }
    }
}
