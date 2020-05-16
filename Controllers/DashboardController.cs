using System;
using System.Linq;
using FreelanceV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreelanceV2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                var announcemants = _context.Announcemants.Include(i => i.WageType).ToList();
                return View(announcemants);
            }
        }

        [HttpGet]
        public IActionResult AnnounmentInfo(int id)
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                var model = _context.Announcemants.Include(p => p.User).Include(p => p.Binds).Single(a => a.Id == id);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult AddMyBind(Announcemants model, string text)
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                var userId = _context.Accounts.Single(a => a.Login == User.Identity.Name).Id;
                _context.Binds.Add(new Binds(){
                    BindText = text,
                    UserId = userId,
                    AnnouncemantId = model.Id
                });
                _context.SaveChanges();
                return RedirectToAction("Index", "Dashboard");
            }
        }

        public JsonResult CheckAuth()
        {
            using (FreelanceContext _context = new FreelanceContext())
            {
                bool useraccess = false;
                var user = _context.Accounts.Include(u => u.Role).SingleOrDefault(u => u.Login == User.Identity.Name);
                if (user != null)
                    useraccess = user.Role.Role == "Программист";
                return Json(useraccess);
            }
        }
    }
    public class BindModel
    {
        public int Id { get; set; }
        public string bindText { get; set; }
    }
}