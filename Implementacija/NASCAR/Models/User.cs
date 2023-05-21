using System;

public abstract class User
{
	int userId;
	string username;
	string password;
	int age;

	public int UserId { get { return userId; } set { userId = value; } }
	public string UserName { get { return username; } set { username = value; } }
	public string Password { get { return password; } set { password = value; } }

	public int Age { get { return age; } set { age = value; } }	
    public User(int userId, string username, string password, int age)
    {
		this.userId = userId;
		this.username = username;
		this.password = password;
		this.age = age;
    }
}
