using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class CardDetails
	{
		[Key]
		public int CardNumber { get; set; }
		public int? CVV { get; set; }
		public string? dateOfExpiry { get; set; }

		public CardDetails()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
