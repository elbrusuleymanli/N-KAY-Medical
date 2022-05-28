﻿


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NKAYM.Constants;
using NKAYM.Models;
using NKAYM.Services;
using NKAYM.ViewModel;
using System.Threading.Tasks;

namespace NKAYM.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailService _mailService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMailService mailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
        }
        //login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid) return View();

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null) user = await _userManager.FindByEmailAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "İstifadəçi və ya şifrə səhvdir");

                return View();
            }
            //for block user
            if (!user.IsActive)
            {
                ModelState.AddModelError("", model.Username + " " + "siz admin tərəfindən bloklanmısınız");
                return View();
            }


            var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "İstifadəçi və ya şifrə səhvdir");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        //register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid) return View();
            var user = await _userManager.FindByNameAsync(model.Username);
            if(user != null)
            {
                ModelState.AddModelError("Username", model.Username + "" + "adlı istifadəçi artıq mövcuddur");
                return View();
            }

            User newUser = new User
            {
                Fullname = model.Fullname,
                UserName = model.Username,
                Email = model.Email

            };
            IdentityResult identityResult =await _userManager.CreateAsync(newUser, model.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, RoleConstants.User);
            //create token
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            //create link
            var link = Url.Action(nameof(ConfirmEmail), "Account", new { newUser.UserName, token }, Request.Scheme);

            await _mailService.SendEmailAsync(new MailRequest
            {
                ToEmail = newUser.Email,
                Body = link,
                Subject = "Qeydiyyatın təsdiqi"
            });

        

           
            return RedirectToAction("Index", "Home");
        }
        //email confirm

        public async Task<IActionResult> ConfirmEmail(string username, string token)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null) return BadRequest();

            var IdentityResult = await _userManager.ConfirmEmailAsync(user, token);

            if (!IdentityResult.Succeeded)
            {
                return BadRequest();
            };
            return RedirectToAction("Index", "Home");
        }
       
        //logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

    }
}
