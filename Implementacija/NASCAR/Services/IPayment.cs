using NASCAR.Models;

namespace NASCAR.Services
{
    public interface IPayment
    {
        public double calculateThePrice(double pricePerDay, int numberOfDays);
    }
}
