using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;

namespace ZooUni.Services.Animals
{
    public interface IAnimalService
    {
        List<AnimalViewModel> All();
        void Add(AnimalViewModel animalViewModel);
    }
}
