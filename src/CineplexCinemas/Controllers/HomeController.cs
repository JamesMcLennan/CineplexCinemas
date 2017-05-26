using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CineplexCinemas.Models;

namespace CineplexCinemas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = HttpContext.Session.GetSession<Booking>("cartItem");
            if (context != null)
            {
                ViewBag.LocationId = context.cineplxId;
                ViewBag.MovieID = context.movieId;
                ViewBag.SessionID = context.sessionId;
                ViewBag.numberOfAdults = HttpContext.Session.GetInt32("numberOfAdults");
                ViewBag.numberOfConc = HttpContext.Session.GetInt32("numberOfConc");
                ViewBag.CustomerName = HttpContext.Session.GetString("CustomerName");
            }
            return View();
        }

        public IActionResult Cinemas()
        {
            ViewData["Message"] = "Your Cinemas page.";

            return View();
        }

        public IActionResult Events()
        {
            ViewData["Message"] = "Private Hire";

            return View();
        }

        public IActionResult Movies()
        {
            ViewData["Message"] = "Your Movies page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
