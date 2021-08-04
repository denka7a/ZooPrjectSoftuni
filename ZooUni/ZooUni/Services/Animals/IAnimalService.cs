using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Animals
{
    public interface IAnimalService
    {
        List<AnimalViewModel> All();
        void Add(AnimalViewModel animalViewModel);
        AnimalViewModel AnimalById(int id);
        bool Edit(int id, string type, string name, string url, string kind);

    }
}
