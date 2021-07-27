using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Models.Api.Animals;

namespace ZooUni.Controllers.Api
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalsApiController : ControllerBase
    {
        private readonly ZooContext context;
        public AnimalsApiController(ZooContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public AnimalsResponseModel GetAnimals()
        {
            var totalAnimals = this.context.Animals.Count();
            var totalUsers = this.context.Users.Count();

            var animals = new AnimalsResponseModel
            {
                TotalAnimals = totalAnimals,
                TotalUsers = totalUsers
            };

            return animals;
        }
        //[Route("details")]  --> /api/animals/details
        //public IActionResult GetAnimal()  
        //{
        //}
    }
}
