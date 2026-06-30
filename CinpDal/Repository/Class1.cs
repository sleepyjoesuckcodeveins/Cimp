using System;
using YahooFinanceApi;
using Domain.Interface;
using Domain.Model;


namespace CinpDomain.Repository
{
    public class YFinanceStock:IYFinanceStock
    {

        public Task <List<StockHistory>> GetStockHistory(string symbol, DateTime startDate, DateTime endDate)
        {        
                
           throw new NotImplementedException();
        }

        public string GetStockData (string symbol)
        {
            throw new NotImplementedException();
        }



    }
}