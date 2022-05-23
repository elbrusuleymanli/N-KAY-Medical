using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class VideoController : Controller
    {
      
            private readonly AppDbContext _context;
            private readonly IWebHostEnvironment _env;

            public VideoController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }
            public IActionResult Index()
        {
            var video = _context.VideoGalleries.ToList();
            return View(video);
        }

        //create video
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VideoGallery videos)
        {
            if (!ModelState.IsValid) return View();

            if (!videos.VideoFile.ContentType.Contains("video"))
            {
                ModelState.AddModelError("VideoFile", "Video formatı uyğun gəlmir");
                return View();

            }


            videos.Video = FileUtils.Create(FileConstants.VideoPath, videos.VideoFile);

            await _context.VideoGalleries.AddAsync(videos);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }


        // delete video
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.VideoGalleries.FindAsync(id);
            if (delete == null) return NotFound();

            return View(delete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteVideo(int id)
        {
            var videoDelete = await _context.VideoGalleries.FindAsync(id);
            if (videoDelete == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.VideoPath, videoDelete.Video));

            _context.VideoGalleries.Remove(videoDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
