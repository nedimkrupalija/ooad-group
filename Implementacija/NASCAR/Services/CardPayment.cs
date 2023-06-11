using NASCAR.Models;

namespace NASCAR.Services
{
    public class CardPayment : IPayment
    {
        public double calculateThePrice(double pricePerDay, int numberOfDays)
        {
            double totalPrice = pricePerDay * numberOfDays;
            double discount = totalPrice * 0.1;
            return totalPrice - discount;
        }
    }
}
