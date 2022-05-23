using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TickerController : Controller
    {
        private readonly AppDbContext _context;
       

        public TickerController(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var ticker = _context.NewsRuns.ToList();
            return View(ticker);
        }

        //update ticker

        public async Task<IActionResult> Update(int id)
        {
            var ticker = await _context.NewsRuns.FindAsync(id);

            if (ticker == null) return NotFound();

            return View(ticker);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, NewsRun ticker)
        {
            var upTicker = await _context.NewsRuns.FindAsync(id);

            if (upTicker == null) return NotFound();
            if (id != ticker.Id) return BadRequest();
            if (!ModelState.IsValid) return View();


            upTicker.Announcement = ticker.Announcement;
           
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }
    }
}
