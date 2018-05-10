using _05___Decorator.Sandwich.ComponentBase;
using _05___Decorator.Sandwich.DecoratorBase;

namespace _05___Decorator.Sandwich.ConcreteDecorator
{
    public class Olives : SandwichDecorator
    {
        public Olives(SandwichBase sandwichBase) : base(sandwichBase)
        {
            Description = "Olives";
        }

        public override string GetDescription()
        {
            return sandwichBase.GetDescription() + ", " + Description;
        }

        public override double GetPrice()
        {
            return sandwichBase.GetPrice() + 0.89;
        }
    }
}
