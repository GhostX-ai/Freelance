using Microsoft.AspNetCore.Mvc;
using FreelanceV2.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FreelanceV2.Areas.Orderer.Controllers
{
    [Area("Orderer")]
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
        public IActionResult CreateAnnouncemant(Announcemants model, string NewWage)
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                if (NewWage != null)
                {
                    _context.WagesType.Add(new WagesType()
                    {
                        WageType = NewWage
                    });
                    _context.SaveChanges();
                    model.WageTypeId = _context.WagesType.First(w => w.WageType == NewWage).Id;
                }
                model.UserId = _context.Accounts.Single(a => a.Login == User.Identity.Name).Id;
                _context.Announcemants.Add(new Announcemants()
                {
                    FullDescription = model.FullDescription,
                    MaxWage = model.MaxWage,
                    MinWage = model.MinWage,
                    Title = model.Title,
                    UserId = model.UserId,
                    WageTypeId = model.WageTypeId
                });
                _context.SaveChanges();
                return View();
            }
        }
    }
}