#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LenMamPortfolio.Data;
using LenMamPortfolio.Models;

namespace LenMamPortfolio.Controllers
{
    public class ContentPagesController : Controller
    {
        private readonly LenMamPortfolioContext _context;

        public ContentPagesController(LenMamPortfolioContext context)
        {
            _context = context;
        }

        // GET: ContentPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContentPages.ToListAsync());
        }

        // GET: ContentPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentPages = await _context.ContentPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contentPages == null)
            {
                return NotFound();
            }

            return View(contentPages);
        }

        // GET: ContentPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContentPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,PageType,MetaData,LastModified,ModifiedBy,IsDeleted")] ContentPages contentPages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contentPages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contentPages);
        }

        // GET: ContentPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentPages = await _context.ContentPages.FindAsync(id);
            if (contentPages == null)
            {
                return NotFound();
            }
            return View(contentPages);
        }

        // POST: ContentPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,PageType,MetaData,LastModified,ModifiedBy,IsDeleted")] ContentPages contentPages)
        {
            if (id != contentPages.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contentPages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentPagesExists(contentPages.Id))
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
            return View(contentPages);
        }

        // GET: ContentPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentPages = await _context.ContentPages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contentPages == null)
            {
                return NotFound();
            }

            return View(contentPages);
        }

        // POST: ContentPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contentPages = await _context.ContentPages.FindAsync(id);
            _context.ContentPages.Remove(contentPages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentPagesExists(int id)
        {
            return _context.ContentPages.Any(e => e.Id == id);
        }
    }
}
