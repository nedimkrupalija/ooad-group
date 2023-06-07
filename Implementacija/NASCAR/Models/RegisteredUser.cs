using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
	public class RegisteredUser : IdentityUser
	{
		

		[DataType(DataType.CreditCard)]
		[DisplayName("Card number")]
		public CardDetails? CardDetails { get; set; }
		
		
		[DataType(DataType.PhoneNumber)]
        public string? Contact { get; set; }
		public DriversLicence? Licence { get; set; }
		public ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();
        public string? FirstName { get; set; }
        public string? LastName { get ; set; }

        public RegisteredUser()
		{

		}
	}
}
