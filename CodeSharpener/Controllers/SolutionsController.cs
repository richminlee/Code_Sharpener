using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeSharpener.Models;

namespace CodeSharpener.Controllers
{
    public class SolutionsController : Controller
    {
        private readonly CodeSharpenerContext _context;

        public SolutionsController(CodeSharpenerContext context)
        {
            _context = context;
        }

        // GET: Solutions
        [HttpGet("/solutions/index")]
        public async Task<IActionResult> Index()
        {
            var codeSharpenerContext = _context.Solution.Include(s => s.Challenge).Include(s => s.User);
            return View(await codeSharpenerContext.ToListAsync());
        }

        // GET: Solutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solution = await _context.Solution
                .Include(s => s.Challenge)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solution == null)
            {
                return NotFound();
            }

            return View(solution);
        }

        // GET: Solutions/Create
        public IActionResult Create()
        {
            ViewData["ChallengeId"] = new SelectList(_context.Challenge, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ChallengeId,UserId")] Solution solution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChallengeId"] = new SelectList(_context.Challenge, "Id", "Id", solution.ChallengeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", solution.UserId);
            return View(solution);
        }

        // GET: Solutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solution = await _context.Solution.FindAsync(id);
            if (solution == null)
            {
                return NotFound();
            }
            ViewData["ChallengeId"] = new SelectList(_context.Challenge, "Id", "Id", solution.ChallengeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", solution.UserId);
            return View(solution);
        }

        // POST: Solutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ChallengeId,UserId")] Solution solution)
        {
            if (id != solution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolutionExists(solution.Id))
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
            ViewData["ChallengeId"] = new SelectList(_context.Challenge, "Id", "Id", solution.ChallengeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", solution.UserId);
            return View(solution);
        }

        // GET: Solutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solution = await _context.Solution
                .Include(s => s.Challenge)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solution == null)
            {
                return NotFound();
            }

            return View(solution);
        }

        // POST: Solutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solution = await _context.Solution.FindAsync(id);
            _context.Solution.Remove(solution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolutionExists(int id)
        {
            return _context.Solution.Any(e => e.Id == id);
        }
    }
}
