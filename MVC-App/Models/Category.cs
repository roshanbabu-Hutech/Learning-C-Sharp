using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		public int CategoryId { get; set; }
	}
}
