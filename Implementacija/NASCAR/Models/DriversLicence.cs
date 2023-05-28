using System;

namespace NASCAR.Models
{

	public class DriversLicence
	{
		public int Id { get; set; }
		public DateTime ExpiryDate { get; set; }
		public Boolean HasBCategory { get; set; }

		public DriversLicence()
		{

		}
	}
}
