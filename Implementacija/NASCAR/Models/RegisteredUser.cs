using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
	public class RegisteredUser : User
	{
		
		public CardDetails? CardDetails { get; set; }


        public string? Contact { get; set; }

		[ForeignKey("Address")]
		public int? AdressId { get; set; }	
		public Address? Address { get; set; }

		[ForeignKey("DriversLicence")]
		public int LicenceId { get; set; }
		public DriversLicence? Licence { get; set; }
		public ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();

		public RegisteredUser()
		{

		}
	}
}
