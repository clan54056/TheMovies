using Microsoft.EntityFrameworkCore;
using The_Movies.Entities;

namespace The_Movies.DataAcess.Context
{
    public class The_MovieManagementDbContext : DbContext
        {
            public The_MovieManagementDbContext(DbContextOptions<The_MovieManagementDbContext> options) : base(options) { }

            public DbSet<Movie> Movies => Set<Movie>();
            public DbSet<Genre> Genres => Set<Genre>();

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Movie>().HasData(
                    new Movie { MovieId = 1, Title = "Chuck Norris in Wonderland", Length = 8},
                    new Movie { MovieId = 2, Title = "Chuck Norris never dies", Length = 8}
                    );

                modelBuilder.Entity<Genre>().HasData(
                    new Genre { GenreId = 1, Name = "Not defined" },
                    new Genre { GenreId = 2, Name = "Chuck Norris has no genre" }
                    );
        }
        }
}
