namespace NASCAR.Services
{
    public class MaxDiscount : IDiscount
    {
        public double CalculateDiscount(string price)
        {
            return Convert.ToDouble(price) * 0.7;
        }
    }
}
