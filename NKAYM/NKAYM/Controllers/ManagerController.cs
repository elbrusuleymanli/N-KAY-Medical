using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class ManagerController : Controller
    {
        private readonly AppDbContext _context;

        public ManagerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var manager = _context.Managers.ToList();
            return View(manager);
        }
    }
}
