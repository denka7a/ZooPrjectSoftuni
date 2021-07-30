using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Data.Models;
using ZooUni.Models;
using ZooUni.Services.Owner;

namespace ZooUni.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IOwnerService service;

        public OwnerController(IOwnerService service)
        {
            this.service = service;
        }

        [Authorize]
        public IActionResult All()
        {
            var owners = service.GetOwners();

            return View(owners);
        }
    }
}
