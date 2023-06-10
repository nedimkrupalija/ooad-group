using Microsoft.AspNetCore.Identity;
using NASCAR.Data;
using NASCAR.Models;

namespace NASCAR.Services
{
	public class AddressNameConverter
	{
		private ApplicationDbContext _context;
		private SignInManager<RegisteredUser> _signInManager;

		public AddressNameConverter(ApplicationDbContext context, SignInManager<RegisteredUser> signInManager)
		{
			_context = context;
			_signInManager = signInManager;

		}

		public int GetAddressId(string Name)
		{
			var address = _context.VehicleAddress.Where(e=>e.City==Name).FirstOrDefault();
			return address.Id;
		}

	}
}
