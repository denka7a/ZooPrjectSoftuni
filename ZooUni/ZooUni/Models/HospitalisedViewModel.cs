using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Models
{
    public class HospitalisedViewModel
    {
        public HospitalViewModel One { get; set; }
        public List<HospitalViewModel> Two { get; set; }
    }
}
