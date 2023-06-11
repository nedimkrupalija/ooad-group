namespace NASCAR.Services
{
    public class ConcreteDiscountFactory : DiscountFactory
    {
        public override IDiscount GetDiscount(string days)
        {
            int _days;
            try
            {
                _days = Convert.ToInt32(days);
            }
            catch {
                return new NoDiscount();
            }

            if (_days <= 7)
            {
                return new NoDiscount();
            }
            else if (_days > 7 && _days < 15)
            {
                return new SuperDiscount();
            }
            else if (_days >= 15)
            {
                return new MaxDiscount();
            }
            else return new NoDiscount();
        }
    }
}
