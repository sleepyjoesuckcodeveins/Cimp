using Domain.Model;
namespace Domain.Interface
{

    public interface IYFinanceStock
    {
        string GetStockData(string symbol);
         Task<List<StockHistory>> GetStockHistory(string symbol, DateTime startDate, DateTime endDate);
    
    }

}