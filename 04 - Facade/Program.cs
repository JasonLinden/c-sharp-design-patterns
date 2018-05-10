using _04___Facade.Computer;
using _04___Facade.Restaurant;
using _04___Facade.Restaurant.Facade;
using System;

namespace _04___Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Computer Facade

            var computer = new ComputerFacade();
            computer.Start();

            #endregion

            #region Restuarant

            ServerFacade server = new ServerFacade();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            Patron patron = new Patron(name);

            Console.WriteLine("Hello " + patron.Name + ". What appetizer would you like? (1-15):");
            var appID = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeID = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkID = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            server.PlaceOrder(patron, appID, entreeID, drinkID);  //Here's what the Facade simplifies

            Console.ReadKey();

            #endregion
        }
    }
}
