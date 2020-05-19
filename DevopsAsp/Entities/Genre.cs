using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevopsAsp.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public String Category { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}