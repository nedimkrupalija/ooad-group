
namespace NASCAR.Code

{
    public interface IDiscount
    {
        double calculateDiscount(int days);
    }

    public class WeeklyDiscount : IDiscount 
    {

        double IDiscount.calculateDiscount(int days)
        {
            return 0.1;
        }
    }
    public class SuperDiscount : IDiscount
    {
        double IDiscount.calculateDiscount(int days)
        {
            return 0.2;
        }
    }

    public class MaxDiscount : IDiscount 
    {
        double IDiscount.calculateDiscount(int days)
        {
            return 0.3;
        }
    }

    public abstract class DiscountFactory
    {
        public abstract IDiscount GetDiscount(string name);
    }

    public class ConcreteDiscountFactory : DiscountFactory
    {
        public override IDiscount GetDiscount(string name)
        {
            switch (name)
            {
                case "Weekly":
                    return new WeeklyDiscount();
                case "Super":
                    return new SuperDiscount();
                case "Max":
                    return new MaxDiscount();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", name));
            }
        }

    }

}
