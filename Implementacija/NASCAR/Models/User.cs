using System;

namespace NASCAR.Models
{
	public abstract class User
	{

		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int Age { get; set; }


		public User()
		{
		}
	}
}
