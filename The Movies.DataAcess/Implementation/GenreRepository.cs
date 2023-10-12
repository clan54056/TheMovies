using The_Movies.DataAcess.Context;
using The_Movies.Entities;
using The_Movies.Repository;

namespace The_Movies.DataAcess.Implementation
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(The_MovieManagementDbContext context) : base(context)
        {

        }
    }
}
