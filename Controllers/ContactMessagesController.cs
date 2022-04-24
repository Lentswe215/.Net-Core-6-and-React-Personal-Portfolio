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
    public class ContactMessagesController : Controller
    {
        private readonly LenMamPortfolioContext _context;

        public ContactMessagesController(LenMamPortfolioContext context)
        {
            _context = context;
        }

        // GET: ContactMessages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactMessages.ToListAsync());
        }

        // GET: ContactMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessages = await _context.ContactMessages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactMessages == null)
            {
                return NotFound();
            }

            return View(contactMessages);
        }

        // GET: ContactMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FromFullName,MobileNumber,EmailAddress,Subject,Message,SenderIP")] ContactMessages contactMessages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactMessages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactMessages);
        }

        // GET: ContactMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessages = await _context.ContactMessages.FindAsync(id);
            if (contactMessages == null)
            {
                return NotFound();
            }
            return View(contactMessages);
        }

        // POST: ContactMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FromFullName,MobileNumber,EmailAddress,Subject,Message,SenderIP")] ContactMessages contactMessages)
        {
            if (id != contactMessages.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactMessages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactMessagesExists(contactMessages.Id))
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
            return View(contactMessages);
        }

        // GET: ContactMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactMessages = await _context.ContactMessages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactMessages == null)
            {
                return NotFound();
            }

            return View(contactMessages);
        }

        // POST: ContactMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactMessages = await _context.ContactMessages.FindAsync(id);
            _context.ContactMessages.Remove(contactMessages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactMessagesExists(int id)
        {
            return _context.ContactMessages.Any(e => e.Id == id);
        }
    }
}
