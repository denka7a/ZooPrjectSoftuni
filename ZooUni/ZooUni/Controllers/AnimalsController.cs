﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;
using ZooUni.Data;
using ZooUni.Data.Models;

namespace ZooUni.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ZooContext zooContext;

        public AnimalsController(ZooContext zooContext)
        {
            this.zooContext = zooContext;
        }
        public IActionResult All()
        {
            var animals = this.zooContext.Animals.Select(x => new AnimalViewModel
            {
                Type = x.Type,
                Name = x.Name,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

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

            var animalData = new Animal
            {
                Type = animalViewModel.Type,
                Name = animalViewModel.Name,
                URL = animalViewModel.URL,
                Kind = animalViewModel.Kind
            };
            this.zooContext.Animals.Add(animalData);
            this.zooContext.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}
