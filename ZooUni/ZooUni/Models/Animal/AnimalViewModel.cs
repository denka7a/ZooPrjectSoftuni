using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Models;
using static ZooUni.Data.ViewsConstants.Animal;

namespace ZooUni.Models
{
    public class AnimalViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(TypeMaxLength), MinLength(TypeMinLength)]
        public string Type { get; set; }

        [Required]
        [StringLength(NameMaxLength), MinLength(NameMinLength)]
        public string Name { get; set; }

        [Url]
        [Required]
        public string URL { get; set; }

        [Required]
        public string Kind { get; set; }
    }
}
