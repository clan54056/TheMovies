using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Entities;

namespace The_Movies.Repository
{
    public interface IUnitOfWork
    {
        public interface IUnitOfWork : IDisposable
        {
            IMovieRepository Movie { get; }
            IGenreRepository Genre { get; }

            int Save();
        }
    }
}
