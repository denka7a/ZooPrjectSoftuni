using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Information
{
    public interface IInformationService
    {
        List<AnimalViewModel> GetAnimals();
    }
}
