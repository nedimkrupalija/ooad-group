using NASCAR.Models;

namespace NASCAR.Services
{
    public class CardPayment : IStrategyPayment
    {
       

        public double CalculateThePrice(double price)
        {
            return price * 0.9;
        }
    }
}
