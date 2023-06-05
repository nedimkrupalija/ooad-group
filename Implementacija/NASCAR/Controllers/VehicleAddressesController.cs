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
    public class VehicleAddressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehicleAddressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VehicleAddresses
        public async Task<IActionResult> Index()
        {
              return _context.VehicleAddress != null ? 
                          View(await _context.VehicleAddress.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.VehicleAddress'  is null.");
        }

        // GET: VehicleAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VehicleAddress == null)
            {
                return NotFound();
            }

            var vehicleAddress = await _context.VehicleAddress
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleAddress == null)
            {
                return NotFound();
            }

            return View(vehicleAddress);
        }

        // GET: VehicleAddresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StreetName,City")] VehicleAddress vehicleAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleAddress);
        }

        // GET: VehicleAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VehicleAddress == null)
            {
                return NotFound();
            }

            var vehicleAddress = await _context.VehicleAddress.FindAsync(id);
            if (vehicleAddress == null)
            {
                return NotFound();
            }
            return View(vehicleAddress);
        }

        // POST: VehicleAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StreetName,City")] VehicleAddress vehicleAddress)
        {
            if (id != vehicleAddress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleAddressExists(vehicleAddress.Id))
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
            return View(vehicleAddress);
        }

        // GET: VehicleAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VehicleAddress == null)
            {
                return NotFound();
            }

            var vehicleAddress = await _context.VehicleAddress
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleAddress == null)
            {
                return NotFound();
            }

            return View(vehicleAddress);
        }

        // POST: VehicleAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VehicleAddress == null)
            {
                return Problem("Entity set 'ApplicationDbContext.VehicleAddress'  is null.");
            }
            var vehicleAddress = await _context.VehicleAddress.FindAsync(id);
            if (vehicleAddress != null)
            {
                _context.VehicleAddress.Remove(vehicleAddress);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleAddressExists(int id)
        {
          return (_context.VehicleAddress?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
