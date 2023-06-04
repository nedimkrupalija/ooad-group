using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	public class Address
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Street name:")]
		public String? StreetName { get; set; }
		public String? City { get; set; }
		
		public ICollection<Vehicle>? Vehicles { get; set; }

		

		public Address()
		{
		}
	}

}
