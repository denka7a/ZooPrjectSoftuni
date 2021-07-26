using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Data.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string URL { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
