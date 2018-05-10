using _03___Builder;
using System.Collections.Generic;

namespace _05___Decorator.Pizza.ComponentBase
{
    /// <summary>
    /// Basic interface defining the core properties.
    /// </summary>
    public interface IPizza
    {
        Cheese Cheese { get; }
        decimal Cost { get; }
        string Description { get; }
        Size Size { get; }
        List<string> Toppings { get; }
    }
}
