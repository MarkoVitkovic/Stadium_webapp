using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stadium_webapp.Models;
using Stadium_webapp.Models.Stadiums;

namespace Stadium_webapp.Controllers
{
    public class stadiumsController : Controller
    {
        private readonly stadiumsContext _context;

        public stadiumsController(stadiumsContext context)
        {
            _context = context;
        }

        // GET: stadiums
        public async Task<IActionResult> Index()
        {
            return View(await _context.stadiums.ToListAsync());
        }

        // GET: stadiums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stadiums = await _context.stadiums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stadiums == null)
            {
                return NotFound();
            }

            return View(stadiums);
        }

        // GET: stadiums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: stadiums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ClubName,TicketPrice,Capacity")] stadiums stadiums)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stadiums);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stadiums);
        }

        // GET: stadiums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stadiums = await _context.stadiums.FindAsync(id);
            if (stadiums == null)
            {
                return NotFound();
            }
            return View(stadiums);
        }

        // POST: stadiums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ClubName,TicketPrice,Capacity")] stadiums stadiums)
        {
            if (id != stadiums.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stadiums);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!stadiumsExists(stadiums.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stadiums);
        }

        // GET: stadiums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stadiums = await _context.stadiums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stadiums == null)
            {
                return NotFound();
            }

            return View(stadiums);
        }

        // POST: stadiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stadiums = await _context.stadiums.FindAsync(id);
            _context.stadiums.Remove(stadiums);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool stadiumsExists(int id)
        {
            return _context.stadiums.Any(e => e.Id == id);
        }
		
	}
}
