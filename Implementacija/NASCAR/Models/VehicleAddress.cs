using Microsoft.EntityFrameworkCore;
using NASCAR.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	public class VehicleAddress
	{
		private ApplicationDbContext _context;

		[Key]
		public int Id { get; set; }
		[DisplayName("Street name:")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No digits allowed!")]
		public string StreetName { get; set; }
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No digits allowed!")]
		public string City { get; set; }
		

		public List<VehicleAddress> GetAll()
		{
			List<VehicleAddress> addresses = _context.VehicleAddress.ToListAsync().Result;


			return addresses;
		}
		
		public VehicleAddress(ApplicationDbContext context)
		{
			_context = context;
		}

		public VehicleAddress()
		{
		}
	}

}
