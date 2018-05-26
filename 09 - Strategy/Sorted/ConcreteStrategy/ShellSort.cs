using Sorted.Strategy;
using System;
using System.Collections.Generic;

namespace Sorted.ConcreteStrategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }
}
