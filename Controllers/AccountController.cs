using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreelanceV2.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace FreelanceV2.Controllers
{
    public class AccountController : Controller
    {
        private FreelanceContext _context = new FreelanceContext();
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Roles = _context.Roles.ToList();
            ViewBag.Genders = _context.Genders.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Accounts user = await _context.Accounts.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (user == null)
                {
                    Guid Id = Guid.NewGuid();
                    Accounts us = new Accounts()
                    {
                        Id = Id.ToString(),
                        Login = model.Login,
                        Password = model.Password,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        MiddleName = model.MiddleName,
                        GenderId = model.GenderId,
                        RoleId = model.RoleId,
                        BirthDate = model.BirthDate,
                        RangId = 1
                    };
                    await _context.Accounts.AddAsync(us);
                    await _context.SaveChangesAsync();
                    await Authenticate(us);
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            ViewBag.Roles = _context.Roles.ToList();
            ViewBag.Genders = _context.Genders.ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Accounts user = await _context.Accounts.FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        private async Task Authenticate(Accounts user)
        {
            string role = _context.Roles.First(r => r.Id == user.RoleId).Role;
            var claims = new List<Claim>{
                new Claim(ClaimsIdentity.DefaultNameClaimType,user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType,role),
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}