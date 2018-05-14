using _02___Command.FastFood.Command;
using System.Collections.Generic;
using System.Linq;

namespace _02___Command.FastFood.ConcreteCommand
{
    public class RemoveCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Remove(currentItems.Where(x => x.Name == newItem.Name).First());
        }
    }
}
