using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Models;
using ZooUni.Models.Home;

namespace ZooUni.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ZooContext context;

        public HomeController(ZooContext context)
        {
            this.context = context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        

        public IActionResult Index()
        {
            var totalAnimals = this.context.Animals.Count();
            var totalUsers = this.context.Users.Count();

            return View(new IndexViewModel
            {
                TotalAnimals = totalAnimals,
                TotalUsers = totalUsers
            });
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
