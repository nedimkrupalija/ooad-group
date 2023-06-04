using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
		public string CardNumber { get; set; }
		public int? CVV { get; set; }
		[DataType(DataType.Date)]
		[DisplayName("Date of expiry:")]
		public string? DateOfExpiry { get; set; }
		
		[ForeignKey("RegisteredUser")]
		[DisplayName("User")]
		public string RegisteredUserId { get; set; }
		public RegisteredUser RegisteredUser { get; set; }

		public CardDetails()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
