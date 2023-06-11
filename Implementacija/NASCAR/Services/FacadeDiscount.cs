using Microsoft.EntityFrameworkCore;
using NASCAR.Data;
using NASCAR.Models;

namespace NASCAR.Services
{
    public class FacadeDiscount
    {
        private ApplicationDbContext _context;
        public ConcreteDiscountFactory _concreteDiscountFactory;
        public FacadeDiscount(ApplicationDbContext context, ConcreteDiscountFactory concreteDiscountFactory)
        {
            _concreteDiscountFactory = concreteDiscountFactory;
            _context = context;
        }
        public double CalculateDiscount(Reservation reservation)
        {
            DateTime pickup = DateTime.Parse(reservation.PickUpDate);
            DateTime drop = DateTime.Parse(reservation.DropDate);

            var carRes =  _context.Reservation.Where(m => m.VehicleId == reservation.VehicleId).ToList();
               
            foreach(var res in carRes)
            {
                DateTime tempPickup = DateTime.Parse(res.PickUpDate);
                DateTime tempDrop = DateTime.Parse(res.DropDate);
                if((pickup >= tempPickup && pickup <= tempDrop)||(pickup<=tempPickup && tempDrop >= pickup))
                {
                    return -1.0;
                }

            }

            int days;
            try
            {
                days = Convert.ToInt32((drop - pickup).TotalDays);
            }
            catch
            {
                return Convert.ToDouble(reservation.Price);
            }
            
            return _concreteDiscountFactory.GetDiscount(days.ToString()).CalculateDiscount(reservation.Price);
           
        }
    }
   

}