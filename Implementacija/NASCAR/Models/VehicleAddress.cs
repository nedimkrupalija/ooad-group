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
		public string StreetName { get; set; }
		public string City { get; set; }
		


		public VehicleAddress()
		{
		}
	}

}
