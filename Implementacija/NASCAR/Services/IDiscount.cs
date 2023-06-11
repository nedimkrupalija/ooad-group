using NASCAR.Models;


namespace NASCAR.Services
{
    public interface IDiscount
    {
        double CalculateDiscount(string price);
    }
}
