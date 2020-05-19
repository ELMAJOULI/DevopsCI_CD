using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DevopsAsp.Entities;

namespace DevopsAsp.ORM
{
    public class MovieStoreContext : DbContext
    {
        public  DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MovieStoreContext() :base("Data Source=AK-107\\SQLEXPRESS;Initial Catalog=MovieStore;Integrated Security=True")
        {
            
        }
    }
}