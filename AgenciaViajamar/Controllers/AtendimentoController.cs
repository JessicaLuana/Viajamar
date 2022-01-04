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
    public class AtendimentoController : Controller
    {
        private readonly Context _context;

        public AtendimentoController(Context context)
        {
            _context = context;
        }

        // GET: Atendimento
        public async Task<IActionResult> Index()
        {
            return View(await _context.atendimento.ToListAsync());
        }

        // GET: Atendimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atendimento = await _context.atendimento
                .FirstOrDefaultAsync(m => m.id == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // GET: Atendimento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atendimento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,telefone,email,mensagem")] Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atendimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atendimento);
        }

        // GET: Atendimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atendimento = await _context.atendimento.FindAsync(id);
            if (atendimento == null)
            {
                return NotFound();
            }
            return View(atendimento);
        }

        // POST: Atendimento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,telefone,email,mensagem")] Atendimento atendimento)
        {
            if (id != atendimento.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atendimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtendimentoExists(atendimento.id))
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
            return View(atendimento);
        }

        // GET: Atendimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atendimento = await _context.atendimento
                .FirstOrDefaultAsync(m => m.id == id);
            if (atendimento == null)
            {
                return NotFound();
            }

            return View(atendimento);
        }

        // POST: Atendimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var atendimento = await _context.atendimento.FindAsync(id);
            _context.atendimento.Remove(atendimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtendimentoExists(int id)
        {
            return _context.atendimento.Any(e => e.id == id);
        }
    }
}
