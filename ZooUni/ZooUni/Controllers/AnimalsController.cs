using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Services.Animals;
using Microsoft.AspNetCore.Authorization;

namespace ZooUni.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly IAnimalService service;

        public AnimalsController(IAnimalService service)
        {
            this.service = service;
        }

        [Authorize]
        public IActionResult All()
        {
            var animals = this.service.All();

            return View(animals);
        }

        [Authorize]
        public IActionResult Add() => View();

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken] // <- pri triene na tokena ot strana na hackera, toi polu4ava BadRequest
        public IActionResult Add(AnimalViewModel animalViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(animalViewModel);
            }

            service.Add(animalViewModel);

            return RedirectToAction(nameof(All));
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var animal = service.AnimalById(id);

            return View(new AnimalViewModel
            {
                Id = animal.Id,
                Type = animal.Type,
                Name = animal.Name,
                URL = animal.URL,
                Kind = animal.Kind
            });
        }
        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, string type, string name, string url, string kind)
        {
            var animalIsEdited = service.Edit(id, type, name, url, kind);

            //if (!animalIsEdited)
            //{
            //    return BadRequest();
            //}

            return RedirectToAction(nameof(All));
        }
    }
}
