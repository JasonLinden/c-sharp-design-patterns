using _05___Mediator.StockSales.Colleague;
using System;

namespace _05___Mediator.StockSales.Mediator
{
    public interface IStockMediator
    {
        void SaleOffer(String stock, int shares, int collCode);

        void BuyOffer(String stock, int shares, int collCode);

        void AddColleague(StockColleague colleague);
    }
}
