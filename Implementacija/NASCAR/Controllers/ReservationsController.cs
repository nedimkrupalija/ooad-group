using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NASCAR.Areas.Identity.Pages.Account;
using NASCAR.Data;
using NASCAR.Models;
using NASCAR.Services;

namespace NASCAR.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<RegisteredUser> _userManager;

        public ReservationsController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = _userManager.FindByIdAsync(userId);
            if (await _userManager.IsInRoleAsync(await user, "RegisteredUser"))
            {
                var applicationDbContext = _context.Reservation.Include(r => r.Discount).Include(r => r.RegisteredUser).Include(r => r.Vehicle)
                    .Where(a => a.RegisteredUserId == HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Reservation.Include(r => r.Discount).Include(r => r.RegisteredUser).Include(r => r.Vehicle);
                return View(await applicationDbContext.ToListAsync());

            }
            
        }

        public async Task<IActionResult> AllReservations()
        {
            var reservations = _context.Reservation;
            return View(await reservations.ToListAsync());
        }


        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            

            var reservation = await _context.Reservation
                .Include(r => r.Discount)
                .Include(r => r.RegisteredUser)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create(int vehicleid, int price)
        {
            var card =  _context.CardDetails 
                .Where(m=>m.RegisteredUserId == HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value).ToListAsync().Result;



            List<string> type = new List<string>();
            type.Add("Cash");
            if (card.Count != 0)
            type.Add("Card");
            ViewData["PaymentType"] = new SelectList(type);
            ViewData["VehicleId"] = vehicleid;
            ViewData["Price"] = price;
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PickUpDate,DropDate,Price,RegisteredUserId,VehicleId,DiscountId,PaymentType")] Reservation reservation)
        {
            reservation.RegisteredUserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
           
            reservation.Price = ((int)(new FacadeDiscount(_context, new ConcreteDiscountFactory()).CalculateDiscount(reservation))).ToString();

            if(reservation.Price == "-1")
            {
                return RedirectToAction(nameof(Error));
            }

            System.Console.WriteLine("abc");

            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            ViewData["DiscountId"] = new SelectList(_context.Discount, "Id", "Id", reservation.DiscountId);
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", reservation.RegisteredUserId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", reservation.VehicleId);
            return RedirectToAction("Index", "Home");
        }

        // GET: Reservations/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["DiscountId"] = new SelectList(_context.Discount, "Id", "Id", reservation.DiscountId);
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", reservation.RegisteredUserId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", reservation.VehicleId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PickUpDate,RegisteredUserId,VehicleId,DiscountId,PaymentType")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DiscountId"] = new SelectList(_context.Discount, "Id", "Id", reservation.DiscountId);
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", reservation.RegisteredUserId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", reservation.VehicleId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Discount)
                .Include(r => r.RegisteredUser)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);

            
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reservation == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reservation'  is null.");
            }
            var reservation = await _context.Reservation.FindAsync(id);
			reservation.Vehicle.IsReserved = false;
            _context.Update(reservation.Vehicle);
			if (reservation != null)
            {
                _context.Reservation.Remove(reservation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
          return (_context.Reservation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
