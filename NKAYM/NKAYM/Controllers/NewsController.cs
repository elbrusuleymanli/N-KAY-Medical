using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using NKAYM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult>  Index()
        {

            var news = await _context.NewsWalls.OrderByDescending(n => n.ReleaseDate).ToListAsync();
           
           
            
            return View(news);
        }

        public async Task<IActionResult> Details(int id)
        {
            var newsDetail =await _context.NewsWalls.FirstOrDefaultAsync(n => n.Id == id);
                if (newsDetail == null) return NotFound();

            return View(newsDetail);
        }

    }
}
