using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
