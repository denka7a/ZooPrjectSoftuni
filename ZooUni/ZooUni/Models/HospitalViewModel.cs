using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Models
{
    public class HospitalViewModel
    {
        [Required]
        public string Name { get; set; }
        public IEnumerable<AnimalViewModel> Animals { get; set; }
    }
}
