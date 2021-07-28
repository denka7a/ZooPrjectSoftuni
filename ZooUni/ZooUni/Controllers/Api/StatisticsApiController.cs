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
    public class StatisticsApiController : ControllerBase
    {
        private readonly ZooContext context;
        public StatisticsApiController(ZooContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public StatisticsResponseModel GetAnimals()
        {
            var totalAnimals = this.context.Animals.Count();
            var totalUsers = this.context.Users.Count();

            var statistics = new StatisticsResponseModel
            {
                TotalAnimals = totalAnimals,
                TotalUsers = totalUsers
            };

            return statistics;
        }
        //[Route("details")]  --> /api/animals/details
        //public IActionResult GetAnimal()  
        //{
        //}
    }
}
