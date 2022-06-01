using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NKAYM.DAL;
using NKAYM.Models;
using NKAYM.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            HomeVM model = new HomeVM
            {
               
                Services = await _context.Services.Take(12).OrderByDescending(s=>s.Id).ToListAsync(),
                Doctors = await _context.Doctors.ToListAsync(),
                NewsRuns = await _context.NewsRuns.FirstOrDefaultAsync(),
                NewsWalls = await _context.NewsWalls.Take(6).OrderByDescending(n => n.ReleaseDate).ToListAsync(),
                Partners= await _context.Partners.OrderBy(p=>p.Order).ToListAsync(),
                
               
            };
            
            return View(model);
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

    }
}
