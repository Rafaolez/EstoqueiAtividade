using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estoquei.Models;

namespace Estoquei.Controllers
{
    public class TipoMovimentacaController : Controller
    {
        private readonly Contexto _context;

        public TipoMovimentacaController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoMovimentaca
        public async Task<IActionResult> Index()
        {
              return _context.TipoMovimentacao != null ? 
                          View(await _context.TipoMovimentacao.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoMovimentacao'  is null.");
        }

        // GET: TipoMovimentaca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoMovimentacao == null)
            {
                return NotFound();
            }

            var tipoMovimentacao = await _context.TipoMovimentacao
                .FirstOrDefaultAsync(m => m.TipoMovimentacaoId == id);
            if (tipoMovimentacao == null)
            {
                return NotFound();
            }

            return View(tipoMovimentacao);
        }

        // GET: TipoMovimentaca/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoMovimentaca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoMovimentacaoId,NomeTipomovimentacao")] TipoMovimentacao tipoMovimentacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoMovimentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoMovimentacao);
        }

        // GET: TipoMovimentaca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoMovimentacao == null)
            {
                return NotFound();
            }

            var tipoMovimentacao = await _context.TipoMovimentacao.FindAsync(id);
            if (tipoMovimentacao == null)
            {
                return NotFound();
            }
            return View(tipoMovimentacao);
        }

        // POST: TipoMovimentaca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoMovimentacaoId,NomeTipomovimentacao")] TipoMovimentacao tipoMovimentacao)
        {
            if (id != tipoMovimentacao.TipoMovimentacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoMovimentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoMovimentacaoExists(tipoMovimentacao.TipoMovimentacaoId))
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
            return View(tipoMovimentacao);
        }

        // GET: TipoMovimentaca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoMovimentacao == null)
            {
                return NotFound();
            }

            var tipoMovimentacao = await _context.TipoMovimentacao
                .FirstOrDefaultAsync(m => m.TipoMovimentacaoId == id);
            if (tipoMovimentacao == null)
            {
                return NotFound();
            }

            return View(tipoMovimentacao);
        }

        // POST: TipoMovimentaca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoMovimentacao == null)
            {
                return Problem("Entity set 'Contexto.TipoMovimentacao'  is null.");
            }
            var tipoMovimentacao = await _context.TipoMovimentacao.FindAsync(id);
            if (tipoMovimentacao != null)
            {
                _context.TipoMovimentacao.Remove(tipoMovimentacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoMovimentacaoExists(int id)
        {
          return (_context.TipoMovimentacao?.Any(e => e.TipoMovimentacaoId == id)).GetValueOrDefault();
        }
    }
}
