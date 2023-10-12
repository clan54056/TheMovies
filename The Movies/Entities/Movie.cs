using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Length { get; set; }
        public List<Genre>? Genres { get; set; }
    }
}
