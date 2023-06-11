using NASCAR.Models;

namespace NASCAR.Services
{
    public class CashPayment : IPayment
    {
        public double calculateThePrice(double pricePerDay, int numberOfDays)
        {
            return pricePerDay * numberOfDays;
        }
    }
}
