using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class database : DbContext
    {
        public database(DbContextOptions<database> options) : base(options)
        {

        }
           public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Rakul Preet Singh", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Natasha Malkova", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Candy love", DisplayOrder = 3 }
                );
        }
    }
    }

