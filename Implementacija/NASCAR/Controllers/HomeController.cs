using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NASCAR.Data;
using NASCAR.Models;
using NASCAR.Services;
using System.Diagnostics;

namespace NASCAR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult search(string name, string year, string price, string city)
        {
            var vehicles =  _context.Vehicles
                .Include(p => p.VehicleAddress)
                .ToList();
            FilterBuilder _filterBuilder = new();
       
            _filterBuilder.SetYear(year);
            try
            {
                _filterBuilder.SetPrice(Convert.ToInt32(price));
            }
            catch(Exception ex)
            {
                _filterBuilder.SetPrice(99999);
            }
           
            _filterBuilder.SetCarName(name);
            
            _filterBuilder.SetCity(city);

            var filter = _filterBuilder.Build();

            vehicles = filter.GetVehicles(vehicles);

            
            return View(nameof(Index), vehicles);

        }


        public IActionResult Index()
        {
            return _context.Vehicles != null ?
             View(_context.Vehicles.ToList()) :
             Problem("Entity set 'ApplicationDbContext.Vehicle'  is null.");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}