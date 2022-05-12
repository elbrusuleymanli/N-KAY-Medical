using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public NewsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult>  Index()
        {
            var news =await _context.NewsWalls.OrderByDescending(n=>n.ReleaseDate).ToListAsync();
            return View(news);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewsWall news)
        {
            if (!ModelState.IsValid) return View();

            if (!news.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "Şəkil formatı uyğun gəlmir");
           return View();
            
            }

            if(news.ImageFile.Length > 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "Şəkilin ölçüsü 1MB artıqdır");
                return View();
            }

            var FileName =Guid.NewGuid()+ news.ImageFile.FileName;
            var wwwRootPath= _env.WebRootPath;
           var fullPath= Path.Combine(wwwRootPath,"assets", "images",FileName);

            FileStream stream = new FileStream(fullPath, FileMode.Create);
            await news.ImageFile.CopyToAsync(stream);
            stream.Close();

            news.Image = FileName;

           await _context.NewsWalls.AddAsync(news);
            await _context.SaveChangesAsync();
            
            
            return RedirectToAction(nameof(Index));
        }
    }
}
