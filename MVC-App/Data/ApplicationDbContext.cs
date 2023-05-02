using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Category>Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(
				new Category {Id = 1, Name = "Roshan Shaik", CategoryId = 1},
				new Category { Id = 2, Name = "Rakul Preet Singh", CategoryId = 2 },
				new Category { Id = 3, Name = "Natasha Malkova", CategoryId = 3 });
		}
	}
}
