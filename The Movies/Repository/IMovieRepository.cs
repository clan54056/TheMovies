using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Entities;

namespace The_Movies.Repository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
