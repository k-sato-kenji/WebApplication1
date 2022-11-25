using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class salariesController : Controller
    {
        private readonly WebApplication1Context _context;

        public salariesController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: salaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.salary.ToListAsync());
        }

        // GET: salaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.salary
                .FirstOrDefaultAsync(m => m.id == id);
            if (salary == null)
            {
                return NotFound();
            }

            return View(salary);
        }

        // GET: salaries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: salaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,beneficiary,paymenttype,paymentdate,paymentamount,travelexpence,healthinsurancepremium,welfarepension,employmentinsurancepremium,incometax,residenttax,totalpaymentamount,overtimeallowance,midnightallowance,holidayallowance,remarks")] salary salary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salary);
        }

        // GET: salaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.salary.FindAsync(id);
            if (salary == null)
            {
                return NotFound();
            }
            return View(salary);
        }

        // POST: salaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,beneficiary,paymenttype,paymentdate,paymentamount,travelexpence,healthinsurancepremium,welfarepension,employmentinsurancepremium,incometax,residenttax,totalpaymentamount,overtimeallowance,midnightallowance,holidayallowance,remarks")] salary salary)
        {
            if (id != salary.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!salaryExists(salary.id))
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
            return View(salary);
        }

        // GET: salaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.salary
                .FirstOrDefaultAsync(m => m.id == id);
            if (salary == null)
            {
                return NotFound();
            }

            return View(salary);
        }

        // POST: salaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salary = await _context.salary.FindAsync(id);
            _context.salary.Remove(salary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool salaryExists(int id)
        {
            return _context.salary.Any(e => e.id == id);
        }
    }
}
