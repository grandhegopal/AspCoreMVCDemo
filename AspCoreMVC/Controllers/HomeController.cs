using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreMVC.Models;

namespace AspCoreMVC.Controllers
{
    public class HomeController : Controller
    {

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(string name, int ID = 1)
        {

            ViewData["name"] = name;

            ViewData["ID"] = ID;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
