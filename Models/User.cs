using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[Required]
		public string Name { get; set; } = "";
		[Required]
		public string Email { get; set; } = "";
		[Required]
		public string Password { get; set; } = "";

		//public User()
		//{
		//	if(Name == null)
		//	{
		//		Name = "";
		//	}
		//	if(Email == null)
		//	{
		//		Email = "";
		//	}
		//	if (Password == null)
		//	{
		//		Password = "";
		//	}
		//}
	}
}
