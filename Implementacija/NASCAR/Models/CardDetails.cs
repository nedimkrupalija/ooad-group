using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class CardDetails
	{
		[DataType(DataType.CreditCard)]
		[DisplayName("Card number:")]
		[Key]
		public int CardNumber { get; set; }
		public int? CVV { get; set; }
		[DataType(DataType.Date)]
		[DisplayName("Date of expiry:")]
		public string? DateOfExpiry { get; set; }
		
		public CardDetails()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
