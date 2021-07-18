using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ZooUni.Data;
using ZooUni.Models;

namespace ZooUni.Controllers
{
    public class InformationController : Controller
    {
        private readonly ZooContext zooContext;

        public InformationController(ZooContext zooContex)
        {
            this.zooContext = zooContex;
        }

        public IActionResult Predator()
        {
            var animals = this.zooContext.Animals.Select(x => new AnimalViewModel
            {
                Type = x.Type,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

            return View(animals);
        }

        public IActionResult Mammal()
        {
            var animals = this.zooContext.Animals.Select(x => new AnimalViewModel
            {
                Type = x.Type,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

            return View(animals);
        }

        public IActionResult Reptile()
        {
            var animals = this.zooContext.Animals.Select(x => new AnimalViewModel
            {
                Type = x.Type,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

            return View(animals);
        }
    }
}