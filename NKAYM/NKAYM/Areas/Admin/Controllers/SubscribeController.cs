using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{  [Area("Admin")]
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var subscribe = _context.Emails.ToList();
            return View(subscribe);
        }
        //delete subscribe
        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.Emails.FindAsync(id);
            if (message == null) return NotFound();

            _context.Emails.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
