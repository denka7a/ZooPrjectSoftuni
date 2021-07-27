using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data.Models;
using static ZooUni.Data.ViewsConstants.Owner;


namespace ZooUni.Models
{
    public class OwnerViewModel
    {
        [Required]
        [StringLength(NameMaxLength), MinLength(NameMinLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(InformationMinLength)]
        public string Information { get; set; }

        [Url]
        public string URL { get; set; }

        public IEnumerable<AnimalViewModel> Animals { get; set; }
    }
}
