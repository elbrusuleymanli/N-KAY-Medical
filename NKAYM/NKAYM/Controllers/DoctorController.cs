using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using NKAYM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            DoctorVM model = new DoctorVM
            {
                Doctors = await _context.Doctors.Include(d => d.Educations).Include(dr => dr.Experiences).Include(d=>d.DoctorPositions).ToListAsync(),
                Positions = await _context.Positions.ToListAsync()
            };
            
            return View(model);
        }
        public async Task <IActionResult> Details(int id)
        {
            var doctor = await _context.Doctors.Include(d => d.Educations).Include(dr => dr.Experiences).FirstOrDefaultAsync(d => d.Id == id);
            if (doctor == null) return NotFound();

            return View(doctor);
        }
    }
}
