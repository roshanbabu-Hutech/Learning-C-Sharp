using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Dtos
{
	public class UserDto
	{
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }

		public UserDto()
		{
			if (Name == null)
			{
				Name = "";
			}
			if (Email == null)
			{
				Email = "";
			}
			if (Password == null)
			{
				Password = "";
			}
		}
	}
}
