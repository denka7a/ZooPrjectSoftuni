using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Models
{
    public class HospitalisedViewModel
    {
        public HospitalisedAnimalViewModel One { get; set; }
        public List<HospitalisedAnimalViewModel> Two { get; set; }
    }
}
