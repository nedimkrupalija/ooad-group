using NASCAR.Models;

namespace NASCAR.Services
{
    public interface IStrategyPayment
    {
        public double CalculateThePrice(double price);
    }
}
