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
        private int items = 0;
        public IActionResult Index()
        {
            var context = HttpContext.Session.GetSession<cartItem>("cartItem");
            if (context == null)
            {
                return View();
            }
            foreach (var item in context)
            {
                if(items == 0)
                {
                    items++;
                    ViewBag.LocationId = item.cineplxId;
                    ViewBag.MovieID = item.movieId;
                    ViewBag.SessionID = item.sessionId;
                }
                else if(items == 1)
                {
                    ViewBag.LocationId1 = item.cineplxId;
                    ViewBag.MovieID1 = item.movieId;
                    ViewBag.SessionID1 = item.sessionId;
                }
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
