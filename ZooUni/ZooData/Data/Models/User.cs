using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Data.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
