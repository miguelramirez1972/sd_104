using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Data;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        public IActionResult Index()
        {
            return View(_context.Songs.Where(s=>s.IsFeatured == true).ToList());
        }

        public IActionResult Songs()
        {
            return View(_context.Songs.Where(s => s.IsActive == true).ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Albums()
        {
            return View(_context.Songs.GroupBy(x => x.Album).Select(grp => grp.First()).ToList());
        }

    }
}
