using _05___Decorator.Sandwich.ComponentBase;
using _05___Decorator.Sandwich.DecoratorBase;

namespace _05___Decorator.Sandwich.ConcreteDecorator
{
    public class Cheese : SandwichDecorator
    {
        public Cheese(SandwichBase sandwichBase) : base(sandwichBase)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return sandwichBase.GetDescription() + ", " + Description;
        }

        public override double GetPrice()
        {
            return sandwichBase.GetPrice() + 1.23;
        }
    }
}
