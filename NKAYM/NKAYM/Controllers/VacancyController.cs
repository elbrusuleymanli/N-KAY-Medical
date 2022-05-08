using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class VacancyController : Controller
    {
      
            private readonly AppDbContext _context;

            public VacancyController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
        {
            var vacancy = _context.Vacancies.ToList();
            return View(vacancy);
        }
    }
}
