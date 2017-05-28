﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//add
using Microsoft.EntityFrameworkCore;
using CineplexApi.Data;
using CineplexApi.Models;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CineplexApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerEventController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<Enquiry> Get()
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                return db.Enquiries.OrderBy(
                    i => i.EnquiryID).ToList();
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Enquiry Get(int id)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                return db.Enquiries.Where(
                    i => i.EnquiryID == id).SingleOrDefault();
            }

        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Enquiry obj)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                db.Enquiries.Add(obj);
                db.SaveChanges();
                return "Enquiry added successfully!";
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Enquiry obj)
        {

            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
                return "Enquiry modified successfully!";
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (CineplexDatabaseContext db = new CineplexDatabaseContext())
            {
                var obj = db.Enquiries.Where(
                    i => i.EnquiryID == id).SingleOrDefault();
                db.Enquiries.Remove(obj);
                db.SaveChanges();
                return "Enquiry deleted successfully!";
            }
        }
    }
}
