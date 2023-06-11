
namespace NASCAR.Code

{
    public class NoDiscount : IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            return 0.0;
        }
    }
    public class WeeklyDiscount : IDiscount 
    {
        double IDiscount.calculateDiscount()
        {
            return 0.1;
        }
    }
    public class SuperDiscount : IDiscount
    {
        double IDiscount.calculateDiscount()
        {
            return 0.2;
        }
    }

    public class MaxDiscount : IDiscount 
    {
        double IDiscount.calculateDiscount()
        {
            return 0.3;
        }
    }


}
