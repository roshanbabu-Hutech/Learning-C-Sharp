﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Dtos
{
	public class UserDetailsDto
	{
		[Required]
		public string? UserName { get; set; }
		[Required]
		public string? CompanyName { get; set; }
		[Required]
		public string? Profession { get; set; }
	}
}
