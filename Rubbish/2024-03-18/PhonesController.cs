using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtFusionStudio.Data;
using ArtFusionStudio.Models;
using ArtFusionStudio.Models.ProductFeatures;
using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Physical;
using ArtFusionStudio.Models.ProductFeatures.PhoneFeatures.Virtual;

namespace ArtFusionStudio.Controllers
{
    public class PhonesController : Controller
    {
        private readonly ArtFusionStudioContext _context;

        public PhonesController(ArtFusionStudioContext context)
        {
            _context = context;
        }

        // GET: Phones
        public async Task<IActionResult> Index()
        {
            var artFusionStudioContext = _context.Phone.Include(p => p.Brand).Include(p => p.Category).Include(p => p.Ratings).Include(p => p.Camera).Include(p => p.DisplayTechnology).Include(p => p.Memory).Include(p => p.OSNameAndVersion).Include(p => p.StorageCapacity).Include(p => p.USB);
            return View(await artFusionStudioContext.ToListAsync());
        }

        // GET: Phones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Ratings)
                .Include(p => p.Camera)
                .Include(p => p.DisplayTechnology)
                .Include(p => p.Memory)
                .Include(p => p.OSNameAndVersion)
                .Include(p => p.StorageCapacity)
                .Include(p => p.USB)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // GET: Phones/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Set<Brand>(), "Id", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name");
            ViewData["RatingId"] = new SelectList(_context.Set<Ratings>(), "Id", "Review");
            ViewData["CameraId"] = new SelectList(_context.Set<Camera>(), "Id", "Id");
            ViewData["CameraId"] = new SelectList(_context.Set<DisplayTechnology>(), "Id", "Name");
            ViewData["CameraId"] = new SelectList(_context.Set<Memory>(), "Id", "Id");
            ViewData["OSNameAndVersionId"] = new SelectList(_context.Set<OSNameAndVersion>(), "Id", "Id");
            ViewData["CameraId"] = new SelectList(_context.Set<StorageCapacity>(), "Id", "Id");
            ViewData["USBId"] = new SelectList(_context.Set<USB>(), "Id", "Type");
            return View();
        }

        // POST: Phones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CameraId,DisplayTechnologyId,MemoryId,StorageCapacityId,USBId,OSNameAndVersionId,Id,Name,Description,CategoryId,BrandId,RatingId")] Phone phone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Set<Brand>(), "Id", "Name", phone.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name", phone.CategoryId);
            ViewData["RatingId"] = new SelectList(_context.Set<Ratings>(), "Id", "Review", phone.RatingId);
            ViewData["CameraId"] = new SelectList(_context.Set<Camera>(), "Id", "Id", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<DisplayTechnology>(), "Id", "Name", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<Memory>(), "Id", "Id", phone.CameraId);
            ViewData["OSNameAndVersionId"] = new SelectList(_context.Set<OSNameAndVersion>(), "Id", "Id", phone.OSNameAndVersionId);
            ViewData["CameraId"] = new SelectList(_context.Set<StorageCapacity>(), "Id", "Id", phone.CameraId);
            ViewData["USBId"] = new SelectList(_context.Set<USB>(), "Id", "Type", phone.USBId);
            return View(phone);
        }

        // GET: Phones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone.FindAsync(id);
            if (phone == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Set<Brand>(), "Id", "Name", phone.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name", phone.CategoryId);
            ViewData["RatingId"] = new SelectList(_context.Set<Ratings>(), "Id", "Review", phone.RatingId);
            ViewData["CameraId"] = new SelectList(_context.Set<Camera>(), "Id", "Id", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<DisplayTechnology>(), "Id", "Name", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<Memory>(), "Id", "Id", phone.CameraId);
            ViewData["OSNameAndVersionId"] = new SelectList(_context.Set<OSNameAndVersion>(), "Id", "Id", phone.OSNameAndVersionId);
            ViewData["CameraId"] = new SelectList(_context.Set<StorageCapacity>(), "Id", "Id", phone.CameraId);
            ViewData["USBId"] = new SelectList(_context.Set<USB>(), "Id", "Type", phone.USBId);
            return View(phone);
        }

        // POST: Phones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CameraId,DisplayTechnologyId,MemoryId,StorageCapacityId,USBId,OSNameAndVersionId,Id,Name,Description,CategoryId,BrandId,RatingId")] Phone phone)
        {
            if (id != phone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneExists(phone.Id))
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
            ViewData["BrandId"] = new SelectList(_context.Set<Brand>(), "Id", "Name", phone.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name", phone.CategoryId);
            ViewData["RatingId"] = new SelectList(_context.Set<Ratings>(), "Id", "Review", phone.RatingId);
            ViewData["CameraId"] = new SelectList(_context.Set<Camera>(), "Id", "Id", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<DisplayTechnology>(), "Id", "Name", phone.CameraId);
            ViewData["CameraId"] = new SelectList(_context.Set<Memory>(), "Id", "Id", phone.CameraId);
            ViewData["OSNameAndVersionId"] = new SelectList(_context.Set<OSNameAndVersion>(), "Id", "Id", phone.OSNameAndVersionId);
            ViewData["CameraId"] = new SelectList(_context.Set<StorageCapacity>(), "Id", "Id", phone.CameraId);
            ViewData["USBId"] = new SelectList(_context.Set<USB>(), "Id", "Type", phone.USBId);
            return View(phone);
        }

        // GET: Phones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phone
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Ratings)
                .Include(p => p.Camera)
                .Include(p => p.DisplayTechnology)
                .Include(p => p.Memory)
                .Include(p => p.OSNameAndVersion)
                .Include(p => p.StorageCapacity)
                .Include(p => p.USB)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // POST: Phones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phone = await _context.Phone.FindAsync(id);
            if (phone != null)
            {
                _context.Phone.Remove(phone);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhoneExists(int id)
        {
            return _context.Phone.Any(e => e.Id == id);
        }
    }
}
