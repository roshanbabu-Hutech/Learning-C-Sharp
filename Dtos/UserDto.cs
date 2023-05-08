using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Dtos
{
	public class UserDto
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }

		public UserDto()
		{
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
