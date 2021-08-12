using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Hospital
{
    public class HospitalService : IHospitalService
    {
        private readonly ZooContext context;

        public HospitalService(ZooContext context)
        {
            this.context = context;
        }

        public void AddInHospital(HospitalisedViewModel hospitalisedAnimalViewModel)
        {
            var animals = context
                .Animals
                .ToList();

            var hospitalData = context.Hospital.FirstOrDefault(x => x.Name == "Hospital");

            var animal = context.Animals.FirstOrDefault(x => x.Name == hospitalisedAnimalViewModel.One.Name);

            if (animal != null)
            {
                animal.HospitalId = hospitalData.Id;
                context.Update(animal);
                this.context.SaveChanges();
            }
        }

        public HospitalisedViewModel RemoveFromHospital(string name)
        {
            var hospital = new HospitalisedViewModel();
            var currentHospital = context.Hospital.Include(a => a.Animals).FirstOrDefault(x => x.Name == "Hospital");
            var currentAnimal = currentHospital.Animals.FirstOrDefault(x => x.Name == name);

            hospital.One = new HospitalViewModel
            {
                Animals = currentHospital.Animals.Select(a => new AnimalViewModel
                {
                    Name = a.Name,
                    URL = a.URL
                })
            };

            hospital.Two = this.context.Hospital.Select(x => new HospitalViewModel
            {
                Name = x.Name,
                Animals = x.Animals.Select(a => new AnimalViewModel
                {
                    Name = a.Name,
                    URL = a.URL
                })
            }).ToList();

            return hospital;
        }

        public Animal GetAnimalFromHospital(string name)
        {
            var hospitalData = context
                .Hospital
                .Include(x => x.Animals)
                .FirstOrDefault(x => x.Name == "Hospital");

            var animalInHospital = hospitalData
                .Animals
                .FirstOrDefault(x => x.Name == name);

            return animalInHospital;
        }

        public HospitalisedViewModel AnimalsInHospital()
        {
            var hospitalData = context
                .Hospital
                .Include(x => x.Animals)
                .FirstOrDefault(x => x.Name == "Hospital");

            var animalsInHospital = new HospitalisedViewModel()
            {
                Two = hospitalData.Animals.Select(a => new HospitalViewModel
                {
                    Name = a.Name,
                    Animals = hospitalData.Animals.Select(x => new AnimalViewModel()
                    {
                        Name = x.Name,
                        URL = x.URL
                    }).ToList()
                }).ToList()
            };

            return animalsInHospital;
        }

        public void RemoveAnimal(Data.Models.Hospital hospital, Animal animal)
        {
            hospital.Animals.Remove(animal);
            context.Update(animal);
            this.context.SaveChanges();
        }
    }
}
