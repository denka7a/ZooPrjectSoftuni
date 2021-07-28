using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooUni.Data;

namespace ZooUni.Services.Home
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ZooContext context;

        public StatisticsService(ZooContext context)
        {
            this.context = context;
        }

        public StatisticsServiceModel GetAll()
        {
            var allAnimals = context.Animals.Count();
            var allUsers = context.Users.Count();

            return new StatisticsServiceModel
            {
                TotalAnimals = allAnimals,
                TotalUsers = allUsers
            };
        }
    }
}
