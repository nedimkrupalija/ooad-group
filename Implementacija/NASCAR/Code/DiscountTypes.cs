using NASCAR.Models;

namespace NASCAR.Code

{
    public class NoDiscount :  Discount, IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            DiscountPercent = 0;
            return 0;
        }
    }
    public class WeeklyDiscount : Discount, IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            DiscountPercent = 0.1;
            return 0.1;
        }
    }
    public class SuperDiscount : Discount, IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            DiscountPercent = 0.15;
            return 0.15;
        }
    }

    public class MaxDiscount : Discount, IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            DiscountPercent = 0.2;
            return 0.2;
        }
    }


}
