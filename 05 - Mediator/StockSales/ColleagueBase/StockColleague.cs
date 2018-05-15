using _05___Mediator.StockSales.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Mediator.StockSales.Colleague
{
    public abstract class StockColleague
    {
        private IStockMediator mediator;
        private int colleagueCode;

        public StockColleague(IStockMediator newMediator)
        {
            mediator = newMediator;
            mediator.AddColleague(this);

        }

        public void SaleOffer(String stock, int shares)
        {
            mediator.SaleOffer(stock, shares, this.colleagueCode);
        }

        public void BuyOffer(String stock, int shares)
        {
            mediator.BuyOffer(stock, shares, this.colleagueCode);
        }

        public void SetCollCode(int collCode) { colleagueCode = collCode; }

    }
}
