using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static ZooUni.Data.ViewsConstants.Animal;

namespace ZooUni.Data.Models
{
    public class Animal
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        public string Type { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Url]
        [Required]
        public string URL { get; set; }

        [Required]
        public string Kind { get; set; }

        public int? HospitalId { get; set; }
        public Hospital Hospital { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

    }
}
