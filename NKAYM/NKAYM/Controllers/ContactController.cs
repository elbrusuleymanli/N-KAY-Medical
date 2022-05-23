using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
        }

        // subscribe email

        public async Task<JsonResult> addSubscribe(string email)
        {

            if (String.IsNullOrWhiteSpace(email)) return Json(400);

            bool isValid = IsValidEmail(email);
            if (!isValid)
            {
                return Json(500);
            }

            Emails emails = new Emails
            {
                Email = email
            };

            await _context.Emails.AddAsync(emails);
            await _context.SaveChangesAsync();
            return Json(200);

        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
