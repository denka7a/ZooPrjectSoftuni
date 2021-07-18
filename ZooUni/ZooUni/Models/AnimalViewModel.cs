using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Models
{
    public class AnimalViewModel
    {
        [Required]
        [StringLength(15), MinLength(2)]
        public string Type { get; set; }
        public string Name { get; set; }

        [Required]
        [Url]
        public string URL { get; set; }
        [Required]
        public string Kind { get; set; }
    }
}
