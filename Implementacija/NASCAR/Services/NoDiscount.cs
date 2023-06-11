using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics.CodeAnalysis;

namespace NASCAR.Services
{
    public class NoDiscount : IDiscount
    {
        

        public double CalculateDiscount(string price)
        {
            return Convert.ToDouble(price) * 1;
        }
    }
}
