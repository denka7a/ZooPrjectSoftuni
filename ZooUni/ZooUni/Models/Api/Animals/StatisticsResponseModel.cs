using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Models.Api.Animals
{
    public class StatisticsResponseModel
    {
        public int TotalAnimals { get; set; }
        public int TotalUsers { get; set; }
    }
}
