using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CineplexCinemas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;


namespace CineplexCinemas.Controllers
{
    public class CartController : Controller
    {
        private int items = 0;
        public IActionResult Index()
        {
            var context = HttpContext.Session.GetSession<cartItem>("cartItem");
            if (context == null)
            {
                items = 0;
                return View();
            }
            foreach (var item in context)
            {
                if (items == 0)
                {
                    items++;
                    ViewBag.LocationId = item.cineplxId;
                    ViewBag.MovieID = item.movieId;
                    ViewBag.SessionID = item.sessionId;
                }
                else if (items == 1)
                {
                    items++;
                    ViewBag.LocationId1 = item.cineplxId;
                    ViewBag.MovieID1 = item.movieId;
                    ViewBag.SessionID1 = item.sessionId;
                }
                else if(items == 2)
                {
                    items++;
                    ViewBag.LocationId2 = item.cineplxId;
                    ViewBag.MovieID2 = item.movieId;
                    ViewBag.SessionID2 = item.sessionId;
                }
                else if (items == 3)
                {
                    items++;
                    ViewBag.LocationId3 = item.cineplxId;
                    ViewBag.MovieID3 = item.movieId;
                    ViewBag.SessionID3 = item.sessionId;
                }
                else if (items == 4)
                {
                    items++;
                    ViewBag.LocationId4 = item.cineplxId;
                    ViewBag.MovieID4 = item.movieId;
                    ViewBag.SessionID4 = item.sessionId;
                }
            }
            return View();
        }
    }
}
