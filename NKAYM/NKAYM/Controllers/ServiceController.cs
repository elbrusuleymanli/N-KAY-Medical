using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var service = await _context.Services.ToListAsync();
           
            return View(service);
        }

        public async Task<IActionResult> Details (int id)
        {
            var service = await _context.Services.Include(s=>s.ServiceOptions).FirstOrDefaultAsync(s=>s.Id==id);
            if (service == null) return NotFound();

            return View(service);
        }
        
    }
}
