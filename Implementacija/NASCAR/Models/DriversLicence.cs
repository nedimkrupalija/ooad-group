using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace NASCAR.Models
{

	public class DriversLicence
	{
		[Key]
		public int Id { get; set; }
		
		[DataType(DataType.Date)]
		[DisplayName("Date of expiry")]
		public string? ExpiryDate { get; set; }
		
		[DisplayName("B category")]
		public Boolean? HasBCategory { get; set; }

		public DriversLicence()
		{

		}
	}
}
