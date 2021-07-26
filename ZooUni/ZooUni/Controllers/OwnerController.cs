using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;

namespace ZooUni.Controllers
{
    public class OwnerController : Controller
    {
        private readonly ZooContext zooContex;

        public OwnerController(ZooContext zooContext)
        {
            this.zooContex = zooContext;
        }

        public IActionResult All()
        {
            var owners = zooContex.Owners
                .Select(x => new OwnerViewModel
                {
                    Name = x.Name,
                    Information = x.Information,
                    Animals = x.Animals.Select(a => new AnimalViewModel
                    {
                        Name = a.Name,
                        URL = a.URL
                    })
                .ToList()
                }).ToList();

            return View(owners);
        }
    }
}
