using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cineplex.Models;
using CineplexCinemas.Models;

namespace CineplexCinemas.Controllers
{
    public class CineplexSitesController : Controller
    {
        private readonly CineplexCinemasContext _context;

        public CineplexSitesController(CineplexCinemasContext context)
        {
            _context = context;    
        }

        // GET: CineplexSites
        public async Task<IActionResult> Index()
        {
            return View(await _context.CineplexSite.ToListAsync());
        }

        // GET: CineplexSites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cineplexSite = await _context.CineplexSite.SingleOrDefaultAsync(m => m.CineplexId == id);
            if (cineplexSite == null)
            {
                return NotFound();
            }

            return View(cineplexSite);
        }

        // GET: CineplexSites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CineplexSites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CineplexId,ImageUrl,Location,LongDescription,ShortDescription")] CineplexSite cineplexSite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cineplexSite);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cineplexSite);
        }

        // GET: CineplexSites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cineplexSite = await _context.CineplexSite.SingleOrDefaultAsync(m => m.CineplexId == id);
            if (cineplexSite == null)
            {
                return NotFound();
            }
            return View(cineplexSite);
        }

        // POST: CineplexSites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CineplexId,ImageUrl,Location,LongDescription,ShortDescription")] CineplexSite cineplexSite)
        {
            if (id != cineplexSite.CineplexId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cineplexSite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CineplexSiteExists(cineplexSite.CineplexId))
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
            return View(cineplexSite);
        }

        // GET: CineplexSites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cineplexSite = await _context.CineplexSite.SingleOrDefaultAsync(m => m.CineplexId == id);
            if (cineplexSite == null)
            {
                return NotFound();
            }

            return View(cineplexSite);
        }

        // POST: CineplexSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cineplexSite = await _context.CineplexSite.SingleOrDefaultAsync(m => m.CineplexId == id);
            _context.CineplexSite.Remove(cineplexSite);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CineplexSiteExists(int id)
        {
            return _context.CineplexSite.Any(e => e.CineplexId == id);
        }
    }
}
