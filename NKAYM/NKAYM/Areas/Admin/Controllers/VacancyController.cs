using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VacancyController : Controller
    {
        private readonly AppDbContext _context;
       

        public VacancyController(AppDbContext context)
        {
            _context = context;
          
        }
        public IActionResult Index()
        {
            var vacancy = _context.Vacancies.OrderByDescending(v => v.Id).ToList();
            return View(vacancy);
        }

        //create vacancy
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vacancy vacancy)
        {
            if (!ModelState.IsValid) return View();

            

            await _context.Vacancies.AddAsync(vacancy);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        // delete vacancy
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.Vacancies.FindAsync(id);
            if (delete == null) return NotFound();

            return View(delete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteVacancy(int id)
        {
            var vacancyDelete = await _context.Vacancies.FindAsync(id);
            if (vacancyDelete == null) return NotFound();



            _context.Vacancies.Remove(vacancyDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //update vacancy

        public async Task<IActionResult> Update(int id)
        {
            var vacancy = await _context.Vacancies.FindAsync(id);

            if (vacancy == null) return NotFound();

            return View(vacancy);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Vacancy vacancy)
        {
            var upVacancy = await _context.Vacancies.FindAsync(id);

            if (upVacancy == null) return NotFound();
            if (id != vacancy.Id) return BadRequest();
            if (!ModelState.IsValid) return View();



            upVacancy.Position = vacancy.Position;
            upVacancy.Gender = vacancy.Gender;
            upVacancy.Education = vacancy.Education;
            upVacancy.Experience = vacancy.Experience;
            upVacancy.WorkTime = vacancy.WorkTime;
            upVacancy.WorkDays = vacancy.WorkDays;


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

        //detail vacancy
        public async Task<IActionResult> Detail(int id)
        {
            var vacancy = await _context.Vacancies.FindAsync(id);
            if (vacancy == null) return NotFound();
            return View(vacancy);
        }
    }
}
