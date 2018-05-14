using System.Collections.Generic;

namespace _02___Command.FastFood.Command
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }
}
