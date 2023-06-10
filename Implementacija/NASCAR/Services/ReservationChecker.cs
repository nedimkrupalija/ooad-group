using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NASCAR.Data;
using NASCAR.Models;

namespace NASCAR.Services
{
    public class ReservationChecker
    {
        private ApplicationDbContext _context;
        private SignInManager<RegisteredUser> _signInManager;
        
        public ReservationChecker(ApplicationDbContext context, SignInManager<RegisteredUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;

        }

      
        public void SetReserved()
        {
            var reservations = _context.Reservation
                .Include(m => m.Vehicle).ToList();
            var currentDate = DateTime.Now;
            
            foreach(Reservation reservation in  reservations)
            {
                var from = DateTime.Parse(reservation.PickUpDate);
                var to = DateTime.Parse(reservation.DropDate);
                if(currentDate<from || currentDate > to)
                {
                    reservation.Vehicle.IsReserved = false;
                }
                else
                {
                    reservation.Vehicle.IsReserved = true;
                }
                _context.Vehicles.Update(reservation.Vehicle);
            }
           
           

        }

    }
}
