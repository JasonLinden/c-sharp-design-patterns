using PostalService;
using PostalService.ConcreteStrategy;
using PostalService.Context;
using RobotStategy.ConcreteStrategy;
using RobotStategy.Context;
using Sorted.ConcreteStrategy;
using Sorted.Context;
using System;

namespace _09___Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Robot

            var robot1 = new Robot("4of11", new BorgBehaviour());
            var robor2 = new Robot("Military Robot", new AggresiveBehaviour());
            var robot3 = new Robot("rotoROBOt", new NormalBehaviour());

            robot1.Move();
            robor2.Move();
            robot3.Move();

            #endregion

            #region Sorted List

            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            #endregion

            var bear = new Package("A teddy bear");
            var defaultPackager = new Packager(new DefaultStrategy());
            defaultPackager.Pack(bear);
            Console.WriteLine(bear.ToString());

            var monitor = new Package("A computer monitor");
            var packager = new Packager(new FragileStrategy());
            packager.Pack(monitor);
            Console.WriteLine(monitor.ToString());

            var fish = new Package("Some salmon filets");
            packager.Pack(fish, new PerishableStrategy());
            Console.WriteLine(fish.ToString());

            var massiveBear = new Package("A MASSIVE teddy bear");
            packager.Pack(massiveBear, new OversizedStrategy());
            Console.WriteLine(massiveBear.ToString());

            Console.ReadKey();
        }
    }
}
