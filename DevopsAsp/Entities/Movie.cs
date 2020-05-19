using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevopsAsp.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public String Title { get; set; }
        private Double Duration { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public Genre  Genre { get; set; }
    }
}