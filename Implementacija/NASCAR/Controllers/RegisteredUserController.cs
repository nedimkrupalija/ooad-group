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
    public class RegisteredUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisteredUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegisteredUser
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RegisteredUser.Include(r => r.Address).Include(r => r.Licence);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RegisteredUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RegisteredUser == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser
                .Include(r => r.Address)
                .Include(r => r.Licence)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            return View(registeredUser);
        }

        // GET: RegisteredUser/Create
        public IActionResult Create()
        {
            ViewData["AdressId"] = new SelectList(_context.Address, "Id", "Id");
            ViewData["LicenceId"] = new SelectList(_context.DriversLicence, "Id", "Id");
            return View();
        }

        // POST: RegisteredUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Contact,AdressId,LicenceId,Id,Username,Password,Age")] RegisteredUser registeredUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registeredUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdressId"] = new SelectList(_context.Address, "Id", "Id", registeredUser.AdressId);
            ViewData["LicenceId"] = new SelectList(_context.DriversLicence, "Id", "Id", registeredUser.LicenceId);
            return View(registeredUser);
        }

        // GET: RegisteredUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RegisteredUser == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser.FindAsync(id);
            if (registeredUser == null)
            {
                return NotFound();
            }
            ViewData["AdressId"] = new SelectList(_context.Address, "Id", "Id", registeredUser.AdressId);
            ViewData["LicenceId"] = new SelectList(_context.DriversLicence, "Id", "Id", registeredUser.LicenceId);
            return View(registeredUser);
        }

        // POST: RegisteredUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Contact,AdressId,LicenceId,Id,Username,Password,Age")] RegisteredUser registeredUser)
        {
            if (id != registeredUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registeredUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisteredUserExists(registeredUser.Id))
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
            ViewData["AdressId"] = new SelectList(_context.Address, "Id", "Id", registeredUser.AdressId);
            ViewData["LicenceId"] = new SelectList(_context.DriversLicence, "Id", "Id", registeredUser.LicenceId);
            return View(registeredUser);
        }

        // GET: RegisteredUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RegisteredUser == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser
                .Include(r => r.Address)
                .Include(r => r.Licence)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            return View(registeredUser);
        }

        // POST: RegisteredUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RegisteredUser == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RegisteredUser'  is null.");
            }
            var registeredUser = await _context.RegisteredUser.FindAsync(id);
            if (registeredUser != null)
            {
                _context.RegisteredUser.Remove(registeredUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisteredUserExists(int id)
        {
          return (_context.RegisteredUser?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
