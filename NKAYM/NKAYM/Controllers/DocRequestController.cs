using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class DocRequestController : Controller
    {
        private readonly AppDbContext _context;

        public DocRequestController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]

        public async Task<JsonResult> SendMessage(DocRequest model)
        {

            if (model == null) return Json(400);

           

            DocRequest reply = new DocRequest
            {
                Fullname = model.Fullname,
                Gender = model.Gender,
                Birhtday = model.Birhtday,
                Address = model.Address,
                Phone=model.Phone,
                AboutSick=model.AboutSick,
                Unit=model.Unit,
                DoctorsFullname=model.DoctorsFullname,
                RequestDay=model.RequestDay,
                RequestTime=model.RequestTime
                

            };

            await _context.DocRequests.AddAsync(reply);
            await _context.SaveChangesAsync();
            return Json(200);

        }
       
    }
}
