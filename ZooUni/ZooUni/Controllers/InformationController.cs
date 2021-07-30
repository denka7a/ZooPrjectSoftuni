using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ZooUni.Data;
using ZooUni.Models;
using ZooUni.Services.Information;

namespace ZooUni.Controllers
{
    public class InformationController : Controller
    {
        private readonly IInformationService service;
        public InformationController(IInformationService service)
        {
            this.service = service;
        }

        public IActionResult Info()
        {
            return View();
        }

        [Authorize]
        public IActionResult Predator()
        {
            var animals = this.service.GetAnimals();

            return View(animals);
        }

        [Authorize]
        public IActionResult Mammal()
        {
            var animals = this.service.GetAnimals();

            return View(animals);
        }

        [Authorize]
        public IActionResult Reptile()
        {
            var animals = this.service.GetAnimals();

            return View(animals);
        }
    }
}