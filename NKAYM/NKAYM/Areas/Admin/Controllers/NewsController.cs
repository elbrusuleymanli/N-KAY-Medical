using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.Constants;
using NKAYM.DAL;
using NKAYM.Models;
using NKAYM.Utils;
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
       //create news
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
            
            news.Image = FileUtils.Create(FileConstants.ImagePath,news.ImageFile);

           await _context.NewsWalls.AddAsync(news);
            await _context.SaveChangesAsync();
            
            
            return RedirectToAction(nameof(Index));
        }


        // delete news
        public async Task<IActionResult> Delete(int id)
        {
            var delete =await _context.NewsWalls.FindAsync(id);
            if (delete == null) return NotFound();
            
            return View(delete);
        }
       
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
       
        public async Task<IActionResult> DeleteNews(int id)
        {
            var newsDelete = await _context.NewsWalls.FindAsync(id);
            if (newsDelete == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, newsDelete.Image));

           _context.NewsWalls.Remove(newsDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //update news

        public async Task<IActionResult> Update(int id)
        {
            var news = await _context.NewsWalls.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, NewsWall news)
        {
            var upNews = await _context.NewsWalls.FindAsync(id);

            if (upNews == null) return NotFound();
            if (id != news.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, upNews.Image));

            upNews.Image = FileUtils.Create(FileConstants.ImagePath, news.ImageFile);

            upNews.Title = news.Title;
            upNews.Descr1 = news.Descr1;
            upNews.Descr2 = news.Descr2;
            upNews.Descr3 = news.Descr3;
           



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

        //detail news
        public async Task<IActionResult> Detail(int id)
        {
            var news = await _context.NewsWalls.FindAsync(id);
            if (news == null) return NotFound();
            return View(news);
        }
    }
}
