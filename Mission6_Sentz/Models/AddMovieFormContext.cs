using Microsoft.EntityFrameworkCore;

namespace Mission6_Sentz.Models
{
    public class AddMovieFormContext : DbContext // Liaison from the app to the database
    {
        public AddMovieFormContext(DbContextOptions<AddMovieFormContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<CategoryInst> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed data
        {
            modelBuilder.Entity<CategoryInst>().HasData(
                
                new CategoryInst { CategoryId = 1, Category = "Miscellaneous" },
                new CategoryInst { CategoryId = 2, Category = "Drama" },
                new CategoryInst { CategoryId = 3, Category = "Television" },
                new CategoryInst { CategoryId = 4, Category = "Horror/Suspense" },
                new CategoryInst { CategoryId = 5, Category = "Comedy" },
                new CategoryInst { CategoryId = 6, Category = "Family" },
                new CategoryInst { CategoryId = 7, Category = "Action/Adventure" },
                new CategoryInst { CategoryId = 8, Category = "VHS" }

                );
        }
    }
}
