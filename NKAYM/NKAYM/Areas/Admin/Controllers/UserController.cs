using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NKAYM.Areas.Admin.ViewModel;
using NKAYM.Constants;
using NKAYM.DAL;
using NKAYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKAYM.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin+" ,"+ RoleConstants.Moderator)]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public UserController(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();

            List<UserVM> usersList = new List<UserVM>();

            foreach (var user in users)
            {
                usersList.Add(new UserVM
                {
                    Id = user.Id,
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    IsActive = user.IsActive,
                    Roles = string.Join(",", await _userManager.GetRolesAsync(user))

                });
            }

            return View(usersList);
        }
        //get roles
        public async Task<IActionResult> GetRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var roles = await _userManager.GetRolesAsync(user);

            ViewBag.Fullname = user.Fullname;
            ViewBag.UserId = user.Id;
           
            return View(roles);

        }

        //remove roles

        public async Task<IActionResult> RemoveRole(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
           
            if (user == null) return NotFound();
           
            await _userManager.RemoveFromRoleAsync(user,roleName);
           
            return RedirectToAction(nameof(GetRoles), new { user.Id });

            
        }

        //add role

        public async Task<IActionResult> AddRoles(string id)
        {

            var roles = await _context.Roles.Select(r => r.Name).ToListAsync();

            AddRoleVM model = new AddRoleVM()
            {
                Roles = roles,
                UserId = id
            };
           
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddRoles(string id, AddRoleVM model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

           
            await _userManager.AddToRoleAsync(user, model.RoleName);

            ViewBag.Username = user.UserName;

            return RedirectToAction(nameof(GetRoles), new { id });

        }
        //change password
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            ViewBag.UserName = user.UserName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordVM model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View();


            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);



            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

        
            return RedirectToAction(nameof(Index));
        }
        //block user

        public async Task<IActionResult> Block(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return View();

            user.IsActive = !user.IsActive;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
