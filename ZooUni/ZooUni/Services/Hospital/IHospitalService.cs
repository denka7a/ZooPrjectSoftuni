using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Hospital
{
    public interface IHospitalService
    {
        public void AddInHospital(HospitalisedViewModel hospitalisedAnimalViewModel);
        HospitalisedViewModel RemoveFromHospital(string name);
        public Animal GetAnimalFromHospital(string name);
        public HospitalisedViewModel AnimalsInHospital();
        public void RemoveAnimal(Data.Models.Hospital hospital, Animal animal);
    }
}
