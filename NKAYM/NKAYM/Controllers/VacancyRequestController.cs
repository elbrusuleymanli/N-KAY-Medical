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

namespace NKAYM.Controllers
{
    public class VacancyRequestController : Controller
    {
        private readonly AppDbContext _context;
        

        public VacancyRequestController(AppDbContext context)
        {
            _context = context;
          
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VacancyRequest vacancy)
        {
            if (!ModelState.IsValid) return View();

            if (!vacancy.PdfFile.ContentType.Contains("pdf"))
            {
                ModelState.AddModelError("PdfFile", " Format uyğun gəlmir");
                return View();

            }

            if (vacancy.PdfFile.Length > 5124 * 5124)
            {
                ModelState.AddModelError("PdfFile", "Şəkilin ölçüsü 5MB artıqdır");
                return View();
            }

            vacancy.CV = FileUtils.Create(FileConstants.PdfPath, vacancy.PdfFile);

            await _context.VacancyRequests.AddAsync(vacancy);
            await _context.SaveChangesAsync();


            return View();
        }
    }
}
