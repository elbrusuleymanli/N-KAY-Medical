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
    public class PartnerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PartnerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var partner = _context.Partners.OrderBy(p=>p.Order).ToList();
            return View(partner);
        }

        //create partner
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Partner partner)
        {
            if (!ModelState.IsValid) return View();

            if (!partner.PartnerImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "Şəkil formatı uyğun gəlmir");
                return View();

            }

            if (partner.PartnerImageFile.Length > 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "Şəkilin ölçüsü 1MB artıqdır");
                return View();
            }
           
            partner.Image = FileUtils.Create(FileConstants.PartnerImagePath, partner.PartnerImageFile);

            await _context.Partners.AddAsync(partner);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        // delete partner
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.Partners.FindAsync(id);
            if (delete == null) return NotFound();

            return View(delete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeletePartner(int id)
        {
            var partnerDelete = await _context.Partners.FindAsync(id);
            if (partnerDelete == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.PartnerImagePath, partnerDelete.Image));

            _context.Partners.Remove(partnerDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        //update partner

        public async Task<IActionResult> Update(int id)
        {
            var news = await _context.Partners.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Partner partner)
        {
            var upPartner = await _context.Partners.FindAsync(id);

            if (upPartner == null) return NotFound();
            if (id != partner.Id) return BadRequest();
            if (!ModelState.IsValid) return View();
         
               
            
            FileUtils.Delete(Path.Combine(FileConstants.PartnerImagePath, upPartner.Image));

            upPartner.Image = FileUtils.Create(FileConstants.PartnerImagePath, partner.PartnerImageFile);

            upPartner.WebAdress = partner.WebAdress;
            upPartner.Order = partner.Order;
          


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }


        //detail partner
        public async Task<IActionResult> Detail(int id)
        {
            var partner = await _context.Partners.FindAsync(id);
            if (partner == null) return NotFound();
            return View(partner);
        }

    }
}
