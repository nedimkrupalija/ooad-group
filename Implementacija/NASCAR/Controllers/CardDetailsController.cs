using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NASCAR.Data;
using NASCAR.Models;

namespace NASCAR.Controllers
{
    public class CardDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CardDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CardDetails.Include(c => c.RegisteredUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CardDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CardDetails == null)
            {
                return NotFound();
            }

            var cardDetails = await _context.CardDetails
                .Include(c => c.RegisteredUser)
                .FirstOrDefaultAsync(m => m.CardNumber == id);
            if (cardDetails == null)
            {
                return NotFound();
            }

            return View(cardDetails);
        }

        // GET: CardDetails/Create
        public IActionResult Create()
        {
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id");
            return View();
        }

        // POST: CardDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardNumber,CVV,DateOfExpiry,RegisteredUserId")] CardDetails cardDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", cardDetails.RegisteredUserId);
            return View(cardDetails);
        }

        // GET: CardDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CardDetails == null)
            {
                return NotFound();
            }

            var cardDetails = await _context.CardDetails.FindAsync(id);
            if (cardDetails == null)
            {
                return NotFound();
            }
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", cardDetails.RegisteredUserId);
            return View(cardDetails);
        }

        // POST: CardDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CardNumber,CVV,DateOfExpiry,RegisteredUserId")] CardDetails cardDetails)
        {
            if (id != cardDetails.CardNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardDetailsExists(cardDetails.CardNumber))
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
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", cardDetails.RegisteredUserId);
            return View(cardDetails);
        }

        // GET: CardDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CardDetails == null)
            {
                return NotFound();
            }

            var cardDetails = await _context.CardDetails
                .Include(c => c.RegisteredUser)
                .FirstOrDefaultAsync(m => m.CardNumber == id);
            if (cardDetails == null)
            {
                return NotFound();
            }

            return View(cardDetails);
        }

        // POST: CardDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CardDetails == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CardDetails'  is null.");
            }
            var cardDetails = await _context.CardDetails.FindAsync(id);
            if (cardDetails != null)
            {
                _context.CardDetails.Remove(cardDetails);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardDetailsExists(string id)
        {
          return (_context.CardDetails?.Any(e => e.CardNumber == id)).GetValueOrDefault();
        }
    }
}
