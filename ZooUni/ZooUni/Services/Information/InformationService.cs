using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Services.Information
{
    public class InformationService : IInformationService
    {
        private readonly ZooContext context;
        public InformationService(ZooContext context)
        {
            this.context = context;
        }

        public List<AnimalViewModel> GetAnimals()
        {
            var animals = this.context.Animals.Select(x => new AnimalViewModel
                {
                Type = x.Type,
                URL = x.URL,
                Kind = x.Kind
            }).ToList();

            return (animals);
        }
    }
}
