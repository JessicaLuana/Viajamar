#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaViajamar.Models;

namespace AgenciaViajamar.Controllers
{
    public class DestinosController : Controller
    {
        private readonly Context _context;

        public DestinosController(Context context)
        {
            _context = context;
        }

        // GET: Destinos
        public async Task<IActionResult> Index()
        {
            return View(await _context.destinos.ToListAsync());
        }

        // GET: Destinos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinos = await _context.destinos
                .FirstOrDefaultAsync(m => m.id == id);
            if (destinos == null)
            {
                return NotFound();
            }

            return View(destinos);
        }

        // GET: Destinos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destinos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,local,quantidade")] Destinos destinos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destinos);
        }

        // GET: Destinos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinos = await _context.destinos.FindAsync(id);
            if (destinos == null)
            {
                return NotFound();
            }
            return View(destinos);
        }

        // POST: Destinos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,local,quantidade")] Destinos destinos)
        {
            if (id != destinos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destinos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinosExists(destinos.id))
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
            return View(destinos);
        }

        // GET: Destinos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinos = await _context.destinos
                .FirstOrDefaultAsync(m => m.id == id);
            if (destinos == null)
            {
                return NotFound();
            }

            return View(destinos);
        }

        // POST: Destinos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destinos = await _context.destinos.FindAsync(id);
            _context.destinos.Remove(destinos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinosExists(int id)
        {
            return _context.destinos.Any(e => e.id == id);
        }
    }
}
