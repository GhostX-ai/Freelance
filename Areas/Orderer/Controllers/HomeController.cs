using Microsoft.AspNetCore.Mvc;
using FreelanceV2.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace FreelanceV2.Areas.Orderer.Controllers
{
    [Area("Orderer")]
    [Authorize(Roles = "Заказчик")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (FreelanceContext _db = new FreelanceContext())
            {
                string userLogin = User.Identity.Name;
                var li = _db.Announcemants.Include(a => a.WageType).Include(a => a.Binds).Where(a => a.User.Login == userLogin).ToList();
                return View(li);
            }
        }
        public IActionResult CreateAnnouncemant()
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                ViewBag.WageTypes = _context.WagesType.ToList();
                return View();
            }
        }
        [HttpPost]
        public IActionResult CreateAnnouncemant(Announcemants model, IFormFile file)
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                string dirpath = Path.GetFullPath("/files/");
                if (!Directory.Exists(dirpath))
                {
                    Directory.CreateDirectory(dirpath);
                }
                string path = dirpath + file.FileName;
                using (var stream = System.IO.File.Create(path))
                {
                    file.CopyTo(stream);
                }
                model.UserId = _context.Accounts.Single(a => a.Login == User.Identity.Name).Id;
                _context.Announcemants.Add(new Announcemants()
                {
                    FullDescription = model.FullDescription,
                    MaxWage = model.MaxWage,
                    MinWage = model.MinWage,
                    Title = model.Title,
                    UserId = model.UserId,
                    WageTypeId = model.WageTypeId,
                    Deadline = model.Deadline,
                    PublicDate = DateTime.Now.Date,
                    FilePath = path,
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}