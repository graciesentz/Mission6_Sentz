using Microsoft.EntityFrameworkCore;

namespace Mission6_Sentz.Models
{
    public class AddMovieFormContext : DbContext
    {
        public AddMovieFormContext(DbContextOptions<AddMovieFormContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Form> Movies { get; set; }
    }
}
