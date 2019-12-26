using Microsoft.EntityFrameworkCore;
using AwsomeMovies.Models;

namespace AwsomeMovies.Data
{
    public class AwsomeMoviesContext : DbContext
    {
        public AwsomeMoviesContext(DbContextOptions<AwsomeMoviesContext> options):base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

    }
}
