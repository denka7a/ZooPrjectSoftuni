using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data.Models;

namespace ZooUni.Models
{
    public class OwnerViewModel
    {
        public string Name { get; set; }
        public string Information { get; set; }
        public IEnumerable<AnimalViewModel> Animals { get; set; }
    }
}
