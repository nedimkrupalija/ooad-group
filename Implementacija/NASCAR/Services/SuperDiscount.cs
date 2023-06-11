namespace NASCAR.Services
{
    public class SuperDiscount : IDiscount
    {
        public double CalculateDiscount(string price)
        {
            return Convert.ToDouble(price) * 0.8;
        }
    }
}
