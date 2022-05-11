using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class VideoGalleryController : Controller
    {
        private readonly AppDbContext _context;

        public VideoGalleryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            var video = await _context.VideoGalleries.OrderByDescending(v => v.Id).ToListAsync();
            return View(video);
        }
    }
}
