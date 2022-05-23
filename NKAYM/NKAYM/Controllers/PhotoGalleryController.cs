using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class PhotoGalleryController : Controller
    {
        private readonly AppDbContext _context;

        public PhotoGalleryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult > Index()
        {
            var photo =await _context.PhotoGalleries.OrderByDescending(p=>p.Id).ToListAsync();

            return View(photo);
        }
        //public async Task <IActionResult> GetPage (int page,int size)
        //{
        //    List<PhotoGallery> photoes =await _context.PhotoGalleries.ToListAsync();
        //    Pagination pagination = new Pagination(photoes, page, size);

        //    return View (pagination);
        //}
    }
}
