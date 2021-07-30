using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;

namespace ZooUni.Services.Owner
{
    public interface IOwnerService
    {
        List<OwnerViewModel> GetOwners();
    }
}
