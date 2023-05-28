using System;

using System.ComponentModel.DataAnnotations;
namespace NASCAR.Models
{

	public class DriversLicence
	{
		[Key]
		public int Id { get; set; }
		public string? ExpiryDate { get; set; }
		public Boolean? HasBCategory { get; set; }

		public DriversLicence()
		{

		}
	}
}
