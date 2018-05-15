using _05___Mediator.StockSales.Mediator;
using System;

namespace _05___Mediator.StockSales.Colleague
{
    public class GormanSlacks : StockColleague
    {
        public GormanSlacks(IStockMediator newMediator) : base(newMediator)
        {
            Console.WriteLine("Gorman Slacks signed up with the stockexchange\n");
        }
    }
}
