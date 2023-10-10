using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Entities;

namespace The_Movies.DataAcess.Context
{
        public class The_MoviesDbContext : DbContext
        {
            public The_MoviesDbContext(DbContextOptions<The_MoviesDbContext> options) : base(options) { }

            public DbSet<Movie> Movies { get; set; }
            public DbSet<Genre> Genres { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Movie>().HasData(
                    new Movie { Id = 1, Title = "Chuck Norris in Wonderland", Length = 8},
                    new Movie { Id = 2, Title = "Chuck Norris never dies", Length = 8}
                    );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Not defined" },
                new Genre { GenreId = 2, Name = "Chuck Norris has no genre" }
                );
        }
        }
}
