using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Models
{
	public class UserDetails
	{
		[Key]
		public int UserId { get; set; }
		public string? UserName { get; set; } 
		public string? UserEmail { get; set; }
		public string? CompanyName { get; set; }
		public string? Profession { get; set; }
		public int Salary { get; set; }
	}
}
