using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevopsAsp.Entities;
using DevopsAsp.ORM;

namespace DevopsAsp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var DbContex = new MovieStoreContext())
            {
                DbContex.Movies.Add(new Movie()
                {
                    Genre = new Genre() {Category = "Drama"},
                    Title = "Hello World"
                });
                DbContex.SaveChanges();
            }
        }
    }
}