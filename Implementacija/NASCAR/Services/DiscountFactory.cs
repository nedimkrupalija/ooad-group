using NASCAR.Models;
using NASCAR.Services;

namespace NASCAR.Services
{
    public abstract class DiscountFactory
    {
        public abstract IDiscount GetDiscount(string days);
        
    }
}
