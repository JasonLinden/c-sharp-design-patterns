using _05___Mediator.Colleague;
using _05___Mediator.GOT.Colleague;
using _05___Mediator.GOT.Mediator;
using _05___Mediator.Mediator;
using _05___Mediator.StockSales.Colleague;
using _05___Mediator.StockSales.Mediator;
using System;

namespace _05___Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Movies

            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessions = leftKitchen;
            mediator.SouthConcessions = rightKitchen;

            leftKitchen.Send("Can you send some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            leftKitchen.Send("Just a couple, we'll send Kenny back with them.");
            #endregion

            #region Stocks

            StockMediator nyse = new StockMediator();

            GormanSlacks broker = new GormanSlacks(nyse);
            JTPoorman broker2 = new JTPoorman(nyse);

            broker.SaleOffer("MSFT", 100);
            broker.SaleOffer("GOOG", 50);

            broker2.BuyOffer("MSFT", 100);
            broker2.SaleOffer("NRG", 10);

            broker.BuyOffer("NRG", 10);

            nyse.GetstockOfferings();
            #endregion

            #region Game Of Thrones

            var crier = new Crier();

            // Create some people and assign the crier.
            var arya = new Person("Arya Stark", crier);
            var cersei = new Person("Cersei Lannister", crier);
            var daenerys = new Person("Daenerys Targaryen", crier);
            // Without a tongue it's difficult to speak, so Ilyn remains silent and listens.
            var ilyn = new Person("Ilyn Payne", crier);
            var tyrion = new Person("Tyrion Lannister", crier);

            // Send messages from respective characters.
            arya.Say("Valar morghulis.");
            tyrion.Say("Never forget what you are, for surely the world will not.");
            daenerys.Say("Men are mad and gods are madder.");
            cersei.Say("When you play the game of thrones, you win or you die. There is no middle ground.");

            #endregion

            Console.ReadKey();
        }
    }
}
