using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VcRequestController : Controller
    {
        private readonly AppDbContext _context;


        public VcRequestController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult>  Index()
        {
            var vacancy = await _context.VacancyRequests.ToListAsync();
            return View(vacancy);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.VacancyRequests.FindAsync(id);
            if (delete == null) return NotFound();

            _context.VacancyRequests.Remove(delete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
