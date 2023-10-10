using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DataAcess.Context;
using The_Movies.Entities;
using The_Movies.Repository;

namespace The_Movies.DataAcess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly The_MoviesDbContext _context;

        public UnitOfWork(The_MoviesDbContext context)
        {
            _context = context;
            Movie = new MovieRepository(_context);
            Genre = new GenreRepository(_context);

        }

        public IMovieRepository Movie { get; private set; }
        public IGenreRepository Genre { get; private set; }



        public int Save()
        {
            return _context.SaveChanges();

        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
