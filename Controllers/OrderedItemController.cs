using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NerdCraft.Models;

namespace NerdCraft.Controllers
{
    [Route("api/OrderedItem")]
    public class OrderedItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderedItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: OrderedItem
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ordereditems.Include(o => o.Item).Include(o => o.Order);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrderedItem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordereditem = await _context.ordereditems
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (ordereditem == null)
            {
                return NotFound();
            }

            return View(ordereditem);
        }

        // GET: OrderedItem/Create
        [HttpPost]
        public IActionResult Create()
        {
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category");
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail");
            return View();
        }

        // POST: OrderedItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,ItemID,Quantity")] ordereditem ordereditem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordereditem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", ordereditem.ItemID);
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", ordereditem.OrderID);
            return View(ordereditem);
        }

        // GET: OrderedItem/Edit/5
        [HttpPut]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordereditem = await _context.ordereditems.FindAsync(id);
            if (ordereditem == null)
            {
                return NotFound();
            }
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", ordereditem.ItemID);
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", ordereditem.OrderID);
            return View(ordereditem);
        }

        // POST: OrderedItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,ItemID,Quantity")] ordereditem ordereditem)
        {
            if (id != ordereditem.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordereditem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ordereditemExists(ordereditem.OrderID))
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
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", ordereditem.ItemID);
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", ordereditem.OrderID);
            return View(ordereditem);
        }

        // GET: OrderedItem/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordereditem = await _context.ordereditems
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (ordereditem == null)
            {
                return NotFound();
            }

            return View(ordereditem);
        }

        // POST: OrderedItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordereditem = await _context.ordereditems.FindAsync(id);
            _context.ordereditems.Remove(ordereditem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ordereditemExists(int id)
        {
            return _context.ordereditems.Any(e => e.OrderID == id);
        }
    }
}
