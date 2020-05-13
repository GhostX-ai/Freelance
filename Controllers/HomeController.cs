using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreelanceV2.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace FreelanceV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
                var model = _context.Announcemants.Include(p=> p.User).Include(p=>p.Binds).Single(a => a.Id == id);
                return View(model);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
