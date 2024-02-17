using Microsoft.EntityFrameworkCore;

namespace Mission6_Sentz.Models
{
    public class AddMovieFormContext : DbContext // Liaison from the app to the database
    {
        public AddMovieFormContext(DbContextOptions<AddMovieFormContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Form> Movies { get; set; }
    }
}
