using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ZooUni.Data.ViewsConstants.Owner;

namespace ZooUni.Data.Models
{
    public class Owner
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Information { get; set; }

        [Required]
        [Url]
        public string URL { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
