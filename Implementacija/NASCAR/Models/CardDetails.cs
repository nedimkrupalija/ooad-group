using System;


namespace NASCAR.Models
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class CardDetails
	{
		public int CardNumber { get; set; }
		public int CVV { get; set; }
		public DateTime dateOfExpiry { get; set; }

		public CardDetails()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
