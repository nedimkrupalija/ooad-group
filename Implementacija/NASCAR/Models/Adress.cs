using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	public class Address
	{
		[Key]
		public int Id { get; set; }
		public String? StreetName { get; set; }
		public String? StreetNumber { get; set; }
		public String? City { get; set; }
		public int? ZipCode { get; set; }
		public Address()
		{
		}
	}

}
