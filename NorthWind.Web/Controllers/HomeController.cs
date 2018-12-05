using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Dal;
using NorthWind.Web.Models;

namespace NorthWind.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthWindContext _context;

        public HomeController(NorthWindContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var tmp = _context.Categories.ToList();
            return View();
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
