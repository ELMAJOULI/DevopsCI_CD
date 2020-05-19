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

        public MovieStoreContext() :base("Server=tcp:devopunittest.database.windows.net,1433;Initial Catalog=MovieStore;Persist Security Info=False;User ID=moviestore;Password=Mrabdelwahed1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            
        }
    }
}