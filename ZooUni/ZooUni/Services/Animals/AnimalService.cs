using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Animals
{
    public class AnimalService : IAnimalService
    {
        private readonly ZooContext context;

        public AnimalService(ZooContext context)
        {
            this.context = context;
        }

        public List<AnimalViewModel> All()
        {
            var animals = this.context.Animals.Select(x => new AnimalViewModel
            {
                Id = x.Id,
                Type = x.Type,
                Name = x.Name,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

            return animals;
        }

        public void Add(AnimalViewModel animalViewModel)
        {
            var animalData = new Animal();
            if (animalViewModel.Kind == "Predator")
            {
                animalData = new Animal
                {
                    Type = animalViewModel.Type,
                    Name = animalViewModel.Name,
                    URL = animalViewModel.URL,
                    Kind = animalViewModel.Kind,
                    OwnerId = 1
                };
            }
            else if (animalViewModel.Kind == "Mammal")
            {
                animalData = new Animal
                {
                    Type = animalViewModel.Type,
                    Name = animalViewModel.Name,
                    URL = animalViewModel.URL,
                    Kind = animalViewModel.Kind,
                    OwnerId = 2
                };
            }
            else if (animalViewModel.Kind == "Reptile")
            {
                animalData = new Animal
                {
                    Type = animalViewModel.Type,
                    Name = animalViewModel.Name,
                    URL = animalViewModel.URL,
                    Kind = animalViewModel.Kind,
                    OwnerId = 3
                };
            }

            this.context.Animals.Add(animalData);
            this.context.SaveChanges();
        }

        public AnimalViewModel AnimalById(int id)
        => context.Animals
            .Where(a => a.Id == id)
            .Select(a => new AnimalViewModel
            {
                Id = a.Id,
                Type = a.Type,
                Name = a.Name,
                URL = a.URL,
                Kind = a.Kind
            })
            .FirstOrDefault();

        public bool Edit(int id, string type, string name, string url, string kind)
        {
            var animalData = context.Animals.Find(id);

            animalData.Id = id;
            animalData.Type = type;
            animalData.Name = name;
            animalData.URL = url;
            animalData.Kind = kind;

            if (animalData == null)
            {
                return false;
            }
            this.context.Update(animalData);
            this.context.SaveChanges();
            return true;
        }
    }
}
