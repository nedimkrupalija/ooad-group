using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
	public abstract class  User
	{
		[Key]
		public int Id { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public int? Age { get; set; }


		
	}
}
