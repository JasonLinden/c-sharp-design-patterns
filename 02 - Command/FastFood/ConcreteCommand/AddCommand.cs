using _02___Command.FastFood.Command;
using System.Collections.Generic;

namespace _02___Command.FastFood.ConcreteCommand
{
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }
}
