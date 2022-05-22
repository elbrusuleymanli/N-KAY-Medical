using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NKAYM.Constants;
using NKAYM.DAL;
using NKAYM.Models;
using NKAYM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhotoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PhotoController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var photo = _context.PhotoGalleries.ToList();
            return View(photo);
        }


        //create photo
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PhotoGallery photo)
        {
            if (!ModelState.IsValid) return View();

            if (!photo.PhotoImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "Şəkil formatı uyğun gəlmir");
                return View();

            }

            if (photo.PhotoImageFile.Length > 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "Şəkilin ölçüsü 1MB artıqdır");
                return View();
            }

            photo.Image = FileUtils.Create(FileConstants.PhotoImagePath, photo.PhotoImageFile);

            await _context.PhotoGalleries.AddAsync(photo);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}
