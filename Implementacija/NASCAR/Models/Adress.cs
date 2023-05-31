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
		[DisplayName("Street number:")]
		public String? StreetNumber { get; set; }
		public String? City { get; set; }
		[DisplayName("Zip code:")]
		public int? ZipCode { get; set; }
		public Address()
		{
		}
	}

}
