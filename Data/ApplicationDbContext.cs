using Microsoft.EntityFrameworkCore;
using WebApplication13.Models;

namespace WebApplication13.Data
{
	public class ApplicationDbContext : DbContext
	{
		public readonly IConfiguration _config;
		public ApplicationDbContext(IConfiguration config)
		{
			_config = config;
		}
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserDetails> UsersDetails { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
				optionsBuilder => optionsBuilder.EnableRetryOnFailure());
				Console.WriteLine("Connection to the database established successfully");
				string? token = _config.GetSection("TokenKey").Value;
				Console.WriteLine(token);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("facebook");
			modelBuilder.Entity<User>()
			.ToTable("users", "facebook")
			.HasKey(t => t.UserId);
			Console.WriteLine("User Table succussfully created");

			modelBuilder.HasDefaultSchema("facebook");
			modelBuilder.Entity<UserDetails>()
				.ToTable("User Details", "facebook")
				.HasKey(t => t.UserId);
			Console.WriteLine("User Details Table created Succussfully");
		}

	}
}
