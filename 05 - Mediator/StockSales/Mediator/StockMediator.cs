using _05___Mediator.StockSales.Colleague;
using System;
using System.Collections.Generic;

namespace _05___Mediator.StockSales.Mediator
{
    public class StockMediator : IStockMediator
    {
        private List<StockColleague> colleagues;
        private List<StockOffer> stockBuyOffers;
        private List<StockOffer> stockSaleOffers;

        private int colleagueCodes = 0;

        public StockMediator()
        {

            colleagues = new List<StockColleague>();
            stockBuyOffers = new List<StockOffer>();
            stockSaleOffers = new List<StockOffer>();
        }

        public void AddColleague(StockColleague newColleague)
        {

            colleagues.Add(newColleague);

            colleagueCodes++;

            newColleague.SetCollCode(colleagueCodes);

        }

        public void SaleOffer(String stock, int shares, int collCode)
        {

            bool stockSold = false;

            foreach (StockOffer offer in stockBuyOffers)
            {

                if ((offer.GetStockSymbol == stock) && (offer.GetstockShares == shares))
                {

                    Console.WriteLine(shares + " shares of " + stock +
                        " sold to colleague code " + offer.GetCollCode);

                    stockBuyOffers.Remove(offer);

                    stockSold = true;

                }

                if (stockSold) { break; }

            }

            if (!stockSold)
            {

                Console.WriteLine(shares + " shares of " + stock +
                        " added to inventory");

                StockOffer newOffering = new StockOffer(shares, stock, collCode);

                stockSaleOffers.Add(newOffering);

            }

        }

        public void BuyOffer(String stock, int shares, int collCode)
        {

            bool stockBought = false;

            foreach (StockOffer offer in stockSaleOffers)
            {

                if ((offer.GetStockSymbol == stock) && (offer.GetstockShares == shares))
                {

                    Console.WriteLine(shares + " shares of " + stock +
                            " bought by colleague code " + offer.GetCollCode);

                    stockSaleOffers.Remove(offer);

                    stockBought = true;

                }

                if (stockBought) { break; }

            }

            if (!stockBought)
            {

                Console.WriteLine(shares + " shares of " + stock +
                        " added to inventory");

                StockOffer newOffering = new StockOffer(shares, stock, collCode);

                stockBuyOffers.Add(newOffering);

            }

        }

        public void GetstockOfferings()
        {

            Console.WriteLine("\nStocks for Sale");

            foreach (StockOffer offer in stockSaleOffers)
            {
                Console.WriteLine(offer.GetstockShares + " of " + offer.GetStockSymbol);
            }

            Console.WriteLine("\nStock Buy Offers");

            foreach (StockOffer offer in stockBuyOffers)
            {
                Console.WriteLine(offer.GetstockShares + " of " + offer.GetStockSymbol);
            }
        }
    }
}
