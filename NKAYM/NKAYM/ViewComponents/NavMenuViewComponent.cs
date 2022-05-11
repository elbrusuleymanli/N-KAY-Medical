using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.ViewComponents
{
    public class NavMenuViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public NavMenuViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var navMenu = _context.NavMenus.FirstOrDefault();

            return View(navMenu);
        }
    }
}
