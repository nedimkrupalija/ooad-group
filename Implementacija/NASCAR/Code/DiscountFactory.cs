namespace NASCAR.Code
{
    public  class DiscountFactory
    {
        public  IDiscount GetDiscount(int days)
        {

            if (days >= 7 && days < 15)
            {
                return new NoDiscount();
            }
            else if (days >= 15 && days < 25)
            {
                return new SuperDiscount();
            }
            else if (days >= 25)
            {
                return new MaxDiscount();
            }
            else return new NoDiscount();
        }
    }
}
