using _508EventPlus.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Controllers
{
    public class BookingsController : Controller
    {
        private readonly EventsPlusContext _context;

        public BookingsController(EventsPlusContext context)
        {
            _context = context;
        }

        // GET: Events
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var @event = from e in _context.Events
                         select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                @event = @event.Where(s => s.Venue.Contains(searchString));
            }

            return View(await @event.ToListAsync());
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }
       

    }
}
