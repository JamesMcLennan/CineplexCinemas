using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//add
using Microsoft.EntityFrameworkCore;
using CineplexApi.Data;
using CineplexApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CineplexCinemas.Controllers
{
    [Route("api/[controller]")]
    public class MovieManagerController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<Movie> Get()
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                return db.Movie.OrderBy(
                    i => i.MovieID).ToList();
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                return db.Movie.Where(
                    i => i.MovieID == id).SingleOrDefault();
            }

        }

        // POST(Add) api/values
        [HttpPost]
        public string Post([FromBody]Movie obj)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                
                db.Movie.Add(obj);
                db.SaveChanges();
                return "Movie added successfully!";
            }
        }

        // PUT(Modify) api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Movie obj)
        {

            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
                return "Movie modified successfully!";
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                var obj = db.Movie.Where(
                    i => i.MovieID == id).SingleOrDefault();
                db.Movie.Remove(obj);
                db.SaveChanges();
                return "Movie deleted successfully!";
            }
        }
    }
}
