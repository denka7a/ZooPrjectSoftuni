using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Services.Animals;

namespace ZooUni.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly IAnimalService service;

        public AnimalsController(IAnimalService service)
        {
            this.service = service;
        }

        public IActionResult All()
        {
            var animals = this.service.All();

            return View(animals);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AnimalViewModel animalViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(animalViewModel);
            }

            service.Add(animalViewModel);

            return RedirectToAction(nameof(All));
        }
    }
}
