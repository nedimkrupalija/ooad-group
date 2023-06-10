using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	public class VehicleAddress
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Street name:")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No digits allowed!")]
		public string StreetName { get; set; }
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No digits allowed!")]
		public string City { get; set; }
		


		public VehicleAddress()
		{
		}
	}

}
