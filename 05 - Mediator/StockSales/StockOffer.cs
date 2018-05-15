using System;

namespace _05___Mediator.StockSales
{
    public class StockOffer
    {
        private int stockShares = 0;
        private String stockSymbol = "";
        private int colleagueCode = 0;

        public StockOffer(int numOfShares, String stock, int collCode)
        {
            stockShares = numOfShares;
            stockSymbol = stock;
            colleagueCode = collCode;
        }

        public int GetstockShares => stockShares;
        public String GetStockSymbol => stockSymbol;
        public int GetCollCode => colleagueCode;

    }
}
