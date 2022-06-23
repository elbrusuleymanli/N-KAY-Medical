using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.Areas.Admin.ViewModel;
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
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ServiceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult > Index()
        {


            var services = await _context.Services.Include(s => s.ServiceOptions).ToListAsync();
            
             
           
                return View(services);
        }
        //add service options
        //public async Task<IActionResult> AddService()
        //{

        //    //var serviceOpt = await _context.ServiceOptions.Select(s => s.Name).ToListAsync();

        //    //AddServiceVM model = new AddServiceVM()
        //    //{
        //    //    ServiceOptions = serviceOpt,
        //    //    ServiceId = id
        //    //};

        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> AddService(string id, AddServiceVM model)
        //{
        //    var service = await _context.Services.FindAsync(id);
        //    if (service == null) return NotFound();

        //    if (!ModelState.IsValid) return View(model);


        //    await _context.Services.AddAsync(service);

           

        //    return RedirectToAction(nameof(Index), new { id });

        //}






        //create service
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Models.Service service)
        {
            if (!ModelState.IsValid) return View();

            if (!service.ServiceImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "Şəkil formatı uyğun gəlmir");
                return View();

            }

            if (service.ServiceImageFile.Length > 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "Şəkilin ölçüsü 1MB artıqdır");
                return View();
            }

            service.Image = FileUtils.Create(FileConstants.ServiceImagePath, service.ServiceImageFile);

            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        // delete service
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.Services.FindAsync(id);
            if (delete == null) return NotFound();

            return View(delete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteService(int id)
        {
            var serviceDelete = await _context.Services.FindAsync(id);
            if (serviceDelete == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.ServiceImagePath, serviceDelete.Image));

            _context.Services.Remove(serviceDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //update service

        public async Task<IActionResult> Update(int id)
        {
            var news = await _context.Services.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Models.Service service)
        {
            var upService = await _context.Services.FindAsync(id);

            if (upService == null) return NotFound();
            if (id != service.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.Delete(Path.Combine(FileConstants.ServiceImagePath, upService.Image));

            upService.Image = FileUtils.Create(FileConstants.ServiceImagePath, service.ServiceImageFile);

            upService.Title = service.Title;
            //upService.Title_RU = service.Title_RU;
            //upService.Title_EN = service.Title_EN;
            upService.Text = service.Text;
            upService.Icon = service.Icon;
            foreach (var item in upService.ServiceOptions)
            {
               
            }
            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

        //detail service
        public async Task<IActionResult> Detail(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return NotFound();
            return View(service);
        }
    }
}
