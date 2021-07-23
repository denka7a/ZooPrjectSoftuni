using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Controllers
{
    public class HospitalController : Controller
    {
        private readonly ZooContext zooContext;
        public HospitalController(ZooContext zooContext)
        {
            this.zooContext = zooContext;
        }

        public IActionResult RemoveFromHospital()
        {
            var hospital = new HospitalisedViewModel();//LazyL
            var currentHospital = zooContext.Hospital.Include(a => a.Animals).FirstOrDefault(x => x.Name == "Hospital");
            var currentAnimal = currentHospital.Animals.FirstOrDefault(x => x.Name == TempData["name"].ToString());
            hospital.One = new HospitalisedAnimalViewModel
            {
                Animals = currentHospital.Animals.Select(a => new AnimalViewModel
                {
                    Name = a.Name,
                    URL = a.URL
                })
            };

            hospital.Two = this.zooContext.Hospital.Select(x => new HospitalisedAnimalViewModel
            {
                Name = x.Name,
                Animals = x.Animals.Select(a => new AnimalViewModel
                {
                    Name = a.Name,
                    URL = a.URL
                })
            }).ToList();

            //var hospital = this.zooContext.Hospital.Select(x => new HospitalisedAnimalViewModel
            //{
            //    Name = x.Name,
            //    Animals = x.Animals.Select(a => new AnimalViewModel
            //    {
            //        Name = a.Name,
            //        URL = a.URL
            //    })
            //}).ToList();

            return View(hospital);
        }
        [HttpPost]
        public IActionResult RemoveFromHospital(HospitalisedViewModel hospitalisedAnimalViewModel)
        {
            var hospitalData = zooContext
                .Hospital
                .Include(x => x.Animals)
                .FirstOrDefault(x => x.Name == "Hospital");

            var animalInHospital = hospitalData
                .Animals
                .FirstOrDefault(x => x.Name == hospitalisedAnimalViewModel.One.Name);

            if (!ModelState.IsValid)
            {
                var animalsInHospital = new HospitalisedViewModel()
                {
                    Two = hospitalData.Animals.Select(a => new HospitalisedAnimalViewModel
                    {
                        Name = a.Name,
                        Animals = hospitalData.Animals.Select(x => new AnimalViewModel()
                        {
                            Name = x.Name,
                            URL = x.URL
                        }).ToList()
                    }).ToList()
                };
                return View(animalsInHospital);
            }

            if (animalInHospital != null)
            {
                hospitalData.Animals.Remove(animalInHospital);
                zooContext.Update(animalInHospital);
                this.zooContext.SaveChanges();
            }

            return Redirect("/Animals/All");
        }

        public IActionResult AddInHospital()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInHospital(HospitalisedViewModel hospitalisedAnimalViewModel)
        {
            var animals = zooContext
                .Animals
                .ToList();

            if (!ModelState.IsValid)
            {
                return View(hospitalisedAnimalViewModel);
            }

            //var hospital = new Hospital
            //{
            //    Name = "Hospital"
            //};

            var hospitalData = zooContext.Hospital.FirstOrDefault(x => x.Name == "Hospital");

            //if (hospitalData == null)
            //{
            //    this.zooContext.Hospital.Add(hospital);
            //    this.zooContext.SaveChanges();
            //}


            var animal = zooContext.Animals.FirstOrDefault(x => x.Name == hospitalisedAnimalViewModel.One.Name);

            if (animal != null)
            {
                animal.HospitalisedAnimalId = hospitalData.Id;
                zooContext.Update(animal);
                this.zooContext.SaveChanges();
            }

            TempData["name"] = hospitalisedAnimalViewModel.One.Name;

            return RedirectToAction(nameof(RemoveFromHospital));
        }
    }
}
