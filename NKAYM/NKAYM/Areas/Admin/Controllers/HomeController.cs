using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.Constants;
using NKAYM.DAL;
using NKAYM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{  
    [Area("Admin")]
    [Authorize(Roles=RoleConstants.Admin)]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
           

            return View();
        }

    }
}
