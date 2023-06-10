using Microsoft.AspNetCore.Mvc;
using NASCAR.Data;
using NASCAR.Models;
using System.Diagnostics;

namespace NASCAR.Controllers
{
    public class AdminController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public AdminController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
			return _context.Reservation != null ?
			 View(_context.Reservation.ToList()) :
			 Problem("Entity set 'ApplicationDbContext.Vehicle'  is null.");
		}

        public IActionResult Users()
        {
            var users = _context.RegisteredUser;
            return View(users.ToList());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
