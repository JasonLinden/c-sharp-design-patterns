using _05___Decorator.Sandwich.ComponentBase;

namespace _05___Decorator.Sandwich.DecoratorBase
{
    public class SandwichDecorator : SandwichBase
    {
        protected SandwichBase sandwichBase;

        public SandwichDecorator(SandwichBase sandwichBase) => 
            this.sandwichBase = sandwichBase;

        public override string GetDescription()
        {
            return sandwichBase.GetDescription();
        }

        public override double GetPrice()
        {
            return sandwichBase.GetPrice();
        }
    }
}
