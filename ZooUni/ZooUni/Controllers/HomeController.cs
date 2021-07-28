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
using ZooUni.Services.Home;

namespace ZooUni.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStatisticsService service;

        public HomeController(IStatisticsService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var statistics = service.GetAll();

            return View(new IndexViewModel
            {
                TotalAnimals = statistics.TotalAnimals,
                TotalUsers = statistics.TotalUsers
            });
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
