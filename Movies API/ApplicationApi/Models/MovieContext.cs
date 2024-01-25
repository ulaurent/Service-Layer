using Microsoft.EntityFrameworkCore;

namespace ApplicationApi.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        // Entity set --> database table 
        // Entity --> row within a table
        public DbSet<Movie> Movies { get; set; } = null;
    }
}
