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
    public class DriversLicencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversLicencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DriversLicences
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DriversLicence.Include(d => d.RegisteredUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DriversLicences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DriversLicence == null)
            {
                return NotFound();
            }

            var driversLicence = await _context.DriversLicence
                .Include(d => d.RegisteredUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driversLicence == null)
            {
                return NotFound();
            }

            return View(driversLicence);
        }

        // GET: DriversLicences/Create
        public IActionResult Create()
        {
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id");
            return View();
        }

        // POST: DriversLicences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExpiryDate,HasBCategory,RegisteredUserId")] DriversLicence driversLicence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driversLicence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", driversLicence.RegisteredUserId);
            return View(driversLicence);
        }

        // GET: DriversLicences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DriversLicence == null)
            {
                return NotFound();
            }

            var driversLicence = await _context.DriversLicence.FindAsync(id);
            if (driversLicence == null)
            {
                return NotFound();
            }
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", driversLicence.RegisteredUserId);
            return View(driversLicence);
        }

        // POST: DriversLicences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExpiryDate,HasBCategory,RegisteredUserId")] DriversLicence driversLicence)
        {
            if (id != driversLicence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driversLicence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriversLicenceExists(driversLicence.Id))
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
            ViewData["RegisteredUserId"] = new SelectList(_context.RegisteredUser, "Id", "Id", driversLicence.RegisteredUserId);
            return View(driversLicence);
        }

        // GET: DriversLicences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DriversLicence == null)
            {
                return NotFound();
            }

            var driversLicence = await _context.DriversLicence
                .Include(d => d.RegisteredUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driversLicence == null)
            {
                return NotFound();
            }

            return View(driversLicence);
        }

        // POST: DriversLicences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DriversLicence == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DriversLicence'  is null.");
            }
            var driversLicence = await _context.DriversLicence.FindAsync(id);
            if (driversLicence != null)
            {
                _context.DriversLicence.Remove(driversLicence);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DriversLicenceExists(int id)
        {
          return (_context.DriversLicence?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
