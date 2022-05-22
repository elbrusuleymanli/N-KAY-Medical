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
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public DoctorController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {

            var doctor = await _context.Doctors.Include(d => d.DoctorPositions).Include(d=>d.Educations).Include(d => d.Experiences).ToListAsync();
            return View(doctor);
        }

        //create doctor
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            if (!ModelState.IsValid) return View();

            if (!doctor.DoctorImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "Şəkil formatı uyğun gəlmir");
                return View();

            }

            if (doctor.DoctorImageFile.Length > 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "Şəkilin ölçüsü 1MB artıqdır");
                return View();
            }

            doctor.Image = FileUtils.Create(FileConstants.DoctorImagePath, doctor.DoctorImageFile);

            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        // delete doctor
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.Doctors.FindAsync(id);
            if (delete == null) return NotFound();

            return View(delete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctorDelete = await _context.Doctors.FindAsync(id);
            if (doctorDelete == null) return NotFound();


            FileUtils.Delete(Path.Combine(FileConstants.DoctorImagePath, doctorDelete.Image));

            _context.Doctors.Remove(doctorDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //update doctor

        public async Task<IActionResult> Update(int id)
        {
            var news = await _context.Doctors.FindAsync(id);

            if (news == null) return NotFound();

            return View(news);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Doctor doctor)
        {
            var upDoctor = await _context.Doctors.FindAsync(id);

            if (upDoctor == null) return NotFound();
            if (id != doctor.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.Delete(Path.Combine(FileConstants.DoctorImagePath, upDoctor.Image));

            upDoctor.Image = FileUtils.Create(FileConstants.DoctorImagePath, doctor.DoctorImageFile);

            upDoctor.Fullname = doctor.Fullname;
            upDoctor.Position = doctor.Position;
            upDoctor.Phone = doctor.Phone;
            upDoctor.WorkDay = doctor.WorkDay;
            upDoctor.Educations = doctor.Educations;
            upDoctor.Experiences = doctor.Experiences;






            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

        //detail doctor
        public async Task<IActionResult> Detail(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null) return NotFound();
            return View(doctor);
        }

    }
}
