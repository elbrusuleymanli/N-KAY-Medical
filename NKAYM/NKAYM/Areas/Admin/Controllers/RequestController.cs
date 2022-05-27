using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{ [Area("Admin")]
    public class RequestController : Controller
    {
        private readonly AppDbContext  _context;

        public RequestController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var request = _context.DocRequests.OrderByDescending(r => r.Id).ToList();
            return View(request);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var request =await _context.DocRequests.FindAsync(id);
            if (request == null) return NotFound();

           _context.DocRequests.Remove(request);
           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
