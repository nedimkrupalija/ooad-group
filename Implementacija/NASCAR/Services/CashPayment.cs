using NASCAR.Models;

namespace NASCAR.Services
{
    public class CashPayment : IStrategyPayment
    {
       
        public double CalculateThePrice(double price)
        {
            return price;
        }
    }
}
