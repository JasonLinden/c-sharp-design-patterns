using _05___Mediator.StockSales.Mediator;
using System;

namespace _05___Mediator.StockSales.Colleague
{
    public class JTPoorman : StockColleague
    {
        public JTPoorman(IStockMediator newMediator) : base(newMediator)
        {
            Console.WriteLine("JTPoorman signed up with the stockexchange\n");
        }
    }
}
