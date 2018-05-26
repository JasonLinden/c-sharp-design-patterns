using Bakery.Concrete;
using Cast.Concrete;
using System;

namespace _10___TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.WriteLine("\nTHE OFFICE");
            var theOffice = new NBCShow("The Office", DayOfWeek.Thursday, 21);
            theOffice.Broadcast();

            Console.WriteLine("\nCOMPUTERPHILE");
            var computerphile = new YouTubeShow("Computerphile");
            computerphile.Broadcast();

            Console.WriteLine("\nSTRANGER THINGS");
            var strangerThings = new NetflixShow("Stranger Things");
            strangerThings.Broadcast();

            Console.ReadKey();
        }
    }
}
