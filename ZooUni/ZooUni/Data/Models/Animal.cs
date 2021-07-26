using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooUni.Data.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Type { get; set; }
        //[Required]
        public string Name { get; set; }
        [Required]
        [Url]
        public string URL { get; set; }
        //[Required]
        public string Kind { get; set; }
        public int? HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

    }
}
