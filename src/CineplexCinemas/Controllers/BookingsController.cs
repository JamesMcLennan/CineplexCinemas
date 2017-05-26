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
    public class BookingsController : Controller
    {
        private readonly CineplexDatabaseContext _context;
        private Cineplex cinema;
        private Movie film;
        private Session session;

        private int cinemaId;
        private int movieId;
        private int sessionId;

        private string name;

        public BookingsController(CineplexDatabaseContext context)
        {
            _context = context;    
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Booking.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,cineplxId,customerName,movieId,numberOfAdults,numberOfConc,sessionId")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,cineplxId,customerName,movieId,numberOfAdults,numberOfConc,sessionId")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.BookingId == id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BookingExists(int id)
        {
            return _context.Booking.Any(e => e.BookingId == id);
        }
        
        public IActionResult sessionDetails(int cineplexId, int movieId, int sessionId)
        {
            //Store Id's
            cinemaId = cineplexId;
            this.movieId = movieId;
            this.sessionId = sessionId;

            var cinemaList = _context.Cineplex.ToList();
            var movieList = _context.Movie.ToList();
            var sessionList = _context.Session.ToList();

            cinema = cinemaList.Find(e => e.CineplexId == cineplexId);
            film = movieList.Find(e => e.MovieId == movieId);
            session = sessionList.Find(e => e.SessionId == sessionId);

            if (cinema != null && film != null && session != null)
            {
                ViewData["CinemaId"] = cinemaId;
                ViewData["movieId"] = movieId;
                ViewData["sessionId"] = sessionId;
                ViewData["Location"] = cinema.Location;
                ViewData["Film"] = film.Title;
                ViewData["SessionTime"] = session.SessionDateTime.TimeOfDay.ToString();
                ViewData["SessionDate"] = session.SessionDateTime.Day + "/" + session.SessionDateTime.Month + "/" + session.SessionDateTime.Year;
            }
            return View();
        }

        [HttpPost]
        public IActionResult confirmationToCart(Booking booking)
        {
            var cartList = HttpContext.Session.GetSession<cartItem>("cartItem");
            if (cartList == null)
            {
                cartList = new List<cartItem>();
            }
            cartItem item = new cartItem();
            item.cineplxId = booking.cineplxId;
            item.movieId = booking.movieId;
            item.sessionId = booking.sessionId;
            cartList.Add(item);
            HttpContext.Session.SetSession("cartItem", cartList);
            
            return RedirectToAction("Index", "Cart");
        }
    }
}
