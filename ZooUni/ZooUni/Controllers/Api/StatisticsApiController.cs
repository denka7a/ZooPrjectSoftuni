using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;
using ZooUni.Models.Api.Animals;
using ZooUni.Services.Home;

namespace ZooUni.Controllers.Api
{
    [ApiController]
    [Route("api/animals")]
    public class StatisticsApiController : ControllerBase
    {
        private readonly IStatisticsService service;

        public StatisticsApiController(IStatisticsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public StatisticsResponseModel GetAnimals()
        {
            var data = this.service.GetAll();

            var statistics = new StatisticsResponseModel
            {
                TotalAnimals = data.TotalAnimals,
                TotalUsers = data.TotalUsers
            };

            return statistics;
        }
        //[Route("details")]  --> /api/animals/details
        //public IActionResult GetAnimal()  
        //{
        //}
    }
}
