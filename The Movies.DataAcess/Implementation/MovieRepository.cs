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
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(The_MovieManagementDbContext context) : base(context)
        {

        }
    }
}
