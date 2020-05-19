using System;
using System.Linq;
using DevopsAsp.Entities;
using DevopsAsp.ORM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevopsAsp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMovie_UnitTest()
        {
            //Arrange :
            var genre = new Genre
            {
                Category = "Action"
            };
            var movie = new Movie
            {
                Genre = genre,
                Title = "Avatar"
            };
            Movie movieTest;
            //Act
            using (var DbStore = new MovieStoreContext())
            {
                 movieTest = DbStore.Movies.Add(movie);
                DbStore.SaveChanges();
                
            }
            //assert :
            Assert.IsTrue(movieTest.Title == movie.Title);

        }
    }
}
