using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;
using ZooUni.Services.Hospital;

namespace ZooUni.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IHospitalService service;

        public HospitalController(IHospitalService service)
        {
            this.service = service;
        }

        [Authorize]
        public IActionResult RemoveFromHospital()
        {
            var hospital = service.RemoveFromHospital(TempData["name"].ToString());
            return View(hospital);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromHospital(HospitalisedViewModel hospitalisedAnimalViewModel)
        {
            var animal = service.GetAnimalFromHospital(hospitalisedAnimalViewModel.One.Name);

            if (!ModelState.IsValid)
            {
                var animalsInHospital = service.AnimalsInHospital();
                
                return View(animalsInHospital);
            }


            if (animal != null)
            {
                service.RemoveAnimal(animal.Hospital, animal);
            }

            return Redirect("/Animals/All");
        }

        [Authorize]
        public IActionResult AddInHospital()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult AddInHospital(HospitalisedViewModel hospitalisedAnimalViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(hospitalisedAnimalViewModel);
            }

            service.AddInHospital(hospitalisedAnimalViewModel);
            TempData["name"] = hospitalisedAnimalViewModel.One.Name;
            return RedirectToAction(nameof(RemoveFromHospital));
        }
    }
}
