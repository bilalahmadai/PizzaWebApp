using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaWebApp.Data;
using PizzaWebApp.Models;

namespace PizzaWebApp.Controllers
{
    public class CheffsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheffsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cheffs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cheff.ToListAsync());
        }

        // GET: Cheffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheff = await _context.Cheff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cheff == null)
            {
                return NotFound();
            }

            return View(cheff);
        }

        // GET: Cheffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cheffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cheff_name")] Cheff cheff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cheff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cheff);
        }

        // GET: Cheffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheff = await _context.Cheff.FindAsync(id);
            if (cheff == null)
            {
                return NotFound();
            }
            return View(cheff);
        }

        // POST: Cheffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cheff_name")] Cheff cheff)
        {
            if (id != cheff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cheff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheffExists(cheff.Id))
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
            return View(cheff);
        }

        // GET: Cheffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheff = await _context.Cheff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cheff == null)
            {
                return NotFound();
            }

            return View(cheff);
        }

        // POST: Cheffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cheff = await _context.Cheff.FindAsync(id);
            _context.Cheff.Remove(cheff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheffExists(int id)
        {
            return _context.Cheff.Any(e => e.Id == id);
        }
    }
}
