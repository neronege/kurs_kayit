using efocoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace efocoreApp.Controllers
{
    public class CourseRecordController : Controller
    {
        private readonly DataContext _context;
        public CourseRecordController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var kurskayit = await _context.CourseRecords
                                  .Include(x => x.course)
                                  .Include(x => x.student)
                                  .ToListAsync();
            return View(kurskayit);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Students = new SelectList(await _context.Students.ToListAsync(), "StudentId", "FullName");
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "CourseId", "Title");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseRecord model)
        {
            _context.CourseRecords.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}