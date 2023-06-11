namespace NASCAR.Code
{
    public abstract class DiscountFactory
    {
        public abstract IDiscount GetDiscount(int days);
    }
}
