using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Claims;
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
        private readonly IStrategyPayment _payment;
        private readonly IStrategyPayment _cashPayment;
        private readonly IStrategyPayment _cardPayment;

        public ReservationsController(ApplicationDbContext context, UserManager<RegisteredUser> userManager, IStrategyPayment payment, IStrategyPayment cashPayment, IStrategyPayment cardPayment)
        {
            _context = context;
            _userManager = userManager;
            _payment = payment;
            _cashPayment = cashPayment;
            _cardPayment = cardPayment;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            if (await _userManager.IsInRoleAsync(user, "RegisteredUser"))
            {
                var applicationDbContext = _context.Reservation
                    .Include(r => r.Discount)
                    .Include(r => r.RegisteredUser)
                    .Include(r => r.Vehicle)
                    .Where(a => a.RegisteredUserId == userId);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Reservation
                    .Include(r => r.Discount)
                    .Include(r => r.RegisteredUser)
                    .Include(r => r.Vehicle);
                return View(await applicationDbContext.ToListAsync());
            }
        }

        public async Task<IActionResult> AllReservations()
        {
            var reservations = await _context.Reservation.ToListAsync();
            return View(reservations);
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
        public async Task<IActionResult> Create(int vehicleid, int price)
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var card = await _context.CardDetails
                .Where(m => m.RegisteredUserId == userId)
                .ToListAsync();

            List<string> type = new List<string>();
            type.Add("Cash");
            if (card.Count != 0)
                type.Add("Card");

            // Get the vehicle by ID and retrieve the price
            var vehicle = await _context.Vehicles.FindAsync(vehicleid);
            double? vehiclePrice = vehicle?.Price;

            // Set the ViewData["Price"] value based on the vehicle price
            ViewData["Price"] = vehiclePrice.HasValue ? vehiclePrice.Value.ToString("0.00") : "N/A";

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PickUpDate,DropDate,Price,RegisteredUserId,VehicleId,DiscountId,PaymentType")] Reservation reservation)
        {
            reservation.RegisteredUserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var oldPrice = reservation.Price;
            reservation.Price = ((int)(new FacadeDiscount(_context, new ConcreteDiscountFactory()).CalculateDiscount(reservation))).ToString();

            if (reservation.Price == "-1")
            {
                return RedirectToAction(nameof(Error));
            }
            var difference = Convert.ToDouble(oldPrice) - Convert.ToDouble(reservation.Price);
            var percent = difference / Convert.ToDouble(oldPrice);
            if (reservation.PaymentType == PaymentEnum.Card)
                percent += 0.1;
            var discount = new Discount(percent, difference);

            _context.Discount.Add(discount);
            await _context.SaveChangesAsync();
           

            System.Console.WriteLine("abc");

            reservation.DiscountId = discount.Id;

            if (reservation.PaymentType == PaymentEnum.Cash)
            {
                reservation.Price = (_cashPayment.CalculateThePrice(Convert.ToDouble(reservation.Price))).ToString();
            }
            else if (reservation.PaymentType == PaymentEnum.Card)
            {
                reservation.Price = (_cardPayment.CalculateThePrice(Convert.ToDouble(reservation.Price))).ToString();
            }

            if (ModelState.IsValid)
            {
                double pricePerDay = await _context.Vehicles
                    .Where(v => v.Id == reservation.VehicleId)
                    .Select(v => v.Price)
                    .FirstOrDefaultAsync() ?? 0;
 
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
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }
    }
}