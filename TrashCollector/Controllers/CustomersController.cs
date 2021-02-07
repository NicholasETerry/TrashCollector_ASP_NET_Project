using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index(Customers customer)
        {
            
            var userId =  this.User.FindFirstValue(ClaimTypes.NameIdentifier);
             customer =  _context.CustomersTable.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (customer == null)
            {
                return RedirectToAction("Create");
            }
            return View(await _context.CustomersTable.Where(c => c.IdentityUserId == userId).ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.CustomersTable
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewBag.Days = pickupDayList();
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,City,ZipCode,EmailAddress,PaymentId,AmountOwed,CalendarId,ScheduledPickUp,SpecialPickUp,TempSuspendStart,TempSuspendEnd,IdentityUserId")] Customers customers)
        {
            if (ModelState.IsValid)

            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customers.IdentityUserId = userId;
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customers.IdentityUserId);
            return View(customers);
        }
        public List<SelectListItem> pickupDayList()
        {
            DateTime dateTime = DateTime.Now;
            string now = dateTime.ToString("dddd");
            List<SelectListItem> daysOfTheWeek = new List<SelectListItem>();
            SelectListItem Monday = new SelectListItem() { Text = "Monday", Value = "0", Selected = true };
            SelectListItem Tuesday = new SelectListItem() { Text = "Tuesday", Value = "1", Selected = false };
            SelectListItem Wednesday = new SelectListItem() { Text = "Wednesday", Value = "2", Selected = false };
            SelectListItem Thurday = new SelectListItem() { Text = "Thursday", Value = "3", Selected = false };
            SelectListItem Friday = new SelectListItem() { Text = "Friday", Value = "4", Selected = false };
            daysOfTheWeek.Add(Monday);
            daysOfTheWeek.Add(Tuesday);
            daysOfTheWeek.Add(Wednesday);
            daysOfTheWeek.Add(Thurday);
            daysOfTheWeek.Add(Friday);
            return daysOfTheWeek;
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.CustomersTable.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customers.IdentityUserId);
            return View(customers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,City,ZipCode,EmailAddress,PaymentId,AmountOwed,CalendarId,ScheduledPickUp,SpecialPickUp,TempSuspendStart,TempSuspendEnd,IdentityUserId")] Customers customers)
        {
            if (id != customers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customers.IdentityUserId);
            return View(customers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.CustomersTable
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.CustomersTable.FindAsync(id);
            _context.CustomersTable.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersExists(int id)
        {
            return _context.CustomersTable.Any(e => e.Id == id);
        }
    }
}
