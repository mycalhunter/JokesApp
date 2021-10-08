using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JokesApp.Data;
using JokesApp.Models;

namespace JokesApp.Controllers
{
    public class DocumentationNotesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocumentationNotesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DocumentationNotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DocumentationNotes.ToListAsync());
        }

        // GET: DocumentationNotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentationNotes = await _context.DocumentationNotes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documentationNotes == null)
            {
                return NotFound();
            }

            return View(documentationNotes);
        }

        // GET: DocumentationNotes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocumentationNotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Example")] DocumentationNotes documentationNotes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documentationNotes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(documentationNotes);
        }

        // GET: DocumentationNotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentationNotes = await _context.DocumentationNotes.FindAsync(id);
            if (documentationNotes == null)
            {
                return NotFound();
            }
            return View(documentationNotes);
        }

        // POST: DocumentationNotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Example")] DocumentationNotes documentationNotes)
        {
            if (id != documentationNotes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documentationNotes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentationNotesExists(documentationNotes.Id))
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
            return View(documentationNotes);
        }

        // GET: DocumentationNotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var documentationNotes = await _context.DocumentationNotes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documentationNotes == null)
            {
                return NotFound();
            }

            return View(documentationNotes);
        }

        // POST: DocumentationNotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var documentationNotes = await _context.DocumentationNotes.FindAsync(id);
            _context.DocumentationNotes.Remove(documentationNotes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentationNotesExists(int id)
        {
            return _context.DocumentationNotes.Any(e => e.Id == id);
        }
    }
}
