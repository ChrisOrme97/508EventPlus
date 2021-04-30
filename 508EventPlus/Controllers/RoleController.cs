using _508EventPlus.Data;
using _508EventPlus.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _508EventPlus.Controllers
{
    public class RoleController : Controller
    {
        EventsPlusContext _Context;
        public RoleController(EventsPlusContext context)
        {
            _Context = context;
        }
        // GET: Role List
        public IActionResult Index()
        {
            var Role = _Context.Roles.ToList();
            return View(Role);
        }

        // GET: Create Role for users 
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            _Context.Roles.Add(Role);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        // Deletes the Role for users
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Role = await _Context.Role
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Role == null)
            {
                return NotFound();
            }

            return View(Role);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = await _Context.Role.FindAsync(id);
            _Context.Role.Remove(role);
            await _Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleExists(int id)
        {
            return _Context.Role.Any(e => e.Id == id);
        }

    }
}
