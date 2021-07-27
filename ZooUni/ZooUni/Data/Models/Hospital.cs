using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Data.Models
{
    public class Hospital
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
