namespace Domain.Model
{
    public class StockHistory
    {
        private string _symbol;
        private DateTime _startDate;
        private DateTime _EndDate;
        public string Symbol { get { return _symbol; } set { _symbol = value; } }
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime EndDate { get { return _EndDate; } set { _EndDate = value; } }
    }


}