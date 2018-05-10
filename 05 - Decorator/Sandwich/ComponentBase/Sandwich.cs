namespace _05___Decorator.Sandwich.ComponentBase
{
    public abstract class SandwichBase
    {
        public abstract string GetDescription();

        public abstract double GetPrice();

        public string Description { get; set; }
    }
}
