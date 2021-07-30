using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Models;

namespace ZooUni.Services.Owner
{
    public class OwnerService : IOwnerService
    {
        private readonly ZooContext zooContext;

        public OwnerService(ZooContext zooContext)
        {
            this.zooContext = zooContext;
        }

        public List<OwnerViewModel> GetOwners()
        {
            var owners = zooContext.Owners
                 .Select(x => new OwnerViewModel
                 {
                     Name = x.Name,
                     Information = x.Information,
                     URL = x.URL,
                     Animals = x.Animals.Select(a => new AnimalViewModel
                     {
                         Name = a.Name
                     })
                 .ToList()
                 }).ToList();

            return owners;
        }
    }
}
